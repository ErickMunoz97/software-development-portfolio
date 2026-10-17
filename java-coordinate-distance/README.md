# Coordinate Distance Calculator (Java)

Reads a folder of text files containing x/y coordinate pairs, stores them as objects, and calculates Euclidean distances between each unique pair.

## Demonstrates

Java classes, collections, file I/O, parsing, nested iteration, and `Math.hypot`.

## Requirements

Java **17+** (uses records-era library methods such as `Stream.toList()`; no external dependencies).

## Run

```bash
javac Program1.java
java Program1 sample-data
```

Each non-empty input line should look like `3 4` or `-2.5 7.0`. Whitespace is accepted. Invalid lines are reported and skipped. If no path is given, the program reads `sample-data`.

## Notes

The original student source is preserved as a readable text file under `legacy/`. The cleaned current version adds error handling, more consistent output, and noninteractive execution with AI-assisted review. Distance calculation is tested with a known 3-4-5 case.
