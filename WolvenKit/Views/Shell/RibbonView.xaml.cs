using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Shell;
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
                        viewModel => viewModel.MainViewModel.ShowHomePageCommand,
                        view => view.HomeButton)
                    .DisposeWith(disposables);

                // toolbar
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewFileCommand,
                        view => view.ToolbarNewButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveFileCommand,
                        view => view.ToolbarSaveButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveAsCommand,
                        view => view.ToolbarSaveAsButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveAllCommand,
                        view => view.ToolbarSaveAllButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewProjectCommand,
                        view => view.ToolbarNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackModCommand,
                        view => view.ToolbarPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.ToolbarPackInstallButton)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.LaunchGameCommand,
                        view => view.ToolbarLaunchButton)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.SelectedGameCommandIdx,
                        view => view.ToolbarLaunchCombobox.SelectedIndex)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.MainViewModel.SelectedGameCommands,
                        view => view.ToolbarLaunchCombobox.ItemsSource)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.ShowSettingsCommand,
                        view => view.ToolbarSettingsButton)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.ProjectExplorer.IsVisible,
                        view => view.ProjectExplorerCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.IsVisible,
                        view => view.AssetBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.PropertiesViewModel.IsVisible,
                        view => view.PropertiesCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.Log.IsVisible,
                        view => view.LogCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.ImportExportToolVM.IsVisible,
                        view => view.ImportExportCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.TweakBrowserVM.IsVisible,
                        view => view.TweakBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.MainViewModel.LocKeyBrowserVM.IsVisible,
                        view => view.LocKeyBrowserCheckbox.IsChecked)
                    .DisposeWith(disposables);

                #endregion
            });
        }

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

    }
}
