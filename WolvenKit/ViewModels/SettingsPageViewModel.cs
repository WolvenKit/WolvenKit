using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Media;
using gpm.Installer;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Serilog;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        private readonly AppViewModel _main;

        private readonly AutoInstallerService _autoInstallerService;

        public SettingsPageViewModel(
            ISettingsManager settingsManager,
            AutoInstallerService autoInstallerService
        )
        {
            _autoInstallerService = autoInstallerService;

            _main = Locator.Current.GetService<AppViewModel>();

            Settings = settingsManager;

            

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
                Log.Information($"Is update available: {release != null}");
                return;
            }

            Log.Information($"Update available: {release.TagName}");

            await _autoInstallerService.Update(release);
        }

        private async Task SaveClose() => await Task.Run(() => _main.CloseModalCommand.Execute(null));

    }
}
