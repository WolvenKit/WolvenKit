using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W.Types;

namespace CP77.CR2W
{
    public static class CommonFunctions
    {
        public static EFormat GetEformatFromCompression(Enums.ETextureCompression compression)
        {
            switch (compression)
            {
                case Enums.ETextureCompression.TCM_QualityR:
                case Enums.ETextureCompression.TCM_QualityRG:
                    return EFormat.BC5_UNORM;
                case Enums.ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM;
                case Enums.ETextureCompression.TCM_DXTNoAlpha:
                case Enums.ETextureCompression.TCM_Normalmap:
                case Enums.ETextureCompression.TCM_Normals_DEPRECATED:
                    return EFormat.BC1_UNORM;
                case Enums.ETextureCompression.TCM_DXTAlphaLinear:
                case Enums.ETextureCompression.TCM_DXTAlpha:
                    return EFormat.BC3_UNORM;
                case Enums.ETextureCompression.TCM_None:
                    return EFormat.R8G8B8A8_UNORM;
                case Enums.ETextureCompression.TCM_RGBE:
                case Enums.ETextureCompression.TCM_Normals:
                case Enums.ETextureCompression.TCM_NormalsHigh_DEPRECATED:
                case Enums.ETextureCompression.TCM_NormalsHigh:
                case Enums.ETextureCompression.TCM_NormalsGloss_DEPRECATED:
                case Enums.ETextureCompression.TCM_NormalsGloss:
                case Enums.ETextureCompression.TCM_TileMap:
                case Enums.ETextureCompression.TCM_HalfHDR_Unsigned:
                case Enums.ETextureCompression.TCM_HalfHDR:
                case Enums.ETextureCompression.TCM_HalfHDR_Signed:
                case Enums.ETextureCompression.TCM_Max:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(compression), compression, null);
            }


        }
    }
}
