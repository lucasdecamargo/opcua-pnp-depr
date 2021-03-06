cmake_minimum_required(VERSION 3.0.0)
project(composite-skills)

set (DEPS_NODE "pnp-nodes-opcua")
set(DEPS_INCLUDE_DIR "../include")
set(DEPS_LIBRARY_DIR "pnp-nodes-opcua")

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace Events Encryption)
find_package(CLI11 CONFIG REQUIRED)

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-client")
file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "di"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${open62541_NODESET_DIR}/DI/OpcUaDiModel.csv"
        FILE_BSD "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "2:http://opcfoundation.org/UA/DI/"
        FILE_NS "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.NodeSet2.xml"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "device_model"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/../nodeset/DeviceModel/Published/DeviceModel/DeviceModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/../nodeset/DeviceModel/Published/DeviceModel/fortiss_Device.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "3:https://fortiss.org/UA/Device/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/../nodeset/DeviceModel/Published/DeviceModel/fortiss_Device.NodeSet2.xml"
        DEPENDS "di"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "composite_skills"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/model/Published/CompositeSkillsModel/CompositeSkillsModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/model/Published/CompositeSkillsModel/CompositeSkills.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "4:https://pnp.org/UA/CompositeSkills/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/model/Published/CompositeSkillsModel/CompositeSkills.NodeSet2.xml"
        DEPENDS "device_model"
        INTERNAL
)

generate_certificate(
        TARGET_NAME "composite-skills-certs-server"
        APP_URI "pnp.component.software.composite-skills"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/server"
)

generate_certificate(
        TARGET_NAME "composite-skills-certs-client"
        APP_URI "pnp.component.software.composite-skills.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/client"
)

add_executable(${PROJECT_NAME}
    ${UA_NODESET_DI_SOURCES}
    ${UA_TYPES_DI_SOURCES}
    ${UA_NODESET_DEVICE_MODEL_SOURCES}
    ${UA_TYPES_DEVICE_MODEL_SOURCES}
    ${UA_NODESET_COMPOSITE_SKILLS_SOURCES}
    ${UA_TYPES_COMPOSITE_SKILLS_SOURCES}
    src/main.cpp
    src/CompositeSkills.cpp
    src/RTMarkerDetectionSkillImpl.cpp
)

target_include_directories(${PROJECT_NAME} PUBLIC
    lib
    ${GENERATE_OUTPUT_DIR}
    $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>
    $<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>
    ${DEPS_INCLUDE_DIR}
)

target_link_libraries(${PROJECT_NAME}
    open62541::open62541
    CLI11::CLI11
    config++
    ${DEPS_LIBRARY_DIR}
    ${DEPS_LIBRARY_DIR}-client
)

add_dependencies(${PROJECT_NAME}
    ${DEPS_NODE}
    ${DEPS_NODE}-client
    composite-skills-ns-composite_skills
    composite-skills-certs-server
    composite-skills-certs-client
)

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${PROJECT_BINARY_DIR}/run.sh" INPUT "${PROJECT_BINARY_DIR}/.run_tmp.sh")
configure_file("run_template.in.sh" "${PROJECT_BINARY_DIR}/.run_tmp.sh")
