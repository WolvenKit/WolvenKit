namespace WolvenKit.UI.Services
{
    using System.Windows;
    using Orchestra.Services;
    using Views;

    public class RibbonService : IRibbonService
    {
        public FrameworkElement GetRibbon()
        {
            return new RibbonView();
        }

        public FrameworkElement GetMainView()
        {
            return new MainView();
        }

        public FrameworkElement GetStatusBar()
        {
            return new StatusBarView();
        }
    }
}