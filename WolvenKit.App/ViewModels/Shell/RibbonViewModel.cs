using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;

namespace WolvenKit.App.ViewModels.Shell;

public partial class RibbonViewModel : ObservableObject
{
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;
    private readonly IGameControllerFactory _gameControllerFactory;

    public RibbonViewModel(
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        IGameControllerFactory gameControllerFactory,
        AppViewModel appViewModel
    )
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;
        _gameControllerFactory = gameControllerFactory;

        MainViewModel = appViewModel;
        MainViewModel.PropertyChanged += MainViewModel_OnPropertyChanged;

        ShowRedmodInRibbon = settingsManager.ShowRedmodInRibbon;

        _settingsManager.PropertyChanged += SettingsManager_PropertyChanged;

        if (!string.IsNullOrEmpty(_settingsManager.LastLaunchProfile))
        {
            _launchProfileText = _settingsManager.LastLaunchProfile;
        }
    }

    private void SettingsManager_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(ISettingsManager.ShowRedmodInRibbon))
        {
            return;
        }

        ShowRedmodInRibbon = _settingsManager.ShowRedmodInRibbon;
    }

    private void MainViewModel_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(MainViewModel.TaskStatus):
                LaunchProfileCommand.NotifyCanExecuteChanged();
                break;
            default:
                break;
        }
    }


    public AppViewModel MainViewModel { get; }


    [RelayCommand]
    private void NewFile() => MainViewModel.NewFileCommand.SafeExecute(null);

    [RelayCommand]
    private void SaveFile() => MainViewModel.SaveFileCommand.SafeExecute();

    [RelayCommand]
    private void SaveAs() => MainViewModel.SaveAsCommand.SafeExecute();

    [RelayCommand]
    private void SaveAll() => MainViewModel.SaveAllCommand.SafeExecute();

    private bool CanStartTask() => MainViewModel.TaskStatus == EStatus.Ready;

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task LaunchProfileAsync()
    {
        if (!await MainViewModel.AreDirtyFilesHandledBeforeLaunch())
        {
            return;
        }

        _settingsManager.LaunchProfiles ??= new Dictionary<string, LaunchProfile>();

        if (LaunchProfileText is not null && _settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out var launchProfile))
        {
            await _gameControllerFactory.GetController().LaunchProject(launchProfile);
            _settingsManager.LastLaunchProfile = LaunchProfileText;
        }
        else
        {
            _loggerService.Error($"No launchprofile with name \"{LaunchProfileText}\" found.");
        }
    }


    [ObservableProperty] private string? _launchProfileText;
    [ObservableProperty] private bool _showRedmodInRibbon;

}
