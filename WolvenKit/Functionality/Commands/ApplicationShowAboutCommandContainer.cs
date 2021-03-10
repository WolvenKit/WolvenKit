using Catel.MVVM;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Functionality.Commands
{
    internal class ApplicationShowAboutCommandContainer : Catel.MVVM.CommandContainerBase
    {
        #region Constructors

        public ApplicationShowAboutCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.ShowAbout, commandManager)
        {
        }

        #endregion Constructors

        #region Methods

        protected override void Execute(object parameter)
        {
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
            RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = true;
            HomePageViewModel.GlobalHomePageVM.SetCurrentPage("About");

            //  HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();

            //  HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageViewModel.GlobalHomePageVM.AboutPV);
        }

        #endregion Methods
    }
}
