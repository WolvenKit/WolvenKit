using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    [ContentProperty(nameof(Children))]
    public class inkCompoundControl : inkControl
    {
        public inkCompoundWidget CompoundWidget => Widget as inkCompoundWidget;

        public UIElementCollection Children { get; private set; }

        public Thickness InternalMargin = new();

        public Thickness ChildMargin => ToThickness(CompoundWidget.ChildMargin);

        public Brush Background { get; set; }

        public inkCompoundControl() : base()
        {
            Children = new UIElementCollection(this, null);
        }

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
                //if (Name == "Root")
                //{ 
                //    var im = BitmapFrame.Create(new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/Screenshot-1.jpg", UriKind.RelativeOrAbsolute));
                //    im.Freeze();
                //    Background = new ImageBrush()
                //    {
                //        ImageSource = im
                //    };
                //}
            }

            Children = new UIElementCollection(this, null);

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl(WidgetView);
                //if (Name == "Root")
                //{
                //    childControl.Effect = new DropShadowEffect()
                //    {
                //        BlurRadius = 3.6 * Width,
                //        ShadowDepth = 0.08 * Width
                //    };
                //}
                AddChild(childControl);
            }
        }

        public override void MouseEnterControl(object sender, MouseEventArgs e)
        {
            foreach (inkControl child in Children)
            {
                child.MouseEnterControl(sender, e);
            }

            base.MouseEnterControl(sender, e);
        }

        public override void MouseLeaveControl(object sender, MouseEventArgs e)
        {
            foreach (inkControl child in Children)
            {
                child.MouseLeaveControl(sender, e);
            }

            base.MouseLeaveControl(sender, e);
        }

        public override void MouseDownControl(object sender, MouseButtonEventArgs e)
        {
            foreach (inkControl child in Children)
            {
                child.MouseDownControl(sender, e);
            }

            base.MouseDownControl(sender, e);
        }

        public override void MouseUpControl(object sender, MouseButtonEventArgs e)
        {
            foreach (inkControl child in Children)
            {
                child.MouseUpControl(sender, e);
            }

            base.MouseUpControl(sender, e);
        }

        public void AddChild(inkControl element)
        {
            Children.Add(element);
            //AddVisualChild(element);
            element.Parent = this;
        }

        public void RemoveChild(inkControl element)
        {
            Children.Remove(element);
            element.Parent = null;
        }

        public inkControl GetChild(int index)
        {
            if (Children.Count <= index)
            {
                return null;
            }

            if (CompoundWidget.ChildOrder == Enums.inkEChildOrder.Forward)
            {
                return (inkControl)Children[index];
            }
            else
            {
                return (inkControl)Children[Children.Count - index - 1];
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
            foreach (inkControl child in Children)
            {
                child.RenderRecursive();
            }
            base.RenderRecursive();
        }
    }
}
