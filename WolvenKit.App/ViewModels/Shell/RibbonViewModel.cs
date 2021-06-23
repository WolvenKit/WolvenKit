using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Reflection;
using Catel.Services;
using ProtoBuf.Meta;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ViewModelBase
    {
        #region fields

        public static RibbonViewModel GlobalRibbonVM;
        private readonly ILoggerService _loggerService;
        private readonly INavigationService _navigationService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly IUIVisualizerService _uiVisualizerService;

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            INavigationService navigationService,
            IUIVisualizerService uiVisualizerService
            )
        {
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => uiVisualizerService);
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => settingsManager);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _navigationService = navigationService;
            _uiVisualizerService = uiVisualizerService;
            _settingsManager = settingsManager;

            StartScreenShown = false;
            BackstageIsOpen = true;
            GlobalRibbonVM = this;

            ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);
            AssetBrowserAddCommand = new RelayCommand(ExecuteAssetBrowserAdd, CanAssetBrowserAdd);

            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();
        }

        #endregion constructors

        #region properties

        public Random rnd = new Random();
        private Color _selectedTheme;

        public enum ERibbonContextualTabGroupVisibility
        {
            Collapsed,
            Visible,
        }


        public bool BackstageIsOpen { get; set; }
        public ERibbonContextualTabGroupVisibility ProjectExplorerContextualTabGroupVisibility { get; set; }

        public string ProjectExplorerContextualTabGroupVisibilityStr =>
            ProjectExplorerContextualTabGroupVisibility.ToString();

        public Color SelectedTheme
        {
            get => _selectedTheme;
            set
            {
                if (_selectedTheme != value)
                {
                    var stringint = "RandomTheme" + rnd.Next(0, 9999) + "Name";
                    _selectedTheme = value;
                    var color = new SolidColorBrush(value);
                    ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", value, false));

                    _loggerService.Info("Changed theme : " + value.ToString());
                    _settingsManager.ThemeAccent = value;
                    _settingsManager.Save();
                }
            }
        }

        public bool StartScreenShown { get; set; }

        #endregion properties

        #region commands

        public ICommand AssetBrowserAddCommand { get; private set; }

        private bool CanAssetBrowserAdd()
        {
            var abvm = ServiceLocator.Default.ResolveType<AssetBrowserViewModel>();
            return abvm is {SelectedFiles: { }} && abvm.SelectedFiles.Any();
        }

        private void ExecuteAssetBrowserAdd()
        {
            var abvm = ServiceLocator.Default.ResolveType<AssetBrowserViewModel>();
            abvm.AddSelectedCommand.SafeExecute();
        }

        



        /// <summary>
        /// Is raised when a PaneView is selected: shows the contextual ribbon tab
        /// </summary>
        public ICommand ViewSelectedCommand { get; private set; }

        private bool CanViewSelected(object view) => true;

        private void ExecuteViewSelected(object viewmodel)
        {
            if (viewmodel is not Tuple<PaneViewModel, bool> tuple)
            {
                return;
            }

            if (tuple.Item1 is ProjectExplorerViewModel)
            {
                ProjectExplorerContextualTabGroupVisibility = tuple.Item2
                    ? ERibbonContextualTabGroupVisibility.Visible
                    : ERibbonContextualTabGroupVisibility.Collapsed;
            }

            //DiscordHelper.SetDiscordRPCStatus(tuple.Item1.Title); // Set status for discord RPC
        }

        #endregion commands

        #region methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // Write initialization code here and subscribe to events

            ServiceLocator.Default.ResolveType<ICommandManager>()
                .RegisterCommand(AppCommands.Application.ViewSelected, ViewSelectedCommand, this);
        }

        #endregion methods
    }
}
