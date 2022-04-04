using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Text.RegularExpressions;
using System.Windows;
using DynamicData;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Docking;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
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

                // top search
                //var observable1 = Observable.FromEventPattern<EventHandler<FunctionEventArgs<string>>, FunctionEventArgs<string>>(
                //            handler => FileSearchBar.SearchStarted += handler,
                //            handler => FileSearchBar.SearchStarted -= handler)
                //    .Select(x => x.EventArgs.Info)
                //    .Subscribe(query =>
                //   {
                //       ViewModel.PerformSearch(query);
                //   });
                //var observable2 = Observable.FromEventPattern<EventHandler<FunctionEventArgs<string>>, FunctionEventArgs<string>>(
                //            handler => OptionsSearchBar.SearchStarted += handler,
                //            handler => OptionsSearchBar.SearchStarted -= handler)
                //    .Select(x => x.EventArgs.Info)
                //    .Subscribe(query =>
                //    {
                //        ViewModel.PerformSearch(query);
                //    });

                this.Bind(ViewModel,
                      viewModel => viewModel.SearchBarText,
                      view => view.FileSearchBar.Text)
                  .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.OptionsSearchBarText,
                        view => view.OptionsSearchBar.Text)
                    .DisposeWith(disposables);

                // left navigation
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.LeftItems,
                        view => view.LeftNavigation.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.LeftSelectedItem,
                        view => view.LeftNavigation.SelectedItem)
                    .DisposeWith(disposables);

                // right file list
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.RightItems,
                        view => view.InnerList.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.RightSelectedItem,
                        view => view.InnerList.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewModel => viewModel.RightSelectedItems,
                      view => view.InnerList.SelectedItems)
                  .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                      viewModel => viewModel.FindUsingCommand,
                      view => view.RightContextMenuFindUsingMenuItem)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.CopyRelPathCommand,
                      view => view.RightContextMenuCopyPathMenuItem)
                  .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                      viewModel => viewModel.OpenFileOnlyCommand,
                      view => view.OpenFileOnly)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.AddSelectedCommand,
                      view => view.AddSelected)
                  .DisposeWith(disposables);
            });

        }

        #region methods

        private static void PreviewMesh(PropertiesViewModel propertiesViewModel, RedFileViewModel selectedItem, IGameFile selectedGameFile)
        {
            //propertiesViewModel.AB_SelectedItem = selectedItem;
            //propertiesViewModel.LoadModel(selectedItem.FullName);
            //propertiesViewModel.AB_MeshPreviewVisible = true;
            //propertiesViewModel.SelectedIndex = 1;


            //using (var meshStream = new MemoryStream())
            //{
            //    selectedGameFile.Extract(meshStream);
            //    propertiesViewModel.LoadModel(meshStream);
            //}

            //var managerCacheDir = ISettingsManager.GetTemp_MeshPath();
            //_ = Directory.CreateDirectory(managerCacheDir);
            //foreach (var f in Directory.GetFiles(managerCacheDir))
            //{
            //    try
            //    {
            //        File.Delete(f);
            //    }
            //    catch
            //    {
            //        // ignored
            //    }
            //}

            //using (var meshStream = new MemoryStream())
            //{
            //    selectedGameFile.Extract(meshStream);
            //    meshStream.Seek(0, SeekOrigin.Begin);
            //    var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileName(selectedItem.Name) ?? throw new InvalidOperationException());
            //    outPath = Path.ChangeExtension(outPath, ".glb");
            //    if (Locator.Current.GetService<MeshTools>().ExportMeshPreviewer(meshStream, new FileInfo(outPath)))
            //    {
            //        propertiesViewModel.LoadModel(outPath);
            //    }
            //    meshStream.Dispose();
            //    meshStream.Close();
            //}
        }

        private static void PreviewWem(PropertiesViewModel propertiesViewModel, IFileSystemViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.IsAudioPreviewVisible = true;
            propertiesViewModel.SelectedIndex = 2;

            var managerCacheDir = ISettingsManager.GetTemp_Audio_importPath();
            _ = Directory.CreateDirectory(managerCacheDir);

            var endPath = Path.Combine(managerCacheDir, Path.GetFileName(selectedItem.Name) ?? throw new InvalidOperationException());
            foreach (var f in Directory.GetFiles(managerCacheDir))
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                    // ignored
                }
            }

            using (var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write))
            {
                selectedGameFile.Extract(fs);
            }

            if (File.Exists(endPath))
            {
                propertiesViewModel.PreviewAudioCommand.SafeExecute(endPath);
            }
        }

        private async void PreviewTexture(PropertiesViewModel propertiesViewModel, RedFileViewModel selectedItem, IGameFile selectedGameFile)
        {
            propertiesViewModel.IsImagePreviewVisible = true;
            propertiesViewModel.SelectedIndex = 3;

            var man = Locator.Current.GetService<IModTools>();

            // extract cr2w to stream
            await using var cr2wstream = new MemoryStream();
            selectedGameFile.Extract(cr2wstream);

            // convert xbm to dds stream
            await using var ddsstream = new MemoryStream();
            var expargs = new XbmExportArgs { Flip = false, UncookExtension = EUncookExtension.tga };
            if (man != null)
            {
                man.ConvertXbmToDdsStream(cr2wstream, ddsstream, out _);
            }

            // try loading it in pfim
            try
            {
                var qa = await ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                if (qa != null)
                {
                    propertiesViewModel.LoadImage(qa);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private bool FilterNodes(object o) => o is RedFileSystemModel data && data.Name.Contains(_currentFolderQuery);

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

            if (e.AddedItems.First() is TreeGridRowInfo { RowData: RedFileSystemModel model })
            {
                vm.RightItems.Clear();
                vm.RightItems.AddRange(model.Directories
                    .Select(h => new RedDirectoryViewModel(h.Value))
                    .OrderBy(_ => Regex.Replace(_.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
                vm.RightItems.AddRange(model.Files
                    .Select(h => new RedFileViewModel(ViewModel.LookupGameFile(h)))
                    .OrderBy(_ => Regex.Replace(_.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
            }
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
            LeftNavigation.ExpandNode(selectedIndex + 1);
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

        private void InnerList_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            var propertiesViewModel = Locator.Current.GetService<PropertiesViewModel>();

            _ = propertiesViewModel.ExecuteSelectFile(vm.RightSelectedItem);

            /*

            if (propertiesViewModel.State is DockState.AutoHidden or DockState.Hidden)
            {
                return;
            }

            var settings = Locator.Current.GetService<ISettingsManager>();

            propertiesViewModel.AB_SelectedItem = vm.RightSelectedItem;

            if (!settings.ShowFilePreview)
            {
                return;
            }

            propertiesViewModel.IsMeshPreviewVisible = false;
            propertiesViewModel.IsAudioPreviewVisible = false;
            propertiesViewModel.IsImagePreviewVisible = false;
            propertiesViewModel.SelectedIndex = 0;

            if (propertiesViewModel.AB_SelectedItem is RedFileViewModel selectedItem)
            {
                var selectedGameFile = selectedItem.GetGameFile();

                if (string.Equals(selectedItem.Extension, ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    PreviewMesh(propertiesViewModel, selectedItem, selectedGameFile);
                }

                if (string.Equals(selectedItem.Extension, ERedExtension.wem.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    PreviewWem(propertiesViewModel, selectedItem, selectedGameFile);
                }

                if (string.Equals(selectedItem.Extension, ERedExtension.xbm.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    PreviewTexture(propertiesViewModel, selectedItem, selectedGameFile);
                }
            }
            */
        }

        private void InnerList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var selectedIndex = LeftNavigation.SelectedIndex;
            LeftNavigation.ExpandNode(selectedIndex + 1);
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
            var selected = InnerList.SelectedItem as RedFileViewModel;

            if (selected != null && !selected.FullName.ToLower().Contains("bk2"))
            {
                return;
            }

            //Extract to Temp dir

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
                    // ignored
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
                new ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                    "test.exe"))
                {

                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            process?.WaitForInputIdle();

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


        #endregion

        private void FileSearchBar_SearchStarted(object sender, FunctionEventArgs<string> e) => ViewModel?.PerformSearch(e.Info);

        private void LeftNavigation_RequestTreeItems(object sender, TreeGridRequestTreeItemsEventArgs args)
        {
            if (args.ParentItem == null)
            {
                args.ChildItems = ViewModel.LeftItems;
            }

            else
            {
                var childFolders = args.ParentItem as RedFileSystemModel;

                if (childFolders is not null)
                {
                    args.ChildItems = childFolders.Directories.Values.OrderBy(x => x.Name).ToList();
                }
            }
        }
    }
}
