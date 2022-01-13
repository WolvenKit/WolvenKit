using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
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
                //Effect = new BlurEffect()
                //{
                //    Radius = 20
                //};
            }

            children = new UIElementCollection(this, null);

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl(WidgetView);
                if (childControl != null)
                    children.Add(childControl);
            }
        }

        public override void MouseEnterControl(object sender, MouseEventArgs e)
        {
            foreach (inkControl child in children)
                child.MouseEnterControl(sender, e);
            base.MouseEnterControl(sender, e);
        }

        public override void MouseLeaveControl(object sender, MouseEventArgs e)
        {
            foreach (inkControl child in children)
                child.MouseLeaveControl(sender, e);
            base.MouseLeaveControl(sender, e);
        }

        public override void MouseDownControl(object sender, MouseButtonEventArgs e)
        {
            foreach (inkControl child in children)
                child.MouseDownControl(sender, e);
            base.MouseDownControl(sender, e);
        }

        public override void MouseUpControl(object sender, MouseButtonEventArgs e)
        {
            foreach (inkControl child in children)
                child.MouseUpControl(sender, e);
            base.MouseUpControl(sender, e);
        }

        public void AddChild(inkControl element)
        {
            children.Add(element);
            element.Parent = this;
        }

        public void RemoveChild(inkControl element)
        {
            children.Remove(element);
            element.Parent = null;
        }

        protected override int VisualChildrenCount
        {
            get { return children?.Count ?? 0; }
        }

        protected override Visual GetVisualChild(int index)
        {
            return children[index];
        }

        protected override void Render(DrawingContext dc)
        {
            if (Background != null)
            {
                dc.DrawRectangle(Background, null, new Rect(0, 0, RenderSize.Width, RenderSize.Height));
                dc.DrawRectangle(null, new Pen(new SolidColorBrush(Color.FromArgb(16, 255, 255, 255)), 0.5), new Rect(-0.5, -0.5, RenderSize.Width + 0.5, RenderSize.Height + 0.5));
            }
        }

        public override void RenderRecursive()
        {
            foreach (inkControl child in children)
            {
                child.RenderRecursive();
            }
            base.RenderRecursive();
        }
    }
}
