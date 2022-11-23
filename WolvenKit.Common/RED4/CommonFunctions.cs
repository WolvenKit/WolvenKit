using System;
using System.Collections.Generic;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;
using static WolvenKit.RED4.CR2W.RedImage;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.CR2W;

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

    /// <summary>
    /// Sets RawFormat, Compression, IsGamma, GenerateMipMaps and IsStreamable from the TextureGroup
    /// </summary>
    /// <param name="textureGroup"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static XbmImportArgs TextureSetupFromTextureGroup(GpuWrapApieTextureGroup textureGroup)
    {
        var outSetup = new XbmImportArgs
        {
            TextureGroup = textureGroup,
            IsGamma = textureGroup is GpuWrapApieTextureGroup.TEXG_Generic_Color or GpuWrapApieTextureGroup.TEXG_Multilayer_Color or GpuWrapApieTextureGroup.TEXG_Generic_UI
        };

        switch (textureGroup)
        {
            case GpuWrapApieTextureGroup.TEXG_Generic_Color:
            case GpuWrapApieTextureGroup.TEXG_Multilayer_Color:
            case GpuWrapApieTextureGroup.TEXG_Multilayer_Microblend:
                outSetup.RawFormat = ETextureRawFormat.TRF_TrueColor;
                outSetup.Compression = ETextureCompression.TCM_QualityColor;
                outSetup.GenerateMipMaps = true;
                outSetup.IsStreamable = true;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_Normal:
            case GpuWrapApieTextureGroup.TEXG_Multilayer_Normal:
                outSetup.RawFormat = ETextureRawFormat.TRF_TrueColor;
                outSetup.Compression = ETextureCompression.TCM_Normalmap;
                outSetup.GenerateMipMaps = true;
                outSetup.IsStreamable = true;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_Data:
                outSetup.RawFormat = ETextureRawFormat.TRF_TrueColor;
                outSetup.Compression = ETextureCompression.TCM_None;
                outSetup.GenerateMipMaps = false;
                outSetup.IsStreamable = true;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_UI:
                outSetup.RawFormat = ETextureRawFormat.TRF_TrueColor;
                outSetup.Compression = ETextureCompression.TCM_DXTAlpha;
                outSetup.GenerateMipMaps = false;
                outSetup.IsStreamable = false;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_Grayscale:
            case GpuWrapApieTextureGroup.TEXG_Multilayer_Grayscale:
                outSetup.RawFormat = ETextureRawFormat.TRF_Grayscale;
                outSetup.Compression = ETextureCompression.TCM_QualityR;
                outSetup.GenerateMipMaps = true;
                outSetup.IsStreamable = true;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_Font:
                outSetup.RawFormat = ETextureRawFormat.TRF_Grayscale_Font;
                outSetup.Compression = ETextureCompression.TCM_None;
                outSetup.GenerateMipMaps = false;
                outSetup.IsStreamable = false;
                break;

            case GpuWrapApieTextureGroup.TEXG_Generic_LUT:
                outSetup.RawFormat = ETextureRawFormat.TRF_DeepColor;
                outSetup.Compression = ETextureCompression.TCM_None;
                outSetup.GenerateMipMaps = false;
                outSetup.IsStreamable = false;
                break;
            case GpuWrapApieTextureGroup.TEXG_Generic_MorphBlend:
                break;
            default:
                throw new ArgumentException("Unknown texture group");
        }

        return outSetup;
    }

    /// <summary>
    /// Sets RawFormat, Compression and PixelSize from DXGI_FORMAT
    /// </summary>
    /// <param name="texFormat"></param>
    /// <returns></returns>
    public static (ETextureRawFormat, ETextureCompression, int) MapGpuToEngineTextureFormat(DXGI_FORMAT texFormat)
    {
        ETextureRawFormat outRawFormat;
        ETextureCompression outCompression;
        int outPixelSize;

        switch (texFormat)
        {
            case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                outRawFormat = ETextureRawFormat.TRF_HDRFloat;
                outCompression = ETextureCompression.TCM_HalfHDR_Unsigned;
                outPixelSize = 16;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                outRawFormat = ETextureRawFormat.TRF_HDRHalf;
                outCompression = ETextureCompression.TCM_HalfHDR_Unsigned;
                outPixelSize = 8;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM:
                outRawFormat = ETextureRawFormat.TRF_DeepColor;
                outCompression = ETextureCompression.TCM_QualityColor;
                outPixelSize = 8;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT:
                outRawFormat = ETextureRawFormat.TRF_HDRFloatGrayscale;
                outCompression = ETextureCompression.TCM_QualityR;
                outPixelSize = 4;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                //case DXGI_FORMAT.L8_UNORM:    //TODO
                // Load as gray scale image
                outRawFormat = ETextureRawFormat.TRF_Grayscale;
                outCompression = ETextureCompression.TCM_QualityR;
                outPixelSize = 1;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                outRawFormat = ETextureRawFormat.TRF_TrueColor;
                outCompression = ETextureCompression.TCM_QualityColor;
                outPixelSize = 4;
                break;

            case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM: //do I need this?
                outRawFormat = ETextureRawFormat.TRF_R8G8;
                outCompression = ETextureCompression.TCM_None;
                outPixelSize = 2;
                break;

            default:
                // Load as True Color image
                outRawFormat = ETextureRawFormat.TRF_TrueColor;
                outCompression = ETextureCompression.TCM_QualityColor;
                outPixelSize = 4;
                break;
        }

        return (outRawFormat, outCompression, outPixelSize);
    }

    public static DXGI_FORMAT GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat, bool isGamma)
    {
        return compression switch
        {
            ETextureCompression.TCM_None => rawFormat switch
            {
                //case ETextureRawFormat.TRF_Invalid:
                //    return DXGI_FORMAT.R8G8B8A8_UNORM;
                ETextureRawFormat.TRF_TrueColor => isGamma ? DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                ETextureRawFormat.TRF_Grayscale => DXGI_FORMAT.DXGI_FORMAT_R8_UNORM,
                ETextureRawFormat.TRF_Grayscale_Font => DXGI_FORMAT.DXGI_FORMAT_A8_UNORM,
                ETextureRawFormat.TRF_HDRFloat => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
                ETextureRawFormat.TRF_HDRHalf => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT,
                ETextureRawFormat.TRF_DeepColor => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM,
                ETextureRawFormat.TRF_HDRFloatGrayscale => DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT,
                ETextureRawFormat.TRF_R8G8 => DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM,
                ETextureRawFormat.TRF_R32UI => DXGI_FORMAT.DXGI_FORMAT_R32_UINT,

                ETextureRawFormat.TRF_Invalid => throw new NotImplementedException(),
                ETextureRawFormat.TRF_Max => throw new NotImplementedException(),
                _ => throw new ArgumentOutOfRangeException(),
            },
            ETextureCompression.TCM_DXTNoAlpha => isGamma ? DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM,
            ETextureCompression.TCM_DXTAlpha => isGamma ? DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
            ETextureCompression.TCM_DXTAlphaLinear => isGamma ? DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
            ETextureCompression.TCM_RGBE => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
            ETextureCompression.TCM_Normalmap => DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM,
            ETextureCompression.TCM_Normals_DEPRECATED => DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM,
            ETextureCompression.TCM_NormalsHigh_DEPRECATED => DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
            ETextureCompression.TCM_NormalsGloss_DEPRECATED => DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
            ETextureCompression.TCM_QualityR => DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM,
            ETextureCompression.TCM_QualityRG => DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM,
            ETextureCompression.TCM_QualityColor => isGamma ? DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM,
            ETextureCompression.TCM_HalfHDR_Unsigned => DXGI_FORMAT.DXGI_FORMAT_BC6H_UF16,
            ETextureCompression.TCM_HalfHDR_Signed => DXGI_FORMAT.DXGI_FORMAT_BC6H_SF16,

            ETextureCompression.TCM_TileMap => throw new NotImplementedException(),
            ETextureCompression.TCM_Max => throw new NotImplementedException(),
            ETextureCompression.TCM_Normals => throw new NotImplementedException(),
            ETextureCompression.TCM_NormalsHigh => throw new NotImplementedException(),
            ETextureCompression.TCM_NormalsGloss => throw new NotImplementedException(),
            ETextureCompression.TCM_HalfHDR => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException(),
        };
    }

    public static GpuWrapApieTextureGroup GetTextureGroupFromFileName(string fileName)
    {
        GpuWrapApieTextureGroup ret;
        if (fileName.EndsWith("_n"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Normal;
        }
        else if (fileName.EndsWith("_rm"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Color;
        }
        else if (fileName.EndsWith("_r"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Grayscale;
        }
        else if (fileName.EndsWith("_m"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Grayscale;
        }
        else if (fileName.EndsWith("_b"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Color;
        }
        else if (fileName.EndsWith("nm"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Normal;
        }
        else if (fileName.EndsWith("_data"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Data;
        }
        else if (fileName.EndsWith("_lut"))
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_LUT;
        }
        else
        {
            ret = GpuWrapApieTextureGroup.TEXG_Generic_Color;
        }

        return ret;
    }

}
