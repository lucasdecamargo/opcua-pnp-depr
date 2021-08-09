#include <CompositeSkills.h>

#include <memory>
#include <chrono>
#include <CLI/CLI.hpp>
#include <libconfig.h++>

#include <spdlog/spdlog.h>
#include <logging.h>
#include <logging_opcua.h>
#include <helper.hpp>

std::shared_ptr<spdlog::logger> logger;

bool running = true;

static void stopHandler(int)
{
    logger->warn("Received Ctrl-C. Shutting down...");
    logger->flush();
    running = false;
}

int main(int argc, char* argv[])
{
    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    CLI::App app{"Composite Skills Server"};

    std::string configFile = "component.cfg";
    std::string certFiles;
    std::string clientCertFiles;
    app.add_option("--config", configFile, "Configuration file path");
    app.add_option("--certs-server", certFiles, "The server certificate files without extension");
    app.add_option("--certs-client", clientCertFiles, "The client certificate files without extension");

    CLI11_PARSE(app, argc, argv);

    libconfig::Config cfg;
    // Read the file. If there is an error, report it and exit.
    try {
        cfg.readFile(configFile.c_str());
    }
    catch (const libconfig::FileIOException& fioex) {
        std::cerr << "I/O error while reading configuration file." << fioex.what() << std::endl;
        return (EXIT_FAILURE);
    }
    catch (const libconfig::ParseException& pex) {
        std::cerr << "Configuration file parse error at " << pex.getFile() << ":" << pex.getLine()
                  << " - " << pex.getError() << std::endl;
        return (EXIT_FAILURE);
    }
    const libconfig::Setting& settings = cfg.getRoot();

    logger = pnp::log::LoggerFactory::createLogger("composite-skills",
                                                       settings["logging"]["level"]["app"],
                                                       settings["logging"].exists("path") ? settings["logging"]["path"] : "");

    
    std::shared_ptr<pnp::opcua::OpcUaServer> uaServer;

    int exitCode = EXIT_SUCCESS;

    try {
        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        if (settings["opcua"]["encryption"] && certFiles.empty()) {
            logger->error("Encryption is enabled but no certificates are given. Use --certs command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting Composite Skills ...");

        uaServer = std::make_shared<pnp::opcua::OpcUaServer>(
                settings,
                logger,
                "pnp.component.software.composite-skills",
                "Software - Composite Skills",
                certFiles,
                "pnp.component.software.composite-skills.client",
                "Software - Composite Skills - Client",
                clientCertFiles);


        std::string clientCert = clientCertFiles + "_cert.der";
        std::string clientKey = clientCertFiles + "_key.der";

        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        pnp::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);

        std::shared_ptr<CompositeSkills> compositeSkills = std::make_shared<CompositeSkills>(
                logger, loggerUa, uaServer, settings["composite_skills"], clientCert, clientKey,
                "pnp.component.software.composite-skills",
                "Software - Composite Skills");

        if (uaServer->init(
                true,
                std::bind(&CompositeSkills::onServerAnnounce, compositeSkills, std::placeholders::_1, std::placeholders::_1)
        ) == UA_STATUSCODE_GOOD) {

            while (running) {
                uaServer->iterate();
                std::this_thread::yield();
                std::this_thread::sleep_for(std::chrono::milliseconds(1));
            }
        }

    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file. {} -> {}", nfex.what(), nfex.getPath());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize component. {} ", rex.what());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    catch(...)
    {
        std::exception_ptr p = std::current_exception();
        std::clog <<(p ? p.__cxa_exception_type()->name() : "null") << std::endl;
    }
    uaServer.reset();

    spdlog::shutdown();
    return exitCode;
}
