using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Semver;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using System.Text.Json;
using Octokit;

namespace WolvenKit.App.Services;

public class UpdateService : IUpdateService
{
    private readonly ILoggerService _loggerService;
    private readonly ISettingsManager _settingsManager;
    private readonly HttpClient _httpClient;
    private readonly GitHubClient _gitHubClient;
    
    public UpdateService(ILoggerService loggerService, ISettingsManager settingsManager)
    {
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "WolvenKit");
        _gitHubClient = new GitHubClient(new ProductHeaderValue("WolvenKit"));
    }
    
    public async Task UpdateToNewestVersion()
    {
        if (!await IsUpdateAvailable())
        {
            return;
        }
        
        var latestRelease = await GetLatestRelease();
        if (latestRelease is null)
        {
            return;
        }
        
        var downloadZipPath = Path.Join(ISettingsManager.GetTemp_DownloadsPath(), latestRelease.TagName + ".zip");
        var portableAsset = latestRelease.Assets.First(a => a.Name == $"WolvenKit-{latestRelease.TagName}.zip");
        
        try
        {
            var responseAsset = await _httpClient.GetAsync(portableAsset.BrowserDownloadUrl);
            responseAsset.EnsureSuccessStatusCode();
            await File.WriteAllBytesAsync(downloadZipPath, await responseAsset.Content.ReadAsByteArrayAsync());
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to download update: {portableAsset.BrowserDownloadUrl}");
            _loggerService.Error(ex);
            return;
        }
        
        var unzipPath = Path.Join(ISettingsManager.GetTemp_DownloadsPath(), "unzip");
        Directory.CreateDirectory(unzipPath);
        ZipFile.ExtractToDirectory(downloadZipPath, unzipPath);
        
        var exePath = Environment.ProcessPath ?? Path.Combine(AppContext.BaseDirectory, "WolvenKit.exe");
        var scriptPath = Path.Combine(ISettingsManager.GetTemp_DownloadsPath(), "update.ps1");
        var vbsScriptPath = Path.Combine(ISettingsManager.GetTemp_DownloadsPath(), "update.vbs");
        File.WriteAllText(scriptPath, $@"
$exePath = ""{exePath}""
$unzipPath = ""{unzipPath}""
$rootTempPath = ""{ISettingsManager.GetTemp_DownloadsPath()}""

while (Get-Process -Name (Split-Path $exePath -LeafBase) -ErrorAction SilentlyContinue) {{
    Start-Sleep -Seconds 1
}}

Copy-Item -Path ""$unzipPath\*"" -Destination $appBaseDir -Recurse -Force

Start-Process -FilePath $exePath

Remove-Item -Path $rootTempPath -Recurse -Force -ErrorAction SilentlyContinue

");
        
        File.WriteAllText(vbsScriptPath, $@"Set objShell = CreateObject(""WScript.Shell"")
objShell.Run ""powershell.exe -ExecutionPolicy Bypass -File """"{scriptPath}"""""", 0, False
");
        Process.Start(new ProcessStartInfo
        {
            FileName = "wscript.exe",
            Arguments = $"\"{vbsScriptPath}\"",
            UseShellExecute = true
        });
        
        Environment.Exit(0);
    }

    public async Task<bool> IsUpdateAvailable()
    {
        // TODO: MOVE EARLY EXIT WHEN SKIP UPDATE CHECK IS SET TO ONLY BE WHEN ITS AUTOMATICALLY TRIGGERED ON STARTUP
        if (DesktopBridgeHelper.IsRunningAsPackage() && _settingsManager.SkipUpdateCheck)
        {
            return false;
        }
        
        var remoteVersion = await GetRemoteVersion();
        if (remoteVersion is null)
        {
            _loggerService.Error("Failed to get remote version");
            return false;
        }
        var localVersion = GetLocalVersion();

        
        _loggerService.Info($"Local version: {localVersion}");
        _loggerService.Info($"Remote version: {remoteVersion}");
        _loggerService.Info($"Returning: {IsLeftNewerThanRight(remoteVersion, localVersion!)}");
        return IsLeftNewerThanRight(localVersion!, remoteVersion);
    }

    private bool IsLeftNewerThanRight(SemVersion left, SemVersion right) => right.CompareSortOrderTo(left) <= 0;

    private SemVersion? GetLocalVersion() => Core.CommonFunctions.GetAssemblyVersion(Constants.AssemblyName);

    private string GetRepositoryName() => _settingsManager.UpdateChannel == EUpdateChannel.Stable
        ? "WolvenKit"
        : "WolvenKit-nightly-releases";

    private async Task<Release?> GetLatestRelease()
    {
        try
        {
            return await _gitHubClient.Repository.Release.GetLatest("WolvenKit", GetRepositoryName());
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to get Release for `WolvenKit/{GetRepositoryName()}`");
            _loggerService.Error(ex);
            return null;
        }
    }
    
    private async Task<SemVersion?> GetRemoteVersion()
    {
        var latestRelease = await GetLatestRelease();
        if (latestRelease is null)
        {
            return null;
        }
        return SemVersion.Parse(latestRelease.TagName, SemVersionStyles.OptionalMinorPatch);  
    }
    
    public async Task<string> GetLatestVersionString() => (await GetLatestRelease())?.TagName ?? "Unknown";
}