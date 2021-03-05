using System.Windows;
using Orchestra.Services;
using WolvenKit.MVVM.Views.Shell.Editor;

namespace WolvenKit.Functionality.Services
{
    public class RibbonService : IRibbonService
    {
        #region Methods

        public FrameworkElement GetMainView() => new MainView();

        public FrameworkElement GetRibbon() => new RibbonView();

        public FrameworkElement GetStatusBar() => new StatusBarView();

        #endregion Methods
    }
}
