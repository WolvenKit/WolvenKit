namespace WolvenKit.UI.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Catel;
    using Catel.MVVM;
    using Catel.Reflection;
    using Catel.Services;
    using Orc.FileSystem;
    using Orchestra.Models;
    using Orchestra.Services;
    using Orchestra.ViewModels;

    public class RibbonViewModel : ViewModelBase
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

            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();
        }

        #region Commands
        /// <summary>
        /// Gets the ShowKeyboardMappings command.
        /// </summary>
        public TaskCommand ShowKeyboardMappings { get; private set; }

        /// <summary>
        /// Method to invoke when the ShowKeyboardMappings command is executed.
        /// </summary>
        private async Task OnShowKeyboardMappingsExecuteAsync()
        {
            await _uiVisualizerService.ShowDialogAsync<KeyboardMappingsCustomizationViewModel>();
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