using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;
using SizeF = System.Windows.Size;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public abstract class inkBaseImageControl : inkControl
    {
        public inkIImageWidget IImageWidget => Widget as inkIImageWidget;

        public System.Drawing.Size OriginalImageSize { get; set; }
        protected ImageSource OriginalImageSource;
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

            OriginalImageSource = (ImageSource)Application.Current.TryFindResource("ImageSource/" + TextureAtlas + "#" + TexturePart);

            if (OriginalImageSource == null)
            {
                if (Application.Current.Resources.Contains(TextureAtlas))
                {
                    return;
                }

                _ = WidgetView.ViewModel.LoadInkAtlasAsync(TextureAtlas);

                OriginalImageSource = (ImageSource)Application.Current.TryFindResource("ImageSource/" + TextureAtlas + "#" + TexturePart);

                if (OriginalImageSource == null)
                {
                    return;
                }
            }

            OriginalImageSize = new System.Drawing.Size((int)Math.Round(OriginalImageSource.Width), (int)Math.Round(OriginalImageSource.Height));

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

                    if (Rect.Top != 0)
                    {
                        if (Rect.Left != 0)
                        {
                            gfx.DrawImage(sourceBitmap, new Rectangle(
                                0, 0, Rect.Left, Rect.Top),
                                0, 0, Rect.Left, Rect.Top,
                                GraphicsUnit.Pixel, attributes);
                        }

                        gfx.DrawImage(sourceBitmap, new Rectangle(
                            Rect.Left, 0, destBitmap.Width - Rect.Left - Rect.Right, Rect.Top),
                            Rect.Left + (Rect.Right == 0 ? -1 : 0) + (Rect.Left == 0 ? -1 : 0), 0, Math.Max(OriginalImageSize.Width - Rect.Left - Rect.Right, 1), Rect.Top,
                            GraphicsUnit.Pixel, attributes);
                        if (Rect.Right != 0)
                        {
                            gfx.DrawImage(sourceBitmap, new Rectangle(
                                destBitmap.Width - Rect.Right, 0, Rect.Right, Rect.Top),
                                OriginalImageSize.Width - Rect.Right, 0, Rect.Right, Rect.Top,
                                GraphicsUnit.Pixel, attributes);
                        }
                    }

                    if (Rect.Left != 0)
                    {
                        gfx.DrawImage(sourceBitmap, new Rectangle(
                            0, Rect.Top, Rect.Left, destBitmap.Height - Rect.Top - Rect.Bottom),
                            0, Rect.Top + (Rect.Bottom == 0 ? -1 : 0) + (Rect.Top == 0 ? -1 : 0), Rect.Left, Math.Max(OriginalImageSize.Height - Rect.Top - Rect.Bottom, 1),
                            GraphicsUnit.Pixel, attributes);
                    }

                    gfx.DrawImage(sourceBitmap, new Rectangle(
                        Rect.Left, Rect.Top, destBitmap.Width - Rect.Left - Rect.Right, destBitmap.Height - Rect.Top - Rect.Bottom),
                        Rect.Left + (Rect.Right == 0 ? -1 : 0) + (Rect.Left == 0 ? -1 : 0), Rect.Top + (Rect.Bottom == 0 ? -1 : 0) + (Rect.Top == 0 ? -1 : 0), Math.Max(OriginalImageSize.Width - Rect.Left - Rect.Right, 1), Math.Max(OriginalImageSize.Height - Rect.Top - Rect.Bottom, 1),
                        GraphicsUnit.Pixel, attributes);
                    if (Rect.Right != 0)
                    {
                        gfx.DrawImage(sourceBitmap, new Rectangle(
                            destBitmap.Width - Rect.Right, Rect.Top, Rect.Right, destBitmap.Height - Rect.Top - Rect.Bottom),
                            OriginalImageSize.Width - Rect.Right, Rect.Top + (Rect.Bottom == 0 ? -1 : 0) + (Rect.Top == 0 ? -1 : 0), Rect.Right, Math.Max(OriginalImageSize.Height - Rect.Top - Rect.Bottom, 1),
                            GraphicsUnit.Pixel, attributes);
                    }

                    if (Rect.Bottom != 0)
                    {
                        if (Rect.Left != 0)
                        {
                            gfx.DrawImage(sourceBitmap, new Rectangle(
                            0, destBitmap.Height - Rect.Bottom, Rect.Left, Rect.Bottom),
                            0, OriginalImageSize.Height - Rect.Bottom, Rect.Left, Rect.Bottom,
                            GraphicsUnit.Pixel, attributes);
                        }

                        gfx.DrawImage(sourceBitmap, new Rectangle(
                            Rect.Left, destBitmap.Height - Rect.Bottom, destBitmap.Width - Rect.Left - Rect.Right, Rect.Bottom),
                            Rect.Left + (Rect.Right == 0 ? -1 : 0) + (Rect.Left == 0 ? -1 : 0), OriginalImageSize.Height - Rect.Bottom, Math.Max(OriginalImageSize.Width - Rect.Left - Rect.Right, 1), Rect.Bottom,
                            GraphicsUnit.Pixel, attributes);
                        if (Rect.Right != 0)
                        {
                            gfx.DrawImage(sourceBitmap, new Rectangle(
                            destBitmap.Width - Rect.Right, destBitmap.Height - Rect.Bottom, Rect.Right, Rect.Bottom),
                            OriginalImageSize.Width - Rect.Right, OriginalImageSize.Height - Rect.Bottom, Rect.Right, Rect.Bottom,
                            GraphicsUnit.Pixel, attributes);
                        }
                    }

                    //        gfx.DrawImage(sourceBitmap, new Rectangle(
                    //            0, 0, Rect.Left, Rect.Top),
                    //            0, 0, Rect.Left, Rect.Top,
                    //            GraphicsUnit.Pixel, attributes);
                    //    gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        Rect.Left, 0, (destBitmap.Width - Rect.Left - Rect.Right), Rect.Top),
                    //        Rect.Left, 0, OriginalImageSize.Width - Rect.Left - Rect.Right, Rect.Top,
                    //        GraphicsUnit.Pixel, attributes);

                    //        gfx.DrawImage(sourceBitmap, new Rectangle(
                    //            (destBitmap.Width - Rect.Right), 0, (Rect.Right), Rect.Top),
                    //            (OriginalImageSize.Width - Rect.Right), 0, (Rect.Right), Rect.Top,
                    //            GraphicsUnit.Pixel, attributes);



                    //    gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        0, Rect.Top, Rect.Left, destBitmap.Height - Rect.Top - Rect.Bottom),
                    //        0, Rect.Top, Rect.Left, OriginalImageSize.Height - Rect.Top - Rect.Bottom,
                    //        GraphicsUnit.Pixel, attributes);
                    //gfx.DrawImage(sourceBitmap, new Rectangle(
                    //    Rect.Left, Rect.Top, (destBitmap.Width - Rect.Left - Rect.Right), (destBitmap.Height - Rect.Top - Rect.Bottom)),
                    //    Rect.Left, Rect.Top, OriginalImageSize.Width - Rect.Left - Rect.Right, OriginalImageSize.Height - Rect.Top - Rect.Bottom,
                    //    GraphicsUnit.Pixel, attributes);

                    //    gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        (destBitmap.Width - Rect.Right), Rect.Top, (Rect.Right), (destBitmap.Height - Rect.Top - Rect.Bottom)),
                    //        (OriginalImageSize.Width - Rect.Right), Rect.Top, (Rect.Right), OriginalImageSize.Height - Rect.Top - Rect.Bottom,
                    //        GraphicsUnit.Pixel, attributes);


                    //        gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        0, (destBitmap.Height - Rect.Bottom), Rect.Left, Rect.Bottom),
                    //        0, (OriginalImageSize.Height - Rect.Bottom), Rect.Left, Rect.Bottom,
                    //        GraphicsUnit.Pixel, attributes);
                    //    gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        Rect.Left, (destBitmap.Height - Rect.Bottom), (destBitmap.Width - Rect.Left - Rect.Right), Rect.Bottom),
                    //        Rect.Left, (OriginalImageSize.Height - Rect.Bottom), OriginalImageSize.Width - Rect.Left - Rect.Right, Rect.Bottom,
                    //        GraphicsUnit.Pixel, attributes);
                    //        gfx.DrawImage(sourceBitmap, new Rectangle(
                    //        (destBitmap.Width - Rect.Right), (destBitmap.Height - Rect.Bottom), (Rect.Right), Rect.Bottom),
                    //        (OriginalImageSize.Width - Rect.Right), (OriginalImageSize.Height - Rect.Bottom), (Rect.Right), Rect.Bottom,
                    //        GraphicsUnit.Pixel, attributes);

                }
                else
                {
                    int x = 0, y = 0, width = OriginalImageSize.Width, height = OriginalImageSize.Height;
                    //if (Widget.FitToContent)
                    //{
                    //    if (TileType == Enums.inkBrushTileType.Horizontal || TileType == Enums.inkBrushTileType.Both)
                    //    {
                    //        x = 0;
                    //    }
                    //    else
                    //    {
                    //        switch (Widget.Layout.HAlign.Value)
                    //        {
                    //            case Enums.inkEHorizontalAlign.Right:
                    //                x = destBitmap.Width - OriginalImageSize.Width;
                    //                break;
                    //            case Enums.inkEHorizontalAlign.Center:
                    //                x = (destBitmap.Width - OriginalImageSize.Width) / 2;
                    //                break;
                    //            case Enums.inkEHorizontalAlign.Fill:
                    //                width = destBitmap.Width;
                    //                break;
                    //            default:
                    //                break;
                    //        }
                    //    }

                    //    if (TileType == Enums.inkBrushTileType.Vertical || TileType == Enums.inkBrushTileType.Both)
                    //    {
                    //        y = 0;
                    //    }
                    //    else
                    //    {
                    //        switch (Widget.Layout.VAlign.Value)
                    //        {
                    //            case Enums.inkEVerticalAlign.Bottom:
                    //                y = destBitmap.Height - OriginalImageSize.Height;
                    //                break;
                    //            case Enums.inkEVerticalAlign.Center:
                    //                y = (destBitmap.Height - OriginalImageSize.Height) / 2;
                    //                break;
                    //            case Enums.inkEVerticalAlign.Fill:
                    //                height = destBitmap.Height;
                    //                break;
                    //            default:
                    //                break;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    width = destBitmap.Width;
                    height = destBitmap.Height;
                    //}

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
                ? MeasureForDimensions(new SizeF(OriginalImageSource.Width, OriginalImageSource.Height), availableSize)
                : MeasureForDimensions(new SizeF(Width, Height), availableSize);
            //return base.MeasureCore(availableSize);
        }

        protected override void ArrangeCore(Rect finalRect) => base.ArrangeCore(finalRect);
    }
}
