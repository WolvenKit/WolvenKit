using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Reflection;
using Catel.Services;
using MLib.Interfaces;
using Orc.Theming;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Orc.ProjectManagement;

namespace WolvenKit.ViewModels
{
    using Functionality.Commands;
    using Functionality.Services;
    using Common.Services;
    using System.Timers;

    public class RibbonViewModel : ViewModel
    {
        #region fields
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly INavigationService _navigationService;
        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly ISettingsManager _settingsManager;
        #endregion

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

            ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);


            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();

        }
        #endregion

        #region properties

        public enum ERibbonContextualTabGroupVisibility
        {
            Collapsed,
            Visible,
        }

        public ERibbonContextualTabGroupVisibility ProjectExplorerContextualTabGroupVisibility { get; set; }
        public string ProjectExplorerContextualTabGroupVisibilityStr =>
            ProjectExplorerContextualTabGroupVisibility.ToString();

        

        private Color _selectedTheme;  
        public Random rnd = new Random();
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
                    ControlzEx.Theming.ThemeManager.Current.AddTheme(new ControlzEx.Theming.Theme(stringint, "asfasf", "Dark", "Red", value, color, true, false));
                    ControlzEx.Theming.ThemeManager.Current.AddTheme(ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", Colors.Red));
                    ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, stringint);
           

                }

            }
        }


        




        #endregion

        #region commands

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
        }

        #endregion

        #region methods
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // Write initialization code here and subscribe to events


            ServiceLocator.Default.ResolveType<ICommandManager>()
                .RegisterCommand(AppCommands.Application.ViewSelected, ViewSelectedCommand, this);
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events

            return base.CloseAsync();
        }
        #endregion
    }
}
