using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Services;

namespace WolvenKit.App.ViewModels.Shell;

public partial class MenuBarViewModel : ObservableObject
{
    private readonly IProgressService<double> _progressService;
    private readonly IArchiveManager _archiveManager;
    private readonly IModTools _modTools;

    public MenuBarViewModel(
        ISettingsManager settingsManager,
        IProgressService<double> progressService,
        IArchiveManager archiveManager,
        IModTools modTools,
        AppViewModel appViewModel)
    {
        MainViewModel = appViewModel;
        _archiveManager = archiveManager;
        _progressService = progressService;
        _modTools = modTools;
        SettingsManager = settingsManager;
    }

    public ISettingsManager SettingsManager { get; }
    public AppViewModel MainViewModel { get; }

    [RelayCommand]
    private void OpenGameFolder() => Commonfunctions.ShowFolderInExplorer(SettingsManager.GetRED4GameRootDir());

}
