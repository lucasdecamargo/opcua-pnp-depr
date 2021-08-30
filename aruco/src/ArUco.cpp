#include <ArUco.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_pnp_types_generated.h>
#include <namespace_aruco_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <pnp_types_nodeids.h>
#include <aruco_nodeids.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

#define NAMESPACE_URI_CAMERA "https://pnp.org/UA/ArUco/"

ArUco::ArUco(
    std::shared_ptr<spdlog::logger> _loggerApp,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const libconfig::Setting& arucoSettings
) :
    arucoSettings(arucoSettings),
    logger(std::move(_loggerApp)),
    loggerOpcua(std::move(_loggerOpcua)),
    server(server)
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize ArUco nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

ArUco::~ArUco()
{
    /* ... */
}

UA_StatusCode ArUco::initSkills()
{
    return UA_STATUSCODE_GOOD;
}

bool ArUco::createNodesFromNodeset()
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

    if(namespace_pnp_types_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the PnPTypes namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_aruco_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the ArUco namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}