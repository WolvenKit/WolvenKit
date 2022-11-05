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

    Task<string> CheckForUpdateAsync(RemotePackageModel model, bool prerelease);
    Task InstallAsync(RemotePackageModel id);
    Task InitAsync();
    Task SaveAsync();
}

public class LibraryService : ILibraryService
{
    private readonly HttpClient _httpClient = new();
    private readonly Microsoft.Extensions.Logging.ILogger<LibraryService> _logger;

    public LibraryService(Microsoft.Extensions.Logging.ILogger<LibraryService> logger)
    {
        _logger = logger;
    }

    public const string FileName = "library.json";

    public ObservableCollection<PackageViewModel> InstalledPackages { get; set; } = new();

    public ObservableCollection<RemotePackageViewModel> RemotePackages { get; set; } = new();

    public static string GetAppData()
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
        // load installed packages
        await LoadAsync();

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
            var latest = await CheckForUpdateAsync(item);
            if (string.IsNullOrEmpty(latest))
            {
                // todo logging
                continue;
            }
            RemotePackages.Add(new(item, latest));
        }
    }

    private bool TryGetInstalled(string id, out PackageViewModel installed)
    {
        installed = InstalledPackages.FirstOrDefault(x => x.Title == id);
        return installed != null;
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
                        InstalledPackages.Add(new PackageViewModel(
                            item.IdStr,
                            "ms-appx:///Assets/ControlImages/Acrylic.png",
                            item.Version,
                            EPackageStatus.Installed
                            )
                        {
                        });
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

        // dbg
        InstalledPackages.Add(new("TEST", "ms-appx:///Assets/ControlImages/Acrylic.png", "1.0", EPackageStatus.Installed));
        InstalledPackages.Add(new("TEST2", "ms-appx:///Assets/ControlImages/Acrylic.png", "2.0", EPackageStatus.Installed));
    }

    public async Task<string> CheckForUpdateAsync(RemotePackageModel model, bool prerelease = false)
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

    public async Task InstallAsync(RemotePackageModel package)
    {
        //_progressService.IsIndeterminate = true;

        // get remote version
        var version = await CheckForUpdateAsync(package);
        if (string.IsNullOrEmpty(version))
        {
            // todo logging
            return;
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
                var owner = package.Url.Split('/').First();
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

                return;
            }

            if (!asset.Any())
            {
                return;
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
                    return;
                }

                await using var fs = new FileStream(zipPath, System.IO.FileMode.Create);
                // TODO report progress here
                await response.Content.CopyToAsync(fs);
            }
        }

        //_progressService.IsIndeterminate = false;

        //TODO

        //var pluginViewModel = Plugins.FirstOrDefault(x => x.Id == id);
        var installedFiles = new List<string>();
        // extract zip file
        // installedFiles = await Task.Run(() => ExtractZip(zipPath, pluginViewModel.InstallPath));


        //// update list
        //if (installedFiles.Count > 0)
        //{
        //    pluginViewModel.Status = EPluginStatus.Latest;
        //    pluginViewModel.Version = version;

        //    pluginViewModel.SetModel(new PluginModel(id, version, installedFiles));
        //}

        // save
        await SaveAsync();
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

    public Task SaveAsync() => throw new NotImplementedException();
}

