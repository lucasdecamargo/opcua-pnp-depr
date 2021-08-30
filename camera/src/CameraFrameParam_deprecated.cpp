#include <CameraFrameParam_deprecated.h>

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

CameraFrameParam::CameraFrameParam(
    std::shared_ptr<spdlog::logger> _loggerApp,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server
) : logger(_loggerApp),
    loggerOpcua(_loggerOpcua),
    server(server)
{ 

}

void CameraFrameParam::init()
{
    {
        LockedServer ls = server->getLocked();

        size_t nsIdx;
        UA_Server_getNamespaceByName(ls.get(), UA_String_fromChars(NAMESPACE_URI_CAMERA), &nsIdx);

        imageNodeId = UA_NODEID_NUMERIC(
            pnp::opcua::UA_Server_getNamespaceIdByName(
                ls.get(), NAMESPACE_URI_CAMERA),
                UA_CAMERAID_CAMERADEVICE_IMAGE
            );

        UA_NodeId headerNodeId;

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Header")),
            &headerNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            headerNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("SequenceID")),
            &headerSequenceIDNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            headerNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Stamp")),
            &headerStampNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            headerNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("FrameID")),
            &headerFrameIDNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Data")),
            &dataNodeId
        );
        
        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Step")),
            &stepNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Encoding")),
            &encodingNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Height")),
            &heightNodeId
        );

        pnp::opcua::UA_Server_findChildWithBrowseName(
            ls.get(),
            logger,
            imageNodeId,
            UA_QUALIFIEDNAME(static_cast<UA_UInt16>((UA_UInt16)nsIdx), const_cast<char*>("Width")),
            &widthNodeId
        );
    }
}

/*********************************************************************
 *                              SETTERS                              *
 *********************************************************************/ 
UA_StatusCode CameraFrameParam::setHeaderSequenceId(uint32_t value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &value, &UA_TYPES[UA_TYPES_UINT32]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), headerSequenceIDNodeId, v);
}

UA_StatusCode CameraFrameParam::setHeaderStamp(UA_DateTime value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &value, &UA_TYPES[UA_TYPES_DATETIME]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), headerStampNodeId, v);
}

UA_StatusCode CameraFrameParam::setHeaderFrameID(std::string value)
{
    UA_String str_val = UA_String_fromChars(value.c_str());
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &str_val, &UA_TYPES[UA_TYPES_STRING]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), headerFrameIDNodeId, v);
}

UA_StatusCode CameraFrameParam::setData(UA_ByteString value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, (UA_ImageBMP*)(&value), &UA_TYPES[UA_TYPES_IMAGEBMP]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), dataNodeId, v);
}

UA_StatusCode CameraFrameParam::setStep(uint32_t value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &value, &UA_TYPES[UA_TYPES_UINT32]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), stepNodeId, v);
}

UA_StatusCode CameraFrameParam::setEncoding(std::string value)
{
    UA_String str_val = UA_String_fromChars(value.c_str());
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &str_val, &UA_TYPES[UA_TYPES_STRING]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), encodingNodeId, v);
}

UA_StatusCode CameraFrameParam::setHeight(uint32_t value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &value, &UA_TYPES[UA_TYPES_UINT32]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), heightNodeId, v);
}

UA_StatusCode CameraFrameParam::setWidth(uint32_t value)
{
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &value, &UA_TYPES[UA_TYPES_UINT32]);
    LockedServer ls = server->getLocked();

    return UA_Server_writeValue(ls.get(), widthNodeId, v);
}


/*********************************************************************
 *                              GETTERS                              *
 *********************************************************************/ 
UA_StatusCode CameraFrameParam::getHeaderSequenceId(uint32_t &value)
{
    UA_Variant var;

    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), headerSequenceIDNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_UINT32]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_UInt32_copy((UA_UInt32*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getHeaderStamp(UA_DateTime &value)
{
    UA_Variant var;
    
    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), headerStampNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_DATETIME]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_DateTime_copy((UA_DateTime*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getHeaderFrameID(std::string &value)
{
    UA_Variant var;
    
    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), headerFrameIDNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_STRING]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_String str;
        UA_String_copy((UA_String*)var.data, &str);
        value = std::string((char*)str.data, str.length);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getData(UA_ByteString &value)
{
    UA_Variant var;
    
    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), dataNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_BYTESTRING]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_ByteString_copy((UA_ByteString*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getStep(uint32_t &value)
{
    UA_Variant var;

    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), stepNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_UINT32]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_UInt32_copy((UA_UInt32*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getEncoding(std::string &value)
{
    UA_Variant var;
    
    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), encodingNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_STRING]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_String str;
        UA_String_copy((UA_String*)var.data, &str);
        value = std::string((char*)str.data, str.length);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getHeight(uint32_t &value)
{
    UA_Variant var;

    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), heightNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_UINT32]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_UInt32_copy((UA_UInt32*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraFrameParam::getWidth(uint32_t &value)
{
    UA_Variant var;

    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = UA_Server_readValue(ls.get(), widthNodeId, &var);

         if (retval != UA_STATUSCODE_GOOD) return retval;
    }

    if(var.type != NULL) // else, value is not set
    {
        if(var.type != &UA_TYPES[UA_TYPES_UINT32]) return UA_STATUSCODE_BADTYPEMISMATCH;

        UA_UInt32_copy((UA_UInt32*)var.data, &value);
    }

    UA_Variant_clear(&var);

    return UA_STATUSCODE_GOOD;
}
