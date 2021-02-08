# WolvenKit
<center><h2><strong>A community mod editor for CDPR games made on variants of REDEngine.</h2></strong></center>  

![Screenshot](/assets/screenshot.png)
![Screenshot](/assets/screenshot2.png)

![WolvenKit-Nightly](https://github.com/WolvenKit/Wolven-kit/workflows/WolvenKit-Nightly/badge.svg)
[![GitHub issues](https://img.shields.io/github/issues/WolvenKit/Wolven-kit.svg)](https://github.com/WolvenKit/Wolven-kit/issues)
[![GitHub forks](https://img.shields.io/github/forks/WolvenKit/Wolven-kit.svg)](https://github.com/WolvenKit/Wolven-kit/network)
[![GitHub stars](https://img.shields.io/github/stars/WolvenKit/Wolven-kit.svg)](https://github.com/WolvenKit/Wolven-kit/stargazers)
[![GitHub license](https://img.shields.io/badge/license-AGPL-blue.svg)](https://raw.githubusercontent.com/WolvenKit/Wolven-kit/master/LICENSE)
![GitHub downloads](https://img.shields.io/github/downloads/WolvenKit/Wolven-Kit/total)
[![Discord](https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/cp77modding)

This repository was created to demonstrate how the proprietary game engine of CDPR, **REDEngine**, reads and writes file formats, and experiment with how their games running on this engine (**The Witcher 3: The Wild Hunt** and **Cyberpunk 2077** currently) work. This tool suite is being made fully for research and educational purposes, and the dev team is in no way responsible of a hypothetical malfunction regarding the game or PC of the end user. It's completely open source, licensed under GPL v3.0, and in no way is it made to generate revenue. The precursor to this tool, W3EDit, was initially [developed by Sarcen](http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/58758-mod-editor) in 2015, around the time The Witcher 3 first came out. After Sarcen stopped working on it, a few of us picked it up and continued from there. Currently, it allows reading and writing nearly every REDEngine file format to some extent. It can be used to create file modifications to the assets of the game. This is heavy WIP, so do make sure to check on it regularly. Our primary focus at the moment is progressing with support for the new game, Cyberpunk 2077.

***Copyright Disclaimer:*** Under Section 107 of the Copyright Act 1976, allowance is made for "fair use" for purposes such as criticism, comment, news reporting, teaching, scholarship, and research. Fair use is permitted by copyright statute that might otherwise be infringing. Non-profit, educational or personal use tips the balance in favor of fair use.. This project is solely made for research and in no way made to generate any revenue.


## Team:
**Project lead: Traderain**  
Core development team:
- **Traderain** (project management, core development etc.)
- **rfuzzo**  (core development)
- **michaelpolakatwork** (rendering)
- **Maxzor** (development)

Special thanks to:
- kote2ster
- George Tziotis
- Murzinio
- vonLeebpl
- ali-alidoust
- Lim3zer0
- sw3dg1n
- robymontyz
- philippTheCat
- mattstates
- dnandha
- carlosproiete
- Strahlemann83
- Jicksaw
- Anras573
- rmemr
- CAPA
- DJ_Kovrik
- KNG
- SkacikPL
- Mezziaz
- The Witcher 3 Modding Discord Server (https://discord.gg/tdSUQQe)
- The Cyberpunk 2077 Modding Server (https://discord.gg/cp77modding)

## Credits:

- https://xentax.com
- https://zenhax.com
- https://github.com/hhrhhr/Lua-utils-for-Witcher-3
- https://github.com/gamebooster/witcher3-booster
- https://bitbucket.org/jlouis/witcherconverter
- https://sourceforge.net/projects/vgmtoolbox/
- http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions
- https://bitbucket.org/zabb65/payday-2-modding-information
- https://modworkshop.net/showthread.php?tid=101
- https://github.com/Atvaark/W3SavegameEditor
- https://www.ffmpeg.org/
- http://irrlicht.sourceforge.net/
- Sarcenzzz for W3Edit

## Building:
Visual Studio 2019 required. All the required files are either nuget packages, which will be automatically downloaded once you press Build, or included in the package in the [Libs directory](/Libs/).
If, for some reason, the LFS quota is depleted, the renderer prerequisite libs can be acquired here: https://outwa.it/lib.zip

## Contributing:
Please do! Fork the project and please commit your changes in small incremental steps with descriptive messages. Code quality is not the biggest concern but refrain from stupid mistakes that may lead to the denial of the pull request. It's a good idea create an issue when implementing a feature so people don't work on the same feature/issue in an asynchronous manner.

For any questions:
- PM me on Discord: Traderain#3279 
- Reach me at: hambalko.bence@gmail.com.
- Discord: https://discord.gg/cp77modding
- Our old server for general chatting: https://discordapp.com/invite/tdSUQQe
