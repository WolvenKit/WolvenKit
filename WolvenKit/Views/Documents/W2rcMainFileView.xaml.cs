using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for W2rcMainFileView.xaml
    /// </summary>
    public partial class W2rcMainFileView : ReactiveUserControl<W2rcFileViewModel>
    {
        public W2rcMainFileView()
        {
            InitializeComponent();

            //ViewModel = new MainFileViewModel();
            //DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                if (DataContext is W2rcFileViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                // ChunksTreeView
                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Chunks,
                       view => view.ChunksTreeView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.ChunksTreeView.SelectedItem)
                  .DisposeWith(disposables);

                // ImportsListView
                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Imports,
                       view => view.ImportsListView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedImport,
                      view => view.ImportsListView.SelectedItem)
                  .DisposeWith(disposables);


                // MainTreeGrid
                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.ChunkProperties,
                       view => view.MainTreeGrid.ItemsSource)
                   .DisposeWith(disposables);

                //this.BindCommand(ViewModel,
                //        viewModel => viewModel.InstallModCommand,
                //        view => view.InstallModContextMenuItem)
                //    .DisposeWith(disposables);




            });

            MainTreeGrid.RequestTreeItems += TreeGrid_RequestTreeItems;
        }

        
      
        private void TreeGrid_RequestTreeItems(object sender, TreeGridRequestTreeItemsEventArgs args)
        {
            if (DataContext is W2rcFileViewModel vm)
            {
                if (args.ParentItem == null)
                {
                    args.ChildItems = vm.ChunkProperties;
                }
                else
                {
                    if (args.ParentItem is ChunkPropertyViewModel chunk)
                    {
                        args.ChildItems = chunk.Children;
                    }
                }
            }
           
               

            //else
            //{
            //    EmployeeInfo employee = args.ParentItem as EmployeeInfo;

            //    if (employee != null)
            //    {
            //        args.ChildItems = ViewModel.GetEmployees().Where(x => x.ReportsTo == employee.ID);
            //    }
            //}
        }

        private void SetCollapsedAll()
        {
            ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        }

        private void HandleTemplateView_OnGoToChunkRequested(object sender, GoToChunkRequestedEventArgs e)
        {
            var target = e.Export;

            if (ViewModel == null || target == null)
            {
                return;
            }

            var chunk = ViewModel.Chunks.FirstOrDefault(x => x.Name.Equals(target.REDName));
            chunk.IsSelected = true;
            ViewModel.SelectedChunk = chunk;
        }

        private void CurveEditorButton_OnClick(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            if (tag is ICurveDataAccessor redcurve)
            {
                var curveEditorWindow = new CurveEditorWindow(redcurve);
                var r = curveEditorWindow.ShowDialog();
                if (r ?? true)
                {
                    var c = curveEditorWindow.GetCurve();
                    if (c is not null)
                    {
                        // set tag data
                        redcurve.SetInterpolationType(c.Type);
                        redcurve.SetCurvePoints(c.Points);
                    }
                }
            }
        }

        private void ChunksButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void ImportsButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }
    }
}
