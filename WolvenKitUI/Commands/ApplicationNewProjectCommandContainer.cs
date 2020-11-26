using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;

namespace WolvenKitUI
{
    public class ApplicationNewProjectCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationNewProjectCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(Commands.Application.NewProject, commandManager)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        protected override void Execute(object parameter)
        {
            






        }
    }
}