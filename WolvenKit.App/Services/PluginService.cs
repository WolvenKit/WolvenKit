using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ViewModels.Dialogs;
using System.IO;
using gpm.Core.Services;
using WolvenKit.Common.Services;
using System.Diagnostics.CodeAnalysis;

namespace WolvenKit.Functionality.Services
{
    public class PluginService : ReactiveObject, IPluginService
    {
        private readonly ILoggerService _logger;
        private readonly ISettingsManager _settings;
        private readonly IDataBaseService _dataBaseService;
        private readonly ILibraryService _libraryService;
        private readonly ITaskService _taskService;

        private readonly Dictionary<EPlugin, string> _pluginIds = new();

        public PluginService(
            ILoggerService loggerService,
            ISettingsManager settingsManager,
            IDataBaseService dataBaseService,
            ILibraryService libraryService,
            ITaskService taskService)
        {
            _logger = loggerService;
            _settings = settingsManager;
            _dataBaseService = dataBaseService;
            _libraryService = libraryService;
            _taskService = taskService;

            // Add plugins
            _pluginIds.Add(EPlugin.redscript,
                Path.Combine(_settings.GetRED4GameRootDir()));
            _pluginIds.Add(EPlugin.cyberenginetweaks,
                Path.Combine(_settings.GetRED4GameRootDir()));
            _pluginIds.Add(EPlugin.mlsetupbuilder,
                Path.Combine(_settings.GetRED4GameRootDir(), "tools", "neurolinked/mlsetupbuilder"));


            Init();
        }

        [Reactive] public ObservableCollection<PluginViewModel> Plugins { get; set; } = new ObservableCollection<PluginViewModel>();

        private void Init()
        {
            Plugins.Clear();

            foreach (var (id, installPath) in _pluginIds)
            {
                var name = id.GetName();
                var package = _dataBaseService.GetPackageFromName(name);
                if (package is null)
                {
                    _logger.Warning($"[{package}] Package {name} not found");
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
                        //if (release.TagName == installedVersion)
                        //{
                        //    Log.Information("[{Package}] Latest release installed", package);
                        //    status = EPluginStatus.Latest;
                        //}
                        //else
                        {
                            _logger.Info($"[{package}] Update available");
                            status = EPluginStatus.Outdated;
                        }
                    }
                }

                Plugins.Add(new PluginViewModel(id, package, null, _taskService, installPath)
                {
                    Status = status,
                    Version = installedVersion
                });
            }
        }

        public bool IsInstalled(EPlugin pluginName)
        {
            var p = Plugins.FirstOrDefault(x => x.Plugin == pluginName);
            if (p == null)
            {
                return false;
            }
            else
            {
                return p.Status != EPluginStatus.NotInstalled;
            }
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
                path = Plugins.FirstOrDefault(x => x.Plugin == plugin).InstallPath;
                return true;
            }
        }
    }
}
