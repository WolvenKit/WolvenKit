using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WolvenKit.Views.Others;
/// <summary>
/// Interaktionslogik für ImagePreviewCanvas.xaml
/// </summary>
public partial class ImageCanvas : UserControl
{
    private Point _origin;
    private Point _start;
    private Point _end;

    public static readonly DependencyProperty SourceProperty = 
        DependencyProperty.Register(
            nameof(Source), 
            typeof(ImageSource), 
            typeof(ImageCanvas));

    public ImageSource Source
    {
        get => (ImageSource)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public static readonly DependencyProperty OverlayProperty =
        DependencyProperty.Register(
            nameof(Overlay),
            typeof(object),
            typeof(ImageCanvas));

    public object Overlay
    {
        get { return GetValue(OverlayProperty); }
        set { SetValue(OverlayProperty, value); }
    }

    public ImageCanvas()
    {
        InitializeComponent();

        ImagePreviewCanvas.PreviewMouseWheel += ImagePreview_MouseWheel;
        ImagePreviewCanvas.MouseDown += ImagePreview_MouseLeftButtonDown;
        ImagePreviewCanvas.MouseUp += ImagePreview_MouseLeftButtonUp;
        ImagePreviewCanvas.MouseMove += ImagePreview_MouseMove;
    }

    private void ImagePreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton != MouseButton.Middle)
        {
            return;
        }

        ImagePreviewCanvas.ReleaseMouseCapture();
        ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);

        _end = new Point(TranslateTransformItem.X, TranslateTransformItem.Y);
    }

    private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
    {
        if (!ImagePreviewCanvas.IsMouseCaptured)
        {
            return;
        }

        var v = _start - Mouse.GetPosition(ImagePreviewCanvas);

        TranslateTransformItem.SetCurrentValue(TranslateTransform.XProperty, _origin.X - v.X);
        TranslateTransformItem.SetCurrentValue(TranslateTransform.YProperty, _origin.Y - v.Y);
    }

    private void ImagePreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        _start = Mouse.GetPosition(ImagePreviewCanvas);
        if (e.ChangedButton != MouseButton.Middle)
        {
            return;
        }

        ImagePreviewCanvas.CaptureMouse();

        // resets when children are hittble? idk
        _origin = _end;
        TranslateTransformItem.SetCurrentValue(TranslateTransform.XProperty, _origin.X);
        TranslateTransformItem.SetCurrentValue(TranslateTransform.YProperty, _origin.Y);

        ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
    }

    private void ImagePreview_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        var zoom = e.Delta > 0 ? 1.2 : (1 / 1.2);

        var cursorPosCanvas = e.GetPosition(ImagePreviewCanvas);

        TranslateTransformItem.SetCurrentValue(TranslateTransform.XProperty, TranslateTransformItem.X + (-(cursorPosCanvas.X - (ImagePreviewCanvas.RenderSize.Width / 2.0) - TranslateTransformItem.X) * (zoom - 1.0)));
        TranslateTransformItem.SetCurrentValue(TranslateTransform.YProperty, TranslateTransformItem.Y + (-(cursorPosCanvas.Y - (ImagePreviewCanvas.RenderSize.Height / 2.0) - TranslateTransformItem.Y) * (zoom - 1.0)));

        _end.X = TranslateTransformItem.X;
        _end.Y = TranslateTransformItem.Y;

        ScaleTransformItem.SetCurrentValue(ScaleTransform.ScaleXProperty, ScaleTransformItem.ScaleX * zoom);
        ScaleTransformItem.SetCurrentValue(ScaleTransform.ScaleYProperty, ScaleTransformItem.ScaleY * zoom);
    }

    public void ResetZoomPan()
    {
        ScaleTransformItem.SetCurrentValue(ScaleTransform.ScaleXProperty, 1D);
        ScaleTransformItem.SetCurrentValue(ScaleTransform.ScaleYProperty, 1D);

        TranslateTransformItem.SetCurrentValue(TranslateTransform.XProperty, 0D);
        TranslateTransformItem.SetCurrentValue(TranslateTransform.YProperty, 0D);

        _end.X = 0;
        _end.Y = 0;
    }
}
