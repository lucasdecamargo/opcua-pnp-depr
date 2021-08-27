#include <RTMarkerDetectionSkillImpl.h>

#include <device_model_nodeids.h>
#include <CompositeSkills.h>

#include <open62541/client_highlevel.h>
#include <types_device_model_generated.h>

#include <client/SkillHelper.hpp>

RTMarkerDetectionSkillImpl::RTMarkerDetectionSkillImpl(
    std::shared_ptr<spdlog::logger> _logger,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    CompositeSkills* compositeSkills
) : logger(std::move(_logger)), 
    loggerOpcua(std::move(_loggerOpcua)), 
    compositeSkills(compositeSkills)
{

}

RTMarkerDetectionSkillImpl::~RTMarkerDetectionSkillImpl()
{
    
}

bool RTMarkerDetectionSkillImpl::start(
    const std::string& cameraControllerEndpoints,
    const std::string& imageProcessorEndpoint
)
{
    logger->info("RTMarkerDetectionSkill called!");

    std::thread t = std::thread([this]()
    {
        std::this_thread::sleep_for(std::chrono::milliseconds(250));

        UA_StatusCode res = markerDetect();

        if(res != UA_STATUSCODE_GOOD)
            this->errored();
        else
            this->finished();
    });
    t.detach();

    return true;
}

UA_StatusCode RTMarkerDetectionSkillImpl::markerDetect()
{
    std::vector<std::shared_ptr<RegisteredSkill>> imageSkills;

    if(this->compositeSkills->cameraEndpoints.empty())
    {
        logger->error("No camera endpoints listed!");
        return UA_STATUSCODE_BADNOTFOUND;
    }

    {
        for(auto &e : this->compositeSkills->cameraEndpoints)
        {
            auto skills = this->compositeSkills->skillDetector->getSkillForEndpoint(e, "ImageFrameSkill");

            if(skills.size() == 1)
                imageSkills.push_back(skills.at(0));
        }

        if(imageSkills.empty())
        {
            logger->error("No image skill registered in any endpoint");
            return UA_STATUSCODE_BADNOTFOUND;
        }
    }

    for(auto &s : imageSkills)
    {
        if(const UA_StatusCode ret = pnp::skill::callSkillNoParameters(s, logger, loggerOpcua)
            != UA_STATUSCODE_GOOD)
        {
            logger->error("Could not call skill. {}", UA_StatusCode_name(ret));
        }
    }

    return UA_STATUSCODE_GOOD;
}

