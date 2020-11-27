using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using Orchestra;
using Orchestra.Services;
using System.Threading.Tasks;
using WolvenKit.App;

namespace WolvenKitUI
{
    public class ApplicationOpenProjectCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly INavigationService _navigationService;
        private readonly IOpenFileService _openFileService;

        public ApplicationOpenProjectCommandContainer(ICommandManager commandManager
            , INavigationService navigationService
            , IOpenFileService openFileService)
            : base(AppCommands.Application.OpenProject, commandManager)
        {
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => openFileService);

            _navigationService = navigationService;
            _openFileService = openFileService;
        }

        protected async override void Execute(object parameter)
        {
            var context = new DetermineOpenFileContext();

            switch (_openFileService.DetermineFileAsync(context))
            {
                default:
                    break;
            }

            

        }
    }
}