using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView : ReactiveUserControl<ProjectExplorerViewModel>
    {
        #region Constructors

        public ProjectExplorerView()
        {
            InitializeComponent();
            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
            TreeGridFlat.ItemsSourceChanged += TreeGridFlat_ItemsSourceChanged;
            TreeGrid.RowDragDropController.DragStart += RowDragDropController_DragStart;
            TreeGrid.RowDragDropController.DragOver += RowDragDropController_DragOver;
            TreeGrid.RowDragDropController.DragLeave += RowDragDropController_DragLeave;
            TreeGrid.RowDragDropController.Drop += RowDragDropController_Drop;
            TreeGrid.RowDragDropController.Dropped += RowDragDropController_Dropped;
            TreeGrid.RowDragDropController.CanAutoExpand = true;

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            ViewModel = Locator.Current.GetService<ProjectExplorerViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                Interactions.DeleteFiles.RegisterHandler(
                    interaction =>
                    {
                        var count = interaction.Input.Count();

                        var result = AdonisUI.Controls.MessageBox.Show(
                        "The selected item(s) will be moved to the Recycle Bin.",
                        "WolvenKit",
                        AdonisUI.Controls.MessageBoxButton.OKCancel,
                        AdonisUI.Controls.MessageBoxImage.Information,
                        AdonisUI.Controls.MessageBoxResult.OK);
                        if (result == AdonisUI.Controls.MessageBoxResult.OK)
                        {
                            interaction.SetOutput(true);
                        }
                        else
                        {
                            interaction.SetOutput(false);
                        }

                    });
                Interactions.Rename.RegisterHandler(
                    interaction =>
                    {
                        var dialog = new DialogHostView();
                        var vm = Locator.Current.GetService<RenameDialogViewModel>();
                        vm.Text = interaction.Input;
                        dialog.ViewModel.HostedViewModel = vm;


                        return Observable.Start(() =>
                        {
                            var result = "";
                            dialog.Owner = Application.Current.MainWindow;
                            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                            if (dialog.ShowDialog() == true)
                            {
                                var innerVm = (RenameDialogViewModel)dialog.ViewModel.HostedViewModel;

                                result = innerVm.Text;
                            }

                            interaction.SetOutput(result);
                        }, RxApp.MainThreadScheduler);
                    });

                ViewModel.ExpandAll.Subscribe(x => ExpandAll());
                ViewModel.CollapseAll.Subscribe(x => CollapseAll());
                ViewModel.ExpandChildren.Subscribe(x => ExpandChildren());
                ViewModel.CollapseChildren.Subscribe(x => CollapseChildren());

                //EventBindings
                Observable
                    .FromEventPattern(TreeGrid, nameof(TreeGrid.CellDoubleTapped))
                    .Subscribe(_ => OnCellDoubleTapped(_.Sender, _.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                Observable
                    .FromEventPattern(TreeGridFlat, nameof(TreeGridFlat.CellDoubleTapped))
                    .Subscribe(_ => OnCellDoubleTapped(_.Sender, _.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.BindGrid1,
                        view => view.TreeGrid.ItemsSource)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.BindGrid1,
                        view => view.TreeGridFlat.ItemsSource)
                    .DisposeWith(disposables);

                //ViewModel.WhenAnyValue(x => x.IsFlatModeEnabled).Subscribe(x => UpdateTreeGrid());

                this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenRootFolderCommand,
                    view => view.OpenFolderButton);

            });

        }

        private void OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs treeGridCellDoubleTappedEventArgs)
        {
            var model = treeGridCellDoubleTappedEventArgs.Node.Item;
            ViewModel.OpenFileCommand.Execute(model);
        }

        private bool _isfirsttime { get; set; } = true;

        private void TreeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }
            if (TreeGrid == null)
            { return; }
            if (TreeGrid.View != null)
            {
                TreeGrid.View.Filter = IsFileIn;
                TreeGrid.View.RefreshFilter();
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        TreeGrid.ExpandAllNodes();
                        var rowIndex = TreeGrid.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGrid.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = TreeGrid.ResolveToStartColumnIndex();
                            TreeGrid.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGrid.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

        private void TreeGridFlat_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }
            if (TreeGridFlat == null)
            { return; }
            if (TreeGridFlat.View != null)
            {
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGridFlat.View.RefreshFilter();
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        var rowIndex = TreeGridFlat.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGridFlat.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = TreeGridFlat.ResolveToStartColumnIndex();
                            TreeGridFlat.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGridFlat.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

        private bool IsFileIn(object o)
        {
            var includeFile = false;
            if (tabControl != null && o is FileModel fm)
            {
                includeFile = true;
                if (tabControl.SelectedIndex == 0)
                {
                    includeFile &= fm.FullName.StartsWith((fm.Project as Cp77Project).FileDirectory);
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    includeFile &= fm.FullName.StartsWith((fm.Project as Cp77Project).ModDirectory);
                }
                else if (tabControl.SelectedIndex == 2)
                {
                    includeFile &= fm.FullName.ToLower().StartsWith((fm.Project as Cp77Project).RawDirectory.ToLower());
                }
                else if (tabControl.SelectedIndex == 3)
                {
                    includeFile &= fm.FullName.StartsWith((fm.Project as Cp77Project).ScriptDirectory);
                }
                else if (tabControl.SelectedIndex == 4)
                {
                    includeFile &= fm.FullName.StartsWith((fm.Project as Cp77Project).TweakDirectory);
                }
                else if (tabControl.SelectedIndex == 5)
                {
                    includeFile &= fm.FullName.StartsWith((fm.Project as Cp77Project).PackedRootDirectory);
                }

                //if (ViewModel != null && ViewModel.IsFlatModeEnabled)
                //    includeFile &= !fm.IsDirectory;

            }
            return includeFile;
        }

        private bool IsFileInFlat(object o) => tabControl != null && o is FileModel fm && IsFileIn(o) && !fm.IsDirectory;

        private void UpdateTreeGrid()
        {
            //if (ViewModel != null && TreeGrid != null)
            //{
            //    if (ViewModel.IsFlatModeEnabled)
            //    {
            //        TreeGrid.SetCurrentValue(SfTreeGrid.ChildPropertyNameProperty, null);
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowSortingProperty, true);
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowDropProperty, false);
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowDraggingRowsProperty, false);
            //    }
            //    else
            //    {
            //        TreeGrid.SetCurrentValue(SfTreeGrid.ChildPropertyNameProperty, "ParentHash");
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowSortingProperty, false);
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowDropProperty, true);
            //        //TreeGrid.SetCurrentValue(SfTreeGrid.AllowDraggingRowsProperty, true);
            //    }
            //    TreeGrid.RepopulateTree();
            //    TreeGrid.View.RefreshFilter();
            //}
        }

        private void tabControl_SelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (TreeGrid != null && TreeGrid.View != null)
            {
                TreeGrid.View.Filter = IsFileIn;
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGrid.View.RefreshFilter();
                TreeGridFlat.View.RefreshFilter();
            }
        }

