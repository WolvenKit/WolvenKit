using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using NarcityMedia.DrawStringLineHeight;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Brush = System.Windows.Media.Brush;
using FontFamily = System.Drawing.FontFamily;
using Rect = System.Windows.Rect;
using Size = System.Windows.Size;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkTextControl : inkControl
    {
        public inkTextWidget TextWidget => Widget as inkTextWidget;

        public string Text
        {
            get
            {
                string text = TextWidget.Text;
                if (text == "" || text == null)
                {
                    text = "Test";
                }

                if (TextWidget.LetterCase == Enums.textLetterCase.UpperCase)
                {
                    text = text.ToUpper();
                }
                else if (TextWidget.LetterCase == Enums.textLetterCase.LowerCase)
                {
                    text = text.ToLower();
                }

                text = text.Replace("\n", System.Environment.NewLine);
                return text;
            }
            set => TextWidget.Text = value;
        }

        public ImageSource ImageSource;

        public Font Font;

        public float WrapWidth = 10000;

        public Size RenderedSize = new Size(0, 0);

        public double TextWidth = 10000;
        public double TextHeight;

        // unaffected by the font scaling we need to do
        public int LineHeight => (int)Math.Round(_fontSize * TextWidget.LineHeightPercentage);

        // not totally sure why this is required - some dpi issue?
        public uint FontSize => _fontSize / 2;

        public double CorrectionY => (FontFamily.GetCellDescent(System.Drawing.FontStyle.Regular)) / 2000.0 * LineHeight;

        public FontFamily FontFamily { get; set; }

        public Brush Mask { get; set; } = new ImageBrush();

        //public override double Width => Widget.FitToContent ? TextWidth : Widget.Size.X;
        //public override double Height => Widget.FitToContent ? TextHeight : Widget.Size.Y;

        public CUInt32 RenderedFontSize { get; set; }

        private CUInt32 _fontSize
        {
            get
            {
                if (!PropertyBindings.ContainsKey("fontSize"))
                {
                    goto NoOverride;
                }

                var variant = GetProperty(PropertyBindings["fontSize"]);

                if (variant == null)
                {
                    goto NoOverride;
                }

                if (variant.Value is CUInt32 fontSize)
                {
                    return fontSize;
                }

            NoOverride:
                return TextWidget.FontSize;
            }
        }

        public CName RenderedFontStyle { get; set; }

        private CName _fontStyle
        {
            get
            {
                if (!PropertyBindings.ContainsKey("fontStyle"))
                {
                    goto NoOverride;
                }

                var variant = GetProperty(PropertyBindings["fontStyle"]);

                if (variant == null)
                {
                    goto NoOverride;
                }

                if (variant.Value is CName fontStyle)
                {
                    return fontStyle;
                }

            NoOverride:
                return TextWidget.FontStyle;
            }
        }

        public inkTextControl() : base()
        {

        }

        public inkTextControl(inkTextWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            SetupFont();

            //RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);

            WidgetView.AddTextWidget(this, TextWidget);
        }

        private void SetupFont()
        {
            RenderedFontSize = FontSize;
            RenderedFontStyle = _fontStyle;

            if (FontSize == 0)
            {
                return;
            }

            var fontPath = TextWidget.FontFamily.DepotPath?.ToString() ?? "";

            var fontCollection = (FontCollection)Application.Current.TryFindResource("FontCollection/" + fontPath + "#" + _fontStyle);

            if (fontCollection == null)
            {
                return;
            }

            FontFamily = fontCollection.Families.First();

            Font = new Font(FontFamily, FontSize);
        }

        private double GetWrapLength(Size size)
        {
            var width = 10000D;
            if (TextWidget.WrappingInfo.AutoWrappingEnabled && !double.IsPositiveInfinity(size.Width) && !Widget.FitToContent)
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
            {
                return;
            }

            using (var tempbmp = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(tempbmp))
                {
                    var textSize = g.MeasureStringLineHeight(Text, Font, (int)Math.Round(GetWrapLength(size)), LineHeight);
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
            {
                return;
            }

            double x = 0, y = 0;
            switch ((Enums.textHorizontalAlignment)TextWidget.TextHorizontalAlignment)
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

            switch ((Enums.textVerticalAlignment)TextWidget.TextVerticalAlignment)
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
                g.DrawString(Text, Font, System.Drawing.Brushes.White, (int)Math.Round(GetWrapLength(size)), LineHeight, new RectangleF((float)x, (float)y, (float)TextWidth, (float)TextWidth), new StringFormat()
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

            Mask = new ImageBrush(ImageSource)
            {
                Stretch = Stretch.None,
                AlignmentY = AlignmentY.Center,
                AlignmentX = AlignmentX.Center
            };

            // not sure stretch & alignment will ever be relevant
            //SetCurrentValue(OpacityMaskProperty, Mask);
        }

        protected override Size MeasureCore(Size availableSize)
        {
            if (RenderedFontSize != FontSize || RenderedFontStyle != _fontStyle)
            {
                SetupFont();
            }
            MeasureText(availableSize);
            var size = new Size(Width, Height)
            {
                //if (Widget.FitToContent)
                //{
                Width = Math.Max(TextWidth, 0),
                Height = Math.Max(TextHeight, 0)
            };
            //}
            return MeasureForDimensions(size, availableSize);
        }

        protected override void ArrangeCore(Rect finalRect) =>
            //MeasureText(finalRect.Size);
            base.ArrangeCore(finalRect);

        protected override void Render(DrawingContext dc)
        {
            var size = new Size(RenderSize.Width, RenderSize.Height);
            //if (RenderedSize != size)
            //{
            DrawText(size);
            //}
            dc.PushOpacityMask(Mask);
            dc.DrawRectangle(TintBrush, null, new Rect(0, 0, size.Width, size.Height));
            dc.Pop();

            base.Render(dc);

            // this is supposed to be faster, but i couldn't get it working with custom fonts
            //FormattedText formattedText = new FormattedText("Different Test", CultureInfo.GetCultureInfo("en-us"),
            //    FlowDirection.LeftToRight, new Typeface(FontFamily, FontStyles.Normal, FontWeights.Regular, FontStretches.Normal), TextWidget.FontSize, TintBrush,
            //    VisualTreeHelper.GetDpi(this).PixelsPerDip);
            //dc.DrawText(formattedText, new System.Windows.Point(0,0));
        }
    }
}
