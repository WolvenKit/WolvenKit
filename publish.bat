@echo off

@RD /S /Q .\publish
dotnet publish .\WolvenKit\WolvenKit.UI.csproj -o publish --no-self-contained -r win-x64 -c Release -f net5.0-windows

echo "The program has completed"