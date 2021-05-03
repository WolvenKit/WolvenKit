using System;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Services;
using Orchestra.Models;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.ViewModels.Shared;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationDeleteProjectCommandContainer : Catel.MVVM.CommandContainerBase
    {
        #region Fields

        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IServiceLocator _serviceLocator;
        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;
        private readonly ISaveFileService _saveFileService;
        private readonly IUIVisualizerService _uIVisualizerService;
        private readonly IViewModelFactory _viewModelFactory;

        #endregion Fields

        #region Constructors

        public ApplicationDeleteProjectCommandContainer(
            IRecentlyUsedItemsService recentlyUsedItemsService,
            IServiceLocator serviceLocator,
            ICommandManager commandManager,
            INavigationService navigationService,
            IProjectManager projectManager,
            ISaveFileService saveFileService,
            IGrowlNotificationService notificationService,
            IUIVisualizerService uIVisualizerService,
            IViewModelFactory viewModelFactory,
            IMessageService messageService,
            ILoggerService loggerService)
            : base(AppCommands.Application.DelProject, commandManager)
        {
            Argument.IsNotNull(() => recentlyUsedItemsService);
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => saveFileService);

            _recentlyUsedItemsService = recentlyUsedItemsService;
            _serviceLocator = serviceLocator;
            _navigationService = navigationService;
            _loggerService = loggerService;
            _saveFileService = saveFileService;
            _uIVisualizerService = uIVisualizerService;
            _viewModelFactory = viewModelFactory;
            _messageService = messageService;
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter) => true;

        protected override void Execute(object parameter)
        {
            try
            {
                RecentlyUsedItem projectToDel = null;
                foreach (var project in _recentlyUsedItemsService.Items)
                {
                    if (project.Name == parameter?.ToString())
                    {
                        projectToDel = project;
                        break;
                    }
                }
                if (projectToDel != null)
                    _recentlyUsedItemsService.RemoveItem(projectToDel);
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to delete recent project", Logtype.Error);
            }
        }

        #endregion Methods
    }
}
