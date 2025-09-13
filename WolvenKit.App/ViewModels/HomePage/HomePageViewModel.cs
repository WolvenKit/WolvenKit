using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

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
    private readonly AppViewModel _appViewModel;
    private readonly ISettingsManager _settingsManager;

    public HomePageViewModel(AppViewModel appViewModel, ISettingsManager settingsManager)
    {
        _appViewModel = appViewModel;
        _settingsManager = settingsManager;
    }

    [ObservableProperty]
    private int _selectedIndex;

    public string VersionNumber => _settingsManager.GetVersionNumber();


    [RelayCommand]
    private void CloseHomePage()
    {
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public void NavigateTo(EHomePage page) => SelectedIndex = (int)page;

    [RelayCommand]
    private void CheckForUpdates() => _appViewModel.CheckForUpdatesCommand.Execute(false);

}
