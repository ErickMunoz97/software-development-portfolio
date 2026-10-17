# Xamarin Calculator and Currency Converter

A Spanish-language **Xamarin.Forms** student mobile app with two screens: arithmetic calculator and a peso/US-dollar converter.

## Demonstrates

C# event handlers, XAML views, page navigation, arithmetic methods, conditional logic, and validation of text input.

## Prerequisites / open project

Legacy Xamarin.Forms and an appropriate Windows/macOS development environment with older Xamarin tooling and Android workload. Open `App1.sln`. **Xamarin support ended in 2024**, so modern machines may require migration to .NET MAUI; this version is preserved to show original coursework.

## Behavior

- Calculator: +, -, multiplication, division, percent, clear, backspace.
- Converter: manual input and a **fixed example rate of 19.30 MXN per 1 USD**. This is **not** a live foreign-exchange quotation.
- Blank/invalid amounts are rejected; dividing by zero produces an explanatory alert.

## Maintained from original coursework

Source, XAML layouts and initial behavior are based on my earlier class project. Input validation, error handling, and documentation were improved with AI assistance in October 2026. I have **not verified the complete Android build in the current environment**.
