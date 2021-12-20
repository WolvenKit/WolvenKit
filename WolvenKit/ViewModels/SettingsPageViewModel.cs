using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;
using WolvenManager.Installer.Services;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        private readonly IUpdateService _updateService;
        private readonly RibbonViewModel _ribbon;

        public SettingsPageViewModel(
            IUpdateService updateService,
            ISettingsManager settingsManager
        )
        {
            _updateService = updateService;
            _ribbon = Locator.Current.GetService<RibbonViewModel>();
            Settings = settingsManager;

            CheckForUpdatesCommand = ReactiveCommand.CreateFromTask(CheckForUpdates);
            SaveCloseCommand = ReactiveCommand.CreateFromTask(SaveClose);
        }


        public ISettingsManager Settings { get; set; }

        public ReactiveCommand<Unit, Unit> CheckForUpdatesCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveCloseCommand { get; }
        private async Task CheckForUpdates() => await Task.Run(() => _updateService.CheckForUpdatesAsync());
        private async Task SaveClose() => await Task.Run(() => _ribbon.BackstageIsOpen = false);

    }
}
