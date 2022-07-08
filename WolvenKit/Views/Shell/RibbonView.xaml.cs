using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        private AppViewModel _mainViewModel;


        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;

            InitializeComponent();

            MaxBackgroundThreadsCount = Environment.ProcessorCount - 1;

            this.WhenActivated(disposables =>
            {
                _mainViewModel = Locator.Current.GetService<AppViewModel>();

                #region commands

                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.ShowHomePageCommand,
                        view => view.HomeButton)
                    .DisposeWith(disposables);

                // toolbar
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.NewFileCommand,
                        view => view.ToolbarNewButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.SaveFileCommand,
                        view => view.ToolbarSaveButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.SaveAsCommand,
                        view => view.ToolbarSaveAsButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.SaveAllCommand,
                        view => view.ToolbarSaveAllButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.NewProjectCommand,
                        view => view.ToolbarNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.PackModCommand,
                        view => view.ToolbarPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.PackInstallModCommand,
                        view => view.ToolbarPackInstallButton)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.LaunchGameCommand,
                        view => view.ToolbarLaunchButton)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.SelectedGameCommandIdx,
                        view => view.ToolbarLaunchCombobox.SelectedIndex)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel._mainViewModel.SelectedGameCommands,
                        view => view.ToolbarLaunchCombobox.ItemsSource)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.ShowSettingsCommand,
                        view => view.ToolbarSettingsButton)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.ProjectExplorer.IsVisible,
                        view => view.ProjectExplorerCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.AssetBrowserVM.IsVisible,
                        view => view.AssetBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    viewModel => viewModel._mainViewModel.PropertiesViewModel.IsVisible,
                        view => view.PropertiesCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.Log.IsVisible,
                        view => view.LogCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.ImportExportToolVM.IsVisible,
                        view => view.ImportExportCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.TweakBrowserVM.IsVisible,
                        view => view.TweakBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel._mainViewModel.LocKeyBrowserVM.IsVisible,
                        view => view.LocKeyBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);

                #endregion

                Interactions.ShowBugReport.RegisterHandler(interaction =>
                {
                    var dialog = new DialogHostView();
                    dialog.ViewModel.HostedViewModel = Locator.Current.GetService<BugReportWizardViewModel>();
                    dialog.Owner = Application.Current.MainWindow;
                    dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;

                    return Observable.Start(() =>
                    {
                        var result = dialog.ShowDialog() == true;
                        interaction.SetOutput(result);
                    }, RxApp.MainThreadScheduler);
                });
                Interactions.ShowFeedback.RegisterHandler(interaction =>
                {
                    var dialog = new DialogHostView();
                    dialog.ViewModel.HostedViewModel = Locator.Current.GetService<FeedbackWizardViewModel>();
                    dialog.Owner = Application.Current.MainWindow;
                    dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;

                    return Observable.Start(() =>
                    {
                        var result = dialog.ShowDialog() == true;
                        interaction.SetOutput(result);
                    }, RxApp.MainThreadScheduler);
                });

            });
        }

        #region properties


        #endregion

        //private void SetRibbonUI()
        //{
        //    while (_ribbon.BackStageButton.IsVisible)
        //    {
        //        _ribbon.BackStageButton.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        //    }
        //    Trace.WriteLine("Disabled File Button");
        //}

        public int MaxBackgroundThreadsCount { get; set; }

        public static MaterialsRepositoryDialog MaterialsRepositoryDia { get; set; }

        private void GenerateMaterialRepoButton_Click(object sender, RoutedEventArgs e)
        {
            if (MaterialsRepositoryDia == null)
            {
                var x = new MaterialsRepositoryDialog();
                MaterialsRepositoryDia = x;
                x.Show();
            }
        }

        private void SetLayoutToDefault(object sender, RoutedEventArgs e) => DockingAdapter.G_Dock.SetLayoutToDefault();
        private void SaveLayoutToProject(object sender, RoutedEventArgs e) => DockingAdapter.G_Dock.SaveLayoutToProject();

        private void ExandAllNodesContext_Click(object sender, RoutedEventArgs e) =>
            _mainViewModel.ProjectExplorer.ExpandAll.Execute().Subscribe();

        private void collapseAllNodesContext_Click(object sender, RoutedEventArgs e) =>
            _mainViewModel.ProjectExplorer.CollapseAll.Execute().Subscribe();

        private void CollapseChildrenContext_Click(object sender, RoutedEventArgs e) =>
            _mainViewModel.ProjectExplorer.CollapseChildren.Execute().Subscribe();

        private void ExandChildrenContext_Click(object sender, RoutedEventArgs e) =>
            _mainViewModel.ProjectExplorer.ExpandChildren.Execute().Subscribe();



        private void ExpandAllAB_Click(object sender, RoutedEventArgs e) => _mainViewModel.AssetBrowserVM.ExpandAll.Execute().Subscribe();

        private void CollapseAllAB_Click(object sender, RoutedEventArgs e) => _mainViewModel.AssetBrowserVM.CollapseAll.Execute().Subscribe();

        private void ExpandSingleAB_Click(object sender, RoutedEventArgs e) => _mainViewModel.AssetBrowserVM.Expand.Execute().Subscribe();

        private void collapseSingleAB_Click(object sender, RoutedEventArgs e) => _mainViewModel.AssetBrowserVM.Collapse.Execute().Subscribe();

        private void Ribbon_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            var mainWindow = (MainView)Locator.Current.GetService<IViewFor<AppViewModel>>();
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                mainWindow?.DragMove();
            }
        }

        ///// <summary>
        ///// Closes material drawer
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Button_Click_2(object sender, RoutedEventArgs e) => MatRepoDrawer.SetCurrentValue(HandyControl.Controls.Drawer.IsOpenProperty, false);
    }
}
