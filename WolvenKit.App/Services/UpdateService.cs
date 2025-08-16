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
            throw new Exception("Failed to get latest release");
        }

        if (!await IsUpdateAvailable(latestRelease))
        {
            return;
        }

        var tempPath = Path.Join(Path.GetTempPath(), "WolvenKitUpdate");
        if (Directory.Exists(tempPath))
        {
            Directory.Delete(tempPath, true);
        }

        Directory.CreateDirectory(tempPath);
        var downloadZipPath = Path.Join(tempPath, latestRelease.TagName + ".zip");
        var portableAsset = latestRelease.Assets.First(a => a.Name == $"WolvenKit-{latestRelease.TagName}.zip");

        try
        {
            var responseAsset = await _httpClient.GetAsync(portableAsset.DownloadUrl);
            responseAsset.EnsureSuccessStatusCode();
            await File.WriteAllBytesAsync(downloadZipPath, await responseAsset.Content.ReadAsByteArrayAsync());
        }
        catch (HttpRequestException)
        {
            Directory.Delete(tempPath, true);
            _loggerService.Error($"Failed to download update from: {portableAsset.DownloadUrl}");
            throw;
        }

        if (await Task.Run(() => portableAsset.Digest?.Split(":")[^1] != BitConverter.ToString(SHA256.Create().ComputeHash(File.ReadAllBytes(downloadZipPath))).Replace("-", "").ToLowerInvariant()))
        {
            Directory.Delete(tempPath, true);
            _loggerService.Error("Downloaded asset is invalid! Aborting update.");
            throw new Exception("Downloaded asset is invalid! Aborting update.");
        }

        var unzipPath = Path.Join(tempPath, "unzip");
        Directory.CreateDirectory(unzipPath);
        ZipFile.ExtractToDirectory(downloadZipPath, unzipPath);
        File.Delete(downloadZipPath);

        var unpackerExePath = Path.Combine(ISettingsManager.GetAppData(), "Updater" ,"WolvenKit.Unpacker.exe");
        if (!File.Exists(unpackerExePath))
        {
            if (Directory.Exists(Path.GetDirectoryName(unpackerExePath)!))
            {
                Directory.Delete(Path.GetDirectoryName(unpackerExePath)!, true);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(unpackerExePath)!);
            var unpackerReleaseAsset = latestRelease.Assets.FirstOrDefault(a => a.Name == $"WolvenKit.Unpacker-{latestRelease.TagName}.zip");
            if (unpackerReleaseAsset is null)
            {
                Directory.Delete(tempPath, true);
                _loggerService.Error("Could not find Unpacker Asset in releases! Aborting update.");
                throw new Exception("Could not find Unpacker Asset in releases! Aborting update.");
            }

            var unpackerZipPath = Path.Join(tempPath, "unpacker.zip");

            try
            {
                var responseAsset = await _httpClient.GetAsync(unpackerReleaseAsset.DownloadUrl);
                responseAsset.EnsureSuccessStatusCode();
                await File.WriteAllBytesAsync(unpackerZipPath, await responseAsset.Content.ReadAsByteArrayAsync());
            }
            catch (HttpRequestException)
            {
                Directory.Delete(tempPath, true);
                _loggerService.Error($"Failed to download unpacker from: {unpackerReleaseAsset.DownloadUrl}");
                throw;
            }

            if (await Task.Run(() => unpackerReleaseAsset.Digest?.Split(":")[^1] != BitConverter.ToString(SHA256.Create().ComputeHash(File.ReadAllBytes(unpackerZipPath))).Replace("-", "").ToLowerInvariant()))
            {
                Directory.Delete(tempPath, true);
                _loggerService.Error("Downloaded unpacker asset is invalid! Aborting update.");
                throw new Exception("Downloaded unpacker asset is invalid! Aborting update.");
            }

            ZipFile.ExtractToDirectory(unpackerZipPath, Path.GetDirectoryName(unpackerExePath)!);
            File.Delete(unpackerZipPath);
        }

        var wolvenKitExePath = Environment.ProcessPath ?? Path.Combine(AppContext.BaseDirectory, "WolvenKit.exe");
        var startInfo = new ProcessStartInfo()
        {
            FileName = unpackerExePath,
            Arguments = $"--wolvenkit-exe-path {wolvenKitExePath} --unzipped-path {unzipPath}",
            UseShellExecute = false,
            CreateNoWindow = true
        };
        Process.Start(startInfo);

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
            return false;
        }

        var localVersion = GetLocalVersion();

        // allow updating to the latest stable when the release channel changes, even if it technically is a downgrade
        if ((localVersion?.ToString().Contains("nightly") ?? false) && !remoteVersion.ToString().Contains("nightly"))
        {
            return true;
        }
        
        return IsLeftNewerThanRight(remoteVersion, localVersion!);
    }

    public async Task<string> GetLatestVersionTag()
    {
        var latestRelease = await GetLatestRelease();
        return latestRelease?.TagName ?? "0.0.0"; 
    }
    
    private bool IsLeftNewerThanRight(SemVersion left, SemVersion right) => right.CompareSortOrderTo(left) == -1;

    public SemVersion? GetLocalVersion() => Core.CommonFunctions.GetAssemblyVersion(Constants.AssemblyName);

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