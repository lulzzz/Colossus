# Aiursoft.Colossus

[![Build Status](https://travis-ci.org/AiursoftWeb/Developer.svg?branch=master)](https://travis-ci.org/AiursoftWeb/Developer)

Colossus is a file uploader and downloader as an OSS example application.

## How to run

**We strongly recommend running this app on Windows 10 or Windows Server 2016**

### Dependencies

* SQL Server LocalDb
* .NET Core 2.0 SDK

### Run with command

Please excuse the following commands in the project folder:

    set ASPNETCORE_ENVIRONMENT Development
    dotnet restore
    dotnet ef database update
    dotnet run

### Run in Visual Studio

Please install Visual Studio 2017 with .NET Core development kit.

1. Double click the `.sln` file.
2. Strike `F5`.

## How to publish

Please excuse the following commands in the project folder:

    set ASPNETCORE_ENVIRONMENT Production
    dotnet restore
    dotnet ef database update
    dotnet publish

If you have IIS installed already, just config the web path to:

    .\bin\Debug\netcoreapp2.0\publish

## How to contribute

There are many ways to contribute to the project: logging bugs, submitting pull requests, reporting issues, and creating suggestions.

Even if you have push rights on the repository, you should create a personal fork and create feature branches there when you need them. This keeps the main repository clean and your personal workflow cruft out of sight.

We're also interested in your feedback for the future of this project. You can submit a suggestion or feature request through the issue tracker. To make this process more effective, we're asking that these include more information to help define them more clearly.