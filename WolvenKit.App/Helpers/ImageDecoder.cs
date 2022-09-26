using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pfim;
using Splat;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Functionality.Other
{
    public static class ImageDecoder
    {
        public static async Task<BitmapSource> RenderToBitmapSourceDds(Stream stream)
        {
            try
            {
                stream.Seek(0, SeekOrigin.Begin);
                var image = Pfimage.FromStream(stream);
                await stream.DisposeAsync().ConfigureAwait(false);
                var pinnedArray = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                var addr = pinnedArray.AddrOfPinnedObject();
                var pfimPic = BitmapSource.Create(image.Width, image.Height, 96.0, 96.0,
                    PixelFormat(image), null, addr, image.DataLen, image.Stride);
                image.Dispose();
                pfimPic.Freeze();
                // yes
                //return new TransformedBitmap(pfimPic, new ScaleTransform(1, -1));
                return pfimPic;
            }
            catch (Exception e)
            {
                Locator.Current.GetService<ILoggerService>()?.Error(e);

                return null;
            }
        }


        /// <summary>
        /// Decodes image from file to BitMapSource
        /// </summary>
        /// <param name="file">Absolute path of the file</param>
        /// <returns></returns>
        public static async Task<BitmapSource> RenderToBitmapSource(string file)
        {
            try
            {
                var ext = Path.GetExtension(file).ToUpperInvariant();
                FileStream filestream;
                switch (ext)
                {
                    case ".JPG":
                    case ".JPEG":
                    case ".JPE":
                    {
                        Stream imageStreamSource = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                        var decoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                        return decoder.Frames[0];
                    }
                    case ".PNG":
                    {
                        Stream imageStreamSource = new FileStream("smiley.png", FileMode.Open, FileAccess.Read, FileShare.Read);
                        var decoder = new PngBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                        return decoder.Frames[0];
                    }
                    case ".BMP":
                    {
                        var myUri = new Uri("tulipfarm.bmp", UriKind.RelativeOrAbsolute);
                        var decoder = new BmpBitmapDecoder(myUri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                        return decoder.Frames[0];
                    }

                    case ".TIF":
                    case ".TIFF":
                    {
                        Stream imageStreamSource = new FileStream("tulipfarm.tif", FileMode.Open, FileAccess.Read, FileShare.Read);
                        var decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                        return decoder.Frames[0];
                    }
                    //case ".GIF":
                    //case ".ICO":
                    //case ".JFIF":
                    //case ".WEBP":
                    //case ".WBMP":
                    //    filestream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan);
                    //    var sKBitmap = SKBitmap.Decode(filestream);
                    //    await filestream.DisposeAsync().ConfigureAwait(false);

                    //    if (sKBitmap == null)
                    //    {
                    //        return null;
                    //    }

                    //    var skPic = sKBitmap.ToWriteableBitmap();
                    //    skPic.Freeze();
                    //    sKBitmap.Dispose();
                    //    return skPic;

                    case ".DDS":
                    case ".TGA": // TODO some tga files are created upside down https://github.com/Ruben2776/PicView/issues/22
                        filestream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan);
                        var image = Pfimage.FromStream(filestream);
                        await filestream.DisposeAsync().ConfigureAwait(false);
                        var pinnedArray = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                        var addr = pinnedArray.AddrOfPinnedObject();
                        var pfimPic = BitmapSource.Create(image.Width, image.Height, 96.0, 96.0,
                            PixelFormat(image), null, addr, image.DataLen, image.Stride);
                        image.Dispose();
                        pfimPic.Freeze();
                        return pfimPic;

                    //case ".PSD":
                    //case ".PSB":
                    //case ".SVG":
                    //case ".XCF":
                    //    filestream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan);
                    //    var transMagick = new MagickImage();
                    //    transMagick.Read(filestream);
                    //    await filestream.DisposeAsync().ConfigureAwait(false);

                    //    transMagick.Quality = 100;
                    //    transMagick.ColorSpace = ColorSpace.Transparent;

                    //    var psd = transMagick.ToBitmapSource();
                    //    transMagick.Dispose();
                    //    psd.Freeze();

                    //    return psd;

                    default: // some formats cause exceptions when using filestream, so defaulting to reading from file
                        //var magick = new MagickImage();
                        //magick.Read(file);

                        //// Set values for maximum quality
                        //magick.Quality = 100;

                        //var pic = magick.ToBitmapSource();
                        //magick.Dispose();
                        //pic.Freeze();

                        //return pic;

                        throw new NotImplementedException();

                }
            }
            catch
            {

                return null;
            }
        }

        private static PixelFormat PixelFormat(IImage image) => image.Format switch
        {
            ImageFormat.Rgb24 => PixelFormats.Bgr24,
            ImageFormat.Rgba32 => PixelFormats.Bgr32,
            ImageFormat.Rgb8 => PixelFormats.Gray8,
            ImageFormat.R5g5b5a1 or ImageFormat.R5g5b5 => PixelFormats.Bgr555,
            ImageFormat.R5g6b5 => PixelFormats.Bgr565,
            _ => throw new Exception($"Unable to convert {image.Format} to WPF PixelFormat"),
        };


    }

    public class XenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && (value as string) != "")
            {
                var q = ImageDecoder.RenderToBitmapSource(value as string);
                return q;
            }

            return null;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

    }
}
