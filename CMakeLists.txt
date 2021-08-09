cmake_minimum_required(VERSION 3.0.0)
project(pnp-nodes VERSION 0.1.0)

include(CTest)
enable_testing()

set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++14")

add_definitions(
        -Wall
        -Wcast-qual
        -Wconversion
        -Werror
        -Wextra
        -Wformat
        -Wformat-security
        -Winit-self
        -Wmultichar
        -Wno-overlength-strings
        -Wno-unused-parameter
        -Wpointer-arith
        -Wstrict-overflow
        -Wuninitialized
        -fPIC
        -fvisibility=hidden
        -Wno-ignored-qualifiers
        -Wno-sign-conversion
        -pipe)

find_package(open62541 1.0 REQUIRED COMPONENTS FullNamespace Events Encryption Discovery DiscoveryMulticast)

find_package(CLI11 CONFIG REQUIRED)
include_directories($<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>)

add_subdirectory(nodeset)
add_subdirectory(include/opcua)
add_subdirectory(composite-skills)
add_subdirectory(semantic-mes)
add_subdirectory(camera)

add_executable(pnp-nodes 
    pnp-nodes.cpp
    # $<TARGET_OBJECTS:${PROJECT_NAME}-opcua>
)

# add_dependencies(pnp-nodes
#     ${PROJECT_NAME}-opcua
# )
target_link_libraries(pnp-nodes 
    pnp-nodes-opcua
)

add_dependencies(${PROJECT_NAME}
                 ${PROJECT_NAME}-nodeset)

target_include_directories(${PROJECT_NAME} INTERFACE
                           $<TARGET_PROPERTY:${PROJECT_NAME}-nodeset,INTERFACE_INCLUDE_DIRECTORIES>)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
