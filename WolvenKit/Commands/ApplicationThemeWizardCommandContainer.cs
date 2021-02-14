using Catel;
using Catel.MVVM;
using Catel.Services;
using Orc.Notifications;
using Orc.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Services;
using WolvenKit.ViewModels;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Commands
{
    class ApplicationThemeWizardCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;
        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;
        private readonly IUIVisualizerService _uIVisualizerService;
        private readonly IViewModelFactory _viewModelFactory;
        private readonly IMessageService _messageService;

        public ApplicationThemeWizardCommandContainer(
            ICommandManager commandManager,
            INavigationService navigationService,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            INotificationService notificationService,
            IUIVisualizerService uIVisualizerService,
            IViewModelFactory viewModelFactory,
            IMessageService messageService,
            ILoggerService loggerService)
            : base(AppCommands.Application.ThemeWizard, commandManager)
        {
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => saveFileService);

            _navigationService = navigationService;
            _loggerService = loggerService;
            _saveFileService = saveFileService;
            _uIVisualizerService = uIVisualizerService;
            _viewModelFactory = viewModelFactory;
            _messageService = messageService;
        }

        protected override bool CanExecute(object parameter) => true;

        protected override async void Execute(object parameter)
        {
            try
            {
                var vm = new UserControlHostWindowViewModel(new ThemeWizardView(), 600, 600);

                var result = await _uIVisualizerService.ShowDialogAsync(vm);

            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to steal your nuggets!", Logtype.Error);
            }
        }
    }
}
