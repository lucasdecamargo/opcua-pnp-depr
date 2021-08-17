#include <Camera.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_camera_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <camera_nodeids.h>

#define NAMESPACE_URI_CAMERA "https://pnp.org/UA/Camera/"

Camera::Camera(
    std::shared_ptr<spdlog::logger> _loggerApp,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const libconfig::Setting& cameraSettings
) :
    cameraSettings(cameraSettings),
    logger(std::move(_loggerApp)),
    loggerOpcua(std::move(_loggerOpcua)),
    server(server)
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Camera nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

Camera::~Camera()
{
    /* ... */
}

UA_StatusCode Camera::initSkills()
{
    UA_NodeId imageFrameSkillId;
    {
        LockedServer ls = server->getLocked();

        imageFrameSkillId = UA_NODEID_NUMERIC
        (
            pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_CAMERA),
                UA_CAMERAID_CAMERADEVICE_SKILLS_IMAGEFRAMESKILL
        );
    }

    imageFrameSkillImpl = new ImageFrameSkillImpl(logger, &device);

    imageFrameSkill = std::make_unique<pnp::opcua::skill::camera::ImageFrameSkill>
                        (server, logger, imageFrameSkillId, "ImageFrameSkill");
    imageFrameSkill->setImpl(imageFrameSkillImpl, [this](){ delete imageFrameSkillImpl; });
    imageFrameSkill->transition(pnp::opcua::ProgramStateNumber::READY);

    return UA_STATUSCODE_GOOD;
}

bool Camera::createNodesFromNodeset()
{
    LockedServer ls = server->getLocked();

    if(namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_device_model_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DeviceModel namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_camera_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the Camera namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}
