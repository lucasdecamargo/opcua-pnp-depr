#ifndef PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP
#define PNP_CAMERA_IMAGEFRAMESKILLIMPL_HPP

#include <skills/camera/ImageFrameSkill.hpp>
#include <CameraDevice.h>

class ImageFrameSkillImpl 
    : virtual public pnp::opcua::skill::camera::ImageFrameSkillImpl
{
private:
    const std::shared_ptr<spdlog::logger> logger;
    CameraDevice* device;

public:
    explicit ImageFrameSkillImpl(
        const std::shared_ptr<spdlog::logger>& logger,
        CameraDevice* cameraDevice
    )   
        : pnp::opcua::skill::camera::ImageFrameSkillImpl(),
          logger(logger),
          device(cameraDevice)
    {
        // ...
    }

    virtual ~ImageFrameSkillImpl() { }

    bool start() override
    {
        logger->info("Taking picture and saving it in LastImageFrame variable.");

        std::thread t = std::thread([this]()
        {
            std::this_thread::sleep_for(std::chrono::milliseconds(250));

            this->frameFinished();
        });

        t.detach();

        return true;
    }

    bool halt() override
    {
        return false;
    };

    bool resume() override
    {
        return false;
    };

    bool suspend() override
    {
        return false;
    };

    bool reset() override
    {
        return false;
    };

};

#endif