cmake_minimum_required(VERSION 3.0.0)

get_directory_property(hasParent PARENT_DIRECTORY)
if(hasParent)
    project(${PROJECT_NAME}-opcua)
else()
    # opcua is built standalone
    project(opcua)
endif()

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace Events Encryption)

set(OPCUA_DIR "${CMAKE_CURRENT_LIST_DIR}")
get_directory_property(hasParent PARENT_DIRECTORY)
if(hasParent)
    set(OPCUA_DIR "${CMAKE_CURRENT_LIST_DIR}" PARENT_SCOPE)
endif()

set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} ${CMAKE_CURRENT_LIST_DIR}/cmake)

add_library(${PROJECT_NAME}
    server/OpcUaServer.cpp
    # include/OpcUaServer.h
)

target_include_directories(${PROJECT_NAME} PUBLIC
    include
    include/spdlog/include
    $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>
)

target_link_libraries(${PROJECT_NAME}
    open62541::open62541
    config++
    pthread
)

# add_dependencies(${PROJECT_NAME}
#     open62541::open62541
# )

function(generate_certificate)
    set(options  )
    set(oneValueArgs TARGET_NAME HOSTNAME APP_URI OUTPUT_DIR)
    set(multiValueArgs )
    cmake_parse_arguments(GEN_CERT "${options}" "${oneValueArgs}" "${multiValueArgs}" ${ARGN} )
    
    if(NOT GEN_CERT_APP_URI OR "${GEN_CERT_APP_URI}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the APP_URI argument")
    endif()
    if(NOT GEN_CERT_OUTPUT_DIR OR "${GEN_CERT_OUTPUT_DIR}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the OUTPUT_DIR argument")
    endif()
    if(NOT GEN_CERT_TARGET_NAME OR "${GEN_CERT_TARGET_NAME}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the TARGET_NAME argument")
    endif()

    message("Generating certificate for ${GEN_CERT_APP_URI} - ${PYTHON_EXECUTABLE}")

    if (GEN_CERT_HOSTNAME)
        set(HOSTNAME "${GEN_CERT_HOSTNAME}")
    else()
        if (CUSTOM_HOSTNAME)
            set(HOSTNAME "${CUSTOM_HOSTNAME}")
        else()
            cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
        endif()
    endif()

    # add_custom_command(OUTPUT ${GEN_CERT_TARGET_NAME}
    #                    ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der
    #                    PRE_BUILD
    #                    COMMAND ${PYTHON_EXECUTABLE} ${OPCUA_DIR}/tools/create_self-signed.py
    #                    --application-uri=${GEN_CERT_APP_URI}
    #                    --key=4096
    #                    --hostname=${HOSTNAME}
    #                    ${GEN_CERT_OUTPUT_DIR}
    #                    DEPENDS
    #                    ${OPCUA_DIR}/tools/ssl_host.cnf
    #                    ${OPCUA_DIR}/tools/create_self-signed.py
    #                    )
    
    add_custom_command(OUTPUT ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_cert.der
                       ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der
                       PRE_BUILD
                       COMMAND ${PYTHON_EXECUTABLE} ${OPCUA_DIR}/tools/create_self-signed.py
                       --application-uri=${GEN_CERT_APP_URI}
                       --key=4096
                       --hostname=${HOSTNAME}
                       ${GEN_CERT_OUTPUT_DIR}
                       DEPENDS
                       ${OPCUA_DIR}/tools/ssl_host.cnf
                       ${OPCUA_DIR}/tools/create_self-signed.py
                       )

    add_custom_target(${GEN_CERT_TARGET_NAME}
                      DEPENDS
                      ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_cert.der
                      ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der)
endfunction()

enable_testing()
