using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ViewModels.Dialogs;
using System.IO;
using WolvenKit.Functionality.Services;
using gpm.Core.Services;
using WolvenKit.Common.Services;

namespace WolvenKit.Functionality.Services
{
    //https://stackoverflow.com/a/4778347
    public static class PluginExtensions
    {
        public static string GetName(this EPlugin p)
        {
            var attr = GetAttr(p);
            return attr.Name;
        }
        private static IdAttribute GetAttr(EPlugin p)
            => (IdAttribute)Attribute.GetCustomAttribute(ForValue(p), typeof(IdAttribute));

        private static MemberInfo ForValue(EPlugin p)
            => typeof(EPlugin).GetField(Enum.GetName(typeof(EPlugin), p));

    }

    public enum EPlugin
    {
        [Id("yamashi/cyberenginetweaks")] cyberenginetweaks,
        [Id("jac3km4/redscript")] redscript,
        [Id("neurolinked/mlsetupbuilder")] mlsetupbuilder,
    }

    internal class IdAttribute : Attribute
    {
        public IdAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    public enum EPluginStatus
    {
        NotInstalled,
        Outdated,
        Latest
    }

    public interface IPluginService
    {
        public ObservableCollection<PluginViewModel> Plugins { get; set; }

        bool IsInstalled(EPlugin pluginName);
    }

    public class PLuginService : ReactiveObject, IPluginService
    {
        private readonly ILoggerService _logger;
        private readonly ISettingsManager _settings;
        private readonly IDataBaseService _dataBaseService;
        private readonly ILibraryService _libraryService;
        private readonly ITaskService _taskService;

        private readonly Dictionary<EPlugin, string> _pluginIds = new();

        public PLuginService(
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
    }
}
