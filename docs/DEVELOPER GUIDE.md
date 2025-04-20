# Developer Guide for the Wolvenkit projects

[WolvenKit on Github](https://github.com/WolvenKit/WolvenKit)
[Dev chat on Cyberpunk 2077 Modding Community Discord](https://discord.gg/redmodding)

## Purpose

Docs are always outdated. Docs near code are the least outdated.

## Getting Started

1. First, read the [README](../README.md)
2. Read the [Contributing Guidelines](CONTRIBUTING.md)
3. Read through the [Redmodding Wiki](https://wiki.redmodding.org/home/), especially
    - [WolvenKit section](https://wiki.redmodding.org/wolvenkit/) which includes the CP2077 Tools docs as well

## Tools

- [Git](https://git-scm.com/)
    - On Windows use the installer, `winget`, or the [Scoop](https://github.com/ScoopInstaller/Scoop) or [Chocolatey](https://chocolatey.org/) package managers
- [A GitHub Account](https://github.com/)
- [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/vs/) (free)

## Debugging

### Logs

- User-facing log: visible in the app (View > Log)
- Application logs: located in `%appdata%\REDModding\WolvenKit`

### Non-print-based debugging

It’s easiest to debug using Visual Studio.

1. Switch to the Debug profile, then Debug: ![image](https://user-images.githubusercontent.com/13802421/157662443-27a00ab2-1b26-4428-ac2e-f317efd15396.png)
2. Set breakpoints and stuff to stop execution at appropriate points..

If you don’t have VS available, or you’re helping someone else, the application log (see above) is a good place to get more info

## Profiling

Use Visual Studio. The default options should work for the most part, but TODO: shared profiling config/info

1. Debug > Performance Profiler
2. You’re probably mostly interested in these options: ![image](https://user-images.githubusercontent.com/13802421/157661489-1d618a59-fca3-4cdc-bc1f-c00ae20c15ae.png)
3. Click `Start`
4. Do stuff that you want to profile
5. When done, click the End Profiling button
6. Creating the diagnostic data can take A LONG TIME, be patient
7. See what you can see. Typically interesting counters are
    - Layout (especially if the GUI feels slow)
    - Function timings (especially the _self_ time if you’re looking for slowness)
