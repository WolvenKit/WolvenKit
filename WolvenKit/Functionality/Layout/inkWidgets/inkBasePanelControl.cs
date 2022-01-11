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

            var totalUnits = 0D;
            var fixedSize = 0D;
            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;
                child.Measure(availableSize);

                var width = child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right;
                var height = child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom;

                if (Widget is inkHorizontalPanelWidget)
                {
                    panelDesiredSize.Width += Math.Max(width, 0);
                    panelDesiredSize.Height = Math.Max(height, panelDesiredSize.Height);

                    if (child.Widget.Layout.SizeRule.Value == Enums.inkESizeRule.Fixed)
                        fixedSize += width;
                    else
                        totalUnits += child.Widget.Layout.SizeCoefficient;
                }
                else
                {
                    panelDesiredSize.Width = Math.Max(width, panelDesiredSize.Width);
                    panelDesiredSize.Height += Math.Max(height, 0);

                    if (child.Widget.Layout.SizeRule.Value == Enums.inkESizeRule.Fixed)
                        fixedSize += height;
                    else
                        totalUnits += child.Widget.Layout.SizeCoefficient;
                }
            }

            if (!Widget.FitToContent)
            {
                panelDesiredSize = new Size(Width, Height);
            }

            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                    width = panelDesiredSize.Width - child.Margin.Left - child.Margin.Right;
                if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                    height = panelDesiredSize.Height - child.Margin.Top - child.Margin.Bottom;

                if (child.Widget.Layout.SizeRule.Value == Enums.inkESizeRule.Stretch)
                {
                    if (Widget is inkHorizontalPanelWidget)
                    {
                        width = child.Widget.Layout.SizeCoefficient * (panelDesiredSize.Width - fixedSize) / totalUnits;
                    }
                    else
                    {
                        height = child.Widget.Layout.SizeCoefficient * (panelDesiredSize.Height - fixedSize) / totalUnits;
                    }
                }

                child.Measure(new Size(Math.Max(width, 0), Math.Max(height, 0)));

            }

            if (Widget.FitToContent)
            {
                return panelDesiredSize;
            }
            else
            {
                return new Size(Width, Height);
            }

        }

        protected override void ArrangeCore(Rect finalRect)
        {
            //var internalSize = finalRect.Size;
            //internalSize.Width -= (InternalMargin.Right + InternalMargin.Left);
            //internalSize.Height -= (InternalMargin.Bottom + InternalMargin.Top);

            double currentX = 0, currentY = 0;
            foreach (inkControl child in children)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                //if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                //    width = Math.Max(finalRect.Size.Width - child.Margin.Left - child.Margin.Right, 0);
                //if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                //    height = Math.Max(finalRect.Size.Height - child.Margin.Top - child.Margin.Bottom, 0);

                var x = currentX + child.Margin.Left;
                var y = currentY + child.Margin.Top;

                if (Widget is inkVerticalPanelWidget)
                {
                    x += HAlignToX(child) * finalRect.Size.Width;
                }
                else
                {
                    y += VAlignToY(child) * finalRect.Size.Height;
                }

                child.Arrange(new Rect(x, y, width, height));

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
