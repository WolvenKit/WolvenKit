using System.Windows;
using Feather.Controls;
using WolvenKit.Functionality.Services;
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





            guide.SetCurrentValue(GuidedTour.ItemsProperty, new[]{
                new GuidedTourItem()
                {
                    Target = LeftSideMenu,
                    Content = "On the left is the side menu of the homepage.\nYou can find items relevant to the categories indicated.\n\nClick on the background of the SideMenu to continue",
                    Placement = GuidedTourItem.ItemPlacement.Right,
                    Title = "Side Menu",


                },
                new GuidedTourItem()
                {
                    Target = LogoNavi,
                    Content = "This logo also acts as a button, by clicking it you exit the homepage.\n(Same for the button on the bottom of the 'SideMenu') \n\nClick anywhere to continue",
                    Placement = GuidedTourItem.ItemPlacement.Right,
                    Title = "WolvenKit Logo",
                    AlternateTargets = new[] { FocusGrid }
                },
                        new GuidedTourItem()
                {
                    Target = WlcmPage.RecentProjectTour,
                    Content = "Below you can find your recent projects. (If you are new this should be empty)\n\nClick on the 'Recent Projects Text' to continue",
                    Placement = GuidedTourItem.ItemPlacement.Top,
                    Title = "Recent Projects Overview",
                },
                new GuidedTourItem()
                {
                    Target = WlcmPage.irathernot,
                    Content = "On the right you can find a 'quick access panel'.\nLet's start of making a new project.\n\nClick on 'Create Project' to continue\n (The tour will continue after creating a new project)",
                    Placement = GuidedTourItem.ItemPlacement.Left,
                    Title = "Quick Access Panel",
                }
            });

            if (SettingsManager.ShowGuidedTour)
            {
                guide.Visibility = Visibility.Visible;

            }



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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            guide.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            guide.Reset();


        }
    }
}
