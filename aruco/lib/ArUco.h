#ifndef PNP_ARUCO_H
#define PNP_ARUCO_H

#include <OpcUaServer.h>
#include <libconfig.h++>

class ArUco
{
public:
    explicit ArUco(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& arucoSettings
    );

    virtual ~ArUco();

    ArUco(const ArUco&) = delete;

    const libconfig::Setting& arucoSettings;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;
};

#endif