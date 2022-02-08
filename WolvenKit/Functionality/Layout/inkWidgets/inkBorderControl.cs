using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkBorderControl : inkControl
    {
        public inkBorderWidget BorderWidget => Widget as inkBorderWidget;

        public float Thickness => BorderWidget.Thickness;

        public inkBorderControl(inkBorderWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override void Render(DrawingContext dc)
        {
            base.Render(dc);
            dc.DrawRectangle(null, new Pen(TintBrush, Thickness), new Rect(0, 0, RenderSize.Width, RenderSize.Height));
        }
    }
}
