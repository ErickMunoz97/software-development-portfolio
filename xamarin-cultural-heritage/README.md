# Cultural Heritage Explorer — Xamarin.Forms

A Spanish-language educational mobile application for browsing cultural heritage landmarks across **seven countries**, with country menus and individual informational pages.

## Demonstrates

- C# and Xamarin.Forms/XAML screen implementation
- Button click events and navigation between pages
- Scrollable layouts, text content, Android drawable resources
- Organizing a multi-screen mobile project

## Build / run

Open `Patrimonios.sln` in an environment capable of compiling **legacy Xamarin.Forms 5**. Requires older Xamarin/Android tooling; Xamarin is no longer supported and this app was **not built in the current review environment**. Modernizing to .NET MAUI would be a separate project.

## Improvements during portfolio preparation

- Corrected **35** Back (`Volver`) handlers to call `Navigation.PopAsync()` instead of adding another page to the stack.
- Fixed a missing `.jpg` extension in one XAML image reference.
- Replaced original landmark photos of unknown redistribution rights with **29 newly generated placeholder images**. These are not real photographs of the landmarks.
- Removed build caches and Android APKs.

## Limitations

The content is largely static and repetitive; in a future rewrite I would store heritage data in a structured model and reuse fewer page templates. This repository documents earlier coursework and subsequent AI-assisted cleanup, not a production app.
