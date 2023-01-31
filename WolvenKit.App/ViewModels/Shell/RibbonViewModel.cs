using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Shell;

public partial class RibbonViewModel : ObservableObject
{
    private readonly IWatcherService _watcherService;
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;
    private readonly IGameControllerFactory _gameControllerFactory;

    public RibbonViewModel(
        IWatcherService watcherService,
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        IGameControllerFactory gameControllerFactory,
        AppViewModel appViewModel
    )
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;
        _gameControllerFactory = gameControllerFactory;
        _watcherService = watcherService;

        MainViewModel = appViewModel;

        _launchProfileText = "Launch Profiles";
    }



    public AppViewModel MainViewModel { get; }


    [RelayCommand]
    private void NewFile()
    {
        MainViewModel.NewFileCommand.SafeExecute(null);
    }

    [RelayCommand]
    private void SaveFile()
    {
        MainViewModel.SaveFileCommand.SafeExecute();
    }
    
    [RelayCommand]
    private void SaveAs()
    {
        MainViewModel.SaveAsCommand.SafeExecute();
    }

    [RelayCommand]
    private void SaveAll()
    {
        MainViewModel.SaveAllCommand.SafeExecute();
    }

    [RelayCommand]
    private async Task LaunchProfileAsync()
    {
        _settingsManager.LaunchProfiles ??= new();

        if (_settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out var launchProfile))
        {
            _watcherService.IsSuspended = true;
            await _gameControllerFactory.GetController().LaunchProject(launchProfile);
            _watcherService.IsSuspended = false;
            await _watcherService.RefreshAsync(MainViewModel.ActiveProject);
        }
        else
        {
            _loggerService.Error($"No launchprofile with name \"{LaunchProfileText}\" found.");
        }
    }



    [ObservableProperty] private string _launchProfileText;

}
