using System.Windows;
using Fluent;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.HomePage
{
    public partial class HomePageView
    {
        public static HomePageView GlobalHomePage;



        public HomePageView()
        {
            InitializeComponent();
            GlobalHomePage = this;
        }

        private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            StaticReferences.GlobalShell.DragMove();
        }

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            StaticReferences.GlobalShell.DragMove();

            // Begin dragging the window
        }



        private void Grid_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMouseOver)
                {
                    if (StaticReferences.GlobalShell.WindowState == WindowState.Maximized)
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Normal);
                    }
                    else
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Maximized);
                    }
                }
            }
            else
            {
                base.OnMouseLeftButtonDown(e);

                StaticReferences.GlobalShell.DragMove();
            }
        }

        //private void SideMenu_DebugItem_Selected(object sender, RoutedEventArgs e)
        //{
        //    if (IsLoaded && IsVisible && IsInitialized)
        //    {
        //        PageViewGrid.Children.Clear();
        //        PageViewGrid.Children.Add(DebugPV);
        //    }
        //}

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
        }
    }
}