#pragma warning disable 1998


        private async Task<bool> DisplayModSortDialog(IEnumerable<string> input) => false;//var inputDialog = new PackageResolverView(new PackageResolverViewModel(input))//{//    Owner = Application.Current.MainWindow//};//this.Overlay.Opacity = 0.5;//this.Overlay.Background = new SolidColorBrush(Colors.White);//var output = new Dictionary<string, string>();//if (inputDialog.ShowDialog() == true)//{//    output = inputDialog.GetOutput().ToDictionary(_ => _.Name, _ => _.ComputedFullName);//}//this.Overlay.Opacity = 1;//this.Overlay.Background = new SolidColorBrush(Colors.Transparent);//return new ZipModifyArgs(output);//var visualizerService = ServiceLocator.Default.ResolveType<IUIVisualizerService>();//var viewModel = new InputDialogViewModel() { Text = SelectedItem.Name };//await visualizerService.ShowDialogAsync(viewModel, delegate (object sender, UICompletedEventArgs args)//{//    if (args.Result != true)//    {//        return;//    }//    if (args.DataContext is not Dialogs.InputDialogViewModel vm)//    {//        return;//    }//    finally//    {//        SelectedItem.RaiseRequestRefresh();//    }//});

        //private void View_NodeCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    Trace.WriteLine("hello");
        //    //if (e.NewItems != null)
        //    //{
        //    //    foreach (var nerd in e.NewItems)
        //    //    {
        //    //        Trace.WriteLine(nerd.ToString());
        //    //        TreeGrid.ExpandNode((TreeNode)nerd);
        //    //    }
        //    //}

        //    if (ViewModel is not ProjectExplorerViewModel viewModel)
        //    {
        //        return;
        //    }

        //    //var rootnodes = TreeGrid.View.Nodes.RootNodes;
        //    //foreach (var rootnode in rootnodes)
        //    //{
        //    //    TreeGrid.ExpandNode(rootnode);
        //    //}

        //    Trace.WriteLine(e.Action.ToString());
        //}

        //protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        //{
        //    if (ViewModel is not ProjectExplorerViewModel viewModel)
        //    {
        //        return;
        //    }

        //    var name = e.PropertyName;
        //    switch (name)
        //    {
        //        case nameof(viewModel.IsTreeBeingEdited):
        //            if (viewModel.IsTreeBeingEdited)
        //            {
        //                TreeGrid.View.BeginInit(TreeViewRefreshMode.DeferRefresh);
        //            }
        //            else
        //            {
        //                TreeGrid.View.EndInit();
        //            }
        //            break;
        //    }
        //}

        #endregion Constructors

        public void ExpandChildren()
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.ExpandAllNodes(node);
        }

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e) => ExpandChildren();

        public void CollapseChildren()
        {
            if (ViewModel is not { } viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.CollapseAllNodes(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e) => CollapseChildren();

        public void ExpandAll() => TreeGrid.ExpandAllNodes();

        public void CollapseAll() => TreeGrid.CollapseAllNodes();

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAll();

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAll();

        private string _currentFolderQuery = "";

        private bool FilterNodes(object o) => o is FileModel data && data.Name.Contains(_currentFolderQuery);

        private void PESearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            // expand all
            TreeGrid.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatially
            TreeGrid.View.Filter = FilterNodes;
            TreeGrid.View.RefreshFilter();
        }

        private void RowDragDropController_DragStart(object sender, TreeGridRowDragStartEventArgs e)
        {

        }
        private void RowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (e.Data.GetDataPresent("Nodes"))
            {
                if (e.Data.GetData("Nodes") is ObservableCollection<TreeNode> treeNodes && treeNodes[0].Item is FileModel sourceFile)
                {
                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        if (targetFile == sourceFile)
                        {
                            e.ShowDragUI = false;
                            e.Handled = true;
                        }
                        else
                        {
                            e.ShowDragUI = true;
                            e.Handled = false;
                        }
                    }
                }
            }
        }

        private void RowDragDropController_DragLeave(object sender, TreeGridRowDragLeaveEventArgs e)
        {

        }
        private void RowDragDropController_Drop(object sender, TreeGridRowDropEventArgs e)
        {
            e.Handled = true;
            // this should all be somewhere else, right?
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        var targetDirectory = Path.GetDirectoryName(targetFile.FullName);
                        if (File.GetAttributes(targetFile.FullName).HasFlag(FileAttributes.Directory))
                        {
                            targetDirectory = targetFile.FullName;
                        }
                        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                        ProcessFileAction(files, targetDirectory, true);
                    }
                }
                else if (e.Data.GetDataPresent("Nodes"))
                {
                    var treeNodes = e.Data.GetData("Nodes") as ObservableCollection<TreeNode>;

                    if (treeNodes.Count == 0 || treeNodes == null)
                    {
                        return;
                    }

                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        var targetDirectory = Path.GetDirectoryName(targetFile.FullName);
                        if (File.GetAttributes(targetFile.FullName).HasFlag(FileAttributes.Directory))
                        {
                            targetDirectory = targetFile.FullName;
                        }
                        var files = new List<string>();
                        foreach (var node in treeNodes)
                        {
                            if (node.Item is FileModel sourceFile)
                            {
                                files.Add(sourceFile.FullName);
                            }
                        }
                        ProcessFileAction(files, targetDirectory, false);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e)
        {

        }

        public bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

        private void ProcessFileAction(List<string> sourceFiles, string targetDirectory, bool onlyCopy)
        {
            foreach (var sourceFile in sourceFiles)
            {
                var newFile = Path.Combine(targetDirectory, Path.GetFileName(sourceFile));
                if (File.GetAttributes(sourceFile).HasFlag(FileAttributes.Directory))
                {
                    foreach (var dirPath in Directory.GetDirectories(sourceFile, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(sourceFile, newFile));
                    }

                    foreach (var newPath in Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(sourceFile, newFile), true);
                    }
                }
                else
                {
                    if (sourceFile == newFile)
                    {
                        return;
                    }

                    if (File.Exists(newFile) && MessageBox.Show("File already exists at that location - overwrite it?", "File Overwrite Confirmation", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                    {
                        return;
                    }
                    if (IsControlBeingHeld || onlyCopy)
                    {
                        File.Copy(sourceFile, newFile, true);
                    }
                    else
                    {
                        File.Move(sourceFile, newFile, true);
                    }
                }
            }
        }

        private void TreeGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!StaticReferences.AllowVideoPreview)
            {
                return;
            }

            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                var dg = sender as SfTreeGrid;
                if (dg.SelectedItem == null)
                {
                    return;
                }
                var selected = dg.SelectedItem as FileModel;

                if (!selected.FullName.ToLower().Contains("bk2"))
                {
                    return;
                }

                var args = $"\"{selected.FullName}\" /I102 /p";
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
        }
    }
}
