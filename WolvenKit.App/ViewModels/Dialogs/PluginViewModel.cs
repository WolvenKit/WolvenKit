using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Dialogs
{
    public class PluginViewModel : ReactiveObject
    {
        public EPlugin Plugin { get; private set; }
        public string InstallPath { get; private set; }

        public PluginViewModel(
            EPlugin plugin,
            string installPath)
        {
            Plugin = plugin;

            InstallPath = installPath;

            InstallCommand = ReactiveCommand.Create(InstallAsync,
                this.WhenAnyValue(x => x.IsBusy,
                (busy) => !busy));
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

            await Task.Delay(1);

            IsBusy = false;
        }

        public ICommand InstallCommand { get; private set; }
        private async Task InstallAsync()
        {


            IsBusy = true;

            switch (Status)
            {
                case EPluginStatus.NotInstalled:
                {
                    if (!Directory.Exists(InstallPath))
                    {
                        Directory.CreateDirectory(InstallPath);
                    }
                    await Task.Delay(1);
                    break;
                }
                case EPluginStatus.Outdated:
                {
                    await Task.Delay(1);
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
