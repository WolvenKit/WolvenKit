using System;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ReactiveObject
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        public readonly AppViewModel _mainViewModel;

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            AppViewModel appViewModel
        )
        {
            _mainViewModel = appViewModel;

            _projectManager = projectManager;
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

            });
            ShowBugReportCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var result = await Interactions.ShowBugReport.Handle(Unit.Default);
            });
            ShowFeedbackCommand = ReactiveCommand.CreateFromTask(async  () =>
            {
                var result = await Interactions.ShowFeedback.Handle(Unit.Default);
            });
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

        #endregion

        #region properties

        [Reactive] public bool StartScreenShown { get; set; }

        [Reactive] public bool BackstageIsOpen { get; set; }

        #endregion properties

    }
}
