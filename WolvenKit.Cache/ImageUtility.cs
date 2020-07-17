using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.Cache
{
    using DDS;
    using ImageFormat = Pfim.ImageFormat;

    public static class ImageUtility
    {
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
                        var caption = "Unrecognized format";
                        MessageBox.Show(msg, caption, MessageBoxButtons.OK);
                        return null;
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

        public static Bitmap FromBytes(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return FromStream(ms);
            }
        }

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
                        var caption = "Unrecognized format";
                        MessageBox.Show(msg, caption, MessageBoxButtons.OK);
                        return null;
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

        public static Bitmap Xbm2Bmp(CBitmapTexture xbm)
        {
            if (xbm == null)
                return null;

            int residentMipIndex = xbm.GetVariableByName("residentMipIndex") == null ? 0 : (int)((CUInt8)xbm.GetVariableByName("residentMipIndex")).val;
            byte[] bytesource;
            // handle cooked xbms
            if (xbm.GetVariableByName("sourceData") != null && xbm.Residentmip != null)
            {
                bytesource = xbm.Residentmip.Bytes;
            }
            // handle uncooked xbms
            else if (xbm.Mips != null)
            {
                bytesource = xbm.Mips.elements[residentMipIndex].Bytes;
            }
            else
            {
                return null;
            }

            using (var ms = new MemoryStream(Xbm2DdsBytes(xbm, bytesource)))
            {
                return FromStream(ms);
            }
        }

        //public static DdsImage Xbm2Dds(CBitmapTexture xbm, byte[] rawimage)
        //{
        //    if (xbm == null || rawimage == null)
        //        return null;
        //    return new DdsImage(Xbm2DdsBytes(xbm, rawimage));
        //}



        public static byte[] Xbm2DdsBytes(CBitmapTexture xbm)
        {
            if (xbm == null)
                return null;

            int residentMipIndex = xbm.GetVariableByName("residentMipIndex") == null ? 0 : (int)((CUInt8)xbm.GetVariableByName("residentMipIndex")).val;
            byte[] bytesource;
            // handle cooked xbms
            if (xbm.GetVariableByName("sourceData") == null)
            {
                bytesource = xbm.Residentmip.Bytes;
            }
            // handle imported xbms
            else
            {
                bytesource = xbm.Mips.elements[residentMipIndex].Bytes;
            }

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                DDSUtils.GenerateAndWriteHeader(bw.BaseStream, Xbm2Ddsheader(xbm));

                bw.Write(bytesource);

                ms.Flush();

                return ms.ToArray();
            }
        }

        public static byte[] Xbm2DdsBytes(CBitmapTexture xbm, byte[] bytesource)
        {
            if (xbm == null)
                return null;

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                DDSUtils.GenerateAndWriteHeader(bw.BaseStream, Xbm2Ddsheader(xbm));

                bw.Write(bytesource);

                ms.Flush();

                return ms.ToArray();
            }
        }





        private static DDSMetadata Xbm2Ddsheader(CBitmapTexture xbm)
        {
            try
            {
                int residentMipIndex = xbm.GetVariableByName("residentMipIndex") == null ? 0 : (int)((CUInt8)xbm.GetVariableByName("residentMipIndex")).val;

                int mipcount;
                // handle cooked xbms
                if (xbm.GetVariableByName("sourceData") == null)
                {
                    mipcount = xbm.Mipdata.elements.Count - residentMipIndex;
                }
                // handle imported xbms
                else
                {
                    mipcount = 0;
                }

                uint width = xbm.Mipdata.elements[residentMipIndex].Width.val;
                uint height = xbm.Mipdata.elements[residentMipIndex].Height.val;

                var ecompression = (CName)xbm.GetVariableByName("compression");
                ETextureCompression compression = (ETextureCompression)Enum.Parse(typeof(ETextureCompression), ecompression.Value);
                var eformat = (CName)xbm.GetVariableByName("format");
                ETextureRawFormat format = ETextureRawFormat.TRF_TrueColor;
                if (eformat != null)
                    format = (ETextureRawFormat)Enum.Parse(typeof(ETextureRawFormat), eformat.Value);



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
                                throw new Exception("Invalid compression type! [" + compression + "]");
                        }
                        break;
                    default:
                        throw new Exception("Invalid compression type! [" + compression + "]");
                }

                return new DDSMetadata(width, height, (uint)mipcount, ddsformat);

                
            }
            catch(Exception e)
            {
                //string message = e.Message;
                //string caption = "Error!";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //MessageBox.Show(message, caption, buttons);
                throw e;
            }
            
        }

        /// <summary>
        /// Convert a DDS image to a CBitmapTexture style image
        /// </summary>
        /// <param name="ddsImage">The buffer to remove the header from</param>
        /// <returns>CBitmapTexture style image</returns>
        public static byte[] Dds2Xbm(byte[] ddsImage)
        {
            return ddsImage.Length > 128 ? ddsImage.Skip(128).ToArray() : new byte[0];
        }
    }
}
