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
    public class inkBasePanelControl : inkCompoundControl
    {
        public inkBasePanelWidget BasePanelWidget => Widget as inkBasePanelWidget;

        public inkBasePanelControl(inkBasePanelWidget widget) : base(widget)
        {

        }

        protected override Size MeasureCore(Size availableSize)
        {
            Size panelDesiredSize = new Size(Width, Height);

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;
                child.Measure(availableSize);
                if (Widget.FitToContent)
                {
                    if (Widget is inkHorizontalPanelWidget)
                    {
                        panelDesiredSize.Width += Math.Max(child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right, 0);
                        panelDesiredSize.Height = Math.Max(child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom, panelDesiredSize.Height);
                    }
                    else
                    {
                        panelDesiredSize.Width = Math.Max(child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right, panelDesiredSize.Width);
                        panelDesiredSize.Height += Math.Max(child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom, 0);
                    }
                }
            }

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.Width;
                var height = child.Height;

                if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                    width = panelDesiredSize.Width;
                if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                    height = panelDesiredSize.Height;

                child.Measure(new Size(width, height));

            }

            return panelDesiredSize;
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            var internalSize = finalRect.Size;
            internalSize.Width -= (InternalMargin.Right + InternalMargin.Left);
            internalSize.Height -= (InternalMargin.Bottom + InternalMargin.Top);

            double currentX = 0, currentY = 0;
            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.Width;
                var height = child.Height;

                if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                    width = internalSize.Width;
                if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                    height = internalSize.Height;

                child.Arrange(new System.Windows.Rect(
                    currentX + child.Widget.Layout.Margin.Left - InternalMargin.Left,
                    currentY + child.Widget.Layout.Margin.Top - InternalMargin.Top,
                    width, height));
                if (Widget is inkVerticalPanelWidget)
                {
                    currentY += height + child.Widget.Layout.Margin.Top;
                }
                else if (Widget is inkHorizontalPanelWidget)
                {
                    currentX += width + child.Widget.Layout.Margin.Left;
                }
            }

            base.ArrangeCore(finalRect);
        }
    }
}
