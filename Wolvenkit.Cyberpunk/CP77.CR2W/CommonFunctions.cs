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
        public static EFormat GetDXGIFormatFromXBM(Enums.ETextureCompression compression, Enums.ETextureRawFormat rawFormat)
        {
            switch (compression)
            {
                case Enums.ETextureCompression.TCM_QualityR:
                    return EFormat.BC4_UNORM;
                case Enums.ETextureCompression.TCM_QualityRG:
                case Enums.ETextureCompression.TCM_Normalmap:
                    return EFormat.BC5_UNORM;
                case Enums.ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM;
                case Enums.ETextureCompression.TCM_DXTNoAlpha:
                case Enums.ETextureCompression.TCM_Normals_DEPRECATED:
                    return EFormat.BC1_UNORM;
                case Enums.ETextureCompression.TCM_DXTAlphaLinear:
                case Enums.ETextureCompression.TCM_DXTAlpha:
                    return EFormat.BC3_UNORM;
                case Enums.ETextureCompression.TCM_None:
                {
                    switch (rawFormat)
                    {
                           
                        case Enums.ETextureRawFormat.TRF_Invalid:
                            return EFormat.R8G8B8A8_UNORM;
                        case Enums.ETextureRawFormat.TRF_Grayscale_Font:
                            throw new NotImplementedException();
                        case Enums.ETextureRawFormat.TRF_R32UI:
                            //return EFormat.R32_UINT;
                            throw new NotImplementedException();
                        case Enums.ETextureRawFormat.TRF_DeepColor:
                            return EFormat.R10G10B10A2_UNORM;
                        case Enums.ETextureRawFormat.TRF_TrueColor:
                            return EFormat.R8G8B8A8_UNORM;
                        
                        case Enums.ETextureRawFormat.TRF_HDRFloat:
                            return EFormat.R32G32B32A32_FLOAT;
                        case Enums.ETextureRawFormat.TRF_HDRHalf:
                            return EFormat.R16G16B16A16_FLOAT;
                        case Enums.ETextureRawFormat.TRF_HDRFloatGrayscale:
                            return EFormat.R16_FLOAT;
                        case Enums.ETextureRawFormat.TRF_R8G8:
                            return EFormat.R8G8_UNORM;


                        case Enums.ETextureRawFormat.TRF_Grayscale:
                            return EFormat.R8_UINT;
                        case Enums.ETextureRawFormat.TRF_AlphaGrayscale:
                            return EFormat.A8_UNORM;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(rawFormat), rawFormat, null);
                    }
                }
                    
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
