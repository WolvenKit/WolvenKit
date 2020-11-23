using Catel;
using Catel.MVVM;
using Catel.Reflection;
using Catel.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels
{
    public class RibbonViewModel : ViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IUIVisualizerService _uiVisualizerService;

        public RibbonViewModel(INavigationService navigationService, IUIVisualizerService uiVisualizerService)
        {
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => uiVisualizerService);

            _navigationService = navigationService;
            _uiVisualizerService = uiVisualizerService;

            ShowKeyboardMappings = new TaskCommand(OnShowKeyboardMappingsExecuteAsync);
            Command1 = new RelayCommand(RunCommand1, CanRunCommand1);

            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();
        }

        #region Commands
        /// <summary>
        /// Gets the ShowKeyboardMappings command.
        /// </summary>
        public TaskCommand ShowKeyboardMappings { get; private set; }
        public ICommand Command1 { get; }

        /// <summary>
        /// Method to invoke when the ShowKeyboardMappings command is executed.
        /// </summary>
        private async Task OnShowKeyboardMappingsExecuteAsync()
        {
            
        }

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