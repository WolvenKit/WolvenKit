using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ReactiveUI;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTTextureView : ReactiveUserControl<RDTTextureViewModel>
    {
        public RDTTextureView()
        {
            InitializeComponent();
            SetupImagePreview();

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTTextureViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                    // ViewModel.Render();
                }
            });
        }

        // Image Preview

        private System.Windows.Point origin;
        private System.Windows.Point start;
        private System.Windows.Point end;
        private ScaleTransform _imageScale;

        private void SetupImagePreview()
        {
            var group = new TransformGroup();


            var xform = new ScaleTransform();
            //xform.ScaleY = -1;
            group.Children.Add(xform);

            var tt = new TranslateTransform();
            group.Children.Add(tt);

            //TranslateTransform zoomCenter = new TranslateTransform();
            //group.Children.Add(zoomCenter);

            ImagePreview.SetCurrentValue(RenderTransformProperty, group);

            ImagePreviewCanvas.PreviewMouseWheel += ImagePreview_MouseWheel;
            ImagePreviewCanvas.MouseDown += ImagePreview_MouseLeftButtonDown;
            ImagePreviewCanvas.MouseUp += ImagePreview_MouseLeftButtonUp;
            ImagePreviewCanvas.MouseMove += ImagePreview_MouseMove;

            ImageDropZone.DragEnter += ImageDropZone_DragEnter;
            ImageDropZone.DragLeave += ImageDropZone_DragLeave;
            ImageDropZone.Drop += ImageDropZone_Drop;

            _imageScale = new ScaleTransform();
            //_imageScale.SetCurrentValue(ScaleTransform.ScaleYProperty, (double)-1);
            ActualImage.SetCurrentValue(RenderTransformProperty, _imageScale);
        }

        private void ImageDropZone_DragEnter(object sender, DragEventArgs e) => ViewModel.IsDragging = true;

        private void ImageDropZone_DragLeave(object sender, DragEventArgs e) => ViewModel.IsDragging = false;

        private void ImageDropZone_Drop(object sender, DragEventArgs e)
        {
            ViewModel.IsDragging = false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                if (files.Count == 1)
                {
                    e.Handled = true;
                    try
                    {
                        var image = new BitmapImage(new Uri(files[0]));
                        ViewModel.Image = image;
                        ViewModel.UpdateFromImage();
                    }
                    catch (Exception)
                    {
                        Locator.Current.GetService<ILoggerService>().Warning("Image type not supported");
                    }

                    try
                    {
                        var metadata = ViewModel.Image.Metadata as BitmapMetadata;
                        if (metadata.ContainsQuery("System.Photo.Orientation"))
                        {
                            switch (metadata.GetQuery("System.Photo.Orientation"))
                            {
                                case 4:
                                    _imageScale.SetCurrentValue(ScaleTransform.ScaleYProperty, (double)-1);
                                    break;
                                default:
                                    _imageScale.SetCurrentValue(ScaleTransform.ScaleYProperty, (double)1);
                                    break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        _imageScale.SetCurrentValue(ScaleTransform.ScaleYProperty, (double)1);
                    }
                    ResetZoomPan(null, null);
                }
            }
        }

        private void ImagePreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.ReleaseMouseCapture();
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                end = new System.Windows.Point(tt.X, tt.Y);
            }
        }

        private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ImagePreviewCanvas.IsMouseCaptured)
            {
                return;
            }

            var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
            var v = start - Mouse.GetPosition(ImagePreviewCanvas);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;
        }

        private void ImagePreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            start = Mouse.GetPosition(ImagePreviewCanvas);
            if (e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.CaptureMouse();
                // resets when children are hittble? idk
                var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                origin = end;
                tt.X = origin.X;
                tt.Y = origin.Y;
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void ImagePreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            var zoom = e.Delta > 0 ? 1.2 : (1 / 1.2);

            var CursorPosCanvas = e.GetPosition(ImagePreviewCanvas);
            pan.X += -(CursorPosCanvas.X - ImagePreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoom - 1.0);
            pan.Y += -(CursorPosCanvas.Y - ImagePreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoom - 1.0);
            end.X = pan.X;
            end.Y = pan.Y;

            transform.ScaleX *= zoom;
            transform.ScaleY *= zoom;

        }

        public void SetRealPixelZoom(object sender, RoutedEventArgs e)
        {
            var transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            //double zoom = ViewModel.Image.Width / ImagePreview.RenderSize.Width;
            //double zoomQuot = zoom / transform.ScaleX;
            ////ImagePreview.SetCurrentValue(WidthProperty, ViewModel.Image.Width);
            ////ImagePreview.SetCurrentValue(HeightProperty, ViewModel.Image.Height);
            //var CursorPosCanvas = start;
            //pan.X += -(CursorPosCanvas.X - ImagePreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoomQuot - 1.0);
            //pan.Y += -(CursorPosCanvas.Y - ImagePreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoomQuot - 1.0);
            //transform.ScaleX = zoom;
            //transform.ScaleY = zoom;

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }

        public void ResetZoomPan(object sender, RoutedEventArgs e)
        {
            var transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }
    }
}
