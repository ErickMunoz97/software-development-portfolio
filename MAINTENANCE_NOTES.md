# Maintenance and verification notes — October 2026

## Source archive review

The archive contains many beginner C# console exercises, sorting variants, Java assignments, SQL examples, a WPF customer management project, two Xamarin projects, a C# dice-game exercise, and R statistics coursework. Several versions and build outputs are duplicates. This repository presents five distinct projects with the best mix of depth and range.

## Changes after original coursework

- Removed build outputs, machine-specific paths, old archive files and unrelated generated files.
- **Java coordinates:** more robust input handling, optional command-line directory argument, locale-independent formatting, included sample data, and a smoke test.
- **Java sorting:** kept the earlier source in `legacy/`, prepared a clean reproducible implementation and test runner, and labeled those changes clearly.
- **Xamarin calculator:** defensive input validation and handling of division by zero; sample (not live) exchange rate.
- **Xamarin heritage:** changed `Volver` navigation handlers to pop the current page rather than repeatedly stacking pages; fixed an image filename; substituted newly generated placeholders for unsourced photographs.
- **WPF/SQL:** repaired the misspelled update table, parameterized update key, removed the old device name and hard-coded background image path, added an example schema and setup notes.

## What was verified

- Java compile and run checks and XML/XAML parsing are recorded in `VERIFICATION.md`.
- C# Xamarin and WPF solutions could not be compiled in the current environment, so **do not claim a successful build**.
- These are portfolio examples, not production-ready applications.
