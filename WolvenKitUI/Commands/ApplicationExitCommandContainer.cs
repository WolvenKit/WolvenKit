using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using System.Threading.Tasks;

namespace WolvenKitUI
{
    public class ApplicationExitCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationExitCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(Commands.Application.Exit, commandManager)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        protected override void Execute(object parameter)
        {
            _navigationService.CloseApplication();
        }
    }
}