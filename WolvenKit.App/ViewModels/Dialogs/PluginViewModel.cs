using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using gpm.Core;
using WolvenKit.Common.Services;
using gpm.Core.Services;
using System.Collections.Generic;
using Serilog;
using gpm.Core.Models;
using WolvenKit.Functionality.Commands;

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

        private readonly List<string> _pluginIds = new() {
            "jac3km4/redscript",
            "yamashi/cyberenginetweaks",
            "neurolinked/mlsetupbuilder",
            "redmod"
        };

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



            StartCommand.SafeExecute();
        }

        public async Task StartAsync()
        {
            // TODO: needed?
            _taskService.Upgrade();

            foreach (var name in _pluginIds)
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

                var status = EPluginStatus.NotInstalled;
                var installPath = Path.Combine(_settings.GetRED4GameRootDir(), "tools", package.Id);
                if (!Directory.Exists(installPath))
                {
                    Directory.CreateDirectory(installPath);
                }

                // check if installed
                if (!_libraryService.TryGetValue(package.Id, out var model))
                {
                    // not installed
                    // TODO: display => "Install"
                    status = EPluginStatus.NotInstalled;
                }
                else
                {
                    //TODO where are they installed?
                    
                    // installed but not in Library => should never happen
                    if (!_libraryService.IsInstalledAtLocation(package, installPath, out var slotIdx))
                    {
                        Log.Warning("[{Package}] Package not installed in {Path} Use gpm install to install a package", package,
                            installPath);
                        continue;
                    }

                    // TODO switch between "Update" and "Repair"

                    // check if latest version is installed
                    if (release.TagName == model.Slots[slotIdx.Value].Version)
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

                Plugins.Add(new PluginModel(package, release, _taskService, installPath)
                {
                    Status = status
                });
            }
        }

       


        [Reactive] public ObservableCollection<PluginModel> Plugins { get; set; } = new ObservableCollection<PluginModel>();


        [Reactive] public PluginModel SelectedPlugin { get; set; }

        

        public ICommand CancelCommand { get; private set; }
        public ICommand StartCommand { get; private set; }
    }

    public class PluginModel : ReactiveObject
    {
        private readonly ITaskService _taskService;

        private readonly string _installPath;
        private readonly Package _package;
        private readonly ReleaseModel _releaseModel = null;

        public string Name { get; }
        public string Description { get; }

        public string Version { get; set; }

        public PluginModel(
            Package package,
            ReleaseModel releaseModel,
            ITaskService taskService,
            string installPath)
        {
            _taskService = taskService;

            _installPath = installPath;
            _releaseModel = releaseModel;
            _package = package;

            Name = package.Name;
            Description = package.Description;

            InstallCommand = ReactiveCommand.Create(InstallAsync, this.WhenAnyValue(
                x => x.IsBusy,
                (installed) =>
                    !installed));
           

            this.WhenAnyValue(x => x.Status).Subscribe(status =>
            {
                switch (status)
                {
                    case EPluginStatus.NotInstalled:
                        Label = "Install";
                        break;
                    case EPluginStatus.Outdated:
                        Label = "Updated";
                        break;
                    case EPluginStatus.Latest:
                        Label = "Repair";
                        break;
                    default:
                        break;
                }
            });
        }

        [Reactive] public EPluginStatus Status { get; set; }
        [Reactive] public string Label { get; set; }

        [Reactive] public bool IsBusy { get; set; }


        public ICommand InstallCommand { get; private set; }
        

        private async Task InstallAsync()
        {
            if (_releaseModel == null)
            {
                return;
            }

            //_progressService.IsIndeterminate = true;

            switch (Status)
            {
                case EPluginStatus.NotInstalled:
                {
                    var result = await _taskService.Install(_package.Id, "", _installPath, false);
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                    }
                    break;
                }
                case EPluginStatus.Outdated:
                {
                    var result = await _taskService.Update(_package.Id, false, _installPath, null, "");
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                    }
                    break;
                }
                case EPluginStatus.Latest:
                    return;
                default:
                    break;
            }

            await Task.Run(async () =>
            {

                IsBusy = true;
                await Task.Delay(1);

            });

            //_progressService.IsIndeterminate = false;
        }
    }


}
