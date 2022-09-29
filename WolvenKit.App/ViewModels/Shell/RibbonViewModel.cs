using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive;
using System.Reflection;
using System.Threading.Tasks;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WinCopies.Linq;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;

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

            this.WhenAnyValue(x => x.MainViewModel.ActiveProject).WhereNotNull().Subscribe(p =>
            {
                if (p is not null)
                {
                    LaunchProfileText = p.Name;
                }
            });

        }



        public AppViewModel MainViewModel { get; }


        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAsCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }

        public ReactiveCommand<Unit, Unit> LaunchOptionsCommand { get; }
        private void LaunchOptions()
        {
            // open launch profiles menu
            //TODO
        }

        public ReactiveCommand<Unit, Unit> LaunchProfileCommand { get; }
        private async Task LaunchProfileAsync()
        {
            if (_settingsManager.LaunchProfiles.TryGetValue(LaunchProfileText, out var launchProfile))
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
