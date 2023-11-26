using System;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
using DXGI_FORMAT = DirectXTexNet.DXGI_FORMAT;
using TEX_DIMENSION = DirectXTexNet.TEX_DIMENSION;

#pragma warning disable CS0414

namespace WolvenKit.RED4.CR2W;

public class TexMetadataWrapper
{
    private readonly TexMetadata _metadata;

    internal TexMetadataWrapper(TexMetadata metadata) => _metadata = metadata;

    public int Width => _metadata.Width;
    public int Height => _metadata.Height;
    public int Depth => _metadata.Depth;
    public int ArraySize => _metadata.ArraySize;
    public int MipLevels => _metadata.MipLevels;
    public Common.DDS.TEX_MISC_FLAG MiscFlags => (Common.DDS.TEX_MISC_FLAG)(uint)_metadata.MiscFlags;
    public Common.DDS.TEX_MISC_FLAG2 MiscFlags2 => (Common.DDS.TEX_MISC_FLAG2)(uint)_metadata.MiscFlags2;
    public Common.DDS.DXGI_FORMAT Format => (Common.DDS.DXGI_FORMAT)(uint)_metadata.Format;
    public Common.DDS.TEX_DIMENSION Dimension => (Common.DDS.TEX_DIMENSION)(uint)_metadata.Dimension;

    public bool IsCubemap() => _metadata.IsCubemap();
    public bool IsPMAlpha() => _metadata.IsPMAlpha();
    public Common.DDS.TEX_ALPHA_MODE GetAlphaMode() => (Common.DDS.TEX_ALPHA_MODE)(uint)_metadata.GetAlphaMode();
    public bool IsVolumemap() => _metadata.IsVolumemap();
}

public class RedImage : IDisposable
{
    public static ILoggerService? LoggerService { private get; set; }

    private static readonly SharpDX.Direct3D11.Device? s_device;

    private ScratchImage _scratchImage;
    private TexMetadata _metadata;

    private DXGI_FORMAT? _compressionFormat;

    private bool _disposed = false;

    private RedImage(ScratchImage scratchImage)
    {
        if (_scratchImage is { IsDisposed: false })
        {
            _scratchImage.Dispose();
        }
        _scratchImage = scratchImage;
        _metadata = _scratchImage.GetMetadata();
    }

    private ScratchImage InternalScratchImage
    {
        get => _scratchImage;
        set
        {
            if (_scratchImage is { IsDisposed: false })
            {
                _scratchImage.Dispose();
            }
            _scratchImage = value;
            _metadata = _scratchImage.GetMetadata();
        }
    }

    public TexMetadataWrapper Metadata => new(_metadata);

    static RedImage()
    {
        s_device = new SharpDX.Direct3D11.Device(DriverType.Hardware, DeviceCreationFlags.BgraSupport);
        if (s_device.FeatureLevel < FeatureLevel.Level_10_0)
        {
            s_device.Dispose();
            s_device = null;
        }
    }

    public Enums.GpuWrapApieTextureGroup Group { get; set; }
    public bool IsStreamable { get; set; }
    public bool GenerateMipMaps { get; set; }
    public byte PlatformMipBiasPC { get; set; }
    public bool AllowTextureDowngrade { get; set; }

    public uint Flags { get; set; } = 1;
    public uint Version { get; set; } = 2;

    public WolvenKit.Common.DDS.DXGI_FORMAT? CompressionFormat
    {
        get
        {
            if (_compressionFormat != null)
            {
                return (WolvenKit.Common.DDS.DXGI_FORMAT)(uint)_compressionFormat;
            }

            return null;
        }
        set
        {
            if (value != null)
            {
                _compressionFormat = (DXGI_FORMAT)(uint)value;
            }
            else
            {
                _compressionFormat = null;
            }

        }
    }

    public bool IsGamma => TexHelper.Instance.IsSRGB(_metadata.Format);

    #region LoadFromFileFormat

