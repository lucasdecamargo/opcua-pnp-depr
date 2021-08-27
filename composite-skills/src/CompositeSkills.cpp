#include <CompositeSkills.h>

#include <string>
#include <unordered_set>

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

namespace aux
{
    template<typename T>
    void removeDuplicates(std::vector<T> &v)
    {
        typename std::vector<T>::iterator itr = v.begin();
        std::unordered_set<T> s;
    
        for (auto curr = v.begin(); curr != v.end(); ++curr)
        {
            if (s.insert(*curr).second) {
                *itr++ = *curr;
            }
        }
    
        v.erase(itr, v.end());
    }
}

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
        skillDetector(new SkillDetector(_loggerApp, _loggerOpcua, 
            clientCertPath, clientKeyPath, clientAppUri, clientName)),
        compositeSettings(compositeSettings),
        logger(std::move(_loggerApp)),
        loggerOpcua(std::move(_loggerOpcua)),
        server(server),
        clientCertPath(clientCertPath),
        clientKeyPath(clientKeyPath),
        clientAppUri(clientAppUri),
        clientName(clientName)        
{
    logger->info("Creating nodeset");
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize CompositeSkills nodeset");
    }

    logger->info("Initializing skills");
    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot initialize skills");
        throw pnp::opcua::StatusCodeException(retval);
    }
}

CompositeSkills::~CompositeSkills()
{
    delete skillDetector;
}

void CompositeSkills::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
)
{
    logger->info("Server announced! Name: "s + std::string((char*)serverOnNetwork->serverName.data)
        + " DiscoveryUrl: "s + std::string((char*)serverOnNetwork->discoveryUrl.data)
    );

    skillDetector->onServerAnnounce(serverOnNetwork, isServerAnnounce);

    std::string endpoint = (char*)serverOnNetwork->discoveryUrl.data;
    auto skills = skillDetector->getSkillForEndpoint(endpoint, "ImageFrameSkill");

    if(skills.size() == 1)
    {
        logger->info("Camera endpoint found!");
        cameraEndpoints.push_back(endpoint);
        aux::removeDuplicates<std::string>(cameraEndpoints);
    }
}

UA_StatusCode CompositeSkills::initSkills()
{
    UA_NodeId rtMarkerDetectionSkillId = UA_NODEID_NUMERIC
    (
        pnp::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_COMPOSITE_SKILLS),
        UA_COMPOSITE_SKILLSID_COMPOSITESKILLS_SKILLS_RTMARKERDETECTIONSKILL
    );

    rtMarkerDetectionSkillImpl = new RTMarkerDetectionSkillImpl(logger, loggerOpcua, this);

    rtMarkerDetectionSkill = std::make_unique<pnp::opcua::skill::composed::RTMarkerDetectionSkill>
                                (server, logger, rtMarkerDetectionSkillId, "RTMarkerDetectionSkill");
    rtMarkerDetectionSkill->setImpl
    (
        rtMarkerDetectionSkillImpl,
        [this]()
        {
            delete rtMarkerDetectionSkillImpl;
        }
    );

    rtMarkerDetectionSkill->transition(pnp::opcua::ProgramStateNumber::READY);

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