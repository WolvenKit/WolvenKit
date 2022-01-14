using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkCompoundControl : inkControl
    {
        public inkCompoundWidget CompoundWidget => Widget as inkCompoundWidget;

        public List<inkControl> Children { get; private set; } = new();

        public Thickness InternalMargin = new();

        public Thickness ChildMargin => ToThickness(CompoundWidget.ChildMargin);

        public Brush Background { get; set; }

        public inkCompoundControl(inkCompoundWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            if (Widget.GetParent() == null)
            {
                //Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                //WidgetView.WhenAnyValue(x => x.ViewModel.WidgetBackground).Subscribe(x => Background = new SolidColorBrush(x));
                //Effect = new BlurEffect()
                //{
                //    Radius = 20
                //};
            }

            //Children = new UIElementCollection(this, null);

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl(WidgetView);
                Children.Add(childControl);
            }
        }

        public override void MouseEnterControl(object sender, MouseEventArgs e)
        {
            foreach (var child in Children)
            {
                child.MouseEnterControl(sender, e);
            }

            base.MouseEnterControl(sender, e);
        }

        public override void MouseLeaveControl(object sender, MouseEventArgs e)
        {
            foreach (var child in Children)
            {
                child.MouseLeaveControl(sender, e);
            }

            base.MouseLeaveControl(sender, e);
        }

        public override void MouseDownControl(object sender, MouseButtonEventArgs e)
        {
            foreach (var child in Children)
            {
                child.MouseDownControl(sender, e);
            }

            base.MouseDownControl(sender, e);
        }

        public override void MouseUpControl(object sender, MouseButtonEventArgs e)
        {
            foreach (var child in Children)
            {
                child.MouseUpControl(sender, e);
            }

            base.MouseUpControl(sender, e);
        }

        public void AddChild(inkControl element)
        {
            Children.Add(element);
            AddVisualChild(element);
            element.Parent = this;
        }

        public void RemoveChild(inkControl element)
        {
            if (Children.Remove(element))
            {
                element.Parent = null;
                RemoveVisualChild(element);
            }
        }

        public inkControl GetChild(int index)
        {
            if (Children.Count <= index)
            {
                return null;
            }

            if (CompoundWidget.ChildOrder.Value == Enums.inkEChildOrder.Forward)
            {
                return Children[index];
            }
            else
            {
                return Children[Children.Count - index - 1];
            }
        }

        protected override int VisualChildrenCount => Children?.Count ?? 0;

        protected override Visual GetVisualChild(int index) => Children[index];

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
            foreach (var child in Children)
            {
                child.RenderRecursive();
            }
            base.RenderRecursive();
        }
    }
}
