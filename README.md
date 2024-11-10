<p align="center">
  <a href="https://wiki.redmodding.org/wolvenkit"><img src="https://user-images.githubusercontent.com/65016231/191120204-c8e08bb2-d68b-4919-91ec-f8c1aaef1e6a.png"/></a><br /><br />
</p>

![GitHub Release Date](https://img.shields.io/github/release-date/WolvenKit/WolvenKit)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/WolvenKit/WolvenKit/check-only.yml)
![GitHub milestone](https://img.shields.io/github/milestones/progress/WolvenKit/WolvenKit/12)
![GitHub all releases](https://img.shields.io/github/downloads/WolvenKit/WolvenKit/total)
![GitHub issues](https://img.shields.io/github/issues/WolvenKit/WolvenKit)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/WolvenKit/WolvenKit)
<a href="https://discord.gg/cp77modding"><img src="https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2"></a>

> ⚠️ This repository focuses on REDengine 4 for Cyberpunk 2077. For WolvenKit for <em>The Witcher 3: Wild Hunt</em> please see: https://github.com/WolvenKit/WolvenKit-7

WolvenKit is an open-source modding tool for <em>Cyberpunk 2077</em>. Our vision is to develop a standalone software which is capable of reading and writing all REDengine file formats. Additionally the WolvenKit application is designed to simplify and accelerate modding workflows. 
This repository was created to demonstrate how <a href="https://en.wikipedia.org/wiki/CD_Projekt">CDPR</a>'s proprietary <a href="https://en.wikipedia.org/wiki/CD_Projekt#REDengine"><strong>REDengine</strong></a> reads and writes file formats. 

This toolkit is being made solely for research and educational purposes, and the dev team is in no way responsible for any malfunctions that occur from its use.
It's completely open source, licensed under the <a href="https://github.com/WolvenKit/WolvenKit/blob/main/LICENSE">GPL-3.0</a>, and in no way is it made to generate revenue.
  
---
  
<h3 align="center">
  <a href="#installation">Installation</a> •
  <a href="#usage">Usage</a> •
  <a href="#contributing">Contributing</a> •
  <a href="#screenshots">Screenshots</a> •
  <a href="#credits">Credits</a> • 
  <a href="#license">License</a>
</h3>
  
## Installation

Wolvenkit requires the latest .NET 8.0 runtime:

1. Go to [Microsoft's .NET download page](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. Find the ".NET Desktop Runtime 8.0.x" section and download the installer for your architecture (x64)
3. Run the downloaded installer

----------

There are multiple ways to install Wolvenkit:

### The WolvenKit.Installer app

The WolvenKit.Installer app is a simple program for managing (installing, updating, removing) different WolvenKit versions similar to the Visual Studio Installer app. 

It is [hosted on github](https://github.com/WolvenKit/WolvenKit.Installer) and you can install it from there. Click here: [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit.Installer)](https://github.com/WolvenKit/WolvenKit.Installer/releases/latest)

### Portable or Installer

Download either the latest stable version or the current nightly (beta) version from here:

| Package | Latest Release | Checks  |
| ------- | ------------ | ----------------- |
| [WolvenKit Nightly](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit-nightly-releases)](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/WolvenKit/WolvenKit/nightly.yml) |
| [WolvenKit](https://github.com/WolvenKit/WolvenKit/releases/latest) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit)](https://github.com/WolvenKit/WolvenKit/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/WolvenKit/WolvenKit/check-only.yml) | 

To install the app quickly download `WolvenKitSetup-x.x.x.exe` and double click to run the installer.

You can also simply download `WolvenKit-x.x.x.x.zip` and extract it to a location of your choice

## Usage

📑 Check out the wiki: https://wiki.redmodding.org/wolvenkit

## Build instructions

If you want to build the app from source yourself:

1. Download and install [Visual Studio 2022 Community Edition](https://www.visualstudio.com/) or a higher version.
2. Clone this repository.
3. Open the solution (`All.sln`)
4. Build the projects.

## Contributing
- Join the [Cyberpunk 2077 Modding Server](https://discord.gg/Epkq79kd96) for active development

Do you want to contribute? Community feedback and contributions are highly appreciated!
It's a good idea to create an issue when implementing a feature so people don't work on the same feature/issue in an asynchronous manner.

**For general rules and guidelines see [CONTRIBUTING.md](/docs/CONTRIBUTING.md).**

For any questions:
Developer | Role | Email
------------ | ------------- | -------------
[Seberoth](https://github.com/seberoth) | Project Lead / Core Development | 
[Rfuzzo](https://github.com/rfuzzo) | Project Lead / Core Development | [Email](mailto:r.fuzzo@gmail.com) 
[Traderain](https://github.com/Traderain) | Project Lead | [Email](mailto:hambalko.bence@gmail.com) 

## Screenshots

![WK 8 6 Home Page Example](https://user-images.githubusercontent.com/65016231/172458777-d521aeaa-b2fb-43ef-a909-3786c1b8bf02.png)

![WK 8 6 Editor Example](https://user-images.githubusercontent.com/65016231/172455912-e1d4fe29-9ab6-45a1-9e0c-17f2bb47c447.png)

## Credits

WolvenKit is a direct result of the hard work and continuous support, financial and otherwise, of the many researchers, programmers, artists, contributors, and companies that have helped with this project. Without their outstanding work and generous support, we never would have been able to create WolvenKit for Cyberpunk 2077. A very special thank you goes out to...

<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" alt="JetBrains logo." height="64">

- [JetBrains](https://www.jetbrains.com) who supplied open source licences for our developers
- [Syncfusion](https://www.syncfusion.com/company/about-us) who supplied an open source licence for the WPF controls we use
- [Ab3d PowerToys](https://www.ab4d.com/PowerToys.aspx)
- [Ab3d DXEngine](https://www.ab4d.com/DXEngine.aspx)

An ancestor to this tool was <a href="https://drive.google.com/file/d/0B3axqSlhNHOOYmpkWk83TXRkZmM/view">W3Edit</a>, initially developed by <a href="https://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/58758-mod-editor">Sarcen</a> in 2015, around the time The Witcher 3 first came out. After Sarcen stopped working on it, a few of us picked it up and continued from there.

- [Assimp](https://github.com/assimp/assimp-net)
- [Zenhax](https://zenhax.com)
- [Xentax](https://xentax.com)
- [Lua Utils for W3](https://github.com/hhrhhr/Lua-utils-for-Witcher-3)
- [TW3 Booster](https://github.com/gamebooster/witcher3-booster)
- [TW3 Converter](https://bitbucket.org/jlouis/witcherconverter)
- [VgmToolbox](https://sourceforge.net/projects/vgmtoolbox/)
- [TW3 Mod Discussion](http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions)
- [Payday 2 Modding Information](https://bitbucket.org/zabb65/payday-2-modding-information)
- [ModWorkshop](https://modworkshop.net/showthread.php?tid=101)
- [W3 SaveGame Editor](https://github.com/Atvaark/W3SavegameEditor)
- [ffmpeg](https://www.ffmpeg.org/)
- [irrlicht](http://irrlicht.sourceforge.net/)

## License

***Copyright Disclaimer:*** Under Section 107 of the Copyright Act 1976, allowance is made for "fair use" for purposes such as criticism, comment, news reporting, teaching, scholarship, and research. Fair use is permitted by copyright statute that might otherwise be infringing. Non-profit, educational or personal use tips the balance in favor of fair use.. This project is solely made for research and in no way made to generate any revenue.
