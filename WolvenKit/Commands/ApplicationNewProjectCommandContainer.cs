using System;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.ProjectManagement;
using WolvenKit.Functionality.Services;

namespace WolvenKit
{
    using Common.Services;
    using WolvenKit.Views.Wizards;
    using WolvenKit.ViewModels;
    using Orchestra.Services;

    public class ApplicationNewProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly ILoggerService _loggerService;
        private readonly IUIVisualizerService _uIVisualizerService;

        public ApplicationNewProjectCommandContainer(
            ICommandManager commandManager,
            IProjectManager projectManager,
            IGrowlNotificationService notificationService,
            IUIVisualizerService uIVisualizerService,
            ILoggerService loggerService)
            : base(AppCommands.Application.NewProject, commandManager, projectManager, notificationService, loggerService)
        {
            Argument.IsNotNull(() => loggerService);

            _loggerService = loggerService;
            _uIVisualizerService = uIVisualizerService;
        }

        protected override bool CanExecute(object parameter) => true;

        protected override async void Execute(object parameter)
        {
            try
            {
                var vm = new UserControlHostWindowViewModel(new ProjectWizardView());

                var result = await _uIVisualizerService.ShowDialogAsync(vm);

            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }
        }
    }
}
