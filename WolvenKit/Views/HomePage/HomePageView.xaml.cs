using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Shell;

namespace WolvenKit.Views.HomePage
{
    public partial class HomePageView
    {
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

        }

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
    }
}