    public static RedImage? LoadFromFile(string filePath)
    {
        var fileName = Path.GetFileName(filePath);
        var extension = Path.GetExtension(filePath);
        if (string.IsNullOrEmpty(extension))
        {
            LoggerService?.Error($"[RedImage] \"{fileName}\" has no extension!");
            return null;
        }

        try
        {
            switch (extension.ToUpper())
            {
                case ".JPG" or ".JPEG" or ".JPE":
                    return LoadFromJPGFile(filePath);
                case ".TIF" or ".TIFF":
                    return LoadFromTIFFFile(filePath);
                case ".PNG":
                    return LoadFromPNGFile(filePath);
                case ".BMP":
                    return LoadFromBMPFile(filePath);
                case ".TGA":
                    return LoadFromTGAFile(filePath);
                case ".DDS":
                    return LoadFromDDSFile(filePath);
                default:
                {
                    LoggerService?.Error($"[RedImage] \"{fileName}\" has an unsupported extension!");
                    return null;
                }
            }
        }
        catch (Exception)
        {
            LoggerService?.Error($"[RedImage] \"{fileName}\" contains invalid data!");
            return null;
        }
    }

    public static RedImage? LoadFromDDSMemory(byte[] buffer) => LoadFromDDSMemory(buffer, DXGI_FORMAT.UNKNOWN);

    public static RedImage? LoadFromDDSMemory(byte[] buffer, Enums.ETextureRawFormat format) => LoadFromDDSMemory(buffer, (DXGI_FORMAT)format);

    public static RedImage? LoadFromDDSMemory(byte[] buffer, Common.DDS.DXGI_FORMAT format) => LoadFromDDSMemory(buffer, (DXGI_FORMAT)format);

    internal static RedImage? LoadFromDDSMemory(byte[] buffer, DXGI_FORMAT format)
    {
        try
        {
            var scratchImage = TexHelper.Instance.LoadFromDDSMemory(buffer, DDS_FLAGS.FORCE_DX10_EXT, out var metadata);

            if (TexHelper.Instance.IsCompressed(metadata.Format))
            {
                scratchImage = scratchImage.Decompress(format);
            }

            return new RedImage(scratchImage);
        }
        catch (Exception)
        {
            LoggerService?.Error($"[RedImage] Buffer contains invalid data!");
            return null;
        }
    }

    // load from files

    public static RedImage LoadFromDDSFile(string szFile, Common.DDS.DXGI_FORMAT format = Common.DDS.DXGI_FORMAT.DXGI_FORMAT_UNKNOWN)
    {
        var scratchImage = TexHelper.Instance.LoadFromDDSFile(szFile, DDS_FLAGS.FORCE_DX10_EXT, out var metadata);

        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            scratchImage = scratchImage.Decompress((DXGI_FORMAT)format);
        }

