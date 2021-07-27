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
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Functionality.Commands
{
    public abstract class ProjectCommandContainerBase : CommandContainerBase
    {
        #region Fields

        protected readonly ICommandManager _commandManager;
        protected readonly ILoggerService _logger;
        protected readonly INotificationService _notificationService;
        protected readonly IPleaseWaitService _pleaseWaitService;
        protected readonly IProjectManager _projectManager;

        #endregion Fields

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
        }

        #endregion Constructors

        #region Methods

        protected override bool CanExecute(object parameter)
        {
            if (_projectManager.ActiveProject == null)
            {
                return false;
            }

            return base.CanExecute(parameter);
        }

        #endregion Methods
    }
}
