using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using gpm.Core.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Serilog;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Dialogs
{


    public class PluginsToolViewModel : DialogViewModel
    {
        private readonly ILoggerService _logger;
        [Reactive] public IPluginService _pluginService { get; set; }

        private readonly ILibraryService _libraryService;
        private readonly IGitHubService _gitHubService;
        private readonly ITaskService _taskService;


        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        public PluginsToolViewModel()
        {
            _logger = Locator.Current.GetService<ILoggerService>();
            _pluginService = Locator.Current.GetService<IPluginService>();

            _libraryService = Locator.Current.GetService<ILibraryService>();
            _gitHubService = Locator.Current.GetService<IGitHubService>();
            _taskService = Locator.Current.GetService<ITaskService>();

            CancelCommand = ReactiveCommand.Create(() => FileHandler(null));
            SyncCommand = ReactiveCommand.Create(SyncAsync);

            _pluginService.Init();
        }


        [Reactive] public PluginViewModel SelectedPlugin { get; set; }


        public ICommand CancelCommand { get; private set; }

        //public ICommand StartCommand { get; private set; }
        public ICommand SyncCommand { get; private set; }
        public async Task SyncAsync()
        {
            _taskService.Upgrade();

            foreach (var plugin in _pluginService.Plugins)
            {
                var package = plugin.Package;

                // hack for supporting redmod
                if (plugin.Plugin == EPlugin.redmod)
                {
                    var redModLocalversion = "";
                    var redModManifest = Path.Combine(new FileInfo(plugin.InstallPath).Directory.FullName, "manifest.txt");
                    if (File.Exists(redModManifest))
                    {
                        redModLocalversion = File.ReadAllText(redModManifest);

                        // remoteVersion
                        // REDMODTODO
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

                    continue;
                }

                // get the latest release
                if (!(await _gitHubService.TryGetRelease(package, ""))
                .Out(out var release))
                {
                    continue;
                }
                if (release is null)
                {
                    continue;
                }

                var installedVersion = "";
                EPluginStatus status;

                // check if installed
                if (!_libraryService.TryGetValue(package.Id, out var model))
                {
                    // not installed
                    status = EPluginStatus.NotInstalled;
                }
                else
                {
                    // installed but not in Library => should never happen
                    if (!_libraryService.IsInstalledAtLocation(package, plugin.InstallPath, out var slotIdx))
                    {
                        status = EPluginStatus.NotInstalled;
                    }
                    else
                    {
                        // check if latest version is installed
                        installedVersion = model.Slots[slotIdx.Value].Version;
                        if (release.TagName == installedVersion)
                        {
                            Log.Information("[{Package}] Latest release installed", package);
                            status = EPluginStatus.Latest;
                        }
                        else
                        {
                            Log.Information("[{Package}] Update available", package);
                            status = EPluginStatus.Outdated;
                        }
                    }
                }

                plugin.Status = status;
                plugin.Version = installedVersion;
                plugin.ReleaseModel = release;
                plugin.IsEnabled = true;
            }

            _logger.Info("Check for updates finished");
        }


    }


}
