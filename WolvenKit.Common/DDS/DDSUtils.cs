using System;
using System.IO;
using System.Linq;

namespace WolvenKit.Common.Tools.DDS
{
    public static class DDSUtils
    {
        const uint DDS_MAGIC = 0x20534444; // "DDS "

        // constants
        #region DDS_HEADER

        // dwsize
        const uint HEADER_SIZE = 124;

        // dwflags
        const uint DDSD_CAPS = 0x00000001;          //required
        const uint DDSD_HEIGHT = 0x00000002;        //required
        const uint DDSD_WIDTH = 0x00000004;         //required
        const uint DDSD_PITCH = 0x00000008;
        const uint DDSD_PIXELFORMAT = 0x00001000;   //required
        const uint DDSD_MIPMAPCOUNT = 0x00020000;
        const uint DDSD_LINEARSIZE = 0x00080000;
        const uint DDSD_DEPTH = 0x00800000;

        const uint DDS_HEADER_FLAGS_TEXTURE = 0x00001007;  // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT 

        // dwCaps
        const uint DDSCAPS_COMPLEX = 0x00000008;
        const uint DDSCAPS_MIPMAP = 0x00400000;
        const uint DDSCAPS_TEXTURE = 0x00001000;

        // dwCaps2
        public const uint DDSCAPS2_CUBEMAP = 0x00000200;
        const uint DDS_CUBEMAP_POSITIVEX = 0x00000600; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEX
        const uint DDS_CUBEMAP_NEGATIVEX = 0x00000a00; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEX
        const uint DDS_CUBEMAP_POSITIVEY = 0x00001200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEY
        const uint DDS_CUBEMAP_NEGATIVEY = 0x00002200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEY
        const uint DDS_CUBEMAP_POSITIVEZ = 0x00004200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEZ
        const uint DDS_CUBEMAP_NEGATIVEZ = 0x00008200;// DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEZ
        public const uint DDSCAPS2_CUBEMAP_ALL_FACES = DDS_CUBEMAP_POSITIVEX | DDS_CUBEMAP_NEGATIVEX |
                                                DDS_CUBEMAP_POSITIVEY | DDS_CUBEMAP_NEGATIVEY |
                                                DDS_CUBEMAP_POSITIVEZ | DDS_CUBEMAP_NEGATIVEZ;
        const uint DDSCAPS2_VOLUME = 0x00200000;
        #endregion

        #region DDS_HEADER_DXT10
        const uint D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x00000001;
        const uint DDS_RESOURCE_MISC_TEXTURECUBE = 0x00000004;

        const uint DDS_ALPHA_MODE_UNKNOWN = 0x00000000;

        #endregion

        private static uint MAKEFOURCC(char ch0, char ch1, char ch2, char ch3) => (uint)(ch0 | ch1 << 8 | ch2 << 16 | ch3 << 24);
        private static void SetPixelmask(Func<uint[]> pfmtfactory, ref DDS_PIXELFORMAT pfmt)
        {
            uint[] masks = pfmtfactory.Invoke();
            pfmt.dwRGBBitCount = masks[0];
            pfmt.dwRBitMask = masks[1];
            pfmt.dwGBitMask = masks[2];
            pfmt.dwBBitMask = masks[3];
            pfmt.dwABitMask = masks[4];
        }

        #region DDS_PIXELFORMAT 
        // dwSize
        const uint PIXELFORMAT_SIZE = 32;
        // dwFlags
        const uint DDPF_ALPHAPIXELS = 0x00000001;
        const uint DDPF_ALPHA = 0x00000002;
        const uint DDPF_FOURCC = 0x00000004;
        const uint DDPF_RGB = 0x00000040;
        const uint DDPF_NORMAL = 0x80000000; // Custom nv flag

        //dwRGBBitCount     dwRBitMask      dwGBitMask      dwBBitMask      dwABitMask
        static uint[] DDSPF_A8R8G8B8() => new uint[5] { 32, 0x00ff0000, 0x0000ff00, 0x000000ff, 0xff000000 };
        static uint[] DDSPF_X8R8G8B8() => new uint[5] { 32, 0x00ff0000, 0x0000ff00, 0x000000ff, 0x00000000 };
        static uint[] DDSPF_A8B8G8R8() => new uint[5] { 32, 0x000000ff, 0x0000ff00, 0x00ff0000, 0xff000000 };
        static uint[] DDSPF_X8B8G8R8() => new uint[5] { 32, 0x000000ff, 0x0000ff00, 0x00ff0000, 0x00000000 };
        static uint[] DDSPF_G16R16() => new uint[5] { 32, 0x0000ffff, 0xffff0000, 0x00000000, 0x00000000 };
        static uint[] DDSPF_R5G6B5() => new uint[5] { 16, 0x0000f800, 0x000007e0, 0x0000001f, 0x00000000 };
        static uint[] DDSPF_A1R5G5B5() => new uint[5] { 16, 0x00007c00, 0x000003e0, 0x0000001f, 0x00000000 };
        static uint[] DDSPF_A4R4G4B4() => new uint[5] { 16, 0x00000f00, 0x000000f0, 0x0000000f, 0x0000f000 };
        static uint[] DDSPF_R8G8B8() => new uint[5] { 24, 0x00ff0000, 0x0000ff00, 0x000000ff, 0x00000000 };

