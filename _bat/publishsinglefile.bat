@echo off

cd ..\

@RD /S /Q .\publish\

echo "publish app"
dotnet publish .\WolvenKit\WolvenKit.UI.csproj -o publish\app\singlefile -p:PublishSingleFile=true --no-self-contained -r win-x64 -c Release -f net5.0-windows

echo "publish console"
dotnet publish .\WolvenKit.CLI\WolvenKit.CLI.csproj -o publish\console\singlefile -p:PublishSingleFile=true --no-self-contained -r win-x64 -c Release -f net5.0

echo "publish singlefile completed"