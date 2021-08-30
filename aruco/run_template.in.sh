#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting ArUco component ..."
$<TARGET_FILE:aruco> --config ${CMAKE_CURRENT_LIST_DIR}/component.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/certs/client/${HOSTNAME} &
P_aruco=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_aruco
trap - SIGINT
wait $P_aruco
