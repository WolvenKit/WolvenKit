using System;
using System.Collections.Generic;
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
using ReactiveUI;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for TextureView.xaml
    /// </summary>
    public partial class TextureView : ReactiveUserControl<TextureViewModel>
    {
        public TextureView()
        {
            InitializeComponent();
            SetupImagePreview();
        }

        // Image Preview

        private System.Windows.Point origin;
        private System.Windows.Point start;
        private System.Windows.Point end;

        private void SetupImagePreview()
        {
            TransformGroup group = new TransformGroup();


            ScaleTransform xform = new ScaleTransform();
            //xform.ScaleY = -1;
            group.Children.Add(xform);

            TranslateTransform tt = new TranslateTransform();
            group.Children.Add(tt);

            //TranslateTransform zoomCenter = new TranslateTransform();
            //group.Children.Add(zoomCenter);

            ImagePreview.SetCurrentValue(RenderTransformProperty, group);

            ImagePreviewCanvas.PreviewMouseWheel += ImagePreview_MouseWheel;
            ImagePreviewCanvas.MouseDown += ImagePreview_MouseLeftButtonDown;
            ImagePreviewCanvas.MouseUp += ImagePreview_MouseLeftButtonUp;
            ImagePreviewCanvas.MouseMove += ImagePreview_MouseMove;
        }

        private void ImagePreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.ReleaseMouseCapture();
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                TranslateTransform tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                end = new System.Windows.Point(tt.X, tt.Y);
            }
        }

        private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ImagePreviewCanvas.IsMouseCaptured)
                return;

            TranslateTransform tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
            Vector v = start - Mouse.GetPosition(ImagePreviewCanvas);
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
                TranslateTransform tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                origin = end;
                tt.X = origin.X;
                tt.Y = origin.Y;
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void ImagePreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            double zoom = e.Delta > 0 ? 1.2 : (1 / 1.2);

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
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

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
        }

        public void ResetZoomPan(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            pan.X = 0;
            pan.Y = 0;
        }
    }
}
