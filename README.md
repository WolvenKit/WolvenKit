
<h3 align="center">
  <br>
  <a href="https://redmodding.org/"><img src="https://media.discordapp.net/attachments/803619861170225203/811665837218856970/banner2.png?width=960&height=305" alt="" ></a>
  <br>
  REDEngine Community Toolkit
  <br>
</h3>

</p>
  <p align="center"> 
    <a href="https://patreon.com/traderain"><img src="https://i.ibb.co/RBZKRg4/Become-a-patron-button.png" alt="Become-a-patron-button" border="0"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/releases/latest"><img src="https://i.ibb.co/272nyjJ/Pngtree-file-download-icon-4719240.png" alt="Pngtree-file-download-icon-4719240" border="0"></a>  
</p>

<h3 align="center">
  <a href="#About">About</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#team">Team</a> •
  <a href="#credits">Credits</a> • 
  <a href="#contributing">Contribute</a> •
  <a href="#license">License</a>
 
</h3>

<p align="center">
  <a href="https://github.com/WolvenKit/Wolvenkit/releases"><img src="https://img.shields.io/github/downloads/WolvenKit/Wolven-Kit/total"></a>
  <a href="https://github.com/WolvenKit/Wolvenkit/actions?query=workflow%3AWolvenKit-Nightly"><img src="https://github.com/WolvenKit/Wolven-kit/workflows/WolvenKit-Nightly/badge.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/issues"><img src="https://img.shields.io/github/issues/WolvenKit/Wolven-kit.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/network"><img src="https://img.shields.io/github/forks/WolvenKit/Wolven-kit.svg"></a>
  <a href="https://github.com/WolvenKit/Wolven-kit/stargazers"><img src="https://img.shields.io/github/stars/WolvenKit/Wolven-kit.svg"></a>    
  <a href="https://raw.githubusercontent.com/WolvenKit/Wolven-kit/master/LICENSE"><img src="https://img.shields.io/badge/license-AGPL-blue.svg"></a>
  <a href="https://discord.gg/cp77modding"><img src="https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2">  </a>  
<div id="about">&zwnj;</div>
<h3 align="center">About</h3>

---

