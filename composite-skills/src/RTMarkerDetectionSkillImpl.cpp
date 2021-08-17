#include <RTMarkerDetectionSkillImpl.h>

#include <device_model_nodeids.h>
#include <CompositeSkills.h>

#include <open62541/client_highlevel.h>
#include <types_device_model_generated.h>

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

        this->finished();
    });
    t.detach();

    return true;
}



