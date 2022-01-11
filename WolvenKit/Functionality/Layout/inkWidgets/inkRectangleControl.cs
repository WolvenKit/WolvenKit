using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkRectangleControl : inkControl
    {
        public inkRectangleWidget RectangleWidget => Widget as inkRectangleWidget;

        public inkRectangleControl(inkWidget widget) : base(widget)
        {

        }

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawRectangle(TintBrush, null, new System.Windows.Rect(0, 0, RenderSize.Width, RenderSize.Height));
            base.OnRender(dc);
        }
    }
}
