using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Cache.DDS
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
        const uint DDSCAPS2_CUBEMAP = 0x00000200;
        const uint DDS_CUBEMAP_POSITIVEX = 0x00000600; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEX
        const uint DDS_CUBEMAP_NEGATIVEX = 0x00000a00; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEX
        const uint DDS_CUBEMAP_POSITIVEY = 0x00001200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEY
        const uint DDS_CUBEMAP_NEGATIVEY = 0x00002200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEY
        const uint DDS_CUBEMAP_POSITIVEZ = 0x00004200; // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEZ
        const uint DDS_CUBEMAP_NEGATIVEZ = 0x00008200;// DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEZ
        const uint DDSCAPS2_CUBEMAP_ALL_FACES = DDS_CUBEMAP_POSITIVEX | DDS_CUBEMAP_NEGATIVEX |
                                                DDS_CUBEMAP_POSITIVEY | DDS_CUBEMAP_NEGATIVEY | 
                                                DDS_CUBEMAP_POSITIVEZ | DDS_CUBEMAP_NEGATIVEZ;
        const uint DDSCAPS2_VOLUME = 0x00200000;
        #endregion

        #region DDS_HEADER_DXT10
        const uint D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x00000001;
        const uint DDS_RESOURCE_MISC_TEXTURECUBE = 0x00000004;

        const uint DDS_ALPHA_MODE_UNKNOWN = 0x00000000;

        #endregion

        #region DDS_PIXELFORMAT 
        // dwSize
        const uint PIXELFORMAT_SIZE = 32;
        // dwFlags
        const uint DDPF_ALPHAPIXELS = 0x00000001;
        const uint DDPF_ALPHA = 0x00000002;
        const uint DDPF_FOURCC = 0x00000004;
        const uint DDPF_RGB = 0x00000040;
        const uint DDPF_NORMAL = 0x80000000; // Custom nv flag
        #endregion


        private static uint MAKEFOURCC(char ch0, char ch1, char ch2, char ch3) => (uint)(ch0 | ch1 << 8 | ch2 << 16 | ch3 << 24);


        public static (DDS_HEADER, DDS_HEADER_DXT10) GenerateHeader(DDSMetadata metadata)
        {
            var height = metadata.Height;
            var width = metadata.Height;
            var mipscount = metadata.Mipscount;
            var iscubemap = metadata.Iscubemap;
            var format = metadata.Format;

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

            var dxt10header = new DDS_HEADER_DXT10()
            {
                dxgiFormat = 0,
                resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D,
                miscFlag = 0,
                arraySize = metadata.Slicecount,
                miscFlags2 = 0
            };

            if (mipscount > 0)
                header.dwMipMapCount = mipscount;

            // dwPitchOrLinearSize
            switch (format)
            {
                case ETextureFormat.TEXFMT_BC1:
                case ETextureFormat.TEXFMT_BC2:
                case ETextureFormat.TEXFMT_BC3:
                case ETextureFormat.TEXFMT_BC4:
                case ETextureFormat.TEXFMT_BC5:
                case ETextureFormat.TEXFMT_BC6H:
                case ETextureFormat.TEXFMT_BC7:
                    {
                        /*var blocksize = 16;
                        if (format == ETextureFormat.TEXFMT_BC1 || format == ETextureFormat.TEXFMT_BC4)
                            blocksize = 8;

                        var f = ((float)width + 3) / 4;
                        var p =(Math.Max(1, f) * blocksize);
                        //var p = (uint)(Math.Max(1, ((width + 3) / 4)) * blocksize);*/
                        uint p = 0;
                        if (format == ETextureFormat.TEXFMT_BC1 || format == ETextureFormat.TEXFMT_BC4)
                            p = width * height / 2;
                        else
                            p = width * height;

                        header.dwPitchOrLinearSize = (uint)(p);
                        header.dwFlags |= DDSD_LINEARSIZE;
                        break;
                    }
                case ETextureFormat.TEXFMT_R8G8B8A8:
                default:
                    {
                        header.dwPitchOrLinearSize = (width * metadata.Bpp + 7) / 8;
                        header.dwFlags |= DDSD_PITCH;
                        break;
                    }
            }
            // unused R8G8_B8G8, G8R8_G8B8, legacy UYVY-packed, and legacy YUY2-packed formats,
            // header.dwPitchOrLinearSize = ((width + 1) >> 1) * 4;

            // depth
            //if (slicecount > 0  && !iscubemap)
            //    header.dwDepth = slicecount;

            // pixelformat
            {
                // dwFourCC
                switch (format)
                {
                    case ETextureFormat.TEXFMT_R8G8B8A8:
                        {
                            ddspf.dwRGBBitCount = 32;
                            ddspf.dwRBitMask = 0xff;
                            ddspf.dwGBitMask = 0xff00;
                            ddspf.dwBBitMask = 0xff0000;
                            ddspf.dwABitMask = 0xff000000;
                            /*ddspf.dwRBitMask = 0x0f00;
                            ddspf.dwGBitMask = 0x00f0;
                            ddspf.dwBBitMask = 0x000f;
                            ddspf.dwABitMask = 0xf000;*/
                            break;
                        }
                    case ETextureFormat.TEXFMT_BC1:
                        {
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '1');
                            break;
                        }
                    case ETextureFormat.TEXFMT_BC2:
                        {
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '3'); break;
                        }
                    case ETextureFormat.TEXFMT_BC3:
                        {
                            ddspf.dwFourCC = MAKEFOURCC('D', 'X', 'T', '5'); break;
                        }
                    case ETextureFormat.TEXFMT_BC4:
                        {
                            ddspf.dwFourCC = MAKEFOURCC('A', 'T', 'I', '1'); break;
                        }
                    case ETextureFormat.TEXFMT_BC5:
                        {
                            ddspf.dwFourCC = MAKEFOURCC('A', 'T', 'I', '2'); break;
                        }
                    case ETextureFormat.TEXFMT_Float_R16G16B16A16:
                        {
                            ddspf.dwFourCC = 113; break;
                        }
                    case ETextureFormat.TEXFMT_Float_R32G32B32A32:
                        {
                            ddspf.dwFourCC = 116; break;
                        }
                    case ETextureFormat.TEXFMT_BC6H:
                    case ETextureFormat.TEXFMT_BC7:
                    default:
                        {
                            break;
                        }
                }
                if (metadata.DXT10)
                    ddspf.dwFourCC = MAKEFOURCC('D', 'X', '1', '0');

                // dwflags
                if (ddspf.dwABitMask != 0) // check this
                    ddspf.dwFlags |= DDPF_ALPHAPIXELS; 
                /*if (ddspf.dwABitMask != 0)
                    ddspf.dwFlags |= DDPF_ALPHA;*/ //old
                if (ddspf.dwFourCC != 0)
                    ddspf.dwFlags |= DDPF_FOURCC;
                if (ddspf.dwRGBBitCount != 0 && ddspf.dwRBitMask != 0 && ddspf.dwGBitMask != 0 && ddspf.dwBBitMask != 0)
                    ddspf.dwFlags |= DDPF_RGB;
                if (metadata.Normal)
                    ddspf.dwFlags |= DDPF_NORMAL; //custom nv flag

                header.ddspf = ddspf;
            }

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
            if (mipscount > 0 )
                header.dwFlags |= DDSD_MIPMAPCOUNT;

            // DXT10
            if (metadata.DXT10)
            {
                // dxgiFormat
                switch (format)
                {
                    case ETextureFormat.TEXFMT_R8G8B8A8: dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_Float_R16G16B16A16: dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT;
                        break;
                    case ETextureFormat.TEXFMT_Float_R32G32B32A32:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT;
                        break;
                    case ETextureFormat.TEXFMT_BC1:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_BC2:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_BC3:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_BC4:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_BC5:
                        dxt10header.dxgiFormat = DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM;
                        break;
                    case ETextureFormat.TEXFMT_BC6H:
                    case ETextureFormat.TEXFMT_BC7:
                    default:
                        break;
                }
                // resourceDimension
                //if (slicecount > 0)
                //    dxt10header.resourceDimension = D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D;
                //misc flag
                if (iscubemap)
                    dxt10header.miscFlag |= DDS_RESOURCE_MISC_TEXTURECUBE;
                if (mipscount > 0)
                    dxt10header.miscFlag |= D3D10_RESOURCE_MISC_GENERATE_MIPS;
                // array size
                if (iscubemap)
                    dxt10header.arraySize = metadata.Slicecount;
                // miscFlags2

            }

            return (header, dxt10header);
        }

        public static void GenerateAndWriteHeader(Stream stream, DDSMetadata metadata)
        {
            (var header, var dxt10header) = GenerateHeader(metadata);
            WriteHeader(stream, header, dxt10header);
        }

        public static void WriteHeader(Stream stream, DDS_HEADER header, DDS_HEADER_DXT10 dxt10header)
        {
            stream.Write(BitConverter.GetBytes(DDS_MAGIC), 0, 4);
            WriteStruct(header, stream);
            if (header.ddspf.dwFourCC == MAKEFOURCC('D', 'X', '1', '0'))
                WriteStruct(dxt10header, stream);
        }
        

        private static void WriteStruct<T>(T value, Stream stream) where T : struct
        {
            var temp = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(temp, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            stream.Write(temp, 0, temp.Length);

            handle.Free();
        }

    }
}
