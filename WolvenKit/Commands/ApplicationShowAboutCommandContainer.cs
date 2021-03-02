using Catel.MVVM;
using WolvenKit.Views.HomePage;

namespace WolvenKit.Commands
{
    class ApplicationShowAboutCommandContainer : Catel.MVVM.CommandContainerBase
    {

        public ApplicationShowAboutCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.ShowAbout, commandManager)
        {

        }

        protected override void Execute(object parameter)
        {
            WKitGlobal.StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
            WKitGlobal.StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.StartScreen.ShownProperty, false);
            WKitGlobal.StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, true);
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.AboutPV);
        }
    }
}
