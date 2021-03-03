using Catel.MVVM;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views.HomePage;

namespace WolvenKit.Functionality.Commands
{
    class ApplicationShowAboutCommandContainer : Catel.MVVM.CommandContainerBase
    {

        public ApplicationShowAboutCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.ShowAbout, commandManager)
        {

        }

        protected override void Execute(object parameter)
        {
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.StartScreen.ShownProperty, false);
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, true);
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.AboutPV);
        }
    }
}
