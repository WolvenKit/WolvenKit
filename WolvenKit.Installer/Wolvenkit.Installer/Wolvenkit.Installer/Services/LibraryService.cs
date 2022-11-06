using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Wolvenkit.Installer.Models;
using Wolvenkit.Installer.ViewModel;

namespace Wolvenkit.Installer.Services;

public interface ILibraryService
{
    ObservableCollection<PackageViewModel> InstalledPackages { get; }

    ObservableCollection<RemotePackageViewModel> RemotePackages { get; set; }

    Task<string> GetLatestVersionAsync(RemotePackageModel model, bool prerelease);
    Task<bool> InstallAsync(RemotePackageModel id, string installPath);
    Task<bool> InstallAsync(PackageModel id);
    Task InitAsync();
    Task SaveAsync();
    Task<bool> RemoveAsync(PackageModel model);
    bool TryGetRemote(PackageModel model, out RemotePackageViewModel remote);
}

public class LibraryService : ILibraryService
{
    private readonly HttpClient _httpClient = new();
    private readonly ILogger<LibraryService> _logger;
    private readonly INotificationService _notificationService;

    public const string FileName = "library.json";

    public LibraryService(Microsoft.Extensions.Logging.ILogger<LibraryService> logger, INotificationService notificationService)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _notificationService = notificationService;
    }

    public ObservableCollection<PackageViewModel> InstalledPackages { get; set; } = new();

    public ObservableCollection<RemotePackageViewModel> RemotePackages { get; set; } = new();

    #region Lifetime

    private static string GetAppData()
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit.Installer");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    public async Task InitAsync()
    {
        // get remote info from static db
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"Wolvenkit.Installer.Resources.AvailableApps.json");
        var available = await JsonSerializer.DeserializeAsync<List<RemotePackageModel>>(stream,
            new JsonSerializerOptions()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

        // create available viewmodels
        foreach (var item in available)
        {
            var latest = await GetLatestVersionAsync(item);
            if (string.IsNullOrEmpty(latest))
            {
                // todo logging
                continue;
            }
            RemotePackages.Add(new(item, latest));
        }

        // load installed packages
        await LoadAsync();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <returns></returns>
    public async Task SaveAsync()
    {
        var models = InstalledPackages.Select(x => x.GetModel()).ToArray();
        var json = JsonSerializer.Serialize(models, new JsonSerializerOptions()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });

        var file = Path.Combine(GetAppData(), FileName);
        await File.WriteAllTextAsync(file, json);
    }

    /// <summary>
    /// Load installed packages
    /// </summary>
    /// <returns></returns>
    private async Task LoadAsync()
    {
        var file = Path.Combine(GetAppData(), FileName);

        if (File.Exists(file))
        {
            try
            {
                var json = await File.ReadAllTextAsync(file);
                var installed = JsonSerializer.Deserialize<List<PackageModel>>(json, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                });

                if (installed is not null)
                {
                    // todo refactor
                    foreach (var item in installed)
                    {
                        // check for updates
                        if (TryGetRemote(item.Name, out var remote))
                        {
                            var installedVersion = item.Version;
                            var remoteVersion = remote.RemoteVersion;

                            // refactor SemVer
                            var updateAvailable = false;
                            if (installedVersion != remoteVersion)
                            {
                                updateAvailable = true;
                            }

                            InstalledPackages.Add(new PackageViewModel(
                            item,
                            updateAvailable ? EPackageStatus.UpdateAvailable : EPackageStatus.Installed,
                            "ms-appx:///Assets/ControlImages/Acrylic.png"
                            )
                            {
                            });
                        }
                        else
                        {
                            InstalledPackages.Add(new PackageViewModel(
                            item,
                            EPackageStatus.Installed,
                            "ms-appx:///Assets/ControlImages/Acrylic.png"
                            )
                            {
                            });
                        }
                    }
                }
                else
                {
                    InstalledPackages = new();
                }
            }
            catch (Exception)
            {
                // TODO logging
                throw;
            }
        }
        else
        {
            InstalledPackages = new();
        }
    }

    #endregion

    #region Dictionary

    private bool TryGetInstalled(string id, out PackageViewModel installed)
    {
        installed = InstalledPackages.FirstOrDefault(x => x.Name == id);
        return installed != null;
    }

    public bool TryGetRemote(PackageModel model, out RemotePackageViewModel remote) => TryGetRemote(model.Name, out remote);

    public bool TryGetRemote(string id, out RemotePackageViewModel remote)
    {
        remote = RemotePackages.FirstOrDefault(x => x.Name == id);
        return remote != null;
    }

    #endregion


    public async Task<string> GetLatestVersionAsync(RemotePackageModel model, bool prerelease = false)
    {
        if (prerelease)
        {
            throw new NotImplementedException();
        }

        var releaseUrl = $@"{model.Url}/releases/latest";
        var response = await _httpClient.GetAsync(new Uri(releaseUrl));

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Could not find release");
            return null;
        }

        // get tag
        return response?.RequestMessage.RequestUri.LocalPath.Split('/').Last();
    }

    public async Task<bool> RemoveAsync(PackageModel model)
    {
        var installed = InstalledPackages.FirstOrDefault(x => x.GetModel() == model);
        if (installed is not null)
        {
            InstalledPackages.Remove(installed);
            await SaveAsync();
            return true;
        }
        else
        {
            _logger.LogError("Could not find {model}", model.Name);
            return false;
        }
    }

    public async Task<bool> InstallAsync(PackageModel package)
    {
        return TryGetRemote(package.Name, out var remote) && await InstallAsync(remote.GetModel(), remote.InstallPath);
    }

    public async Task<bool> InstallAsync(RemotePackageModel package, string installPath)
    {
        if (string.IsNullOrEmpty(installPath))
        {
            _logger.LogError("Install location does not exist: {installpath}", installPath);
            return false;
        }

        //_progressService.IsIndeterminate = true;

        // get remote version
        var version = await GetLatestVersionAsync(package);
        if (string.IsNullOrEmpty(version))
        {
            _logger.LogError("No remote version found");
            return false;
        }

        // check installed?

        var fileName = package.AssetPattern.Replace(@".*\", version);
        var testZipPath = Path.Combine(Path.GetTempPath(), fileName);
        var zipPath = testZipPath;

        if (!File.Exists(testZipPath))
        {
            // query github api
            var header = $"wolvenkit";
            var ghClient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue(header));
            IEnumerable<Octokit.ReleaseAsset> asset = new List<Octokit.ReleaseAsset>();
            try
            {
                var owner = package.Url.Split('/')[^2];
                var repo = package.Url.Split('/').Last();

                var releases = await ghClient.Repository.Release.GetAll(owner, repo);
                var latest = releases[0];
                var assets = latest.Assets.ToList();
                asset = assets.Where(x => Regex.IsMatch(x.Name, package.AssetPattern));
            }
            catch (Octokit.ApiException)
            {
                // Prior to first API call, this will be null, because it only deals with the last call.
                var apiInfo = ghClient.GetLastApiInfo();
                var rateLimit = apiInfo?.RateLimit;
                var howManyRequestsCanIMakePerHour = rateLimit?.Limit;
                var howManyRequestsDoIHaveLeft = rateLimit?.Remaining;
                var whenDoesTheLimitReset = rateLimit?.Reset; // UTC time

                _logger.LogInformation($"[Update] {howManyRequestsDoIHaveLeft}/{howManyRequestsCanIMakePerHour} - reset: {whenDoesTheLimitReset ?? whenDoesTheLimitReset.Value.ToLocalTime()}");
                _logger.LogError("API rate limit exceeded");

                return false;
            }

            if (!asset.Any())
            {
                _logger.LogError("No assets found to download");
                return false;
            }

            // download 
            var contentUrl = asset.First().BrowserDownloadUrl;
            zipPath = Path.Combine(Path.GetTempPath(), contentUrl.Split('/').Last());

            if (!File.Exists(zipPath))
            {
                var response = await _httpClient.GetAsync(new Uri(contentUrl));
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogError(ex, "Failed to respond to url: {contentUrl}", contentUrl);
                    return false;
                }

                await using var fs = new FileStream(zipPath, System.IO.FileMode.Create);
                // TODO report progress here
                await response.Content.CopyToAsync(fs);
            }
        }

        //_progressService.IsIndeterminate = false;

        // extract zip file
        var installedFiles = await Task.Run(() => ExtractZip(zipPath, installPath));
        var installedPackage = new PackageModel(package.Name, version, installedFiles.Select(x => Path.GetRelativePath(installPath, x)).ToArray(), installPath);

        InstalledPackages.Add(new(installedPackage, EPackageStatus.Installed, package.ImagePath));

        // save
        await SaveAsync();

        return true;
    }

    private List<string> ExtractZip(string zipPath, string extractPath)
    {
        // extract from temp path
        var files = new List<string>();

        if (!Directory.Exists(extractPath))
        {
            Directory.CreateDirectory(extractPath);
        }

        try
        {
            if (!extractPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
            {
                extractPath += Path.DirectorySeparatorChar;
            }

            using var archive = ZipFile.OpenRead(zipPath);

            var progress = 0;
            //_progressService.IsIndeterminate = false;
            //_progressService.Report(0.1);
            foreach (var entry in archive.Entries)
            {
                // Gets the full path to ensure that relative segments are removed.
                var destinationPath = Path.GetFullPath(Path.Combine(extractPath, entry.FullName));

                if (destinationPath.EndsWith(Path.DirectorySeparatorChar))
                {
                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }
                }
                else
                {
                    // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that are case-insensitive.
                    if (destinationPath.StartsWith(extractPath, StringComparison.Ordinal))
                    {
                        var folder = Path.GetDirectoryName(destinationPath);
                        if (folder != null)
                        {
                            if (!Directory.Exists(folder))
                            {
                                Directory.CreateDirectory(folder);
                            }
                        }

                        entry.ExtractToFile(destinationPath, true);
                        files.Add(destinationPath);
                    }
                }

                progress++;
                //_progressService.Report(progress / (float)archive.Entries.Count);
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to extract plugin zip: {zipPath}", zipPath);

            files.Clear();
        }

        //_progressService.Completed();
        return files;
    }


}

