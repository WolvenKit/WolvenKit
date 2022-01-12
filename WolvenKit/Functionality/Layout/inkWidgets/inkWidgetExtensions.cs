using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public static class inkWidgetExtensions
    {
        public static inkControl CreateControl(this inkWidget widget)
        {
            switch (widget)
            {
                case inkCanvasWidget Canvas:
                    return new inkCanvasControl(Canvas);
                case inkBasePanelWidget BasePanel:
                    return new inkBasePanelControl(BasePanel);
                case inkFlexWidget Flex:
                    return new inkFlexControl(Flex);
                case inkCompoundWidget Compound:
                    return new inkCompoundControl(Compound);
                case inkImageWidget Image:
                    return new inkImageControl(Image);
                case inkMaskWidget Mask:
                    return new inkMaskControl(Mask);
                case inkTextWidget Text:
                    return new inkTextControl(Text);
                case inkRectangleWidget Rectangle:
                    return new inkRectangleControl(Rectangle);
                case inkBorderWidget Border:
                    return new inkBorderControl(Border);
                default:
                    return new inkControl(widget);
            }
        }

        public static inkWidget GetParent(this inkWidget widget)
        {
            if (widget.ParentWidget != null)
            {
                return (inkWidget)widget.ParentWidget.GetValue();
            }
            return null;
        }

        public static List<inkWidget> GetChildren(this inkCompoundWidget widget)
        {
            var children = new List<inkWidget>();
            if (widget.Children != null && widget.Children.GetValue() is inkMultiChildren imc)
            {
                var childrenHandles = imc.Children.Reverse();
                if (widget.ChildOrder.Value == Enums.inkEChildOrder.Forward)
                    childrenHandles = childrenHandles.Reverse();
                foreach (var childHandle in childrenHandles)
                {
                    children.Add((inkWidget)childHandle.GetValue());
                }
            }
            return children;
        }
    }
}
