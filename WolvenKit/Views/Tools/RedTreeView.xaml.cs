using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

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
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RedTreeView));

        public object ItemsSource
        {
            get { return (object)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(RedTreeView));

        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
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

        private void SfTreeView_ItemDragOver(object sender, TreeViewItemDragOverEventArgs e)
        {
            var allowDrop = false;
            if (sender is SfTreeView tv)
            {
                if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
                {
                    if (e.TargetNode != null && e.TargetNode.Content is ChunkViewModel target)
                    {
                        if (source == target)
                        {
                            allowDrop = false;
                        }
                        //else if (source.CanBeDroppedOn(target))
                        //{
                        //    e.DropPosition = DropPosition.DropAsChild;
                        //}
                        else if (source.Data is IRedType)
                        {
                            if (IsControlBeingHeld && !target.Parent.IsReadOnly)
                            {
                                if (target.Parent.Data is IRedBufferPointer)
                                {
                                    allowDrop = true;
                                }

                                if (target.Parent.Data is IRedArray arr)
                                {
                                    var arrayType = target.Parent.Data.GetType().GetGenericTypeDefinition();

                                    if (arrayType == typeof(CArray<>))
                                    {
                                        allowDrop = true;
                                    }

                                    if (arrayType == typeof(CStatic<>) && arr.Count < arr.MaxSize)
                                    {
                                        allowDrop = true;
                                    }
                                }
                            }
                            else if (target.IsInArray && !target.Parent.IsReadOnly)
                            {
                                allowDrop = true;
                            }
                        }
                    }
                }
                if (e.DropPosition == DropPosition.DropAsChild || e.DropPosition == DropPosition.DropHere)
                {
                    e.DropPosition = DropPosition.DropBelow;
                }
                e.DropPosition = allowDrop ? e.DropPosition : DropPosition.None;
            }
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    if (e.TargetNode != null && e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            //        if (files.Count == 1)
            //        {
            //            if (dropFileLocation != files[0])
            //            {
            //                try
            //                {
            //                    dropFileLocation = files[0];
            //                    var json = File.ReadAllText(files[0]);
            //                    dropFile = JsonConvert.DeserializeObject<RedTypeDto>(json);
            //                }
            //                catch (Exception)
            //                {

            //                }
            //            }
            //            //if (dropFile != null && dropFile.Type == target.Type)
            //            //{
            //            e.DropPosition = DropPosition.DropAsChild;
            //            //}
            //        }
            //    }
            //}
        }

        private void SfTreeView_ItemDropping(object sender, TreeViewItemDroppingEventArgs e)
        {
            e.Handled = true;
            if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            {
                if (e.TargetNode.Content is ChunkViewModel target && target.Parent != null && (e.DropPosition == DropPosition.DropBelow || e.DropPosition == DropPosition.DropAbove))
                {
                    if (IsControlBeingHeld)
                    {
                        if (source.Data is IRedCloneable irc)
                        {
                            MessageBoxResult messageBoxResult = MessageBox.Show($"Duplicate {source.Data.GetType().Name} here?", "Duplicate Confirmation", MessageBoxButton.YesNo);
                            if (messageBoxResult == MessageBoxResult.Yes)
                            {
                                target.Parent.InsertChild(target.Parent.Properties.IndexOf(target) + (e.DropPosition == DropPosition.DropBelow ? 1 : 0), (IRedType)irc.DeepCopy());
                            }
                        }
                    }
                    else
                    {
                        target.Parent.MoveChild(target.Parent.Properties.IndexOf(target) + (e.DropPosition == DropPosition.DropBelow ? 1 : 0), source);
                    }
                        //if (target.Parent.Data is DataBuffer or SerializationDeferredDataBuffer)
                        //{
                        //    target.Parent.AddChunkToDataBuffer((RedBaseClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
                        //}

                        //if (target.Parent.Data is IRedArray arr)
                        //{
                        //    var arrayType = target.Parent.Data.GetType().GetGenericTypeDefinition();

                        //    if (arrayType == typeof(CArray<>))
                        //    {
                        //        target.Parent.AddClassToArray((RedBaseClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
                        //    }

                        //    if (arrayType == typeof(CStatic<>) && arr.Count < arr.MaxSize)
                        //    {
                        //        target.Parent.AddClassToArray((RedBaseClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
                        //    }
                        //}
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
