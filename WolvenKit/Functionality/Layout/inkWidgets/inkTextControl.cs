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
using NarcityMedia.DrawStringLineHeight;
using Size = System.Windows.Size;
using Rect = System.Windows.Rect;
using FontFamily = System.Drawing.FontFamily;
using WolvenKit.Views.Documents;
using ReactiveUI;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkTextControl : inkControl
    {
        public inkTextWidget TextWidget => Widget as inkTextWidget;

        public string Text
        {
            get {
                string text = TextWidget.Text;
                if (TextWidget.Text == "")
                    text = "Test";
                if (TextWidget.LetterCase.Value == Enums.textLetterCase.UpperCase)
                    text = text.ToUpper();
                else if (TextWidget.LetterCase.Value == Enums.textLetterCase.LowerCase)
                    text = text.ToLower();
                text = text.Replace("\n", System.Environment.NewLine);
                return text;
            }
            set {
                TextWidget.Text = value;
            }
        }

        public ImageSource ImageSource;

        public Font Font;

        public float WrapWidth = 10000;

        public Size RenderedSize = new Size(0, 0);

        public double TextWidth = 10000;
        public double TextHeight;

        // unaffected by the font scaling we need to do
        public int LineHeight => (int)Math.Round(TextWidget.FontSize * TextWidget.LineHeightPercentage);

        // not totally sure why this is required - some dpi issue?
        public int FontSize => (int)Math.Round(TextWidget.FontSize * 0.85);

        public double CorrectionY => (FontFamily.GetCellDescent(System.Drawing.FontStyle.Regular)) / 1000.0 * Font.Size;

        public FontFamily FontFamily { get; set; }

        //public override double Width => Widget.FitToContent ? TextWidth : Widget.Size.X;
        //public override double Height => Widget.FitToContent ? TextHeight : Widget.Size.Y;

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

        public inkTextControl(inkTextWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            var fontPath = TextWidget.FontFamily.DepotPath?.ToString() ?? "";

            var fontCollection = (FontCollection)Application.Current.TryFindResource("FontCollection/" + fontPath + "#" + TextWidget.FontStyle);

            if (fontCollection == null)
                return;

            FontFamily = fontCollection.Families.First();

            Font = new Font(FontFamily, FontSize);
            //FontFamily = new System.Windows.Media.FontFamily(Font.Name);

            //if (Text != "")
            //    DrawText(new System.Windows.Size(Width, Height));

            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);

            WidgetView.AddTextWidget(this, TextWidget);
        }

        private double GetWrapLength(Size size)
        {
            var width = 10000D;
            if (TextWidget.WrappingInfo.AutoWrappingEnabled && !Double.IsPositiveInfinity(size.Width) && !Widget.FitToContent)
            {
                width = size.Width;
            }
            if (TextWidget.WrappingInfo.WrappingAtPosition != 0)
            {
                width = TextWidget.WrappingInfo.WrappingAtPosition;
            }
            return width;
        }

        private void MeasureText(Size size)
        {
            if (size.Width == 0 || size.Height == 0 || FontSize == 0)
                return;

            using (var tempbmp = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(tempbmp))
                {
                    SizeF textSize = g.MeasureStringLineHeight(Text, Font, (int)Math.Round(GetWrapLength(size)), LineHeight);
                    TextWidth = textSize.Width;
                    TextHeight = Math.Max(textSize.Height - CorrectionY * 2, 0);
                }
            }
        }

        public static StringAlignment ToStringAlignment(Enums.textHorizontalAlignment a)
        {
            switch (a)
            {
                case Enums.textHorizontalAlignment.Left:
                    return StringAlignment.Near;
                case Enums.textHorizontalAlignment.Center:
                    return StringAlignment.Center;
                case Enums.textHorizontalAlignment.Right:
                    return StringAlignment.Far;
                default:
                    return StringAlignment.Near;
            }
        }

        public static StringAlignment ToStringAlignment(Enums.textVerticalAlignment a)
        {
            switch (a)
            {
                case Enums.textVerticalAlignment.Top:
                    return StringAlignment.Near;
                case Enums.textVerticalAlignment.Center:
                    return StringAlignment.Center;
                case Enums.textVerticalAlignment.Bottom:
                    return StringAlignment.Far;
                default:
                    return StringAlignment.Near;
            }
        }

        private void DrawText(Size size)
        {
            RenderedSize = size;

            if (size.Width == 0 || size.Height == 0 || FontSize == 0)
                return;

            double x = 0, y = 0;
            switch (TextWidget.TextHorizontalAlignment.Value)
            {
                case Enums.textHorizontalAlignment.Left:
                    x = 0;
                    break;
                case Enums.textHorizontalAlignment.Center:
                    x = (size.Width - TextWidth) / 2;
                    break;
                case Enums.textHorizontalAlignment.Right:
                    x = size.Width - TextWidth;
                    break;
                default:
                    break;
            }

            switch (TextWidget.TextVerticalAlignment.Value)
            {
                case Enums.textVerticalAlignment.Top:
                    y = -CorrectionY;
                    break;
                case Enums.textVerticalAlignment.Center:
                    y = (size.Height - TextHeight) / 2 - CorrectionY;
                    break;
                case Enums.textVerticalAlignment.Bottom:
                    y = size.Height - TextHeight - CorrectionY;
                    break;
                default:
                    break;
            }

            var bmp = new Bitmap((int)size.Width, (int)(size.Height), System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.DrawString(Text, Font, ToDrawingBrush(Widget.TintColor), (int)Math.Round(GetWrapLength(size)), LineHeight, new RectangleF((float)x, (float)y, (float)TextWidth, (float)TextWidth), new StringFormat()
                {
                    //Alignment = ToStringAlignment(TextWidget.TextHorizontalAlignment.Value.GetValueOrDefault()),
                    //LineAlignment = ToStringAlignment(TextWidget.TextVerticalAlignment.Value.GetValueOrDefault()),
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.None
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

            // not sure stretch & alignment will ever be relevant
            SetCurrentValue(OpacityMaskProperty, new ImageBrush()
            {
                ImageSource = ImageSource,
                Stretch = Stretch.None,
                AlignmentY = AlignmentY.Center,
                AlignmentX = AlignmentX.Center
            });
        }

        protected override Size MeasureCore(Size availableSize)
        {
            MeasureText(availableSize);
            var size = new Size(Width, Height);
            //if (Widget.FitToContent)
            //{
            size.Width = Math.Max(TextWidth, 0);
            size.Height = Math.Max(TextHeight, 0);
            //}
            return MeasureForDimensions(size, availableSize);
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            //MeasureText(finalRect.Size);
            base.ArrangeCore(finalRect);
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            var newSize = new Size(RenderSize.Width, RenderSize.Height);
            dc.DrawRectangle(TintBrush, null, new Rect(0, 0, newSize.Width, newSize.Height));
            if (Text != "" && RenderedSize != newSize)
            {
                DrawText(newSize);
            }
            // this is supposed to be faster, but i couldn't get it working with custom fonts
            //FormattedText formattedText = new FormattedText("Different Test", CultureInfo.GetCultureInfo("en-us"),
            //    FlowDirection.LeftToRight, new Typeface(FontFamily, FontStyles.Normal, FontWeights.Regular, FontStretches.Normal), TextWidget.FontSize, TintBrush,
            //    VisualTreeHelper.GetDpi(this).PixelsPerDip);
            //dc.DrawText(formattedText, new System.Windows.Point(0,0));
        }
    }
}
