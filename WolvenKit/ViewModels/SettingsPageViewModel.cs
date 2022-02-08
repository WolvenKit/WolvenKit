using System;
using System.Reactive;
using System.Threading.Tasks;
using gpm.Installer;
using ReactiveUI;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        private readonly AppViewModel _main;
        private readonly ILoggerService _loggerService;
        private readonly AutoInstallerService _autoInstallerService;

        public SettingsPageViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService,
            AutoInstallerService autoInstallerService
        )
        {
            _autoInstallerService = autoInstallerService;

            _main = Locator.Current.GetService<AppViewModel>();

            Settings = settingsManager;
            _loggerService = loggerService;

            CheckForUpdatesCommand = ReactiveCommand.CreateFromTask(CheckForUpdates);
            SaveCloseCommand = ReactiveCommand.CreateFromTask(SaveClose);
        }


        public ISettingsManager Settings { get; set; }

        public ReactiveCommand<Unit, Unit> SaveCloseCommand { get; }

        public ReactiveCommand<Unit, Unit> CheckForUpdatesCommand { get; }
        private async Task CheckForUpdates()
        {
            // 1 API call
            if (!(await _autoInstallerService.CheckForUpdate())
                .Out(out var release))
            {
                _loggerService.Info($"Is update available: {release != null}");
                return;
            }

            _loggerService.Success($"Update available: {release.TagName}");
            Settings.IsUpdateAvailable = true;

            var result = await Interactions.ShowMessageBoxAsync("An update is ready to install for WolvenKit. Exit the app and install it?", "Update available");
            switch (result)
            {
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Yes:
                    if (await _autoInstallerService.Update()) // 1 API call
                    {
                        
                    }
                    break;
            }
        }

        private async Task SaveClose() => await Task.Run(() => _main.CloseModalCommand.Execute(null));

    }
}
