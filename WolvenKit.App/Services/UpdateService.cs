using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Semver;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WolvenKit.App.Services;

public class UpdateService : IUpdateService
{
    private readonly ILoggerService _loggerService;
    private readonly ISettingsManager _settingsManager;
    private readonly HttpClient _httpClient;
    
    public UpdateService(ILoggerService loggerService, ISettingsManager settingsManager)
    {
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "WolvenKit");
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    }
    
    public async Task UpdateToNewestVersion()
    {
        var latestRelease = await GetLatestRelease();
        if (latestRelease is null)
        {
            return;
        }
        
        if (!await IsUpdateAvailable(latestRelease))
        {
            return;
        }
        
        var tempPath = Path.Join(Path.GetTempPath(), "WolvenKitUpdate");
        Directory.CreateDirectory(tempPath);
        var downloadZipPath = Path.Join(tempPath, latestRelease.TagName + ".zip");
        var portableAsset = latestRelease.Assets.First(a => a.Name == $"WolvenKit-{latestRelease.TagName}.zip");
        
        try
        {
            var responseAsset = await _httpClient.GetAsync(portableAsset.DownloadUrl);
            responseAsset.EnsureSuccessStatusCode();
            await File.WriteAllBytesAsync(downloadZipPath, await responseAsset.Content.ReadAsByteArrayAsync());
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to download update from: {portableAsset.DownloadUrl}");
            _loggerService.Error(ex);
            return;
        }
        
        if (portableAsset.Digest?.Split(":")[^1] != BitConverter.ToString(SHA256.Create().ComputeHash(File.ReadAllBytes(downloadZipPath))).Replace("-", "").ToLowerInvariant())
        {
            Directory.Delete(tempPath, true);
            _loggerService.Error("Downloaded update asset is invalid! Aborting update.");
            return;       
        }
        
        var unzipPath = Path.Join(tempPath, "unzip");
        Directory.CreateDirectory(unzipPath);
        ZipFile.ExtractToDirectory(downloadZipPath, unzipPath);
        
        var exePath = Environment.ProcessPath ?? Path.Combine(AppContext.BaseDirectory, "WolvenKit.exe");
        var scriptPath = Path.Combine(tempPath, "update.ps1");
        var vbsScriptPath = Path.Combine(tempPath, "update.vbs");
        File.WriteAllText(scriptPath, $@"
$exePath = ""{exePath}""
$unzipPath = ""{unzipPath}""
$rootTempPath = ""{tempPath}""

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

    public async Task<bool> IsUpdateAvailable(MinimalGithubRelease? release = null)
    {
        if (DesktopBridgeHelper.IsRunningAsPackage())
        {
            return false;
        }

        var remoteVersion = await GetRemoteVersion(release);
        if (remoteVersion is null)
        {
            _loggerService.Error("Failed to get remote version");
            return false;
        }
        var localVersion = GetLocalVersion();
        
        return IsLeftNewerThanRight(remoteVersion, localVersion!);
    }

    public async Task<string> GetLatestVersionTag()
    {
        var latestRelease = await GetLatestRelease();
        return latestRelease?.TagName ?? "0.0.0"; 
    }
    
    private bool IsLeftNewerThanRight(SemVersion left, SemVersion right) => right.CompareSortOrderTo(left) == -1;

    private SemVersion? GetLocalVersion() => Core.CommonFunctions.GetAssemblyVersion(Constants.AssemblyName);

    private string GetRepositoryName() => _settingsManager.UpdateChannel == EUpdateChannel.Stable
        ? "WolvenKit"
        : "WolvenKit-nightly-releases";
    
    private async Task<MinimalGithubRelease?> GetLatestRelease()
    {
        try
        {
            var response =
                await _httpClient.GetAsync(@$"https://api.github.com/repos/WolvenKit/{GetRepositoryName()}/releases/latest");
            response.EnsureSuccessStatusCode();
            var serializedResponse = JsonConvert.DeserializeObject<MinimalGithubRelease>(await response.Content.ReadAsStringAsync());
            return serializedResponse;
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to get Release for `WolvenKit/{GetRepositoryName()}`");
            _loggerService.Error(ex);
            return null;
        }
    }
    
    private async Task<SemVersion?> GetRemoteVersion(MinimalGithubRelease? release = null)
    {
        var latestRelease = release ?? await GetLatestRelease();
        if (latestRelease is null)
        {
            return null;
        }
        return SemVersion.Parse(latestRelease.TagName, SemVersionStyles.OptionalMinorPatch);  
    }
}