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
using WolvenKit.Functionality.Layout;
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
                    var stack = new StackPanel();
                    WidgetPreview.Children.Clear();
                    WidgetPreview.Children.Add(stack);
                    foreach (var item in library.LibraryItems)
                    {
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

                        RenderWidget(stack, root);
                    }
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

        private System.Windows.Media.Color ToColor(HDRColor hdr)
        {
            return System.Windows.Media.Color.FromArgb((byte)(hdr.Alpha * 255), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
        }

        private System.Drawing.Color ToDrawingColor(HDRColor hdr, float alpha = 1)
        {
            return System.Drawing.Color.FromArgb((byte)(hdr.Alpha * 255 * alpha), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
        }

        private System.Drawing.Brush ToBrush(HDRColor hdr)
        {
            return new SolidBrush(System.Drawing.Color.FromArgb((byte)(hdr.Alpha * 255), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255)));
        }

        private System.Windows.Point ToPoint(Vector2 v)
        {
            return new System.Windows.Point(v.X, v.Y);
        }

        private void RenderWidget(Panel parent, inkWidget widget)
        {
            var parentWidget = parent.Tag as inkWidget;
            FrameworkElement element = new Canvas();

            float width = widget.Size.X;
            float height = widget.Size.Y;

            float left = widget.Layout.Margin.Left;
            float top = widget.Layout.Margin.Top;
            float right = widget.Layout.Margin.Right;
            float bottom = widget.Layout.Margin.Bottom;

            if (parentWidget is not inkFlexWidget)
            {
                if ((widget.Layout.Anchor.Value == Enums.inkEAnchor.Fill ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomFillHorizontaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterFillHorizontaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopFillHorizontaly
                    ) && !Double.IsNaN(parent.Width))
                {
                    width = (float)parent.Width;
                }

                if ((widget.Layout.Anchor.Value == Enums.inkEAnchor.Fill ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterFillVerticaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.LeftFillVerticaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.RightFillVerticaly
                    ) && !Double.IsNaN(parent.Height))
                {
                    height = (float)parent.Height;
                }
            }

            if (widget is inkCompoundWidget cw)
            {
                Panel panel;
                if (widget is inkCanvasWidget)
                {
                    panel = new Canvas();
                    panel.Background = new SolidColorBrush(ToColor(widget.TintColor))
                    {
                        Opacity = 0.0
                    };
                }
                else if (widget is inkHorizontalPanelWidget)
                {
                    panel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };
                    panel.Background = new SolidColorBrush(ToColor(widget.TintColor))
                    {
                        Opacity = 0.0
                    };
                }
                else if (widget is inkVerticalPanelWidget)
                {
                    panel = new StackPanel()
                    {
                        Orientation = Orientation.Vertical
                    };
                    panel.Background = new SolidColorBrush(ToColor(widget.TintColor))
                    {
                        Opacity = 0.0
                    };
                }
                else
                {
                    panel = new Grid();
                }

                if (ToThickness(cw.ChildMargin) != new Thickness(0, 0, 0, 0))
                {
                    var border = new Border();
                    border.Child = panel;
                    panel.Margin = ToThickness(cw.ChildMargin);
                    element = border;
                }
                else
                {
                    element = panel;
                }
            }
            else if (widget is inkTextWidget textWidget && (int)height > 0 && (int)width > 0)
            {
                var text = textWidget.Text.GetValue();
                if (text == "")
                    text = "empty text";
                if (textWidget.LetterCase.Value == Enums.textLetterCase.UpperCase)
                    text = text.ToUpper();
                // not totally sure why this is required - some dpi issue?
                //uint fontSize = (uint)(textWidget.FontSize * 0.8);
                uint fontSize = (uint)(textWidget.FontSize);
                var fontPath = textWidget.FontFamily.DepotPath?.ToString() ?? "";
                if (ViewModel.Fonts.ContainsKey(fontPath) && ViewModel.Fonts[fontPath].ContainsKey(textWidget.FontStyle))
                {
                    var fc = ViewModel.Fonts[fontPath][textWidget.FontStyle];
                    Font f = new Font(fc.Families.First(), fontSize);

                    var wrapWidth = 10000;
                    if (textWidget.WrappingInfo.AutoWrappingEnabled && textWidget.WrappingInfo.WrappingAtPosition != 0)
                    {
                        wrapWidth = (int)textWidget.WrappingInfo.WrappingAtPosition;
                    }
                    float actualTextWidth, actualTextHeight;
                    using (var tempbmp = new Bitmap(wrapWidth, 10000, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
                    {
                        using (var g = Graphics.FromImage(tempbmp))
                        {
                            SizeF s = g.MeasureString(text, f, new SizeF(wrapWidth, 10000));
                            actualTextWidth = s.Width;
                            actualTextHeight = s.Height;
                        }
                    }
                    if (widget.FitToContent)
                    {
                        width = actualTextWidth;
                        height = actualTextHeight;
                    }

                    var bmp = new Bitmap((int)width, (int)height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                    using (var g = Graphics.FromImage(bmp))
                    {
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                        g.DrawString(text, f, ToBrush(widget.TintColor), new RectangleF(0, 0, wrapWidth, 10000));
                    }

                    // premultiplied alpha issues here too - opacitymask addresses it
                    var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        bmp.GetHbitmap(),
                        IntPtr.Zero,
                        Int32Rect.Empty,
                        BitmapSizeOptions.FromEmptyOptions());
                    var imageBrush = new ImageBrush()
                    {
                        ImageSource = bitmapSource
                    };
                    var grid = new Grid();
                    grid.OpacityMask = imageBrush;
                    grid.Background = new SolidColorBrush(ToColor(widget.TintColor));
                    element = grid;
                }
                else
                {
                    // fallback for font failure
                    var textblock = new TextBlock();
                    textblock.Text = textWidget.Text;
                    textblock.FontSize = fontSize;
                    textblock.Foreground = new SolidColorBrush(ToColor(widget.TintColor));

                    if (textWidget.TextHorizontalAlignment.ToEnumString() == "Center")
                        textblock.TextAlignment = TextAlignment.Center;

                    element = textblock;
                }
                RenderOptions.SetBitmapScalingMode(element, BitmapScalingMode.NearestNeighbor);

                //element.Margin = ToThickness(widget.Layout.Margin);

            }
            else if (widget is inkImageWidget imageWidget && imageWidget.TextureAtlas != null)
            {
                var atlasPath = imageWidget.TextureAtlas.DepotPath?.GetValue() ?? "";
                if (ViewModel.AtlasParts.ContainsKey(atlasPath))
                {

                    if (ViewModel.AtlasParts[atlasPath].ContainsKey(imageWidget.TexturePart))
                    {
                        var imageSource = ViewModel.AtlasParts[atlasPath][imageWidget.TexturePart];
                        Bitmap bitmap;
                        using (var outStream = new MemoryStream())
                        {
                            BitmapEncoder enc = new BmpBitmapEncoder();
                            enc.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
                            enc.Save(outStream);
                            bitmap = new Bitmap(outStream);
                        }

                        int renderWidth, renderHeight;
                        if (imageWidget.UseNineSliceScale)
                        {
                            renderWidth = bitmap.Width;
                            renderHeight = bitmap.Height;
                            if (widget.FitToContent && parentWidget is inkFlexWidget)
                            {
                                height = bitmap.Height;
                                width = bitmap.Width;
                            }
                        }
                        else if (widget.FitToContent)
                        {
                            height = bitmap.Height;
                            width = bitmap.Width;
                            renderHeight = bitmap.Height;
                            renderWidth = bitmap.Width;
                        }
                        else
                        {
                            renderWidth = (int)Math.Round(width);
                            renderHeight = (int)Math.Round(height);
                        }
                        //}

                        //if (imageWidget.Layout.HAlign.Value != Enums.inkEHorizontalAlign.Fill)
                        //{
                            //renderWidth = bitmap.Width;
                            //width = renderWidth;
                        //}

                        //if (imageWidget.Layout.VAlign.Value != Enums.inkEVerticalAlign.Fill)
                        //{
                            //renderHeight = bitmap.Height;
                            //height = renderHeight;
                        //}

                        Bitmap bmp = new Bitmap(renderWidth, renderHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                        using (Graphics gfx = Graphics.FromImage(bmp))
                        {
                            // this is doesn't account for premultipied alpha, so the opacity mask is still needed
                            var matrix = new ColorMatrix(new float[][]
                            {
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                            });
                            matrix.Matrix03 = widget.TintColor.Alpha;
                            matrix.Matrix40 = widget.TintColor.Red;
                            matrix.Matrix41 = widget.TintColor.Green;
                            matrix.Matrix42 = widget.TintColor.Blue;

                            ImageAttributes attributes = new ImageAttributes();
                            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            gfx.DrawImage(bitmap, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                        }

                        var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                            bmp.GetHbitmap(),
                            IntPtr.Zero,
                            Int32Rect.Empty,
                            BitmapSizeOptions.FromEmptyOptions());

                        switch (imageWidget.MirrorType.Value)
                        {
                            case Enums.inkBrushMirrorType.Both:
                                bitmapSource = new TransformedBitmap(bitmapSource, new ScaleTransform(-1, -1));
                                break;
                            case Enums.inkBrushMirrorType.Horizontal:
                                bitmapSource = new TransformedBitmap(bitmapSource, new ScaleTransform(-1, 1));
                                break;
                            case Enums.inkBrushMirrorType.Vertical:
                                bitmapSource = new TransformedBitmap(bitmapSource, new ScaleTransform(1, -1));
                                break;
                            case Enums.inkBrushMirrorType.NoMirror:
                                break;
                        }

                        //var hb = bitmap.GetHbitmap();
                        //var stride = ((renderWidth * 32 + 31) & ~31) >> 3;

                        //var bitmapSource = BitmapSource.Create(renderWidth, renderHeight,
                        //    96, 96, System.Windows.Media.PixelFormats.Pbgra32, null, hb, renderHeight * renderWidth * 4, stride);

                        //var image = new System.Windows.Controls.Image();
                        //image.Source = bitmapSource;
                        //element = image;

                        if (imageWidget.UseNineSliceScale && ViewModel.AtlasSlices.ContainsKey(atlasPath) && ViewModel.AtlasSlices[atlasPath].ContainsKey(imageWidget.TexturePart))
                        {
                            var rect = ViewModel.AtlasSlices[atlasPath][imageWidget.TexturePart];
                            var ns = new NineSlicePanel()
                            {
                                BackgroundImage = bitmapSource,
                                NineSlice = ToThickness(rect)
                            };
                            element = ns;
                        }
                        else
                        {
                            var imagebrush = new ImageBrush();
                            imagebrush.ImageSource = bitmapSource;
                            //RenderOptions.SetBitmapScalingMode(imagebrush, BitmapScalingMode.NearestNeighbor);

                            var grid = new Canvas();
                            grid.Background = new SolidColorBrush(ToColor(widget.TintColor));
                            grid.OpacityMask = imagebrush;
                            element = grid;
                        }
                        RenderOptions.SetBitmapScalingMode(element, BitmapScalingMode.NearestNeighbor);
                    }
                }
            }
            else if (widget is inkRectangleWidget rectangleWidget)
            {
                var rectangle = new Canvas();
                rectangle.Background = new SolidColorBrush(ToColor(widget.TintColor));
                element = rectangle;
            }

            element.Tag = widget;
            element.ToolTip = widget.Name + $" ({widget.GetType().Name})";
            element.Name = widget.GetType().Name + "_" + widget.Name.GetValue().Replace(" ", "_").Replace("-", "_").Replace("/", "_");

            element.Width = width > 0 ? width : 0;
            element.Height = height > 0 ? height : 0;
            

            if (parentWidget is inkBasePanelWidget || parentWidget is inkFlexWidget)
            {
                switch (widget.Layout.HAlign.Value)
                {
                    case Enums.inkEHorizontalAlign.Center:
                        element.HorizontalAlignment = HorizontalAlignment.Center;
                        break;
                    case Enums.inkEHorizontalAlign.Left:
                        element.HorizontalAlignment = HorizontalAlignment.Left;
                        break;
                    case Enums.inkEHorizontalAlign.Right:
                        element.HorizontalAlignment = HorizontalAlignment.Right;
                        break;
                    case Enums.inkEHorizontalAlign.Fill:
                        element.HorizontalAlignment = HorizontalAlignment.Stretch;
                        break;
                }

                switch (widget.Layout.VAlign.Value)
                {
                    case Enums.inkEVerticalAlign.Center:
                        element.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    case Enums.inkEVerticalAlign.Top:
                        element.VerticalAlignment = VerticalAlignment.Top;
                        break;
                    case Enums.inkEVerticalAlign.Bottom:
                        element.VerticalAlignment = VerticalAlignment.Bottom;
                        break;
                    case Enums.inkEVerticalAlign.Fill:
                        element.VerticalAlignment = VerticalAlignment.Stretch;
                        break;
                }
            }

            parent.Children.Add(element);

            if (parentWidget is inkCanvasWidget)
            {
                if (widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomLeft ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.LeftFillVerticaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterLeft ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopLeft
                    )
                {
                    Canvas.SetLeft(element, -element.Width * widget.Layout.AnchorPoint.X + left);
                }
                else if (widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomRight ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.RightFillVerticaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterRight ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopRight
                    )
                {
                    Canvas.SetRight(element, -element.Width * (1.0 - widget.Layout.AnchorPoint.X) + right);
                }
                else
                {
                    Canvas.SetLeft(element, parent.Width / 2 - element.Width / 2 + left);
                }

                if (widget.Layout.Anchor.Value == Enums.inkEAnchor.TopCenter ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopFillHorizontaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopLeft ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.TopRight
                    )
                {
                    Canvas.SetTop(element, -element.Height * widget.Layout.AnchorPoint.Y + top);
                }
                else if (widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomCenter ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomFillHorizontaly ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomLeft ||
                    widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomRight
                    )
                {
                    Canvas.SetBottom(element, -element.Height * (1.0 - widget.Layout.AnchorPoint.Y) + bottom);
                }
                else
                {
                    Canvas.SetTop(element, parent.Height / 2 - element.Height / 2 + top);
                }
            }
            else
            {
                element.Margin = new Thickness(left * widget.Layout.SizeCoefficient, top * widget.Layout.SizeCoefficient,
                    right * widget.Layout.SizeCoefficient, bottom * widget.Layout.SizeCoefficient);
            }

            // lots of elements are hidden by default
            if (parentWidget is not null)
                element.Opacity = widget.Opacity;

            if (!widget.Visible)
            {
                if (widget.AffectsLayoutWhenHidden)
                {
                    element.Visibility = Visibility.Hidden;
                    //element.Opacity *= 0.1;
                }
                else
                {
                    element.Visibility = Visibility.Collapsed;
                    //element.Opacity *= 0.1;
                }
            }


            if (widget is inkCompoundWidget comp)
            {
                var panel = element as Panel;
                if (element is Border b)
                {
                    //if (widget.FitToContent)
                    //{ 
                        b.Width = Double.NaN;
                        b.Height = Double.NaN;
                    //}
                    panel = (Panel)b.Child;
                }
                //panel.ClipToBounds = true;
                if (comp.Children != null && comp.Children.GetValue() is inkMultiChildren imc)
                {
                    var children = imc.Children.Reverse();
                    if (comp.ChildOrder.Value == Enums.inkEChildOrder.Forward)
                        children = children.Reverse();

                    foreach (var child in children)
                    {
                        RenderWidget(panel, child);
                    }
                    //double totalHeight = 0, totalWidth = 0;
                    //foreach (FrameworkElement child in panel.Children)
                    //{
                    //    totalHeight += child.Height;
                    //    totalWidth += child.Width;
                    //}

                    if (widget is inkBasePanelWidget || widget is inkFlexWidget)
                    {
                        panel.Height = Double.NaN;
                        panel.Width = Double.NaN;

                        foreach (FrameworkElement child in panel.Children)
                        {
                            if (child.Tag is inkImageWidget iw && iw.UseNineSliceScale)
                            {
                                if (iw.Layout.HAlign.Value == Enums.inkEHorizontalAlign.Fill)
                                {
                                    child.Width = Double.NaN;
                                }

                                if (iw.Layout.VAlign.Value == Enums.inkEVerticalAlign.Fill)
                                {
                                    child.Height = Double.NaN;
                                }
                            }
                        }
                    }
                    else
                    {
                        panel.Width = width;
                        panel.Height = height;
                    }
                    //panel.Background = new SolidColorBrush(ToColor(widget.TintColor))
                    //{
                    //    Opacity = 0.01
                    //};
                    //var style = new Style();
                    //style.Setters.Add(new Setter(BackgroundProperty, new SolidColorBrush(ToColor(widget.TintColor))
                    //{
                    //    Opacity = 0.01
                    //}));
                    //var trigger = new Trigger()
                    //{
                    //    Property = IsMouseOverProperty,
                    //    Value = true
                    //};
                    //trigger.Setters.Add(new Setter(BackgroundProperty, new SolidColorBrush(ToColor(widget.TintColor))
                    //{
                    //    Opacity = 0.1
                    //}));
                    //style.Triggers.Add(trigger);
                    //panel.Style = style;
                }
            }

            element.RenderTransformOrigin = ToPoint(widget.RenderTransformPivot);
            element.RenderTransform = new TransformGroup()
            {
                Children = new TransformCollection(new List<System.Windows.Media.Transform>()
                {
                    new ScaleTransform(widget.RenderTransform.Scale.X, widget.RenderTransform.Scale.Y),
                    new TranslateTransform(widget.RenderTransform.Translation.X, widget.RenderTransform.Translation.Y),
                    new SkewTransform(Math.Atan(widget.RenderTransform.Shear.X) * 180/Math.PI, Math.Atan(widget.RenderTransform.Shear.Y) * 180/Math.PI),
                    new RotateTransform(widget.RenderTransform.Rotation)
                })
            };
        }

        private Thickness AddToThickness(inkMargin m, Thickness t)
        {
            return new Thickness(m.Left + t.Left, m.Top + t.Top, m.Right + t.Right, m.Bottom + t.Bottom);
        }

        private HorizontalAlignment ToHorizontalAlignment(CEnum<Enums.inkEHorizontalAlign> hAlign)
        {
            switch (hAlign.Value)
            {
                case Enums.inkEHorizontalAlign.Fill:
                    return HorizontalAlignment.Stretch;
                case Enums.inkEHorizontalAlign.Center:
                    return HorizontalAlignment.Center;
                case Enums.inkEHorizontalAlign.Left:
                    return HorizontalAlignment.Left;
                case Enums.inkEHorizontalAlign.Right:
                    return HorizontalAlignment.Right;
                default:
                    return HorizontalAlignment.Left;
            }
        }

        private VerticalAlignment ToVerticalAlignment(CEnum<Enums.inkEVerticalAlign> hAlign)
        {
            switch (hAlign.Value)
            {
                case Enums.inkEVerticalAlign.Fill:
                    return VerticalAlignment.Stretch;
                case Enums.inkEVerticalAlign.Center:
                    return VerticalAlignment.Center;
                case Enums.inkEVerticalAlign.Top:
                    return VerticalAlignment.Top;
                case Enums.inkEVerticalAlign.Bottom:
                    return VerticalAlignment.Bottom;
                default:
                    return VerticalAlignment.Top;
            }
        }

        private Thickness ToThickness(inkMargin value)
        {
            return new Thickness(value.Left, value.Top, value.Right, value.Bottom);
}

        private Thickness ToThickness(RectF value)
        {
            return new Thickness(value.Left, value.Top, value.Right, value.Bottom);
        }

        private void WidgetPreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                WidgetPreviewCanvas.ReleaseMouseCapture();
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                TranslateTransform tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
                end = new System.Windows.Point(Math.Round(tt.X), Math.Round(tt.Y));
            }
        }

        private void WidgetPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!WidgetPreviewCanvas.IsMouseCaptured)
                return;

            TranslateTransform tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
            Vector v = start - Mouse.GetPosition(WidgetPreviewCanvas);
            tt.X = Math.Round(origin.X - v.X);
            tt.Y = Math.Round(origin.Y - v.Y);
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
                tt.X = Math.Round(origin.X);
                tt.Y = Math.Round(origin.Y);
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void WidgetPreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];
            TranslateTransform pan = (TranslateTransform)transformGroup.Children[1];

            double zoom = e.Delta > 0 ? 1.189207115 : (1 / 1.189207115);

            var CursorPosCanvas = e.GetPosition(WidgetPreviewCanvas);
            pan.X += Math.Round(-(CursorPosCanvas.X - WidgetPreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoom - 1.0));
            pan.Y += Math.Round(-(CursorPosCanvas.Y - WidgetPreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoom - 1.0));
            end.X = pan.X;
            end.Y = pan.Y;

            transform.ScaleX = zoom * transform.ScaleX;
            transform.ScaleY = transform.ScaleX;
            UpdateZoomText(transform.ScaleX);
        }

        public void UpdateZoomText(double scale)
        {
            ZoomText.SetCurrentValue(TextBlock.TextProperty, $"{(scale*100).ToString("F1")}%");
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
            UpdateZoomText(transform.ScaleX);
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
            UpdateZoomText(transform.ScaleX);
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }
    }
}
