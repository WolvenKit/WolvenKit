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
using System.Reactive.Linq;

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

            //this.WhenAnyValue(x => x.DataContext).Subscribe(x =>
            //{
            //    if (x is RDTDataViewModel vm)
            //    {
            //        SetCurrentValue(ViewModelProperty, vm);
            //    }
            //});

            this.WhenActivated(disposables =>
            {

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Chunks,
                       view => view.TreeView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.TreeView.SelectedItem)
                  .DisposeWith(disposables);

                ViewModel.SelectedChunk = ViewModel.Chunks[0];

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.PropertyGridData,
                //       view => view.PropertyGrid.SelectedObject)
                //   .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.PropertyGridItems,
                //       view => view.PropertyGrid.Items)
                //   .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk,
                //       view => view.CustomPG.DataContext)
                //   .DisposeWith(disposables);

                //this.ViewModel.WhenAnyValue(x => x.SelectedChunk)
                //    .Where(x => x != null)
                //    .Select(x => new ObservableCollection<PropertyGridItem>(x.Properties
                //        .Where(x => x != null)
                //        .Select(x => new PropertyGridItem()
                //        {
                //            PropertyName = x.Name,
                //            Editor = PropertyGridEditors.GetPropertyEditor(x.PropertyType)
                //        }
                //    ))).BindTo(PropertyGrid, x => x.Items);

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
