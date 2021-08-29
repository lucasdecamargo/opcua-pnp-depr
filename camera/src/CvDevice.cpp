#include <CvDevice.h>
#include <CameraDeviceProperties.hpp>

#include <opencv2/imgcodecs.hpp>
#include <opencv2/imgproc/imgproc.hpp>

#include <open62541/util.h>

#include <map>

#include <iostream>


std::map<CameraDeviceEncoders,int> encToCv
{
    {CameraDeviceEncoders::BGR8, CV_8UC3},
    {CameraDeviceEncoders::MONO8, CV_8UC1},
    {CameraDeviceEncoders::RGB8, CV_8UC3},
    {CameraDeviceEncoders::MONO16, CV_16UC1},
    {CameraDeviceEncoders::BGR16, CV_16UC3},
    {CameraDeviceEncoders::RGB16, CV_16UC3},
    {CameraDeviceEncoders::BGRA8, CV_8UC4},
    {CameraDeviceEncoders::RGBA8, CV_8UC4},
    {CameraDeviceEncoders::BGRA16, CV_16UC4},
    {CameraDeviceEncoders::RGBA16, CV_16UC4},
    {CameraDeviceEncoders::BAYER_RGGB8, CV_8UC1},
    {CameraDeviceEncoders::BAYER_BGGR8, CV_8UC1},
    {CameraDeviceEncoders::BAYER_GBRG8, CV_8UC1},
    {CameraDeviceEncoders::BAYER_GRBG8, CV_8UC1},
    {CameraDeviceEncoders::BAYER_RGGB16, CV_16UC1},
    {CameraDeviceEncoders::BAYER_BGGR16, CV_16UC1},
    {CameraDeviceEncoders::BAYER_GBRG16, CV_16UC1},
    {CameraDeviceEncoders::BAYER_GRBG16, CV_16UC1},
    {CameraDeviceEncoders::YUV422, CV_8UC2}
};

std::map<int,CameraDeviceEncoders> cvToEnc
{
    {CV_8UC3, CameraDeviceEncoders::BGR8},
    {CV_8UC1, CameraDeviceEncoders::MONO8},
    {CV_8UC3, CameraDeviceEncoders::RGB8},
    {CV_16UC1, CameraDeviceEncoders::MONO16},
    {CV_16UC3, CameraDeviceEncoders::BGR16},
    {CV_16UC3, CameraDeviceEncoders::RGB16},
    {CV_8UC4, CameraDeviceEncoders::BGRA8},
    {CV_8UC4, CameraDeviceEncoders::RGBA8},
    {CV_16UC4, CameraDeviceEncoders::BGRA16},
    {CV_16UC4, CameraDeviceEncoders::RGBA16},
    {CV_8UC1, CameraDeviceEncoders::BAYER_RGGB8},
    {CV_8UC1, CameraDeviceEncoders::BAYER_BGGR8},
    {CV_8UC1, CameraDeviceEncoders::BAYER_GBRG8},
    {CV_8UC1, CameraDeviceEncoders::BAYER_GRBG8},
    {CV_16UC1, CameraDeviceEncoders::BAYER_RGGB16},
    {CV_16UC1, CameraDeviceEncoders::BAYER_BGGR16},
    {CV_16UC1, CameraDeviceEncoders::BAYER_GBRG16},
    {CV_16UC1, CameraDeviceEncoders::BAYER_GRBG16},
    {CV_8UC2, CameraDeviceEncoders::YUV422}
};

std::map<CameraDeviceEncoders, std::string> encToStr
{
    {CameraDeviceEncoders::BMP, "BMP"},
    {CameraDeviceEncoders::JPG, "JPG"},
    {CameraDeviceEncoders::PNG, "PNG"},
    {CameraDeviceEncoders::GIF, "GIF"}
};


CvDevice::CvDevice(const std::string &filename, int apiPreference)
    : filename(filename), apiPreference(apiPreference), index(-1)
{

}

CvDevice::CvDevice(int index, int apiPreference)
    : apiPreference(apiPreference), index(index)
{

}

CvDevice::~CvDevice()
{

}

bool CvDevice::retrieve(UA_ByteString &image, int flag)
{
    std::cout << "isOpened: " << isOpened() << std::endl;
    if(!isOpened()) return false;

    std::cout << "CV Retrieving" << std::endl;
    cv::Mat cv_out;
    if(!this->cv::VideoCapture::retrieve(cv_out, flag))
        return false;

    
    if(format != -1) return _retrieve_file_encoding(image, cv_out, format);

    std::cout << "Normal encoding" << std::endl;
    size_t step = cv_out.cols * cv_out.elemSize();
    size_t size = step * cv_out.rows;


    if(image.data != nullptr) delete[] image.data;
    image.length = size;
    image.data = new UA_Byte[size];

    if(cv_out.isContinuous()) 
        memcpy(image.data, cv_out.data, size);
    
    else
    {
        // Copy row by row
        uchar* data_ptr = (uchar*)(&image.data[0]);
        uchar* cv_ptr = cv_out.data;
        for(int i = 0; i < cv_out.rows; i++)
        {
            memcpy(data_ptr, cv_ptr, step);
            data_ptr += step;
            cv_ptr += step;
        }
    }

    return true;
}

bool CvDevice::_retrieve_file_encoding(UA_ByteString &image, cv::Mat &m, int fmt)
{
    if(format == -1) return false;

    std::cout << "File encoding" << std::endl;

    std::vector<uchar> vec;
    cv::imencode("." + encToStr[(CameraDeviceEncoders)fmt], m, vec);

    std::cout << "Assigning image" << std::endl;

    if(image.data != nullptr) delete[] image.data;
    image.length = vec.size();
    image.data = new UA_Byte[image.length];
    std::copy(vec.begin(), vec.end(), image.data);

    std::cout << "Returning true" << std::endl;

    return true;
}

bool CvDevice::read(UA_ByteString &image)
{
    std::cout << "Grabing" << std::endl;
    grab();
    std::cout << "Calling retrieving func" << std::endl;
    return retrieve(image);
}

bool CvDevice::open()
{
    if(index != -1) return this->cv::VideoCapture::open(index, apiPreference);
    else return this->cv::VideoCapture::open(filename, apiPreference);
}

double CvDevice::get(int propId) const
{
    if(propId == CameraDeviceProperties::CAP_PROP_FORMAT)
    {
        if(format != -1)
            return cvToEnc[(int)this->cv::VideoCapture::get(propId)];
        else return format;
    }
    else
        return this->cv::VideoCapture::get(propId);
}

bool CvDevice::set(int propId, double value)
{
    if(propId == CameraDeviceProperties::CAP_PROP_FORMAT)
    {
        if(value > (int)CameraDeviceEncoders::FILEENCODING)
            format = (int)value;
        else
        {
            format = -1;
            return this->cv::VideoCapture::set(propId, encToCv[(CameraDeviceEncoders)value]);
        }
    }
    else
        return this->cv::VideoCapture::set(propId, value);

    return true;
}

void CvDevice::release()
{
    return this->cv::VideoCapture::release();
}

bool CvDevice::isOpened() const
{
    return this->cv::VideoCapture::isOpened();
}


bool CvDevice::grab()
{
    return this->cv::VideoCapture::grab();
}
