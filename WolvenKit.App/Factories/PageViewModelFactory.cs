using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Factories;

public class PageViewModelFactory : IPageViewModelFactory
{
    private readonly ISettingsManager _settingsManager;
    private readonly IPluginService _pluginService;

    public PageViewModelFactory(
        ISettingsManager settingsManager, 
        IPluginService pluginService)
    {
        _settingsManager = settingsManager;
        _pluginService = pluginService;
    }
    public HomePageViewModel HomePageViewModel(AppViewModel appViewModel) => new(appViewModel, _settingsManager, _pluginService);
}