This repository was created to demonstrate how [CDPR](https://en.wikipedia.org/wiki/CD_Projekt)'s proprietary [**REDEngine**](https://en.wikipedia.org/wiki/CD_Projekt#REDengine) reads and writes file formats.
And to experiment with the working of games running on this engine i.e. **The Witcher 3: The Wild Hunt** and **Cyberpunk 2077**. 
This toolkit is being made solely for research and educational purposes, and the dev team is in no way responsible for any malfunctions that occur from its use.
Its completely open source, licensed under GPL v3.0, and in no way is it made to generate revenue.
An ancestor to this tool was [W3Edit](https://drive.google.com/file/d/0B3axqSlhNHOOYmpkWk83TXRkZmM/view), initially developed by [Sarcen](http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/58758-mod-editor) in 2015, around the time The Witcher 3 first came out.
After Sarcen stopped working on it, a few of us picked it up and continued from there.

Currently, WolvenKit allows reading and writing nearly every REDEngine file format to some extent. 
It can also be used to create file modifications to the assets of the game, though this is currently beign actively worked upon, so do make sure to check it regularly.
Our primary focus at the moment is progressing with support for the new game, Cyberpunk 2077.

<div id="how-to-use">&zwnj;</div>
<h3 align="center">How to Use</h3>

---
<p align="center">WolvenKit can either be built from source or acquired pre-built via the installer.</p>
  
<h3 align="center">
  <a href="#building">Build</a> •
  <a href="#install">Install</a> 
</h3>

<div id="install">&zwnj;</div>
<h3 align="center">Install WolvenKit</h3>

---

1. **Download WolvenKit**

    | Package | Latest Release | Checks  |
    | ------- | ------------ | ------------------ |
    | [WolvenKit Nightly](https://github.com/WolvenKit/WolvenKit-nightly-releases/) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit-nightly-releases)](https://github.com/WolvenKit/WolvenKit-nightly-releases/releases/latest) | ![GitHub Workflow Status](https://img.shields.io/github/workflow/status/WolvenKit/WolvenKit/WolvenKit-Nightly?color=green) |
    | [WolvenKit](https://github.com/WolvenKit/WolvenKit/) | [![GitHub release (latest by date)](https://img.shields.io/github/v/release/WolvenKit/WolvenKit)](https://github.com/WolvenKit/WolvenKit/releases/latest) | ![GitHub branch checks state](https://img.shields.io/github/checks-status/WolvenKit/WolvenKit/master) | 


2. **Launch the installer.**
   1. Double click on the .exe to start the installation procedure and the program will take care of the rest.

<div id="building">&zwnj;</div>
<h3 align="center">Build WolvenKit</h3>

---

1. **Install .NET 5**
   1. https://dotnet.microsoft.com/download/dotnet/5.0

2. **Install the latest Visual Studio release.**
   1. https://visualstudio.microsoft.com/downloads/

3. **Required files**
   1. All the required files are either NuGet packages, which will automatically be downloaded on pressing `Build`, or readily included in the package in the [Libs directory](/Libs/).
   1. If, for some reason, the LFS quota is depleted, the renderer prerequisite libs can be acquired here: https://outwa.it/lib.zip

4. **Build and Run**
   1. Build WolvenKit.sln on Debug or Release doesn't matter.
   2. Run `WolvenKit.exe` (in `WolvenKit\bin\<Debug|Release>\net5.0-windows\win-x64\`).

<div id="contributing">&zwnj;</div>
<h3 align="center">Contribute</h3>

---

Please do! Fork the project and please commit your changes in small incremental steps with descriptive messages.
Code quality is not the biggest concern but refrain from stupid mistakes that may lead to the denial of the pull request.
It's a good idea to create an issue when implementing a feature so people don't work on the same feature/issue in an asynchronous manner.

For any questions
- PM Traderain#3279 on Discord,
- Mail hambalko.bence@gmail.com,
- Join the [Cyberpunk 2077 Modding Server](discord.gg/Epkq79kd96) for active development, or [the old server](https://discordapp.com/invite/tdSUQQe) for general chatting.

<div id="team">&zwnj;</div>
<h3 align="center">The WolvenKit Team</h3>

---

<h3 align="left">Core Development Team</h3>

Developer | Role | Email
------------ | ------------- | -------------
Traderain | Project Management / Core Development | [Email](mailto:hambalko.bence@gmail.com) 
Rfuzzo | Core Development | [Email](mailto:r.fuzzo@gmail.com) 
Nightmarea | MVVM Development | [Email](mailto:kote2ster@gmail.com) 
Offline | UI Development | [Email](mailto:sodanakin@gmail.com) 



<h3 align="center"><a href="https://imgbb.com/"><img src="https://i.ibb.co/ky17Xj9/download-1.png" alt="download-1" border="0"></a>
</h3>




<!-- readme: contributors -start -->
[<img alt="Traderain" src="https://avatars.githubusercontent.com/u/6411732?v=4&s=117 width=117">](https://github.com/Traderain) |[<img alt="rfuzzo" src="https://avatars.githubusercontent.com/u/37657287?v=4&s=117 width=117">](https://github.com/rfuzzo) |[<img alt="kote2ster" src="https://avatars.githubusercontent.com/u/7668964?v=4&s=117 width=117">](https://github.com/kote2ster) |[<img alt="Murzinio" src="https://avatars.githubusercontent.com/u/17109925?v=4&s=117 width=117">](https://github.com/Murzinio) |[<img alt="Offline-R503B" src="https://avatars.githubusercontent.com/u/11785451?v=4&s=117 width=117">](https://github.com/Offline-R503B) |[<img alt="Maxzor" src="https://avatars.githubusercontent.com/u/16599683?v=4&s=117 width=117">](https://github.com/Maxzor) |[<img alt="vonLeebpl" src="https://avatars.githubusercontent.com/u/18351077?v=4&s=117 width=117">](https://github.com/vonLeebpl) |[<img alt="TheBloke" src="https://avatars.githubusercontent.com/u/784313?v=4&s=117 width=117">](https://github.com/TheBloke) |[<img alt="jato" src="https://avatars.githubusercontent.com/u/65016231?v=4&s=117 width=117">](https://github.com/ja-to) |[<img alt="michaelpolakatwork" src="https://avatars.githubusercontent.com/u/8367868?v=4&s=117 width=117">](https://github.com/michaelpolakatwork) |[<img alt="DerinHalil" src="https://avatars.githubusercontent.com/u/50413946?v=4&s=117 width=117">](https://github.com/DerinHalil) |[<img alt="HitmanHimself" src="https://avatars.githubusercontent.com/u/76775663?v=4&s=117 width=117">](https://github.com/HitmanHimself) |[<img alt="Lim3zer0" src="https://avatars.githubusercontent.com/u/37447664?v=4&s=117 width=117">](https://github.com/Lim3zer0) |[<img alt="phrisk" src="https://avatars.githubusercontent.com/u/2071877?v=4&s=117 width=117">](https://github.com/phrisk) |[<img alt="ali-alidoust" src="https://avatars.githubusercontent.com/u/11314833?v=4&s=117 width=117">](https://github.com/ali-alidoust) |[<img alt="Anras573" src="https://avatars.githubusercontent.com/u/3352626?v=4&s=117 width=117">](https://github.com/Anras573) |[<img alt="carlosproiete" src="https://avatars.githubusercontent.com/u/33644328?v=4&s=117 width=117">](https://github.com/carlosproiete) |[<img alt="Jicksaw" src="https://avatars.githubusercontent.com/u/4146763?v=4&s=117 width=117">](https://github.com/Jicksaw) |[<img alt="TheFusion21" src="https://avatars.githubusercontent.com/u/19536820?v=4&s=117 width=117">](https://github.com/TheFusion21) |[<img alt="mattstates" src="https://avatars.githubusercontent.com/u/10776356?v=4&s=117 width=117">](https://github.com/mattstates) |[<img alt="robymontyz" src="https://avatars.githubusercontent.com/u/1668164?v=4&s=117 width=117">](https://github.com/robymontyz) |[<img alt="Strahlemann83" src="https://avatars.githubusercontent.com/u/34252137?v=4&s=117 width=117">](https://github.com/Strahlemann83) |[<img alt="sw3dg1n" src="https://avatars.githubusercontent.com/u/56805141?v=4&s=117 width=117">](https://github.com/sw3dg1n) |[<img alt="dingdio" src="https://avatars.githubusercontent.com/u/4729750?v=4&s=117 width=117">](https://github.com/dingdio) |[<img alt="dnandha" src="https://avatars.githubusercontent.com/u/29749761?v=4&s=117 width=117">](https://github.com/dnandha) |[<img alt="hrkrx" src="https://avatars.githubusercontent.com/u/5176531?v=4&s=117 width=117">](https://github.com/hrkrx) |[<img alt="philippTheCat" src="https://avatars.githubusercontent.com/u/120595?v=4&s=117 width=117">](https://github.com/philippTheCat) |
:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
[Traderain](https://github.com/Traderain)|[rfuzzo](https://github.com/rfuzzo)|[kote2ster](https://github.com/kote2ster)|[Murzinio](https://github.com/Murzinio)|[Offline-R503B](https://github.com/Offline-R503B)|[Maxzor](https://github.com/Maxzor)|[vonLeebpl](https://github.com/vonLeebpl)|[TheBloke](https://github.com/TheBloke)|[ja-to](https://github.com/ja-to)|[michaelpolakatwork](https://github.com/michaelpolakatwork)|[DerinHalil](https://github.com/DerinHalil)|[HitmanHimself](https://github.com/HitmanHimself)|[Lim3zer0](https://github.com/Lim3zer0)|[phrisk](https://github.com/phrisk)|[ali-alidoust](https://github.com/ali-alidoust)|[Anras573](https://github.com/Anras573)|[carlosproiete](https://github.com/carlosproiete)|[Jicksaw](https://github.com/Jicksaw)|[TheFusion21](https://github.com/TheFusion21)|[mattstates](https://github.com/mattstates)|[robymontyz](https://github.com/robymontyz)|[Strahlemann83](https://github.com/Strahlemann83)|[sw3dg1n](https://github.com/sw3dg1n)|[dingdio](https://github.com/dingdio)|[dnandha](https://github.com/dnandha)|[hrkrx](https://github.com/hrkrx)|[philippTheCat](https://github.com/philippTheCat)|
<!-- readme: contributors -end -->

<div id="screenshots">&zwnj;</div>
<h3 align="center">Screenshot</h3>

<p align="center"> 
 <img src="https://media.discordapp.net/attachments/803648048018096170/809406032336912394/unknown.png?width=837&height=640"> 
</p>

![screenshot](https://cdn.discordapp.com/attachments/788051447081598976/811578293676539904/unknown.png)

<div id="credits">&zwnj;</div>
<h3 align="center">Credits</h3>

WolvenKit is a direct result of the hard work and continuous support, financial and otherwise, of the many researchers, programmers, artists, contributors, and companies that have helped with this project. Without their outstanding work and generous support, we never would have been able to create WolvenKit for Cyberpunk 2077. A very special thank you goes out to...

</p>
  <p align="center"> 
    <a href=""><img src="https://westeurope1-mediap.svc.ms/transform/thumbnail?provider=spo&inputFormat=png&cs=fFNQTw&docid=https%3A%2F%2Fab4d-my.sharepoint.com%3A443%2F_api%2Fv2.0%2Fdrives%2Fb!om0nV2OXpkSuKuPbUOHMVAHSR4NqrSNJiWhax0B0h1V2Rs-aAf27TY9OPnezny9X%2Fitems%2F01LOPMH6QC42H7D6EMKRFLCJDK7N2YLS5D%3Fversion%3DPublished&access_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJub25lIn0.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvYWI0ZC1teS5zaGFyZXBvaW50LmNvbUBkNWQyZDViZS04NDc2LTRhODQtYmJlOC1lMDlkNzM0ZjY0YTciLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNjE3NzIxMjAwIiwiZXhwIjoiMTYxNzc0MjgwMCIsImVuZHBvaW50dXJsIjoiZ3JLRXozQmp2cWY3bnhiLzlFaENxSnd1SUpwb20vWStmVnM3MUVjSi9FOD0iLCJlbmRwb2ludHVybExlbmd0aCI6IjExNCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6Ik5UY3lOelprWVRJdE9UYzJNeTAwTkdFMkxXRmxNbUV0WlROa1lqVXdaVEZqWXpVMCIsIm5hbWVpZCI6IjAjLmZ8bWVtYmVyc2hpcHx1cm4lM2FzcG8lM2Fhbm9uI2U4MDJjMTYxNDFlOTJkYzNmZjExNzgyNzNlZDMwNGRjMGMyYzI2ODY2Y2MxMmM3NDAwY2UyZTJlNTU2OWFlYjUiLCJuaWkiOiJtaWNyb3NvZnQuc2hhcmVwb2ludCIsImlzdXNlciI6InRydWUiLCJjYWNoZWtleSI6IjBoLmZ8bWVtYmVyc2hpcHx1cm4lM2FzcG8lM2Fhbm9uI2U4MDJjMTYxNDFlOTJkYzNmZjExNzgyNzNlZDMwNGRjMGMyYzI2ODY2Y2MxMmM3NDAwY2UyZTJlNTU2OWFlYjUiLCJzaGFyaW5naWQiOiJjeXJldE96LzRrcW1Fck8wTTJSK2h3IiwidHQiOiIwIiwidXNlUGVyc2lzdGVudENvb2tpZSI6IjIifQ.aW84MXpRWDc5S1RMN08rZHNQLzg3aXZrSW44M05MTEJQTGZKd0pEUTZRWT0&encodeFailures=1&width=128&height=128&srcWidth=128&srcHeight=128" alt="Become-a-patron-button" border="0"></a>
  <a href="h"><img src="https://avatars.githubusercontent.com/u/4129749?s=88&v=4" alt="Pngtree-file-download-icon-4719240" border="0"></a>  
  <a href="h"><img src="https://gramfile.com/wp-content/uploads/2018/10/FFmpeg-Logo-Icon-45x45.png" alt="Pngtree-file-download-icon-4719240" border="0"></a>  

</p>

--- People

- Traderain ( Core Development , Project Manager ) 
- robertfuzzo ( Core Development , Co-Manager )
- michaelpolak ( Vulkan Rendering Backend )
- r503b  ( UI Design , Trello/Team Management  )
- Sebi | hrkrx ( MVVM Development )
- Nightmarea ( MVVM Development , Core Development )
- Seberoth (Core Development)
- HitmanHimself (Development)
- ZATheDeadMan (Research + Installer)
- Forsentio (Research)
- BFG9000 (Research)
- WSSDude420 (Development)
- TheFusion21 (Research + Development)
- m0xf (Research)
- Joschka (Research)
- Turk645  (Research) 

- perzeuscs ( Web Design )
- moonded  ( Web Design )
- soulweaver1  ( Web Design )
- Paco ( Web Design )
- prawny ( Web Design )
-
- HomeSick  ( Logo, Banner Design )
- shorono  ( Icon Design )
- redgalacticbear  ( Icon Design )
- PNDR ( Icon Design )
- Rosza (Icon Design)

--- Companies/Software

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
- Sarcenzzz for W3Edit



<div id="license">&zwnj;</div>
<h3 align="center">License</h3>

---

***Copyright Disclaimer:*** Under Section 107 of the Copyright Act 1976, allowance is made for "fair use" for purposes such as criticism, comment, news reporting, teaching, scholarship, and research. Fair use is permitted by copyright statute that might otherwise be infringing. Non-profit, educational or personal use tips the balance in favor of fair use.. This project is solely made for research and in no way made to generate any revenue.
