using Catel.MVVM;
using WolvenKit.Views.HomePage;

namespace WolvenKit.Commands
{
    class ApplicationShowSettingsCommandContainer : Catel.MVVM.CommandContainerBase
    {

        public ApplicationShowSettingsCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.ShowSettings, commandManager)
        {

        }

        protected override void Execute(object parameter)
        {
            WKitGlobal.AppHelper.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
            WKitGlobal.AppHelper.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.StartScreen.ShownProperty, false);
            WKitGlobal.AppHelper.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, true);
            HomePageView.GlobalHomePage.PageViewGrid.Children.Clear();
            HomePageView.GlobalHomePage.PageViewGrid.Children.Add(HomePageView.GlobalHomePage.SettingsPV);
        }
    }
}
