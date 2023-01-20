using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public record PluginModel(EPlugin Id, string Version, List<string> Files);


    public class PluginViewModel : ReactiveObject
    {
        private readonly IPluginService _pluginService;
        private readonly ILoggerService _loggerService;
        private readonly IProgressService<double> _progressService;

        private PluginModel _pluginModel;

        public PluginViewModel(
            IPluginService pluginService,
            ILoggerService loggerService,
            IProgressService<double> progressService,
            PluginModel plugin,
            string installPath)
        {
            _pluginService = pluginService;
            _loggerService = loggerService;
            _progressService = progressService;

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
                    case EPluginStatus.Installed:
                        break;
                    default:
                        break;
                }
            });

            _ = Observable.FromEventPattern<EventHandler<double>, double>(
                handler => _progressService.ProgressChanged += handler,
                handler => _progressService.ProgressChanged -= handler)
                .Select(_ => _.EventArgs * 100)
                .ToProperty(this, x => x.Progress, out _progress);

            _ = _progressService
                .WhenAnyValue(x => x.IsIndeterminate)
                .ToProperty(this, x => x.IsIndeterminate, out _isIndeterminate);

            _ = _progressService.WhenAnyValue(x => x.IsIndeterminate).Subscribe(b => IsIndeterminate = b);
        }

        public EPlugin Id => _pluginModel.Id;
        public string Name => Id.GetDisplayName();
        public string Description => Id.GetDescription();

        public string InstallPath { get; init; }

        [Reactive] public string Version { get; set; }
        [Reactive] public EPluginStatus Status { get; set; }
        [Reactive] public string? Label { get; set; }

        private readonly ObservableAsPropertyHelper<bool> _isIndeterminate;
        [Reactive] public bool IsIndeterminate { get; set; }
        [Reactive] public bool IsBusy { get; set; }

        private readonly ObservableAsPropertyHelper<double> _progress;
        public double Progress => _progress.Value;
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
                case EPluginStatus.Installed:
                    break;
                default:
                    break;
            }

            IsBusy = false;
            _progressService.IsIndeterminate = false;
        }

        internal PluginModel GetModel() => _pluginModel;
        internal void SetModel(PluginModel model) => _pluginModel = model;
    }


}
