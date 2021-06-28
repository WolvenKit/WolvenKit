using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Catel.IoC;
using CP77.CR2W;
using HandyControl.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Docking;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.ViewModels.Editor;
using SelectionChangedEventArgs = System.Windows.Controls.SelectionChangedEventArgs;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using Wolvenkit.InteropControls;

namespace WolvenKit.Views.Editor
{
    public partial class AssetBrowserView : INotifyPropertyChanged
    {
        public static AssetBrowserView GlobalABView;

        public AssetBrowserView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
            GlobalABView = this;
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void SearchBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (string.Equals(SBBar.Text, "Search", System.StringComparison.OrdinalIgnoreCase))
            {
                SBBar.SetCurrentValue(TextBox.TextProperty, "");
            }
        }

        private void SBBar_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (string.Equals(SBBar.Text, "Search", System.StringComparison.OrdinalIgnoreCase))
            {
                SBBar.SetCurrentValue(TextBox.TextProperty, "");
            }
        }

        private void InnerList_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {
            if (StaticReferences.GlobalPropertiesView == null)
            { return; }

            if (ViewModel is not AssetBrowserViewModel vm)
            { return; }

            var propertiesViewModel = ServiceLocator.Default.ResolveType<PropertiesViewModel>();

            if (propertiesViewModel.State is DockState.AutoHidden or DockState.Hidden)
            { return; }

            if (propertiesViewModel.canShowPrev)
            {
                propertiesViewModel.AB_SelectedItem = vm.RightSelectedItem;
            }
            else
            {
                return;
            }

            propertiesViewModel.AB_MeshPreviewVisible = false;
            propertiesViewModel.IsAudioPreviewVisible = false;
            propertiesViewModel.IsImagePreviewVisible = false;

            if (propertiesViewModel.AB_SelectedItem != null)
            {
                var selectedItem = propertiesViewModel.AB_SelectedItem;
                var selectedGameFile = propertiesViewModel.AB_SelectedItem.GetGameFile();

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.mesh.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                { PreviewMesh(propertiesViewModel, selectedItem, selectedGameFile); }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.wem.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                { PreviewWem(propertiesViewModel, selectedItem, selectedGameFile); }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.xbm.ToString(),
                                            System.StringComparison.OrdinalIgnoreCase))
                { PreviewTexture(propertiesViewModel, selectedItem, selectedGameFile); }
            }
            propertiesViewModel.DecideForMeshPreview();
        }

        private void PreviewMesh(PropertiesViewModel propertiesViewModel, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.AB_MeshPreviewVisible = true;

            var managerCacheDir = ISettingsManager.GetTemp_MeshPath();
            Directory.CreateDirectory(managerCacheDir);
            foreach (var f in Directory.GetFiles(managerCacheDir))
            {
                try
                { File.Delete(f); }
                catch { }
            }

            var endPath = Path.Combine(managerCacheDir, Path.GetFileName(selectedItem.Name));
            var q2 = ServiceLocator.Default.ResolveType<MeshTools>().ExportMeshWithoutRigPreviewer(selectedGameFile, endPath, ISettingsManager.GetTemp_OBJPath());
            if (q2.Length > 0)
            { StaticReferences.GlobalPropertiesView.LoadModel(q2); }
        }

        private void PreviewWem(PropertiesViewModel propertiesViewModel, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.IsAudioPreviewVisible = true;

            var managerCacheDir = ISettingsManager.GetTemp_Audio_importPath();
            Directory.CreateDirectory(managerCacheDir);

            var endPath = Path.Combine(managerCacheDir, Path.GetFileName(selectedItem.Name));
            foreach (var f in Directory.GetFiles(managerCacheDir))
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                }
            }

            using (var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write))
            {
                selectedGameFile.Extract(fs);
            }

            if (File.Exists(endPath))
            {
                propertiesViewModel.AddAudioItem(endPath);
            }
        }

        private async void PreviewTexture(PropertiesViewModel propertiesViewModel, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.IsImagePreviewVisible = true;

            var man = ServiceLocator.Default.ResolveType<ModTools>();

            // extract cr2w to stream
            await using var cr2wstream = new MemoryStream();
            selectedGameFile.Extract(cr2wstream);

            // convert xbm to dds stream
            await using var ddsstream = new MemoryStream();
            var expargs = new XbmExportArgs { Flip = false, UncookExtension = EUncookExtension.tga };
            man.UncookXbm(cr2wstream, ddsstream, out _);

            // try loading it in pfim
            try
            {
                var qa = await ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                if (qa != null)
                { StaticReferences.GlobalPropertiesView.LoadImage(qa); }
            }
            catch (Exception) { }
        }

        private void SBBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ViewModel is not AssetBrowserViewModel vm)
            { return; }
            if (InnerList == null)
            { return; }

            if (SBBar.Text != "search" || SBBar.Text != "")
            {
                this.InnerList.SearchHelper.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SearchHelper.SearchBrushProperty, HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3"));
                this.InnerList.SearchHelper.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SearchHelper.AllowFilteringProperty, true);
                this.InnerList.SearchHelper.Search(SBBar.Text);
            }
            else
            { this.InnerList.SearchHelper.ClearSearch(); }
        }

        private void LeftNavigation_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (DataContext is not AssetBrowserViewModel vm)
            {
                return;
            }

            if (!e.AddedItems.Any())
            {
                return;
            }

            if (e.AddedItems.First() is TreeGridRowInfo { RowData: GameFileTreeNode model })
            {
                vm.RightItems = model.Files.Values.SelectMany(_ => _)
                    .Select(_ => new FileEntryViewModel(_ as FileEntry));
            }
        }

        private string _currentFolderQuery = "";

        private bool FilterNodes(object o) => o is GameFileTreeNode data && data.Name.Contains(_currentFolderQuery);

        private void FolderSearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            // expand all
            LeftNavigation.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatially
            LeftNavigation.View.Filter = FilterNodes;
            LeftNavigation.View.RefreshFilter();
        }

        private void LeftNavigationHomeButton_OnClick(object sender, RoutedEventArgs e) => LeftNavigation.CollapseAllNodes();

        private void Expand_OnClick(object sender, RoutedEventArgs e) => ExpandNode();

        public void ExpandNode()
        {
            var selectedIndex = LeftNavigation.SelectedIndex;
            LeftNavigation.ExpandNode(selectedIndex);
        }

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAllNodes();

        public void ExpandAllNodes() => LeftNavigation.ExpandAllNodes();

        private void Collapse_OnClick(object sender, RoutedEventArgs e) => CollapseNode();

        public void CollapseNode()
        {
            var selectedItem = LeftNavigation.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            var node = LeftNavigation.View.Nodes.GetNode(selectedItem);
            LeftNavigation.CollapseNode(node);
        }

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAllNodes();

        public void CollapseAllNodes() => LeftNavigation.CollapseAllNodes();

        private void RightContextMenuAddAll_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is AssetBrowserViewModel vm)
            {
                NotificationHelper.IsShowNotificationsEnabled = false;
                vm.AddSelectedCommand.SafeExecute();
            }
        }

        private void VidPreviewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (!StaticReferences.AllowVideoPreview)
            {
                return;
            }

            if (InnerList.SelectedItem == null)
            {
                return;
            }
            var selected = InnerList.SelectedItem as FileEntryViewModel;

            if (!selected.FullName.ToLower().Contains("bk2"))
            {
                return;
            }

            ///Extract to Temp dir

            var tempPath = ISettingsManager.GetTemp_Video_PreviewPath();
            var endPath = Path.Combine(tempPath, Path.GetFileName(selected.Name));

            foreach (var f in Directory.GetFiles(tempPath))
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                }
            }

            using (var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write))
            {
                selected.GetGameFile().Extract(fs);
            }

            if (File.Exists(endPath))
            {
            }

            var x = "Resources\\Media\\test.exe | " + endPath + "/I2 /P /L";

            var appControl = new AppControl();
            appControl.ExeName = x.Split('|')[0];
            appControl.Args = x.Split('|')[1];
            appControl.VisualPoint = new Point(0.0, 30.0);

            if (StaticReferences.XoWindow == null)
            {
                StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
                StaticReferences.XoWindow.Closed += (sender, args) => StaticReferences.XoWindow = null;
            }

            if (StaticReferences.XoWindow.Content != null)
            {
                return;
            }
            StaticReferences.XoWindow.Unloaded += new RoutedEventHandler((s, e) =>
            {
                var q = s as HandyControl.Controls.GlowWindow;
                q.Close();
                StaticReferences.XoWindow = null;
                StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
            });

            Grid grid = new Grid();
            grid.Children.Add(appControl);
            StaticReferences.XoWindow.SetCurrentValue(ContentProperty, grid);
            StaticReferences.XoWindow.SetCurrentValue(Window.TopmostProperty, true);
            StaticReferences.XoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            StaticReferences.XoWindow.Show();
        }
    }
}
