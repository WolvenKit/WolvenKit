using System;
using System.Linq;
using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ReactiveObject
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly WorkSpaceViewModel _mainViewModel;

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            WorkSpaceViewModel workSpaceViewModel
        )
        {
            _mainViewModel = workSpaceViewModel;

            _projectManager = projectManager;
            _loggerService = loggerService;
            _settingsManager = settingsManager;

            StartScreenShown = false;
            BackstageIsOpen = true;

            //ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);
            AssetBrowserAddCommand = new RelayCommand(ExecuteAssetBrowserAdd, CanAssetBrowserAdd);

            OpenProjectCommand =
                ReactiveCommand.Create<string>(s => _mainViewModel.OpenProjectCommand.Execute(s).Subscribe());

            PackProjectCommand = ReactiveCommand.Create(() => _mainViewModel.PackModCommand.SafeExecute());
        }

        #endregion constructors

        #region commands

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; }
        public ReactiveCommand<string, Unit> NewProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> PackProjectCommand { get; }

        public ReactiveCommand<string, Unit> NewFileCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> SaveFileCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> SaveAllCommand = ReactiveCommand.Create<string>(link => { });

        public ReactiveCommand<string, Unit> ViewProjectExplorerCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ViewAssetBrowserCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ViewPropertiesCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ViewLogCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ViewCodeEditorCommand = ReactiveCommand.Create<string>(link => { });

        public ReactiveCommand<string, Unit> ShowSettingsCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ShowBugReportCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> ShowFeedbackCommand = ReactiveCommand.Create<string>(link => { });

        public ReactiveCommand<string, Unit> ShowImportExportToolCommand = ReactiveCommand.Create<string>(link => { });
       
        #endregion


        #region properties

        public enum ERibbonContextualTabGroupVisibility
        {
            Collapsed,
            Visible,
        }

        [Reactive] public bool StartScreenShown { get; set; }

        [Reactive] public bool BackstageIsOpen { get; set; }

        [Reactive] public ERibbonContextualTabGroupVisibility ProjectExplorerContextualTabGroupVisibility { get; set; }

        //private Color _selectedTheme;
        //public Color SelectedTheme
        //{
        //    get => _selectedTheme;
        //    set
        //    {
        //        if (_selectedTheme != value)
        //        {
        //            //var stringint = "RandomTheme" + rnd.Next(0, 9999) + "Name";
        //            _selectedTheme = value;


        //            _loggerService.Info("Changed theme : " + value.ToString());
        //            _settingsManager.SetThemeAccent(value);
        //            _settingsManager.Save();
        //        }
        //    }
        //}


        public string ProjectExplorerContextualTabGroupVisibilityStr =>
            ProjectExplorerContextualTabGroupVisibility.ToString();

        #endregion properties

        #region commands

        public ICommand AssetBrowserAddCommand { get; private set; }

        private bool CanAssetBrowserAdd()
        {
            var abvm = Locator.Current.GetService<AssetBrowserViewModel>();
            return abvm is {RightSelectedItems: { }} && abvm.RightSelectedItems.Any();
        }

        private void ExecuteAssetBrowserAdd()
        {
            var abvm = Locator.Current.GetService<AssetBrowserViewModel>();
            abvm.AddSelectedCommand.SafeExecute();
        }

        #endregion commands
    }
}
