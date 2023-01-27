using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Shell
{
    public partial class RibbonViewModel : ObservableObject
    {
        private readonly IWatcherService _watcherService;
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;
        private readonly IGameControllerFactory _gameControllerFactory;

        public RibbonViewModel(
            IWatcherService watcherService,
            ISettingsManager settingsManager,
            ILoggerService loggerService,
            IGameControllerFactory gameControllerFactory,
            AppViewModel appViewModel
        )
        {
            _settingsManager = settingsManager;
            _loggerService = loggerService;
            _gameControllerFactory = gameControllerFactory;
            _watcherService = watcherService;

            MainViewModel = appViewModel;

            _launchProfileText = "Launch Profiles";

            NewFileCommand = ReactiveCommand.Create(() => MainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => MainViewModel.SaveFileCommand.SafeExecute());
            SaveAsCommand = ReactiveCommand.Create(() => MainViewModel.SaveAsCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => MainViewModel.SaveAllCommand.SafeExecute());

            LaunchProfileCommand = ReactiveCommand.CreateFromTask(LaunchProfileAsync);

            /*this.WhenAnyValue(x => x.MainViewModel.ActiveProject).WhereNotNull().Subscribe(p =>
            {
                if (p is not null)
                {
                    LaunchProfileText = p.Name;
                }
            });*/

        }



        public AppViewModel MainViewModel { get; }


        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAsCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }





        public ReactiveCommand<Unit, Unit> LaunchProfileCommand { get; }
        private async Task LaunchProfileAsync()
        {
            _settingsManager.LaunchProfiles ??= new();

            if (_settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out var launchProfile))
            {
                _watcherService.IsSuspended = true;
                await _gameControllerFactory.GetController().LaunchProject(launchProfile);
                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(MainViewModel.ActiveProject);
            }
            else
            {
                _loggerService.Error($"No launchprofile with name \"{LaunchProfileText}\" found.");
            }
        }



        [ObservableProperty] private string _launchProfileText;

    }
}
