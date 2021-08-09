#ifndef PNP_BASE_SEMANTIC_MES_H
#define PNP_BASE_SEMANTIC_MES_H

#include <OpcUaServer.h>
#include <libconfig.h++>
#include <spdlog/spdlog.h>

class SemanticMes
{
public:
    explicit SemanticMes(
            std::shared_ptr<spdlog::logger> _loggerApp,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath
    );

    virtual ~SemanticMes();

    SemanticMes(const SemanticMes&) = delete;

    virtual UA_StatusCode startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
    );


    void start();

    void stop();

    void onServerRegister(const UA_RegisteredServer* registeredServer);

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

protected:
    virtual bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;

    virtual UA_StatusCode initSkills();

    UA_StatusCode triggerModelChangeEvent(UA_NodeId nodeId);

private:
    bool running = false;
};

#endif
