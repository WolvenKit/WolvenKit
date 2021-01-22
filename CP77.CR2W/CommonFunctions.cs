using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Catel.IoC;
using Catel.Linq;
using CP77.Common.Services;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WolvenKit.Common.Tools.DDS;
using CP77.CR2W.Types;
using CP77Tools.Model;
using WolvenKit.Common;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W
{
    public static class CommonFunctions
    {
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        ///  Gets the DXGI format for CP77 dds buffers from a given ETextureCompression and ETextureRawFormat
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="rawFormat"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static EFormat GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat)
        {
            switch (compression)
            {
                case ETextureCompression.TCM_QualityR:
                    return EFormat.BC4_UNORM;
                case ETextureCompression.TCM_QualityRG:
                case ETextureCompression.TCM_Normalmap:
                    return EFormat.BC5_UNORM;
                case ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM;
                case ETextureCompression.TCM_DXTNoAlpha:
                case ETextureCompression.TCM_Normals_DEPRECATED:
                    return EFormat.BC1_UNORM;
                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_DXTAlpha:
                    return EFormat.BC3_UNORM;
                case ETextureCompression.TCM_None:
                {
                    switch (rawFormat)
                    {
                        case ETextureRawFormat.TRF_Invalid:
                        case ETextureRawFormat.TRF_TrueColor:
                            return EFormat.R8G8B8A8_UNORM;
                        
                        case ETextureRawFormat.TRF_DeepColor:
                            return EFormat.R10G10B10A2_UNORM;
                        
                        case ETextureRawFormat.TRF_HDRFloat:
                            return EFormat.R32G32B32A32_FLOAT;
                        case ETextureRawFormat.TRF_HDRHalf:
                            return EFormat.R16G16B16A16_FLOAT;
                        case ETextureRawFormat.TRF_HDRFloatGrayscale:
                            return EFormat.R16_FLOAT;
                        case ETextureRawFormat.TRF_R8G8:
                            return EFormat.R8G8_UNORM;
                        
                        case ETextureRawFormat.TRF_Grayscale:
                            return EFormat.R8_UINT;
                        case ETextureRawFormat.TRF_AlphaGrayscale:
                            return EFormat.A8_UNORM;
                        
                        case ETextureRawFormat.TRF_Grayscale_Font:
                            throw new NotImplementedException();
                        case ETextureRawFormat.TRF_R32UI:
                            //return EFormat.R32_UINT;
                            throw new NotImplementedException();
                        default:
                            throw new ArgumentOutOfRangeException(nameof(rawFormat), rawFormat, null);
                    }
                }

                case ETextureCompression.TCM_RGBE:
                case ETextureCompression.TCM_Normals:
                case ETextureCompression.TCM_NormalsHigh_DEPRECATED:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_NormalsGloss_DEPRECATED:
                case ETextureCompression.TCM_NormalsGloss:
                case ETextureCompression.TCM_TileMap:
                case ETextureCompression.TCM_HalfHDR_Unsigned:
                case ETextureCompression.TCM_HalfHDR:
                case ETextureCompression.TCM_HalfHDR_Signed:
                case ETextureCompression.TCM_Max:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(compression), compression, null);
            }
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        /// <param name="DXGIFormat"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static (ETextureCompression, ETextureRawFormat, ETexGroupFlags) GetRedFormatsFromDxgiFormat(EFormat DXGIFormat)
        {
            switch (DXGIFormat)
            {
                case EFormat.R32G32B32A32_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloat, ETexGroupFlags.RawFormatOnly);
                case EFormat.R16G16B16A16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRHalf, ETexGroupFlags.RawFormatOnly);
                case EFormat.R10G10B10A2_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_DeepColor, ETexGroupFlags.RawFormatOnly);
                case EFormat.R8G8B8A8_UNORM:
                    throw new NotImplementedException();
                case EFormat.R32_UINT:
                    throw new NotImplementedException();
                case EFormat.R8G8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_R8G8, ETexGroupFlags.RawFormatOnly);
                case EFormat.R16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloatGrayscale, ETexGroupFlags.RawFormatOnly);
                case EFormat.R8_UINT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_Grayscale, ETexGroupFlags.RawFormatOnly);
                case EFormat.A8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_AlphaGrayscale, ETexGroupFlags.RawFormatOnly);
                case EFormat.BC1_UNORM:
                    return (ETextureCompression.TCM_DXTNoAlpha, ETextureRawFormat.TRF_Invalid, ETexGroupFlags.CompressionOnly);
                case EFormat.BC2_UNORM:
                    throw new NotImplementedException();
                case EFormat.BC3_UNORM:
                    return (ETextureCompression.TCM_DXTAlpha, ETextureRawFormat.TRF_Invalid, ETexGroupFlags.CompressionOnly);
                case EFormat.BC4_UNORM:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid, ETexGroupFlags.CompressionOnly);
                case EFormat.BC5_UNORM:
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid, ETexGroupFlags.CompressionOnly);
                case EFormat.BC7_UNORM:
                    return (ETextureCompression.TCM_QualityColor, ETextureRawFormat.TRF_Invalid, ETexGroupFlags.CompressionOnly);
                default:
                    throw new ArgumentOutOfRangeException(nameof(DXGIFormat), DXGIFormat, null);
            }
        }

        public enum ETexGroupFlags
        {
            CompressionOnly,
            RawFormatOnly,
            Both
        }
        
        public static (ETextureCompression, ETextureRawFormat, ETexGroupFlags) 
            GetRedFormatsFromTextureGroup(GpuWrapApieTextureGroup textureGroup)
        {
            switch (textureGroup)
            {
                case GpuWrapApieTextureGroup.TEXG_Generic_Grayscale:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid,
                        ETexGroupFlags.CompressionOnly);
                case GpuWrapApieTextureGroup.TEXG_Generic_Normal: //TODO: support TCM_Normals_DEPRECATED?
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid,
                        ETexGroupFlags.CompressionOnly);
                case GpuWrapApieTextureGroup.TEXG_Generic_Color:
                case GpuWrapApieTextureGroup.TEXG_Generic_Data:
                case GpuWrapApieTextureGroup.TEXG_Generic_UI:
                case GpuWrapApieTextureGroup.TEXG_Generic_Font:
                case GpuWrapApieTextureGroup.TEXG_Generic_LUT:
                case GpuWrapApieTextureGroup.TEXG_Generic_MorphBlend:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Color:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Normal:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Grayscale:
                case GpuWrapApieTextureGroup.TEXG_Multilayer_Microblend:
                default:
                    throw new ArgumentOutOfRangeException(nameof(textureGroup), textureGroup, null);
            }
        }
    }
}
