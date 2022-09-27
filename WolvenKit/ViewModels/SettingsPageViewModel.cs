using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        public readonly AppViewModel MainViewModel;
        private readonly ILoggerService _loggerService;

        public SettingsPageViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService
        )
        {
            MainViewModel = Locator.Current.GetService<AppViewModel>();
            Settings = settingsManager;
            _loggerService = loggerService;

            SaveCloseCommand = ReactiveCommand.CreateFromTask(SaveClose);
        }


        public ISettingsManager Settings { get; set; }

        public ReactiveCommand<Unit, Unit> SaveCloseCommand { get; }

        private async Task SaveClose() => await Task.Run(() => MainViewModel.CloseModalCommand.Execute(null));

    }
}
