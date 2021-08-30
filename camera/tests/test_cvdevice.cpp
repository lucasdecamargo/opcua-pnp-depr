#include <gtest/gtest.h>

#include <CameraDeviceProperties.hpp>
#include <CvDevice.h>

#include <opencv2/imgcodecs.hpp>
#include <opencv2/imgproc/imgproc.hpp>

#include <open62541/util.h>
#include <types_pnp_types_generated_handling.h>

#include <iostream>

TEST(CvDevice, ImageReadPNG) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::PNG));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "PNG");

    std::vector<uint8_t> vec;
    EXPECT_TRUE(cv::imencode(".png", cv_img, vec));

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);

    EXPECT_EQ(vec.size(),ua_img.data.length);

    for(auto &v : vec)
    {
        EXPECT_EQ(v, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}

TEST(CvDevice, ImageReadBMP) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::BMP));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "BMP");

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));

    std::vector<uint8_t> vec;
    EXPECT_TRUE(cv::imencode(".bmp", cv_img, vec));

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);

    EXPECT_EQ(vec.size(),ua_img.data.length);

    for(auto &v : vec)
    {
        EXPECT_EQ(v, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}

TEST(CvDevice, ImageReadJPG) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::JPG));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "JPG");

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));

    std::vector<uint8_t> vec;
    EXPECT_TRUE(cv::imencode(".jpg", cv_img, vec));

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);

    EXPECT_EQ(vec.size(),ua_img.data.length);

    for(auto &v : vec)
    {
        EXPECT_EQ(v, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}

TEST(CvDevice, ImageReadBGR8) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::BGR8));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "BGR8");

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));
    cv_img.convertTo(cv_img, CV_8UC3);

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);
    uint8_t* cv_ptr = (uint8_t*)(&cv_img.data[0]);

    EXPECT_EQ(cv_img.elemSize() * cv_img.cols * cv_img.rows, ua_img.data.length);

    for(size_t i = 0; i < ua_img.data.length; i++)
    {
        EXPECT_EQ(*cv_ptr, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
        cv_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}

TEST(CvDevice, ImageReadMONO8) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::MONO8));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "MONO8");

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));
    cv_img.convertTo(cv_img, CV_8UC1);

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);
    uint8_t* cv_ptr = (uint8_t*)(&cv_img.data[0]);

    EXPECT_EQ(cv_img.elemSize() * cv_img.cols * cv_img.rows, ua_img.data.length);

    for(size_t i = 0; i < ua_img.data.length; i++)
    {
        EXPECT_EQ(*cv_ptr, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
        cv_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}

TEST(CvDevice, ImageReadBGR16) {
    std::string filename(IMG_LENA);
    CvDevice dev(filename);
    UA_ImageDataType ua_img;

    EXPECT_TRUE(dev.set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::BGR16));
    EXPECT_TRUE(dev.open());
    EXPECT_TRUE(dev.grab());
    EXPECT_TRUE(dev.retrieve(ua_img));
    EXPECT_STREQ((const char*)ua_img.encoding.data, "BGR16");

    cv::VideoCapture cv_cap;
    cv::Mat cv_img;

    EXPECT_TRUE(cv_cap.open(IMG_LENA));
    EXPECT_TRUE(cv_cap.grab());
    EXPECT_TRUE(cv_cap.retrieve(cv_img));
    cv_img.convertTo(cv_img, CV_16UC3);

    uint8_t* ua_ptr = (uint8_t*)(&ua_img.data.data[0]);
    uint8_t* cv_ptr = (uint8_t*)(&cv_img.data[0]);

    EXPECT_EQ(cv_img.elemSize() * cv_img.cols * cv_img.rows, ua_img.data.length);

    for(size_t i = 0; i < ua_img.data.length; i++)
    {
        EXPECT_EQ(*cv_ptr, *ua_ptr);
        ua_ptr += sizeof(uint8_t);
        cv_ptr += sizeof(uint8_t);
    }

    delete[] ua_img.data.data;
    delete[] ua_img.encoding.data;

    dev.release();
    cv_cap.release();
}
