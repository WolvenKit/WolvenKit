using Catel;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationExitCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationExitCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(AppCommands.Application.Exit, commandManager)
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
