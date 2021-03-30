using System;
using System.Threading.Tasks;
using Catel;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.ViewModels.Others;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Commands
{
    class ApplicationPublishProjectCommandContainer : CommandContainerBase
    {
        #region Fields

        private readonly ILoggerService _loggerService;
        private readonly IUIVisualizerService _uIVisualizerService;

        #endregion Fields

        #region Constructors

        public ApplicationPublishProjectCommandContainer(
            ICommandManager commandManager,
            IUIVisualizerService uIVisualizerService,
            ILoggerService loggerService)
            : base(AppCommands.Application.PublishProject, commandManager)
        {
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => loggerService);

            _loggerService = loggerService;
            _uIVisualizerService = uIVisualizerService;
        }

        #endregion Constructors

        #region Methods

        protected override async Task ExecuteAsync(object parameter)
        {
            try
            {
                var vm = new UserControlHostWindowViewModel(new PublishWizardView());

                var result = await _uIVisualizerService.ShowDialogAsync(vm);
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to publish project!", Logtype.Error);
            }
        }

        #endregion Methods
    }
}