        return new RedImage(scratchImage);
    }

    public static RedImage LoadFromTGAFile(string szFile) => new(TexHelper.Instance.LoadFromTGAFile(szFile));

    public static RedImage LoadFromBMPFile(string szFile) => new(TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE));

    public static RedImage LoadFromJPGFile(string szFile) => new(TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE));

    public static RedImage LoadFromPNGFile(string szFile)
    {
        var result = new RedImage(TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE));

        if (result._metadata.Format == DXGI_FORMAT.B8G8R8A8_UNORM)
        {
            result.InternalScratchImage = result.InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
        }

        if (result._metadata.Format == DXGI_FORMAT.B8G8R8A8_UNORM_SRGB)
        {
            result.InternalScratchImage = result.InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM_SRGB, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
        }

        return result;
    }

    public static RedImage LoadFromTIFFFile(string szFile) =>
        new(TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE));

    #endregion

    #region SaveToFileFormat

    private byte[] SaveToMemory(UnmanagedMemoryStream ms)
    {
        var buffer = new byte[ms.Length];
        var readBytes = ms.Read(buffer, 0, buffer.Length);
        ms.Dispose();

        if (readBytes != buffer.Length)
        {
            throw new Exception();
        }

        return buffer;
    }

    public void SaveToDDS(string szFile) =>
        InternalScratchImage.SaveToDDSFile(DDS_FLAGS.FORCE_DX10_EXT, szFile);

    public byte[] SaveToDDSMemory() =>
        SaveToMemory(InternalScratchImage.SaveToDDSMemory(DDS_FLAGS.FORCE_DX10_EXT));

    public void SaveToTGA(string szFile)
    {
        ScratchImage? tmpImage = null;
        if (TexHelper.Instance.IsSRGB(_metadata.Format))
        {
            if (_metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM_SRGB)
            {
                tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM_SRGB, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }
        else
        {
            if (_metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM)
            {
                tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }

        if (tmpImage != null)
        {
            tmpImage.SaveToTGAFile(0, szFile);
            tmpImage.Dispose();
        }
        else
        {
            InternalScratchImage.SaveToTGAFile(0, szFile);
        }
    }

    public byte[] SaveToTGAMemory()
    {
        ScratchImage? tmpImage = null;
        if (TexHelper.Instance.IsSRGB(_metadata.Format))
        {
            if (_metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM_SRGB)
            {
                tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM_SRGB, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }
        else
        {
            if (_metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM)
            {
                tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }

        if (tmpImage != null)
        {
            var buffer = SaveToMemory(tmpImage.SaveToTGAMemory(0));
            tmpImage.Dispose();

            return buffer;
        }
        else
        {
            return SaveToMemory(InternalScratchImage.SaveToTGAMemory(0));
        }
    }

    public void SaveToBMP(string szFile) =>
        SaveToWIC(szFile, TexHelper.Instance.GetWICCodec(WICCodecs.BMP));

    public byte[] SaveToBMPMemory() =>
        SaveToWICMemory(TexHelper.Instance.GetWICCodec(WICCodecs.BMP));

    public void SaveToJPEG(string szFile) =>
        SaveToWIC(szFile, TexHelper.Instance.GetWICCodec(WICCodecs.JPEG));

    public byte[] SaveToJPEGMemory() =>
        SaveToWICMemory(TexHelper.Instance.GetWICCodec(WICCodecs.JPEG));

    public void SaveToPNG(string szFile) =>
        SaveToWIC(szFile, TexHelper.Instance.GetWICCodec(WICCodecs.PNG));

    public byte[] SaveToPNGMemory() =>
        SaveToWICMemory(TexHelper.Instance.GetWICCodec(WICCodecs.PNG));

    public void SaveToTIFF(string szFile) =>
        SaveToWIC(szFile, TexHelper.Instance.GetWICCodec(WICCodecs.TIFF));

    public byte[] SaveToTIFFMemory() =>
        SaveToWICMemory(TexHelper.Instance.GetWICCodec(WICCodecs.TIFF));

    private void SaveToWIC(string szFile, Guid wicCodec)
    {
        if (_metadata.Format == DXGI_FORMAT.R8G8_UNORM)
        {
            var img = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
            img.SaveToWICFile(0, WIC_FLAGS.NONE, wicCodec, szFile);
            img.Dispose();
        }
        else
        {
            InternalScratchImage.SaveToWICFile(0, WIC_FLAGS.NONE, wicCodec, szFile);
        }
    }

    private byte[] SaveToWICMemory(Guid wicCodec)
    {
        byte[] buffer;
        if (_metadata.Format == DXGI_FORMAT.R8G8_UNORM)
        {
            var img = InternalScratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
            buffer = SaveToMemory(img.SaveToWICMemory(0, WIC_FLAGS.NONE, wicCodec));
            img.Dispose();
        }
        else
        {
            buffer = SaveToMemory(InternalScratchImage.SaveToWICMemory(0, WIC_FLAGS.NONE, wicCodec));
        }

        return buffer;
    }

    public byte[] GetPreview(bool flip)
    {
        if (TexHelper.Instance.IsCompressed(_metadata.Format))
        {
            InternalScratchImage = InternalScratchImage.Decompress(DXGI_FORMAT.UNKNOWN);
            _metadata = InternalScratchImage.GetMetadata();
        }

        if (_metadata.IsCubemap())
        {
            var s_offsetx = new[] { 2, 0, 1, 1, 1, 3 };
            var s_offsety = new[] { 1, 1, 0, 2, 1, 1 };

            var result = TexHelper.Instance.Initialize2D(_metadata.Format, _metadata.Width * 4, _metadata.Height * 3, 1, 1, CP_FLAGS.NONE);
            var dest = result.GetImage(0, 0, 0);

            for (var i = 0; i < 6; i++)
            {
                var img = InternalScratchImage.GetImage(0, i, 0);

                var offsetx = s_offsetx[i] * _metadata.Width;
                var offsety = s_offsety[i] * _metadata.Height;

                TexHelper.Instance.CopyRectangle(img, 0, 0, _metadata.Width, _metadata.Height, dest, TEX_FILTER_FLAGS.DEFAULT, offsetx, offsety);
            }

            return SaveToMemory(result.SaveToWICMemory(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG)));
        }
        else
        {
            if (flip)
            {
                InternalScratchImage = InternalScratchImage.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);
            }

            return SaveToWICMemory(TexHelper.Instance.GetWICCodec(WICCodecs.PNG));
        }
    }

    #endregion SaveToFileFormat

    public RedImage Crop(int x, int y, int width, int height)
    {
        var croppedImage = TexHelper.Instance.Initialize2D(_metadata.Format, width, height, 1, 1, CP_FLAGS.NONE);

        TexHelper.Instance.CopyRectangle(InternalScratchImage.GetImage(0), x, y, width, height, croppedImage.GetImage(0), TEX_FILTER_FLAGS.DEFAULT, 0, 0);

        return new RedImage(croppedImage);
    }

    public void FlipV() => InternalScratchImage = InternalScratchImage.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);

    public void Convert(Common.DDS.DXGI_FORMAT format)
    {
        if (TexHelper.Instance.IsCompressed(_metadata.Format))
        {
            throw new Exception();
        }

        if (Metadata.Format == format)
        {
            return;
        }

        var internalFormat = (DXGI_FORMAT)(uint)format;

        if (TexHelper.Instance.IsCompressed(internalFormat))
        {
            Compress(internalFormat);
        }
        else
        {
            InternalScratchImage = InternalScratchImage.Convert(internalFormat, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
        }
    }

    private void Compress(DXGI_FORMAT format)
    {
        if (!TexHelper.Instance.IsCompressed(format))
        {
            throw new ArgumentOutOfRangeException(nameof(format));
        }

        if (TexHelper.Instance.IsSRGB(_metadata.Format) != TexHelper.Instance.IsSRGB(format))
        {
            throw new ArgumentOutOfRangeException(nameof(format));
        }

        if (format is DXGI_FORMAT.BC6H_UF16
                or DXGI_FORMAT.BC6H_SF16
                or DXGI_FORMAT.BC7_UNORM
                or DXGI_FORMAT.BC7_UNORM_SRGB &&
            s_device != null)
        {
            InternalScratchImage = InternalScratchImage.Compress(s_device.NativePointer, format, TEX_COMPRESS_FLAGS.DEFAULT, 1.0F);
        }
        else
        {
            InternalScratchImage = InternalScratchImage.Compress(format, TEX_COMPRESS_FLAGS.PARALLEL, 0.5F);
        }
    }

    public CBitmapTexture SaveToXBM(XbmImportArgs args)
    {
        if (args.Compression == ETextureCompression.TCM_DXTAlpha)
        {
            args.PremultiplyAlpha = true;
        }

        var settings = new RedImageTransformSettings(args.TextureGroup, args.IsGamma, args.VFlip, args.RawFormat, args.Compression, args.GenerateMipMaps, args.PremultiplyAlpha, args.IsStreamable);

        // get resource
        var (setup, blob) = GetSetupAndBlob(settings);

        return new CBitmapTexture
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            Width = (uint)blob.Header.SizeInfo.Width,
            Height = (uint)blob.Header.SizeInfo.Height,
            Depth = (uint)blob.Header.SizeInfo.Depth,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public CTextureArray SaveToTexArray()
    {
        var (setup, blob) = GetSetupAndBlob(new RedImageTransformSettings(default, default, default, default, default, false, default, default));

        return new CTextureArray
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public CCubeTexture SaveToCubeMap()
    {
        var (setup, blob) = GetSetupAndBlob(new RedImageTransformSettings(default, default, default, default, default, false, default, default));

        return new CCubeTexture()
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public record RedImageTransformSettings(GpuWrapApieTextureGroup TextureGroup, bool IsGamma, bool VFlip, ETextureRawFormat RawFormat, ETextureCompression Compression, bool GenerateMipMaps, bool PremultiplyAlpha, bool IsStreamable)
    {
        public bool AllowTextureDowngrade { get; } = false; // unused
        public byte AlphaToCoverageThreshold { get; } = 0; // unused
    }

    private static bool HasAlpha(DXGI_FORMAT format)
    {
#pragma warning disable IDE0010 // Add missing cases
        switch (format)
        {
            case DXGI_FORMAT.R32G32B32A32_TYPELESS:
            case DXGI_FORMAT.R32G32B32A32_FLOAT:
            case DXGI_FORMAT.R32G32B32A32_UINT:
            case DXGI_FORMAT.R32G32B32A32_SINT:
            case DXGI_FORMAT.R16G16B16A16_TYPELESS:
            case DXGI_FORMAT.R16G16B16A16_FLOAT:
            case DXGI_FORMAT.R16G16B16A16_UNORM:
            case DXGI_FORMAT.R16G16B16A16_UINT:
            case DXGI_FORMAT.R16G16B16A16_SNORM:
            case DXGI_FORMAT.R16G16B16A16_SINT:
            case DXGI_FORMAT.R10G10B10A2_TYPELESS:
            case DXGI_FORMAT.R10G10B10A2_UNORM:
            case DXGI_FORMAT.R10G10B10A2_UINT:
            case DXGI_FORMAT.R8G8B8A8_TYPELESS:
            case DXGI_FORMAT.R8G8B8A8_UNORM:
            case DXGI_FORMAT.R8G8B8A8_UNORM_SRGB:
            case DXGI_FORMAT.R8G8B8A8_UINT:
            case DXGI_FORMAT.R8G8B8A8_SNORM:
            case DXGI_FORMAT.R8G8B8A8_SINT:
            case DXGI_FORMAT.A8_UNORM:
            case DXGI_FORMAT.BC1_TYPELESS:
            case DXGI_FORMAT.BC1_UNORM:
            case DXGI_FORMAT.BC1_UNORM_SRGB:
            case DXGI_FORMAT.BC2_TYPELESS:
            case DXGI_FORMAT.BC2_UNORM:
            case DXGI_FORMAT.BC2_UNORM_SRGB:
            case DXGI_FORMAT.BC3_TYPELESS:
            case DXGI_FORMAT.BC3_UNORM:
            case DXGI_FORMAT.BC3_UNORM_SRGB:
            case DXGI_FORMAT.B5G5R5A1_UNORM:
            case DXGI_FORMAT.B8G8R8A8_UNORM:
            case DXGI_FORMAT.R10G10B10_XR_BIAS_A2_UNORM:
            case DXGI_FORMAT.B8G8R8A8_TYPELESS:
            case DXGI_FORMAT.B8G8R8A8_UNORM_SRGB:
            case DXGI_FORMAT.BC7_TYPELESS:
            case DXGI_FORMAT.BC7_UNORM:
            case DXGI_FORMAT.BC7_UNORM_SRGB:
            case DXGI_FORMAT.AYUV:
            case DXGI_FORMAT.Y410:
            case DXGI_FORMAT.Y416:
            case DXGI_FORMAT.AI44:
            case DXGI_FORMAT.IA44:
            case DXGI_FORMAT.A8P8:
            case DXGI_FORMAT.B4G4R4A4_UNORM:
            //case XBOX_DXGI_FORMAT_R10G10B10_7E3_A2_FLOAT:
            //case XBOX_DXGI_FORMAT_R10G10B10_6E4_A2_FLOAT:
            //case XBOX_DXGI_FORMAT_R10G10B10_SNORM_A2_UNORM:
                return true;
            
            default:
                return false;
        }
#pragma warning restore IDE0010 // Add missing cases
    }


    private (STextureGroupSetup, rendRenderTextureBlobPC) GetSetupAndBlob(RedImageTransformSettings settings)
    {
        var setup = new STextureGroupSetup();
        var blob = new rendRenderTextureBlobPC();

        var tmpImage = false;
        var img = InternalScratchImage;
        var metadata = _metadata;

        var outImageFormat = CommonFunctions.GetDXGIFormat(settings.Compression, settings.RawFormat, settings.IsGamma);
        //if (!TexHelper.Instance.IsCompressed(outImageFormat))
        //{
        //    throw new ArgumentOutOfRangeException(nameof(outImageFormat));
        //}
        //if (TexHelper.Instance.IsSRGB(metadata.Format) != TexHelper.Instance.IsSRGB((DXGI_FORMAT)outImageFormat))
        //{
        //    throw new ArgumentOutOfRangeException(nameof(outImageFormat));
        //}
        if (settings.Compression == ETextureCompression.TCM_None && metadata.Format != (DXGI_FORMAT)outImageFormat)
        {
            tmpImage = true;

            img = img.Convert((DXGI_FORMAT)outImageFormat, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
            metadata = img.GetMetadata();
        }

        // gamma adjustments
        if (settings.IsGamma && !TexHelper.Instance.IsSRGB(metadata.Format))
        {
            var srgbFormat = TexHelper.Instance.MakeSRGB(metadata.Format);
            if (metadata.Format != srgbFormat)
            {
                tmpImage = true;

                img = img.Convert(srgbFormat, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
                metadata = img.GetMetadata();
            }
        }
        else if (!settings.IsGamma && TexHelper.Instance.IsSRGB(metadata.Format))
        {
            var linearFormat = TexHelper.Instance.MakeLinear(metadata.Format);
            if (metadata.Format != linearFormat)
            {
                tmpImage = true;

                img = img.Convert(linearFormat, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
                metadata = img.GetMetadata();
            }
        }

        // flip
        if (settings.VFlip)
        {
            tmpImage = true;

            img = img.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);
            metadata = img.GetMetadata();
        }

        if (settings.PremultiplyAlpha && HasAlpha(metadata.Format))
        {
            tmpImage = true;

            img = img.PremultiplyAlpha(TEX_PMALPHA_FLAGS.DEFAULT);
            metadata = img.GetMetadata();
        }

        if (settings.GenerateMipMaps)
        {
            tmpImage = true;

            if (_metadata.Dimension == TEX_DIMENSION.TEXTURE3D)
            {
                img = img.GenerateMipMaps3D(TEX_FILTER_FLAGS.DEFAULT, 0);
            }
            else
            {
                img = img.GenerateMipMaps(TEX_FILTER_FLAGS.DEFAULT, 0);
            }

            metadata = img.GetMetadata();
        }

        // compress
        tmpImage = true;
        if (settings.Compression != ETextureCompression.TCM_None)
        {
            if ((DXGI_FORMAT)outImageFormat is DXGI_FORMAT.BC6H_UF16 or DXGI_FORMAT.BC6H_SF16 or DXGI_FORMAT.BC7_UNORM or DXGI_FORMAT.BC7_UNORM_SRGB && s_device != null)
            {
                img = img.Compress(s_device.NativePointer, (DXGI_FORMAT)outImageFormat, TEX_COMPRESS_FLAGS.DEFAULT, 1.0F);
            }
            else
            {
                img = img.Compress((DXGI_FORMAT)outImageFormat, TEX_COMPRESS_FLAGS.PARALLEL, 0.5F);
            }
        }

        metadata = img.GetMetadata();

        #region STextureGroupSetup

        setup.HasMipchain = metadata.MipLevels > 1;
        setup.Compression = settings.Compression;
        //if (TexHelper.Instance.IsCompressed(metadata.Format))
        //{
        //    setup.Compression = CommonFunctions.GetRedCompressionFromDXGI(metadata.Format, settings.PremultiplyAlpha);
        //}
        setup.RawFormat = settings.RawFormat;
        setup.IsGamma = TexHelper.Instance.IsSRGB(metadata.Format);

        var mipBiasMaxUnclamped = metadata.MipLevels - 3;
        var mipBiasMax = Math.Max(0, mipBiasMaxUnclamped);
        setup.PlatformMipBiasPC = Math.Clamp(setup.PlatformMipBiasPC, (byte)0, (byte)mipBiasMax);
        setup.PlatformMipBiasConsole = Math.Clamp(setup.PlatformMipBiasConsole, (byte)0, (byte)mipBiasMax);

        setup.AllowTextureDowngrade = settings.AllowTextureDowngrade;
        setup.AlphaToCoverageThreshold = settings.AlphaToCoverageThreshold;

        setup.Group = settings.TextureGroup;
        setup.IsStreamable = settings.IsStreamable;


        #endregion STextureGroupSetup

        #region rendRenderTextureBlobPC

        blob.Header.Flags = Flags; // always 1?
        blob.Header.Version = Version; // need to check, 1 or 2

        blob.Header.SizeInfo.Width = (CUInt16)metadata.Width;
        blob.Header.SizeInfo.Height = (CUInt16)metadata.Height;
        blob.Header.SizeInfo.Depth = (CUInt16)metadata.Depth;

        blob.Header.TextureInfo.DataAlignment = 8;
        blob.Header.TextureInfo.MipCount = (CUInt8)metadata.MipLevels;

        switch (metadata.Dimension)
        {
            case TEX_DIMENSION.TEXTURE2D:
                blob.Header.TextureInfo.Type = Enums.GpuWrapApieTextureType.TEXTYPE_2D;
                if (metadata.IsCubemap())
                {
                    blob.Header.TextureInfo.Type = Enums.GpuWrapApieTextureType.TEXTYPE_CUBE;
                }
                break;
            case TEX_DIMENSION.TEXTURE3D:
                blob.Header.TextureInfo.Type = Enums.GpuWrapApieTextureType.TEXTYPE_2D;
                break;
            case TEX_DIMENSION.TEXTURE1D:
            default:
                throw new ArgumentOutOfRangeException();
        }

        blob.Header.TextureInfo.TextureDataSize = (CUInt32)img.GetPixelsSize();
        blob.Header.TextureInfo.SliceCount = (CUInt16)metadata.ArraySize;

        uint mipMapOffset = 0;
        for (var i = 0; i < metadata.ArraySize; i++)
        {
            for (var j = 0; j < metadata.MipLevels; j++)
            {
                var tmpImg = img.GetImage(j, i, 0);

                if (i == 0)
                {
                    // TODO: Some mipMaps have a different SlicePitch in the original xbm
                    var mipMapInfo = new rendRenderTextureBlobMipMapInfo
                    {
                        Layout =
                        {
                            RowPitch = (CUInt32)tmpImg.RowPitch,
                            SlicePitch = (CUInt32)tmpImg.SlicePitch
                        },
                        Placement = {
                            Offset = mipMapOffset,
                            Size = (CUInt32)(tmpImg.SlicePitch * metadata.Depth)
                        }
                    };

                    blob.Header.MipMapInfo.Add(mipMapInfo);

                    mipMapOffset += mipMapInfo.Placement.Size;
                }
            }
        }

        if (blob.Header.MipMapInfo == null || blob.Header.MipMapInfo.Count == 0)
        {
            throw new ArgumentNullException();
        }

        blob.Header.TextureInfo.SliceSize = blob.Header.MipMapInfo[^1]!.Placement.Offset + blob.Header.MipMapInfo[^1]!.Placement.Size;

        #endregion rendRenderTextureBlobPC

        // save
        using var ms = img.SaveToDDSMemory(DDS_FLAGS.FORCE_DX10_EXT);

        var buffer = new byte[ms.Length];
        var readBytes = ms.Read(buffer, 0, buffer.Length);
        ms.Dispose();

        if (readBytes != buffer.Length)
        {
            throw new Exception();
        }

        blob.TextureData = new SerializationDeferredDataBuffer(buffer[148..])
        {
            Buffer =
            {
                Flags = 131072
            }
        };

        if (tmpImage)
        {
            img.Dispose();
        }
        return (setup, blob);
    }

    public static RedImage FromRedFile(CR2WFile cr2wFile)
    {
        if (cr2wFile == null)
        {
            throw new ArgumentNullException(nameof(cr2wFile));
        }

        return FromRedClass(cr2wFile.RootChunk);
    }

    public static RedImage FromRedClass(RedBaseClass cls)
    {
        if (cls == null)
        {
            throw new ArgumentNullException(nameof(cls));
        }

        if (cls is CBitmapTexture cBitmap)
        {
            return FromXBM(cBitmap);
        }

        if (cls is CTextureArray cTextureArray)
        {
            return FromTexArray(cTextureArray);
        }

        if (cls is CCubeTexture cCubeTexture)
        {
            return FromCubeMap(cCubeTexture);
        }

        if (cls is CReflectionProbeDataResource cReflectionProbeDataResource)
        {
            return FromEnvProbe(cReflectionProbeDataResource);
        }

        throw new NotSupportedException();
    }

    public static RedImage FromXBM(CBitmapTexture bitmapTexture)
    {
        if (bitmapTexture.Setup is not { } setup ||
            bitmapTexture.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
        {
            throw new ArgumentException(nameof(bitmapTexture));
        }

        return Create(setup, blob);
    }

    public static RedImage FromTexArray(CTextureArray textureArray)
    {
        if (textureArray.Setup is not { } setup ||
            textureArray.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
        {
            throw new ArgumentException(nameof(textureArray));
        }

        return Create(setup, blob);
    }

    public static RedImage FromCubeMap(CCubeTexture cubeTexture)
    {
        if (cubeTexture.Setup is not { } setup ||
            cubeTexture.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
        {
            throw new ArgumentException(nameof(cubeTexture));
        }

        return Create(setup, blob);
    }

    public static RedImage FromEnvProbe(CReflectionProbeDataResource reflectionProbeDataResource)
    {
        if (reflectionProbeDataResource.TextureData.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
        {
            throw new ArgumentException(nameof(reflectionProbeDataResource));
        }

        return Create(new STextureGroupSetup(), blob);
    }



    public static RedImage FromWICBuffer(byte[] buffer)
    {
        var scratchImage = TexHelper.Instance.LoadFromWICMemory(buffer, WIC_FLAGS.NONE);

        return new RedImage(scratchImage);
    }

    public static RedImage FromTGABuffer(byte[] buffer)
    {
        var scratchImage = TexHelper.Instance.LoadFromTGAMemory(buffer);

        return new RedImage(scratchImage);
    }

    private static unsafe RedImage Create(STextureGroupSetup setup, rendRenderTextureBlobPC blob)
    {
        var info = new DDSUtils.DDSInfo()
        {
            Compression = setup.Compression,
            RawFormat = setup.RawFormat,
            IsGamma = setup.IsGamma,
            Width = blob.Header.SizeInfo.Width,
            Height = blob.Header.SizeInfo.Height,
            Depth = blob.Header.SizeInfo.Depth,
            MipCount = blob.Header.TextureInfo.MipCount,
            SliceCount = blob.Header.TextureInfo.SliceCount,
            TextureType = blob.Header.TextureInfo.Type,
            FlipV = true
        };
        var imgData = blob.TextureData.Buffer.GetBytes();

        var result = Create(info, imgData);

        result.Group = setup.Group;
        result.IsStreamable = setup.IsStreamable;
        result.PlatformMipBiasPC = setup.PlatformMipBiasPC;
        result.AllowTextureDowngrade = setup.AllowTextureDowngrade;

        result.Flags = blob.Header.Flags;
        result.Version = blob.Header.Version;

        return result;
    }

    public static unsafe RedImage Create(DDSUtils.DDSInfo info, byte[] imgData)
    {
        var ddsLength = 148 + imgData.Length;
        var memIntPtr = Marshal.AllocHGlobal(ddsLength);

        var memBytePtr = (byte*)memIntPtr.ToPointer();
        using (var ms = new UnmanagedMemoryStream(memBytePtr, ddsLength, ddsLength, FileAccess.Write))
        {
            DDSUtils.GenerateAndWriteHeader(ms, info);
            ms.Write(imgData);
        }

        var result = new RedImage(TexHelper.Instance.LoadFromDDSMemory(memIntPtr, ddsLength, DDS_FLAGS.NONE, out var metadata));

        // This fails on compressed files 
        if (!TexHelper.Instance.IsCompressed(metadata.Format) && result.Metadata.MipLevels > 1)
        {
            result.InternalScratchImage = result.InternalScratchImage.CreateCopyWithEmptyMipMaps(1, result._metadata.Format, CP_FLAGS.NONE, false);
        }
        
        return result;
    }

    #region IDisposable

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources.
            }

            if (InternalScratchImage is { IsDisposed: false })
            {
                InternalScratchImage.Dispose();
            }

            _disposed = true;
        }
    }

    ~RedImage()
    {
        Dispose(disposing: false);
    }

    #endregion IDisposable
}