        static uint[] DDSPF_L8() => new uint[5] { 8, 0xff, 0x00, 0x00, 0x00 };
        static uint[] DDSPF_A8() => new uint[5] { 8, 0x00, 0x00, 0x00, 0xff };
        static uint[] DDSPF_A8L8() => new uint[5] { 16, 0x00ff, 0x0000, 0x0000, 0xff00 };
        #endregion

        #region Writing
        public static void GenerateAndWriteHeader(Stream stream, DDSMetadata metadata)
        {
            var (header, dxt10header) = GenerateHeader(metadata);
            WriteHeader(stream, header, dxt10header);
        }

        private static (DDS_HEADER, DDS_HEADER_DXT10) GenerateHeader(DDSMetadata metadata)
        {
            var height = metadata.Height;
            var width = metadata.Width;
            var mipscount = metadata.Mipscount;
            var iscubemap = metadata.Iscubemap;
            var format = metadata.Format;
            bool dxt10 = /*metadata.Format == EFormat.BC7_UNORM;*/metadata.Dx10;  //TODO
            // for BC7_UNORM, R8_UINT

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
                dwDepth = 0,
                dwMipMapCount = 0,
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
                miscFlags2 = 0
            };

            if (mipscount > 0)
                header.dwMipMapCount = mipscount;


