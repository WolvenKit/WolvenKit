# CP77Tools

[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
[![Discord](https://img.shields.io/discord/717692382849663036.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/Epkq79kd96)
[![CodeFactor](https://www.codefactor.io/repository/github/wolvenkit/cp77tools/badge)](https://www.codefactor.io/repository/github/wolvenkit/cp77tools)
![GitHub all releases](https://img.shields.io/github/downloads/rfuzzo/cp77tools/total)
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/rfuzzo/cp77tools)](https://github.com/WolvenKit/CP77Tools/releases)
[![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/rfuzzo/cp77tools?include_prereleases)](https://github.com/WolvenKit/CP77Tools/releases)

Modding tools for the CDPR Cyberpunk 2077 video game.

## Latest Stable Release
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/rfuzzo/cp77tools)](https://github.com/WolvenKit/CP77Tools/releases) https://github.com/WolvenKit/CP77Tools/releases


## Latest Beta Release
[![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/rfuzzo/cp77tools?include_prereleases)](https://github.com/WolvenKit/CP77Tools/releases) https://github.com/WolvenKit/CP77Tools/releases

-------------

❗  **requires NET5.0.** (if you don't have it: https://dotnet.microsoft.com/download/dotnet/5.0)

❗  **The cp77 tools require oo2ext_7_win64.dll to work.** Copy and paste the dll found here `Cyberpunk 2077\bin\x64\oo2ext_7_win64.dll` into the cp77Tools folder.

If you are building from source, the dll needs to be in the same folder as the build .exe, e.g.
C:\cpmod\CP77Tools\CP77Tools\bin\Debug\net5.0\oo2ext_7_win64.dll

-------------

❓  **Check the wiki for guides and how to use this tool:** https://github.com/WolvenKit/CP77Tools/wiki


## Usage:

❗  **Surround paths with quotation marks** (if the path contains spaces: e.g. `archive -e -p "C:\Cyberpunk 2077\modding"`)

* displays the general help: list all commands
`--help`

* displays help for a specific command, e.g. 
`archive -h`

### Main functions
* extract all files from archive
`archive -e -p "PATH TO ARCHIVE"`

* extract all textures from archive (supports conversion to tga, bmp, jpg, png, dds)
`archive -u --uext png -p "PATH TO ARCHIVE"`

* rebuild textures and buffers (this step is needed when packing textures!, see the wiki for how to use this command)
`rebuild -p "PATH TO FOLDER" -b -t --keep --unsaferaw`

* pack a folder into an .archive (see the wiki for how to use this command)
`pack -p "PATH TO FOLDER"`

### Debug Options
* dumps property info from extracted cr2w file
`cr2w -c -p "<PATH TO FILE>"`
* dumps class info from extracted cr2w file
`cr2w -a -p "<PATH TO FILE>"`
