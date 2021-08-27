#ifndef PNP_RTMARKERDETECTIONSKILLIMPL_H
#define PNP_RTMARKERDETECTIONSKILLIMPL_H

#include <skills/composed/RTMarkerDetectionSkill.hpp>
#include<types_device_model_generated.h>

class CompositeSkills;

class RTMarkerDetectionSkillImpl
    : virtual public pnp::opcua::skill::composed::RTMarkerDetectionSkillImpl
{
private:
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;

    CompositeSkills *compositeSkills;

public:
    explicit RTMarkerDetectionSkillImpl(
        std::shared_ptr<spdlog::logger> _logger,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        CompositeSkills* compositeSkills
    );

    virtual ~RTMarkerDetectionSkillImpl();

protected:
    bool start(
        const std::string& cameraControllerEndpoints,
        const std::string& imageProcessorEndpoint
    ) override;

    bool halt() override { return false; };
    bool resume() override { return false; };
    bool suspend() override { return false; };
    bool reset() override { return false; };

    UA_StatusCode markerDetect();
};

#endif