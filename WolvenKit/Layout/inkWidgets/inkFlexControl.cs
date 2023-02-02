using System;
using System.Windows;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkFlexControl : inkCompoundControl
    {
        public inkFlexWidget FlexWidget => Widget as inkFlexWidget;

        public inkFlexControl() : base()
        {

        }

        public inkFlexControl(inkFlexWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override Size MeasureCore(Size availableSize)
        {

            //InternalMargin = new();

            var contentSize = new Size();

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                child.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                contentSize.Width = Math.Max(width + child.Margin.Left + child.Margin.Right, contentSize.Width);
                contentSize.Height = Math.Max(height + child.Margin.Top + child.Margin.Bottom, contentSize.Height);

                //if (!HAlignToFill(child))
                //{
                //InternalMargin.Left = Math.Min(child.Margin.Left, InternalMargin.Left);
                //InternalMargin.Right = Math.Min(Width - (width + Math.Max(child.Margin.Left, 0) + Math.Max(child.Margin.Right, 0)), InternalMargin.Right);
                //InternalMargin.Right = Math.Min(Width - (x + width + child.Margin.Right), InternalMargin.Right);
                //}
                //if (!VAlignToFill(child))
                //{
                //InternalMargin.Top = Math.Min(child.Margin.Top, InternalMargin.Top);
                //InternalMargin.Bottom = Math.Min(Height - (height + Math.Max(child.Margin.Top, 0) + Math.Max(child.Margin.Bottom, 0)), InternalMargin.Bottom);
                //InternalMargin.Bottom = Math.Min(Height - (y + height + child.Margin.Bottom), InternalMargin.Bottom);
                //}
            }

            //var internalSize = new Size(Width, Height);

            //internalSize.Width -= (InternalMargin.Left + InternalMargin.Right);
            //internalSize.Height -= (InternalMargin.Top + InternalMargin.Bottom);

            var internalSize = MeasureForDimensions(contentSize, availableSize);

            foreach (inkControl child in Children)
            {
                if (child.Visibility == Visibility.Collapsed)
                {
                    continue;
                }

                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;

                if (HAlignToFill(child))
                {
                    width = Math.Max(internalSize.Width - child.Margin.Left - child.Margin.Right, width);
                }

                if (VAlignToFill(child))
                {
                    height = Math.Max(internalSize.Height - child.Margin.Top - child.Margin.Bottom, height);
                }

                child.Measure(new Size(width, height));
            }

            return MeasureForDimensions(internalSize, availableSize);
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

                double x = 0, y = 0;

                switch ((Enums.inkEHorizontalAlign)child.Widget.Layout.HAlign)
                {
                    case Enums.inkEHorizontalAlign.Fill:
                        x = child.Margin.Left;
                        break;
                    case Enums.inkEHorizontalAlign.Left:
                        x = child.Margin.Left;
                        break;
                    case Enums.inkEHorizontalAlign.Right:
                        x = finalRect.Size.Width - width - child.Margin.Right;
                        break;
                    case Enums.inkEHorizontalAlign.Center:
                        x = (finalRect.Size.Width - width) / 2 + child.Margin.Left - child.Margin.Right;
                        break;
                    default:
                        break;
                }

                switch ((Enums.inkEVerticalAlign)child.Widget.Layout.VAlign)
                {
                    case Enums.inkEVerticalAlign.Fill:
                        y = child.Margin.Top;
                        break;
                    case Enums.inkEVerticalAlign.Top:
                        y = child.Margin.Top;
                        break;
                    case Enums.inkEVerticalAlign.Bottom:
                        y = finalRect.Size.Height - height - child.Margin.Bottom;
                        break;
                    case Enums.inkEVerticalAlign.Center:
                        y = (finalRect.Size.Height - height) / 2 + child.Margin.Top - child.Margin.Bottom;
                        break;
                    default:
                        break;
                }

                //x += InternalMargin.Left;
                //y += InternalMargin.Top;

                child.Arrange(new Rect(x, y, width, height));
            }

            base.ArrangeCore(finalRect);
        }
    }
}
