#include <Camera.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

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
    return UA_STATUSCODE_GOOD;
}

bool Camera::createNodesFromNodeset()
{
    return true;
}
