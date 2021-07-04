@echo off


cd ..\

set "baseDir=%cd%"

set "EXE=WolvenKit.exe"
set "OUT=%baseDir%\publish"
set "OUTFULL=%baseDir%\publish\full"
set "CONSOLE=%baseDir%\publish\console"
set "AIP=%baseDir%\Installers\wkit_setup.aip"


@RD /S /Q .\publish\

echo "publish app"
dotnet publish .\WolvenKit\WolvenKit.csproj -o %OUTFULL% --no-self-contained -r win-x64 -c Release -f net5.0-windows

echo "publish console"
dotnet publish .\WolvenKit.CLI\WolvenKit.CLI.csproj -o %CONSOLE% --no-self-contained -r win-x64 -c Release -f net5.0

echo "create manifest exe"
dotnet publish .\WolvenManager.Installer\WolvenManager.Installer.csproj -o %OUT% -p:PublishSingleFile=true --no-self-contained -r win-x64 -c Release -f net5.0

echo "create assets"
.\publish\WolvenManager.Installer.exe create -a %OUTFULL%\%EXE% -o %OUT%


REM INSTALLERS

REM add managed files
@echo {"IsPortable": false} > %OUTFULL%\.managed

echo "Inno Setup ..."
.\Installers\ISCC\ISCC.exe /O"publish\inno" /dMyAppBaseDir="..\publish\full\" .\Installers\installer.iss

echo "Advanced Installer ..."
c:
cd "C:\Program Files (x86)\Caphyon\Advanced Installer 18.4\bin\x86\"

.\AdvancedInstaller.com /edit %AIP% /SetVersion -fromfile %OUTFULL%\%EXE% 
.\AdvancedInstaller.com /edit %AIP% /SetOutputLocation -buildname DefaultBuild -path %OUT%
.\AdvancedInstaller.com /edit %AIP% /RefreshSync
.\AdvancedInstaller.com /edit %AIP% /Rebuild


REM MANIFEST

echo "create manifest"

x:
cd %baseDir%

.\publish\WolvenManager.Installer.exe manifest -a %OUTFULL%\%EXE% -i %OUT% -o %OUT%



echo "fullpublish completed"