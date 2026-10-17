# Sorting Algorithm Analysis (Java)

Compares **insertion, bubble, merge, heap and quick sort** using repeatable random inputs, records key comparisons, and exports a simple CSV for charts.

## Requirements

Java **17+**, no external packages.

## Run and test

```bash
javac SortCounter.java SortCounterTest.java
java SortCounterTest
java SortCounter
```

The program writes `results.csv` with `algorithm,size,key_comparisons,sorted`. To choose an output location: `java SortCounter output.csv`.

## Methodology

All algorithms receive copies of the same input at each size. Random inputs have a fixed seed, and comparisons are counted whenever two array elements (or an element and a pivot/key) are compared. These are **operation counts, not execution times**, and different implementations count only the operations defined in the code. Every result is checked for sorted order.

## Attribution and project evolution

The initial coursework explored the same five sorting algorithms and generated CSV data. The **original is retained in `legacy/`**. The current implementation is a clearly identified AI-assisted refactor to fix sorting and counter issues and provide repeatable tests. Do not present the refactor as code written without assistance.
