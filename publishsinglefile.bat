@echo off

@RD /S /Q .\publishsinglefile
dotnet publish .\WolvenKit\WolvenKit.UI.csproj -o publishsinglefile -p:PublishSingleFile=true --no-self-contained -r win-x64 -c Release -f net5.0-windows

echo "The program has completed"