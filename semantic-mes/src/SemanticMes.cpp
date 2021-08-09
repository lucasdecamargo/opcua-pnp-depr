#include <SemanticMes.h>

#include <string>
#include <utility>

#include <helper.hpp>
#include <open62541/client_highlevel.h>
#include <open62541/client_config_default.h>
#include <open62541/server.h>
#include <logging_opcua.h>

using namespace std::string_literals;

SemanticMes::SemanticMes(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath
) :
        logger(std::move(_loggerApp)),
        loggerOpcua(std::move(_loggerOpcua)),
        server(server)
{

    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Semantic MES nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);

}

SemanticMes::~SemanticMes()
{
    stop();
}

bool SemanticMes::createNodesFromNodeset()
{
    return true;
}

void SemanticMes::start()
{
    if (running)
        return;
    running = true;
    // executeProcessSkill->transition(pnp::opcua::ProgramStateNumber::READY);
}

void SemanticMes::stop()
{
    running = false;
    // executeProcessSkill->transition(pnp::opcua::ProgramStateNumber::HALTED);
}

UA_StatusCode SemanticMes::startExecution(
        const std::string& abstractProcessIri,
        const std::string& executionMode
)
{
    return UA_STATUSCODE_BADNOTIMPLEMENTED;
}

UA_StatusCode SemanticMes::initSkills()
{
    return UA_STATUSCODE_GOOD;
}

void SemanticMes::onServerRegister(const UA_RegisteredServer* registeredServer)
{
    /* ... */
    logger->info("[SemanticMes] onServerRegister");
}

void SemanticMes::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
)
{
    /* ... */
    logger->info("Server announced! Name: "s + std::string((char*)serverOnNetwork->serverName.data)
        + " DiscoveryUrl: "s + std::string((char*)serverOnNetwork->discoveryUrl.data)
    );
}

UA_StatusCode SemanticMes::triggerModelChangeEvent(UA_NodeId nodeId) {
    UA_NodeId eventId;

    LockedServer ls = server->getLocked();

    UA_StatusCode retval = UA_Server_createEvent(ls.get(), UA_NODEID_NUMERIC(0, UA_NS0ID_BASEMODELCHANGEEVENTTYPE), &eventId);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("createEvent failed: {}", UA_StatusCode_name(retval));
        return retval;
    }

    /* Set the Event Attributes */
    /* Setting the Time is required or else the event will not show up in UAExpert! */
    UA_DateTime eventTime = UA_DateTime_now();
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Time")),
                                         &eventTime,
                                         &UA_TYPES[UA_TYPES_DATETIME]);

    UA_UInt16 eventSeverity = 100;
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Severity")),
                                         &eventSeverity,
                                         &UA_TYPES[UA_TYPES_UINT16]);

    UA_LocalizedText eventMessage = UA_LOCALIZEDTEXT(const_cast<char*>("en-US"),
                                                     const_cast<char*>("The model changed"));
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Message")),
                                         &eventMessage,
                                         &UA_TYPES[UA_TYPES_LOCALIZEDTEXT]);

    return UA_Server_triggerEvent(ls.get(),
                                  eventId,
                                  nodeId,
                                  NULL, UA_TRUE);

}
