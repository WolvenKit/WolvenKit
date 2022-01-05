<p align="center">
  <a href="https://github.com/WolvenKit/Wolvenkit/releases"><img src="https://img.shields.io/github/downloads/WolvenKit/Wolven-Kit/total"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/actions?query=workflow%3AWolvenKit-Nightly"><img src="https://github.com/WolvenKit/Wolven-kit/workflows/WolvenKit-Nightly/badge.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/issues"><img src="https://img.shields.io/github/issues/WolvenKit/Wolven-kit.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/network"><img src="https://img.shields.io/github/forks/WolvenKit/Wolven-kit.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/stargazers"><img src="https://img.shields.io/github/stars/WolvenKit/Wolven-kit.svg"></a>    
  <a href="https://raw.githubusercontent.com/WolvenKit/Wolven-kit/master/LICENSE"><img src="https://img.shields.io/badge/license-AGPL-blue.svg"></a>
  <a href="https://discord.gg/cp77modding"><img src="https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2">  </a>  

# WolvenKit

This repository was created to demonstrate how [CDPR](https://en.wikipedia.org/wiki/CD_Projekt)'s proprietary [**REDEngine**](https://en.wikipedia.org/wiki/CD_Projekt#REDengine) reads and writes file formats.
And to experiment with the working of games running on this engine i.e. **The Witcher 3: The Wild Hunt** and **Cyberpunk 2077**. 
This toolkit is being made solely for research and educational purposes, and the dev team is in no way responsible for any malfunctions that occur from its use.
Its completely open source, licensed under GPL v3.0, and in no way is it made to generate revenue.
An ancestor to this tool was [W3Edit](https://drive.google.com/file/d/0B3axqSlhNHOOYmpkWk83TXRkZmM/view), initially developed by [Sarcen](http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/58758-mod-editor) in 2015, around the time The Witcher 3 first came out.
After Sarcen stopped working on it, a few of us picked it up and continued from there.

Currently, WolvenKit allows reading and writing nearly every REDEngine file format to some extent. 
It can also be used to create file modifications to the assets of the game, though this is currently beign actively worked upon, so do make sure to check it regularly.
Our primary focus at the moment is progressing with support for the new game, Cyberpunk 2077.

:question: Check out the wiki: https://wiki.redmodding.org/wolvenkit

---
  
<h3 align="center">
  <a href="#installation">Installation</a> •
  <a href="#usage">Usage</a> •
  <a href="#contributing">Contributing</a> •
  <a href="#screenshots">Screenshots</a> •
  <a href="#credits">Credits</a> • 
  <a href="#license">License</a>
</h3>

</p>
  <p align="center"> 
    <a href="https://patreon.com/traderain"><img src="https://i.ibb.co/RBZKRg4/Become-a-patron-button.png" alt="Become-a-patron-button" border="0"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/releases/latest"><img src="https://i.ibb.co/272nyjJ/Pngtree-file-download-icon-4719240.png" alt="Pngtree-file-download-icon-4719240" border="0"></a>  
</p>

  
## Installation

Download either the latest stable version or the current nightly (beta) version from here:

| Package | Latest Release | Checks  |
| ------- | ------------ | ----------------- |
| [WolvenKit Nightly](https://github.com/WolvenKit/WolvenKit-nightly-releases/) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit-nightly-releases)](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/workflow/status/WolvenKit/WolvenKit/WolvenKit-Nightly?color=green) |
| [WolvenKit](https://github.com/WolvenKit/WolvenKit/) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit)](https://github.com/WolvenKit/WolvenKit/releases/latest) | ![GitHub branch checks state](https://img.shields.io/github/checks-status/WolvenKit/WolvenKit/master) | 

### Installer
1. Install the NET 5 Runtime: https://dotnet.microsoft.com/download/dotnet/5.0
2. Double click on the .exe to start the installation procedure and the program will take care of the rest.

### Portable
1. Install the NET 5 Runtime: https://dotnet.microsoft.com/download/dotnet/5.0
2. Download Wolvenkit.zip
3. Run WolvenKit.exe

## Usage

:question: Check out the wiki: https://wiki.redmodding.org/wolvenkit


## Build instructions
1. Download and install [Visual Studio 2019 Community Edition](https://www.visualstudio.com/) or a higher version.
2. Clone this repository.
3. Clone the dependencies (`git submodule update --init --recursive`).
4. Open the solution (`All.sln`)
5. Build the projects.

## Contributing
- Join the [Cyberpunk 2077 Modding Server](discord.gg/Epkq79kd96) for active development

Do you want to contribute? Community feedback and contributions are highly appreciated!
It's a good idea to create an issue when implementing a feature so people don't work on the same feature/issue in an asynchronous manner.

**For general rules and guidelines see [CONTRIBUTING.md](/docs/CONTRIBUTING.md).**

For any questions:
Developer | Role | Email
------------ | ------------- | -------------
Traderain | Project Lead / Core Development | [Email](mailto:hambalko.bence@gmail.com) 
Rfuzzo | Project Lead / Core Development | [Email](mailto:r.fuzzo@gmail.com) 

## Screenshots

![screenshot](https://media.discordapp.net/attachments/803648048018096170/809406032336912394/unknown.png?width=837&height=640)

![screenshot](https://cdn.discordapp.com/attachments/788051447081598976/811578293676539904/unknown.png)


## Credits

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
