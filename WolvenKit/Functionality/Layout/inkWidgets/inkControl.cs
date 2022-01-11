using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkControl : Panel
    {
        public inkWidget Widget;
        public inkControl ParentControl => Parent as inkControl;

        public inkControl(inkWidget widget) : base()
        {
            Widget = widget;
            Tag = Widget;

            //Background = Brushes.Transparent;

            //Background = ToBrush(Widget.TintColor);

            ToolTip = Widget.Name + $" ({Widget.GetType().Name})";
            Name = Widget.GetType().Name + "_" + Widget.Name.GetValue().Replace(" ", "_").Replace("-", "_").Replace("/", "_");

            Width = Widget.Size.X;
            Height = Widget.Size.Y;

            //Margin = ToThickness(Widget.Layout.Margin);

            //HorizontalAlignment = ToHorizontalAlignment(Widget.Layout.HAlign.Value);
            //VerticalAlignment = ToVerticalAlignment(Widget.Layout.VAlign.Value);

            //if (Widget.GetParent() is inkFlexWidget && (Widget is inkImageWidget iw3 && iw3.UseNineSliceScale))
            //{
            //    HorizontalAlignment = HorizontalAlignment.Stretch;
            //    VerticalAlignment = VerticalAlignment.Stretch;
            //}

            //if (Widget.GetParent() is inkCanvasWidget)
            //{
            //    //if (widget is inkBasePanelWidget || widget is inkFlexWidget)
            //    //{
            //    //    Canvas.SetLeft(element, left);
            //    //    Canvas.SetRight(element, right);
            //    //    Canvas.SetTop(element, top);
            //    //    Canvas.SetBottom(element, bottom);
            //    //}
            //    //else
            //    //{
            //    if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomLeft ||
            //         Widget.Layout.Anchor.Value == Enums.inkEAnchor.LeftFillVerticaly ||
            //         Widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterLeft ||
            //         Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopLeft
            //         )
            //    {
            //        Canvas.SetLeft(this, -Width * Widget.Layout.AnchorPoint.X + left);
            //    }
            //    else if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomRight ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.RightFillVerticaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterRight ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopRight
            //        )
            //    {
            //        Canvas.SetRight(this, -Width * (1.0 - Widget.Layout.AnchorPoint.X) + right);
            //    }
            //    else if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.Fill ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterFillHorizontaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomFillHorizontaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopFillHorizontaly
            //        )
            //    {
            //        Canvas.SetLeft(this, left);
            //        Canvas.SetRight(this, right);
            //    }
            //    else
            //    {
            //        Canvas.SetLeft(this, ParentControl.Width / 2 - Width * Widget.Layout.AnchorPoint.X + left);
            //    }

            //    if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopCenter ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopFillHorizontaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopLeft ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.TopRight
            //        )
            //    {
            //        Canvas.SetTop(this, -Height * Widget.Layout.AnchorPoint.Y + top);
            //    }
            //    else if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomCenter ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomFillHorizontaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomLeft ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.BottomRight
            //        )
            //    {
            //        Canvas.SetBottom(this, -Height * (1.0 - Widget.Layout.AnchorPoint.Y) + bottom);
            //    }
            //    else if (Widget.Layout.Anchor.Value == Enums.inkEAnchor.Fill ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.CenterFillVerticaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.LeftFillVerticaly ||
            //        Widget.Layout.Anchor.Value == Enums.inkEAnchor.RightFillVerticaly
            //        )
            //    {
            //        Canvas.SetBottom(this, bottom);
            //        Canvas.SetTop(this, top);
            //    }
            //    else
            //    {
            //        Canvas.SetTop(this, ParentControl.Height / 2 - Height * Widget.Layout.AnchorPoint.Y + top);
            //    }
            //    //}
            //}

            if (Widget.GetParent() is not null)
                Opacity = Widget.Opacity;
            else
                HorizontalAlignment = HorizontalAlignment.Left;

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

            RenderTransformOrigin = ToPoint(Widget.RenderTransformPivot);
            RenderTransform = new TransformGroup()
            {
                Children = new TransformCollection(new List<System.Windows.Media.Transform>()
                {
                    new ScaleTransform(Widget.RenderTransform.Scale.X, Widget.RenderTransform.Scale.Y),
                    new TranslateTransform(Widget.RenderTransform.Translation.X, Widget.RenderTransform.Translation.Y),
                    new SkewTransform(Math.Atan(Widget.RenderTransform.Shear.X) * 180/Math.PI, Math.Atan(Widget.RenderTransform.Shear.Y) * 180/Math.PI),
                    new RotateTransform(Widget.RenderTransform.Rotation)
                })
            };
        }

        //protected override void OnRender(DrawingContext dc)
        //{
        //    base.OnRender(dc);
        //}

        protected override Size MeasureOverride(Size availableSize)
        {
            //return base.MeasureOverride(availableSize);
            var size = new Size(Width, Height);
            //size = availableSize;
            if ((AnchorToFillH(this) && Widget.GetParent() is inkCanvasWidget) || (HAlignToFill(this) && Widget.GetParent() is not inkCanvasWidget))
                size.Width = availableSize.Width;
            if ((AnchorToFillV(this) && Widget.GetParent() is inkCanvasWidget) || (VAlignToFill(this) && Widget.GetParent() is not inkCanvasWidget))
                size.Height = availableSize.Height;
            return base.MeasureOverride(size);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var size = new Size(Width, Height);
            //size = finalSize;
            if ((AnchorToFillH(this) && Widget.GetParent() is inkCanvasWidget) || (HAlignToFill(this) && Widget.GetParent() is not inkCanvasWidget))
                size.Width = finalSize.Width;
            if ((AnchorToFillV(this) && Widget.GetParent() is inkCanvasWidget) || (VAlignToFill(this) && Widget.GetParent() is not inkCanvasWidget))
                size.Height = finalSize.Height;
            return base.ArrangeOverride(size);
        }

        // Override the default Measure method of Panel
        //protected override Size MeasureOverride(Size availableSize)
        //{
        //    Size panelDesiredSize = new Size();

        //    // In our example, we just have one child.
        //    // Report that our panel requires just the size of its only child.
        //    foreach (UIElement child in InternalChildren)
        //    {
        //        child.Measure(availableSize);
        //        panelDesiredSize = child.DesiredSize;
        //    }

        //    return panelDesiredSize;
        //}
        //protected override Size ArrangeOverride(Size finalSize)
        //{
        //    foreach (UIElement child in InternalChildren)
        //    {
        //        double x = 50;
        //        double y = 50;

        //        child.Arrange(new System.Windows.Rect(new System.Windows.Point(x, y), child.DesiredSize));
        //    }
        //    return finalSize; // Returns the final Arranged size
        //}

        public static System.Windows.Point ToPoint(Vector2 v)
        {
            return new System.Windows.Point(v.X, v.Y);
        }

        public static Color ToColor(HDRColor hdr)
        {
            return Color.FromArgb((byte)(hdr.Alpha * 255), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
        }

        public static Brush ToBrush(HDRColor hdr)
        {
            return new SolidColorBrush(ToColor(hdr));
        }

        public static System.Drawing.Color ToDrawingColor(HDRColor hdr, float alpha = 1)
        {
            return System.Drawing.Color.FromArgb((byte)(hdr.Alpha * 255 * alpha), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
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
