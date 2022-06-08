using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Views.Shell;

namespace WolvenKit.Views.HomePage
{
    public partial class HomePageView
    {
        #region Fields


        #endregion Fields

        #region Constructors
        private readonly ISettingsManager _settingsManager;
        private readonly RibbonViewModel _ribbon;

        public HomePageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<HomePageViewModel>();
            DataContext = ViewModel;

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _ribbon = Locator.Current.GetService<RibbonViewModel>();

            this.WhenActivated(disposables => this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedIndex,
                      view => view.HomeTabs.SelectedIndex)
                  .DisposeWith(disposables));

            //guide.SetCurrentValue(GuidedTour.ItemsProperty, new[]{
            //    new GuidedTourItem()
            //    {
            //        Target = LeftSideMenu,
            //        Content = "On the left is the side menu of the homepage.\nYou can find items relevant to the categories indicated.\n\nClick on the background of the SideMenu to continue",
            //        Placement = GuidedTourItem.ItemPlacement.Right,
            //        Title = "Side Menu",


            //    },
            //    new GuidedTourItem()
            //    {
            //        Target = LogoNavi,
            //        Content = "This logo also acts as a button, by clicking it you exit the homepage.\n(Same for the button on the bottom of the 'SideMenu') \n\nClick anywhere to continue",
            //        Placement = GuidedTourItem.ItemPlacement.Right,
            //        Title = "WolvenKit Logo",
            //        AlternateTargets = new FrameworkElement[] { FocusGrid }
            //    },
            //            new GuidedTourItem()
            //    {
            //        Target = WlcmPage.RecentProjectTour,
            //        Content = "Below you can find your recent projects. (If you are new this should be empty)\n\nClick on the 'Recent Projects Text' to continue",
            //        Placement = GuidedTourItem.ItemPlacement.Top,
            //        Title = "Recent Projects Overview",
            //    },
            //    new GuidedTourItem()
            //    {
            //        Target = WlcmPage.DiscordLinkButton,
            //        Content = "On the right you can find a 'quick access panel'.\nLet's start of making a new project.\n\nClick on 'Create Project' to continue\n (The tour will End here, more will be explained in the next version.)",
            //        Placement = GuidedTourItem.ItemPlacement.Left,
            //        Title = "Quick Access Panel",
            //        AlternateTargets = new FrameworkElement[] { WlcmPage.YoutubeLinkButton}
            //    }
            //});


            guide.Finished += Guide_Finished;

            if (_settingsManager is { ShowGuidedTour: true })
            {
                guide.Visibility = Visibility.Hidden;

            }
        }

        private void Guide_Finished(object sender, RoutedEventArgs e)
        {
            guide.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
            _settingsManager.ShowGuidedTour = false;
            _settingsManager.Save();
            //SAVE?
        }

        #endregion Constructors

        #region Methods

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (!e.Handled)
            {
                var mainWindow = (MainView)Locator.Current.GetService<IViewFor<AppViewModel>>();
                mainWindow?.DragMove();
            }
        }

        private void Grid_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMouseOver)
                {
                    //TODO:ORC
                    //if (StaticReferences.GlobalShell != null)
                    //{
                    //    StaticReferences.GlobalShell.SetCurrentValue(Window.WindowStateProperty,
                    //        StaticReferences.GlobalShell.WindowState == WindowState.Maximized
                    //            ? WindowState.Normal
                    //            : WindowState.Maximized);
                    //}
                }
            }
            else
            {
                base.OnMouseLeftButtonDown(e);
                var mainWindow = (MainView)Locator.Current.GetService<IViewFor<AppViewModel>>();
                mainWindow?.DragMove();
            }
        }

        #endregion Methods

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    guide.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        //    guide.Reset();
        //}

    }
}
