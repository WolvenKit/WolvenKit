using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WolvenKit.App.Helpers;
using WolvenKit.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Application = System.Windows.Application;
using Rect = System.Windows.Rect;
using SizeF = System.Windows.Size;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public abstract class inkBaseImageControl : inkControl
    {
        public inkIImageWidget IImageWidget => Widget as inkIImageWidget;

        public System.Drawing.Size OriginalImageSize { get; set; }
        protected BitmapSource OriginalImageSource;
        protected RectF nsRect;
        protected WolvenKit.RED4.Types.Rect Rect = new();

        public ImageSource ImageSource;
        public bool UsingNineScale { get; set; }

        public ImageSource Texture { get; set; }
        //public string TextureAtlas { get; set; }

        public Enums.inkBrushTileType TileType { get; set; } = Enums.inkBrushTileType.NoTile;

        public System.Windows.Media.Brush Mask { get; set; } = new ImageBrush();

        public string TextureAtlas
        {
            get
            {
                if (!PropertyBindings.ContainsKey("textureAtlas"))
                {
                    goto NoOverride;
                }

                var variant = GetProperty(PropertyBindings["textureAtlas"]);

                if (variant?.Value is CResourceAsyncReference<inkTextureAtlas> atlas)
                {
                    return atlas.DepotPath;
                }

            NoOverride:
                return IImageWidget.TextureAtlas.DepotPath;
            }
        }

        public string TexturePart { get; set; }

        public SizeF RenderedSize = new();

        //public override double Width => Widget.FitToContent ? OriginalImageSize.Width : Widget.Size.X;
        //public override double Height => Widget.FitToContent ? OriginalImageSize.Height : Widget.Size.Y;

        public inkBaseImageControl() : base()
        {

        }

        public inkBaseImageControl(inkIImageWidget widget, RDTWidgetView widgetView) : base((inkWidget)widget, widgetView)
        {

            if (TextureAtlas == null)
            {
                return;
            }

            //TextureAtlas = IImageWidget.TextureAtlas.DepotPath;
            TexturePart = IImageWidget.TexturePart;

            OriginalImageSource = (BitmapSource)Application.Current.TryFindResource("ImageSource/" + TextureAtlas + "#" + TexturePart);

            if (OriginalImageSource == null)
            {
                if (InkCache.Resources.Contains(TextureAtlas))
                {
                    return;
                }

                _ = WidgetView.ViewModel.LoadInkAtlasAsync(TextureAtlas);

                OriginalImageSource = (BitmapSource)Application.Current.TryFindResource("ImageSource/" + TextureAtlas + "#" + TexturePart);

                if (OriginalImageSource == null)
                {
                    return;
                }
            }

            OriginalImageSize = new System.Drawing.Size(OriginalImageSource.PixelWidth, OriginalImageSource.PixelHeight);

            //DrawImage(new SizeF(Width, Height));

            //RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);
        }

        protected virtual ColorMatrix GetColorMatrix()
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
                Matrix03 = TintColor.A / 255F
            };
            //matrix.Matrix13 = TintColor.Alpha / 3F;
            //matrix.Matrix23 = TintColor.Alpha / 3F;
            //matrix.Matrix40 = TintColor.R / 255F;
            //matrix.Matrix41 = TintColor.G / 255F;
            //matrix.Matrix42 = TintColor.B / 255F;
            return matrix;
        }

        protected virtual void DrawImage(SizeF size)
        {
            RenderedSize = size;
            if (size.Width == 0 || size.Height == 0)
            {
                return;
            }

            if (OriginalImageSource == null)
            {
                return;
            }

            switch (TileType)
            {
                case Enums.inkBrushTileType.Both:
                    size.Width = OriginalImageSize.Width;
                    size.Height = OriginalImageSize.Height;
                    break;
                case Enums.inkBrushTileType.Vertical:
                    size.Height = OriginalImageSize.Height;
                    break;
                case Enums.inkBrushTileType.Horizontal:
                    size.Width = OriginalImageSize.Width;
                    break;
                case Enums.inkBrushTileType.NoTile:
                    break;
                default:
                    break;
            }

            Bitmap sourceBitmap;
            using (var outStream = new MemoryStream())
            {
                BitmapEncoder enc = new TiffBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)OriginalImageSource));
                enc.Save(outStream);
                sourceBitmap = new Bitmap(outStream);
            }

            var destBitmap = new Bitmap((int)Math.Round(size.Width), (int)Math.Round(size.Height), System.Drawing.Imaging.PixelFormat.Format64bppArgb); // System.Drawing.Imaging.PixelFormat.Format16bppGrayScale pls

            using (var gfx = Graphics.FromImage(destBitmap))
            {

                var attributes = new ImageAttributes();

                //attributes.SetColorKey(System.Drawing.Color.Black, System.Drawing.Color.White);
                attributes.SetColorMatrix(GetColorMatrix(), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                if (UsingNineScale)
                {
                    attributes.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);

                    DrawNineSlicedImage(gfx, destBitmap, sourceBitmap, attributes);
                }
                else
                {
                    int x = 0, y = 0, width = destBitmap.Width, height = destBitmap.Height;

                    switch (TileType)
                    {
                        case Enums.inkBrushTileType.Both:
                            width = OriginalImageSize.Width;
                            height = OriginalImageSize.Height;
                            break;
                        case Enums.inkBrushTileType.Vertical:
                            height = OriginalImageSize.Height;
                            break;
                        case Enums.inkBrushTileType.Horizontal:
                            width = OriginalImageSize.Width;
                            break;
                        case Enums.inkBrushTileType.NoTile:
                            break;
                        default:
                            break;
                    }

                    gfx.DrawImage(sourceBitmap, new Rectangle(x, y, width, height), 0, 0, OriginalImageSize.Width, OriginalImageSize.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            sourceBitmap.Dispose();

            ImageSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                destBitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            destBitmap.Dispose();

            ImageSource.Freeze();

            //SetCurrentValue(OpacityMaskProperty, Mask);
        }

        private void DrawNineSlicedImage(Graphics graphics, Bitmap destImage, Bitmap sourceImage, ImageAttributes attributes)
        {
            var destSlices = GetRectangles(destImage);
            var sourceSlices = GetRectangles(sourceImage);

            graphics.DrawImage(sourceImage, destSlices.TopLeft, sourceSlices.TopLeft, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.TopCenter, sourceSlices.TopCenter, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.TopRight, sourceSlices.TopRight, GraphicsUnit.Pixel, attributes);

            graphics.DrawImage(sourceImage, destSlices.Left, sourceSlices.Left, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.Center, sourceSlices.Center, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.Right, sourceSlices.Right, GraphicsUnit.Pixel, attributes);

            graphics.DrawImage(sourceImage, destSlices.BottomLeft, sourceSlices.BottomLeft, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.BottomCenter, sourceSlices.BottomCenter, GraphicsUnit.Pixel, attributes);
            graphics.DrawImage(sourceImage, destSlices.BottomRight, sourceSlices.BottomRight, GraphicsUnit.Pixel, attributes);

            SliceRectangles GetRectangles(Bitmap image)
            {
                int leftX = 0;
                int centerX = Rect.Left;
                int rightX = image.Width - Rect.Right;

                int topY = 0;
                int centerY = Rect.Top;
                int bottomY = image.Height - Rect.Bottom;

                int topHeight = Rect.Top;
                int centerHeight = image.Height - (Rect.Top + Rect.Bottom);
                int bottomHeight = Rect.Bottom;

                int leftWidth = Rect.Left;
                int centerWidth = image.Width - (Rect.Left + Rect.Right);
                int rightWidth = Rect.Right;

                return new SliceRectangles(
                    new Rectangle(leftX, topY, leftWidth, topHeight), 
                    new Rectangle(centerX, topY, centerWidth, topHeight),
                    new Rectangle(rightX, topY, rightWidth, topHeight),
                    new Rectangle(leftX, centerY, leftWidth, centerHeight),
                    new Rectangle(centerX, centerY, centerWidth, centerHeight),
                    new Rectangle(rightX, centerY, rightWidth, centerHeight),
                    new Rectangle(leftX, bottomY, leftWidth, bottomHeight),
                    new Rectangle(centerX, bottomY, centerWidth, bottomHeight),
                    new Rectangle(rightX, bottomY, rightWidth, bottomHeight));
            }
        }

        private record SliceRectangles(
            Rectangle TopLeft,
            Rectangle TopCenter,
            Rectangle TopRight,
            Rectangle Left,
            Rectangle Center,
            Rectangle Right,
            Rectangle BottomLeft,
            Rectangle BottomCenter,
            Rectangle BottomRight);

        public static TileMode ToTileMode(Enums.inkBrushTileType? tile)
        {
            return tile switch
            {
                Enums.inkBrushTileType.NoTile => TileMode.None,
                Enums.inkBrushTileType.Horizontal => TileMode.Tile,
                Enums.inkBrushTileType.Vertical => TileMode.Tile,
                Enums.inkBrushTileType.Both => TileMode.Tile,
                null => TileMode.Tile,
                _ => TileMode.Tile,
            };
        }

        public static AlignmentX ToAlignmentX(Enums.inkEHorizontalAlign? type)
        {
            return type switch
            {
                Enums.inkEHorizontalAlign.Left => AlignmentX.Left,
                Enums.inkEHorizontalAlign.Right => AlignmentX.Right,
                Enums.inkEHorizontalAlign.Fill => AlignmentX.Center,
                Enums.inkEHorizontalAlign.Center => AlignmentX.Center,
                null => AlignmentX.Center,
                _ => AlignmentX.Center,
            };
        }

        public static AlignmentY ToAlignmentY(Enums.inkEVerticalAlign? type)
        {
            return type switch
            {
                Enums.inkEVerticalAlign.Top => AlignmentY.Top,
                Enums.inkEVerticalAlign.Bottom => AlignmentY.Bottom,
                Enums.inkEVerticalAlign.Fill => AlignmentY.Center,
                Enums.inkEVerticalAlign.Center => AlignmentY.Center,
                null => AlignmentY.Center,
                _ => AlignmentY.Center,
            };
        }

        protected override void Render(DrawingContext dc)
        {
            if (TintBrush != null)
            {
                var newSize = new SizeF(RenderSize.Width, RenderSize.Height);
                if (OriginalImageSource != null && newSize != RenderedSize)
                {
                    DrawImage(newSize);
                }

                if (ImageSource != null)
                {
                    dc.PushOpacityMask(Mask);
                    dc.DrawRectangle(TintBrush, null, new Rect(0, 0, newSize.Width, newSize.Height));
                    dc.Pop();
                    //dc.DrawImage(ImageSource, new Rect(0, 0, newSize.Width, newSize.Height));
                }
            }
            base.Render(dc);
        }

        protected override SizeF MeasureCore(SizeF availableSize)
        {
            return Widget.FitToContent && OriginalImageSource != null
                ? MeasureForDimensions(new SizeF(OriginalImageSource.PixelWidth, OriginalImageSource.PixelHeight), availableSize)
                : MeasureForDimensions(new SizeF(Width, Height), availableSize);
            //return base.MeasureCore(availableSize);
        }

        protected override void ArrangeCore(Rect finalRect) => base.ArrangeCore(finalRect);
    }
}
