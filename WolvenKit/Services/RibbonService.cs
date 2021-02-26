using Orchestra.Services;
using System.Windows;
using WolvenKit.Views;

namespace WolvenKit.Services
{
    public class RibbonService : IRibbonService
    {
        public FrameworkElement GetRibbon() => new RibbonView();

        public FrameworkElement GetMainView() => new MainView();

        public FrameworkElement GetStatusBar() => new StatusBarView();
    }
}
