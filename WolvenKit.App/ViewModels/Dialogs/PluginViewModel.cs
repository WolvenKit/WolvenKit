using System;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using gpm.Core.Models;
using gpm.Core.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public class PluginViewModel : ReactiveObject
    {
        private readonly ITaskService _taskService;
        private readonly ILoggerService _logger;

        public PluginViewModel(EPlugin plugin, string installPath,
            EPluginStatus status, string version,
            string name, string description)
        {
            _taskService = Locator.Current.GetService<ITaskService>();
            _logger = Locator.Current.GetService<ILoggerService>();

            Plugin = plugin;
            InstallPath = installPath;
            Status = status;
            Version = version;
            Name = name;
            Description = description;

            InstallCommand = ReactiveCommand.Create(InstallAsync,
                this.WhenAnyValue(x => x.IsBusy, x => x.ReleaseModel,
                (busy, model) =>
                {
                    if (busy)
                    {
                        return false;
                    }

                    if (Plugin == EPlugin.redmod)
                    {
                        return true;
                    }

                    return model != null;
                }));
            OpenCommand = ReactiveCommand.Create(OpenAsync);
            RemoveCommand = ReactiveCommand.Create(RemoveAsync);

            this.WhenAnyValue(x => x.Status).Subscribe(status =>
            {
                switch (status)
                {
                    case EPluginStatus.NotInstalled:
                        IsUpdateAvailable = true;

                        IsNoUpdateAvailable = !IsUpdateAvailable;
                        Label = "Install";
                        break;
                    case EPluginStatus.Outdated:
                        IsUpdateAvailable = true;

                        IsNoUpdateAvailable = !IsUpdateAvailable;
                        Label = "Update";
                        break;
                    case EPluginStatus.Installed:
                        IsUpdateAvailable = false;

                        IsNoUpdateAvailable = !IsUpdateAvailable;
                        Label = "Check for Updates";
                        break;
                    case EPluginStatus.Latest:
                        IsUpdateAvailable = false;

                        IsNoUpdateAvailable = !IsUpdateAvailable;
                        Label = "Repair";
                        break;
                    default:
                        break;
                }
            });
        }

        public PluginViewModel(
            EPlugin plugin, string installPath,
            EPluginStatus status, string version,
            string name, string description,
            Package package, ReleaseModel releaseModel)
            : this(plugin, installPath, status, version, name, description)
        {
            ReleaseModel = releaseModel;
            Package = package;
        }

        public EPlugin Plugin { get; private set; }
        public string InstallPath { get; private set; }


        public Package Package { get; private set; }
        [Reactive] public ReleaseModel ReleaseModel { get; set; }
        public string Name { get; }
        public string Description { get; }


        [Reactive] public string Version { get; set; }

        [Reactive] public EPluginStatus Status { get; set; }
        [Reactive] public string Label { get; set; }

        [Reactive] public bool IsEnabled { get; set; }
        [Reactive] public bool IsBusy { get; set; }

        [Reactive] public bool IsUpdateAvailable { get; set; }
        [Reactive] public bool IsNoUpdateAvailable { get; set; }


        public ICommand OpenCommand { get; private set; }
        private void OpenAsync()
        {
            switch (Plugin)
            {
                case EPlugin.cyberenginetweaks:
                    _logger.Info("Cannot open cyberenginetweaks.");
                    break;
                case EPlugin.redscript:
                    _logger.Info("Cannot open redscript.");
                    break;
                case EPlugin.mlsetupbuilder:
                    Commonfunctions.ShowFolderInExplorer(InstallPath);
                    break;
                case EPlugin.redmod:
                    _logger.Info("Cannot open redmod - it is a commandline tool.");
                    break;
                default:
                    break;
            }
        }

        public ICommand RemoveCommand { get; private set; }
        private async Task RemoveAsync()
        {
            // hack for redmod
            if (Plugin == EPlugin.redmod)
            {
                IsBusy = true;

                var dir = new FileInfo(InstallPath).Directory;
                foreach (var f in dir.GetFiles())
                {
                    try
                    {
                        f.Delete();
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                if (!dir.GetFiles().Any())
                {
                    dir.Delete();
                }

                IsBusy = false;
                return;
            }

            IsBusy = true;

            var result = await _taskService.Remove(Package.Id, false, InstallPath, null);
            if (result)
            {
                Status = EPluginStatus.NotInstalled;
                Version = "";
            }

            IsBusy = false;
        }

        public ICommand InstallCommand { get; private set; }
        private async Task InstallAsync()
        {
            // hack for redmod
            if (Plugin == EPlugin.redmod)
            {
                IsBusy = true;

                // REDMODTODO

                // get from cdn


                // install


                IsBusy = false;
                return;
            }

            if (ReleaseModel == null)
            {
                return;
            }

            IsBusy = true;

            switch (Status)
            {
                case EPluginStatus.NotInstalled:
                {
                    if (!Directory.Exists(InstallPath))
                    {
                        Directory.CreateDirectory(InstallPath);
                    }
                    var result = await _taskService.Install(Package.Id, "", InstallPath, false);
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                        Version = ReleaseModel.TagName;
                    }
                    break;
                }
                case EPluginStatus.Outdated:
                {
                    var result = await _taskService.Update(Package.Id, false, InstallPath, null, "");
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                        Version = ReleaseModel.TagName;
                    }
                    break;
                }
                case EPluginStatus.Latest:
                    // repair
                    // TODO
                    break;
                default:
                    break;
            }

            IsBusy = false;
        }
    }


}
