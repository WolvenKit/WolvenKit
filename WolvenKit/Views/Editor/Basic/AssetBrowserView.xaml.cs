using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CP77.CR2W;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Docking;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.ViewModels.Editor;
using System.Text.RegularExpressions;
using System.Reactive.Linq;
using Syncfusion.Data;
using DynamicData;

namespace WolvenKit.Views.Editor
{
    public partial class AssetBrowserView : ReactiveUserControl<AssetBrowserViewModel>
    {
        private string _currentFolderQuery = "";

        public AssetBrowserView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<AssetBrowserViewModel>();
            DataContext = ViewModel;


            this.WhenActivated(disposables =>
            {

                ViewModel.ExpandAll.Subscribe(x => ExpandAllNodes());
                ViewModel.CollapseAll.Subscribe(x => CollapseAllNodes());
                ViewModel.Expand.Subscribe(x => ExpandNode());
                ViewModel.Collapse.Subscribe(x => CollapseNode());

                //FileSearchBar.Events().SearchStarted
                var observable = Observable.FromEventPattern<EventHandler<FunctionEventArgs<string>>, FunctionEventArgs<string>>(
                            handler => FileSearchBar.SearchStarted += handler,
                            handler => FileSearchBar.SearchStarted -= handler)
                    .Select(x => x.EventArgs.Info)
                    //.InvokeCommand(this, x => x.ViewModel.SearchStartedCommand);
                    .Subscribe(query =>
                   {
                       ViewModel.PerformSearch(query);
                       ResetDataGridPages();
                   });

            });

        }

        #region methods

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
            var q2 = Locator.Current.GetService<MeshTools>().ExportMeshWithoutRigPreviewer(selectedGameFile, endPath, ISettingsManager.GetTemp_OBJPath());
            if (q2.Length > 0)
            {
                propertiesViewModel.LoadModel(q2);
            }
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

            var man = Locator.Current.GetService<ModTools>();

            // extract cr2w to stream
            await using var cr2wstream = new MemoryStream();
            selectedGameFile.Extract(cr2wstream);

            // convert xbm to dds stream
            await using var ddsstream = new MemoryStream();
            var expargs = new XbmExportArgs { Flip = false, UncookExtension = EUncookExtension.tga };
            man.ConvertXbmToDdsStream(cr2wstream, ddsstream, out _);

