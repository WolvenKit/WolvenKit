@echo off

cd ..\

@RD /S /Q .\publish\

:: @RD /S /Q .\publish\full
:: @RD /S /Q .\publish\console

echo "publish app"
dotnet publish .\WolvenKit\WolvenKit.UI.csproj -o publish\full --no-self-contained -r win-x64 -c Release -f net5.0-windows

echo "publish console"
dotnet publish .\WolvenKit.CLI\WolvenKit.CLI.csproj -o publish\console --no-self-contained -r win-x64 -c Release -f net5.0

echo "The program has completed"