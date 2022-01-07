using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
using ReactiveUI;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTWidgetView.xaml
    /// </summary>
    public partial class RDTWidgetView : ReactiveUserControl<RDTWidgetViewModel>
    {
        public RDTWidgetView()
        {
            InitializeComponent();
            SetupWidgetPreview();

            this.WhenActivated(disposables =>
            {
                this.ViewModel.WhenAnyValue(x => x.library).Subscribe(library =>
                {
                    var item = library.LibraryItems.FirstOrDefault();
                    if (item == null)
                        return;

                    if (item.PackageData == null || item.PackageData.Data is not Package04 pkg)
                    {
                        item.Package.Buffer.Decompress();
                        if (item.Package.Data is not Package04 pkg2)
                            return;
                        pkg = pkg2;
                    }

                    if (pkg.RootChunk is not inkWidgetLibraryItemInstance inst)
                        return;

                    if (inst.RootWidget.GetValue() is not inkCanvasWidget root)
                        return;

                    RenderWidget(WidgetPreview, root);
                });
            });
        }

        // Image Preview

        private System.Windows.Point origin;
        private System.Windows.Point start;
        private System.Windows.Point end;

        private void SetupWidgetPreview()
        {
            TransformGroup group = new TransformGroup();


            ScaleTransform xform = new ScaleTransform();
            //xform.ScaleY = -1;
            group.Children.Add(xform);

            TranslateTransform tt = new TranslateTransform();
            group.Children.Add(tt);

            //TranslateTransform zoomCenter = new TranslateTransform();
            //group.Children.Add(zoomCenter);

            WidgetPreview.SetCurrentValue(RenderTransformProperty, group);

            WidgetPreviewCanvas.PreviewMouseWheel += WidgetPreview_MouseWheel;
            WidgetPreviewCanvas.MouseDown += WidgetPreview_MouseLeftButtonDown;
            WidgetPreviewCanvas.MouseUp += WidgetPreview_MouseLeftButtonUp;
            WidgetPreviewCanvas.MouseMove += WidgetPreview_MouseMove;
        }

        private System.Windows.Media.Color ColorFromHDRColor(HDRColor hdr)
        {
            return System.Windows.Media.Color.FromArgb((byte)(hdr.Alpha * 255), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
        }

        private System.Windows.Point PointFromVector2(Vector2 v)
        {
            return new System.Windows.Point(v.X, v.Y);
        }

        private void RenderWidget(Canvas parent, inkWidget widget)
        {
            FrameworkElement element = new Canvas();

            if (widget is inkCanvasWidget)
            {
                var canvas = new Canvas();
                element = canvas;
            }

            if (widget is inkCompoundWidget comp && comp.Children != null && comp.Children.GetValue() is inkMultiChildren imc)
            {
                var canvas = new Canvas();
                foreach (var child in imc.Children)
                {
                    RenderWidget(canvas, child);
                }
                element = canvas;
            }

            if (widget is inkTextWidget textWidget)
            {
                var text = new TextBlock();
                text.Text = textWidget.Text;
                text.FontSize = textWidget.FontSize;
                text.Foreground = new SolidColorBrush(ColorFromHDRColor(widget.TintColor));
                if (textWidget.TextHorizontalAlignment.ToEnumString() == "Center")
                    text.HorizontalAlignment = HorizontalAlignment.Center;
                element = text;

            }

            if (widget is inkImageWidget imageWidget && imageWidget.TextureAtlas != null)
            {
                var atlasPath = imageWidget.TextureAtlas.DepotPath.GetValue();
                if (ViewModel.AtlasParts.ContainsKey(atlasPath))
                {
                    var grid = new Grid();
                    grid.Background = new SolidColorBrush(ColorFromHDRColor(widget.TintColor));

                    var imageSource = ViewModel.AtlasParts[atlasPath][imageWidget.TexturePart];
                    Bitmap bitmap;
                    using (var outStream = new MemoryStream())
                    {
                        BitmapEncoder enc = new BmpBitmapEncoder();
                        enc.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
                        enc.Save(outStream);
                        bitmap = new Bitmap(outStream);
                    }

                    bitmap.MakeTransparent(System.Drawing.Color.Black);

                    var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        bitmap.GetHbitmap(),
                        IntPtr.Zero,
                        Int32Rect.Empty,
                        BitmapSizeOptions.FromEmptyOptions());

                    var imagebrush = new ImageBrush();
                    imagebrush.ImageSource = bitmapSource;
                    grid.OpacityMask = imagebrush;
                    element = grid;
                }
            }

            if (widget is inkRectangleWidget rectangleWidget)
            {
                var rectangle = new Grid();
                rectangle.Background = new SolidColorBrush(ColorFromHDRColor(widget.TintColor));
                element = rectangle;
            }

            element.Width = widget.Size.X;
            element.Height = widget.Size.Y;

            element.Opacity = widget.Opacity;

            element.RenderTransformOrigin = PointFromVector2(widget.RenderTransformPivot);
            element.RenderTransform = new ScaleTransform(widget.RenderTransform.Scale.X, widget.RenderTransform.Scale.Y);

            parent.Children.Add(element);
            Canvas.SetLeft(element, widget.Layout.Margin.Left);
            Canvas.SetTop(element, widget.Layout.Margin.Top);
            Canvas.SetRight(element, widget.Layout.Margin.Right);
            Canvas.SetBottom(element, widget.Layout.Margin.Bottom);
        }

        private void WidgetPreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                WidgetPreviewCanvas.ReleaseMouseCapture();
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                TranslateTransform tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
                end = new System.Windows.Point(tt.X, tt.Y);
            }
        }

        private void WidgetPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!WidgetPreviewCanvas.IsMouseCaptured)
                return;

            TranslateTransform tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
            Vector v = start - Mouse.GetPosition(WidgetPreviewCanvas);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;
        }

        private void WidgetPreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            start = Mouse.GetPosition(WidgetPreviewCanvas);
            if (e.ChangedButton == MouseButton.Middle)
            {
                WidgetPreviewCanvas.CaptureMouse();
                // resets when children are hittble? idk
                TranslateTransform tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
                origin = end;
                tt.X = origin.X;
                tt.Y = origin.Y;
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void WidgetPreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            double zoom = e.Delta > 0 ? 1.2 : (1 / 1.2);

            var CursorPosCanvas = e.GetPosition(WidgetPreviewCanvas);
            pan.X += -(CursorPosCanvas.X - WidgetPreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoom - 1.0);
            pan.Y += -(CursorPosCanvas.Y - WidgetPreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoom - 1.0);
            end.X = pan.X;
            end.Y = pan.Y;

            transform.ScaleX *= zoom;
            transform.ScaleY *= zoom;

        }

        public void SetRealPixelZoom(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            //double zoom = ViewModel.Image.Width / WidgetPreview.RenderSize.Width;
            //double zoomQuot = zoom / transform.ScaleX;
            ////WidgetPreview.SetCurrentValue(WidthProperty, ViewModel.Image.Width);
            ////WidgetPreview.SetCurrentValue(HeightProperty, ViewModel.Image.Height);
            //var CursorPosCanvas = start;
            //pan.X += -(CursorPosCanvas.X - WidgetPreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoomQuot - 1.0);
            //pan.Y += -(CursorPosCanvas.Y - WidgetPreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoomQuot - 1.0);
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
            TransformGroup transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }
    }
}
