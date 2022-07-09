using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;
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
                #region contextual tab bindings

                // project explorer
                CPEOpenFileButton.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                OpeninFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                CopyFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                PasteFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                DeleteFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                RenameFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();

                // asset browser
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.AddSelectedCommand,
                        view => view.AddSelectedItemsButton).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.ToggleModBrowserCommand,
                        view => view.ModBrowserButton).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.OpenFileLocationCommand,
                        view => view.SearchOpenFileLocation).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.AddSearchKeyCommand,
                        view => view.SearchKindButton).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.AddSearchKeyCommand,
                        view => view.SearchKindButton).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.AddSearchKeyCommand,
                        view => view.SearchKindButton).DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.AssetBrowserVM.AddSearchKeyCommand,
                        view => view.SearchKindButton).DisposeWith(disposables);

                #endregion

                _mainViewModel = Locator.Current.GetService<AppViewModel>();

                _mainViewModel.ProjectExplorer.WhenAnyValue(x => x.IsActive).Subscribe(b =>
                    projectexplorercontextab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, b));
                _mainViewModel.AssetBrowserVM.WhenAnyValue(x => x.IsActive).Subscribe(b =>
                    abcontextab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, b));
                //_mainViewModel.ActiveDocument.WhenAnyValue(x => x != null && x.IsActive).Subscribe(b =>
                //    documentContextTab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, b));

                #region commands

                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.ShowHomePageCommand,
                        view => view.HomePageButton)
                    .DisposeWith(disposables);

                // App Menu
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.AppMenuOpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewProjectCommand,
                        view => view.AppMenuNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.PackProjectCommand,
                        view => view.AppMenuPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.AppMenuPackInstallButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.NewFileCommand,
                        view => view.AppMenuNewFileButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveFileCommand,
                        view => view.AppMenuSaveFileButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveAsCommand,
                        view => view.AppMenuSaveAsFileButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveAllCommand,
                        view => view.AppMenuSaveAllFileButton)
                    .DisposeWith(disposables);

                // General
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.GeneralOpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewProjectCommand,
                        view => view.GeneralNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.PackProjectCommand,
                        view => view.GeneralPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.GeneralPackInstallButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.NewFileCommand,
                        view => view.GeneralNewFileButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveFileCommand,
                        view => view.GeneralSaveFileButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveAsCommand,
                        view => view.GeneralSaveAsButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.SaveAllCommand,
                        view => view.GeneralSaveAllButton)
                    .DisposeWith(disposables);

                //View
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ViewProjectExplorerCommand,
                        view => view.ViewProjectExplorerButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ViewAssetBrowserCommand,
                        view => view.ViewAssetBrowserButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ViewPropertiesCommand,
                        view => view.ViewPropertiesButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ViewLogCommand,
                        view => view.ViewLogButton)
                    .DisposeWith(disposables);
                //this.BindCommand(ViewModel,
                //        viewModel => viewModel.ViewCodeEditorCommand,
                //        view => view.ViewCodeEditorButton)
                //    .DisposeWith(disposables);

                //Options
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.ShowSettingsCommand,
                        view => view.OptionsShowSettingsButton)
                    .DisposeWith(disposables);

                // Utilities
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ShowImportExportToolCommand,
                        view => view.UtilitiesShowImportExportToolButton)
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
