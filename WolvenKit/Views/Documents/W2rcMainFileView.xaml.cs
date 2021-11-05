using System;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Converters;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Documents;
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
                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.ChunkProperties,
                //       view => view.MainTreeGrid.ItemsSource)
                //   .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.SelectedChunk.Data,
                       view => view.PropertyGrid.SelectedObject)
                   .DisposeWith(disposables);

            });


            //PropertyGrid.CustomEditorCollection = CustomEditorCollection;
            //MainTreeGrid.RequestTreeItems += TreeGrid_RequestTreeItems;
        }

        //private void TreeGrid_RequestTreeItems(object sender, TreeGridRequestTreeItemsEventArgs args)
        //{
        //    if (DataContext is W2rcFileViewModel vm)
        //    {
        //        if (args.ParentItem == null)
        //        {
        //            args.ChildItems = vm.ChunkProperties;
        //        }
        //        else
        //        {
        //            if (args.ParentItem is ChunkPropertyViewModel chunk)
        //            {
        //                args.ChildItems = chunk.Children;
        //            }
        //        }
        //    }

        //    //else
        //    //{
        //    //    EmployeeInfo employee = args.ParentItem as EmployeeInfo;

        //    //    if (employee != null)
        //    //    {
        //    //        args.ChildItems = ViewModel.GetEmployees().Where(x => x.ReportsTo == employee.ID);
        //    //    }
        //    //}
        //}

        //private void HandleTemplateView_OnGoToChunkRequested(object sender, GoToChunkRequestedEventArgs e)
        //{
        //    var target = e.Export;

        //    if (ViewModel == null || target == null)
        //    {
        //        return;
        //    }

        //    var chunk = ViewModel.Chunks.FirstOrDefault(x => x.Name.Equals(target.REDName));
        //    chunk.IsSelected = true;
        //    ViewModel.SelectedChunk = chunk;
        //}

        private void SetCollapsedAll()
        {
            ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
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







        private void PropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            if (e.OriginalSource is PropertyItem { } propertyItem)
            {
                var customEditor = PropertyGridEditors.GetPropertyEditor(propertyItem.PropertyType);
                if (customEditor is not null)
                {
                    propertyItem.Editor = customEditor;
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
            }
        }

        private void PropertyGrid_CollectionEditorOpening(object sender, CollectionEditorOpeningEventArgs e)
        {
            //Restrict collection editor window opening
            e.Cancel = true;

            if (sender is PropertyGrid pg)
            {
                var selectedProperty = pg.SelectedPropertyItem;
                var prop = selectedProperty.Value;

                if (prop is IREDArray editableVariable)
                {
                    // open custom collection editor
                    var collectionEditor = new RedCollectionEditor(editableVariable);
                    var r = collectionEditor.ShowDialog();
                    if (r ?? true)
                    {
                        //TODO
                    }
                }
                else
                {
                    throw new ArgumentException(nameof(editableVariable));
                }
            }
        }
    }
}
