using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Tools.DDS;
using static WolvenKit.Common.Tools.DDS.TexconvWrapper;

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
        public static EFormat GetEFormatFromREDEngineByte(byte redbyte)
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

        public static (byte, byte) GetREDEngineByteFromEFormat(EFormat fmt)
        {
            switch (fmt)
            {
                case EFormat.R8G8B8A8_UNORM: return (0xFD, 0x3); // Attention! this returns 0xFDx 0x3 //TODO: 
                case EFormat.BC1_UNORM: return (0x7, 0x4);
                case EFormat.BC2_UNORM: return (0x0D, 0x4);
                case EFormat.BC3_UNORM: return (0x08, 0x4);
                case EFormat.BC4_UNORM: return (0x0E, 0x4);
                case EFormat.BC5_UNORM: return (0x0F, 0x4);
                case EFormat.BC7_UNORM: return (0x0A, 0x4);
                default:
                    return (0x0, 0x0); // Attention! this returns 0x 0x
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
