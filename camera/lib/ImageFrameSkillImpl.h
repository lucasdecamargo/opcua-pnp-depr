#ifndef PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP
#define PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP

#include <OpcUaServer.h>
#include <skills/camera/ImageFrameSkill.hpp>
#include <CameraDevice.h>

class ImageFrameSkillImpl 
    : virtual public pnp::opcua::skill::camera::ImageFrameSkillImpl
{
private:
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;
    const std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<CameraDevice> device;
    UA_NodeId imageNodeId;

public:
    explicit ImageFrameSkillImpl(
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::shared_ptr<spdlog::logger>& logger,
        const std::shared_ptr<CameraDevice>& cameraDevice,
        UA_NodeId& imageNodeId
    );

    virtual ~ImageFrameSkillImpl() { }

    bool start() override;

    bool halt() override;

    bool resume() override;

    bool suspend() override;

    bool reset() override;

};

#endif