#include <PnpSemanticMes.h>

#include <open62541/client_highlevel.h>

#include <string>

using namespace std::string_literals;

PnpSemanticMes::PnpSemanticMes(
        std::shared_ptr<spdlog::logger> _logger,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const libconfig::Setting& pnpSetting
) :
        SemanticMes(std::move(_logger), std::move(_loggerOpcua), server, clientCertPath, clientKeyPath),
        pnpSetting(pnpSetting)
{

}

PnpSemanticMes::~PnpSemanticMes() = default;

UA_StatusCode PnpSemanticMes::startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
)
{
    logger->info("[PnpSemanticMes] startExecution");

    return 0;
}
