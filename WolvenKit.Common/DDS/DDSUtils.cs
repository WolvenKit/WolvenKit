using System;
using System.IO;
using DirectXTexNet;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.DDS
{
    public static class DDSUtils
    {
        #region Fields

        private const uint DDS_MAGIC = 0x20534444;

        #endregion Fields

        #region DDS_HEADER

        // dwCaps2
        public const uint DDSCAPS2_CUBEMAP = 0x00000200;

        public const uint DDSCAPS2_CUBEMAP_ALL_FACES = DDS_CUBEMAP_POSITIVEX | DDS_CUBEMAP_NEGATIVEX |
                                                        DDS_CUBEMAP_POSITIVEY | DDS_CUBEMAP_NEGATIVEY |
                                                        DDS_CUBEMAP_POSITIVEZ | DDS_CUBEMAP_NEGATIVEZ;

        private const uint DDS_CUBEMAP_NEGATIVEX = 0x00000a00;

        private const uint DDS_CUBEMAP_NEGATIVEY = 0x00002200;

        private const uint DDS_CUBEMAP_NEGATIVEZ = 0x00008200;

        private const uint DDS_CUBEMAP_POSITIVEX = 0x00000600;

        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEX
        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEX
        private const uint DDS_CUBEMAP_POSITIVEY = 0x00001200;

        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEY
        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEY
        private const uint DDS_CUBEMAP_POSITIVEZ = 0x00004200;

        private const uint DDS_HEADER_FLAGS_TEXTURE = 0x00001007;

        // dwCaps
        private const uint DDSCAPS_COMPLEX = 0x00000008;

        // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT
        private const uint DDSCAPS_MIPMAP = 0x00400000;

        private const uint DDSCAPS_TEXTURE = 0x00001000;

        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEZ
        // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEZ
        private const uint DDSCAPS2_VOLUME = 0x00200000;

        // dwflags
        private const uint DDSD_CAPS = 0x00000001;

        private const uint DDSD_DEPTH = 0x00800000;

        //required
        private const uint DDSD_HEIGHT = 0x00000002;

        private const uint DDSD_LINEARSIZE = 0x00080000;

        private const uint DDSD_MIPMAPCOUNT = 0x00020000;

        private const uint DDSD_PITCH = 0x00000008;

        private const uint DDSD_PIXELFORMAT = 0x00001000;

        //required
        private const uint DDSD_WIDTH = 0x00000004;

        // dwsize
        private const uint HEADER_SIZE = 124;

        //required
        //required

        #endregion DDS_HEADER

        #region DDS_HEADER_DXT10

        private const uint D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x00000001;
        private const uint DDS_ALPHA_MODE_UNKNOWN = 0x00000000;
        private const uint DDS_RESOURCE_MISC_TEXTURECUBE = 0x00000004;

        private const uint DDS_ALPHA_MODE_STRAIGHT = 0x00000001;

        #endregion DDS_HEADER_DXT10

        #region Methods

        private static uint MAKEFOURCC(char ch0, char ch1, char ch2, char ch3) => (uint)(ch0 | (ch1 << 8) | (ch2 << 16) | (ch3 << 24));

        private static void SetPixelmask(Func<uint[]> pfmtfactory, ref DDS_PIXELFORMAT pfmt)
        {
            var masks = pfmtfactory.Invoke();
            pfmt.dwRGBBitCount = masks[0];
            pfmt.dwRBitMask = masks[1];
            pfmt.dwGBitMask = masks[2];
            pfmt.dwBBitMask = masks[3];
            pfmt.dwABitMask = masks[4];
        }

        #endregion Methods

        #region DDS_PIXELFORMAT

        private const uint DDPF_ALPHA = 0x00000002;

        // dwFlags
        private const uint DDPF_ALPHAPIXELS = 0x00000001;

        private const uint DDPF_FOURCC = 0x00000004;

        private const uint DDPF_LUMINANCE = 0x00020000;

        private const uint DDPF_NORMAL = 0x80000000;

        private const uint DDPF_RGB = 0x00000040;

        // dwSize
        private const uint PIXELFORMAT_SIZE = 32;

        // Custom nv flag

        private static uint[] DDSPF_A1R5G5B5() => new uint[5] { 16, 0x00007c00, 0x000003e0, 0x0000001f, 0x00000000 };

        private static uint[] DDSPF_A4R4G4B4() => new uint[5] { 16, 0x00000f00, 0x000000f0, 0x0000000f, 0x0000f000 };

        private static uint[] DDSPF_A8() => new uint[5] { 8, 0x00, 0x00, 0x00, 0xff };

        private static uint[] DDSPF_A8B8G8R8() => new uint[5] { 32, 0x000000ff, 0x0000ff00, 0x00ff0000, 0xff000000 };

        private static uint[] DDSPF_A8L8() => new uint[5] { 16, 0x00ff, 0x0000, 0x0000, 0xff00 };

        //dwRGBBitCount     dwRBitMask      dwGBitMask      dwBBitMask      dwABitMask
        private static uint[] DDSPF_A8R8G8B8() => new uint[5] { 32, 0x00ff0000, 0x0000ff00, 0x000000ff, 0xff000000 };

        private static uint[] DDSPF_G16R16() => new uint[5] { 32, 0x0000ffff, 0xffff0000, 0x00000000, 0x00000000 };

        private static uint[] DDSPF_L8() => new uint[5] { 8, 0xff, 0x00, 0x00, 0x00 };

        private static uint[] DDSPF_R5G6B5() => new uint[5] { 16, 0x0000f800, 0x000007e0, 0x0000001f, 0x00000000 };

        private static uint[] DDSPF_R8G8B8() => new uint[5] { 24, 0x00ff0000, 0x0000ff00, 0x000000ff, 0x00000000 };

        private static uint[] DDSPF_X8B8G8R8() => new uint[5] { 32, 0x000000ff, 0x0000ff00, 0x00ff0000, 0x00000000 };

        private static uint[] DDSPF_X8R8G8B8() => new uint[5] { 32, 0x00ff0000, 0x0000ff00, 0x000000ff, 0x00000000 };

        #endregion DDS_PIXELFORMAT

        #region Convert

        public enum ConvertableFileTypes
        {
            bmp,
            png,
            dds,
            tga,
            tif,
            wdp
        }

        #endregion

        #region Writing

        public class DDSInfo
        {
            public Enums.ETextureCompression Compression { get; set; }
            public Enums.ETextureRawFormat RawFormat { get; set; }
            public bool IsGamma { get; set; }

            public uint Width { get; set; }
            public uint Height { get; set; }
            public uint Depth { get; set; }
            public uint MipCount { get; set; }
            public uint SliceCount { get; set; }
            public Enums.GpuWrapApieTextureType TextureType { get; set; }

            public bool FlipV { get; set; }
        }

        public static void GenerateAndWriteHeader(Stream stream, DDSInfo info)
        {
            var (ddsHeader, dxt10Header) = GenerateHeader(info);
            WriteHeader(stream, ddsHeader, dxt10Header);
        }

        private static (DDS_HEADER, DDS_HEADER_DXT10) GenerateHeader(DDSInfo info)
        {
            var ddsHeader = new DDS_HEADER()
            {
                dwSize = HEADER_SIZE,
                dwFlags = DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT,
                dwHeight = info.Height,
                dwWidth = info.Width,
                dwPitchOrLinearSize = 0,
                dwDepth = info.Depth,
                dwMipMapCount = info.MipCount,
                dwReserved1 = 0,
                dwReserved2 = 0,
                dwReserved3 = 0,
                dwReserved4 = 0,
                dwReserved5 = 0,
                dwReserved6 = 0,
                dwReserved7 = 0,
                dwReserved8 = 0,
                dwReserved9 = 0,
                dwReserved10 = 0,
                dwReserved11 = 0,
                ddspf = new DDS_PIXELFORMAT
                {
                    dwSize = PIXELFORMAT_SIZE,
                    dwFlags = DDPF_FOURCC,
                    dwFourCC = MAKEFOURCC('D', 'X', '1', '0'),
                    dwRGBBitCount = 0,
                    dwRBitMask = 0,
                    dwGBitMask = 0,
                    dwBBitMask = 0,
                    dwABitMask = 0
                },
                dwCaps = DDSCAPS_TEXTURE,
                dwCaps2 = 0,
                dwCaps3 = 0,
                dwCaps4 = 0,
                dwReserved12 = 0,
            };

            var dx10Header = new DDS_HEADER_DXT10()
            {
                dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN,
                resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_UNKNOWN,
                miscFlag = 0,
                arraySize = 1,
                miscFlags2 = DDS_ALPHA_MODE_STRAIGHT
            };

            dx10Header.dxgiFormat = info.Compression switch
            {
                Enums.ETextureCompression.TCM_None => info.RawFormat switch
                {
                    Enums.ETextureRawFormat.TRF_Invalid => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                    Enums.ETextureRawFormat.TRF_TrueColor => info.IsGamma ? DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                    Enums.ETextureRawFormat.TRF_DeepColor => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM, // seems wrong
                    Enums.ETextureRawFormat.TRF_Grayscale => DXGI_FORMAT.DXGI_FORMAT_R8_UNORM,
                    Enums.ETextureRawFormat.TRF_HDRFloat => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
                    Enums.ETextureRawFormat.TRF_HDRHalf => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT,
                    Enums.ETextureRawFormat.TRF_HDRFloatGrayscale => DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT,
                    Enums.ETextureRawFormat.TRF_R8G8 => DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM,
                    Enums.ETextureRawFormat.TRF_Grayscale_Font => DXGI_FORMAT.DXGI_FORMAT_A8_UNORM,
                    _ => throw new ArgumentOutOfRangeException()
                },
                Enums.ETextureCompression.TCM_DXTNoAlpha => info.IsGamma ? DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM,
                Enums.ETextureCompression.TCM_DXTAlpha => info.IsGamma ? DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
                Enums.ETextureCompression.TCM_Normalmap => DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM,
                Enums.ETextureCompression.TCM_Normals_DEPRECATED => DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM,
                Enums.ETextureCompression.TCM_NormalsHigh_DEPRECATED => DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
                Enums.ETextureCompression.TCM_DXTAlphaLinear => info.IsGamma ? DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
                Enums.ETextureCompression.TCM_QualityR => DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM,
                Enums.ETextureCompression.TCM_QualityRG => DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM,
                Enums.ETextureCompression.TCM_QualityColor => info.IsGamma ? DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB : DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM,
                Enums.ETextureCompression.TCM_HalfHDR_Unsigned => DXGI_FORMAT.DXGI_FORMAT_BC6H_UF16,
                _ => throw new NotSupportedException()
            };

            if (info.Compression == Enums.ETextureCompression.TCM_DXTAlpha)
            {
                dx10Header.miscFlags2 = 2;
            }

            var dxFormat = (DirectXTexNet.DXGI_FORMAT)(int)dx10Header.dxgiFormat;

            switch (info.TextureType)
            {

                case Enums.GpuWrapApieTextureType.TEXTYPE_2D:
                    dx10Header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D;
                    break;
                case Enums.GpuWrapApieTextureType.TEXTYPE_CUBE:
                    dx10Header.arraySize = info.SliceCount;
                    dx10Header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D;
                    break;
                case Enums.GpuWrapApieTextureType.TEXTYPE_ARRAY:
                    dx10Header.arraySize = info.SliceCount;
                    dx10Header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D;
                    break;
                case Enums.GpuWrapApieTextureType.TEXTYPE_3D:
                    dx10Header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            TexHelper.Instance.ComputePitch(dxFormat, (int)ddsHeader.dwWidth, (int)ddsHeader.dwHeight, out var row, out var slice, CP_FLAGS.NONE);
            if (TexHelper.Instance.IsCompressed(dxFormat))
            {
                ddsHeader.dwPitchOrLinearSize = (uint)slice;
                ddsHeader.dwFlags |= DDSD_LINEARSIZE;
            }
            else
            {
                ddsHeader.dwPitchOrLinearSize = (uint)row;
                ddsHeader.dwFlags |= DDSD_PITCH;
            }

            //switch (dx10Header.dxgiFormat)
            //{
            //    case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
            //    case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
            //        var nbw1 = Math.Max(1, (ddsHeader.dwWidth + 3) / 4);
            //        var nbh1 = Math.Max(1, (ddsHeader.dwHeight + 3) / 4);
            //        ddsHeader.dwPitchOrLinearSize = nbw1 * nbh1 * 8;
            //        ddsHeader.dwFlags |= DDSD_LINEARSIZE;
            //        if (ddsHeader.dwPitchOrLinearSize != slice)
            //        {
            //
            //        }
            //
            //        // var b1 = ddsHeader.dwPitchOrLinearSize == header.MipMapInfo[1 - setup.PlatformMipBiasPC].Layout.SlicePitch;
            //        break;
            //
            //    case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
            //    case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
            //    case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
            //        var nbw2 = Math.Max(1, (ddsHeader.dwWidth + 3) / 4);
            //        var nbh2 = Math.Max(1, (ddsHeader.dwHeight + 3) / 4);
            //        ddsHeader.dwPitchOrLinearSize = nbw2 * nbh2 * 16;
            //        ddsHeader.dwFlags |= DDSD_LINEARSIZE;
            //        if (ddsHeader.dwPitchOrLinearSize != slice)
            //        {
            //
            //        }
            //
            //        // var b2 = ddsHeader.dwPitchOrLinearSize == header.MipMapInfo[0].Layout.SlicePitch;
            //        break;
            //
            //    default:
            //        ddsHeader.dwPitchOrLinearSize = ((ddsHeader.dwWidth * bpp) + 7) / header.TextureInfo.DataAlignment;
            //        ddsHeader.dwFlags |= DDSD_PITCH;
            //        if (ddsHeader.dwPitchOrLinearSize != row)
            //        {
            //
            //        }
            //
            //        // var b3 = ddsHeader.dwPitchOrLinearSize == header.MipMapInfo[0].Layout.RowPitch;
            //        break;
            //}

            if (ddsHeader.dwMipMapCount > 0)
            {
                ddsHeader.dwFlags |= DDSD_MIPMAPCOUNT;

                if (ddsHeader.dwMipMapCount > 1)
                {
                    ddsHeader.dwCaps |= DDSCAPS_MIPMAP | DDSCAPS_COMPLEX;
                }
            }

            if (dx10Header.resourceDimension == D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D)
            {
                ddsHeader.dwDepth = 1;

                if (info.TextureType == Enums.GpuWrapApieTextureType.TEXTYPE_CUBE)
                {
                    ddsHeader.dwCaps |= DDSCAPS_COMPLEX;
                    ddsHeader.dwCaps2 |= DDSCAPS2_CUBEMAP_ALL_FACES;

                    dx10Header.miscFlag |= 0x04;
                    if (dx10Header.arraySize % 6 != 0)
                    {
                        throw new Exception();
                    }
                    dx10Header.arraySize /= 6;
                }
            }

            if (dx10Header.resourceDimension == D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D)
            {
                ddsHeader.dwDepth = info.Depth;

                ddsHeader.dwFlags |= DDSD_DEPTH;
                ddsHeader.dwCaps2 |= DDSCAPS2_VOLUME;
            }

            return (ddsHeader, dx10Header);
        }

        public static void GenerateAndWriteHeader(Stream stream, DDSMetadata metadata)
        {
            var (header, dxt10header) = GenerateHeader(metadata);
            WriteHeader(stream, header, dxt10header);
        }

        private static (DDS_HEADER, DDS_HEADER_DXT10) GenerateHeader(DDSMetadata metadata)
        {
            var height = metadata.Height;
            var width = metadata.Width;
            var depth = metadata.Depth;
            var mipscount = metadata.Mipscount;
            var iscubemap = metadata.IsCubeMap();
            var format = metadata.Format;
            var dxt10 = metadata.Dx10;

            var ddspf = new DDS_PIXELFORMAT()
            {
                dwSize = PIXELFORMAT_SIZE,
                dwFlags = 0,
                dwFourCC = 0,
                dwRGBBitCount = 0,
                dwRBitMask = 0,
                dwGBitMask = 0,
                dwBBitMask = 0,
                dwABitMask = 0
            };

            var header = new DDS_HEADER()
            {
                dwSize = HEADER_SIZE,
                dwFlags = DDS_HEADER_FLAGS_TEXTURE,
                dwHeight = height,
                dwWidth = width,
                dwPitchOrLinearSize = 0,
                dwDepth = depth,
                dwMipMapCount = mipscount,
                dwReserved1 = 0,
                dwReserved2 = 0,
                dwReserved3 = 0,
                dwReserved4 = 0,
                dwReserved5 = 0,
                dwReserved6 = 0,
                dwReserved7 = 0,
                dwReserved8 = 0,
                dwReserved9 = 0,
                dwReserved10 = 0,
                dwReserved11 = 0,
                ddspf = ddspf,
                dwCaps = DDSCAPS_TEXTURE,
                dwCaps2 = 0,
                dwCaps3 = 0,
                dwCaps4 = 0,
                dwReserved12 = 0,
            };

            var dx10header = new DDS_HEADER_DXT10()
            {
                dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM,
                resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D,
                miscFlag = 0,
                arraySize = metadata.Slicecount,
                miscFlags2 = DDS_ALPHA_MODE_STRAIGHT
            };

            if (dx10header.arraySize > 1 && metadata.Dimensions == TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D)
            {
                header.dwCaps2 |= 0x200;
                dx10header.miscFlag |= 0x4;
            }

            if (metadata.Dimensions == TEX_DIMENSION.TEX_DIMENSION_TEXTURE3D)
            {
                dx10header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D;
            }

            // pixelformat
            {
                // dwFourCC
                if (dxt10)
                {
                    ddspf.dwFourCC = MAKEFOURCC('D', 'X', '1', '0');
                }
                else
                {
                    switch (format)
                    {
                        case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                            ddspf.dwFourCC = 116;
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                            ddspf.dwFourCC = 113;
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM:
                            throw new NotImplementedException();
                        case DXGI_FORMAT.DXGI_FORMAT_R32_UINT:
                            throw new NotImplementedException();
                        case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM:
                            SetPixelmask(DDSPF_A8L8, ref ddspf);
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT:
                            ddspf.dwFourCC = 111;
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_R8_UNORM:
                        case DXGI_FORMAT.DXGI_FORMAT_R8_UINT:
                            SetPixelmask(DDSPF_L8, ref ddspf);
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                            SetPixelmask(DDSPF_A8, ref ddspf);
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                            SetPixelmask(DDSPF_A8R8G8B8, ref ddspf);
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '1');
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '3');
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '5');
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('B', 'C', '4', 'U');
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('B', 'C', '5', 'U');
                            break;

                        case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
                            dxt10 = true;
                            break;

                        default:
                            throw new MissingFormatException($"Missing format: {format}");
                    }
                }

                // dwflags
                if (ddspf.dwABitMask != 0) // check this
                {
                    ddspf.dwFlags |= DDPF_ALPHAPIXELS;
                }
                /*if (ddspf.dwABitMask != 0)
   ddspf.dwFlags |= DDPF_ALPHA;*/ //old
                if (ddspf.dwFourCC != 0)
                {
                    ddspf.dwFlags |= DDPF_FOURCC;
                }

                if (ddspf.dwRGBBitCount != 0 && ddspf.dwRBitMask != 0 && ddspf.dwGBitMask != 0 && ddspf.dwBBitMask != 0)
                {
                    ddspf.dwFlags |= DDPF_RGB;
                }

                if (ddspf.dwRBitMask != 0 && ddspf.dwGBitMask == 0 && ddspf.dwBBitMask == 0 && ddspf.dwABitMask == 0)
                {
                    ddspf.dwFlags |= DDPF_LUMINANCE;
                }

                header.ddspf = ddspf;
            }

            // dwPitchOrLinearSize
            uint p = 0;
            var bpp = ddspf.dwRGBBitCount;
            switch (format)
            {
                case DXGI_FORMAT.DXGI_FORMAT_R8_UNORM:
                    header.dwPitchOrLinearSize = ((width * bpp) + 7) / 8;
                    break;

                case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                case DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_R32_UINT:
                case DXGI_FORMAT.DXGI_FORMAT_R8_UINT:
                case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT:
                case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
                    header.dwPitchOrLinearSize = ((width * bpp) + 7) / 8;
                    header.dwFlags |= DDSD_PITCH;
                    break;

                case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB:
                case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
                    p = width * height / 2; //max(1,width ?4)x max(1,height ?4)x 8 (DXT1)
                    header.dwPitchOrLinearSize = p;
                    header.dwFlags |= DDSD_LINEARSIZE;
                    break;

                case DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB:
                case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
                case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB:
                    p = width * height;     //max(1,width ?4)x max(1,height ?4)x 16 (DXT2-5)
                    header.dwPitchOrLinearSize = p;
                    header.dwFlags |= DDSD_LINEARSIZE;
                    break;

                default:
                    throw new MissingFormatException($"Missing format: {format}");
            }
            // unused R8G8_B8G8, G8R8_G8B8, legacy UYVY-packed, and legacy YUY2-packed formats,
            // header.dwPitchOrLinearSize = ((width + 1) >> 1) * 4;

            // depth
            //if (slicecount > 0  && !iscubemap)
            //    header.dwDepth = slicecount;

            // caps
            if (iscubemap || mipscount > 1)
            {
                header.dwCaps |= DDSCAPS_COMPLEX;
            }

            if (mipscount > 1)
            {
                header.dwCaps |= DDSCAPS_MIPMAP;
            }

            // caps2
            if (iscubemap)
            {
                header.dwCaps2 |= DDSCAPS2_CUBEMAP_ALL_FACES | DDSCAPS2_CUBEMAP;
            }
            //if (slicecount > 0)
            //    header.dwCaps2 |= DDSCAPS2_VOLUME;

            // flags
            //if (slicecount > 0)
            //    header.dwFlags |= DDSD_DEPTH;
            if (mipscount > 0)
            {
                header.dwFlags |= DDSD_MIPMAPCOUNT;
            }

            if (depth > 0)
            {
                header.dwFlags |= DDSD_DEPTH;
            }

            // DXT10
            if (dxt10)
            {
                // dxgiFormat
                switch (format)
                {
                    case DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R32_UINT:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R32_UINT;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R8_UINT:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8_UINT;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R8_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_A8_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_A8_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB;
                        break;

                    case DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB:
                        dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB;
                        break;

                    default:
                    {
                        throw new MissingFormatException($"Missing format: {format}");
                    }
                }
                // resourceDimension
                //if (slicecount > 0)
                //    dxt10header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D;
                //misc flag
                //if (iscubemap)
                //    dxt10header.miscFlag |= DDS_RESOURCE_MISC_TEXTURECUBE;
                //if (mipscount > 0)
                //    dxt10header.miscFlag |= D3D10_RESOURCE_MISC_GENERATE_MIPS;
                // array size
                //if (iscubemap)
                //    dxt10header.arraySize = metadata.Slicecount;
                // miscFlags2
            }

            return (header, dx10header);
        }

        private static void WriteHeader(Stream stream, DDS_HEADER header, DDS_HEADER_DXT10 dxt10header)
        {
            stream.Write(BitConverter.GetBytes(DDS_MAGIC), 0, 4);
            stream.WriteStruct(header);
            if (header.ddspf.dwFourCC == MAKEFOURCC('D', 'X', '1', '0'))
            {
                stream.WriteStruct(dxt10header);
            }
        }

        #endregion Writing

        #region Reading

        public static bool TryReadDdsHeader(Stream stream, out DDS_HEADER header)
        {
            header = default;
            if (stream.Length < 128)
            {
                return false;
            }

            if (stream.ReadStruct<int>() != DDS_MAGIC)
            {
                return false;
            }

            header = stream.ReadStruct<DDS_HEADER>();


            return true;
        }

        /// <summary>
        /// Check if a stream is a dds file. Does not advance the stream.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static bool IsDdsFile(Stream stream)
        {
            var pos = stream.Position;
            var result = TryReadDdsHeader(stream, out _);
            stream.Seek(pos, SeekOrigin.Begin);
            return result;
        }

        #endregion Reading

    }
}
