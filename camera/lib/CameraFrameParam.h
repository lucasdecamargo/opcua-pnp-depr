#ifndef PNP_CAMERAFRAMEPARAM_HPP
#define PNP_CAMERAFRAMEPARAM_HPP

#include <OpcUaServer.h>

class Camera;

class CameraFrameParam
{
public:
    friend class Camera;

    explicit CameraFrameParam(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server
    );

    void init();

    UA_StatusCode setHeaderSequenceId(uint32_t value);
    UA_StatusCode setHeaderStamp(UA_DateTime value);
    UA_StatusCode setHeaderFrameID(std::string value);

    UA_StatusCode setData();
    UA_StatusCode setStep(uint32_t value);
    UA_StatusCode setEncoding(std::string value);
    UA_StatusCode setHeight(uint32_t value);
    UA_StatusCode setWidth(uint32_t value);

    UA_StatusCode getHeaderSequenceId(uint32_t &value);
    UA_StatusCode getHeaderStamp(UA_DateTime &value);
    UA_StatusCode getHeaderFrameID(std::string &value);

    UA_StatusCode getData();
    UA_StatusCode getStep(uint32_t &value);
    UA_StatusCode getEncoding(std::string &value);
    UA_StatusCode getHeight(uint32_t &value);
    UA_StatusCode getWidth(uint32_t &value);

protected:
    UA_NodeId frameNodeId;

    UA_NodeId headerSequenceIDNodeId;
    UA_NodeId headerStampNodeId;
    UA_NodeId headerFrameIDNodeId;

    UA_NodeId dataNodeId;
    UA_NodeId stepNodeId;
    UA_NodeId encodingNodeId;
    UA_NodeId heightNodeId;
    UA_NodeId widthNodeId;

private:
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;
};

#endif