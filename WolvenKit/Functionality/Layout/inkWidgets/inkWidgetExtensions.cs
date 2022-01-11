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
            inkControl element = null;
            if (widget is inkCanvasWidget canvas)
                element = new inkCanvasControl(canvas);
            else if (widget is inkFlexWidget flex)
                element = new inkFlexControl(flex);
            else if (widget is inkCompoundWidget compound)
                element = new inkCompoundControl(compound);
            else if (widget is inkImageWidget image)
                element = new inkImageControl(image);
            else if (widget is inkRectangleWidget rectangle)
                element = new inkRectangleControl(rectangle);
            else if (widget is inkTextWidget text)
                element = new inkTextControl(text);
            return element;
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
