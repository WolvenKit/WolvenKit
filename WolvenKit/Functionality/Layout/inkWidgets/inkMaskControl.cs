using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkMaskControl : inkControl
    {
        public inkMaskWidget MaskWidget => Widget as inkMaskWidget;

        public inkMaskControl(inkMaskWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override void Render(DrawingContext dc) => base.Render(dc);
    }
}
