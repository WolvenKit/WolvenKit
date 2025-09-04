using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class ImageDecoder
{
    public static BitmapSource LoadBitmapFromResource(string resourcePath)
    {
        var bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri($"pack://application:,,,/WolvenKit;component/{resourcePath}");
        bitmap.EndInit();
        bitmap.Freeze();
        return bitmap;
    }

    public static BitmapImage CreateBitmapImage(RedImage img, bool flip)
    {
        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(img.GetPreview(flip));
        bitmapImage.EndInit();

        return bitmapImage;
    }

    public static Task<BitmapImage?> RenderToBitmapImageDds(Stream stream, Common.DDS.DXGI_FORMAT format) =>
        Task.Run(() =>
        {
            var image = RedImage.LoadFromDDSMemory(stream.ToByteArray(), format);
            if (image == null)
            {
                return null;
            }

            return CreateBitmapImage(image, false);
        });

    public static Task<BitmapImage?> RenderToBitmapImageDds(Stream stream, Enums.ETextureRawFormat format) =>
        Task.Run(() =>
        {
            var image = RedImage.LoadFromDDSMemory(stream.ToByteArray(), format);
            if (image == null)
            {
                return null;
            }

            return CreateBitmapImage(image, false);
        });

    /// <summary>
    /// Decodes image from file to BitMapSource
    /// </summary>
    /// <param name="file">Absolute path of the file</param>
    /// <returns></returns>
    public static Task<BitmapImage?> RenderToBitmapImage(string file) =>
        Task.Run(() =>
        {
            var image = RedImage.LoadFromFile(file);
            if (image != null)
            {
                return CreateBitmapImage(image, false);
            }

            return null;
        });
}

public class XenConverter : IValueConverter
{
    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && value is string s && !string.IsNullOrEmpty(s))
        {
            return ImageDecoder.RenderToBitmapImage(s);
        }

        return null;
    }


    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}
