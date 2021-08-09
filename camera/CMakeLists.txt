cmake_minimum_required(VERSION 3.0.0)
project(camera)

set(DEPS_INCLUDE_DIR "../include")
set(DEPS_LIBRARY_DIR "pnp-nodes-opcua")

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace Events Encryption)
find_package(CLI11 CONFIG REQUIRED)

generate_certificate(
        TARGET_NAME "camera-certs-server"
        APP_URI "pnp.component.camera"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/server"
)

generate_certificate(
        TARGET_NAME "camera-certs-client"
        APP_URI "pnp.component.camera.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/client"
)

add_executable(${PROJECT_NAME}
    src/main.cpp
    src/Camera.cpp
)

target_include_directories(${PROJECT_NAME} PUBLIC
    lib
    $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>
    $<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>
    ${DEPS_INCLUDE_DIR}
)

target_link_libraries(${PROJECT_NAME}
    open62541::open62541
    CLI11::CLI11
    config++
    ${DEPS_LIBRARY_DIR}
)

add_dependencies(${PROJECT_NAME}
    camera-certs-server
    camera-certs-client
)

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${PROJECT_BINARY_DIR}/run.sh" INPUT "${PROJECT_BINARY_DIR}/.run_tmp.sh")
configure_file("run_template.in.sh" "${PROJECT_BINARY_DIR}/.run_tmp.sh")
