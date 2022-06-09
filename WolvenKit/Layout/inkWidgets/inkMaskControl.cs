using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkMaskControl : inkBaseImageControl
    {
        public inkMaskWidget MaskWidget => Widget as inkMaskWidget;

        public inkMaskControl(inkMaskWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            //Opacity = 1.0;
            DrawImage(new Size(Width, Height));
        }

        protected override void Render(DrawingContext dc)
        {
            //base.Render(dc);
            //if (ImageSource != null)
            //{
            //    dc.DrawImage(ImageSource, new Rect(0, 0, RenderSize.Width, RenderSize.Height));
            //}
        }

        protected override ColorMatrix GetColorMatrix()
        {
            // this is doesn't account for premultipied alpha, so the opacity mask is still needed
            var matrix = new ColorMatrix(new float[][]
            {
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
            })
            {
                Matrix03 = (float)Opacity
            };
            //matrix.Matrix13 = TintColor.A / 3F;
            //matrix.Matrix23 = TintColor.A / 3F;
            //matrix.Matrix40 = TintColor.R / 255F;
            //matrix.Matrix41 = TintColor.G / 255F;
            //matrix.Matrix42 = TintColor.B / 255F;
            return matrix;
        }


        protected override void DrawImage(Size size) => base.DrawImage(size);//if (ImageSource != null)//{//    SetCurrentValue(OpacityMaskProperty, new ImageBrush(ImageSource)//    {//        Stretch = Stretch.None//    });//}
    }
}
