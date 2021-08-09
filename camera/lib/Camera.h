#ifndef PNP_CAMERA_H
#define PNP_CAMERA_H

#include <OpcUaServer.h>
#include <libconfig.h++>

class Camera
{
public:
    explicit Camera(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& cameraSettings
    );

    virtual ~Camera();

    Camera(const Camera&) = delete;

    const libconfig::Setting& cameraSettings;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;
};

#endif