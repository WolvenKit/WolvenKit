using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using gpm.Core.Models;
using gpm.Core.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Core;

namespace WolvenKit.ViewModels.Dialogs
{
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
            OpenCommand = ReactiveCommand.Create(OpenAsync);
            RemoveCommand = ReactiveCommand.Create(RemoveAsync);


            this.WhenAnyValue(x => x.Status).Subscribe(status =>
            {
                switch (status)
                {
                    case EPluginStatus.NotInstalled:
                        IsOpenEnabled = false;
                        IsNotInstalled = true;
                        Label = "Install";
                        break;
                    case EPluginStatus.Outdated:
                        IsOpenEnabled = true;
                        IsNotInstalled = false;
                        Label = "Updated";
                        break;
                    case EPluginStatus.Latest:
                        IsOpenEnabled = true;
                        IsNotInstalled = false;
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
        [Reactive] public bool IsNotInstalled { get; set; }
        [Reactive] public bool IsOpenEnabled { get; set; } // = IsInstalled


        public ICommand InstallCommand { get; private set; }
        public ICommand OpenCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }

        private async Task OpenAsync()
        {
            // TODO
            await Task.Delay(1);
        }

        private async Task RemoveAsync()
        {
            IsBusy = true;

            var result = await _taskService.Remove(_package.Id, false, _installPath, null);
            if (result)
            {
                Status = EPluginStatus.NotInstalled;
                Version = "";
            }

            IsBusy = false;
        }

        private async Task InstallAsync()
        {
            if (_releaseModel == null)
            {
                return;
            }

            IsBusy = true;

            switch (Status)
            {
                case EPluginStatus.NotInstalled:
                {
                    if (!Directory.Exists(_installPath))
                    {
                        Directory.CreateDirectory(_installPath);
                    }
                    var result = await _taskService.Install(_package.Id, "", _installPath, false);
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                        Version = _releaseModel.TagName;
                    }
                    break;
                }
                case EPluginStatus.Outdated:
                {
                    var result = await _taskService.Update(_package.Id, false, _installPath, null, "");
                    if (result)
                    {
                        Status = EPluginStatus.Latest;
                        Version = _releaseModel.TagName;
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

            //await Task.Run(async () =>
            //{

            //    IsBusy = true;
            //    await Task.Delay(1);

            //});

            IsBusy = false;
        }
    }


}
