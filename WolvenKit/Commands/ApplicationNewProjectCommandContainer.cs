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

namespace WolvenKit
{
    using Model;
    using Common;
    using Common.Model;
    using Common.Services;
    using WolvenKit.ViewModels.Wizards;
    using WolvenKit.Views.Wizards;
    using WolvenKit.ViewModels;
    using WolvenKit.Views;

    public class ApplicationNewProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly INavigationService _navigationService;
        private readonly ILoggerService _loggerService;
        private readonly ISaveFileService _saveFileService;
        private readonly IUIVisualizerService _uIVisualizerService;
        private readonly IViewModelFactory _viewModelFactory;
        private readonly IMessageService _messageService;

        public ApplicationNewProjectCommandContainer(
            ICommandManager commandManager,
            INavigationService navigationService,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            INotificationService notificationService,
            IUIVisualizerService uIVisualizerService,
            IViewModelFactory viewModelFactory,
            IMessageService messageService,
            ILoggerService loggerService)
            : base(AppCommands.Application.NewProject, commandManager, projectManager, notificationService, loggerService)
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
                var vm = new UserControlHostWindowViewModel(new ProjectWizardView(), 500, 2500);
                
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