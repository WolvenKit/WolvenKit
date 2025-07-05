using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Documents;
using Rect = System.Windows.Rect;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    public class inkImageControl : inkBaseImageControl
    {
        public inkImageWidget ImageWidget => Widget as inkImageWidget;

        public inkImageControl() : base()
        {

        }

        public inkImageControl(inkImageWidget widget, RDTWidgetView widgetView) : base(widget, widgetView)
        {
            if (ImageWidget.UseNineSliceScale)
            {
                nsRect = (RectF)Application.Current.TryFindResource("RectF/" + TextureAtlas + "#" + TexturePart);
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

            TileType = ImageWidget.TileType;

            DrawImage(new Size(Width, Height));
        }

        protected override void DrawImage(Size size)
        {
            base.DrawImage(size);

            if (ImageSource != null)
            {
                switch ((Enums.inkBrushMirrorType)ImageWidget.MirrorType)
                {
                    case Enums.inkBrushMirrorType.Both:
                        ImageSource = new TransformedBitmap((BitmapSource)ImageSource, new ScaleTransform(-1, -1));
                        break;
                    case Enums.inkBrushMirrorType.Horizontal:
                        ImageSource = new TransformedBitmap((BitmapSource)ImageSource, new ScaleTransform(-1, 1));
                        break;
                    case Enums.inkBrushMirrorType.Vertical:
                        ImageSource = new TransformedBitmap((BitmapSource)ImageSource, new ScaleTransform(1, -1));
                        break;
                    case Enums.inkBrushMirrorType.NoMirror:
                        break;
                    default:
                        break;
                }

                ImageSource.Freeze();

                Mask = new ImageBrush(ImageSource)
                {
                    Stretch = Stretch.None,
                    TileMode = ToTileMode(TileType),
                    AlignmentX = ToAlignmentX(ImageWidget.TileHAlign),
                    AlignmentY = ToAlignmentY(ImageWidget.TileVAlign),
                    ViewportUnits = BrushMappingMode.Absolute,
                    Viewport = new Rect(0, 0, size.Width, size.Height)
                };
            }
        }
    }
}
