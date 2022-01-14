using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkControl : UIElement
    {
        public inkWidget Widget => _widget;

        protected inkWidget _widget;

        public string Name { get; set; }

        public virtual double Width => Widget.Size.X;
        public virtual double Height => Widget.Size.Y;

        public Thickness Margin => ToThickness(Widget.Layout.Margin);

        public Dictionary<string, string> PropertyBindings = new();

        private List<string> _stateStack = new();

        public string LocalState => _stateStack.FirstOrDefault(defaultValue: null);

        public inkControl Parent { get; set; }

        public Color TintColor
        {
            get
            {
                SetCurrentValue(OpacityProperty, (double)WidgetOpacity);
                if (!PropertyBindings.ContainsKey("tintColor"))
                    goto NoOverride;

                var variant = GetProperty(PropertyBindings["tintColor"]);

                if (variant?.Value is HDRColor color)
                    return ToColor(color);

                NoOverride:
                return ToColor(Widget.TintColor);
            }
        }

        public Brush TintBrush => new SolidColorBrush(TintColor);

        public RDTWidgetView WidgetView;

        public string WidgetPath => Widget.Path;

        DrawingGroup backingStore = new DrawingGroup();

        public RotateTransform Rotation { get; set; } = new();

        public ScaleTransform Scale { get; set; } = new();

        public TranslateTransform Translation { get; set; } = new();

        //public static readonly DependencyProperty RotationProperty = DependencyProperty.Register(
        //    nameof(Rotation), typeof(RotateTransform),
        //    typeof(inkControl)
        //);

        //public RotateTransform Rotation
        //{
        //    get => (RotateTransform)GetValue(RotationProperty);
        //    set => SetValue(RotationProperty, value);
        //}

        public float WidgetOpacity
        {
            get
            {
                if (!PropertyBindings.ContainsKey("opacity"))
                    goto NoOverride;

                var variant = GetProperty(PropertyBindings["opacity"]);

                if (variant?.Value is CFloat opacity)
                    return opacity;

                NoOverride:
                return Widget.Opacity;
            }
        }

        public inkControl(inkWidget widget, RDTWidgetView widgetView) : base()
        {
            _widget = widget;
            Name = Widget.Name;
            WidgetView = widgetView;

            if (Widget.PropertyManager != null && Widget.PropertyManager.GetValue() is inkPropertyManager ipm)
            {
                foreach (inkPropertyBinding ipb in ipm.Bindings)
                {
                    PropertyBindings.Add(ipb.PropertyName, ipb.StylePath);
                    if (WidgetView.ViewModel.Bindings == null)
                        WidgetView.ViewModel.Bindings = new();
                    if (!WidgetView.ViewModel.Bindings.Contains(ipb.PropertyName))
                        WidgetView.ViewModel.Bindings.Add(ipb.PropertyName);
                }
            }

            //ToolTip = Widget.Name + $" ({Widget.GetType().Name})";

            // unhide the roots at least
            if (Widget.GetParent() is not null)
            {
                Opacity = WidgetOpacity;

                if (!Widget.Visible)
                {
                    //if (Widget.AffectsLayoutWhenHidden)
                    //{
                    //    Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    //    Visibility = Visibility.Collapsed;
                    //}
                }
                //ClipToBounds = false;
            }
            else
            {
                //ClipToBounds = true;
            }

            RenderTransformOrigin = ToPoint(Widget.RenderTransformPivot);

            Rotation.Angle = Widget.RenderTransform.Rotation;
            Scale.ScaleX = Widget.RenderTransform.Scale.X;
            Scale.ScaleY = Widget.RenderTransform.Scale.Y;
            Translation.X = Widget.RenderTransform.Translation.X;
            Translation.Y = Widget.RenderTransform.Translation.Y;

            RenderTransform = new TransformGroup()
            {
                Children = new TransformCollection(new List<System.Windows.Media.Transform>()
                {
                    Scale,
                    Translation,
                    new SkewTransform(Math.Atan(Widget.RenderTransform.Shear.X) * 180/Math.PI, Math.Atan(Widget.RenderTransform.Shear.Y) * 180/Math.PI),
                    Rotation
                })
            };

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
                _stateStack.Remove("Active");
            else
                _stateStack.Insert(0, "Active");
            Render();
        }

        public virtual void MouseUpControl(object sender, MouseButtonEventArgs e)
        {
            _stateStack.Remove("Press");
            Render();
        }

        public CVariant GetProperty(string propertyPath)
        {

            if (WidgetView.ViewModel == null)
                return null;

            if (WidgetView.ViewModel.CurrentStyleState == null)
                return null;

            if (WidgetView.ViewModel.CurrentTheme == null)
                return null;

            CVariant variant;
            foreach (var state in _stateStack)
            {
                variant = (CVariant)Application.Current.TryFindResource("CVariant/" + WidgetView.ViewModel.CurrentTheme + "/" + propertyPath + "#" + state);

                if (variant != null)
                    goto ValidVariant;
            }

            variant = (CVariant)Application.Current.TryFindResource("CVariant/" + WidgetView.ViewModel.CurrentTheme + "/" + propertyPath + "#" + WidgetView.ViewModel.CurrentStyleState);

            if (variant == null)
                return null;

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
            Render(drawingContext);
            drawingContext.Close();
        }

        protected virtual void Render(DrawingContext dc)
        {

        }

        public virtual void RenderRecursive() => Render();

        protected override Size MeasureCore(Size availableSize)
        {
            return MeasureForDimensions(new Size(Width, Height), availableSize);
        }

        protected Size MeasureForDimensions(Size dimensions, Size availableSize)
        {
            var size = dimensions;
            if (!Double.IsPositiveInfinity(availableSize.Width) && FillH(this))
                size.Width = availableSize.Width;
            if (!Double.IsPositiveInfinity(availableSize.Height) && FillV(this))
                size.Height = availableSize.Height;
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

        public static System.Windows.Point ToPoint(Vector2 v)
        {
            return new System.Windows.Point(v.X, v.Y);
        }

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

        public static Brush ToBrush(HDRColor hdr)
        {
            return new SolidColorBrush(ToColor(hdr));
        }

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

        public static System.Drawing.Brush ToDrawingBrush(HDRColor hdr)
        {
            return new System.Drawing.SolidBrush(ToDrawingColor(hdr));
        }

        public static Thickness AddToThickness(inkMargin m, Thickness t)
        {
            return new Thickness(m.Left + t.Left, m.Top + t.Top, m.Right + t.Right, m.Bottom + t.Bottom);
        }

        public static HorizontalAlignment ToHorizontalAlignment(CEnum<Enums.inkEHorizontalAlign> hAlign)
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

        public static VerticalAlignment ToVerticalAlignment(CEnum<Enums.inkEVerticalAlign> hAlign)
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

        public static Thickness ToThickness(inkMargin value)
        {
            return new Thickness(value.Left, value.Top, value.Right, value.Bottom);
        }

        public static Thickness ToThickness(RectF value)
        {
            return new Thickness(value.Left, value.Top, value.Right, value.Bottom);
        }

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
                    return control.Widget.Layout.SizeRule.Value == Enums.inkESizeRule.Stretch;
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
                    return control.Widget.Layout.SizeRule.Value == Enums.inkESizeRule.Stretch;
                default:
                    return false;
            }
        }

        public static bool AnchorLeft(inkControl control)
        {
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.Anchor.Value)
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
            switch (control.Widget.Layout.HAlign.Value)
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
            switch (control.Widget.Layout.VAlign.Value)
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

        public static bool HAlignToFill(inkControl control)
        {
            return control.Widget.Layout.HAlign.Value == Enums.inkEHorizontalAlign.Fill;
        }

        public static bool VAlignToFill(inkControl control)
        {
            return control.Widget.Layout.VAlign.Value == Enums.inkEVerticalAlign.Fill;
        }
    }
}
