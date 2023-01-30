using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Extensions;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.HomePage.Pages;
using WolvenKit.App.ViewModels.Shell;
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

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        viewmodel => viewmodel.SelectedIndex,
                        view => view.HomeTabs.SelectedIndex)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.CloseHomePageCommand,
                        view => view.ToEditorButton)
                    .DisposeWith(disposables);
            });

        }

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // dumb hack
            if (ViewModel.SelectedIndex == (int)EHomePage.Mods)
            {
                return;
            }

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

        // TODO: Can't you bind this directly in XAML? -wopss

        private void ModsPageTab_Selected(object sender, RoutedEventArgs e)
        {
            if (sender is TabItem tab && tab.Content is Pages.ModsView view && view.DataContext is ModsViewModel vm)
            {
                vm.CheckRedModCommand.SafeExecute();
            }
        }

        private void PluginsPageTab_Selected(object sender, RoutedEventArgs e)
        {
            if (sender is TabItem tab && tab.Content is Pages.PluginsToolView view && view.DataContext is PluginsToolViewModel vm)
            {
                //vm.ReloadCommand.SafeExecute();
            }
        }

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    guide.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        //    guide.Reset();
        //}

    }
}
