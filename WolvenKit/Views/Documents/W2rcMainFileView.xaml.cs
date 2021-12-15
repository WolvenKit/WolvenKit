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
            SetupImagePreview();

            this.WhenAnyValue(x => x.DataContext).Subscribe(x =>
            {
                if (x is W2rcFileViewModel vm)
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
        public ICommand ExportChunkCommand { get; private set; }

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
                        else if (source.CanBeDroppedOn(target))
                        {
                            e.DropPosition = DropPosition.DropAsChild;
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
                    //if (source.CanBeDroppedOn(target))
                    //{
                        //e.Handled = false;
                    //}
                }
            }
        }

        private void SfTreeView_ItemDropped(object sender, TreeViewItemDroppedEventArgs e)
        {
            if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            {
                if (e.TargetNode.Content is ChunkViewModel target)
                {
                    if (source.CanBeDroppedOn(target))
                    {
                        target.Data = source.Data;
                    }
                }
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.TargetNode.Content is ChunkViewModel target)
                {
                    var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                    if (files.Count == 1)
                    {
                        if (dropFileLocation == files[0])
                        {
                            //target.Data = dropFile.Data;
                        }
                    }
                }
            }
        }

        private System.Windows.Point origin;
        private System.Windows.Point start;

        private void SetupImagePreview()
        {
            TransformGroup group = new TransformGroup();


            ScaleTransform xform = new ScaleTransform();
            xform.ScaleY = -1;
            group.Children.Add(xform);

            TranslateTransform tt = new TranslateTransform();
            group.Children.Add(tt);

            //TranslateTransform zoomCenter = new TranslateTransform();
            //group.Children.Add(zoomCenter);

            ImagePreview.SetCurrentValue(RenderTransformProperty, group);

            ImagePreviewCanvas.MouseWheel += ImagePreview_MouseWheel;
            ImagePreviewCanvas.MouseDown += ImagePreview_MouseLeftButtonDown;
            ImagePreviewCanvas.MouseUp += ImagePreview_MouseLeftButtonUp;
            ImagePreviewCanvas.MouseMove += ImagePreview_MouseMove;
        }
        private void ImagePreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left || e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.ReleaseMouseCapture();
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
            }
        }

        private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ImagePreviewCanvas.IsMouseCaptured)
                return;

            TranslateTransform tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
            Vector v = start - e.GetPosition(ImagePreviewCanvas);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;
        }

        private void ImagePreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            start = e.GetPosition(ImagePreviewCanvas);
            if (e.ChangedButton == MouseButton.Left || e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.CaptureMouse();
                TranslateTransform tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                origin = new System.Windows.Point(tt.X, tt.Y);
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void ImagePreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            double zoom = e.Delta > 0 ? 1.2 : (1/1.2);

            var CursorPosCanvas = e.GetPosition(ImagePreviewCanvas);
            pan.X += -(CursorPosCanvas.X - ImagePreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoom - 1.0);
            pan.Y += -(CursorPosCanvas.Y - ImagePreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoom - 1.0);

            transform.ScaleX *= zoom;
            transform.ScaleY *= zoom;

        }

        public void SetRealPixelZoom(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            double zoom = ViewModel.Image.Width / ImagePreview.RenderSize.Width;
            double zoomQuot = zoom / transform.ScaleX;
            //ImagePreview.SetCurrentValue(WidthProperty, ViewModel.Image.Width);
            //ImagePreview.SetCurrentValue(HeightProperty, ViewModel.Image.Height);
            var CursorPosCanvas = start;
            pan.X += -(CursorPosCanvas.X - ImagePreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoomQuot - 1.0);
            pan.Y += -(CursorPosCanvas.Y - ImagePreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoomQuot - 1.0);
            transform.ScaleX = zoom;
            transform.ScaleY = -zoom;
        }

        public void ResetZoomPan(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            transform.ScaleX = 1;
            transform.ScaleY = -1;
            pan.X = 0;
            pan.Y = 0;
        }
    }
}
