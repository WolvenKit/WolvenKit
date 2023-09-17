using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.UI.Xaml.TreeView.Engine;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for RedTreeView.xaml
    /// </summary>
    public partial class RedTreeView : UserControl
    {
        public RedTreeView()
        {
            InitializeComponent();

            TreeView.ApplyTemplate();
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RedTreeView));

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItem"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(RedTreeView));

        public object SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register(nameof(SelectedItems), typeof(object), typeof(RedTreeView));

        public object SelectedItems
        {
            get => GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        /*

                //
                // Summary:
                //     Identifies the Syncfusion.UI.Xaml.TreeView.SfTreeView.SelectedItems dependency
                //     property.
                public static readonly DependencyProperty SelectedItemsProperty =
                    DependencyProperty.Register(nameof(SelectedItems), typeof(ObservableCollection<object>), typeof(RedTreeView));
                //    , new PropertyMetadata(null, delegate (DependencyObject sender, DependencyPropertyChangedEventArgs args) {(sender as RedTreeView).OnPropertyChanged(args); }));

                //
                // Summary:
                //     Gets or sets the selected items for selection.
                //
                // Value:
                //     The collection of object that contains data item that are selected.
                public ObservableCollection<object> SelectedItems
                {
                    get { return (ObservableCollection<object>)GetValue(SelectedItemsProperty); }
                    set { SetValue(SelectedItemsProperty, value); }
                }


        */

        private void OnSelectionChanged(object sender, Syncfusion.UI.Xaml.TreeView.ItemSelectionChangedEventArgs e)
        {
            foreach (var removedItem in e.RemovedItems)
            {
                if (removedItem is ISelectableTreeViewItemModel selectable)
                {
                    selectable.IsSelected = false;
                }
            }

            foreach (var removedItem in e.AddedItems)
            {
                if (removedItem is ISelectableTreeViewItemModel selectable)
                {
                    selectable.IsSelected = true;
                }
            }
        }

        public async void OnCollapsed(object sender, Syncfusion.UI.Xaml.TreeView.NodeExpandedCollapsedEventArgs e)
        {
            if (e.Node.Level == 0 &&
                e.Node.Content is ChunkViewModel cvm &&
                cvm.ResolvedData is worldStreamingSector)
            {
                var test = Locator.Current.GetService<AppViewModel>();
                var tt = Locator.Current.GetService<AppViewModel>();

                if (tt.ActiveDocument is RedDocumentViewModel rr &&
                    rr.SelectedTabItemViewModel is RDTDataViewModel rdtd)
                {
                    var chunk = rdtd.Chunks.First();
                    try
                    {
                        await chunk.Refresh();
                    }
                    catch (Exception ex) { Locator.Current.GetService<ILoggerService>().Error(ex); }

                }
            }
        }


        // Drag & Drop Functionality

        //private string dropFileLocation;
        //private RedTypeDto dropFile;

        private void SfTreeView_ItemDragStarting(object sender, TreeViewItemDragStartingEventArgs e)
        {
            //var record = e.DraggingNodes[0].Content as ChunkViewModel;
            //if (typeof(CBool).IsAssignableTo(record.Data.GetType()))
            //    e.Cancel = true;
        }

        public bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);


        private bool IsAllowDrop(TreeViewItemDragOverEventArgs e)
        {
            if (e.DraggingNodes?[0].Content is not ChunkViewModel source ||
                e.TargetNode?.Content is not ChunkViewModel target)
            {
                return false;
            }

            if (source == target || source.Data is null || target.Parent == null || target.Parent.IsReadOnly)
            {
                return false;
            }

            switch (IsControlBeingHeld)
            {
                case false when !target.IsInArray:
                case true when target.Parent.Data is IRedBufferPointer:
                    return true;
                case true:
                {
                    if (target.Parent.Data is not IRedArray arr)
                    {
                        return false;
                    }

                    var arrayType = target.Parent.Data.GetType().GetGenericTypeDefinition();

                    return arrayType == typeof(CArray<>) || (arrayType == typeof(CStatic<>) && arr.Count < arr.MaxSize);
                }
                default:
                    return true;
            }
        }

        private void SfTreeView_ItemDragOver(object sender, TreeViewItemDragOverEventArgs e)
        {
            if (sender is not SfTreeView)
            {
                return;
            }

            if (e.DropPosition is DropPosition.DropAsChild or DropPosition.DropHere)
            {
                e.DropPosition = DropPosition.DropBelow;
            }

            e.DropPosition = IsAllowDrop(e) ? e.DropPosition : DropPosition.None;

        }

        private void DragDropInsertNode()
        {
        }

        private async void SfTreeView_ItemDropping(object sender, TreeViewItemDroppingEventArgs e)
        {
            if (e.DraggingNodes == null
                || e.TargetNode.Content is not ChunkViewModel target
                || target.Parent == null
                || (e.DropPosition != DropPosition.DropBelow && e.DropPosition != DropPosition.DropAbove))
            {
                e.Handled = true;
                return;
            }

            var targetIndex = target.Parent.Properties.IndexOf(target);

            foreach (var node in e.DraggingNodes.Where(node => node.Content is ChunkViewModel))
            {
                var source = (ChunkViewModel)node.Content;

                if (IsControlBeingHeld && source.Data is IRedCloneable irc)
                {
                    if (await Interactions.ShowMessageBoxAsync($"Duplicate {source.Data.GetType().Name} here?",
                            "Duplicate Confirmation", WMessageBoxButtons.YesNo) == WMessageBoxResult.Yes)
                    {
                        target.Parent.InsertChild(
                            target.Parent.Properties.IndexOf(target) +
                            (e.DropPosition == DropPosition.DropBelow ? 1 : 0), (IRedType)irc.DeepCopy());
                    }
                }
                else
                {
                    Debug.WriteLine("Moved a node to " + targetIndex);
                    target.Parent.MoveChild(
                        targetIndex + (e.DropPosition == DropPosition.DropBelow ? 1 : 0),
                        source);
                    targetIndex += 1;
                }
            }


            e.Handled = true;
        }

        private void SfTreeView_ItemDropped(object sender, TreeViewItemDroppedEventArgs e)
        {
            //if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            //{
            //    if (e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        if (source.Data is RedBaseClass rbc && target.Parent.Data is DataBuffer)
            //        {
            //            target.Parent.AddChunkToDataBuffer((RedBaseClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
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

        //private void TreeView_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
        //{
        //    e.Height = e.Node.Content.();
        //    e.Handled = true;
        //}
    }
}
