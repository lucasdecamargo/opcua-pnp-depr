#ifndef PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP
#define PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP

#include <skills/camera/ImageFrameSkill.hpp>
#include <CameraDevice.h>

class Camera;

class ImageFrameSkillImpl 
    : virtual public pnp::opcua::skill::camera::ImageFrameSkillImpl
{
private:
    const std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<CameraDevice> device;
    Camera* camera;

public:
    explicit ImageFrameSkillImpl(
        const std::shared_ptr<spdlog::logger>& logger,
        const std::shared_ptr<CameraDevice>& cameraDevice,
        Camera* camera
    );

    virtual ~ImageFrameSkillImpl() { }

    bool start() override;

    bool halt() override;

    bool resume() override;

    bool suspend() override;

    bool reset() override;

};

#endif