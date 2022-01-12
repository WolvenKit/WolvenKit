using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkBorderControl : inkControl
    {
        public inkBorderWidget BorderWidget => Widget as inkBorderWidget;

        public float Thickness => BorderWidget.Thickness;

        public inkBorderControl(inkBorderWidget widget) : base(widget)
        {

        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            dc.DrawRectangle(null, new Pen(TintBrush, Thickness), new Rect(0, 0, RenderSize.Width, RenderSize.Height));
        }
    }
}
