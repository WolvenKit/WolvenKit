using System;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using Splat;
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
    // #needs_MVVM

    #region Fields

    private readonly ISettingsManager _settingsManager;
    private readonly IPluginService _pluginService;

    #endregion Fields

    public HomePageViewModel(ISettingsManager settingsManager, IPluginService pluginService)
    {
        _settingsManager = settingsManager;
        _pluginService = pluginService;

        CurrentWindowState = WindowState.Normal;
    }


    [ObservableProperty] private int _selectedIndex;

    public WindowState CurrentWindowState { get; set; }

    public string VersionNumber => _settingsManager.GetVersionNumber();

    [RelayCommand]
    public void MinimizeWindow()
    {
        SystemCommands.MinimizeWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>().NotNull());
        CurrentWindowState = WindowState.Minimized;
    }

    [RelayCommand]
    private void RestoreWindow()
    {
        if (CurrentWindowState == WindowState.Maximized)
        {
            SystemCommands.RestoreWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>().NotNull());
            CurrentWindowState = WindowState.Normal;
        }
        else
        {
            SystemCommands.MaximizeWindow((Window)Locator.Current.GetService<IViewFor<AppViewModel>>().NotNull());
            CurrentWindowState = WindowState.Maximized;
        }
    }

    [RelayCommand]
    private void CloseHomePage()
    {
        var main = Locator.Current.GetService<AppViewModel>().NotNull();
        main.CloseModalCommand.Execute(null);
    }

    public void NavigateTo(EHomePage page) => SelectedIndex = (int)page;

}
