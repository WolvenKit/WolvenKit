using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Core;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Functionality.Services
{
    public class PluginService : ReactiveObject, IPluginService
    {
        private const string _pluginFileName = "wolvenkit_plugins.json";

        private readonly ILoggerService _loggerService;
        private readonly ISettingsManager _settings;
        private readonly IProgressService<double> _progressService;

        private readonly HttpClient _client = new();
        private readonly Dictionary<EPlugin, string> _pluginIds = new();

        public PluginService(
            ILoggerService loggerService,
            IProgressService<double> progressService,
            ISettingsManager settingsManager)
        {
            _loggerService = loggerService;
            _settings = settingsManager;
            _progressService = progressService;
        }

        [Reactive] public ObservableCollection<PluginViewModel> Plugins { get; set; } = new ObservableCollection<PluginViewModel>();


        public void Init()
        {
            if (!Directory.Exists(_settings.GetRED4GameRootDir()))
            {
                _loggerService.Error("No gamedirectory found. Please select the game in your settings");
                return;
            }

            InitPlugins();

            PopulatePlugins();
        }

        private void PopulatePlugins()
        {
            // check installed plugins json
            var pluginManifestDir = Path.Combine(_settings.GetRED4GameRootDir(), "tools");
            if (!Directory.Exists(pluginManifestDir))
            {
                Directory.CreateDirectory(pluginManifestDir);
            }

            var pluginManifestPath = Path.Combine(pluginManifestDir, _pluginFileName);
            var pluginManifestDict = new Dictionary<EPlugin, PluginModel>();
            if (File.Exists(pluginManifestPath))
            {
                var pluginManifest = File.ReadAllText(pluginManifestPath);
                try
                {
                    pluginManifestDict = JsonSerializer.Deserialize<Dictionary<EPlugin, PluginModel>>(pluginManifest, new JsonSerializerOptions() { WriteIndented = true });
                }
                catch (System.Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }

            // populate installed plugins
            Plugins.Clear();
            foreach (var (id, installPath) in _pluginIds)
            {
                if (pluginManifestDict.TryGetValue(id, out var model))
                {
                    // is installed
                    if (!string.IsNullOrEmpty(model.Version) && model.Files.Count > 0)
                    {
                        Plugins.Add(new PluginViewModel(this, _loggerService, _progressService, model, installPath)
                        {
                            Status = EPluginStatus.Outdated, // TODO plugins: make this better
                        });
                    }
                    else
                    {
                        // TODO plugins: some smart check if something is installed


                        Plugins.Add(new PluginViewModel(this, _loggerService, _progressService, model, installPath)
                        {
                            Status = EPluginStatus.NotInstalled,
                        });
                    }
                }
                else
                {
                    // this should only happen the very first time
                    Plugins.Add(new PluginViewModel(this, _loggerService, _progressService, new PluginModel(id, null, new()), installPath)
                    {
                        Status = EPluginStatus.NotInstalled
                    });
                }


                // Redmod
                if (id == EPlugin.redmod)
                {
                    var plugin = Plugins.FirstOrDefault(x => x.Id == id);
                    var redMod = Path.Combine(installPath, "redMod.exe");
                    if (File.Exists(redMod))
                    {
                        // TODO remoteVersion
                        // TODO add redmod version.txt

                        var redModLocalversion = "1.0";
                        var redModRemoteVersion = "1.0";

                        if (redModLocalversion != redModRemoteVersion)
                        {
                            plugin.Status = EPluginStatus.Outdated;
                            plugin.Version = redModLocalversion;
                        }
                        else
                        {
                            plugin.Status = EPluginStatus.Latest;
                            plugin.Version = redModLocalversion;
                        }
                    }
                }
            }
        }

        private void InitPlugins()
        {
            _pluginIds.Clear();

            foreach (var item in Enum.GetValues<EPlugin>())
            {
                switch (item)
                {
                    case EPlugin.cyberenginetweaks:
                    case EPlugin.redscript:
                    case EPlugin.red4ext:
                    case EPlugin.tweakXL:
                        _pluginIds.Add(item, Path.Combine(_settings.GetRED4GameRootDir()));
                        break;
                    case EPlugin.mlsetupbuilder:
                        _pluginIds.Add(item, Path.Combine(_settings.GetRED4GameRootDir(), "tools", "neurolinked", "mlsetupbuilder"));
                        break;
                    case EPlugin.wolvenkit_resources:
                        _pluginIds.Add(item, Path.Combine(_settings.GetRED4GameRootDir(), "tools", "wolvenkit", "wolvenkit-resources"));
                        break;
                    case EPlugin.redmod:
                        _pluginIds.Add(item, Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "bin"));
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public async Task CheckForUpdatesAsync()
        {
            foreach (var plugin in Plugins)
            {
                if (plugin.Id == EPlugin.redmod)
                {
                    // handle redmod differently for now
                    var redmodPath = Path.Combine(plugin.InstallPath, "redMod.exe");

                    // get version and status
                    //var rmStatus = EPluginStatus.NotInstalled;
                    //var version = "";
                    if (File.Exists(redmodPath))
                    {
                        var redModManifest = Path.Combine(plugin.InstallPath, "version.txt");
                        if (File.Exists(redModManifest))
                        {
                            plugin.Version = File.ReadAllText(redModManifest);
                            var redModRemoteVersion = "1.0";

                            plugin.Status = plugin.Version != redModRemoteVersion ? EPluginStatus.Outdated : EPluginStatus.Latest;
                        }
                        else
                        {
                            plugin.Status = EPluginStatus.Outdated;
                        }
                    }

                    continue;
                }

                if (plugin.Status == EPluginStatus.NotInstalled)
                {
                    continue;
                }

                var response = await CheckForUpdateAsync(plugin.Id);
                if (response is null)
                {
                    return;
                }
                var remoteVersion = response.RequestMessage.RequestUri.LocalPath.Split('/').Last();

                if (remoteVersion != plugin.Version)
                {
                    plugin.Status = EPluginStatus.Outdated;
                }
            }
        }

        public bool IsInstalled(EPlugin pluginName)
        {
            var p = Plugins.FirstOrDefault(x => x.Id == pluginName);
            return p is not null && !string.IsNullOrEmpty(p.Version);
        }

        public async Task InstallPluginAsync(EPlugin id)
        {
            if (id == EPlugin.redmod)
            {
                var res = await Interactions.ShowMessageBoxAsync("Please install RedMod with GOG or Steam.", "RedMod", WMessageBoxButtons.Ok);
                _loggerService.Warning("Install RedMod with GOG or Steam.");
                return;
            }

            _progressService.IsIndeterminate = true;

            // check remote version (no github API call)
            var response = await CheckForUpdateAsync(id);
            if (response is null)
            {
                return;
            }
            var version = response.RequestMessage.RequestUri.LocalPath.Split('/').Last().TrimStart('v');

            var fileName = id.GetFile().Replace(@".*\", version);
            // TODO check if asset is already downloaded
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
                    var releases = await ghClient.Repository.Release.GetAll(id.GetUrl().Split('/').First(), id.GetUrl().Split('/').Last());
                    var latest = releases[0];
                    var assets = latest.Assets.ToList();
                    asset = assets.Where(x => Regex.IsMatch(x.Name, id.GetFile()));
                }
                catch (Octokit.ApiException)
                {
                    // Prior to first API call, this will be null, because it only deals with the last call.
                    var apiInfo = ghClient.GetLastApiInfo();
                    var rateLimit = apiInfo?.RateLimit;
                    var howManyRequestsCanIMakePerHour = rateLimit?.Limit;
                    var howManyRequestsDoIHaveLeft = rateLimit?.Remaining;
                    var whenDoesTheLimitReset = rateLimit?.Reset; // UTC time
                    _loggerService.Info($"[Update] {howManyRequestsDoIHaveLeft}/{howManyRequestsCanIMakePerHour} - reset: {whenDoesTheLimitReset ?? whenDoesTheLimitReset.Value.ToLocalTime()}");

                    _loggerService.Error("API rate limit exceeded");

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
                    response = await _client.GetAsync(new Uri(contentUrl));
                    try
                    {
                        response.EnsureSuccessStatusCode();
                    }
                    catch (HttpRequestException ex)
                    {
                        _loggerService.Error($"Failed to respond to url: {contentUrl}");
                        _loggerService.Error(ex);
                        return;
                    }

                    await using var fs = new FileStream(zipPath, System.IO.FileMode.Create);
                    // TODO report progress here
                    await response.Content.CopyToAsync(fs);
                }
            }

            _progressService.IsIndeterminate = false;

            var pluginViewModel = Plugins.FirstOrDefault(x => x.Id == id);
            var installedFiles = new List<string>();
            // extract zip file
            switch (id)
            {
                case EPlugin.red4ext:
                case EPlugin.tweakXL:
                case EPlugin.cyberenginetweaks:
                case EPlugin.redscript:
                case EPlugin.mlsetupbuilder:
                    installedFiles = await Task.Run(() => ExtractZip(zipPath, pluginViewModel.InstallPath));
                    break;
                case EPlugin.wolvenkit_resources:
                    installedFiles = await Task.Run(() => InstallResources(zipPath, pluginViewModel.InstallPath));
                    break;
                case EPlugin.redmod:
                    break;
                default:
                    throw new NotImplementedException();
            }

            // update list
            if (installedFiles.Count > 0)
            {
                pluginViewModel.Status = EPluginStatus.Latest;
                pluginViewModel.Version = version;

                pluginViewModel.SetModel(new PluginModel(id, version, installedFiles));
            }

            // save
            await SerializeAsync();
        }

        private List<string> InstallResources(string zipPath, string extractPath)
        {

            // unzip multiple resources
            var resources = ExtractZip(zipPath, extractPath);
            var result = new List<string>(resources);

            foreach (var resource in resources)
            {
                // TODO plugins refactor this
                switch (Path.GetFileName(resource))
                {
                    case Common.Constants.RedDbKark:

                        // unkark reddb
                        var destinationPath = Path.Combine(ISettingsManager.GetAppData(), Common.Constants.RedDb);

                        var (hash, _) = CommonFunctions.HashFileSHA512(resource);

                        if (!File.Exists(destinationPath))
                        {
                            Oodle.OodleTask(resource, destinationPath, true, false);
                            _settings.ReddbHash = hash;
                            _settings.Save();
                        }
                        else
                        {
                            if (!hash.Equals(_settings.ReddbHash))
                            {
                                _loggerService.Info($"old hash: {_settings.ReddbHash}, new hash: {hash}. Updating reddb");
                                Oodle.OodleTask(resource, destinationPath, true, false);
                                _settings.ReddbHash = hash;
                                _settings.Save();
                            }
                        }

                        result.Add(destinationPath);
                        break;
                    default:
                        break;
                }
            }

            return result;
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
                _progressService.IsIndeterminate = false;
                _progressService.Report(10);
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
                    _progressService.Report(progress / (float)archive.Entries.Count);
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Failed to extract plugin zip: {zipPath}");
                _loggerService.Error(ex);

                files.Clear();
            }

            return files;
        }

        public async Task RemovePluginAsync(EPlugin id)
        {
            if (id == EPlugin.redmod)
            {
                var res = await Interactions.ShowMessageBoxAsync("Please remove RedMod with GOG or Steam.", "RedMod", WMessageBoxButtons.Ok);

                _loggerService.Warning("Remove RedMod with GOG or Steam.");
                return;
            }

            var vm = Plugins.FirstOrDefault(x => x.Id == id);
            if (vm is null)
            {
                return;
            }

            // delete installed files
            foreach (var file in vm.GetModel().Files)
            {
                if (File.Exists(file))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        _loggerService.Error($"Failed to delete file {file}");
                        _loggerService.Error(ex);
                    }
                }
            }

            // update plugin status
            vm.Status = EPluginStatus.NotInstalled;
            vm.Version = "";

            vm.SetModel(new(id, null, null));

            // save
            await SerializeAsync();
        }

        public bool TryGetInstallPath(EPlugin plugin, [NotNullWhen(true)] out string path)
        {
            if (!IsInstalled(plugin))
            {
                path = null;
                return false;
            }
            else
            {
                path = Plugins.FirstOrDefault(x => x.Id == plugin).InstallPath;
                return true;
            }
        }

        private async Task SerializeAsync()
        {
            var pluginManifestDict = new Dictionary<EPlugin, PluginModel>();
            foreach (var plugin in Plugins)
            {
                pluginManifestDict[plugin.Id] = plugin.GetModel();
            }

            var pluginManifestDir = Path.Combine(_settings.GetRED4GameRootDir(), "tools");
            if (!Directory.Exists(pluginManifestDir))
            {
                Directory.CreateDirectory(pluginManifestDir);
            }

            var pluginManifestPath = Path.Combine(pluginManifestDir, _pluginFileName);
            using var fs = new FileStream(pluginManifestPath, FileMode.Create);
            await JsonSerializer.SerializeAsync(fs, pluginManifestDict, new JsonSerializerOptions() { WriteIndented = true });
        }

        private async Task<HttpResponseMessage> CheckForUpdateAsync(EPlugin id)
        {
            var githuburl = $@"https://github.com/{id.GetUrl()}/releases/latest";
            var response = await _client.GetAsync(new Uri(githuburl));

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                _loggerService.Error($"Failed to respond to url: {githuburl}");
                _loggerService.Error(ex);
                return null;
            }

            // get tag
            return response;
        }
    }
}
