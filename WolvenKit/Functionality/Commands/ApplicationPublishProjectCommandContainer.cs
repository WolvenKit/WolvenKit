using System;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Others;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Commands
{
    class ApplicationPublishProjectCommandContainer : CommandContainerBase
    {
        #region Fields

        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly IUIVisualizerService _uIVisualizerService;

        #endregion Fields

        #region Constructors

        public ApplicationPublishProjectCommandContainer(
            IProjectManager projectManager,
            ICommandManager commandManager,
            IUIVisualizerService uIVisualizerService,
            ILoggerService loggerService)
            : base(AppCommands.Application.PublishProject, commandManager)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => uIVisualizerService);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
            _uIVisualizerService = uIVisualizerService;
            _loggerService = loggerService;
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter)
            => _projectManager.ActiveProject is EditorProject;

        protected override async Task ExecuteAsync(object parameter)
        {
            try
            {
                var vm = new UserControlHostWindowViewModel(new PublishWizardView());
                ServiceLocator.Default.RegisterInstance(vm);

                var result = await _uIVisualizerService.ShowDialogAsync(vm);
                ServiceLocator.Default.RemoveType(typeof(UserControlHostWindowViewModel));
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
