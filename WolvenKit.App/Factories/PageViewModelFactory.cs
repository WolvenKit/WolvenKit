using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Factories;

public class PageViewModelFactory : IPageViewModelFactory
{
    private readonly ISettingsManager _settingsManager;

    public PageViewModelFactory(ISettingsManager settingsManager)
    {
        _settingsManager = settingsManager;
    }
    public HomePageViewModel HomePageViewModel(AppViewModel appViewModel) => new(appViewModel, _settingsManager);
}