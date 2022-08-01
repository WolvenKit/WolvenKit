using System;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using SharpDX.Direct3D;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using DXGI_FORMAT = DirectXTexNet.DXGI_FORMAT;
using TEX_DIMENSION = DirectXTexNet.TEX_DIMENSION;

#pragma warning disable CS0414

namespace WolvenKit.RED4.CR2W;

public class RedImage : IDisposable
{
    private static SharpDX.Direct3D11.Device s_device = null;

    private ScratchImage _scratchImage;

    private DXGI_FORMAT? _compressionFormat;

    private bool _disposed = false;

    private RedImage(){}

    public TexMetadata Metadata => _scratchImage.GetMetadata();

    static RedImage()
    {
        s_device = new SharpDX.Direct3D11.Device(DriverType.Hardware);
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
        _scratchImage.SaveToDDSFile(DDS_FLAGS.FORCE_DX10_EXT, szFile);

    public byte[] SaveToDDSMemory() =>
        SaveToMemory(_scratchImage.SaveToDDSMemory(DDS_FLAGS.FORCE_DX10_EXT));

    public void SaveToTGA(string szFile)
    {
        ScratchImage tmpImage = null;
        if (TexHelper.Instance.IsSRGB(Metadata.Format))
        {
            if (Metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM_SRGB)
            {
                tmpImage = _scratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM_SRGB, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }
        else
        {
            if (Metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM)
            {
                tmpImage = _scratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }

        if (tmpImage != null)
        {
            tmpImage.SaveToTGAFile(0, szFile);
            tmpImage.Dispose();
        }
        else
        {
            _scratchImage.SaveToTGAFile(0, szFile);
        }
    }

    public byte[] SaveToTGAMemory()
    {
        ScratchImage tmpImage = null;
        if (TexHelper.Instance.IsSRGB(Metadata.Format))
        {
            if (Metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM_SRGB)
            {
                tmpImage = _scratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM_SRGB, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            }
        }
        else
        {
            if (Metadata.Format != DXGI_FORMAT.R8G8B8A8_UNORM)
            {
                tmpImage = _scratchImage.Convert(DXGI_FORMAT.R8G8B8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
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
            return SaveToMemory(_scratchImage.SaveToTGAMemory(0));
        }
    }

    public void SaveToBMP(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.BMP), szFile);

    public byte[] SaveToBMPMemory() =>
        SaveToMemory(_scratchImage.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.BMP)));

    public void SaveToJPEG(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.JPEG), szFile);

    public byte[] SaveToJPEGMemory() =>
        SaveToMemory(_scratchImage.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.JPEG)));

    public void SaveToPNG(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG), szFile);

    public byte[] SaveToPNGMemory() =>
        SaveToMemory(_scratchImage.SaveToWICMemory(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG)));

    public void SaveToTIFF(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.TIFF), szFile);

    public byte[] SaveToTIFFMemory() =>
        SaveToMemory(_scratchImage.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.TIFF)));

    #endregion SaveToFileFormat

    public bool IsConvertible()
    {
        return Metadata.Format != DXGI_FORMAT.R8G8_UNORM;
    }

    public CBitmapTexture SaveToXBM()
    {
        var (setup, blob) = GetSetupAndBlob();

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
        var (setup, blob) = GetSetupAndBlob();

        return new CTextureArray
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    public CCubeTexture SaveToCubeMap()
    {
        var (setup, blob) = GetSetupAndBlob();

        return new CCubeTexture()
        {
            CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
            RenderTextureResource = { RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(blob) },
            Setup = setup
        };
    }

    private (STextureGroupSetup, rendRenderTextureBlobPC) GetSetupAndBlob()
    {
        var setup = new STextureGroupSetup();
        var blob = new rendRenderTextureBlobPC();

        var tmpImage = false;
        var img = _scratchImage;
        var metadata = img.GetMetadata();

        if (GenerateMipMaps)
        {
            tmpImage = true;

            if (Metadata.Dimension == TEX_DIMENSION.TEXTURE3D)
            {
                img = img.GenerateMipMaps3D(TEX_FILTER_FLAGS.DEFAULT, 0);
            }
            else
            {
                img = img.GenerateMipMaps(TEX_FILTER_FLAGS.DEFAULT, 0);
            }

            metadata = img.GetMetadata();
        }

        if (_compressionFormat is { } compFmt && !TexHelper.Instance.IsCompressed(metadata.Format))
        {
            tmpImage = true;

            if (compFmt is DXGI_FORMAT.BC6H_UF16 or DXGI_FORMAT.BC6H_SF16 or DXGI_FORMAT.BC7_UNORM or DXGI_FORMAT.BC7_UNORM_SRGB)
            {
                if (s_device != null)
                {
                    img = img.Compress(s_device.NativePointer, compFmt, TEX_COMPRESS_FLAGS.DEFAULT, 1.0F);
                }
                else
                {
                    img = img.Compress(compFmt, TEX_COMPRESS_FLAGS.PARALLEL, 0.5F);
                }
            }
            else
            {
                img = img.Compress(compFmt, TEX_COMPRESS_FLAGS.PARALLEL, 0.5F);
            }

            metadata = img.GetMetadata();
        }



        #region STextureGroupSetup

        setup.HasMipchain = metadata.MipLevels > 1;

        var (rawFormat, isGamma1) = CommonFunctions.GetRedTextureFromDXGI(Metadata.Format);
        setup.RawFormat = rawFormat;
        setup.IsGamma = isGamma1;

        if (_compressionFormat != null)
        {
            var (compression, isGamma2) = CommonFunctions.GetRedCompressionFromDXGI((DXGI_FORMAT)_compressionFormat);
            setup.Compression = compression;
            setup.IsGamma = isGamma2;
        }

        setup.Group = Group;
        setup.IsStreamable = IsStreamable;
        setup.PlatformMipBiasPC = PlatformMipBiasPC;
        setup.AllowTextureDowngrade = AllowTextureDowngrade;

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

        blob.TextureData = new SerializationDeferredDataBuffer(buffer[148..]);

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

    public static RedImage FromDDSBuffer(byte[] buffer, Enums.ETextureRawFormat format = Enums.ETextureRawFormat.TRF_Invalid)
    {
        var scratchImage = TexHelper.Instance.LoadFromDDSMemory(buffer, DDS_FLAGS.FORCE_DX10_EXT, out var metadata);

        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            var targetFormat = CommonFunctions.GetDXGIFormat2(Enums.ETextureCompression.TCM_None, format, false, null);

            scratchImage = scratchImage.Decompress(targetFormat);
        }

        return new RedImage
        {
            _scratchImage = scratchImage
        };
    }

    public static RedImage FromWICBuffer(byte[] buffer)
    {
        var scratchImage = TexHelper.Instance.LoadFromWICMemory(buffer, WIC_FLAGS.NONE);

        return new RedImage
        {
            _scratchImage = scratchImage
        };
    }

    public static RedImage FromTGABuffer(byte[] buffer)
    {
        var scratchImage = TexHelper.Instance.LoadFromTGAMemory(buffer);

        return new RedImage
        {
            _scratchImage = scratchImage
        };
    }

    private static unsafe RedImage Create(STextureGroupSetup setup, rendRenderTextureBlobPC blob)
    {
        var result = new RedImage();

        var imgData = blob.TextureData.Buffer.GetBytes();
        var ddsLength = 148 + imgData.Length;
        var memIntPtr = Marshal.AllocHGlobal(ddsLength);

        var memBytePtr = (byte*)memIntPtr.ToPointer();
        using (var ms = new UnmanagedMemoryStream(memBytePtr, ddsLength, ddsLength, FileAccess.Write))
        {
            DDSUtils.GenerateAndWriteHeader(ms, setup, blob.Header);
            ms.Write(blob.TextureData.Buffer.GetBytes());
        }

        result._scratchImage = TexHelper.Instance.LoadFromDDSMemory(memIntPtr, ddsLength, DDS_FLAGS.NONE, out var metadata);
        if (TexHelper.Instance.IsCompressed(metadata.Format))
        {
            result._compressionFormat = metadata.Format;

            var textureFormat = CommonFunctions.GetDXGIFormat2(Enums.ETextureCompression.TCM_None, setup.RawFormat, setup.IsGamma, null);
            result._scratchImage = result._scratchImage.Decompress(textureFormat);
        }

        if (result.Metadata.MipLevels > 1)
        {
            result.GenerateMipMaps = true;

            result._scratchImage = result._scratchImage.CreateCopyWithEmptyMipMaps(1, result.Metadata.Format, CP_FLAGS.NONE, false);
        }

        
        result._scratchImage = result._scratchImage.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);

        result.Group = setup.Group;
        result.IsStreamable = setup.IsStreamable;
        result.PlatformMipBiasPC = setup.PlatformMipBiasPC;
        result.AllowTextureDowngrade = setup.AllowTextureDowngrade;

        result.Flags = blob.Header.Flags;
        result.Version = blob.Header.Version;

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

            if (_scratchImage is { IsDisposed: false })
            {
                _scratchImage.Dispose();
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
