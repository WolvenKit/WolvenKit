using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using WolvenKit.Common.DDS;
using WolvenKit.CR2W.Types;
using ImageFormat = Pfim.ImageFormat;

namespace WolvenKit.MVVM.Model
{
    public static class ImageUtility
    {
        #region Methods

        /// <summary>
        /// Gets the image bytes from a dds byte array, trims the first 128 bytes
        /// </summary>
        /// <param name="ddsImage"></param>
        /// <returns></returns>
        public static byte[] Dds2Bytes(byte[] ddsImage)
        {
            return ddsImage.Length > 128 ? ddsImage.Skip(128).ToArray() : new byte[0];
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
        /// Gets the redengine texture format from the compression method
        /// Used when creating a dds from an xbm
        /// TODO: TEST THIS!!!
        /// </summary>
        /// <param name="compression"></param>
        /// <returns></returns>
        public static EFormat GetEFormatFromCompression(Enums.ETextureCompression compression)
        {
            switch (compression)
            {
                // missing:  0xFD
                // missing:  0x0    //EFormat.R8G8B8A8_UNORM
                case Enums.ETextureCompression.TCM_None:
                    return EFormat.R8G8B8A8_UNORM;

                //0x07 // exception: characters\models\animals\goose\model\t_01__goose_d01.xbm has 0x07 but TCM_DXTAlpha
                case Enums.ETextureCompression.TCM_DXTNoAlpha:
                case Enums.ETextureCompression.TCM_Normals:
                    return EFormat.BC1_UNORM;

                //0x08 // exception: characters\models\animals\goose\model\t_01__goose_d01.xbm has 0x07 but TCM_DXTAlpha
                case Enums.ETextureCompression.TCM_DXTAlpha:
                case Enums.ETextureCompression.TCM_NormalsHigh:
                case Enums.ETextureCompression.TCM_NormalsGloss:
                    return EFormat.BC3_UNORM;

                case Enums.ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM; //0x0A

                // missing:  0x0D   //EFormat.BC2_UNORM // used for not imported dds files in texturecache therefore will never come up here

                case Enums.ETextureCompression.TCM_QualityR:
                    return EFormat.BC4_UNORM; //0x0E

                case Enums.ETextureCompression.TCM_QualityRG:
                    return EFormat.BC5_UNORM; //0x0F

                case Enums.ETextureCompression.TCM_DXTAlphaLinear:    // unused
                case Enums.ETextureCompression.TCM_RGBE:              // unused
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Taken from game files /engine/textures/texturegroups.xml
        /// </summary>
        /// <param name="textureGroup"></param>
        /// <returns></returns>
        public static Enums.ETextureCompression GetTextureCompressionFromTextureGroup(Common.Wcc.ETextureGroup textureGroup)
        {
            switch (textureGroup)
            {
                case Common.Wcc.ETextureGroup.SystemNoMips:
                    return Enums.ETextureCompression.TCM_None;

                case Common.Wcc.ETextureGroup.MimicDecalsNormal:
                case Common.Wcc.ETextureGroup.FoliageDiffuse:
                case Common.Wcc.ETextureGroup.WorldDiffuseWithAlpha:
                case Common.Wcc.ETextureGroup.Particles:
                case Common.Wcc.ETextureGroup.WorldSpecular:
                case Common.Wcc.ETextureGroup.BillboardAtlas:
                //case Common.Wcc.ETextureGroup.TerrainDiffuseAtlas: // found in engine.xml but not in wcc enum /shrug
                case Common.Wcc.ETextureGroup.GUIWithAlpha:
                case Common.Wcc.ETextureGroup.CharacterDiffuseWithAlpha:
                case Common.Wcc.ETextureGroup.HeadDiffuseWithAlpha:
                    return Enums.ETextureCompression.TCM_DXTAlpha;

                case Common.Wcc.ETextureGroup.SpecialQuestDiffuse:
                case Common.Wcc.ETextureGroup.TerrainDiffuse:
                case Common.Wcc.ETextureGroup.GUIWithoutAlpha:
                case Common.Wcc.ETextureGroup.WorldDiffuse:
                case Common.Wcc.ETextureGroup.ParticlesWithoutAlpha:
                case Common.Wcc.ETextureGroup.CharacterDiffuse:
                case Common.Wcc.ETextureGroup.CharacterEmissive:
                case Common.Wcc.ETextureGroup.HeadDiffuse:
                case Common.Wcc.ETextureGroup.HeadEmissive:
                case Common.Wcc.ETextureGroup.DiffuseNoMips:
                    return Enums.ETextureCompression.TCM_DXTNoAlpha;

                //case Common.Wcc.ETextureGroup.TerrainNormalAtlas: // found in engine.xml but not in wcc enum /shrug
                case Common.Wcc.ETextureGroup.DetailNormalMap:
                case Common.Wcc.ETextureGroup.WorldNormalHQ:
                case Common.Wcc.ETextureGroup.SpecialQuestNormal:
                case Common.Wcc.ETextureGroup.CharacterNormalHQ:
                case Common.Wcc.ETextureGroup.HeadNormalHQ:
                    return Enums.ETextureCompression.TCM_NormalsHigh;

                case Common.Wcc.ETextureGroup.NormalmapGloss:
                case Common.Wcc.ETextureGroup.CharacterNormalmapGloss:
                case Common.Wcc.ETextureGroup.NormalsNoMips:
                    return Enums.ETextureCompression.TCM_NormalsGloss;

                case Common.Wcc.ETextureGroup.TerrainNormal:
                case Common.Wcc.ETextureGroup.CharacterNormal:
                case Common.Wcc.ETextureGroup.HeadNormal:
                    return Enums.ETextureCompression.TCM_Normals;

                case Common.Wcc.ETextureGroup.QualityOneChannel:
                    return Enums.ETextureCompression.TCM_QualityR;

                case Common.Wcc.ETextureGroup.QualityTwoChannels:
                    return Enums.ETextureCompression.TCM_QualityRG;

                case Common.Wcc.ETextureGroup.QualityColor:
                    return Enums.ETextureCompression.TCM_QualityColor;

                case Common.Wcc.ETextureGroup.Default:
                case Common.Wcc.ETextureGroup.Font:
                case Common.Wcc.ETextureGroup.Flares:
                case Common.Wcc.ETextureGroup.WorldNormal:
                case Common.Wcc.ETextureGroup.PostFxMap:
                //case Common.Wcc.ETextureGroup.TerrainSpecial: // found in engine.xml but not in wcc enum /shrug
                default:
                    throw new NotImplementedException();
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

            Enums.ETextureCompression compression = xbm.Compression.WrappedEnum;

            var ddsformat = ImageUtility.GetEFormatFromCompression(compression);

            // TODO: TEST THIS
            if (ddsformat == EFormat.R8G8B8A8_UNORM)
            {
                Enums.ETextureRawFormat format = xbm.Format.WrappedEnum;
                switch (format)
                {
                    case Enums.ETextureRawFormat.TRF_Grayscale:   // only this is ever used
                        break;

                    case Enums.ETextureRawFormat.TRF_TrueColor:   // this is set if format is NULL
                    case Enums.ETextureRawFormat.TRF_HDR:
                    case Enums.ETextureRawFormat.TRF_AlphaGrayscale:
                    case Enums.ETextureRawFormat.TRF_HDRGrayscale:
                    default:
                        ddsformat = EFormat.R8G8B8A8_UNORM;
                        //throw new Exception("Invalid texture format type! [" + format + "]");
                        break;
                }
            }

            return new DDSMetadata(width, height, (uint)mipcount, ddsformat);
        }

        #endregion Methods
    }
}
