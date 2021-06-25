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
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Models.Docking;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.ViewModels.Editor;
using SelectionChangedEventArgs = System.Windows.Controls.SelectionChangedEventArgs;

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

            propertiesViewModel.AB_SelectedItem = vm.SelectedFile;
            propertiesViewModel.AB_MeshPreviewVisible = false;
            propertiesViewModel.IsAudioPreviewVisible = false;
            propertiesViewModel.IsImagePreviewVisible = false;

            var wKitAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");

            if (propertiesViewModel.AB_SelectedItem != null)
            {
                var selectedItem = propertiesViewModel.AB_SelectedItem;
                var selectedGameFile = propertiesViewModel.AB_SelectedItem.GetGameFile();

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.mesh.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                { PreviewMesh(propertiesViewModel, wKitAppData, selectedItem, selectedGameFile); }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.wem.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                { PreviewWem(propertiesViewModel, wKitAppData, selectedItem, selectedGameFile); }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.xbm.ToString(),
                                            System.StringComparison.OrdinalIgnoreCase))
                { PreviewTexture(propertiesViewModel, wKitAppData, selectedItem, selectedGameFile); }
            }
            propertiesViewModel.DecideForMeshPreview();
        }

        private void PreviewMesh(PropertiesViewModel propertiesViewModel, string wKitAppData, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.AB_MeshPreviewVisible = true;

            var managerCacheDir = Path.Combine(wKitAppData, "Temp_Mesh");
            Directory.CreateDirectory(managerCacheDir);
            foreach (var f in Directory.GetFiles(managerCacheDir))
            {
                try
                { File.Delete(f); }
                catch { }
            }

            var endPath = Path.Combine(managerCacheDir, Path.GetFileName(selectedItem.Name));
            var q2 = ServiceLocator.Default.ResolveType<MeshTools>().ExportMeshWithoutRigPreviewer(selectedGameFile, endPath);
            if (q2.Length > 0)
            { StaticReferences.GlobalPropertiesView.LoadModel(q2); }
        }

        private void PreviewWem(PropertiesViewModel propertiesViewModel, string wKitAppData, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.IsAudioPreviewVisible = true;

            var managerCacheDir = Path.Combine(wKitAppData, "Temp_Audio_import");
            string EndPath = Path.Combine(managerCacheDir, Path.GetFileName(selectedItem.Name));
            Directory.CreateDirectory(managerCacheDir);
            foreach (var f in Directory.GetFiles(managerCacheDir))
            {
                try
                { File.Delete(f); }
                catch { }
            }
            using var fs = new FileStream(EndPath, FileMode.Create, FileAccess.Write);
            selectedGameFile.Extract(fs);

            if (File.Exists(EndPath))
            { propertiesViewModel.AddAudioItem(EndPath); }
        }

        private async void PreviewTexture(PropertiesViewModel propertiesViewModel, string wKitAppData, FileEntryViewModel selectedItem, IGameFile selectedGameFile)
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
                if (qa != null)                {                    StaticReferences.GlobalPropertiesView.LoadImage(qa);                }
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
                vm.CurrentNodeFiles = model.Files.Values.SelectMany(_ => _)
                    .Select(_ => new FileEntryViewModel(_ as FileEntry));
            }
        }
    }
}
