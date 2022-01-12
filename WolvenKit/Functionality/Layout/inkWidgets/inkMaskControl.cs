using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using Rect = System.Windows.Rect;
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkMaskControl : inkControl
    {
        public inkMaskWidget MaskWidget => Widget as inkMaskWidget;

        public inkMaskControl(inkMaskWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {

        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
        }
    }
}
