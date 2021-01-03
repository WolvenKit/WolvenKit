using System;
using System.Drawing;
using System.IO;
using System.Linq;
using WolvenKit.CR2W.Types;
using System.Runtime.InteropServices;
using WolvenKit.Common.Tools.DDS;
using static WolvenKit.CR2W.Types.Enums;
using static WolvenKit.Common.Tools.DDS.TexconvWrapper;

namespace WolvenKit.Model
{
    using System.Drawing.Imaging;
    using WolvenKit.Common;
    using WolvenKit.Common.Model;
    using WolvenKit.Common.Tools;
    using WolvenKit.Common.Wcc;
    using ImageFormat = Pfim.ImageFormat;

    public static class ImageUtility
    {
        /// <summary>
        /// Gets the redengine texture format from the compression method
        /// Used when creating a dds from an xbm
        /// TODO: TEST THIS!!!
        /// </summary>
        /// <param name="compression"></param>
        /// <returns></returns>
        public static EFormat GetEFormatFromCompression(ETextureCompression compression)
        {
            switch (compression)
            {
                // missing:  0xFD
                // missing:  0x0    //EFormat.R8G8B8A8_UNORM
                case ETextureCompression.TCM_None:
                    return EFormat.R8G8B8A8_UNORM;
                

                //0x07 // exception: characters\models\animals\goose\model\t_01__goose_d01.xbm has 0x07 but TCM_DXTAlpha
                case ETextureCompression.TCM_DXTNoAlpha:
                case ETextureCompression.TCM_Normals:
                    return EFormat.BC1_UNORM;

                //0x08 // exception: characters\models\animals\goose\model\t_01__goose_d01.xbm has 0x07 but TCM_DXTAlpha
                case ETextureCompression.TCM_DXTAlpha:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_NormalsGloss:
                    return EFormat.BC3_UNORM; 


                case ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM; //0x0A

                // missing:  0x0D   //EFormat.BC2_UNORM // used for not imported dds files in texturecache therefore will never come up here

                case ETextureCompression.TCM_QualityR:
                    return EFormat.BC4_UNORM; //0x0E

                case ETextureCompression.TCM_QualityRG:
                    return EFormat.BC5_UNORM; //0x0F

                case ETextureCompression.TCM_DXTAlphaLinear:    // unused
                case ETextureCompression.TCM_RGBE:              // unused
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Taken from game files /engine/textures/texturegroups.xml
        /// </summary>
        /// <param name="textureGroup"></param>
        /// <returns></returns>
        public static ETextureCompression GetTextureCompressionFromTextureGroup(ETextureGroup textureGroup)
        {
            switch (textureGroup)
            {
                case ETextureGroup.SystemNoMips:
                    return ETextureCompression.TCM_None;

                case ETextureGroup.MimicDecalsNormal:
                case ETextureGroup.FoliageDiffuse:
                case ETextureGroup.WorldDiffuseWithAlpha:
                case ETextureGroup.Particles:
                case ETextureGroup.WorldSpecular:
                case ETextureGroup.BillboardAtlas:
                //case ETextureGroup.TerrainDiffuseAtlas: // found in engine.xml but not in wcc enum /shrug
                case ETextureGroup.GUIWithAlpha:
                case ETextureGroup.CharacterDiffuseWithAlpha:
                case ETextureGroup.HeadDiffuseWithAlpha:
                    return ETextureCompression.TCM_DXTAlpha;

                case ETextureGroup.SpecialQuestDiffuse:
                case ETextureGroup.TerrainDiffuse:
                case ETextureGroup.GUIWithoutAlpha:
                case ETextureGroup.WorldDiffuse:
                case ETextureGroup.ParticlesWithoutAlpha:
                case ETextureGroup.CharacterDiffuse:
                case ETextureGroup.CharacterEmissive:
                case ETextureGroup.HeadDiffuse:
                case ETextureGroup.HeadEmissive:
                case ETextureGroup.DiffuseNoMips:
                    return ETextureCompression.TCM_DXTNoAlpha;

                //case ETextureGroup.TerrainNormalAtlas: // found in engine.xml but not in wcc enum /shrug
                case ETextureGroup.DetailNormalMap:
                case ETextureGroup.WorldNormalHQ:
                case ETextureGroup.SpecialQuestNormal:
                case ETextureGroup.CharacterNormalHQ:
                case ETextureGroup.HeadNormalHQ:
                    return ETextureCompression.TCM_NormalsHigh;


                case ETextureGroup.NormalmapGloss:
                case ETextureGroup.CharacterNormalmapGloss:
                case ETextureGroup.NormalsNoMips:
                    return ETextureCompression.TCM_NormalsGloss;

                case ETextureGroup.TerrainNormal:
                case ETextureGroup.CharacterNormal:
                case ETextureGroup.HeadNormal:
                    return ETextureCompression.TCM_Normals;

                case ETextureGroup.QualityOneChannel:
                    return ETextureCompression.TCM_QualityR;

                case ETextureGroup.QualityTwoChannels:
                    return ETextureCompression.TCM_QualityRG;

                case ETextureGroup.QualityColor:
                    return ETextureCompression.TCM_QualityColor;

                case ETextureGroup.Default:
                case ETextureGroup.Font:
                case ETextureGroup.Flares:
                case ETextureGroup.WorldNormal:
                case ETextureGroup.PostFxMap:
                //case ETextureGroup.TerrainSpecial: // found in engine.xml but not in wcc enum /shrug
                default:
                    throw new NotImplementedException();
            }
        }




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
        private static Bitmap FromStream(Stream stream)
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

            

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                DDSUtils.GenerateAndWriteHeader(bw.BaseStream, GetDDSMetadata(xbm));

                bw.Write(xbm.GetBytes());

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
            int residentMipIndex = xbm.ResidentMipIndex?.val ?? 0;
                
            int mipcount = xbm.Mipdata.elements.Count - residentMipIndex;

            uint width = xbm.Mipdata.elements[residentMipIndex].Width.val;
            uint height = xbm.Mipdata.elements[residentMipIndex].Height.val;

            ETextureCompression compression = xbm.Compression.WrappedEnum;

            var ddsformat = ImageUtility.GetEFormatFromCompression(compression);


            // TODO: TEST THIS
            if (ddsformat == EFormat.R8G8B8A8_UNORM)
            {
                ETextureRawFormat format = xbm.Format.WrappedEnum;
                switch (format)
                {
                    
                    case ETextureRawFormat.TRF_Grayscale:   // only this is ever used
                        break;
                    case ETextureRawFormat.TRF_TrueColor:   // this is set if format is NULL
                    case ETextureRawFormat.TRF_HDR:
                    case ETextureRawFormat.TRF_AlphaGrayscale:
                    case ETextureRawFormat.TRF_HDRGrayscale:
                    default:
                        ddsformat = EFormat.R8G8B8A8_UNORM;
                        //throw new Exception("Invalid texture format type! [" + format + "]");
                        break;
                }
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
