using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

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
                EUncookExtension.dds => TexconvNative.ESaveFileTypes.DDS,
                _ => throw new ArgumentOutOfRangeException(nameof(extension), extension, null)
            };


        /// <summary>
        /// Converts a dds stream to another texture file type and writes it to file
        /// </summary>
        /// <param name="ms">The input dds stream</param>
        /// <param name="outfilename">The output filename. Extension will be overwritten with the correct filetype</param>
        /// <param name="args"></param>
        /// <param name="vflip"></param>
        /// <param name="decompressedFormat"></param>
        /// <returns></returns>
        public static bool ConvertFromDdsAndSave(Stream ms, string outfilename, ExportArgs args, bool vflip, DXGI_FORMAT decompressedFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN)
        {
            // check if stream is dds
            if (!DDSUtils.IsDdsFile(ms))
            {
                throw new ArgumentException("Input stream not a dds file", nameof(ms));
            }

            // get arguments
            var uext = EUncookExtension.dds;
            if (args is not XbmExportArgs and not MlmaskExportArgs)
            {
                return false;

            }

            uext = args switch
            {
                XbmExportArgs xbm => xbm.UncookExtension,
                MlmaskExportArgs ml => ml.UncookExtension,
                _ => uext
            };

            return ConvertFromDdsAndSave(ms, outfilename, ToSaveFormat(uext), vflip, decompressedFormat);
        }
        public static bool ConvertFromDdsAndSave(Stream ms, string outfilename, TexconvNative.ESaveFileTypes filetype, bool vflip, DXGI_FORMAT decompressedFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new NotImplementedException();
            }

            RedImage? image = null;
            byte[]? rentedBuffer = null;
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

                var outDir = new FileInfo(outfilename).Directory?.FullName;
                Directory.CreateDirectory(outDir.NotNull());
                var fileName = Path.GetFileNameWithoutExtension(outfilename);
                var extension = filetype.ToString().ToLower();
                var newpath = Path.Combine(outDir, $"{fileName}.{extension}");

                image = RedImage.LoadFromDDSMemory(rentedBuffer, Enums.ETextureRawFormat.TRF_HDRFloat); // forcing best?
                if (image == null)
                {
                    throw new ArgumentException($"Could not load image file");
                }

                if (vflip)
                {
                    image.FlipV();
                }

                switch (filetype)
                {
                    case TexconvNative.ESaveFileTypes.DDS:
                        image.SaveToDDS(newpath);
                        break;
                    case TexconvNative.ESaveFileTypes.BMP:
                        image.SaveToBMP(newpath);
                        break;
                    case TexconvNative.ESaveFileTypes.PNG:
                        image.SaveToPNG(newpath);
                        break;
                    case TexconvNative.ESaveFileTypes.TGA:
                        image.SaveToTGA(newpath);
                        break;
                    case TexconvNative.ESaveFileTypes.TIFF:
                        image.SaveToTIFF(newpath);
                        break;
                    case TexconvNative.ESaveFileTypes.JPEG:
                        image.SaveToJPEG(newpath);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(filetype), filetype, null);
                }
            }
            finally
            {
                image?.Dispose();

                if (rentedBuffer is not null)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }

            return true;
        }

        /// <summary>
        /// Converts a dds image to another texture format
        /// </summary>
        public static byte[] ConvertFromDds(Stream stream, EUncookExtension textureType)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                throw new NotImplementedException();
            }

            if (textureType == EUncookExtension.dds)
            {
                throw new NotSupportedException("texture to convert from dds must not be dds iteslf");
            }

            RedImage? image = null;
            byte[]? rentedBuffer = null;
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

                image = RedImage.LoadFromDDSMemory(rentedBuffer);
                if (image == null)
                {
                    throw new ArgumentException("Could not load dds file");
                }

                var filetype = ToSaveFormat(textureType);

                return filetype switch
                {
                    TexconvNative.ESaveFileTypes.BMP => image.SaveToBMPMemory(),
                    TexconvNative.ESaveFileTypes.PNG => image.SaveToPNGMemory(),
                    TexconvNative.ESaveFileTypes.TGA => image.SaveToTGAMemory(),
                    TexconvNative.ESaveFileTypes.TIFF => image.SaveToTIFFMemory(),
                    TexconvNative.ESaveFileTypes.JPEG => image.SaveToJPEGMemory(),
                    _ => throw new ArgumentOutOfRangeException(nameof(filetype), filetype, null),
                };
            }
            finally
            {
                image?.Dispose();

                if (rentedBuffer is not null)
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

            RedImage? image = null;
            byte[]? rentedBuffer = null;
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

                var fileType = ToSaveFormat(inExtension);

                image = fileType switch
                {
                    TexconvNative.ESaveFileTypes.BMP or TexconvNative.ESaveFileTypes.JPEG or TexconvNative.ESaveFileTypes.PNG or TexconvNative.ESaveFileTypes.TIFF => RedImage.FromWICBuffer(rentedBuffer),
                    TexconvNative.ESaveFileTypes.TGA => RedImage.FromTGABuffer(rentedBuffer),
                    _ => throw new ArgumentOutOfRangeException(),
                };
                if (outFormat != null && image.Metadata.Format != outFormat)
                {
                    image.Convert((DXGI_FORMAT)outFormat);
                }

                return image.SaveToDDSMemory();
            }
            finally
            {
                image?.Dispose();

                if (rentedBuffer is not null)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }
        }
    }
}
