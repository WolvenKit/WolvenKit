using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Media;
using Ab3d.DirectX;
using Ab3d.DirectX.Client.Settings;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Editor;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;

            InitializeComponent();

            var dxEngineSettingsStorage = new DXEngineSettingsStorage();
            DXEngineSettings.Initialize(dxEngineSettingsStorage);
            this.MaxBackgroundThreadsCount = Environment.ProcessorCount - 1;

            this.WhenActivated(disposables =>
            {
                // contextual tabs
                CPEOpenFileButton.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                OpeninFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                CopyFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                PasteFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                DeleteFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();
                RenameFileContext.DataContext = Locator.Current.GetService<ProjectExplorerViewModel>();

                PrevFileInfo.DataContext = Locator.Current.GetService<PropertiesViewModel>();


                _mainViewModel = Locator.Current.GetService<AppViewModel>();


                _mainViewModel.ProjectExplorer.WhenAnyValue(x => x.IsActive).Subscribe(b =>
                    projectexplorercontextab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, b));
                _mainViewModel.AssetBrowserVM.WhenAnyValue(x => x.IsActive).Subscribe(b =>
                    abcontextab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, b));

                // App Menu
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.AppMenuOpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.NewProjectCommand,
                        view => view.AppMenuNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.PackProjectCommand,
                        view => view.AppMenuPackProjectButton)
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
                        viewModel => viewModel.SaveAllCommand,
                        view => view.AppMenuSaveAllFileButton)
                    .DisposeWith(disposables);

                // General
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.GeneralOpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel._mainViewModel.NewProjectCommand,
                        view => view.GeneralNewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.PackProjectCommand,
                        view => view.GeneralPackProjectButton)
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
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ViewCodeEditorCommand,
                        view => view.ViewCodeEditorButton)
                    .DisposeWith(disposables);

                //Options
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ShowSettingsCommand,
                        view => view.OptionsShowSettingsButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ShowBugReportCommand,
                        view => view.OptionsShowBugReportButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ShowFeedbackCommand,
                        view => view.OptionsShowFeedbackButton)
                    .DisposeWith(disposables);

                // Utilities
                this.BindCommand(ViewModel,
                        viewModel => viewModel.ShowImportExportToolCommand,
                        view => view.UtilitiesShowImportExportToolButton)
                    .DisposeWith(disposables);

            });
        }

        #region properties

        private AppViewModel _mainViewModel;

        #endregion



        private void SetRibbonUI()
        {
            while (_ribbon.BackStageButton.IsVisible)
            {
                _ribbon.BackStageButton.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            }
            Trace.WriteLine("Disabled File Button");
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //_ribbon.SetCurrentValue(Syncfusion.Windows.Tools.Controls.Ribbon.IsBackStageVisibleProperty, true);

            ViewModel.StartScreenShown = false;
            ViewModel.BackstageIsOpen = true;
        }

        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)Application.Current.FindResource("MahApps.Brushes.Accent3");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);
        }

        private void Border_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)Application.Current.FindResource("MahApps.Brushes.AccentBase");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);
        }

        private double _selectedDpiScale = double.NaN;

        public int MaxBackgroundThreadsCount { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dxEngineSettingsWindow = new DXEngineSettingsWindow();

            if (DXEngineSettings.Current.GraphicsProfiles != null && DXEngineSettings.Current.GraphicsProfiles.Length > 0)
            {
                dxEngineSettingsWindow.SelectedGraphicsProfile = DXEngineSettings.Current.GraphicsProfiles[0];
            }
            else
            {
                dxEngineSettingsWindow.SelectedGraphicsProfile = null;
            }

            dxEngineSettingsWindow.SelectedDpiScale = _selectedDpiScale;

            dxEngineSettingsWindow.SelectedMaxBackgroundThreadsCount = MaxBackgroundThreadsCount;

            dxEngineSettingsWindow.ShowDialog();

            GraphicsProfile selectedGraphicsProfile = dxEngineSettingsWindow.SelectedGraphicsProfile;

            // Save the selected GraphicsProfile to application settings
            DXEngineSettings.Current.SaveGraphicsProfile(selectedGraphicsProfile);

            _selectedDpiScale = dxEngineSettingsWindow.SelectedDpiScale;
            MaxBackgroundThreadsCount = dxEngineSettingsWindow.SelectedMaxBackgroundThreadsCount;

            // Now create an array of GraphicsProfile from selectedGraphicsProfiles
            // If selectedGraphicsProfiles is hardware GraphicProfile, than we will also add software and WPF 3D rendering as fallback to the array
            DXEngineSettings.Current.GraphicsProfiles = DXEngineSettings.Current.SystemCapabilities.CreateArrayOfRecommendedGraphicsProfiles(selectedGraphicsProfile);
        }

        public static MaterialsRepositoryDialog MaterialsRepositoryDia { get; set; }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {
            if (MaterialsRepositoryDia == null)
            {
                var x = new MaterialsRepositoryDialog();
                MaterialsRepositoryDia = x;
                x.Show();
            }
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e) => DockingAdapter.G_Dock.SetLayoutToDefault();

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

        /// <summary>
        /// Closes material drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e) => MatRepoDrawer.SetCurrentValue(HandyControl.Controls.Drawer.IsOpenProperty, false);
    }
}
