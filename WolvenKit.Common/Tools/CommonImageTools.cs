using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Wcc;
using static WolvenKit.DDS.TexconvWrapper;

namespace WolvenKit.Common.Tools
{
    public static class CommonImageTools
    {
        /// <summary>
        /// Gets the texture compression method from some weird enum used in xbms
        /// TODO: TEST THIS!!!
        /// </summary>
        /// <param name="redbyte"></param>
        /// <returns></returns>
        public static ETextureFormat GetTextureFormatFromREDEngineByte(short redbyte)
        {
            switch (redbyte)
            {
                case 0x0:
                    return ETextureFormat.TEXFMT_R8G8B8A8;
                case 0xFD:
                    return ETextureFormat.TEXFMT_R8G8B8A8;
                case 0x07:
                    return ETextureFormat.TEXFMT_BC1;
                case 0x08:
                    return ETextureFormat.TEXFMT_BC3;
                case 0x09:
                    return ETextureFormat.TEXFMT_BC6H;
                case 0x0A:
                    return ETextureFormat.TEXFMT_BC7;
                case 0x0B:
                    return ETextureFormat.TEXFMT_Float_R16G16B16A16;
                case 0x0C:
                    return ETextureFormat.TEXFMT_Float_R32G32B32A32;
                case 0x0D:
                    return ETextureFormat.TEXFMT_BC2;
                case 0x0E:
                    return ETextureFormat.TEXFMT_BC4;
                case 0x0F:
                    return ETextureFormat.TEXFMT_BC5;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        /// <summary>
        /// Translates REDEngine textureformats to DXGI textureformat used in texconv
        /// TODO: TEST THIS!!!
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public static EFormat GetTexconvFormatFromTextureFormat(ETextureFormat format)
        {
            switch (format)
            {
                case ETextureFormat.TEXFMT_BC1:
                    return EFormat.BC1_UNORM;
                case ETextureFormat.TEXFMT_BC2:
                    return EFormat.BC2_UNORM;
                case ETextureFormat.TEXFMT_BC3:
                    return EFormat.BC3_UNORM;
                case ETextureFormat.TEXFMT_BC4:
                    return EFormat.BC4_UNORM;
                case ETextureFormat.TEXFMT_BC5:
                    return EFormat.BC5_UNORM;
                case ETextureFormat.TEXFMT_BC7:
                    return EFormat.BC7_UNORM;
                case ETextureFormat.TEXFMT_R8G8B8A8:
                    return EFormat.R8G8B8A8_UNORM;
                case ETextureFormat.TEXFMT_NULL:
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        


        public static void ConvertDDSTo(Stream stream)
        {
            using (var image = new MagickImage(stream))
            {
                



            }



        }

        public static void ReadImageMetaData(Stream stream)
        {
            var info = new MagickImageInfo(stream);

            stream.Seek(0, SeekOrigin.Begin);
            using (var image = new MagickImage(stream))
            {




            }

            

        }

        

        public static (int height, int width) ReadImageMetaData(string filepath)
        {
            var info = new MagickImageInfo(filepath);

            //using (var image = Pfim.Pfim.FromFile(filepath))
            //{


            //}




            // expretimental wkit import
            //CommonImageTools.ReadImageMetaData(fullpath);

            // read metadata
            // width, height: can be gotten from ImageMagick
            int height = info.Height;
            int width = info.Width;
            // compression: look up in texturegroups.xml
            // texturegroup: gotten from here

            // unk1, unk2: ???
            // Mipdata: create mips?


            // create xbm


            // create cr2wfile

            return (height, width);
        }




    }
}
