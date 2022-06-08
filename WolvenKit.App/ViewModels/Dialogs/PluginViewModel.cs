using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using gpm.Core.Models;
using gpm.Core.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class PluginViewModel : ReactiveObject
    {
        private readonly ITaskService _taskService;

        public EPlugin Plugin { get; private set; }
        public string InstallPath { get; private set; }
        public Package Package { get; private set; }

        public PluginViewModel(
            EPlugin plugin,
            Package package,
            ReleaseModel releaseModel,
            ITaskService taskService,
            string installPath)
        {
            _taskService = taskService;
            Plugin = plugin;

            InstallPath = installPath;
            ReleaseModel = releaseModel;
            Package = package;

            Name = package.Name;
            Description = package.Description;

            InstallCommand = ReactiveCommand.Create(InstallAsync,
                this.WhenAnyValue(x => x.IsBusy, x => x.ReleaseModel,
                (busy, model) => !busy && model != null));
            OpenCommand = ReactiveCommand.Create(OpenAsync);
            RemoveCommand = ReactiveCommand.Create(RemoveAsync);


            _ = this.WhenAnyValue(x => x.Status).Subscribe(status =>
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
                        Label = "Update";
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

        [Reactive] public ReleaseModel ReleaseModel { get; set; }
        public string Name { get; }
        public string Description { get; }
        [Reactive] public string Version { get; set; }

        [Reactive] public EPluginStatus Status { get; set; }
        [Reactive] public string Label { get; set; }

        [Reactive] public bool IsBusy { get; set; }
        [Reactive] public bool IsNotInstalled { get; set; }
        [Reactive] public bool IsOpenEnabled { get; set; } // = IsInstalled


        public ICommand OpenCommand { get; private set; }
        private async Task OpenAsync() =>
            // TODO
            await Task.Delay(1);

        public ICommand RemoveCommand { get; private set; }
        private async Task RemoveAsync()
        {
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
                        _ = Directory.CreateDirectory(InstallPath);
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

            //await Task.Run(async () =>
            //{

            //    IsBusy = true;
            //    await Task.Delay(1);

            //});

            IsBusy = false;
        }
    }


}
