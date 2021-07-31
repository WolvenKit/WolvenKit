using System;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using ProtoBuf.Meta;
using ReactiveUI;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Core;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ReactiveObject
    {
        #region fields

        public static RibbonViewModel GlobalRibbonVM;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService
        )
        {

            _projectManager = projectManager;
            _loggerService = loggerService;
            _settingsManager = settingsManager;

            StartScreenShown = false;
            BackstageIsOpen = true;
            GlobalRibbonVM = this;

            //ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);
            AssetBrowserAddCommand = new RelayCommand(ExecuteAssetBrowserAdd, CanAssetBrowserAdd);
        }

        #endregion constructors

        #region commands

        public ReactiveCommand<string, Unit> OpenProjectCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> NewProjectCommand = ReactiveCommand.Create<string>(link => { });
        public ReactiveCommand<string, Unit> PackProjectCommand = ReactiveCommand.Create<string>(link => { });

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


        public bool BackstageIsOpen { get; set; }
        public ERibbonContextualTabGroupVisibility ProjectExplorerContextualTabGroupVisibility { get; set; }

        public string ProjectExplorerContextualTabGroupVisibilityStr =>
            ProjectExplorerContextualTabGroupVisibility.ToString();

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

        public bool StartScreenShown { get; set; }

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
