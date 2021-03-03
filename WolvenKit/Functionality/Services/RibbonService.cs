using System.Windows;
using Orchestra.Services;
using WolvenKit.MVVM.Views.Shell.Editor;

namespace WolvenKit.Functionality.Services
{
    public class RibbonService : IRibbonService
    {
        public FrameworkElement GetRibbon() => new RibbonView();

        public FrameworkElement GetMainView() => new MainView();

        public FrameworkElement GetStatusBar() => new StatusBarView();
    }
}
