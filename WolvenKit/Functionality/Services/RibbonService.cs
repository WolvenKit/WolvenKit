using Orchestra.Services;
using System.Windows;
using WolvenKit.MVVM.Views.Shell.Editor;
using WolvenKit.Views;

namespace WolvenKit.Functionality.Services
{
    public class RibbonService : IRibbonService
    {
        public FrameworkElement GetRibbon() => new RibbonView();

        public FrameworkElement GetMainView() => new MainView();

        public FrameworkElement GetStatusBar() => new StatusBarView();
    }
}
