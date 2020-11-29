using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using Orc.ProjectManagement;
using WolvenKit.App;
using WolvenKit.Common.Services;

namespace WolvenKitUI
{
    public class ApplicationNewProjectCommandContainer : ProjectCommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationNewProjectCommandContainer(
            ICommandManager commandManager, 
            INavigationService navigationService, 
            IProjectManager projectManager,
            ILoggerService loggerService)
            : base(AppCommands.Application.NewProject, commandManager, projectManager, loggerService)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        protected override void Execute(object parameter)
        {
            






        }
    }
}