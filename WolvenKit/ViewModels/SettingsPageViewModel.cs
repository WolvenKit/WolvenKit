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

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        private readonly AppViewModel _main;

        public SettingsPageViewModel(
            ISettingsManager settingsManager
        )
        {
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
            await Task.Run(() =>
            {

            });
        }

        private async Task SaveClose() => await Task.Run(() => _main.CloseModalCommand.Execute(null));

    }
}
