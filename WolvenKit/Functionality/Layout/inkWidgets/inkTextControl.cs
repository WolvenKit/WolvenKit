using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkTextControl : inkControl
    {
        public inkTextWidget TextWidget => Widget as inkTextWidget;

        public System.Windows.Media.Brush TintBrush;

        public string Text = "";

        public ImageSource ImageSource;

        public Font Font;

        public System.Windows.Media.FontFamily FontFamily;

        public float WrapWidth = 10000;

        public System.Windows.Size RenderedSize = new System.Windows.Size(0, 0);

        public double TextWidth;
        public double TextHeight;

        public override double Width => Widget.FitToContent ? TextWidth : Widget.Size.X;
        public override double Height => Widget.FitToContent ? TextHeight : Widget.Size.Y;

        public float offsetY
        {
            get
            {
                if (TextWidget.TextVerticalAlignment.Value == Enums.textVerticalAlignment.Top)
                    return -TextWidget.FontSize * 0.25F;
                else if (TextWidget.TextVerticalAlignment.Value == Enums.textVerticalAlignment.Bottom)
                    return TextWidget.FontSize * 0.25F;
                return TextWidget.FontSize * 0.1F;
            }
        }

        public StringAlignment TextAlignment
        {
            get
            {
                if (TextWidget.TextHorizontalAlignment.Value == Enums.textHorizontalAlignment.Left)
                    return StringAlignment.Near;
                if (TextWidget.TextHorizontalAlignment.Value == Enums.textHorizontalAlignment.Right)
                    return StringAlignment.Far;
                return StringAlignment.Center;
            }
        }

        public inkTextControl(inkTextWidget widget) : base(widget)
        {
            TintBrush = new SolidColorBrush(ToColor(Widget.TintColor));
            //Background = TintBrush;

            Text = TextWidget.Text.GetValue();

            if (Text == "")
                Text = "Test";

            if (TextWidget.LetterCase.Value == Enums.textLetterCase.UpperCase)
                Text = Text.ToUpper();

            // not totally sure why this is required - some dpi issue?
            float fontSize = (float)(TextWidget.FontSize * 0.8);
            //float fontSize = (float)(TextWidget.FontSize);
            var fontPath = TextWidget.FontFamily.DepotPath?.ToString() ?? "";

            var fontCollection = (FontCollection)Application.Current.TryFindResource("FontCollection/" + fontPath + "#" + TextWidget.FontStyle);

            if (fontCollection == null)
                return;

            Font = new Font(fontCollection.Families.First(), fontSize);
            FontFamily = new System.Windows.Media.FontFamily(Font.Name);

            if (TextWidget.WrappingInfo.AutoWrappingEnabled && TextWidget.WrappingInfo.WrappingAtPosition != 0)
            {
                WrapWidth = (int)TextWidget.WrappingInfo.WrappingAtPosition;
            }

            using (var tempbmp = new Bitmap((int)WrapWidth, 10000, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {
                using (var g = Graphics.FromImage(tempbmp))
                {
                    SizeF s = g.MeasureString(Text, Font, new SizeF(WrapWidth, 10000));
                    TextWidth = s.Width;
                    TextHeight = s.Height;
                }
            }

            if (Text != "")
                DrawText(new System.Windows.Size(Width, Height));

            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);

        }

        private void DrawText(System.Windows.Size size)
        {
            RenderedSize = size;
            var wrapWidth = Math.Min(WrapWidth, size.Width);
            var bmp = new Bitmap((int)size.Width, (int)(size.Height), System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.DrawString(Text, Font, ToDrawingBrush(Widget.TintColor), new RectangleF(0, offsetY, (float)wrapWidth, (float)size.Height), new StringFormat()
                {
                    LineAlignment = StringAlignment.Center
                });
            }

            // premultiplied alpha issues here too - opacitymask addresses it
            ImageSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                bmp.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            bmp.Dispose();

            ImageSource.Freeze();

            SetCurrentValue(OpacityMaskProperty, new ImageBrush()
            {
                ImageSource = ImageSource,
                Stretch = Stretch.None,
                AlignmentY = AlignmentY.Center
            });
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            var newSize = new System.Windows.Size(RenderSize.Width, RenderSize.Height);
            dc.DrawRectangle(TintBrush, null, new System.Windows.Rect(0, 0, newSize.Width, newSize.Height));
            if (Text != "" && RenderedSize != newSize)
                DrawText(newSize);
            //FormattedText formattedText = new FormattedText("Different Test", CultureInfo.GetCultureInfo("en-us"),
            //    FlowDirection.LeftToRight, new Typeface(FontFamily, FontStyles.Normal, FontWeights.Regular, FontStretches.Normal), TextWidget.FontSize, TintBrush,
            //    VisualTreeHelper.GetDpi(this).PixelsPerDip);
            //dc.DrawText(formattedText, new System.Windows.Point(0,0));
        }
    }
}