            // try loading it in pfim
            try
            {
                var qa = await ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                if (qa != null)
                {
                    propertiesViewModel.LoadImage(qa);
                }
            }
            catch (Exception) { }
        }

        private bool FilterNodes(object o) => o is GameFileTreeNode data && data.Name.Contains(_currentFolderQuery);

        #endregion

        #region leftNavigation

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
                vm.RightItems.Clear();
                vm.RightItems.AddRange(model.Files
                    .Select(_ => new FileEntryViewModel(_ as FileEntry))
                    .OrderBy(_ => Regex.Replace(_.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
            }

            // reset rightside
            ResetDataGridPages();
        }

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

        #region expand/collapse

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

        #endregion

        #endregion

        #region rightFileGrid

        private void FileSearchBar_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (string.Equals(FileSearchBar.Text, "Search", System.StringComparison.OrdinalIgnoreCase))
            {
                FileSearchBar.SetCurrentValue(TextBox.TextProperty, "");
            }
        }
        private void FileSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (ViewModel is not AssetBrowserViewModel vm)
            //{
            //    return;
            //}
            //if (InnerList == null)
            //{
            //    return;
            //}

            //if (FileSearchBar.Text != "search" || FileSearchBar.Text != "")
            //{
            //    this.InnerList.SearchHelper.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SearchHelper.SearchBrushProperty, HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3"));
            //    this.InnerList.SearchHelper.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SearchHelper.AllowFilteringProperty, true);
            //    this.InnerList.SearchHelper.Search(FileSearchBar.Text);
            //}
            //else
            //{
            //    this.InnerList.SearchHelper.ClearSearch();
            //}
        }

        private void InnerList_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {
            if (ViewModel is not AssetBrowserViewModel vm)
            {
                return;
            }

            var propertiesViewModel = Locator.Current.GetService<PropertiesViewModel>();

            if (propertiesViewModel.State is DockState.AutoHidden or DockState.Hidden)
            {
                return;
            }

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
                {
                    PreviewMesh(propertiesViewModel, selectedItem, selectedGameFile);
                }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.wem.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                {
                    PreviewWem(propertiesViewModel, selectedItem, selectedGameFile);
                }

                if (string.Equals(propertiesViewModel.AB_SelectedItem.Extension, ERedExtension.xbm.ToString(),
                                            System.StringComparison.OrdinalIgnoreCase))
                {
                    PreviewTexture(propertiesViewModel, selectedItem, selectedGameFile);
                }
            }
            propertiesViewModel.DecideForMeshPreview();
        }

       

        
        private void RightContextMenuAddAll_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is AssetBrowserViewModel vm)
            {
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

            if (!File.Exists(endPath))
            {
                return;
            }


            var args = $"\"{endPath}\" /I102 /p";
            var procInfo =
                new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                    "test.exe"))
                {

                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            process?.WaitForInputIdle();
            //var appControl = new AppControl();
            //appControl.ExeName = x.Split('|')[0];
            //appControl.Args = x.Split('|')[1];
            //appControl.VisualPoint = new Point(0.0, 30.0);

            //if (StaticReferences.XoWindow == null)
            //{
            //    StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
            //    StaticReferences.XoWindow.Closed += (sender, args) => StaticReferences.XoWindow = null;
            //}

            //if (StaticReferences.XoWindow.Content != null)
            //{
            //    return;
            //}
            //StaticReferences.XoWindow.Unloaded += new RoutedEventHandler((s, e) =>
            //{
            //    var q = s as HandyControl.Controls.GlowWindow;
            //    q.Close();
            //    StaticReferences.XoWindow = null;
            //    StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
            //});

            //Grid grid = new Grid();
            //grid.Children.Add(appControl);
            //StaticReferences.XoWindow.SetCurrentValue(ContentProperty, grid);
            //StaticReferences.XoWindow.SetCurrentValue(Window.TopmostProperty, true);
            //StaticReferences.XoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //StaticReferences.XoWindow.Show();
        }

        private void BKExport_Click(object sender, RoutedEventArgs e)
        {
            //var q = InnerList.SelectedItems[0] as FileEntryViewModel;

            //if (!q.Extension.ToLower().Contains("bk2"))
            //{ return; }

            /////Extract to Temp dir

            //var tempPath = ISettingsManager.GetTemp_Video_PreviewPath();
            //var endPath = Path.Combine(tempPath, Path.GetFileName(q.Name));
            //using (var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write))
            //{
            //    q.GetGameFile().Extract(fs);
            //}
            //if (!File.Exists(endPath))
            //{
            //    return;
            //}

            //// Need to get this file to RAW

            //var procInfo = new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"));
            //procInfo.Arguments = endPath + " " + Path.ChangeExtension(endPath, ".avi") + "/o /#";
            //procInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"));
            //// Start the process
            //var process = System.Diagnostics.Process.Start(procInfo);
            //// Wait for process to be created and enter idle condition
            //process.WaitForInputIdle();
        }



        private void dataPager_OnDemandLoading(object sender, Syncfusion.UI.Xaml.Controls.DataPager.OnDemandLoadingEventArgs args)
        {
            if (ViewModel.RightItems !=  null)
            {
                if (ViewModel.RightItems.Any())
                {
                    var items = ViewModel.RightItems.Skip(args.StartIndex)?.Take(args.PageSize);
                    dataPager.LoadDynamicItems(args.StartIndex, items);
                }
                else
                {
                    dataPager.SetCurrentValue(Syncfusion.UI.Xaml.Controls.DataPager.SfDataPager.SourceProperty, ViewModel.RightItems);
                }
            }
            
        }

        private void ResetDataGridPages()
        {
            if (ViewModel.RightItems == null)
            {
                return;
            }

            var prevPageCount = this.dataPager.PageCount;

            if (ViewModel.RightItems.Count < dataPager.PageSize)
            {
                dataPager.SetCurrentValue(Syncfusion.UI.Xaml.Controls.DataPager.SfDataPager.PageCountProperty, 1);
            }
            else
            {
                var count = ViewModel.RightItems.Count / dataPager.PageSize;

                if (ViewModel.RightItems.Count % dataPager.PageSize == 0)
                {
                    dataPager.SetCurrentValue(Syncfusion.UI.Xaml.Controls.DataPager.SfDataPager.PageCountProperty, count);
                }
                else
                {
                    dataPager.SetCurrentValue(Syncfusion.UI.Xaml.Controls.DataPager.SfDataPager.PageCountProperty, count + 1);
                }
            }

            var newPageCount = this.dataPager.PageCount;

            dataPager.MoveToPage(0);
            //if (newPageCount == prevPageCount)
            {
                (dataPager.PagedSource as PagedCollectionView).ResetCacheForPage(this.dataPager.PageIndex);
            }
        }

        #endregion
    }
}
