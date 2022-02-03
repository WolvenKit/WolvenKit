using System;
using System.Windows;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkCanvasControl : inkCompoundControl
    {
        public inkCanvasWidget CanvasWidget => Widget as inkCanvasWidget;

        public inkCanvasControl() : base()
        {

        }

        public inkCanvasControl(inkCanvasWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override Size MeasureCore(Size availableSize)
        {

            InternalMargin = new();

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                child.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

                //var width = child.DesiredSize.Width;
                //var height = child.DesiredSize.Height;
                //var x = AnchorToX(child) * width - child.Widget.Layout.AnchorPoint.X * width;
                //var y = AnchorToY(child) * height - child.Widget.Layout.AnchorPoint.Y * height;

                //if (AnchorLeft(child))
                //    x += child.Margin.Left;
                //else if (AnchorRight(child))
                //    x -= child.Margin.Right;
                //else
                //    x += (child.Margin.Left - child.Margin.Right);

                //if (AnchorTop(child))
                //    y += child.Margin.Top;
                //else if (AnchorBottom(child))
                //    y -= child.Margin.Bottom;
                //else
                //    y += (child.Margin.Top - child.Margin.Bottom);

                //InternalMargin.Left = Math.Min(x, InternalMargin.Left);
                //InternalMargin.Top = Math.Min(y, InternalMargin.Top);
                //InternalMargin.Right = Math.Min(Width - (x + width), InternalMargin.Right);
                //InternalMargin.Bottom = Math.Min(Height - (y + height), InternalMargin.Bottom);
                //InternalMargin.Right = Math.Min(Width - (x + width + child.Margin.Right), InternalMargin.Right);
                //InternalMargin.Bottom = Math.Min(Height - (y + height + child.Margin.Bottom), InternalMargin.Bottom);
            }

            //var internalSize = new Size(Width, Height);

            //internalSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            //internalSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            var internalSize = MeasureForDimensions(new Size(Width, Height), availableSize);

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                if (AnchorToFillH(child))
                {
                    width = Math.Max(internalSize.Width - child.Margin.Left - child.Margin.Right, 0);
                }

                if (AnchorToFillV(child))
                {
                    height = Math.Max(internalSize.Height - child.Margin.Top - child.Margin.Bottom, 0);
                }

                child.Measure(new Size(width, height));
            }

            return MeasureForDimensions(new Size(Width, Height), availableSize);
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            //var internalSize = finalRect.Size;
            //internalSize.Width -= (InternalMargin.Right + InternalMargin.Left);
            //internalSize.Height -= (InternalMargin.Bottom + InternalMargin.Top);

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                //if (AnchorToFillH(child))
                //    width = finalRect.Size.Width - child.Margin.Left - child.Margin.Right;
                //if (AnchorToFillV(child))
                //    height = finalRect.Size.Height - child.Margin.Top - child.Margin.Bottom;

                var x = AnchorToX(child) * finalRect.Size.Width;
                var y = AnchorToY(child) * finalRect.Size.Height;

                if (!AnchorToFillH(child))
                {
                    x -= child.Widget.Layout.AnchorPoint.X * width;
                }

                if (!AnchorToFillV(child))
                {
                    y -= child.Widget.Layout.AnchorPoint.Y * height;
                }

                if (AnchorLeft(child))
                {
                    x += child.Margin.Left;
                }
                else if (AnchorRight(child))
                {
                    x -= child.Margin.Right;
                }
                else if (AnchorCenterH(child))
                {
                    x += child.Margin.Left - child.Margin.Right;
                }
                else
                {
                    x += child.Margin.Left;
                }

                if (AnchorTop(child))
                {
                    y += child.Margin.Top;
                }
                else if (AnchorBottom(child))
                {
                    y -= child.Margin.Bottom;
                }
                else if (AnchorCenterV(child))
                {
                    y += child.Margin.Top - child.Margin.Bottom;
                }
                else
                {
                    y += child.Margin.Top;
                }

                //x -= InternalMargin.Left;
                //y -= InternalMargin.Top;

                child.Arrange(new Rect(x, y, width, height));
            }
            //finalRect.Size = internalSize;
            base.ArrangeCore(finalRect);
        }
    }
}
