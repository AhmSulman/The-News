# The News

A cross-platform news reader built with **.NET MAUI**. It's a later iteration of [News](https://github.com/AhmSulman/News) that adds local SQLite storage.

![.NET MAUI](https://img.shields.io/badge/.NET_MAUI-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=flat-square&logo=sqlite&logoColor=white)

## Features

- Headlines feed pulled from a news API
- Article detail view
- Local SQLite storage
- Shell navigation with an About page

## Structure

```
News/
  Models/NewsApiModels.cs   API response models
  Views/                    HeadlinesView, ArticleView, AboutView
  Navigator.cs, Settings.cs
```

## Build

Open `News.sln` in Visual Studio 2022 with the .NET MAUI workload installed. Set your news API key in `Settings.cs`, pick a target (Android, Windows, iOS or macOS) and run.

## License

GPL-3.0
