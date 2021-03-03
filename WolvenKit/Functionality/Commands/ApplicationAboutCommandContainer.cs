using Catel;
using Catel.MVVM;
using Orchestra.Services;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Commands
{
    public class ApplicationAboutCommandContainer : Catel.MVVM.CommandContainerBase
    {
        #region Fields

        private readonly IAboutService _aboutService;

        #endregion Fields

        #region Constructors

        public ApplicationAboutCommandContainer(ICommandManager commandManager, IAboutService aboutService)
            : base(AppCommands.Application.About, commandManager)
        {
            Argument.IsNotNull(() => aboutService);

            _aboutService = aboutService;
        }

        #endregion Constructors



        #region Methods

        protected override void Execute(object parameter) => _aboutService.ShowAboutAsync();

        #endregion Methods
    }
}
