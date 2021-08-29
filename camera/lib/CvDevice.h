#ifndef PNP_CVDEVICE_HPP
#define PNP_CVDEVICE_HPP

#include <CameraDevice.h>
#include <opencv2/core.hpp>
#include <opencv2/videoio.hpp>

class CvDevice : public CameraDevice, public cv::VideoCapture
{
public:
    // using cv::VideoCapture::grab;
    // using cv::VideoCapture::isOpened;
    // using cv::VideoCapture::release;
    // using cv::VideoCapture::get;
    // using cv::VideoCapture::set;

    /**
     * Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
     */ 
    CvDevice(const std::string &filename, int apiPreference=cv::CAP_ANY);
    /**
     * Opens a camera for video capturing
     */ 
    CvDevice(int index=0, int apiPreference=cv::CAP_ANY);

    virtual ~CvDevice();

    bool retrieve(UA_ByteString &image, int flag = 0);
    bool read(UA_ByteString &image);
    bool open();
    /**
     * Closes the capturing device
     */ 
    void release();
    /**
     * Returns true if video capturing has been initialized already
     */ 
    bool isOpened() const;

    /**
     * Grabs the next frame from capturing device.
     */ 
    bool grab();

    /**
     * Returns the specified CameraDevice property
     */ 
    double get(int propId) const;
    /**
     * Sets a property in the CameraDevice property
     */ 
    bool set(int propId, double value);

private:
    std::string filename;
    int apiPreference;
    int index;
    int format = -1;

    bool _retrieve_file_encoding(UA_ByteString &image, cv::Mat &m, int fmt);
};

#endif
