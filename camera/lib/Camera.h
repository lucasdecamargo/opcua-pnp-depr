#ifndef PNP_CAMERA_H
#define PNP_CAMERA_H

#include <OpcUaServer.h>
#include <libconfig.h++>

#include <ImageFrameSkillImpl.hpp>
#include <CameraDevice.h>
#include <CameraFrameParam.h>

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

    CameraDevice device;
    ImageFrameSkillImpl *imageFrameSkillImpl{};
    std::unique_ptr<pnp::opcua::skill::camera::ImageFrameSkill> imageFrameSkill;

    CameraFrameParam cameraFrameParam;
};

#endif