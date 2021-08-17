#ifndef OPCUA_SKILLS_CAMERA_IMAGE_SKILL_H
#define OPCUA_SKILLS_CAMERA_IMAGE_SKILL_H

#include <SkillBase.hpp>
#include <functional>

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace camera{
                class ImageSkill : virtual public SkillBase
                {
                protected:
                    UA_StatusCode readParameters() override
                    {
                        return UA_STATUSCODE_GOOD;
                    }

                public:
                    explicit ImageSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                        : SkillBase(server, logger, skillNodeId, eventSourceName)
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }
                    }

                    void imageFinished()
                    {
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after camera has finished to ready");
                        }
                    }

                    void imageErrored()
                    {
                        if (!transition(ProgramStateNumber::HALTED)) {
                            logger->error("Failed to make transition after camera has finished to halted");
                        }
                    }
                };
            }
        }
    }
}

#endif