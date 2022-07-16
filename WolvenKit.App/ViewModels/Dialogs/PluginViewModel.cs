using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public record PluginModel(EPlugin Id, string Version, List<string> Files);


    public class PluginViewModel : ReactiveObject
    {
        private readonly IPluginService _pluginService;
        private readonly ILoggerService _loggerService;

        private PluginModel _pluginModel;

        public PluginViewModel(IPluginService pluginService, ILoggerService loggerService, PluginModel plugin, string installPath)
        {
            _pluginService = pluginService;
            _loggerService = loggerService;

            _pluginModel = plugin;

            InstallPath = installPath;
            Version = plugin.Version;

            InstallCommand = ReactiveCommand.CreateFromTask(InstallAsync, this.WhenAnyValue(x => x.IsBusy, (busy) => !busy));
            OpenCommand = ReactiveCommand.Create(Open);
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

        public EPlugin Id => _pluginModel.Id;
        public string Name => Id.GetDisplayName();
        public string Description => Id.GetDescription();

        public string InstallPath { get; init; }

        [Reactive] public string Version { get; set; }
        [Reactive] public EPluginStatus Status { get; set; }
        [Reactive] public string Label { get; set; }
        [Reactive] public bool IsBusy { get; set; }
        [Reactive] public bool IsNotInstalled { get; set; }
        [Reactive] public bool IsOpenEnabled { get; set; } // = IsInstalled


        public ICommand OpenCommand { get; init; }
        private void Open() => Commonfunctions.ShowFolderInExplorer(InstallPath);

        public ICommand RemoveCommand { get; init; }
        private async Task RemoveAsync()
        {
            IsBusy = true;

            await _pluginService.RemovePluginAsync(Id);

            IsBusy = false;
        }

        public ICommand InstallCommand { get; init; }
        private async Task InstallAsync()
        {
            IsBusy = true;

            switch (Status)
            {
                case EPluginStatus.NotInstalled:
                {
                    await _pluginService.InstallPluginAsync(Id);
                    break;
                }
                case EPluginStatus.Outdated:
                {
                    await _pluginService.InstallPluginAsync(Id);
                    break;
                }
                case EPluginStatus.Latest:
                    //repair
                    // delete
                    await _pluginService.RemovePluginAsync(Id);
                    // reinstall
                    await _pluginService.InstallPluginAsync(Id);
                    break;
                default:
                    break;
            }

            IsBusy = false;
        }

        internal PluginModel GetModel() => _pluginModel;
        internal void SetModel(PluginModel model) => _pluginModel = model;
    }


}
