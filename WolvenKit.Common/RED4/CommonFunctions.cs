using System;
using System.Collections.Generic;
using WolvenKit.Common.DDS;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.CR2W
{
    public static class CommonFunctions
    {
        public static string GetResourceClassesFromExtension(ERedExtension extension)
        {
            foreach (var fileType in FileTypeHelper.FileTypes)
            {
                if (fileType.Extension == extension)
                {
                    return fileType.RootType.Name;
                }
            }

            return null;
        }

        public static ERedExtension[] GetExtensionFromResourceClass(string resourceClass)
        {
            var ext = new List<ERedExtension>();
            foreach (var fileType in FileTypeHelper.FileTypes)
            {
                if (fileType.RootType.Name == resourceClass)
                {
                    ext.Add(fileType.Extension);
                }
            }

            return ext.ToArray();
        }

        #region Methods

        /// <summary>
        ///  Gets the DXGI format for CP77 dds buffers from a given ETextureCompression and ETextureRawFormat
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="rawFormat"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static DXGI_FORMAT GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat, ILoggerService logger)
        {
            switch (compression)
            {
                case ETextureCompression.TCM_QualityR:
                    return DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM;

                case ETextureCompression.TCM_QualityRG:
                case ETextureCompression.TCM_Normalmap:
                    return DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM;

                case ETextureCompression.TCM_QualityColor:
                    return DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM;

                case ETextureCompression.TCM_DXTNoAlpha:
                case ETextureCompression.TCM_Normals_DEPRECATED:
                    return DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM;

                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_DXTAlpha:
                case ETextureCompression.TCM_NormalsHigh_DEPRECATED:
                    return DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM;

                case ETextureCompression.TCM_None:
                {
                    switch (rawFormat)
                    {
                        case ETextureRawFormat.TRF_Invalid:
                        case ETextureRawFormat.TRF_TrueColor:
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;

                        case ETextureRawFormat.TRF_DeepColor:
                            return DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM;

                        case ETextureRawFormat.TRF_HDRFloat:
                            return DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT;

                        case ETextureRawFormat.TRF_HDRHalf:
                            return DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT;

                        case ETextureRawFormat.TRF_HDRFloatGrayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT;

                        case ETextureRawFormat.TRF_R8G8:
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM;

                        case ETextureRawFormat.TRF_Grayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_R8_UINT;

                        case ETextureRawFormat.TRF_AlphaGrayscale:
                            return DXGI_FORMAT.DXGI_FORMAT_A8_UNORM;

                        case ETextureRawFormat.TRF_Grayscale_Font:
                        //throw new NotImplementedException($"{nameof(GetDXGIFormat)}: TRF_Grayscale_Font");
                        case ETextureRawFormat.TRF_R32UI:
                            //return DXGI_FORMAT.R32_UINT;
                            //throw new NotImplementedException($"{nameof(GetDXGIFormat)}: TRF_R32UI");
                            logger.Warning($"Unknown texture format: {rawFormat.ToString()}");
                            return DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(rawFormat), rawFormat, null);
                    }
                }

                case ETextureCompression.TCM_RGBE:
                case ETextureCompression.TCM_Normals:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_NormalsGloss_DEPRECATED:
                case ETextureCompression.TCM_NormalsGloss:
                case ETextureCompression.TCM_TileMap:
                case ETextureCompression.TCM_HalfHDR_Unsigned:
                case ETextureCompression.TCM_HalfHDR:
                case ETextureCompression.TCM_HalfHDR_Signed:
                case ETextureCompression.TCM_Max:
                {
                    logger.Warning($"Unknown texture compression format: {compression.ToString()}");
                    return DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM;
                }
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
        public static (ETextureCompression, ETextureRawFormat) GetRedFormatsFromDxgiFormat(DXGI_FORMAT DXGIFormat)
        {
            switch (DXGIFormat)
            {
                case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloat);

                case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRHalf);

                case DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_DeepColor);

                case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_TrueColor);

                case DXGI_FORMAT.DXGI_FORMAT_R32_UINT:
                    throw new NotImplementedException($"{nameof(GetRedFormatsFromDxgiFormat)}: R32_UINT");

                case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_R8G8);

                case DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_HDRFloatGrayscale);

                case DXGI_FORMAT.DXGI_FORMAT_R8_UINT:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_Grayscale);

                case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                    return (ETextureCompression.TCM_None, ETextureRawFormat.TRF_AlphaGrayscale);

                case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
                    return (ETextureCompression.TCM_DXTNoAlpha, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM:
                    throw new NotImplementedException($"{nameof(GetRedFormatsFromDxgiFormat)}: BC2_UNORM");

                case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
                    return (ETextureCompression.TCM_DXTAlpha, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid);

                case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
                    return (ETextureCompression.TCM_QualityColor, ETextureRawFormat.TRF_Invalid);

                default:
                    throw new ArgumentOutOfRangeException(nameof(DXGIFormat), DXGIFormat, null);
            }
        }

        public static (ETextureCompression, ETextureRawFormat)
            GetRedFormatsFromTextureGroup(GpuWrapApieTextureGroup textureGroup)
        {
            switch (textureGroup)
            {
                case GpuWrapApieTextureGroup.TEXG_Generic_Grayscale:
                    return (ETextureCompression.TCM_QualityR, ETextureRawFormat.TRF_Invalid);

                case GpuWrapApieTextureGroup.TEXG_Generic_Normal: //TODO: support TCM_Normals_DEPRECATED?
                    return (ETextureCompression.TCM_Normalmap, ETextureRawFormat.TRF_Invalid);

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




        #endregion Methods
    }
}
