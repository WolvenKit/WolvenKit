using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using static WolvenKit.Common.DDS.TexconvNative;

namespace WolvenKit.Common.DDS
{
    public static class Texconv
    {
        public static DDSMetadata GetMetadataFromTGAFile(string path)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var md = TexconvNative.GetMetadataFromTGAFile(path, TGA_FLAGS.TGA_FLAGS_NONE);
                var bpp = TexconvNative.BitsPerPixel(md.format);
                return new DDSMetadata(md, (uint)bpp, true);
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
                var md = TexconvNative.GetMetadataFromDDSFile(path, DDSFLAGS.DDS_FLAGS_NONE);
                var bpp = TexconvNative.BitsPerPixel(md.format);
                return new DDSMetadata(md, (uint)bpp, true);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static DDSMetadata GetMetadataFromDDSMemory(byte[] buffer)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var md = TexconvNative.GetMetadataFromDDSMemory(buffer, DDSFLAGS.DDS_FLAGS_NONE);
                var bpp = TexconvNative.BitsPerPixel(md.format);
                return new DDSMetadata(md, (uint)bpp, true);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static int ComputeRowPitch(int width, int height, DXGI_FORMAT format) => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? (int)TexconvNative.ComputeRowPitch(format, width, height)
                : throw new NotImplementedException();

        public static int ComputeSlicePitch(int width, int height, DXGI_FORMAT format) => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? (int)TexconvNative.ComputeSlicePitch(format, width, height)
                : throw new NotImplementedException();

        public static ESaveFileTypes ToSaveFormat(EUncookExtension extension) =>
            extension switch
            {
                EUncookExtension.bmp => ESaveFileTypes.BMP,
                EUncookExtension.jpg => ESaveFileTypes.JPEG,
                EUncookExtension.png => ESaveFileTypes.PNG,
                EUncookExtension.tga => ESaveFileTypes.TGA,
                EUncookExtension.tiff => ESaveFileTypes.TIFF,
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
        public static bool ConvertFromDdsAndSave(Stream ms, string outfilename, ESaveFileTypes filetype, bool vflip = false, bool hflip = false)
        {
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

                //TexconvNative.ConvertAndSaveDdsImage(rentedBuffer, newpath, filetype, vflip, hflip);
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    var buffer = Array.Empty<byte>();
                    using (var blob = new ManagedBlob())
                    {
                        var l = TexconvNative.ConvertFromDds(rentedBuffer, blob.GetBlob(), filetype, vflip, hflip);
                        buffer = blob.GetBytes();
                    }
                    File.WriteAllBytes(newpath, buffer);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            finally
            {
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
        public static byte[] ConvertFromDds(Stream stream, EUncookExtension textureType, bool vflip = false, bool hflip = false)
        {
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

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    var buffer = Array.Empty<byte>();
                    using (var blob = new ManagedBlob())
                    {
                        var l = TexconvNative.ConvertFromDds(rentedBuffer, blob.GetBlob(), ToSaveFormat(textureType), vflip, hflip);
                        buffer = blob.GetBytes();
                    }
                    return buffer;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            finally
            {
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

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    var buffer = Array.Empty<byte>();
                    using (var blob = new ManagedBlob())
                    {
                        var l = TexconvNative.ConvertToDds(rentedBuffer, blob.GetBlob(), ToSaveFormat(inExtension),
                        format, vflip, hflip);
                        buffer = blob.GetBytes();
                    }
                    return buffer;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            finally
            {
                if (rentedBuffer is not null)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
            }
        }
    }
}
