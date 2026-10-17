#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")"
javac Program1.java
work="$(mktemp -d)"
trap 'rm -rf "$work"; rm -f Program1*.class' EXIT
printf '0 0\n3 4\n' > "$work/two.txt"
java Program1 "$work" | grep -q '5.000'
echo 'PASS: pairwise distance 3-4-5'
