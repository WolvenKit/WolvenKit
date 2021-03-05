using Catel;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationOptionsCommandContainer : Catel.MVVM.CommandContainerBase
    {
        #region Fields

        private readonly INavigationService _navigationService;

        #endregion Fields

        #region Constructors

        public ApplicationOptionsCommandContainer(ICommandManager commandManager, INavigationService navigationService)
            : base(AppCommands.Application.Options, commandManager)
        {
            Argument.IsNotNull(() => navigationService);

            _navigationService = navigationService;
        }

        #endregion Constructors

        #region Methods

        protected override void Execute(object parameter)
        {
        }

        #endregion Methods
    }
}
