using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkFlexControl : inkCompoundControl
    {
        public inkFlexWidget FlexWidget => Widget as inkFlexWidget;

        public inkFlexControl(inkFlexWidget widget) : base(widget)
        {

        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var internalSize = availableSize;

            foreach (inkControl child in InternalChildren)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                child.Measure(internalSize);

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                var x = AnchorToX(child) * width;
                var y = AnchorToY(child) * height;

                if (!HAlignToFill(child))
                    x -= child.Widget.Layout.AnchorPoint.X * width;

                if (!VAlignToFill(child))
                    y -= child.Widget.Layout.AnchorPoint.Y * height;

                x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;
                y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                InternalMargin.Left = Math.Min(x, InternalMargin.Left);
                InternalMargin.Top = Math.Min(y, InternalMargin.Top);
                //InternalMargin.Right = Math.Min(Width - (x + width), InternalMargin.Right);
                //InternalMargin.Bottom = Math.Min(Height - (y + height), InternalMargin.Bottom);
                InternalMargin.Right = Math.Min(Width - (x + width + child.Widget.Layout.Margin.Right), InternalMargin.Right);
                InternalMargin.Bottom = Math.Min(Height - (y + height + child.Widget.Layout.Margin.Bottom), InternalMargin.Bottom);
            }

            internalSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            internalSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            foreach (inkControl child in InternalChildren)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;
                child.Measure(internalSize);

                if (HAlignToFill(child))
                    child.Width = internalSize.Width;
                if (VAlignToFill(child))
                    child.Height = internalSize.Height;
            }

            return availableSize;
        }
    }
}
