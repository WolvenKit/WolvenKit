using Catel.MVVM;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Functionality.Commands
{
    internal class ApplicationShowSettingsCommandContainer : Catel.MVVM.CommandContainerBase
    {
        #region Constructors

        public ApplicationShowSettingsCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.ShowSettings, commandManager)
        {
        }

        #endregion Constructors

        #region Methods

        protected override void Execute(object parameter)
        {
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = false;
            RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = true;
            HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Settings");

            //  HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            // HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageViewModel.GlobalHomePageVM.SettingsPV);
        }

        #endregion Methods
    }
}
