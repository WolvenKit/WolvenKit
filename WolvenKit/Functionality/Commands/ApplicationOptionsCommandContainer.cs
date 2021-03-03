using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using WolvenKit;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOptionsCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationOptionsCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(AppCommands.Application.Options, commandManager)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        protected override void Execute(object parameter)
        {
            






        }
    }
}
