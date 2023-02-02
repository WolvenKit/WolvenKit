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
    private static BitmapImage CreateBitmapImage(RedImage img)
    {
        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(img.GetPreview());
        bitmapImage.EndInit();

        return bitmapImage;
    }

    public static Task<BitmapImage> RenderToBitmapImageDds(Stream stream, Common.DDS.DXGI_FORMAT format) =>
        Task.Run(() => CreateBitmapImage(RedImage.LoadFromDDSMemory(stream.ToByteArray(), format)));

    public static Task<BitmapImage> RenderToBitmapImageDds(Stream stream, Enums.ETextureRawFormat format) =>
        Task.Run(() => CreateBitmapImage(RedImage.LoadFromDDSMemory(stream.ToByteArray(), format)));

    /// <summary>
    /// Decodes image from file to BitMapSource
    /// </summary>
    /// <param name="file">Absolute path of the file</param>
    /// <returns></returns>
    public static Task<BitmapImage?> RenderToBitmapImage(string file) =>
        Task.Run(() =>
        {
            try
            {
                var ext = Path.GetExtension(file).ToUpperInvariant();

                RedImage image;
                switch (ext)
                {
                    case ".JPG":
                    case ".JPEG":
                    case ".JPE":
                    {
                        image = RedImage.LoadFromJPGFile(file);
                        break;
                    }
                    case ".PNG":
                    {
                        image = RedImage.LoadFromPNGFile(file);
                        break;
                    }
                    case ".BMP":
                    {
                        image = RedImage.LoadFromBMPFile(file);
                        break;
                    }

                    case ".TIF":
                    case ".TIFF":
                    {
                        image = RedImage.LoadFromTIFFFile(file);
                        break;
                    }

                    case ".DDS":
                    {
                        image = RedImage.LoadFromDDSFile(file);
                        break;
                    }

                    case ".TGA": // TODO some tga files are created upside down https://github.com/Ruben2776/PicView/issues/22
                    {
                        image = RedImage.LoadFromTGAFile(file);
                        break;
                    }

                    default:
                        throw new NotImplementedException();
                }

                return CreateBitmapImage(image);
            }
            catch
            {
                return null;
            }
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
