using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        _progressService.PropertyChanged += ProgressService_PropertyChanged;
        _progressService.ProgressChanged += ProgressService_ProgressChanged;
    }

    private void ProgressService_ProgressChanged(object? sender, double e)
    {
        Progress = e * 100;
    }

    private void ProgressService_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IsIndeterminate))
        {
            IsIndeterminate = _progressService.IsIndeterminate;
        }
    }


    public EPlugin Id => _pluginModel.Id;
    public string Name => Id.GetDisplayName();
    public string Description => Id.GetDescription();

    public string InstallPath { get; init; }

    [ObservableProperty] private string _version;
    
    [ObservableProperty]
    private EPluginStatus _status;
    partial void OnStatusChanged(EPluginStatus value)
    {
        switch (value)
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
                Label = "Reinstall";
                break;
            case EPluginStatus.Installed:
                break;
            default:
                break;
        }
    }

    [ObservableProperty] private string? _label;

    [ObservableProperty] private bool _isIndeterminate;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(InstallCommand))]
    private bool _isBusy;

    [ObservableProperty]
    private double _progress;

    [ObservableProperty]
    private bool _isNotInstalled;

    [ObservableProperty]
    private bool _isOpenEnabled; // = IsInstalled


    [RelayCommand]
    private void Open() => Commonfunctions.ShowFolderInExplorer(InstallPath);

    [RelayCommand]
    private async Task Remove()
    {
        IsBusy = true;

        await _pluginService.RemovePluginAsync(Id);

        IsBusy = false;
    }

    private bool CanInstall() => !IsBusy;
    [RelayCommand]
    private async Task Install()
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
