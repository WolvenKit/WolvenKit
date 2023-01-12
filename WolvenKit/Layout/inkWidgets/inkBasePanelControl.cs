using System;
using System.Windows;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkBasePanelControl : inkCompoundControl
    {
        public inkBasePanelWidget BasePanelWidget => Widget as inkBasePanelWidget;

        public inkBasePanelControl(inkBasePanelWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override Size MeasureCore(Size availableSize)
        {
            var totalUnits = 0D;
            var fixedSize = 0D;
            var panelContentSize = new Size(0, 0);
            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                child.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

                var width = child.DesiredSize.Width + child.Margin.Left + child.Margin.Right;
                var height = child.DesiredSize.Height + child.Margin.Top + child.Margin.Bottom;

                if (Widget is inkHorizontalPanelWidget)
                {
                    panelContentSize.Width += Math.Max(width, 0);
                    panelContentSize.Height = Math.Max(height, panelContentSize.Height);

                    if (child.Widget.Layout.SizeRule == Enums.inkESizeRule.Fixed)
                    {
                        fixedSize += width;
                    }
                    else
                    {
                        totalUnits += child.Widget.Layout.SizeCoefficient;
                    }
                }
                else
                {
                    panelContentSize.Width = Math.Max(width, panelContentSize.Width);
                    panelContentSize.Height += Math.Max(height, 0);

                    if (child.Widget.Layout.SizeRule == Enums.inkESizeRule.Fixed)
                    {
                        fixedSize += height;
                    }
                    else
                    {
                        totalUnits += child.Widget.Layout.SizeCoefficient;
                    }
                }
            }

            var panelDesiredSize = MeasureForDimensions(new Size(Width, Height), availableSize);

            if (Widget.FitToContent)
            {
                panelContentSize.Width += Math.Max(ChildMargin.Left + ChildMargin.Right, 0);
                panelContentSize.Height += Math.Max(ChildMargin.Top + ChildMargin.Bottom, 0);
                panelDesiredSize = MeasureForDimensions(panelContentSize, availableSize);
            }

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                {
                    width = panelDesiredSize.Width - child.Margin.Left - child.Margin.Right - ChildMargin.Left - ChildMargin.Right;
                }

                if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                {
                    height = panelDesiredSize.Height - child.Margin.Top - child.Margin.Bottom - ChildMargin.Top - ChildMargin.Bottom;
                }

                if (child.Widget.Layout.SizeRule == Enums.inkESizeRule.Stretch)
                {
                    if (Widget is inkHorizontalPanelWidget)
                    {
                        width = (child.Widget.Layout.SizeCoefficient * (panelDesiredSize.Width - fixedSize - ChildMargin.Left - ChildMargin.Right) / totalUnits) - child.Margin.Left - child.Margin.Right;
                    }
                    else
                    {
                        height = (child.Widget.Layout.SizeCoefficient * (panelDesiredSize.Height - fixedSize - ChildMargin.Top - ChildMargin.Bottom) / totalUnits) - child.Margin.Top - child.Margin.Bottom;
                    }
                }

                child.Measure(new Size(Math.Max(width, 0), Math.Max(height, 0)));

            }

            return MeasureForDimensions(panelDesiredSize, availableSize);

        }

        protected override void ArrangeCore(Rect finalRect)
        {
            double currentX = 0, currentY = 0;
            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                var x = currentX;
                var y = currentY;

                if (Widget is inkVerticalPanelWidget)
                {
                    switch ((Enums.inkEHorizontalAlign)child.Widget.Layout.HAlign)
                    {
                        case Enums.inkEHorizontalAlign.Fill:
                            x += child.Margin.Left;
                            break;
                        case Enums.inkEHorizontalAlign.Left:
                            x += child.Margin.Left;
                            break;
                        case Enums.inkEHorizontalAlign.Right:
                            x += finalRect.Size.Width - width - child.Margin.Right;
                            break;
                        case Enums.inkEHorizontalAlign.Center:
                            x += ((finalRect.Size.Width - width) / 2) + child.Margin.Left - child.Margin.Right;
                            break;
                        default:
                            break;
                    }

                    y += child.Margin.Top;
                }
                else
                {
                    switch ((Enums.inkEVerticalAlign)child.Widget.Layout.VAlign)
                    {
                        case Enums.inkEVerticalAlign.Fill:
                            y += child.Margin.Top;
                            break;
                        case Enums.inkEVerticalAlign.Top:
                            y += child.Margin.Top;
                            break;
                        case Enums.inkEVerticalAlign.Bottom:
                            y += finalRect.Size.Height - height - child.Margin.Bottom;
                            break;
                        case Enums.inkEVerticalAlign.Center:
                            y += ((finalRect.Size.Height - height) / 2) + child.Margin.Top - child.Margin.Bottom;
                            break;
                        default:
                            break;
                    }

                    x += child.Margin.Left;
                }


                //if (child.Widget.Layout.HAlign.Value == Enums.inkEHorizontalAlign.Center)
                //    x -= child.Widget.Layout.AnchorPoint.X * width;
                //if (child.Widget.Layout.VAlign.Value == Enums.inkEVerticalAlign.Center)
                //    y -= child.Widget.Layout.AnchorPoint.Y * height;

                //if (child.Widget.Layout.HAlign.Value == Enums.inkEHorizontalAlign.Left)
                //    x += child.Margin.Left;
                //else if (child.Widget.Layout.HAlign.Value == Enums.inkEHorizontalAlign.Right)
                //    x -= child.Margin.Right;
                //else
                //    x += (child.Margin.Left - child.Margin.Right);

                //if (child.Widget.Layout.VAlign.Value == Enums.inkEVerticalAlign.Top)
                //    y += child.Margin.Top;
                //else if (child.Widget.Layout.VAlign.Value == Enums.inkEVerticalAlign.Bottom)
                //    y -= child.Margin.Bottom;
                //else
                //    y += (child.Margin.Top - child.Margin.Bottom);


                child.Arrange(new Rect(ChildMargin.Left + x, ChildMargin.Top + y, width, height));

                if (Widget is inkVerticalPanelWidget)
                {
                    currentY = y + height + child.Margin.Bottom;
                }
                else if (Widget is inkHorizontalPanelWidget)
                {
                    currentX = x + width + child.Margin.Right;
                }
            }

            base.ArrangeCore(finalRect);
        }
    }
}
