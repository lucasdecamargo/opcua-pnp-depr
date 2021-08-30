#include <ImageFrameSkillImpl.h>
#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

ImageFrameSkillImpl::ImageFrameSkillImpl(
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const std::shared_ptr<spdlog::logger>& logger,
    const std::shared_ptr<CameraDevice>& cameraDevice,
    UA_NodeId& imageNodeId
)   
    : pnp::opcua::skill::camera::ImageFrameSkillImpl(),
        server(server),
        logger(logger),
        device(cameraDevice),
        imageNodeId(imageNodeId)
{
    // ...
}

bool ImageFrameSkillImpl::start()
{
    logger->info("Taking picture and saving it in Image/Data variable.");

    std::thread t = std::thread([this]()
    {
        UA_ImageDataType image;
        
        try
        {
            if(this->device->read(image))
            {

                UA_Variant v;
                UA_Variant_init(&v);
                UA_Variant_setScalar(&v, &image, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_IMAGEDATATYPE]);

                LockedServer ls = this->server->getLocked();
                UA_StatusCode ret = UA_Server_writeValue(ls.get(), this->imageNodeId, v);

                if(ret != UA_STATUSCODE_GOOD)
                    logger->error("Could not set ImageData param. Err: {}", UA_StatusCode_name(ret));
            }

            if(image.data.data != nullptr) delete[] image.data.data;
            if(image.encoding.data != nullptr) delete[] image.encoding.data;
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
