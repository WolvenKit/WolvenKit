using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Common.DDS
{
    public static class Texconv
    {
        public static DDSMetadata GetMetadataFromTGAFile(string path)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var md = TexHelper.Instance.GetMetadataFromTGAFile(path);
                var bpp = TexHelper.Instance.BitsPerPixel(md.Format);
                return new DDSMetadata((uint)md.Width, (uint)md.Height, (uint)md.Depth, (uint)md.ArraySize, (uint)md.MipLevels, (uint)md.MiscFlags, (uint)md.MiscFlags2, (DXGI_FORMAT)md.Format, (TEX_DIMENSION)md.Dimension, (uint)bpp, true);
            }
            else
            {
                //using (var image = Image.Load(path))
                //{

                //}
                throw new NotImplementedException();
            }
        }

        public static DDSMetadata GetMetadataFromDDSFile(string path)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var md = TexHelper.Instance.GetMetadataFromDDSFile(path, DDS_FLAGS.NONE);
                var bpp = TexHelper.Instance.BitsPerPixel(md.Format);
                return new DDSMetadata((uint)md.Width, (uint)md.Height, (uint)md.Depth, (uint)md.ArraySize, (uint)md.MipLevels, (uint)md.MiscFlags, (uint)md.MiscFlags2, (DXGI_FORMAT)md.Format, (TEX_DIMENSION)md.Dimension, (uint)bpp, true);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static unsafe DDSMetadata GetMetadataFromDDSMemory(byte[] buffer)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                fixed (byte* pIn = buffer)
                {
                    var md = TexHelper.Instance.GetMetadataFromDDSMemory((IntPtr)pIn, buffer.Length, DDS_FLAGS.NONE);
                    var bpp = TexHelper.Instance.BitsPerPixel(md.Format);
                    return new DDSMetadata((uint)md.Width, (uint)md.Height, (uint)md.Depth, (uint)md.ArraySize, (uint)md.MipLevels, (uint)md.MiscFlags, (uint)md.MiscFlags2, (DXGI_FORMAT)md.Format, (TEX_DIMENSION)md.Dimension, (uint)bpp, true);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static int ComputeRowPitch(int width, int height, DXGI_FORMAT format)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                TexHelper.Instance.ComputePitch((DirectXTexNet.DXGI_FORMAT)format, width, height, out var rowPitch, out _, CP_FLAGS.NONE);
                return (int)rowPitch;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static int ComputeSlicePitch(int width, int height, DXGI_FORMAT format)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                TexHelper.Instance.ComputePitch((DirectXTexNet.DXGI_FORMAT)format, width, height, out _, out var slicePitch, CP_FLAGS.NONE);
                return (int)slicePitch;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static TexconvNative.ESaveFileTypes ToSaveFormat(EUncookExtension extension) =>
            extension switch
            {
                EUncookExtension.bmp => TexconvNative.ESaveFileTypes.BMP,
                EUncookExtension.jpg => TexconvNative.ESaveFileTypes.JPEG,
                EUncookExtension.png => TexconvNative.ESaveFileTypes.PNG,
                EUncookExtension.tga => TexconvNative.ESaveFileTypes.TGA,
                EUncookExtension.tiff => TexconvNative.ESaveFileTypes.TIFF,
                _ => throw new ArgumentOutOfRangeException(nameof(extension), extension, null)
            };


        /// <summary>
        /// Converts a dds stream to another texture file type and writes it to file
        /// </summary>
        /// <param name="ms">The input dds stream</param>
        /// <param name="outfilename">The output filename. Extension will be overwritten with the correct filetype</param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool ConvertFromDdsAndSave(Stream ms, string outfilename, ExportArgs args)
        {
            // check if stream is dds
            if (!DDSUtils.IsDdsFile(ms))
            {
                throw new ArgumentException("Input stream not a dds file", nameof(ms));
            }

            // get arguments
            var uext = EUncookExtension.dds;
            var vflip = false;
            if (args is not XbmExportArgs and not MlmaskExportArgs)
            {
                return false;

            }
            switch (args)
            {
                case XbmExportArgs xbm:
                    uext = xbm.UncookExtension;
                    vflip = xbm.Flip;
                    break;
                case MlmaskExportArgs ml:
                    uext = ml.UncookExtension.FromMlMaskExtension();
                    break;
            }

            return uext != EUncookExtension.dds && ConvertFromDdsAndSave(ms, outfilename, ToSaveFormat(uext), vflip);
        }
        public static bool ConvertFromDdsAndSave(Stream ms, string outfilename, TexconvNative.ESaveFileTypes filetype, bool vflip = false, bool hflip = false)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new NotImplementedException();
            }

            byte[] rentedBuffer = null;
            try
            {
                var offset = 0;

                var len = checked((int)ms.Length);
                rentedBuffer = ArrayPool<byte>.Shared.Rent(len);

                int readBytes;
                while (offset < len &&
                       (readBytes = ms.Read(rentedBuffer, offset, len - offset)) > 0)
                {
                    offset += readBytes;
                }

                var outDir = new FileInfo(outfilename).Directory.FullName;
                Directory.CreateDirectory(outDir);
                var fileName = Path.GetFileNameWithoutExtension(outfilename);
                var extension = filetype.ToString().ToLower();
                var newpath = Path.Combine(outDir, $"{fileName}.{extension}");

                var image = TexHelper.Instance.LoadFromDDSMemory(rentedBuffer, DDS_FLAGS.NONE, out var metadata);
                if (TexHelper.Instance.IsCompressed(metadata.Format))
                {
                    image = image.Decompress(DirectXTexNet.DXGI_FORMAT.UNKNOWN);
                }

                var flip = TEX_FR_FLAGS.ROTATE0;
                if (vflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_VERTICAL;
                }

                if (hflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_HORIZONTAL;
                }

                if (flip != 0)
                {
                    image = image.FlipRotate(flip);
                }

                UnmanagedMemoryStream outStream;
                switch (filetype)
                {
                    case TexconvNative.ESaveFileTypes.BMP:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.BMP));
                        break;
                    case TexconvNative.ESaveFileTypes.PNG:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.PNG));
                        break;
                    case TexconvNative.ESaveFileTypes.TGA:
                        outStream = image.SaveToTGAMemory(0);
                        break;
                    case TexconvNative.ESaveFileTypes.TIFF:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.TIFF));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(filetype), filetype, null);
                }

                //TexconvNative.ConvertAndSaveDdsImage(rentedBuffer, newpath, filetype, vflip, hflip);
                var outBuffer = new byte[outStream.Length];
                outStream.Read(outBuffer, 0, outBuffer.Length);
                File.WriteAllBytes(newpath, outBuffer);
            }
            finally
            {
                if (rentedBuffer is object)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }

            return true;
        }

        /// <summary>
        /// Converts a dds image to another texture format
        /// </summary>
        public static byte[] ConvertFromDds(Stream stream, EUncookExtension textureType, bool vflip = false, bool hflip = false)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new NotImplementedException();
            }

            if (textureType == EUncookExtension.dds)
            {
                throw new NotSupportedException("texture to convert from dds must not be dds iteslf");
            }

            byte[] rentedBuffer = null;
            try
            {
                var offset = 0;

                var len = checked((int)stream.Length);
                rentedBuffer = ArrayPool<byte>.Shared.Rent(len);

                int readBytes;
                while (offset < len &&
                       (readBytes = stream.Read(rentedBuffer, offset, len - offset)) > 0)
                {
                    offset += readBytes;
                }

                var filetype = ToSaveFormat(textureType);

                var image = TexHelper.Instance.LoadFromDDSMemory(rentedBuffer, DDS_FLAGS.NONE, out var metadata);
                if (TexHelper.Instance.IsCompressed(metadata.Format))
                {
                    image = image.Decompress(DirectXTexNet.DXGI_FORMAT.UNKNOWN);
                }

                var flip = TEX_FR_FLAGS.ROTATE0;
                if (vflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_VERTICAL;
                }

                if (hflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_HORIZONTAL;
                }

                if (flip != 0)
                {
                    image = image.FlipRotate(flip);
                }

                UnmanagedMemoryStream outStream;
                switch (filetype)
                {
                    case TexconvNative.ESaveFileTypes.BMP:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.BMP));
                        break;
                    case TexconvNative.ESaveFileTypes.PNG:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.PNG));
                        break;
                    case TexconvNative.ESaveFileTypes.TGA:
                        outStream = image.SaveToTGAMemory(0);
                        break;
                    case TexconvNative.ESaveFileTypes.TIFF:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.TIFF));
                        break;
                    case TexconvNative.ESaveFileTypes.JPEG:
                        outStream = image.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.JPEG));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(filetype), filetype, null);
                }

                //TexconvNative.ConvertAndSaveDdsImage(rentedBuffer, newpath, filetype, vflip, hflip);
                var outBuffer = new byte[outStream.Length];
                outStream.Read(outBuffer, 0, outBuffer.Length);

                return outBuffer;
            }
            finally
            {
                if (rentedBuffer is object)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }
        }

        /// <summary>
        /// Converts texture stream with given extension stream to dds
        /// </summary>
        public static byte[] ConvertToDds(Stream stream, EUncookExtension inExtension, DXGI_FORMAT? outFormat = null, bool vflip = false, bool hflip = false)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new NotImplementedException();
            }

            if (inExtension == EUncookExtension.dds)
            {
                throw new NotSupportedException("texture to convert to dds must not be dds iteslf");
            }

            byte[] rentedBuffer = null;
            try
            {
                var offset = 0;

                var len = checked((int)stream.Length);
                rentedBuffer = ArrayPool<byte>.Shared.Rent(len);

                int readBytes;
                while (offset < len &&
                       (readBytes = stream.Read(rentedBuffer, offset, len - offset)) > 0)
                {
                    offset += readBytes;
                }

                var format = outFormat ?? DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;

                var fileType = ToSaveFormat(inExtension);

                ScratchImage image;
                switch (fileType)
                {
                    case TexconvNative.ESaveFileTypes.BMP:
                        image = TexHelper.Instance.LoadFromWICMemory(rentedBuffer, WIC_FLAGS.NONE);
                        break;
                    case TexconvNative.ESaveFileTypes.JPEG:
                        image = TexHelper.Instance.LoadFromWICMemory(rentedBuffer, WIC_FLAGS.NONE);
                        break;
                    case TexconvNative.ESaveFileTypes.PNG:
                        image = TexHelper.Instance.LoadFromWICMemory(rentedBuffer, WIC_FLAGS.NONE);
                        break;
                    case TexconvNative.ESaveFileTypes.TGA:
                        image = TexHelper.Instance.LoadFromTGAMemory(rentedBuffer);
                        break;
                    case TexconvNative.ESaveFileTypes.TIFF:
                        image = TexHelper.Instance.LoadFromWICMemory(rentedBuffer, WIC_FLAGS.NONE);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var flip = TEX_FR_FLAGS.ROTATE0;
                if (vflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_VERTICAL;
                }

                if (hflip)
                {
                    flip |= TEX_FR_FLAGS.FLIP_HORIZONTAL;
                }

                if (flip != 0)
                {
                    image = image.FlipRotate(flip);
                }

                image.OverrideFormat((DirectXTexNet.DXGI_FORMAT)format);

                var outStream = image.SaveToDDSMemory(DDS_FLAGS.NONE);

                var outBuffer = new byte[outStream.Length];
                outStream.Read(outBuffer, 0, outBuffer.Length);

                return outBuffer;
            }
            finally
            {
                if (rentedBuffer is object)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }
        }
    }
}
