using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public static class inkWidgetExtensions
    {
        public static inkControl CreateControl(this inkWidget widget, RDTWidgetView widgetView)
        {
            switch (widget)
            {
                case inkCanvasWidget Canvas:
                    return new inkCanvasControl(Canvas, widgetView);
                case inkBasePanelWidget BasePanel:
                    return new inkBasePanelControl(BasePanel, widgetView);
                case inkFlexWidget Flex:
                    return new inkFlexControl(Flex, widgetView);
                case inkGridWidget Grid:
                    return new inkGridControl(Grid, widgetView);
                case inkCompoundWidget Compound:
                    return new inkCompoundControl(Compound, widgetView);
                case inkImageWidget Image:
                    return new inkImageControl(Image, widgetView);
                case inkMaskWidget Mask:
                    return new inkMaskControl(Mask, widgetView);
                case inkTextWidget Text:
                    return new inkTextControl(Text, widgetView);
                case inkRectangleWidget Rectangle:
                    return new inkRectangleControl(Rectangle, widgetView);
                case inkBorderWidget Border:
                    return new inkBorderControl(Border, widgetView);
                default:
                    return new inkControl(widget, widgetView);
            }
        }

        //public static string GetPath(this inkWidget widget)
        //{
        //    if (widget.GetParent() is inkWidget parent)
        //        return parent.Name + "/" + widget.Name;
        //    return widget.Name;
        //}

        //public static inkWidget GetParent(this inkWidget widget)
        //{
        //    if (widget.ParentWidget != null)
        //    {
        //        return (inkWidget)widget.ParentWidget.GetValue();
        //    }
        //    return null;
        //}

        public static List<inkWidget> GetChildren(this inkCompoundWidget widget)
        {
            var children = new List<inkWidget>();
            if (widget.Children != null && widget.Children.GetValue() is inkMultiChildren imc)
            {
                var childrenHandles = imc.Children.Reverse();
                if (widget.ChildOrder == Enums.inkEChildOrder.Forward)
                {
                    childrenHandles = childrenHandles.Reverse();
                }

                foreach (var childHandle in childrenHandles)
                {
                    children.Add((inkWidget)childHandle.GetValue());
                }
            }
            return children;
        }
    }
}
