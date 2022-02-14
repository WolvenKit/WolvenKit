using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Dialogs
{
    public enum EPluginStatus
    {
        NotInstalled,
        Outdated,
        Latest
    }

    public class PluginViewModel : DialogViewModel
    {
        private readonly ILoggerService _logger;
        private readonly ILibraryService _libraryService;
        private readonly ISettingsManager _settings;
        private readonly IDataBaseService _dataBaseService;
        private readonly IGitHubService _gitHubService;
        private readonly ITaskService _taskService;

        private readonly Dictionary<string, string> _pluginIds = new();

        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        public PluginViewModel()
        {
            _logger = Locator.Current.GetService<ILoggerService>();
            _libraryService = Locator.Current.GetService<ILibraryService>();
            _dataBaseService = Locator.Current.GetService<IDataBaseService>();
            _gitHubService = Locator.Current.GetService<IGitHubService>();
            _settings = Locator.Current.GetService<ISettingsManager>();
            _taskService = Locator.Current.GetService<ITaskService>();

            CancelCommand = ReactiveCommand.Create(() => FileHandler(null));
            StartCommand = ReactiveCommand.Create(StartAsync);

            // Add plugins
            _pluginIds.Add( "jac3km4/redscript",
                Path.Combine(_settings.GetRED4GameRootDir()));
            _pluginIds.Add("yamashi/cyberenginetweaks",
                Path.Combine(_settings.GetRED4GameRootDir()));
            _pluginIds.Add("neurolinked/mlsetupbuilder",
                Path.Combine(_settings.GetRED4GameRootDir(), "tools", "neurolinked/mlsetupbuilder"));
            _pluginIds.Add("redmod",
                Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod"));


            StartCommand.SafeExecute();
        }

        public async Task StartAsync()
        {
            // TODO: needed?
            _taskService.Upgrade();

            foreach (var (name, installPath) in _pluginIds)
            {
                var package = _dataBaseService.GetPackageFromName(name);
                if (package is null)
                {
                    Log.Warning("[{Package}] Package {Name} not found", package, name);
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
                    // TODO: display => "Install"
                    status = EPluginStatus.NotInstalled;
                }
                else
                {
                    // installed but not in Library => should never happen
                    if (!_libraryService.IsInstalledAtLocation(package, installPath, out var slotIdx))
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

                Plugins.Add(new PluginModel(package, release, _taskService, installPath)
                {
                    Status = status,
                    Version = installedVersion
                });
            }
        }

        [Reactive] public ObservableCollection<PluginModel> Plugins { get; set; } = new ObservableCollection<PluginModel>();

        [Reactive] public PluginModel SelectedPlugin { get; set; }

        public ICommand CancelCommand { get; private set; }

        public ICommand StartCommand { get; private set; }
    }


}
