using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows;
using System.Windows.Media;
using Ab3d.DirectX;
using Ab3d.DirectX.Client.Settings;
using Catel.Data;
using Catel.IoC;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Editor;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView
    {
        public RibbonView()
        {
            InitializeComponent();
            StaticReferences.RibbonViewInstance = this;
            var dxEngineSettingsStorage = new DXEngineSettingsStorage();
            DXEngineSettings.Initialize(dxEngineSettingsStorage);
            this.MaxBackgroundThreadsCount = Environment.ProcessorCount - 1;
        }

        private void SetRibbonUI()
        {
            while (_ribbon.BackStageButton.IsVisible)
            {
                _ribbon.BackStageButton.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            }
            Trace.WriteLine("Disabled File Button");
        }

        protected override void OnViewModelChanged() => base.OnViewModelChanged();

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);
            OpenFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            OpeninFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            CopyFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            PasteFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            DeleteFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            RenameFileContext.DataContext = (ProjectExplorerViewModel)ServiceLocator.Default.ResolveType<ProjectExplorerViewModel>();
            PrevFileInfo.DataContext = (PropertiesViewModel)ServiceLocator.Default.ResolveType<PropertiesViewModel>();

            if (e is not AdvancedPropertyChangedEventArgs property)
            {
                return;
            }

            switch (property.PropertyName)
            {
                //case "SelectedTheme":
                //    if (property.NewValue is Color accentColor)
                //    {
                //        //var color = new SolidColorBrush(accentColor);
                //        ControlzEx.Theming.ThemeManager.Current.ChangeTheme(
                //            Application.Current,
                //            ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", accentColor, false));
                //    }

                //    break;

                default:
                    break;
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //_ribbon.SetCurrentValue(Syncfusion.Windows.Tools.Controls.Ribbon.IsBackStageVisibleProperty, true);

            RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = true;
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

        private void ExandAllNodesContext_Click(object sender, RoutedEventArgs e) => ProjectExplorerView.GlobalPEView.ExpandAll();

        private void collapseAllNodesContext_Click(object sender, RoutedEventArgs e) => ProjectExplorerView.GlobalPEView.CollapseAll();

        private void CollapseChildrenContext_Click(object sender, RoutedEventArgs e) => ProjectExplorerView.GlobalPEView.CollapseChildren();

        private void ExandChildrenContext_Click(object sender, RoutedEventArgs e) => ProjectExplorerView.GlobalPEView.ExpandChildren();

        private void ExpandAllAB_Click(object sender, RoutedEventArgs e) => AssetBrowserView.GlobalABView.ExpandAllNodes();

        private void CollapseAllAB_Click(object sender, RoutedEventArgs e) => AssetBrowserView.GlobalABView.CollapseAllNodes();

        private void ExpandSingleAB_Click(object sender, RoutedEventArgs e) => AssetBrowserView.GlobalABView.ExpandAllNodes();

        private void collapseSingleAB_Click(object sender, RoutedEventArgs e) => AssetBrowserView.GlobalABView.CollapseNode();

        /// <summary>
        /// Closes material drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e) => MatRepoDrawer.SetCurrentValue(HandyControl.Controls.Drawer.IsOpenProperty, false);
    }
}
