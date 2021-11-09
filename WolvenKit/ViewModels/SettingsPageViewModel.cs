using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenManager.Installer.Services;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        private readonly IUpdateService _updateService;

        public SettingsPageViewModel(
            IUpdateService updateService,
            ISettingsManager settingsManager
        )
        {
            _updateService = updateService;
            Settings = settingsManager;

            CheckForUpdatesCommand = ReactiveCommand.CreateFromTask(CheckForUpdates);
        }


        public ISettingsManager Settings { get; set; }


        public ReactiveCommand<Unit, Unit> CheckForUpdatesCommand { get; }
        private async Task CheckForUpdates() => await Task.Run(()  => _updateService.CheckForUpdatesAsync());

    }
}
