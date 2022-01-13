using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ReactiveUI;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
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

        public Brush Background { get; set; }

        public inkCompoundControl(inkCompoundWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            if (Widget.GetParent() == null)
            {
                //Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                WidgetView.WhenAnyValue(x => x.ViewModel.WidgetBackground).Subscribe(x => Background = new SolidColorBrush(x));
            }

            children = new UIElementCollection(this, null);

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl(WidgetView);
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
            if (Background != null)
            {
                dc.DrawRectangle(Background, null, new Rect(0, 0, RenderSize.Width, RenderSize.Height));
                dc.DrawRectangle(null, new Pen(new SolidColorBrush(Color.FromArgb(16, 255, 255, 255)), 0.5), new Rect(-0.5, -0.5, RenderSize.Width + 0.5, RenderSize.Height + 0.5));
            }
                //dc.DrawText(new FormattedText(Widget.Name + $" ({Widget.GetType().Name})", CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                //    new Typeface("Arial"), 8, new SolidColorBrush(Color.FromArgb(16, 255, 255, 255)), 1.0), new Point(0, -10));
        }
    }
}
