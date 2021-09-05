using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using HandyControl.Data;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.ViewModels.Tools;

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

            ViewModel = Locator.Current.GetService<ProjectExplorerViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                Interactions.DeleteFiles.RegisterHandler(
                    interaction =>
                    {
                        var count = interaction.Input.Count();

                        var result = AdonisUI.Controls.MessageBox.Show(
                        "The selected items will be deleted permanently.",
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

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.BindGrid1,
                        view => view.TreeGrid.ItemsSource)
                    .DisposeWith(disposables);


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
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        TreeGrid.ExpandAllNodes();
                        var rowIndex = this.TreeGrid.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGrid.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = this.TreeGrid.ResolveToStartColumnIndex();
                            this.TreeGrid.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGrid.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

#pragma warning disable 1998


        private async Task<bool> DisplayModSortDialog(IEnumerable<string> input)
#pragma warning restore 1998
        {

            return false;


            //var inputDialog = new PackageResolverView(new PackageResolverViewModel(input))
            //{
            //    Owner = Application.Current.MainWindow
            //};
            //this.Overlay.Opacity = 0.5;
            //this.Overlay.Background = new SolidColorBrush(Colors.White);

            //var output = new Dictionary<string, string>();
            //if (inputDialog.ShowDialog() == true)
            //{
            //    output = inputDialog.GetOutput().ToDictionary(_ => _.Name, _ => _.ComputedFullName);
            //}

            //this.Overlay.Opacity = 1;
            //this.Overlay.Background = new SolidColorBrush(Colors.Transparent);

            //return new ZipModifyArgs(output);


            //var visualizerService = ServiceLocator.Default.ResolveType<IUIVisualizerService>();
            //var viewModel = new InputDialogViewModel() { Text = SelectedItem.Name };
            //await visualizerService.ShowDialogAsync(viewModel, delegate (object sender, UICompletedEventArgs args)
            //{
            //    if (args.Result != true)
            //    {
            //        return;
            //    }

            //    if (args.DataContext is not Dialogs.InputDialogViewModel vm)
            //    {
            //        return;
            //    }



            //    finally
            //    {
            //        SelectedItem.RaiseRequestRefresh();
            //    }
            //});

        }

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

        private void TreeGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!StaticReferences.AllowVideoPreview)
            {
                return;
            }

            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                SfTreeGrid dg = sender as SfTreeGrid;
                if (dg.SelectedItem == null)
                {
                    return;
                }
                var selected = dg.SelectedItem as FileModel;

                if (!selected.FullName.ToLower().Contains("bk2"))
                {
                    return;
                }

                var args = $"\"{ selected.FullName}\" /I102 /p";
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
