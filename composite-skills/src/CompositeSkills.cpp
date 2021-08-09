#include <CompositeSkills.h>

#include <string>

#include <helper.hpp>
#include <open62541/client.h>
#include <open62541/client_highlevel.h>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_composite_skills_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <composite_skills_nodeids.h>

using namespace std::string_literals;

CompositeSkills::CompositeSkills(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& compositeSettings,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientName
) :
        compositeSettings(compositeSettings),
        logger(std::move(_loggerApp)),
        loggerOpcua(std::move(_loggerOpcua)),
        server(server),
        clientCertPath(clientCertPath),
        clientKeyPath(clientKeyPath),
        clientAppUri(clientAppUri),
        clientName(clientName)
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize CompositeSkills nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

CompositeSkills::~CompositeSkills()
{
 /* ... */
}

void CompositeSkills::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
)
{
    logger->info("Server announced! Name: "s + std::string((char*)serverOnNetwork->serverName.data)
        + " DiscoveryUrl: "s + std::string((char*)serverOnNetwork->discoveryUrl.data)
    );
}

UA_StatusCode CompositeSkills::initSkills()
{
    return UA_STATUSCODE_GOOD;
}

bool CompositeSkills::createNodesFromNodeset()
{
    LockedServer ls = server->getLocked();

    if(namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_device_model_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DeviceModel namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_composite_skills_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the CompositeSkills namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}