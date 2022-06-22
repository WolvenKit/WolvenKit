using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Point = System.Windows.Point;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkControl : UIElement
    {
        public inkWidget Widget => _widget;

        protected inkWidget _widget;

        public string Name { get; set; }

        //public virtual double Width => Widget?.Size.X ?? 0;
        //public virtual double Height => Widget?.Size.Y ?? 0;

        public Enums.inkEAnchor Anchor { get; set; }

        //public Thickness Margin => ToThickness(Widget.Layout.Margin);

        public Dictionary<string, string> PropertyBindings = new();

        private readonly List<string> _stateStack = new();

        public string LocalState => _stateStack.FirstOrDefault(defaultValue: null);

        public inkControl Parent { get; set; }

        public Color TintColor
        {
            get
            {
                var opacity = WidgetOpacity;
                if (opacity >= 0.0)
                {
                    SetCurrentValue(OpacityProperty, (double)opacity);
                }
                if (!PropertyBindings.ContainsKey("tintColor"))
                {
                    goto NoOverride;
                }

                var variant = GetProperty(PropertyBindings["tintColor"]);

                if (variant?.Value is HDRColor color)
                {
                    return ToColor(color);
                }

            NoOverride:
                return ToColor(Widget?.TintColor ?? new HDRColor() { Alpha = 1, Blue = 1, Green = 1, Red = 1 });
            }
        }

        public Brush TintBrush => new SolidColorBrush(TintColor);

        public RDTWidgetView WidgetView;

        public string WidgetPath => Widget?.GetPath() ?? "";

        private readonly DrawingGroup backingStore = new DrawingGroup();

        public RotateTransform Rotation { get; set; } = new();

        public ScaleTransform Scale { get; set; } = new();

        public TranslateTransform Translation { get; set; } = new();

        public SkewTransform Skew { get; set; } = new();

        private bool _debug = true;

        public bool Debug
        {
            get => _debug || (Parent != null && Parent.Debug);
            set => _debug = value;
        }

        //private IsMouse

        //
        // Summary:
        //     Identifies the WolvenKit.Functionality.Layout.inkWidgets.inkControl.Margin dependency property.
        public static readonly DependencyProperty MarginProperty = DependencyProperty.Register(nameof(Margin), typeof(Thickness), typeof(inkControl),
            new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.AffectsMeasure, OnMarginChanged));

        private static void OnMarginChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((inkControl)d).InvalidateMeasure();//((inkControl)d).Render();

        public Thickness Margin
        {
            get => (Thickness)GetValue(MarginProperty);
            set => SetValue(MarginProperty, value);
        }

        //
        // Summary:
        //     Identifies the WolvenKit.Functionality.Layout.inkWidgets.inkControl.Width dependency property.
        public static readonly DependencyProperty WidthProperty = DependencyProperty.Register(nameof(Width), typeof(double), typeof(inkControl),
            new FrameworkPropertyMetadata(0D, FrameworkPropertyMetadataOptions.AffectsMeasure, OnWidthChanged));

        private static void OnWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((inkControl)d).InvalidateMeasure();//((inkControl)d).Render();

        public double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        //
        // Summary:
        //     Identifies the WolvenKit.Functionality.Layout.inkWidgets.inkControl.Height dependency property.
        public static readonly DependencyProperty HeightProperty = DependencyProperty.Register(nameof(Height), typeof(double), typeof(inkControl),
            new FrameworkPropertyMetadata(0D, FrameworkPropertyMetadataOptions.AffectsMeasure, OnHeightChanged));

        private static void OnHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((inkControl)d).InvalidateMeasure();//((inkControl)d).Render();

        public double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        public float WidgetOpacity
        {
            get
            {
                if (!PropertyBindings.ContainsKey("opacity"))
                {
                    goto NoOverride;
                }

                var variant = GetProperty(PropertyBindings["opacity"]);

                if (variant?.Value is CFloat opacity)
                {
                    return opacity;
                }

            NoOverride:
                return -1;
            }
        }

        public inkControl() : base()
        {
            MouseEnter += MouseEnterCore;
            MouseLeave += MouseLeaveCore;
            MouseDown += MouseDownCore;
            MouseUp += MouseUpCore;

            RenderTransform = new TransformGroup()
            {
                Children = new TransformCollection(new List<System.Windows.Media.Transform>()
                {
                    Scale,
                    Translation,
                    Skew,
                    Rotation
                })
            };
        }

        public inkControl(inkWidget widget, RDTWidgetView widgetView) : this()
        {
            _widget = widget;
            Name = Widget.Name;
            WidgetView = widgetView;

            if (Widget.PropertyManager != null && Widget.PropertyManager.GetValue() is inkPropertyManager ipm)
            {
                foreach (var ipb in ipm.Bindings)
                {
                    PropertyBindings.Add(ipb.PropertyName, ipb.StylePath);
                    if (!WidgetView.ViewModel.Bindings.Contains(ipb.PropertyName))
                    {
                        WidgetView.ViewModel.Bindings.Add(ipb.PropertyName);
                    }
                }
            }

            if (Widget.Effects != null)
            {
                foreach (var handle in Widget.Effects)
                {
                    var effect = (inkIEffect)handle.GetValue();
                    if (!WidgetView.ViewModel.inkEffects.Contains(effect))
                    {
                        WidgetView.ViewModel.inkEffects.Add(effect);
                    }

                    if (effect is inkMaskEffect me)
                    {
                        if (me.IsEnabled)
                        {
                            ClipToBounds = true;
                        }
                    }
                }
            }

            //WidgetView.RegisterName("margin" + GetHashCode(), Margin);
            Margin = ToThickness(Widget.Layout.Margin);
            Width = Widget.Size.X;
            Height = Widget.Size.Y;

            //ToolTip = Widget.Name + $" ({Widget.GetType().Name})";

            // unhide the roots at least
            if (Widget.GetParent() is not null)
            {
                Opacity = Widget.Opacity;

                if (!Widget.Visible)
                {
                    if (Widget.AffectsLayoutWhenHidden)
                    {
                        Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Visibility = Visibility.Collapsed;
                    }
                }
                //ClipToBounds = false;
            }
            else
            {
                //ClipToBounds = true;
            }

            WidgetView.RegisterName("element" + GetHashCode(), this);

            RenderTransformOrigin = ToPoint(Widget.RenderTransformPivot);

            WidgetView.RegisterName("rotation" + GetHashCode(), Rotation);
            Rotation.Angle = Widget.RenderTransform.Rotation;
            WidgetView.RegisterName("scale" + GetHashCode(), Scale);
            Scale.ScaleX = Widget.RenderTransform.Scale.X;
            Scale.ScaleY = Widget.RenderTransform.Scale.Y;
            WidgetView.RegisterName("translation" + GetHashCode(), Translation);
            Translation.X = Widget.RenderTransform.Translation.X;
            Translation.Y = Widget.RenderTransform.Translation.Y;
            Skew.AngleX = Math.Atan(Widget.RenderTransform.Shear.X) * 180 / Math.PI;
            Skew.AngleY = Math.Atan(Widget.RenderTransform.Shear.Y) * 180 / Math.PI;

            if (Widget.IsInteractive)
            {
                MouseEnter += MouseEnterControl;
                MouseLeave += MouseLeaveControl;
                MouseDown += MouseDownControl;
                MouseUp += MouseUpControl;
            }
            else
            {
                //IsHitTestVisible = false;
            }
        }


        public void MouseEnterCore(object sender, MouseEventArgs e) => Render();

        public void MouseLeaveCore(object sender, MouseEventArgs e) => Render();

        public void MouseDownCore(object sender, MouseButtonEventArgs e) => Render();

        public void MouseUpCore(object sender, MouseButtonEventArgs e) => Render();


        public virtual void MouseEnterControl(object sender, MouseEventArgs e)
        {
            _stateStack.Insert(0, "Hover");
            Render();
        }

        public virtual void MouseLeaveControl(object sender, MouseEventArgs e)
        {
            _stateStack.Remove("Hover");
            Render();
        }

        public virtual void MouseDownControl(object sender, MouseButtonEventArgs e)
        {
            _stateStack.Insert(0, "Press");
            if (_stateStack.Contains("Active"))
            {
                _stateStack.Remove("Active");
            }
            else
            {
                _stateStack.Insert(0, "Active");
            }

            Render();
        }

        public virtual void MouseUpControl(object sender, MouseButtonEventArgs e)
        {
            _stateStack.Remove("Press");
            Render();
        }

        public CVariant GetProperty(string propertyPath)
        {
            if (WidgetView == null)
            {
                return null;
            }

            if (WidgetView.ViewModel == null)
            {
                return null;
            }

            if (WidgetView.ViewModel.CurrentStyleState == null)
            {
                return null;
            }

            if (WidgetView.ViewModel.CurrentTheme == null)
            {
                return null;
            }

            CVariant variant;
            foreach (var state in _stateStack)
            {
                variant = (CVariant)Application.Current.TryFindResource("CVariant/" + WidgetView.ViewModel.CurrentTheme + "/" + propertyPath + "#" + state);

                if (variant != null)
                {
                    goto ValidVariant;
                }
            }

            variant = (CVariant)Application.Current.TryFindResource("CVariant/" + WidgetView.ViewModel.CurrentTheme + "/" + propertyPath + "#" + WidgetView.ViewModel.CurrentStyleState);

            if (variant == null)
            {
                return null;
            }

        ValidVariant:

            if (variant.Value is inkStylePropertyReference ispr)
            {
                variant = GetProperty(ispr.ReferencedPath);
            }

            return variant;
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);

            Render();
            dc.DrawDrawing(backingStore);
        }

        public void Render()
        {
            var drawingContext = backingStore.Open();
            RenderCore(drawingContext);
            drawingContext.Close();
        }

        protected virtual void RenderCore(DrawingContext dc)
        {
            var drawOpacity = Opacity;
            if (Debug)
            {
                var lineThickness = 0.1;
                drawOpacity = IsMouseOver ? 1.0 : 0.1;
                var debugOpacity = (byte)(IsMouseOver ? 255 : 100);

                dc.DrawText(new FormattedText(Name, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 4D, new SolidColorBrush(Color.FromArgb(debugOpacity, 255, 255, 255)), 96D)
                {
                    TextAlignment = TextAlignment.Left
                }, new Point(0, -6));
                dc.DrawRectangle(new SolidColorBrush(Color.FromArgb(10, 0, 0, 0)), new Pen(new SolidColorBrush(Color.FromArgb(debugOpacity, 255, 255, 255)), lineThickness), new Rect(0, 0, RenderSize.Width, RenderSize.Height));
                if (Margin != new Thickness())
                {
                    var brush = new SolidColorBrush(Color.FromArgb(debugOpacity, 255, 0, 255));
                    dc.DrawRectangle(null, new Pen(brush, lineThickness), new Rect(-Margin.Left, -Margin.Top, Math.Max(RenderSize.Width + Margin.Left + Margin.Right, 0), Math.Max(RenderSize.Height + Margin.Top + Margin.Bottom, 0)));
                    if (Margin.Top != 0)
                    {
                        dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width / 2, -Margin.Top), new Point(RenderSize.Width / 2, -Margin.Top / 2 - 2.5));
                        dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width / 2, 0), new Point(RenderSize.Width / 2, -Margin.Top / 2 + 2.5));
                        dc.DrawText(new FormattedText($"{Margin.Top}px", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 4D, brush, 96D)
                        {
                            TextAlignment = TextAlignment.Center
                        }, new Point(RenderSize.Width / 2, -Margin.Top / 2 - 2.5));
                    }
                    if (Margin.Bottom != 0)
                    {
                        dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width / 2, RenderSize.Height + Margin.Bottom / 2 + 2.5), new Point(RenderSize.Width / 2, RenderSize.Height + Margin.Bottom));
                        dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width / 2, RenderSize.Height + Margin.Bottom / 2 - 2.5), new Point(RenderSize.Width / 2, RenderSize.Height));
                        dc.DrawText(new FormattedText($"{Margin.Bottom}px", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 4D, brush, 96D)
                        {
                            TextAlignment = TextAlignment.Center
                        }, new Point(RenderSize.Width / 2, RenderSize.Height + Margin.Bottom / 2 - 2.5));
                    }
                    if (Margin.Left != 0)
                    {
                        if (Margin.Left > 10)
                        {
                            dc.DrawLine(new Pen(brush, lineThickness), new Point(0, RenderSize.Height / 2), new Point(-Margin.Left / 2 + 5, RenderSize.Height / 2));
                            dc.DrawLine(new Pen(brush, lineThickness), new Point(-Margin.Left, RenderSize.Height / 2), new Point(-Margin.Left / 2 - 5, RenderSize.Height / 2));
                        }
                        dc.DrawText(new FormattedText($"{Margin.Left}px", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 4D, brush, 96D)
                        {
                            TextAlignment = TextAlignment.Center
                        }, new Point(-Margin.Left / 2, RenderSize.Height / 2 - 2.5));
                    }
                    if (Margin.Right != 0)
                    {
                        if (Margin.Right > 10)
                        {
                            dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width + Margin.Right / 2 - 5, RenderSize.Height / 2), new Point(RenderSize.Width, RenderSize.Height / 2));
                            dc.DrawLine(new Pen(brush, lineThickness), new Point(RenderSize.Width + Margin.Right / 2 + 5, RenderSize.Height / 2), new Point(RenderSize.Width + Margin.Right, RenderSize.Height / 2));
                        }
                        dc.DrawText(new FormattedText($"{Margin.Right}px", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 4D, brush, 96D)
                        {
                            TextAlignment = TextAlignment.Center
                        }, new Point(RenderSize.Width + Margin.Right / 2, RenderSize.Height / 2 - 2.5));
                    }
                }
                dc.DrawEllipse(null, new Pen(new SolidColorBrush(Color.FromArgb(debugOpacity, 0, 255, 255)), lineThickness), new Point(RenderSize.Width * AnchorToX(this), RenderSize.Height * AnchorToY(this)), 5, 5);
            }
            dc.PushOpacity(drawOpacity);

            var isMasked = false;

            if (Parent != null)
            {
                inkMaskControl mask = null;
                foreach (inkControl control in ((inkCompoundControl)Parent).Children)
                {
                    if (control is inkMaskControl _mask)
                    {
                        mask = _mask;
                        continue;
                    }

                    if (control == this && mask != null)
                    {
                        isMasked = true;
                        var point = mask.TranslatePoint(new Point(0, 0), this);
                        //SetCurrentValue(OpacityMaskProperty, new ImageBrush(mask.ImageSource)
                        //dc.PushOpacityMask(new ImageBrush(mask.ImageSource)
                        //{
                        //    Viewport = new Rect(point, mask.RenderSize),
                        //    ViewportUnits = BrushMappingMode.Absolute,
                        //    Viewbox = new Rect(new Point(0, 0), mask.RenderSize),
                        //    ViewboxUnits = BrushMappingMode.Absolute
                        //});
                        dc.PushClip(new RectangleGeometry(new Rect(point, mask.RenderSize)));
                        //var maskDc = new DrawingGroup();

                        //var drawingContext = maskDc.Open();
                        //drawingContext.DrawImage(mask.ImageSource, new Rect(point, mask.RenderSize));
                        //drawingContext.Close();
                        //dc.PushOpacityMask(new DrawingBrush(maskDc));

                        //SetCurrentValue(OpacityMaskProperty, new VisualBrush(mask));
                    }
                }
            }

            Render(dc);

            if (isMasked)
            {
                dc.Pop();
            }

            dc.Pop();
        }

        protected virtual void Render(DrawingContext dc)
        {

        }

        public virtual void RenderRecursive() => Render();

        protected override Size MeasureCore(Size availableSize) => MeasureForDimensions(new Size(Width, Height), availableSize);

        protected Size MeasureForDimensions(Size dimensions, Size availableSize)
        {
            var size = dimensions;
            if (!double.IsPositiveInfinity(availableSize.Width) && FillH(this))
            {
                size.Width = availableSize.Width;
            }

            if (!double.IsPositiveInfinity(availableSize.Height) && FillV(this))
            {
                size.Height = availableSize.Height;
            }

            return size;
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            finalRect.X = Math.Round(finalRect.X);
            finalRect.Y = Math.Round(finalRect.Y);
            finalRect.Width = Math.Round(finalRect.Width);
            finalRect.Height = Math.Round(finalRect.Height);

            base.ArrangeCore(finalRect);
        }

        // conversion functions

        public static Point ToPoint(Vector2 v) => new Point(v.X, v.Y);

        // i'm pretty sure this isn't the right way to convert these
        public static Color ToColor(HDRColor hdr, float alpha = 1)
        {
            float r = hdr.Red;
            float g = hdr.Green;
            float b = hdr.Blue;
            if (r > 1.0 || g > 1.0 || b > 1.0)
            {
                var scale = Math.Max(Math.Max(r, g), b);
                r /= scale;
                g /= scale;
                b /= scale;
            }
            //r /= 2F;
            //g /= 2F;
            //b /= 2F;
            return Color.FromArgb((byte)(hdr.Alpha * 255 * alpha), (byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }

        public static Brush ToBrush(HDRColor hdr) => new SolidColorBrush(ToColor(hdr));

        public static System.Drawing.Color ToDrawingColor(HDRColor hdr, float alpha = 1)
        {
            float r = hdr.Red;
            float g = hdr.Green;
            float b = hdr.Blue;
            if (r > 1.0 || g > 1.0 || b > 1.0)
            {
                var scale = Math.Max(Math.Max(r, g), b);
                r /= scale;
                g /= scale;
                b /= scale;
            }
            return System.Drawing.Color.FromArgb((byte)(hdr.Alpha * 255 * alpha), (byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }

        public static System.Drawing.Brush ToDrawingBrush(HDRColor hdr) => new System.Drawing.SolidBrush(ToDrawingColor(hdr));

        public static Thickness AddToThickness(inkMargin m, Thickness t) => new Thickness(m.Left + t.Left, m.Top + t.Top, m.Right + t.Right, m.Bottom + t.Bottom);

        public static HorizontalAlignment ToHorizontalAlignment(CEnum<Enums.inkEHorizontalAlign> hAlign)
        {
            switch ((Enums.inkEHorizontalAlign)hAlign)
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

        public static VerticalAlignment ToVerticalAlignment(CEnum<Enums.inkEVerticalAlign> hAlign)
        {
            switch ((Enums.inkEVerticalAlign)hAlign)
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

        public static Thickness ToThickness(inkMargin value) => new Thickness(value.Left, value.Top, value.Right, value.Bottom);

        public static Thickness ToThickness(RectF value) => new Thickness(value.Left, value.Top, value.Right, value.Bottom);

        public static bool FillH(inkControl control)
        {
            switch (control.Widget.GetParent())
            {
                case inkCanvasWidget:
                    return AnchorToFillH(control);
                case inkFlexWidget:
                case inkVerticalPanelWidget:
                    return HAlignToFill(control);
                case inkHorizontalPanelWidget:
                    return control.Widget.Layout.SizeRule == Enums.inkESizeRule.Stretch;
                default:
                    return false;
            }
        }

        public static bool FillV(inkControl control)
        {
            switch (control.Widget.GetParent())
            {
                case inkCanvasWidget:
                    return AnchorToFillV(control);
                case inkFlexWidget:
                case inkHorizontalPanelWidget:
                    return VAlignToFill(control);
                case inkVerticalPanelWidget:
                    return control.Widget.Layout.SizeRule == Enums.inkESizeRule.Stretch;
                default:
                    return false;
            }
        }

        public static bool AnchorLeft(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                    return true;
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                default:
                    return false;
            }
        }

        public static bool AnchorRight(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                    return true;
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.CenterFillVerticaly:
                default:
                    return false;
            }
        }

        public static bool AnchorCenterH(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.CenterFillVerticaly:
                    return true;
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                default:
                    return false;
            }
        }

        public static bool AnchorCenterV(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                    return true;
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.CenterFillVerticaly:
                default:
                    return false;
            }
        }

        public static double AnchorToX(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                    return 0;
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.CenterFillVerticaly:
                    return 0.5;
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                    return 1;
                default:
                    return 0;
            }
        }

        public static bool AnchorTop(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.TopRight:
                    return true;
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.RightFillVerticaly:
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.BottomRight:
                default:
                    return false;
            }
        }

        public static bool AnchorBottom(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.BottomRight:
                    return true;
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.RightFillVerticaly:
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.CenterRight:
                default:
                    return false;
            }
        }

        public static double AnchorToY(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.RightFillVerticaly:
                case Enums.inkEAnchor.Fill:
                    return 0;
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.CenterRight:
                    return 0.5;
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.BottomRight:
                    return 1;
                default:
                    return 0;
            }
        }

        public static bool AnchorToFillH(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.Fill:
                    return true;
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomRight:
                case Enums.inkEAnchor.RightFillVerticaly:
                default:
                    return false;
            }
        }

        public static bool AnchorToFillV(inkControl control)
        {
            switch ((Enums.inkEAnchor)control.Widget.Layout.Anchor)
            {
                case Enums.inkEAnchor.Fill:
                case Enums.inkEAnchor.LeftFillVerticaly:
                case Enums.inkEAnchor.CenterFillVerticaly:
                case Enums.inkEAnchor.RightFillVerticaly:
                    return true;
                case Enums.inkEAnchor.TopFillHorizontaly:
                case Enums.inkEAnchor.CenterFillHorizontaly:
                case Enums.inkEAnchor.BottomFillHorizontaly:
                case Enums.inkEAnchor.TopLeft:
                case Enums.inkEAnchor.CenterLeft:
                case Enums.inkEAnchor.BottomLeft:
                case Enums.inkEAnchor.TopCenter:
                case Enums.inkEAnchor.Centered:
                case Enums.inkEAnchor.BottomCenter:
                case Enums.inkEAnchor.TopRight:
                case Enums.inkEAnchor.CenterRight:
                case Enums.inkEAnchor.BottomRight:
                default:
                    return false;
            }
        }

        public static double HAlignToX(inkControl control)
        {
            switch ((Enums.inkEHorizontalAlign)control.Widget.Layout.HAlign)
            {
                case Enums.inkEHorizontalAlign.Left:
                case Enums.inkEHorizontalAlign.Fill:
                    return 0;
                case Enums.inkEHorizontalAlign.Center:
                    return 0.5;
                case Enums.inkEHorizontalAlign.Right:
                    return 1;
                default:
                    return 0;
            }
        }

        public static double VAlignToY(inkControl control)
        {
            switch ((Enums.inkEVerticalAlign)control.Widget.Layout.VAlign)
            {
                case Enums.inkEVerticalAlign.Top:
                case Enums.inkEVerticalAlign.Fill:
                    return 0;
                case Enums.inkEVerticalAlign.Center:
                    return 0.5;
                case Enums.inkEVerticalAlign.Bottom:
                    return 1;
                default:
                    return 0;
            }
        }

        public static bool HAlignToFill(inkControl control) => control.Widget.Layout.HAlign == Enums.inkEHorizontalAlign.Fill;

        public static bool VAlignToFill(inkControl control) => control.Widget.Layout.VAlign == Enums.inkEVerticalAlign.Fill;
    }
}
