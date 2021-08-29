#ifndef PNP_CAMERADEVICE_H
#define PNP_CAMERADEVICE_H

#include <open62541/types.h>

class CameraDevice
{
public:
    CameraDevice();

    CameraDevice(const CameraDevice&) = delete;

    virtual ~CameraDevice();

    
    /**
     * Grabs the next frame from capturing device.
     */ 
    virtual bool grab();

    /**
     * Decodes and returns the grabbed video frame.
     * grab() must be called first.
     */
    virtual bool retrieve(UA_ByteString &image, int flag = 0) = 0;

    /**
     * Grabs, decodes and returns the next video frame.
     */ 
    virtual bool read(UA_ByteString &image);

    /**
     * Opens the capture device
     */ 
    virtual bool open();
    /**
     * Closes the capturing device
     */ 
    virtual void release();
    /**
     * Returns true if video capturing has been initialized already
     */ 
    virtual bool isOpened() const;

    /**
     * Returns the specified CameraDevice property
     */ 
    virtual double get(int propId) const;
    /**
     * Sets a property in the CameraDevice property
     */ 
    virtual bool set(int propId, double value);
};

#endif