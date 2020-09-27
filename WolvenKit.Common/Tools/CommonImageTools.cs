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
        /// Used when extracting from texture cache
        /// </summary>
        /// <param name="redbyte"></param>
        /// <returns></returns>
        public static EFormat GetEFormatFromREDEngineByte(short redbyte)
        {
            switch (redbyte)
            {
                case 0x0:                                          // None
                case 0xFD: return EFormat.R8G8B8A8_UNORM;          // UNKNOWN FORMAT
                case 0x07: return EFormat.BC1_UNORM;               //TCM_DXTNoAlpha, TCM_Normals
                case 0x08: return EFormat.BC3_UNORM;               //TCM_DXTAlpha, TCM_NormalsHigh, TCM_NormalsGloss
                //case 0x09: return EFormat.BC6H_UF16;               // unused
                case 0x0A: return EFormat.BC7_UNORM;               //TCM_QualityColor
                //case 0x0B: return EFormat.R16G16B16A16_FLOAT;      // unused
                //case 0x0C: return EFormat.R32G32B32A32_FLOAT;      // unused
                case 0x0D: return EFormat.BC2_UNORM;               // ???
                case 0x0E: return EFormat.BC4_UNORM;               //TCM_QualityR
                case 0x0F: return EFormat.BC5_UNORM;               //TCM_QualityRG
                default:
                    throw new NotImplementedException();
            }
        }

        public enum ERedTextureFormat
        {
            BC1_UNORM = 7,
            BC3_UNORM = 8,

            BC7_UNORM = 10,
            
            BC2_UNORM = 13,
            BC4_UNORM = 14,
            BC5_UNORM = 15,

            R8G8B8A8_UNORM = 253 // unknown?
        }
    }
}
