using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        public readonly AppViewModel MainViewModel;
        private readonly ILoggerService _loggerService;

        public SettingsPageViewModel(
            AppViewModel mainViewModel,
            ISettingsManager settingsManager,
            ILoggerService loggerService
        )
        {
            MainViewModel = mainViewModel;
            Settings = settingsManager;
            _loggerService = loggerService;

            SaveCloseCommand = ReactiveCommand.CreateFromTask(SaveClose);
        }


        public ISettingsManager Settings { get; set; }

        public ReactiveCommand<Unit, Unit> SaveCloseCommand { get; }

        private async Task SaveClose() => await Task.Run(() => MainViewModel.CloseModalCommand.Execute(null));

    }
}
