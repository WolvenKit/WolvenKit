using Catel;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;

namespace WolvenKitUI
{
    public class ApplicationOptionsCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;

        public ApplicationOptionsCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(Commands.Application.Options, commandManager)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        protected override void Execute(object parameter)
        {
            






        }
    }
}