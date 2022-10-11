using System;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
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
    private static readonly SharpDX.Direct3D11.Device s_device;

    private ScratchImage _scratchImage;
    private TexMetadata _metadata;

    private DXGI_FORMAT? _compressionFormat;

    private bool _disposed = false;

    private RedImage(){}

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

    public static RedImage LoadFromDDSFile(string szFile, Common.DDS.DXGI_FORMAT format = Common.DDS.DXGI_FORMAT.DXGI_FORMAT_UNKNOWN)
    {
        var scratchImage = TexHelper.Instance.LoadFromDDSFile(szFile, DDS_FLAGS.FORCE_DX10_EXT, out var metadata);

        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            scratchImage = scratchImage.Decompress(format.ToDirectXTexFormat());
        }

        return new()
        {
            InternalScratchImage = scratchImage
        };
    }

    public static RedImage LoadFromDDSMemory(byte[] buffer) => LoadFromDDSMemory(buffer, DXGI_FORMAT.UNKNOWN);

    public static RedImage LoadFromDDSMemory(byte[] buffer, Enums.ETextureRawFormat format) => LoadFromDDSMemory(buffer, format.ToDirectXTexFormat());

    public static RedImage LoadFromDDSMemory(byte[] buffer, Common.DDS.DXGI_FORMAT format) => LoadFromDDSMemory(buffer, format.ToDirectXTexFormat());

    internal static RedImage LoadFromDDSMemory(byte[] buffer, DXGI_FORMAT format)
    {
        var scratchImage = TexHelper.Instance.LoadFromDDSMemory(buffer, DDS_FLAGS.FORCE_DX10_EXT, out var metadata);

        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            scratchImage = scratchImage.Decompress(format);
        }

        return new RedImage
        {
            InternalScratchImage = scratchImage
        };
    }

    public static RedImage LoadFromTGAFile(string szFile) =>
        new() { InternalScratchImage = TexHelper.Instance.LoadFromTGAFile(szFile) };

    public static RedImage LoadFromBMPFile(string szFile) =>
        new() { InternalScratchImage = TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE) };

    public static RedImage LoadFromJPGFile(string szFile) =>
        new() { InternalScratchImage = TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE) };

    public static RedImage LoadFromPNGFile(string szFile)
    {
        var result = new RedImage { InternalScratchImage = TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE) };

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
        new() { InternalScratchImage = TexHelper.Instance.LoadFromWICFile(szFile, WIC_FLAGS.NONE) };

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
        ScratchImage tmpImage = null;
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
        ScratchImage tmpImage = null;
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

    public byte[] GetPreview()
    {
        if (_metadata.IsCubemap())
        {
            var s_offsetx = new[] { 2, 0, 1, 1, 1, 3 };
            var s_offsety = new[] { 1, 1, 0, 2, 1, 1 };

            var result = TexHelper.Instance.Initialize2D(_metadata.Format, _metadata.Width * 4, _metadata.Height * 3, 1, 1, CP_FLAGS.NONE);
            var dest = result.GetImage(0, 0, 0);

            for (int i = 0; i < 6; i++)
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
            return SaveToMemory(InternalScratchImage.SaveToWICMemory(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG)));
        }
    }

    #endregion SaveToFileFormat

    public RedImage Crop(int x, int y, int width, int height)
    {
        var croppedImage = TexHelper.Instance.Initialize2D(_metadata.Format, width, height, 1, 1, CP_FLAGS.NONE);

        TexHelper.Instance.CopyRectangle(InternalScratchImage.GetImage(0), x, y, width, height, croppedImage.GetImage(0), TEX_FILTER_FLAGS.DEFAULT, 0, 0);

        return new RedImage {InternalScratchImage = croppedImage};
    }

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
        var settings = new RedImageTransformSettings();
        settings.RawFormat = CommonFunctions.GetDXGIFormat3(SupportedCompressionFormats.TCM_None, args.RawFormat, args.IsGamma, null);

        if (args.Compression != SupportedCompressionFormats.TCM_None)
        {
            settings.CompressionFormat = CommonFunctions.GetDXGIFormat3(args.Compression, SupportedRawFormats.TRF_Invalid, args.IsGamma, null);
        }
        
        settings.IsGamma = args.IsGamma;
        settings.GenerateMipMaps = args.HasMipchain;

        if (args.Compression == SupportedCompressionFormats.TCM_DXTAlpha)
        {
            settings.PremultiplyAlpha = true;
        }

        var (setup, blob) = GetSetupAndBlob(settings);

        setup.Group = args.TextureGroup;
        setup.RawFormat = Enum.Parse<Enums.ETextureRawFormat>(args.RawFormat.ToString());
        setup.Compression = Enum.Parse<Enums.ETextureCompression>(args.Compression.ToString());
        setup.IsStreamable = args.IsStreamable;
        setup.HasMipchain = args.HasMipchain;
        setup.IsGamma = args.IsGamma;
        setup.PlatformMipBiasPC = args.PlatformMipBiasPC;
        setup.PlatformMipBiasConsole = args.PlatformMipBiasConsole;
        setup.AllowTextureDowngrade = args.AllowTextureDowngrade;
        setup.AlphaToCoverageThreshold = args.AlphaToCoverageThreshold;

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
        var (setup, blob) = GetSetupAndBlob(new RedImageTransformSettings {GenerateMipMaps = false});

        return new CTextureArray
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public CCubeTexture SaveToCubeMap()
    {
        var (setup, blob) = GetSetupAndBlob(new RedImageTransformSettings { GenerateMipMaps = false });

        return new CCubeTexture()
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public class RedImageTransformSettings
    {
        public DXGI_FORMAT RawFormat = DXGI_FORMAT.UNKNOWN;
        public DXGI_FORMAT CompressionFormat = DXGI_FORMAT.UNKNOWN;
        public bool IsGamma = false;
        public bool GenerateMipMaps = false;
        public bool PremultiplyAlpha = false;
        public bool VFlip = true;
    }

    private (STextureGroupSetup, rendRenderTextureBlobPC) GetSetupAndBlob(RedImageTransformSettings settings)
    {
        var setup = new STextureGroupSetup();
        var blob = new rendRenderTextureBlobPC();

        var tmpImage = false;
        var img = InternalScratchImage;
        var metadata = _metadata;

        if (settings.RawFormat != DXGI_FORMAT.UNKNOWN && settings.RawFormat != metadata.Format)
        {
            if (TexHelper.Instance.IsCompressed(settings.RawFormat))
            {
                throw new ArgumentOutOfRangeException(nameof(settings.RawFormat));
            }

            tmpImage = true;

            img = img.Convert(settings.RawFormat, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
            metadata = img.GetMetadata();
        }
        else
        {
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

            if (!settings.IsGamma && TexHelper.Instance.IsSRGB(metadata.Format))
            {
                var linearFormat = TexHelper.Instance.MakeLinear(metadata.Format);
                if (metadata.Format != linearFormat)
                {
                    tmpImage = true;

                    img = img.Convert(linearFormat, TEX_FILTER_FLAGS.FORCE_WIC, 0.5F);
                    metadata = img.GetMetadata();
                }
            }
        }

        if (settings.VFlip)
        {
            tmpImage = true;

            img = img.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);
            metadata = img.GetMetadata();
        }

        if (settings.PremultiplyAlpha)
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

        var uncompressedFormat = metadata.Format;
        if (settings.CompressionFormat != DXGI_FORMAT.UNKNOWN)
        {
            if (!TexHelper.Instance.IsCompressed(settings.CompressionFormat))
            {
                throw new ArgumentOutOfRangeException(nameof(settings.CompressionFormat));
            }

            if (TexHelper.Instance.IsSRGB(metadata.Format) != TexHelper.Instance.IsSRGB(settings.CompressionFormat))
            {
                throw new ArgumentOutOfRangeException(nameof(settings.CompressionFormat));
            }

            tmpImage = true;

            if (settings.CompressionFormat is DXGI_FORMAT.BC6H_UF16
                    or DXGI_FORMAT.BC6H_SF16
                    or DXGI_FORMAT.BC7_UNORM
                    or DXGI_FORMAT.BC7_UNORM_SRGB &&
                s_device != null)
            {
                img = img.Compress(s_device.NativePointer, settings.CompressionFormat, TEX_COMPRESS_FLAGS.DEFAULT, 1.0F);
            }
            else
            {
                img = img.Compress(settings.CompressionFormat, TEX_COMPRESS_FLAGS.PARALLEL, 0.5F);
            }

            metadata = img.GetMetadata();
        }

        #region STextureGroupSetup

        setup.HasMipchain = metadata.MipLevels > 1;

        var rawFormat = CommonFunctions.GetRedTextureFromDXGI(uncompressedFormat);
        setup.RawFormat = rawFormat;
        setup.IsGamma = TexHelper.Instance.IsSRGB(metadata.Format);

        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            setup.Compression = CommonFunctions.GetRedCompressionFromDXGI(metadata.Format, settings.PremultiplyAlpha);
        }

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

        blob.Header.TextureInfo.SliceSize = blob.Header.MipMapInfo[^1].Placement.Offset + blob.Header.MipMapInfo[^1].Placement.Size;

        #endregion rendRenderTextureBlobPC

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

        return new RedImage
        {
            InternalScratchImage = scratchImage
        };
    }

    public static RedImage FromTGABuffer(byte[] buffer)
    {
        var scratchImage = TexHelper.Instance.LoadFromTGAMemory(buffer);

        return new RedImage
        {
            InternalScratchImage = scratchImage
        };
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
        var result = new RedImage();

        var ddsLength = 148 + imgData.Length;
        var memIntPtr = Marshal.AllocHGlobal(ddsLength);

        var memBytePtr = (byte*)memIntPtr.ToPointer();
        using (var ms = new UnmanagedMemoryStream(memBytePtr, ddsLength, ddsLength, FileAccess.Write))
        {
            DDSUtils.GenerateAndWriteHeader(ms, info);
            ms.Write(imgData);
        }

        result.InternalScratchImage = TexHelper.Instance.LoadFromDDSMemory(memIntPtr, ddsLength, DDS_FLAGS.NONE, out var metadata);
        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            result._compressionFormat = metadata.Format;

            var textureFormat = CommonFunctions.GetDXGIFormat2(Enums.ETextureCompression.TCM_None, info.RawFormat, info.IsGamma, null);
            result.InternalScratchImage = result.InternalScratchImage.Decompress(textureFormat);
        }

        if (result.Metadata.MipLevels > 1)
        {
            result.InternalScratchImage = result.InternalScratchImage.CreateCopyWithEmptyMipMaps(1, result._metadata.Format, CP_FLAGS.NONE, false);
        }


        if (!result._metadata.IsCubemap() && info.FlipV)
        {
            result.InternalScratchImage = result.InternalScratchImage.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);
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
