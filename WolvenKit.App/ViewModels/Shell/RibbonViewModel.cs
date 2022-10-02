using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;

namespace WolvenKit.ViewModels.Shell
{
    public class RibbonViewModel : ReactiveObject
    {
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;
        private readonly IGameControllerFactory _gameControllerFactory;

        public RibbonViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService,
            IGameControllerFactory gameControllerFactory,
            AppViewModel appViewModel
        )
        {
            _settingsManager = settingsManager;
            _loggerService = loggerService;
            _gameControllerFactory = gameControllerFactory;
            MainViewModel = appViewModel;

            LaunchProfileText = "Launch Profiles";

            NewFileCommand = ReactiveCommand.Create(() => MainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => MainViewModel.SaveFileCommand.SafeExecute());
            SaveAsCommand = ReactiveCommand.Create(() => MainViewModel.SaveAsCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => MainViewModel.SaveAllCommand.SafeExecute());
            LaunchOptionsCommand = ReactiveCommand.Create(LaunchOptions);
            LaunchProfileCommand = ReactiveCommand.CreateFromTask(async () => await LaunchProfileAsync());

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

        public ReactiveCommand<Unit, Unit> LaunchOptionsCommand { get; }
        private async void LaunchOptions() => await Interactions.ShowLaunchProfilesView.Handle(Unit.Default);



        public ReactiveCommand<Unit, Unit> LaunchProfileCommand { get; }
        private async Task LaunchProfileAsync()
        {
            if (_settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out App.Models.LaunchProfile launchProfile))
            {
                await _gameControllerFactory.GetController().LaunchProject(launchProfile);
            }
            else
            {
                _loggerService.Error($"No launchprofile with name \"{LaunchProfileText}\" found.");
            }
        }



        [Reactive] public string LaunchProfileText { get; set; }

    }
}
