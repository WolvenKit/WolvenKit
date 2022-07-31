using System;
using System.IO;
using System.Runtime.InteropServices;
using DirectXTexNet;
using SharpDX.Direct3D;
using WolvenKit.Common.DDS;
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

    private STextureGroupSetup _debugSetup;
    private rendRenderTextureBlobPC _debugBlob;

    private RedImage(){}

    public TexMetadata Metadata => _scratchImage.GetMetadata();

    private static IntPtr GetDevicePtr()
    {
        if (s_device == null)
        {
            s_device = new SharpDX.Direct3D11.Device(DriverType.Hardware);
        }

        return s_device.NativePointer;
    }

    public void SaveToDDS(string szFile) =>
        _scratchImage.SaveToDDSFile(DDS_FLAGS.NONE, szFile);

    public void SaveToJPEG(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.JPEG), szFile);

    public void SaveToPNG(string szFile) =>
        _scratchImage.SaveToWICFile(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG), szFile);

    public byte[] SaveToPNG()
    {
        using var ms = _scratchImage.SaveToWICMemory(0, WIC_FLAGS.FORCE_RGB, TexHelper.Instance.GetWICCodec(WICCodecs.PNG));

        var buffer = new byte[ms.Length];
        var readBytes = ms.Read(buffer, 0, buffer.Length);
        ms.Dispose();

        if (readBytes != buffer.Length)
        {
            throw new Exception();
        }

        return buffer;
    }

    public void SaveToXBM()
    {
        var root = new CBitmapTexture();
        var blob = new rendRenderTextureBlobPC();

        var tmpImage = false;
        ScratchImage img;
        if (_compressionFormat != null && !TexHelper.Instance.IsCompressed(Metadata.Format))
        {
            tmpImage = true;
            img = _scratchImage.Compress(GetDevicePtr(), (DXGI_FORMAT)_compressionFormat, TEX_COMPRESS_FLAGS.DEFAULT, 1.0F);
        }
        else
        {
            img = _scratchImage;
        }

        var metadata = img.GetMetadata();

        #region STextureGroupSetup

        root.Setup.HasMipchain = metadata.MipLevels > 1;

        var (rawFormat, isGamma1) = CommonFunctions.GetRedTextureFromDXGI(Metadata.Format);
        root.Setup.RawFormat = rawFormat;
        root.Setup.IsGamma = isGamma1;

        if (_compressionFormat != null)
        {
            var (compression, isGamma2) = CommonFunctions.GetRedCompressionFromDXGI((DXGI_FORMAT)_compressionFormat);
            root.Setup.Compression = compression;
            root.Setup.IsGamma = isGamma2;
        }

        #endregion STextureGroupSetup

        #region rendRenderTextureBlobPC

        blob.Header.Flags = 1; // always 1?
        blob.Header.Version = 2; // need to check, 1 or 2

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

        blob.Header.TextureInfo.SliceCount = (CUInt16)metadata.ArraySize;

        if (blob.Header.TextureInfo.SliceCount > 1 && blob.Header.TextureInfo.MipCount > 1)
        {

        }

        uint mipMapOffset = 0;
        uint sliceSize = 0;
        for (var i = 0; i < metadata.ArraySize; i++)
        {
            for (var j = 0; j < metadata.MipLevels; j++)
            {
                var tmpImg = img.GetImage(j, i, 0);
                
                if (i == 0)
                {
                    var mipMapInfo = new rendRenderTextureBlobMipMapInfo
                    {
                        Layout =
                        {
                            RowPitch = (CUInt32)tmpImg.RowPitch,
                            SlicePitch = (CUInt32)tmpImg.SlicePitch
                        },
                        Placement = {
                            Offset = mipMapOffset,
                            Size = (uint)(tmpImg.Width * tmpImg.Height) // need to check
                        }
                    };

                    blob.Header.MipMapInfo.Add(mipMapInfo);

                    mipMapOffset += mipMapInfo.Placement.Size;
                }

                sliceSize += (uint)(tmpImg.Width * tmpImg.Height);
            }
        }

        blob.Header.TextureInfo.SliceSize = blob.Header.MipMapInfo[^1].Placement.Offset + blob.Header.MipMapInfo[^1].Placement.Size;
        blob.Header.TextureInfo.TextureDataSize = sliceSize;

        if (blob.Header.TextureInfo.MipCount > 1)
        {
            blob.Header.TextureInfo.SliceSize += 27;
        }

        if (blob.Header.TextureInfo.SliceCount > 1)
        {
            blob.Header.TextureInfo.TextureDataSize += 162;
        }

        var m1 = _debugBlob.Header.TextureInfo.SliceSize == blob.Header.TextureInfo.SliceSize;
        var m2 = _debugBlob.Header.TextureInfo.TextureDataSize == blob.Header.TextureInfo.TextureDataSize;

        if (!m1 || !m2)
        {

        }
        else
        {
            
        }

        

        #endregion rendRenderTextureBlobPC

        if (tmpImage)
        {
            img.Dispose();
        }
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

        throw new NotImplementedException();
        // return Create(setup, blob);
    }

    public static RedImage FromMesh(CMesh cMesh)
    {
        if (cMesh.RenderResourceBlob.Chunk is not rendRenderTextureBlobPC blob)
        {
            throw new ArgumentException(nameof(cMesh));
        }

        throw new NotImplementedException();
        // return Create(setup, blob);
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

        result._scratchImage = result._scratchImage.FlipRotate(TEX_FR_FLAGS.FLIP_VERTICAL);

        result._debugSetup = setup;
        result._debugBlob = blob;

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
