using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        public readonly AppViewModel MainViewModel;

        public ISettingsManager Settings { get; set; }

        public SettingsPageViewModel(
            AppViewModel mainViewModel,
            ISettingsManager settingsManager
        )
        {
            MainViewModel = mainViewModel;
            Settings = settingsManager;
        }
    }
}