            // pixelformat
            {
                // dwFourCC
                if (dxt10)
                    ddspf.dwFourCC = MAKEFOURCC('D', 'X', '1', '0');
                else
                {
                    switch (format)
                    {
                        case EFormat.R32G32B32A32_FLOAT:
                            ddspf.dwFourCC = 116; break;
                        case EFormat.R16G16B16A16_FLOAT:
                            ddspf.dwFourCC = 113; break;
                        case EFormat.R10G10B10A2_UNORM:
                            throw new NotImplementedException();
                        case EFormat.R32_UINT:
                            throw new NotImplementedException();
                        case EFormat.R8G8_UNORM:
                            SetPixelmask(DDSPF_A8L8, ref ddspf); break;
                        case EFormat.R16_FLOAT:
                            ddspf.dwFourCC = 111; break;
                        case EFormat.R8_UINT:
                            SetPixelmask(DDSPF_L8, ref ddspf); break;
                        case EFormat.A8_UNORM:
                            SetPixelmask(DDSPF_A8, ref ddspf); break;
                        case EFormat.R8G8B8A8_UNORM:
                            SetPixelmask(DDSPF_A8R8G8B8, ref ddspf); break;
                        case EFormat.BC1_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '1'); break;
                        case EFormat.BC2_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '3'); break;
                        case EFormat.BC3_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '5'); break;
                        case EFormat.BC4_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('B', 'C', '4', 'U'); break;
                        case EFormat.BC5_UNORM:
                            ddspf.dwFourCC = MAKEFOURCC('B', 'C', '5', 'U'); break;
                        case EFormat.BC7_UNORM:
                            dxt10 = true; break;
                        default:
                            throw new MissingFormatException($"Missing Format: {format}");
                    }
                }
                
                // dwflags
                if (ddspf.dwABitMask != 0) // check this
                    ddspf.dwFlags |= DDPF_ALPHAPIXELS;
                /*if (ddspf.dwABitMask != 0)
                    ddspf.dwFlags |= DDPF_ALPHA;*/ //old
                if (ddspf.dwFourCC != 0)
                    ddspf.dwFlags |= DDPF_FOURCC;
                if (ddspf.dwRGBBitCount != 0 && (ddspf.dwRBitMask != 0 || ddspf.dwGBitMask != 0 || ddspf.dwBBitMask != 0))
                    ddspf.dwFlags |= DDPF_RGB;
                

                header.ddspf = ddspf;
            }

            // dwPitchOrLinearSize
            uint p = 0;
            switch (format)
            {
                case EFormat.R32G32B32A32_FLOAT:
                case EFormat.R16G16B16A16_FLOAT:
                case EFormat.R10G10B10A2_UNORM:
                case EFormat.R32_UINT:
                case EFormat.R8_UINT:
                case EFormat.R8G8_UNORM:
                case EFormat.R16_FLOAT:
                case EFormat.A8_UNORM:
                case EFormat.R8G8B8A8_UNORM:
                    var bpp = ddspf.dwRGBBitCount;
                    header.dwPitchOrLinearSize = (width * bpp + 7) / 8;
                    header.dwFlags |= DDSD_PITCH;
                    break;
                case EFormat.BC1_UNORM:
                case EFormat.BC4_UNORM:
                    p = width * height / 2; //max(1,width ?4)x max(1,height ?4)x 8 (DXT1)
                    header.dwPitchOrLinearSize = (uint)(p);
                    header.dwFlags |= DDSD_LINEARSIZE;
                    break;
                case EFormat.BC2_UNORM:
                case EFormat.BC3_UNORM:
                case EFormat.BC5_UNORM:
                case EFormat.BC7_UNORM:
                    p = width * height;     //max(1,width ?4)x max(1,height ?4)x 16 (DXT2-5)
                    header.dwPitchOrLinearSize = (uint)(p);
                    header.dwFlags |= DDSD_LINEARSIZE;
                    break;
                default:
                    throw new MissingFormatException($"Missing Format: {format}");
            }
            // unused R8G8_B8G8, G8R8_G8B8, legacy UYVY-packed, and legacy YUY2-packed formats,
            // header.dwPitchOrLinearSize = ((width + 1) >> 1) * 4;

            // depth
            //if (slicecount > 0  && !iscubemap)
            //    header.dwDepth = slicecount;


            // caps
            if (iscubemap || mipscount > 0)
                header.dwCaps |= DDSCAPS_COMPLEX;
            if (mipscount > 0)
                header.dwCaps |= DDSCAPS_MIPMAP;

            // caps2
            if (iscubemap)
                header.dwCaps2 |= DDSCAPS2_CUBEMAP_ALL_FACES | DDSCAPS2_CUBEMAP;
            //if (slicecount > 0)
            //    header.dwCaps2 |= DDSCAPS2_VOLUME;

            // flags
            //if (slicecount > 0)
            //    header.dwFlags |= DDSD_DEPTH;
            if (mipscount > 0)
                header.dwFlags |= DDSD_MIPMAPCOUNT;

            // DXT10
            if (dxt10)
            {   
                // dxgiFormat
                switch (format)
                {
                    case EFormat.R32G32B32A32_FLOAT: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT; break;
                    case EFormat.R16G16B16A16_FLOAT: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT; break;
                    case EFormat.R10G10B10A2_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM; break;
                    case EFormat.R8G8B8A8_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM; break;
                    case EFormat.R32_UINT: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R32_UINT; break;
                    case EFormat.R8G8_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM; break;
                    case EFormat.R16_FLOAT: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT; break;
                    case EFormat.R8_UINT: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8_UINT; break;
                    case EFormat.A8_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_A8_UNORM; break;
                    case EFormat.BC1_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM; break;
                    case EFormat.BC2_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM; break;
                    case EFormat.BC3_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM; break;
                    case EFormat.BC4_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM; break;
                    case EFormat.BC7_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM; break;
                    case EFormat.BC5_UNORM: dx10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM; break;
                    default:
                    {
                        throw new MissingFormatException($"Missing Format: {format}");
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
                stream.WriteStruct(dxt10header);
        }
        #endregion

        #region Reading
        public static DDSMetadata ReadHeader(string ddsfile)
        {
            var metadata = new DDSMetadata();
            using (var fs = new FileStream(ddsfile, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                if (fs.Length < 128) return metadata;

                // check if DDS file
                var buffer = reader.ReadBytes(4);
                if (!buffer.SequenceEqual(BitConverter.GetBytes(DDS_MAGIC))) return metadata;

                var id = reader.BaseStream.ReadStruct<DDS_HEADER>();
                metadata = new DDSMetadata(id);

                return metadata;
            }
        }

        public static uint CalculateMipMapSize(uint width, uint height, EFormat format)
        {
            //TODO: dword align, check if sizes are not pow2
            

            switch (format)
            {
                case EFormat.R8G8B8A8_UNORM: 
                    return width * height * 4; //(width * bpp + 7) / 8;
                case EFormat.BC1_UNORM:
                case EFormat.BC4_UNORM:
                    return width * height / 2;  //max(1,width ?4)x max(1,height ?4)x 8 (DXT1)
                case EFormat.BC2_UNORM:
                case EFormat.BC3_UNORM:
                case EFormat.BC5_UNORM:
                case EFormat.BC7_UNORM:
                    return width * height;      //max(1,width ?4)x max(1,height ?4)x 16 (DXT2-5)
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

    }
}
