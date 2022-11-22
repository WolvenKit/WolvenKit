using System;
using System.Collections.Generic;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using static WolvenKit.RED4.Types.Enums;
using DXGI_FORMAT = WolvenKit.Common.DDS.DXGI_FORMAT;

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

        public static DirectXTexNet.DXGI_FORMAT GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat, bool isGamma/*, ILoggerService logger*/)
        {
            return compression switch
            {
                ETextureCompression.TCM_None => rawFormat switch
                {
                    //case ETextureRawFormat.TRF_Invalid:
                    //    return DirectXTexNet.DXGI_FORMAT.R8G8B8A8_UNORM;
                    ETextureRawFormat.TRF_TrueColor => isGamma ? DirectXTexNet.DXGI_FORMAT.R8G8B8A8_UNORM_SRGB : DirectXTexNet.DXGI_FORMAT.R8G8B8A8_UNORM,
                    ETextureRawFormat.TRF_Grayscale => DirectXTexNet.DXGI_FORMAT.R8_UNORM,
                    ETextureRawFormat.TRF_Grayscale_Font => DirectXTexNet.DXGI_FORMAT.A8_UNORM,
                    ETextureRawFormat.TRF_HDRFloat => DirectXTexNet.DXGI_FORMAT.R32G32B32A32_FLOAT,
                    ETextureRawFormat.TRF_HDRHalf => DirectXTexNet.DXGI_FORMAT.R16G16B16A16_FLOAT,
                    ETextureRawFormat.TRF_DeepColor => DirectXTexNet.DXGI_FORMAT.R16G16B16A16_UNORM,
                    ETextureRawFormat.TRF_HDRFloatGrayscale => DirectXTexNet.DXGI_FORMAT.R32_FLOAT,
                    ETextureRawFormat.TRF_R8G8 => DirectXTexNet.DXGI_FORMAT.R8G8_UNORM,
                    ETextureRawFormat.TRF_R32UI => DirectXTexNet.DXGI_FORMAT.R32_UINT,
                    _ => throw new ArgumentOutOfRangeException(),//logger.Warning($"Unknown texture format: {rawFormat}");
                },
                ETextureCompression.TCM_DXTNoAlpha => isGamma ? DirectXTexNet.DXGI_FORMAT.BC1_UNORM_SRGB : DirectXTexNet.DXGI_FORMAT.BC1_UNORM,
                ETextureCompression.TCM_DXTAlpha => isGamma ? DirectXTexNet.DXGI_FORMAT.BC3_UNORM_SRGB : DirectXTexNet.DXGI_FORMAT.BC3_UNORM,
                ETextureCompression.TCM_DXTAlphaLinear => isGamma ? DirectXTexNet.DXGI_FORMAT.BC3_UNORM_SRGB : DirectXTexNet.DXGI_FORMAT.BC3_UNORM,
                ETextureCompression.TCM_RGBE => DirectXTexNet.DXGI_FORMAT.R32G32B32A32_FLOAT,
                ETextureCompression.TCM_Normalmap => DirectXTexNet.DXGI_FORMAT.BC5_UNORM,
                ETextureCompression.TCM_Normals_DEPRECATED => DirectXTexNet.DXGI_FORMAT.BC1_UNORM,
                ETextureCompression.TCM_NormalsHigh_DEPRECATED => DirectXTexNet.DXGI_FORMAT.BC3_UNORM,
                ETextureCompression.TCM_NormalsGloss_DEPRECATED => DirectXTexNet.DXGI_FORMAT.BC3_UNORM,
                ETextureCompression.TCM_QualityR => DirectXTexNet.DXGI_FORMAT.BC4_UNORM,
                ETextureCompression.TCM_QualityRG => DirectXTexNet.DXGI_FORMAT.BC5_UNORM,
                ETextureCompression.TCM_QualityColor => isGamma ? DirectXTexNet.DXGI_FORMAT.BC7_UNORM_SRGB : DirectXTexNet.DXGI_FORMAT.BC7_UNORM,
                ETextureCompression.TCM_HalfHDR_Unsigned => DirectXTexNet.DXGI_FORMAT.BC6H_UF16,
                ETextureCompression.TCM_HalfHDR_Signed => DirectXTexNet.DXGI_FORMAT.BC6H_SF16,
                _ => throw new ArgumentOutOfRangeException(),//logger.Warning($"Unknown texture compression format: {compression}");
            };
        }
    }
}
