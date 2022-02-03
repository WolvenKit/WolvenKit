using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkRectangleControl : inkControl
    {
        public inkRectangleWidget RectangleWidget => Widget as inkRectangleWidget;

        public inkRectangleControl(inkWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override void Render(DrawingContext dc)
        {
            base.Render(dc);
            dc.DrawRectangle(TintBrush, null, new System.Windows.Rect(0, 0, RenderSize.Width, RenderSize.Height));
        }
    }
}
