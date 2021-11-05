using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ReactiveObject
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IProgressService<double> _progressService;
        private readonly IArchiveManager _archiveManager;
        private readonly IModTools _modTools;
        public ISettingsManager _settingsManager { get; }
        public readonly AppViewModel _mainViewModel;

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProgressService<double> progressService,
            IArchiveManager archiveManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            IModTools modTools,
            AppViewModel appViewModel
        )
        {
            _mainViewModel = appViewModel;

            _archiveManager = archiveManager;
            _progressService = progressService;
            _projectManager = projectManager;
            _modTools = modTools;
            _loggerService = loggerService;
            _settingsManager = settingsManager;

            StartScreenShown = false;
            BackstageIsOpen = true;

            //ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);
            //AssetBrowserAddCommand = new RelayCommand(ExecuteAssetBrowserAdd, CanAssetBrowserAdd);
            //AssetBrowserOpenFileLocation = new RelayCommand(ExecuteAssetBrowserOpenFileLocation, CanAssetBrowserOpenFileLocation);

            OpenProjectCommand = ReactiveCommand.Create<string>(s => _mainViewModel.OpenProjectCommand.Execute(s).Subscribe());
            //NewProjectCommand = ReactiveCommand.Create(() => _mainViewModel.NewProjectCommand.Execute().Subscribe());
            PackProjectCommand = ReactiveCommand.Create(() => _mainViewModel.PackModCommand.SafeExecute());

            NewFileCommand = ReactiveCommand.Create(() => _mainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => _mainViewModel.SaveFileCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => _mainViewModel.SaveAllCommand.SafeExecute());

            ViewProjectExplorerCommand = ReactiveCommand.Create(() => _mainViewModel.ShowProjectExplorerCommand.SafeExecute());
            ViewAssetBrowserCommand = ReactiveCommand.Create(() => _mainViewModel.ShowAssetsCommand.SafeExecute());
            ViewPropertiesCommand = ReactiveCommand.Create(() => _mainViewModel.ShowPropertiesCommand.SafeExecute());
            ViewLogCommand = ReactiveCommand.Create(() => _mainViewModel.ShowLogCommand.SafeExecute());
            //ViewCodeEditorCommand = ReactiveCommand.Create(() => _mainViewModel.ShowCodeEditorCommand.SafeExecute());
            ShowImportExportToolCommand = ReactiveCommand.Create(() => _mainViewModel.ShowImportExportToolCommand.SafeExecute());

            ShowSettingsCommand = ReactiveCommand.Create(() =>
            {
                BackstageIsOpen = true;
            });
            ShowBugReportCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var result = await Interactions.ShowBugReport.Handle(Unit.Default);
            });
            ShowFeedbackCommand = ReactiveCommand.CreateFromTask(async  () =>
            {
                var result = await Interactions.ShowFeedback.Handle(Unit.Default);
            });

            OpenMaterialRepositoryCommand = ReactiveCommand.Create(() =>
            {
                Commonfunctions.ShowFolderInExplorer(_settingsManager.MaterialRepositoryPath);
            });

            UnbundleGameCommand = ReactiveCommand.CreateFromTask(UnbundleGame);


        }

        private async Task UnbundleGame()
        {
            var depotPath = new DirectoryInfo(_settingsManager.MaterialRepositoryPath);
            if (depotPath.Exists)
            {
                await Task.Run(() =>
                {
                    var archives = _archiveManager.Archives.KeyValues.Select(x => x.Value).ToList();

                    var total = archives.Count;
                    var progress = 0;
                    _progressService.Report(0);

                    for (int i = 0; i < archives.Count; i++)
                    {
                        var archive = archives[i];
                        _modTools.ExtractAll(archive as Archive, depotPath);

                        progress++;
                        _progressService.Report(i / (float)total);
                    }
                    _progressService.Report(1.0);
                });
            }
        }

        #endregion constructors

        #region commands

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; }
        //public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> PackProjectCommand { get; }

        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }

        public ReactiveCommand<Unit, Unit> ViewProjectExplorerCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewAssetBrowserCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewPropertiesCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewLogCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewCodeEditorCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowImportExportToolCommand { get; }

        public ReactiveCommand<Unit, Unit> ShowSettingsCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowBugReportCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowFeedbackCommand { get; }

        public ReactiveCommand<Unit, Unit> OpenMaterialRepositoryCommand { get; }
        public ReactiveCommand<Unit, Unit> UnbundleGameCommand { get; }

        #endregion

        #region properties

        [Reactive] public bool StartScreenShown { get; set; }

        [Reactive] public bool BackstageIsOpen { get; set; }

        #endregion properties

    }
}
