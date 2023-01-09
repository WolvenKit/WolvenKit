<p align="center">
  <a href="https://wiki.redmodding.org/wolvenkit"><img src="https://user-images.githubusercontent.com/65016231/191120204-c8e08bb2-d68b-4919-91ec-f8c1aaef1e6a.png"/></a><br /><br />
  <a href="https://github.com/WolvenKit/Wolvenkit/releases"><img src="https://img.shields.io/github/downloads/WolvenKit/WolvenKit/total"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/actions?query=workflow%3AWolvenKit-Nightly"><img src="https://github.com/WolvenKit/WolvenKit/workflows/WolvenKit-Nightly/badge.svg"></a>
  <a href="https://github.com/WolvenKit/WolvenKit/issues"><img src="https://img.shields.io/github/issues/WolvenKit/WolvenKit.svg"></a>
  <a href="https://github.com/WolvenKit/WolvenKit/network"><img src="https://img.shields.io/github/forks/WolvenKit/WolvenKit.svg"></a>
  <a href="https://github.com/WolvenKit/WolvenKit/stargazers"><img src="https://img.shields.io/github/stars/WolvenKit/WolvenKit.svg"></a>    
  <a href="https://raw.githubusercontent.com/WolvenKit/WolvenKit/main/LICENSE"><img src="https://img.shields.io/github/license/WolvenKit/WolvenKit.svg"></a>
  <a href="https://discord.gg/cp77modding"><img src="https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2"></a>
</p>

<p align="center">

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

<p align="center"> 
  <a href="https://patreon.com/traderain"><img src="https://i.ibb.co/RBZKRg4/Become-a-patron-button.png" alt="Become-a-patron-button" border="0"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/releases/latest"><img src="https://i.ibb.co/272nyjJ/Pngtree-file-download-icon-4719240.png" alt="Pngtree-file-download-icon-4719240" border="0"></a>  
</p>

  
## Installation

### Prerequisite: .NET Runtime

We recommend always using the latest .NET 7.0 runtime, unless otherwise specified. 

1. Go to [Microsoft's .NET download page](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. Find the ".NET Desktop Runtime 7.0.x" section and download the installer for your architecture (x64)
3. Run the downloaded installer

### WolvenKit

Download either the latest stable version or the current nightly (beta) version from here:

| Package | Latest Release | Checks  |
| ------- | ------------ | ----------------- |
| [WolvenKit Nightly](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit-nightly-releases)](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/WolvenKit/WolvenKit/nightly.yml) |
| [WolvenKit](https://github.com/WolvenKit/WolvenKit/releases/latest) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit)](https://github.com/WolvenKit/WolvenKit/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/WolvenKit/WolvenKit/check-only.yml) | 


### Portable
1. Download and extract `Wolvenkit.zip`
2. Double click WolvenKit.exe

### Installer
1. Download the `Wolvenkit.Installer.Package_x.x.x.x_x64.msixbundle` installer
2. Double click it

## Usage

📑 Check out the wiki: https://wiki.redmodding.org/wolvenkit

## Build instructions
1. Download and install [Visual Studio 2022 Community Edition](https://www.visualstudio.com/) or a higher version.
2. Clone this repository.
3. Open the solution (`All.sln`)
4. Build the projects.

## Contributing
- Join the [Cyberpunk 2077 Modding Server](discord.gg/Epkq79kd96) for active development

Do you want to contribute? Community feedback and contributions are highly appreciated!
It's a good idea to create an issue when implementing a feature so people don't work on the same feature/issue in an asynchronous manner.

**For general rules and guidelines see [CONTRIBUTING.md](/docs/CONTRIBUTING.md).**

For any questions:
Developer | Role | Email
------------ | ------------- | -------------
[Traderain](https://github.com/Traderain) | Project Lead / Core Development | [Email](mailto:hambalko.bence@gmail.com) 
[Rfuzzo](https://github.com/rfuzzo) | Project Lead / Core Development | [Email](mailto:r.fuzzo@gmail.com) 
[Seberoth](https://github.com/seberoth) | Core Development | 

## Screenshots

![WK 8 6 Home Page Example](https://user-images.githubusercontent.com/65016231/172458777-d521aeaa-b2fb-43ef-a909-3786c1b8bf02.png)


![WK 8 6 Editor Example](https://user-images.githubusercontent.com/65016231/172455912-e1d4fe29-9ab6-45a1-9e0c-17f2bb47c447.png)


## Credits

An ancestor to this tool was <a href="https://drive.google.com/file/d/0B3axqSlhNHOOYmpkWk83TXRkZmM/view">W3Edit</a>, initially developed by <a href="https://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/58758-mod-editor">Sarcen</a> in 2015, around the time The Witcher 3 first came out.
After Sarcen stopped working on it, a few of us picked it up and continued from there.

WolvenKit is a direct result of the hard work and continuous support, financial and otherwise, of the many researchers, programmers, artists, contributors, and companies that have helped with this project. Without their outstanding work and generous support, we never would have been able to create WolvenKit for Cyberpunk 2077. A very special thank you goes out to...

- [Ab3d PowerToys](https://www.ab4d.com/PowerToys.aspx)
- [Ab3d DXEngine](https://www.ab4d.com/DXEngine.aspx)
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
