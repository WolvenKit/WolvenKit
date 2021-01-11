// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectCommandContainerBase.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using Catel.Threading;
using Orc.Notifications;
using Orc.ProjectManagement;
using WolvenKit.Common.Services;
using WolvenKit.Model.Project;

namespace WolvenKit.Commands
{
    public abstract class ProjectCommandContainerBase : CommandContainerBase
    {
        #region Fields
        protected readonly ICommandManager _commandManager;
        protected readonly INotificationService _notificationService;
        protected readonly ILoggerService _logger;
        protected readonly IProjectManager _projectManager;
        protected readonly IPleaseWaitService _pleaseWaitService;
        #endregion

        #region Constructors
        protected ProjectCommandContainerBase(string commandName, 
            ICommandManager commandManager, 
            IProjectManager projectManager,
            INotificationService notificationService,
            ILoggerService loggerService)
            : base(commandName, commandManager)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => notificationService);

            _commandManager = commandManager;
            _projectManager = projectManager;
            _logger = loggerService;
            _notificationService = notificationService;

            _pleaseWaitService = ServiceLocator.Default.ResolveType<IPleaseWaitService>();

            _projectManager.ProjectActivatedAsync += OnProjectActivatedAsync;
        }
        #endregion

        #region Methods
        private Task OnProjectActivatedAsync(object sender, ProjectUpdatedEventArgs e)
        {
            //await Task.Run(() => ProjectActivated((Project) e.OldProject, (Project) e.NewProject));
            ProjectActivated((EditorProject)e.OldProject, (EditorProject)e.NewProject);

            //TODO: why is that here?
            _commandManager.InvalidateCommands();

            return TaskHelper.Completed;
        }

        protected virtual async Task ProjectActivated(EditorProject oldEditorProject, EditorProject newEditorProject)
        {
            if (newEditorProject == null)
                return;

            await Task.Run(() => newEditorProject.Initialize());

            
        }

        protected override bool CanExecute(object parameter)
        {
            if (_projectManager.ActiveProject == null)
            {
                return false;
            }

            return base.CanExecute(parameter);
        }
        #endregion
    }
}