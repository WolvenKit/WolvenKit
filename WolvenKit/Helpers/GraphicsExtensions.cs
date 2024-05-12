using System.Drawing;
using System.Drawing.Imaging;

namespace WolvenKit.Helpers;

public static class GraphicsExtensions
{
    public static void DrawImage(this Graphics graphics, Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr) => 
        graphics.DrawImage(image, destRect, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, imageAttr);
}