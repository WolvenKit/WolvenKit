using System;
using System.Drawing;
using System.IO;
using System.Linq;
using WolvenKit.CR2W.Types;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.App.Model
{
    using DDS;
    using WolvenKit.Common;
    using ImageFormat = Pfim.ImageFormat;

    public static class ImageUtility
    {
        /// <summary>
        /// Create a System.Drawing.Bitmap from a physical file with Pfim
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Bitmap FromFile(string path)
        {
            using (var image = Pfim.Pfim.FromFile(path))
            {
                PixelFormat format;

                // Convert from Pfim's backend agnostic image format into GDI+'s image format
                switch (image.Format)
                {
                    case ImageFormat.Rgb24:
                        format = PixelFormat.Format24bppRgb;
                        break;

                    case ImageFormat.Rgba32:
                        format = PixelFormat.Format32bppArgb;
                        break;

                    case ImageFormat.R5g5b5:
                        format = PixelFormat.Format16bppRgb555;
                        break;

                    case ImageFormat.R5g6b5:
                        format = PixelFormat.Format16bppRgb565;
                        break;

                    case ImageFormat.R5g5b5a1:
                        format = PixelFormat.Format16bppArgb1555;
                        break;

                    case ImageFormat.Rgb8:
                        format = PixelFormat.Format8bppIndexed;
                        break;

                    default:
                        var msg = $"{image.Format} is not recognized for Bitmap on Windows Forms. " +
                                   "You'd need to write a conversion function to convert the data to known format";
                        //var caption = "Unrecognized format";
                        //MessageBox.Show(msg, caption, MessageBoxButtons.OK);
                        throw new NotImplementedException(msg);
                }

                // Pin pfim's data array so that it doesn't get reaped by GC
                var handle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                try
                {
                    var data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
                    return new Bitmap(image.Width, image.Height, image.Stride, format, data);
                }
                finally
                {
                    handle.Free();
                }
            }
        }

        /// <summary>
        /// Create a System.Drawing.Bitmap from a byte array with Pfim
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Bitmap FromBytes(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return FromStream(ms);
            }
        }

        /// <summary>
        /// Create a System.Drawing.Bitmap from a stream with Pfim
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Bitmap FromStream(Stream stream)
        {
            using (var image = Pfim.Pfim.FromStream(stream))
            {
                PixelFormat format;

                // Convert from Pfim's backend agnostic image format into GDI+'s image format
                switch (image.Format)
                {
                    case ImageFormat.Rgb24:
                        format = PixelFormat.Format24bppRgb;
                        break;

                    case ImageFormat.Rgba32:
                        format = PixelFormat.Format32bppArgb;
                        break;

                    case ImageFormat.R5g5b5:
                        format = PixelFormat.Format16bppRgb555;
                        break;

                    case ImageFormat.R5g6b5:
                        format = PixelFormat.Format16bppRgb565;
                        break;

                    case ImageFormat.R5g5b5a1:
                        format = PixelFormat.Format16bppArgb1555;
                        break;

                    case ImageFormat.Rgb8:
                        format = PixelFormat.Format8bppIndexed;
                        break;

                    default:
                        var msg = $"{image.Format} is not recognized for Bitmap on Windows Forms. " +
                                   "You'd need to write a conversion function to convert the data to known format";
                        //var caption = "Unrecognized format";
                        //MessageBox.Show(msg, caption, MessageBoxButtons.OK);
                        throw new NotImplementedException(msg);
                }

                // Pin pfim's data array so that it doesn't get reaped by GC
                var handle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                try
                {
                    var data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
                    return new Bitmap(image.Width, image.Height, image.Stride, format, data);
                }
                finally
                {
                    handle.Free();
                }
            }
        }

        /// <summary>
        /// Create a System.Drawing.Bitmap from a Redengine CBitmapTexture with Wkit DDS Utility
        /// </summary>
        /// <param name="xbm"></param>
        /// <returns></returns>
        public static Bitmap Xbm2Bmp(CBitmapTexture xbm)
        {
            if (xbm == null)
                return null;

            using (var ms = new MemoryStream(Xbm2DdsBytes(xbm)))
            {
                return FromStream(ms);
            }
        }

        /// <summary>
        /// Create a byte array from a Redengine CBitmapTexture with Wkit DDS Utility
        /// </summary>
        /// <param name="xbm"></param>
        /// <returns></returns>
        public static byte[] Xbm2DdsBytes(CBitmapTexture xbm)
        {
            if (xbm == null)
                return null;

            byte[] bytesource;
            if (xbm.Residentmip != null && xbm.Residentmip.Bytes != null)
            {
                bytesource = xbm.Residentmip.Bytes;
            }
            else
            {
                throw new NotImplementedException();
            }

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                DDSUtils.GenerateAndWriteHeader(bw.BaseStream, GetDDSMetadata(xbm));

                bw.Write(bytesource);

                ms.Flush();

                return ms.ToArray();
            }
        }

        /// <summary>
        /// Generate DDSMetadata from a Redengine CBitmapTexture
        /// </summary>
        /// <param name="xbm"></param>
        /// <returns></returns>
        private static DDSMetadata GetDDSMetadata(CBitmapTexture xbm)
        {
            int residentMipIndex = xbm.ResidentMipIndex == null ? 0 : xbm.ResidentMipIndex.val;
                
            int mipcount = xbm.Mipdata.elements.Count - residentMipIndex;

            uint width = xbm.Mipdata.elements[residentMipIndex].Width.val;
            uint height = xbm.Mipdata.elements[residentMipIndex].Height.val;

            ETextureCompression compression = xbm.Compression.WrappedEnum;

            var ddsformat = ETextureFormat.TEXFMT_R8G8B8A8;
            switch (compression)
            {
                    
                case ETextureCompression.TCM_DXTNoAlpha:
                    ddsformat = ETextureFormat.TEXFMT_BC1;
                    break;
                case ETextureCompression.TCM_DXTAlpha:
                    ddsformat = ETextureFormat.TEXFMT_BC3;
                    break;
                case ETextureCompression.TCM_Normals:
                    ddsformat = ETextureFormat.TEXFMT_BC1;
                    break;
                case ETextureCompression.TCM_NormalsHigh:
                    ddsformat = ETextureFormat.TEXFMT_BC3;
                    break;
                case ETextureCompression.TCM_NormalsGloss:
                    ddsformat = ETextureFormat.TEXFMT_BC3;
                    break;
                case ETextureCompression.TCM_QualityR:
                    ddsformat = ETextureFormat.TEXFMT_BC4;
                    break;
                case ETextureCompression.TCM_QualityRG:
                    ddsformat = ETextureFormat.TEXFMT_BC5;
                    break;
                case ETextureCompression.TCM_QualityColor:
                    ddsformat = ETextureFormat.TEXFMT_BC3;
                    break;
                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_RGBE:
                case ETextureCompression.TCM_None:
                    {
                        ETextureRawFormat format = xbm.Format.WrappedEnum;
                        switch (format)
                        {
                            case ETextureRawFormat.TRF_TrueColor:
                                ddsformat = ETextureFormat.TEXFMT_R8G8B8A8;
                                break;
                            case ETextureRawFormat.TRF_Grayscale:
                                break;
                            case ETextureRawFormat.TRF_HDR:
                            case ETextureRawFormat.TRF_AlphaGrayscale:
                            case ETextureRawFormat.TRF_HDRGrayscale:
                            default:
                                ddsformat = ETextureFormat.TEXFMT_R8G8B8A8;
                                //throw new Exception("Invalid texture format type! [" + format + "]");
                                break;
                        }
                        break;
                    }
                default:
                    throw new Exception("Invalid texture compression type! [" + compression + "]");
            }

            return new DDSMetadata(width, height, (uint)mipcount, ddsformat);
        }

        /// <summary>
        /// Gets the image bytes from a dds byte array, trims the first 128 bytes
        /// </summary>
        /// <param name="ddsImage"></param>
        /// <returns></returns>
        public static byte[] Dds2Bytes(byte[] ddsImage)
        {
            return ddsImage.Length > 128 ? ddsImage.Skip(128).ToArray() : new byte[0];
        }
    }
}
