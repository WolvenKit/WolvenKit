using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.ViewModels.Shell
{
    public class MenuBarViewModel : ObservableObject
    {
        private readonly IProgressService<double> _progressService;
        private readonly IArchiveManager _archiveManager;
        private readonly IModTools _modTools;



        public MenuBarViewModel(
            ISettingsManager settingsManager,
            IProgressService<double> progressService,
            IArchiveManager archiveManager,
            IModTools modTools,
            AppViewModel appViewModel)
        {
            MainViewModel = appViewModel;
            _archiveManager = archiveManager;
            _progressService = progressService;
            _modTools = modTools;
            SettingsManager = settingsManager;

            OpenGameFolderCommand = ReactiveCommand.Create(() => Commonfunctions.ShowFolderInExplorer(SettingsManager.GetRED4GameRootDir()));
        }

        public ISettingsManager SettingsManager { get; }
        public AppViewModel MainViewModel { get; }

        public ReactiveCommand<Unit, Unit> OpenGameFolderCommand { get; }

    }
}
