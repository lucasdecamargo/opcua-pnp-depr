#ifndef PNP_COMPOSITE_SKILLS_H
#define PNP_COMPOSITE_SKILLS_H

#include <OpcUaServer.h>
#include <libconfig.h++>

class CompositeSkills
{
public:
    explicit CompositeSkills(
            std::shared_ptr<spdlog::logger> _loggerApp,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
            const libconfig::Setting& compositeSettings,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const std::string& clientAppUri,
            const std::string& clientName
    );

    virtual ~CompositeSkills();

    CompositeSkills(const CompositeSkills&) = delete;

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

    const libconfig::Setting& compositeSettings;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;

    const std::string clientCertPath;
    const std::string clientKeyPath;
    const std::string clientAppUri;
    const std::string clientName;

};

#endif