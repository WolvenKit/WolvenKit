using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public record PluginModel(EPlugin Id, string Version, List<string> Files);


public partial class PluginViewModel : ObservableObject
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
        _version = plugin.Version;

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
            .Subscribe(x => Progress = x);

        _ = _progressService
            .WhenAnyValue(x => x.IsIndeterminate)
            .Subscribe(x => IsIndeterminate = x);

        _ = _progressService.WhenAnyValue(x => x.IsIndeterminate).Subscribe(b => IsIndeterminate = b);
    }

    public EPlugin Id => _pluginModel.Id;
    public string Name => Id.GetDisplayName();
    public string Description => Id.GetDescription();

    public string InstallPath { get; init; }

    [ObservableProperty] private string _version;
    [ObservableProperty] private EPluginStatus _status;
    [ObservableProperty] private string? _label;

    [ObservableProperty] private bool _isIndeterminate;
    [ObservableProperty] private bool _isBusy;

    [ObservableProperty] private double _progress;
    [ObservableProperty] private bool _isNotInstalled;
    [ObservableProperty] private bool _isOpenEnabled; // = IsInstalled


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
