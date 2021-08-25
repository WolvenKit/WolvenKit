@echo off

cd ..\

@RD /S /Q .\publish\

set vs_com19="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\vsdevcmd.bat"
call %vs_com19%

echo "publish app"
:: dotnet publish .\WolvenKit\WolvenKit.csproj -o publish\full --no-self-contained -r win-x64 -c Release -f net5.0-windows
msbuild .\WolvenKit\WolvenKit.csproj -t:restore;Build;Publish /p:PublishDir="../publish/app/";Configuration=Release;Platform=x64;SelfContained=False;PublishReadyToRun=False;PublishTrimmed=False


echo "publish console"
:: dotnet publish .\WolvenKit.CLI\WolvenKit.CLI.csproj -o publish\console --no-self-contained -r win-x64 -c Release -f net5.0
msbuild .\WolvenKit.CLI\WolvenKit.CLI.csproj -t:restore;Build;Publish /p:PublishDir="../publish/console/";Configuration=Release;Platform=x64;SelfContained=False;PublishReadyToRun=False;PublishTrimmed=False

echo "The program has completed"

