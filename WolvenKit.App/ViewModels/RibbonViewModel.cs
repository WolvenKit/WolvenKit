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
using WolvenKit.App.Commands;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels
{
    public class RibbonViewModel : ViewModel
    {
        #region fields
        private readonly ILoggerService _loggerService;
        private readonly INavigationService _navigationService;
        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly ISettingsManager _settingsManager;
        #endregion

        #region constructors
        public RibbonViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService, 
            INavigationService navigationService, 
            IUIVisualizerService uiVisualizerService
            )
        {
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => uiVisualizerService);
            Argument.IsNotNull(() => settingsManager);

            _loggerService = loggerService;
            _navigationService = navigationService;
            _uiVisualizerService = uiVisualizerService;
            _settingsManager = settingsManager;



            ShowKeyboardMappings = new TaskCommand(OnShowKeyboardMappingsExecuteAsync);
            Command1 = new RelayCommand(RunCommand1, CanRunCommand1);


            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();



        }
        #endregion

        #region MyRegion
        /// <summary>
        /// Dependency Property on RibbonView
        /// </summary>
        public List<string> ListOfThemes => new List<string>(){ "Dark.Red", "Light.Blue"  };

        private string _selectedTheme;
        /// <summary>
        /// Dependency Property on RibbonView
        /// </summary>
        public string SelectedTheme
        {
            get => _selectedTheme;
            set
            {
                if (_selectedTheme != value)
                {
                    var oldValue = _selectedTheme;
                    _selectedTheme = value;
                    RaisePropertyChanged(() => SelectedTheme, oldValue, value);
                }
            }
        }

        


        #endregion

        #region Commands
        public TaskCommand ShowKeyboardMappings { get; private set; }
        
        private async Task OnShowKeyboardMappingsExecuteAsync()
        {
            
        }

        public ICommand Command1 { get; }
        private bool CanRunCommand1() => true;
        private void RunCommand1()
        {
            
        }
        #endregion

        #region Methods
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Write initialization code here and subscribe to events
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events

            return base.CloseAsync();
        }
        #endregion
    }
}