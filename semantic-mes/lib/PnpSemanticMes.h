#ifndef PNP_SEMANTIC_MES_H
#define PNP_SEMANTIC_MES_H

#include <SemanticMes.h>

class PnpSemanticMes: public SemanticMes
{
public:
    explicit PnpSemanticMes(
            std::shared_ptr<spdlog::logger> _logger,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const libconfig::Setting& pnpSetting
    );

    ~PnpSemanticMes() override;

    UA_StatusCode startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
    ) override;

private:
    const libconfig::Setting& pnpSetting;
};

#endif