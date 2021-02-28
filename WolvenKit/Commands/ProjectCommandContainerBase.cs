// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectCommandContainerBase.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System;
using Catel.IoC;
using Catel.Services;
using WolvenKit.Services;

namespace WolvenKit
{
    using Model;
    using Common.Services;

    using System.Threading.Tasks;
    using Catel;
    using Catel.MVVM;
    using Catel.Threading;
    using Orc.ProjectManagement;
    using Orchestra.Services;

    public abstract class ProjectCommandContainerBase : CommandContainerBase
    {
        #region Fields
        protected readonly ICommandManager _commandManager;
        protected readonly IGrowlNotificationService _notificationService;
        protected readonly ILoggerService _logger;
        protected readonly IProjectManager _projectManager;
        protected readonly IPleaseWaitService _pleaseWaitService;
        #endregion

        #region Constructors
        protected ProjectCommandContainerBase(string commandName, 
            ICommandManager commandManager, 
            IProjectManager projectManager,
            IGrowlNotificationService notificationService,
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
            //Task.Run(() => ProjectActivated((EditorProject) e.OldProject, (EditorProject) e.NewProject));
            var asd = ProjectActivated((EditorProject)e.OldProject, (EditorProject)e.NewProject);

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
