include(FetchContent)

FetchContent_Declare(
  googletest
  URL https://github.com/google/googletest/archive/refs/tags/release-1.11.0.zip
)

FetchContent_MakeAvailable(googletest)

enable_testing()

add_executable(hello_test
    hello_test.cpp
)
target_link_libraries(hello_test
    gtest_main
)
target_link_libraries(hello_test
    gtest_main
)

add_executable(utest
    test_cvdevice.cpp
)

target_link_libraries(utest
    gtest_main
    ${PROJECT_NAME}-lib
)

add_dependencies(utest
    ${PROJECT_NAME}
)

target_compile_definitions(utest PRIVATE
    IMG_LENA="${CMAKE_CURRENT_LIST_DIR}/lena.png"
)

include(GoogleTest)
gtest_discover_tests(hello_test)
gtest_discover_tests(utest)

