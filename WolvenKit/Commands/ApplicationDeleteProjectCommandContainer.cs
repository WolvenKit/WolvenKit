using System;
using System.IO;
using System.Text;
using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Orc.Notifications;
using Orc.ProjectManagement;
using Settings = Orc.Squirrel.Settings;

using WolvenKit.Model.Wizards;
using Fluent;
using Catel.IoC;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Common.Services;

namespace WolvenKit.Commands
{
    class ApplicationDeleteProjectCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;
        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;
        private readonly IUIVisualizerService _uIVisualizerService;
        private readonly IViewModelFactory _viewModelFactory;
        private readonly IMessageService _messageService;

        public ApplicationDeleteProjectCommandContainer(
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

        protected override  void Execute(object parameter)
        {
            try
            {
              

            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to steal your nuggets!", Logtype.Error);
            }
        }
    }
}
