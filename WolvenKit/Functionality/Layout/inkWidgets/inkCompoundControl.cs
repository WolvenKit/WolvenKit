using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkCompoundControl : inkControl
    {
        public inkCompoundWidget CompoundWidget => Widget as inkCompoundWidget;

        protected readonly UIElementCollection children;

        public Thickness InternalMargin = new();

        public Thickness ChildMargin => ToThickness(CompoundWidget.ChildMargin);

        public inkCompoundControl(inkCompoundWidget widget) : base(widget)
        {
            children = new UIElementCollection(this, null);

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl();
                if (childControl != null)
                    children.Add(childControl);
            }
        }

        public void AddChild(UIElement element)
        {
            children.Add(element);
        }

        public void RemoveChild(UIElement element)
        {
            children.Remove(element);
        }

        protected override int VisualChildrenCount
        {
            get { return children.Count; }
        }

        protected override Visual GetVisualChild(int index)
        {
            return children[index];
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            // use for quick debugging & eventual debug mode
            //if (false)
            //{
            //    dc.DrawRectangle(new SolidColorBrush(Color.FromArgb(4, 255, 255, 255)), null, new Rect(0, 0, Width, Height));
            //    dc.DrawRectangle(null, new Pen(new SolidColorBrush(Color.FromArgb(16, 255, 255, 255)), 0.5), new Rect(0, 0, RenderSize.Width, RenderSize.Height));
            //    dc.DrawText(new FormattedText(Widget.Name + $" ({Widget.GetType().Name})", CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
            //        new Typeface("Arial"), 8, new SolidColorBrush(Color.FromArgb(16, 255, 255, 255)), 1.0), new Point(0, 1 + Height));
            //}
        }
    }
}
