using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Factories;

public interface IPageViewModelFactory
{
    public HomePageViewModel HomePageViewModel(AppViewModel appViewModel);
}
