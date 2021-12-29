using System;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Converters;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using WolvenKit.Views.Templates;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.ViewModels.Shell;
using System.Windows.Input;
using System.Windows.Media;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using WolvenKit.Common.Conversion;
using static WolvenKit.ViewModels.Shell.ChunkViewModel;
using Syncfusion.Windows.Shared;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTDataView.xaml
    /// </summary>
    public partial class RDTDataView : ReactiveUserControl<RDTDataViewModel>
    {
        public RDTDataView()
        {
            InitializeComponent();

            PropertyGrid.Loaded += PropertyGrid_Loaded;

            this.WhenAnyValue(x => x.DataContext).Subscribe(x =>
            {
                if (x is RDTDataViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });

            this.WhenActivated(disposables =>
            {
                // ChunksTreeView
                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.Chunks,
                //       view => view.ChunksTreeView.ItemsSource)
                //   .DisposeWith(disposables);
                //this.Bind(ViewModel,
                //      viewmodel => viewmodel.SelectedChunk,
                //      view => view.ChunksTreeView.SelectedItem)
                //  .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Chunks,
                       view => view.TreeView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.TreeView.SelectedItem)
                  .DisposeWith(disposables);

                // ImportsListView
                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.Imports,
                //       view => view.ImportsListView.ItemsSource)
                //   .DisposeWith(disposables);
                //this.Bind(ViewModel,
                //      viewmodel => viewmodel.SelectedImport,
                //      view => view.ImportsListView.SelectedItem)
                //  .DisposeWith(disposables);


                // MainTreeGrid
                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.ChunkProperties,
                //       view => view.MainTreeGrid.ItemsSource)
                //   .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.SelectedChunk.PropertyGridData,
                       view => view.PropertyGrid.SelectedObject)
                   .DisposeWith(disposables);

                //this.BindCommand(ViewModel, vm => vm.ExportChunkCommand, v => v.ExportChunkCommand)
                //    .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.Name,
                //       view => view.PropertyGrid.SelectedPropertyItem.DisplayName)
                //   .DisposeWith(disposables);

            });


            //PropertyGrid.CustomEditorCollection = CustomEditorCollection;
            //MainTreeGrid.RequestTreeItems += TreeGrid_RequestTreeItems;
        }
        //public ICommand AddItemToArrayCommand { get; private set; }
        //public ICommand ExportChunkCommand { get; private set; }

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

        //private void SetCollapsedAll()
        //{
        //    ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        //    ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        //}





        //private void ChunksButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SetCollapsedAll();
        //    ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        //}

        //private void ImportsButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SetCollapsedAll();
        //    ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        //}







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
                else
                {
                    propertyItem.Editor = new PropertyGridEditors.BaseTypeEditor();
                    e.ExpandMode = PropertyExpandModes.NestedMode;
                }
                var viewData = ViewModel.SelectedChunk.PropertyGridData;
                if (e.DisplayName == "Value" && viewData.GetType().IsGenericType && viewData.GetType().GetGenericTypeDefinition() == typeof(RedArrayItem<>))
                {
                    if (ViewModel.SelectedChunk.Parent.Data is IRedArray ary)
                    {
                        //e.DisplayName = $"[{ary.IndexOf(ViewModel.SelectedChunk.Data)}] {ViewModel.SelectedChunk.Type}";
                        e.DisplayName = $"{ViewModel.SelectedChunk.Parent.Name} [{ary.IndexOf(ViewModel.SelectedChunk.Data)}]";
                    }
                }
                if (e.DisplayName == "Value" && viewData.GetType().IsGenericType && viewData.GetType().GetGenericTypeDefinition() == typeof(RedClassProperty<>))
                {
                    if (ViewModel.SelectedChunk.Parent.Data is IRedClass cls)
                    {
                        //e.DisplayName = $"[{ary.IndexOf(ViewModel.SelectedChunk.Data)}] {ViewModel.SelectedChunk.Type}";
                        //e.DisplayName = $"{ViewModel.SelectedChunk.Name} ({ViewModel.SelectedChunk.Type})";
                        e.DisplayName = ViewModel.SelectedChunk.Name;
                    }
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

                if (prop is IRedArray editableVariable)
                {
                    // open custom collection editor
                    var collectionEditor = new RedCollectionEditor(editableVariable);
                    var r = collectionEditor.ShowDialog();
                    if (r ?? true)
                    {
                        //TODO
                        throw new Exception("TODO");
                    }
                }
                else
                {
                    throw new ArgumentException(nameof(editableVariable));
                }
            }
        }

        // Drag & Drop Functionality

        private string dropFileLocation;
        private RedClassDto dropFile;

        private void SfTreeView_ItemDragStarting(object sender, TreeViewItemDragStartingEventArgs e)
        {
            //var record = e.DraggingNodes[0].Content as ChunkViewModel;
            //if (typeof(CBool).IsAssignableTo(record.Data.GetType()))
            //    e.Cancel = true;
        }

        private void SfTreeView_ItemDragOver(object sender, TreeViewItemDragOverEventArgs e)
        {
            e.DropPosition = DropPosition.None;
            if (sender is SfTreeView tv)
            {
                if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
                {
                    if (e.TargetNode.Content is ChunkViewModel target)
                    {
                        if (source == target)
                        {
                            e.DropPosition = DropPosition.DropAsChild;
                        }
                        //else if (source.CanBeDroppedOn(target))
                        //{
                        //    e.DropPosition = DropPosition.DropAsChild;
                        //}
                        else if (source.Data is RedBaseClass rbc && target.Parent.Data is DataBuffer db)
                        {
                            e.DropPosition = DropPosition.DropBelow;
                        }
                    }
                }
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.TargetNode != null && e.TargetNode.Content is ChunkViewModel target)
                { 
                    var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                    if (files.Count == 1)
                    {
                        if (dropFileLocation != files[0])
                        {
                            dropFileLocation = files[0];
                            var json = File.ReadAllText(files[0]);
                            dropFile = JsonConvert.DeserializeObject<RedClassDto>(json);
                        }
                        //if (dropFile != null && dropFile.Type == target.Type)
                        //{
                            e.DropPosition = DropPosition.DropAsChild;
                        //}
                    }
                }
            }
        }

        private void SfTreeView_ItemDropping(object sender, TreeViewItemDroppingEventArgs e)
        {
            e.Handled = true;
            if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            {
                if (e.TargetNode.Content is ChunkViewModel target)
                {
                    if (source.Data is RedBaseClass rbc && target.Parent.Data is DataBuffer)
                    {
                        target.Parent.AddChunkToDataBuffer((IRedClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
                    }
                }
            }
        }

        private void SfTreeView_ItemDropped(object sender, TreeViewItemDroppedEventArgs e)
        {
            //if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            //{
            //    if (e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        if (source.Data is RedBaseClass rbc && target.Parent.Data is DataBuffer)
            //        {
            //            target.Parent.AddChunkToDataBuffer((IRedClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
            //        }
            //    }
            //}

            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    if (e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            //        if (files.Count == 1)
            //        {
            //            if (dropFileLocation == files[0])
            //            {
            //                //target.Data = dropFile.Data;
            //            }
            //        }
            //    }
            //}
        }

        private void PropertyGrid_SelectedObjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private void PropertyGrid_Loaded(object sender, RoutedEventArgs e)
        {
            PropertyView item1 = VisualUtils.FindDescendant(this, typeof(PropertyView)) as PropertyView;

            if (item1 != null)
                item1.ItemContainerGenerator.StatusChanged += ItemContainerGenerator_StatusChanged;
        }

        void ItemContainerGenerator_StatusChanged(object sender, EventArgs e)
        {
            if (sender is ItemContainerGenerator icg)
            {
                foreach (var item in icg.Items)
                {
                    var pi = (PropertyItem)item;
                }
            }
        }

        private void PropertyGrid_ValueChanged(object sender, ValueChangedEventArgs args)
        {
            ViewModel.File.SetIsDirty(true);
        }

        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is Grid g && g.DataContext is ChunkViewModel cvm)
            {
                if (cvm.Value != "null")
                {
                    e.CanExecute = true;
                    e.Handled = true;
                }
            }
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Grid g && g.DataContext is ChunkViewModel cvm)
            {
                Clipboard.SetText(cvm.Value);
            }
        }
    }
}
