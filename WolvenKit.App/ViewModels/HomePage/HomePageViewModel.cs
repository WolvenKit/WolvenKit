using System;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.ViewModels.HomePage;

public enum EHomePage
{
    Welcome,
    Mods,
    Plugins,
    Settings,
    Wiki,
    Github,
    Website
}

public partial class HomePageViewModel : ObservableObject
{
    private readonly ISettingsManager _settingsManager;
    private readonly IPluginService _pluginService;
    private readonly AppViewModel _appViewModel;

    public HomePageViewModel(AppViewModel appViewModel, ISettingsManager settingsManager, IPluginService pluginService)
    {
        _settingsManager = settingsManager;
        _pluginService = pluginService;
        _appViewModel = appViewModel;
        
        CurrentWindowState = WindowState.Normal;
    }

    [ObservableProperty]
    private int _selectedIndex;

    public WindowState CurrentWindowState { get; set; }

    public string VersionNumber => _settingsManager.GetVersionNumber();


    [RelayCommand]
    private void CloseHomePage()
    {
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public void NavigateTo(EHomePage page) => SelectedIndex = (int)page;

}
