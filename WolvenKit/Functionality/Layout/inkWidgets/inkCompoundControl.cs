using System;
using System.Windows;
using System.Windows.Media;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkCompoundControl : inkControl
    {
        public inkCompoundWidget CompoundWidget => Widget as inkCompoundWidget;
        //public List<inkControl> Children = new();

        public Thickness InternalMargin = new();

        public inkCompoundControl(inkCompoundWidget widget) : base(widget)
        {
            Background = new SolidColorBrush(Color.FromArgb(4, 255, 255, 255));

            foreach (var child in CompoundWidget.GetChildren())
            {
                var childControl = child.CreateControl();
                if (childControl != null)
                    InternalChildren.Add(childControl);
            }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            //Size panelDesiredSize = new Size(Width, Height);
            var internalSize = availableSize;

            if (Widget is inkCanvasWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    child.Measure(internalSize);

                    var width = child.DesiredSize.Width;
                    var height = child.DesiredSize.Height;
                    var x = AnchorToX(child) * width - child.Widget.Layout.AnchorPoint.X * width;
                    var y = AnchorToY(child) * height - child.Widget.Layout.AnchorPoint.Y * height;

                    if (AnchorToX(child) == 0)
                        x += child.Widget.Layout.Margin.Left;
                    else if (AnchorToX(child) == 1)
                        x -= child.Widget.Layout.Margin.Right;
                    else
                        x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;

                    if (AnchorToY(child) == 0)
                        y += child.Widget.Layout.Margin.Top;
                    else if (AnchorToY(child) == 1)
                        y -= child.Widget.Layout.Margin.Bottom;
                    else
                        y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                    //panelDesiredSize.Width = Math.Max(Math.Max(x, 0) + width, panelDesiredSize.Width);
                    //panelDesiredSize.Height = Math.Max(Math.Max(y, 0) + height, panelDesiredSize.Height);

                    InternalMargin.Left = Math.Min(x, InternalMargin.Left);
                    InternalMargin.Top = Math.Min(y, InternalMargin.Top);
                    InternalMargin.Right = Math.Min(Width - (x + width), InternalMargin.Right);
                    InternalMargin.Bottom = Math.Min(Height - (y + height), InternalMargin.Bottom);
                }
            }
            else if (Widget is inkFlexWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    child.Measure(internalSize);

                    //var width = child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right;
                    //var height = child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom;

                    var width = child.DesiredSize.Width;
                    var height = child.DesiredSize.Height;
                    var x = AnchorToX(child) * width;
                    var y = AnchorToY(child) * height;

                    if (!HAlignToFill(child))
                        x -= child.Widget.Layout.AnchorPoint.X * width;
                    if (!VAlignToFill(child))
                        y -= child.Widget.Layout.AnchorPoint.Y * height;

                    //if (AnchorToX(child) == 0)
                    //    x += child.Widget.Layout.Margin.Left;
                    //else if (AnchorToX(child) == 1)
                    //    x -= child.Widget.Layout.Margin.Right;
                    //else
                        x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;

                    //if (AnchorToY(child) == 0)
                    //    y += child.Widget.Layout.Margin.Top;
                    //else if (AnchorToY(child) == 1)
                    //    y -= child.Widget.Layout.Margin.Bottom;
                    //else
                        y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                    //panelDesiredSize.Width = Math.Max(x + width, panelDesiredSize.Width);
                    //panelDesiredSize.Height = Math.Max(y + height, panelDesiredSize.Height);

                    InternalMargin.Left = Math.Min(x, InternalMargin.Left);
                    InternalMargin.Top = Math.Min(y, InternalMargin.Top);
                    InternalMargin.Right = Math.Min(Width - (x + width + child.Widget.Layout.Margin.Right), InternalMargin.Right);
                    InternalMargin.Bottom = Math.Min(Height - (y + height + child.Widget.Layout.Margin.Bottom), InternalMargin.Bottom);
                }
            }
            else if (Widget is inkHorizontalPanelWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;
                    child.Measure(internalSize);
                    //if (Widget.FitToContent)
                    //{
                    //    panelDesiredSize.Width += Math.Max(child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right, 0);
                    //    panelDesiredSize.Height = Math.Max(child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom, panelDesiredSize.Height);
                    //}
                }
            }
            else if (Widget is inkVerticalPanelWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;
                    child.Measure(internalSize);
                    //if (Widget.FitToContent)
                    //{
                    //    panelDesiredSize.Width = Math.Max(child.DesiredSize.Width + child.Widget.Layout.Margin.Left + child.Widget.Layout.Margin.Right, panelDesiredSize.Width);
                    //    panelDesiredSize.Height += Math.Max(child.DesiredSize.Height + child.Widget.Layout.Margin.Top + child.Widget.Layout.Margin.Bottom, 0);
                    //}
                }
            }
            else
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    child.Measure(internalSize);
                }
            }

            internalSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            internalSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            foreach (inkControl child in InternalChildren)
            {
                if (child.Visibility == Visibility.Collapsed)
                    continue;
                child.Measure(internalSize);
            }

            //return new Size(Width - (InternalMargin.Left + InternalMargin.Right), Height - (InternalMargin.Top + InternalMargin.Bottom));


            //var size = new Size(Width, Height);
            //if (AnchorToFillH(this))
            //    size.Width = availableSize.Width;
            //if (AnchorToFillV(this))
            //    size.Height = availableSize.Height;

            //if (Widget.GetParent() == null)
            //{
            //    Width -= (InternalMargin.Left + InternalMargin.Right);
            //    Height -= (InternalMargin.Top + InternalMargin.Bottom);
            //    SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            //}
            //availableSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            //availableSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            //return internalSize;
            return internalSize;

            //return panelDesiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var internalSize = finalSize;
            internalSize.Width -= (InternalMargin.Right + InternalMargin.Left);
            internalSize.Height -= (InternalMargin.Bottom + InternalMargin.Top);

            if (Widget is inkCanvasWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    //if (child is inkCompoundControl cc)
                    //{
                    //    finalSize.Width -= cc.InternalMargin.Right;
                    //    finalSize.Height -= cc.InternalMargin.Bottom;
                    //}


                    //child.Measure(new Size(5000, 5000));
                    //child.Measure(internalSize);

                    var width = child.Width;
                    var height = child.Height;

                    //var width = 500;
                    //var height = 500;

                    //if (AnchorToFillH(child))
                    //child.Width = internalSize.Width;
                    //if (AnchorToFillV(child))
                    //child.Height = internalSize.Height;

                    // should be managed from child's measure & desiresize
                    //if (AnchorToFillH(child))
                    //    width = internalSize.Width;
                    //if (AnchorToFillV(child))
                    //    height = internalSize.Height;
                    var x = AnchorToX(child) * finalSize.Width - child.Widget.Layout.AnchorPoint.X * width;
                    var y = AnchorToY(child) * finalSize.Height - child.Widget.Layout.AnchorPoint.Y * height;

                    //if (AnchorToX(child) == 0)
                    //    x += child.Widget.Layout.Margin.Left;
                    //else if (AnchorToX(child) == 1)
                    //    x -= child.Widget.Layout.Margin.Right;
                    //else
                    x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;

                    //if (AnchorToY(child) == 0)
                    //    y += child.Widget.Layout.Margin.Top;
                    //else if (AnchorToY(child) == 1)
                    //    y -= child.Widget.Layout.Margin.Bottom;
                    //else
                    y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                    //x += InternalMargin.Left;
                    //y += InternalMargin.Top;

                    child.Arrange(new System.Windows.Rect(x, y, width, height));
                }
            }
            else if (Widget is inkFlexWidget)
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    //if (HAlignToFill(child))
                    //    child.Width = internalSize.Width;
                    //if (VAlignToFill(child))
                    //    child.Height = internalSize.Height;

                    //child.Measure(internalSize);

                    var width = child.Width;
                    var height = child.Height;

                    //if (HAlignToFill(child))
                    //    width = internalSize.Width;
                    //if (VAlignToFill(child))
                    //    height = internalSize.Height;

                    var x = AnchorToX(child) * finalSize.Width;
                    var y = AnchorToY(child) * finalSize.Height;

                    if (!HAlignToFill(child))
                        x -= child.Widget.Layout.AnchorPoint.X * width;

                    if (!VAlignToFill(child))
                        y -= child.Widget.Layout.AnchorPoint.Y * height;

                    //if (AnchorToX(child) == 0)
                    //    x += child.Widget.Layout.Margin.Left;
                    //else if (AnchorToX(child) == 1)
                    //    x -= child.Widget.Layout.Margin.Right;
                    //else
                    x += child.Widget.Layout.Margin.Left - child.Widget.Layout.Margin.Right;

                    //if (AnchorToY(child) == 0)
                    //    y += child.Widget.Layout.Margin.Top;
                    //else if (AnchorToY(child) == 1)
                    //    y -= child.Widget.Layout.Margin.Bottom;
                    //else
                    y += child.Widget.Layout.Margin.Top - child.Widget.Layout.Margin.Bottom;

                    //x += InternalMargin.Left;
                    //y += InternalMargin.Top;

                    child.Arrange(new System.Windows.Rect(x, y, width, height));
                }
            }
            else if (Widget is inkBasePanelWidget)
            {
                double currentX = 0, currentY = 0;
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    //if (HAlignToFill(child) && Widget is inkVerticalPanelWidget)
                    //    child.Width = internalSize.Width;
                    //if (VAlignToFill(child) && Widget is inkHorizontalPanelWidget)
                    //    child.Height = internalSize.Height;

                    //child.Measure(internalSize);

                    var width = child.DesiredSize.Width;
                    var height = child.DesiredSize.Height;
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
            }
            else
            {
                foreach (inkControl child in InternalChildren)
                {
                    if (child.Visibility == Visibility.Collapsed)
                        continue;

                    child.Measure(internalSize);
                }
            }

            //var size = new Size(Width, Height);
            //if (AnchorToFillH(this))
            //    size.Width = finalSize.Width;
            //if (AnchorToFillV(this))
            //    size.Height = finalSize.Height;
            //return size;
            //return finalSize;
            return base.ArrangeOverride(finalSize);
        }
    }
}
