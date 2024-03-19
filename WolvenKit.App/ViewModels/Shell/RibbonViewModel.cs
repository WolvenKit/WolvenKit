using System.ComponentModel;
using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;

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
        MainViewModel.PropertyChanged += MainViewModel_OnPropertyChanged;

        _launchProfileText = "Launch Profiles";
        _launchGameText = "Launch Game";
    }

    private void MainViewModel_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MainViewModel.TaskStatus))
        {
            LaunchProfileCommand.NotifyCanExecuteChanged();
        }
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

    private bool CanStartTask() => MainViewModel.TaskStatus == EStatus.Ready;

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task LaunchProfileAsync()
    {
        _settingsManager.LaunchProfiles ??= new();

        if (_settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out var launchProfile))
        {
            _watcherService.IsSuspended = true;
            await _gameControllerFactory.GetController().LaunchProject(launchProfile);
            _watcherService.IsSuspended = false;
        }
        else
        {
            _loggerService.Error($"No launchprofile with name \"{LaunchProfileText}\" found.");
        }
    }


    [ObservableProperty] private string _launchProfileText;

    [ObservableProperty] private string _launchGameText;

}
