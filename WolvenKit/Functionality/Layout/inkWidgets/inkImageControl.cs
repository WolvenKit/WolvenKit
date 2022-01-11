using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WolvenKit.RED4.Types;
using SizeF = System.Windows.Size;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkImageControl : inkControl
    {
        public inkImageWidget ImageWidget => Widget as inkImageWidget;

        public System.Drawing.Size OriginalImageSize;
        private ImageSource OriginalImageSource;
        private RectF nsRect;
        private WolvenKit.RED4.Types.Rect Rect;

        private ImageSource ImageSource;
        private System.Windows.Media.Brush TintBrush;
        public bool UsingNineScale = false;

        public SizeF RenderedSize = new SizeF();

        public inkImageControl(inkImageWidget widget) : base(widget)
        {
            TintBrush = new SolidColorBrush(ToColor(Widget.TintColor));
            Background = TintBrush;

            if (ImageWidget.TextureAtlas == null)
                return;

            OriginalImageSource = (ImageSource)Application.Current.TryFindResource("ImageSource/" + ImageWidget.TextureAtlas.DepotPath + "#" + ImageWidget.TexturePart);

            if (OriginalImageSource == null)
                return;

            OriginalImageSize = new System.Drawing.Size((int)OriginalImageSource.Width, (int)OriginalImageSource.Height);

            if (Widget.FitToContent || ImageWidget.UseNineSliceScale)
            {
                Width = OriginalImageSize.Width;
                Height = OriginalImageSize.Height;
            }

            if (ImageWidget.UseNineSliceScale)
            {
                nsRect = (RectF)Application.Current.TryFindResource("RectF/" + ImageWidget.TextureAtlas.DepotPath + "#" + ImageWidget.TexturePart);
                if (nsRect != null)
                {
                    UsingNineScale = true;
                    Rect = new RED4.Types.Rect()
                    {
                        Left = (int)Math.Round(nsRect.Left),
                        Top = (int)Math.Round(nsRect.Top),
                        Right = (int)Math.Round(nsRect.Right),
                        Bottom = (int)Math.Round(nsRect.Bottom)
                    };
                }
            }

            DrawImage(new SizeF(Width, Height));

            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);
        }

        protected void DrawImage(SizeF size)
        {
            RenderedSize = size;
            Bitmap sourceBitmap;
            using (var outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)OriginalImageSource));
                enc.Save(outStream);
                sourceBitmap = new Bitmap(outStream);
            }

            Bitmap destBitmap = new Bitmap((int)size.Width, (int)size.Height);

            using (Graphics gfx = Graphics.FromImage(destBitmap))
            {
                // this is doesn't account for premultipied alpha, so the opacity mask is still needed
                var matrix = new ColorMatrix(new float[][]
                {
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                        new float[] { 0, 0, 0, 0, 0},
                });
                matrix.Matrix03 = Widget.TintColor.Alpha;
                matrix.Matrix40 = Widget.TintColor.Red;
                matrix.Matrix41 = Widget.TintColor.Green;
                matrix.Matrix42 = Widget.TintColor.Blue;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                if (UsingNineScale)
                {
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        0, 0, Rect.Left, Rect.Top),
                        0, 0, Rect.Left, Rect.Top,
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        Rect.Left, 0, (destBitmap.Width - Rect.Left - Rect.Right), Rect.Top),
                        Rect.Left, 0, (OriginalImageSize.Width - Rect.Left - Rect.Right), Rect.Top,
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        (destBitmap.Width - Rect.Right), 0, (Rect.Right), Rect.Top),
                        (OriginalImageSize.Width - Rect.Right), 0, (Rect.Right), Rect.Top,
                        GraphicsUnit.Pixel, attributes);

                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        0, Rect.Top, Rect.Left, (destBitmap.Height - Rect.Top - Rect.Bottom)),
                        0, Rect.Top, Rect.Left, (OriginalImageSize.Height - Rect.Top - Rect.Bottom),
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        Rect.Left, Rect.Top, (destBitmap.Width - Rect.Left - Rect.Right), (destBitmap.Height - Rect.Top - Rect.Bottom)),
                        Rect.Left, Rect.Top, (OriginalImageSize.Width - Rect.Left - Rect.Right), (OriginalImageSize.Height - Rect.Top - Rect.Bottom),
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        (destBitmap.Width - Rect.Right), Rect.Top, (Rect.Right), (destBitmap.Height - Rect.Top - Rect.Bottom)),
                        (OriginalImageSize.Width - Rect.Right), Rect.Top, (Rect.Right), (OriginalImageSize.Height - Rect.Top - Rect.Bottom),
                        GraphicsUnit.Pixel, attributes);

                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        0, (destBitmap.Height - Rect.Bottom), Rect.Left, Rect.Bottom),
                        0, (OriginalImageSize.Height - Rect.Bottom), Rect.Left, Rect.Bottom,
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        Rect.Left, (destBitmap.Height - Rect.Bottom), (destBitmap.Width - Rect.Left - Rect.Right), Rect.Bottom),
                        Rect.Left, (OriginalImageSize.Height - Rect.Bottom), (OriginalImageSize.Width - Rect.Left - Rect.Right), Rect.Bottom,
                        GraphicsUnit.Pixel, attributes);
                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        (destBitmap.Width - Rect.Right), (destBitmap.Height - Rect.Bottom), (Rect.Right), Rect.Bottom),
                        (OriginalImageSize.Width - Rect.Right), (OriginalImageSize.Height - Rect.Bottom), (Rect.Right), Rect.Bottom,
                        GraphicsUnit.Pixel, attributes);
                }
                else
                {
                    gfx.DrawImage(sourceBitmap, new Rectangle(0, 0, destBitmap.Width, destBitmap.Height), 0, 0, sourceBitmap.Width, sourceBitmap.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            sourceBitmap.Dispose();

            var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                destBitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            destBitmap.Dispose();

            bitmapSource.Freeze();

            switch (ImageWidget.MirrorType.Value)
            {
                case Enums.inkBrushMirrorType.Both:
                    ImageSource = new TransformedBitmap(bitmapSource, new ScaleTransform(-1, -1));
                    break;
                case Enums.inkBrushMirrorType.Horizontal:
                    ImageSource = new TransformedBitmap(bitmapSource, new ScaleTransform(-1, 1));
                    break;
                case Enums.inkBrushMirrorType.Vertical:
                    ImageSource = new TransformedBitmap(bitmapSource, new ScaleTransform(1, -1));
                    break;
                case Enums.inkBrushMirrorType.NoMirror:
                    ImageSource = bitmapSource;
                    break;
            }

            ImageSource.Freeze();

            SetCurrentValue(OpacityMaskProperty, new ImageBrush()
            {
                ImageSource = ImageSource,
                Stretch = Stretch.Fill,
            });
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            //var newSize = new SizeF(ActualWidth, ActualHeight);
            var newSize = new SizeF(RenderSize.Width, RenderSize.Height);
            if (OriginalImageSource != null && RenderedSize != newSize)
                DrawImage(newSize);
            //if (TintBrush != null && ImageSource != null)
            //    dc.DrawRectangle(TintBrush, null, new System.Windows.Rect(0, 0, ActualWidth, ActualHeight));
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            if (Widget.FitToContent)
            {
                var newSize = new SizeF(OriginalImageSource.Width, OriginalImageSource.Height);
                return base.MeasureOverride(newSize);
            }
            else
            {
                return base.MeasureOverride(new SizeF(Width, Height));
            }
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            //if (Widget.FitToContent)
            //{
            //    var newSize = new SizeF(OriginalImageSource.Width, OriginalImageSource.Height);
            //    return base.ArrangeOverride(newSize);
            //}
            //else
            //{
            //    return base.ArrangeOverride(new SizeF(Width, Height));
            //}
            //return base.ArrangeOverride(finalSize);
            return base.ArrangeOverride(finalSize);
        }
    }
}
