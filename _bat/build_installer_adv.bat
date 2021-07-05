@echo off

cd ..\

set "baseDir=%cd%"

set "EXE=WolvenKit.exe"
set "out1=%baseDir%\publish"
set "out2=%baseDir%\publish\full"
set "AIP=%baseDir%\Installers\wkit_setup.aip"

c:
cd "C:\Program Files (x86)\Caphyon\Advanced Installer 18.4\bin\x86\"

.\AdvancedInstaller.com /edit %AIP% /SetVersion -fromfile %out2%/%EXE% 
.\AdvancedInstaller.com /edit %AIP% /SetOutputLocation -buildname DefaultBuild -path %out1%
.\AdvancedInstaller.com /edit %AIP% /RefreshSync
.\AdvancedInstaller.com /edit %AIP% /Rebuild