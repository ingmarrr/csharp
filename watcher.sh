#!/bin/zsh/

# Watcher for the file system
# This script will watch the file system for changes and then run the
# appropriate scripts to update the database and the web site.

DIR="./public"

fswatch -o "$DIR" | while read num; do
  if [ $# -eq 0 ]; then
    echo "Usage: $0 <port-number>"
    exit 1
  fi

  PORT=$1
  PID=$(lsof -ti tcp:$PORT)

  if [ ! -z "$PID" ]; then
    echo "Killing process on port $PORT with PID $PID"
    kill $PID
  else
    echo "No process found on port $PORT"
  fi
  bun run http-server -c-1
done




