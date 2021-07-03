@echo off

call publish.bat

echo "create manifest exe"
dotnet publish .\WolvenManager.Installer\WolvenManager.Installer.csproj -o .\publish -p:PublishSingleFile=true --no-self-contained -r win-x64 -c Release -f net5.0

echo "create assets"
.\publish\WolvenManager.Installer.exe create -a .\publish\full\WolvenKit.exe -o .\publish

echo "Inno Setup ..."
.\Installers\ISCC\ISCC.exe /O"publish" /dMyAppBaseDir="..\publish\full\" .\Installers\installer.iss

echo "create manifest"
.\publish\WolvenManager.Installer.exe manifest -a .\publish\full\WolvenKit.exe -i .\publish -o .\publish

echo "fullpublish completed"