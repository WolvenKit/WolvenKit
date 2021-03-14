using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage
{
    public partial class HomePageView
    {
        #region Fields

        public static HomePageView GlobalHomePage;

        #endregion Fields

        #region Constructors

        public HomePageView()
        {
            InitializeComponent();
            GlobalHomePage = this;
        }

        #endregion Constructors

        #region Methods

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            StaticReferences.GlobalShell.DragMove();
        }

        private void Grid_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMouseOver)
                {
                    if (StaticReferences.GlobalShell.WindowState == WindowState.Maximized)
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(Window.WindowStateProperty, WindowState.Normal);
                    }
                    else
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(Window.WindowStateProperty, WindowState.Maximized);
                    }
                }
            }
            else
            {
                base.OnMouseLeftButtonDown(e);
                StaticReferences.GlobalShell.DragMove();
            }
        }

        #endregion Methods
    }
}
