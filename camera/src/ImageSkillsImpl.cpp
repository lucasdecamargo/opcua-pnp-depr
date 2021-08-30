#include <ImageFrameSkillImpl.h>
#include <Camera.h>

ImageFrameSkillImpl::ImageFrameSkillImpl(
    const std::shared_ptr<spdlog::logger>& logger,
    const std::shared_ptr<CameraDevice>& cameraDevice,
    Camera* camera
)   
    : pnp::opcua::skill::camera::ImageFrameSkillImpl(),
        logger(logger),
        device(cameraDevice),
        camera(camera)
{
    // ...
}

bool ImageFrameSkillImpl::start()
{
    logger->info("Taking picture and saving it in Image/Data variable.");

    std::thread t = std::thread([this]()
    {
        UA_ByteString data;
        data.data = nullptr;
        
        try
        {
            if(this->device->read(data))
            {
                UA_StatusCode ret = this->camera->cameraFrameParam.setData(data);

                if(ret != UA_STATUSCODE_GOOD)
                    logger->error("Could not set ImageData param. Err: {}", UA_StatusCode_name(ret));
            }

            if(data.data != nullptr) delete[] data.data;
        }
        catch(const std::exception& e)
        {
            logger->critical("When trying to read frame, raised exception: {}", e.what());
        }        

        this->frameFinished();
    });

    t.detach();

    return true;
}

bool ImageFrameSkillImpl::halt()
{
    return false;
};

bool ImageFrameSkillImpl::resume()
{
    return false;
};

bool ImageFrameSkillImpl::suspend()
{
    return false;
};

bool ImageFrameSkillImpl::reset()
{
    return false;
};
