using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.RED4.Types;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkCanvasControl : inkCompoundControl
    {
        public inkCanvasWidget CanvasWidget => Widget as inkCanvasWidget;

        public inkCanvasControl(inkCanvasWidget widget) : base(widget)
        {

        }

        protected override Size MeasureCore(Size availableSize)
        {
            var internalSize = new Size(Width, Height);

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                child.Measure(internalSize);

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;
                var x = AnchorToX(child) * width - child.Widget.Layout.AnchorPoint.X * width;
                var y = AnchorToY(child) * height - child.Widget.Layout.AnchorPoint.Y * height;

                //x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;
                //y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                if (AnchorToX(child) == 0)
                    x += child.Widget.Layout.Margin.Left;
                else if (AnchorToX(child) == 1)
                    x -= child.Widget.Layout.Margin.Right;
                else
                    x += (child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right);

                if (AnchorToY(child) == 0)
                    y += child.Widget.Layout.Margin.Top;
                else if (AnchorToY(child) == 1)
                    y -= child.Widget.Layout.Margin.Bottom;
                else
                    y += (child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom);

                InternalMargin.Left = Math.Min(x, InternalMargin.Left);
                InternalMargin.Top = Math.Min(y, InternalMargin.Top);
                InternalMargin.Right = Math.Min(Width - (x + width), InternalMargin.Right);
                InternalMargin.Bottom = Math.Min(Height - (y + height), InternalMargin.Bottom);
            }

            internalSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            internalSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.Width;
                var height = child.Height;

                if (AnchorToFillH(child))
                    width = internalSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right;
                if (AnchorToFillV(child))
                    height = internalSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom;

                child.Measure(new Size(width, height));
            }

            return internalSize;
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            var internalSize = finalRect.Size;
            internalSize.Width -= (InternalMargin.Right + InternalMargin.Left);
            internalSize.Height -= (InternalMargin.Bottom + InternalMargin.Top);

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.Width;
                var height = child.Height;

                if (AnchorToFillH(child))
                    width = internalSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right;
                if (AnchorToFillV(child))
                    height = internalSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom;

                var x = AnchorToX(child) * finalRect.Size.Width - child.Widget.Layout.AnchorPoint.X * width;
                var y = AnchorToY(child) * finalRect.Size.Height - child.Widget.Layout.AnchorPoint.Y * height;

                if (AnchorToX(child) == 0)
                    x += child.Widget.Layout.Margin.Left;
                else if (AnchorToX(child) == 1)
                    x -= child.Widget.Layout.Margin.Right;
                else
                    x += (child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right);

                if (AnchorToY(child) == 0)
                    y += child.Widget.Layout.Margin.Top;
                else if (AnchorToY(child) == 1)
                    y -= child.Widget.Layout.Margin.Bottom;
                else
                    y += (child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom);

                //x += InternalMargin.Left;
                //y += InternalMargin.Top;

                child.Arrange(new System.Windows.Rect(x, y, width, height));
            }

            base.ArrangeCore(finalRect);
        }
    }
}
