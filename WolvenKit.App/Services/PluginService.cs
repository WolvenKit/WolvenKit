using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Functionality.Services
{
    public class PluginService : ReactiveObject, IPluginService
    {
        private readonly ILoggerService _logger;
        private readonly ISettingsManager _settings;

        private readonly Dictionary<EPlugin, string> _pluginIds = new();

        public PluginService(
            ILoggerService loggerService,
            ISettingsManager settingsManager)
        {
            _logger = loggerService;
            _settings = settingsManager;
        }

        [Reactive] public ObservableCollection<PluginViewModel> Plugins { get; set; } = new ObservableCollection<PluginViewModel>();

        public void Init()
        {
            if (!Directory.Exists(_settings.GetRED4GameRootDir()))
            {
                _logger.Error("No gamedirectory found. Please select the game in your settings");
                return;
            }

            // Add plugins
            if (!_pluginIds.ContainsKey(EPlugin.redscript))
            {
                _pluginIds.Add(EPlugin.redscript, Path.Combine(_settings.GetRED4GameRootDir()));
            }

            if (!_pluginIds.ContainsKey(EPlugin.cyberenginetweaks))
            {
                _pluginIds.Add(EPlugin.cyberenginetweaks, Path.Combine(_settings.GetRED4GameRootDir()));
            }

            if (!_pluginIds.ContainsKey(EPlugin.mlsetupbuilder))
            {
                _pluginIds.Add(EPlugin.mlsetupbuilder, Path.Combine(_settings.GetRED4GameRootDir(), "tools", "neurolinked", "mlsetupbuilder"));
            }

            Plugins.Clear();

            foreach (var (id, installPath) in _pluginIds)
            {
                var name = id.GetName();


                //var installedVersion = "";
                //EPluginStatus status;



                //Plugins.Add(new PluginViewModel(id, package, null, installPath)
                //{
                //    Status = status,
                //    Version = installedVersion
                //});
            }
        }

        public bool IsInstalled(EPlugin pluginName)
        {
            var p = Plugins.FirstOrDefault(x => x.Plugin == pluginName);
            return p is not null && p.Status != EPluginStatus.NotInstalled;
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
