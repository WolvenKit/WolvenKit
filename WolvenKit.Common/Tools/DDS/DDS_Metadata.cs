using DirectXTexSharp;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.Common.DDS
{
    /// <summary>
    /// A wrapper around DirectX::TexMetadata with some extra properties
    /// </summary>
    public readonly struct DDSMetadata
    {
        //DirectX::TexMetadata
        //size_t width;
        //size_t height;     // Should be 1 for 1D textures
        //size_t depth;      // Should be 1 for 1D or 2D textures
        //size_t arraySize;  // For cubemap, this is a multiple of 6
        //size_t mipLevels;
        //uint32_t miscFlags;
        //uint32_t miscFlags2;
        //DXGI_FORMAT format;
        //TEX_DIMENSION dimension;

        #region Properties

        public uint Width { get; }
        public uint Height { get; }
        public uint Depth { get; }
        public uint Slicecount { get; }
        public uint Mipscount { get; }
        public uint MiscFlags { get; }
        public uint MiscFlags2 { get; }
        public EFormat Format { get; }
        public TEX_DIMENSION Dimensions { get; }


        public uint Bpp { get; }
        //public bool Iscubemap { get; }
        public bool Dx10 { get; }

        #endregion Properties

        public bool IsCubeMap() => (MiscFlags & 0x4L) != 0;


        #region Constructors

        public DDSMetadata(TexMetadata metadata,
            uint bpp,
            //bool iscubemap,
            bool dx10)
        {
            Width = (uint)metadata.width;
            Height = (uint)metadata.height;
            Depth = (uint)metadata.depth;
            Slicecount = (uint)metadata.arraySize;
            Mipscount = (uint)metadata.mipLevels;
            MiscFlags = metadata.miscFlags;
            MiscFlags2 = metadata.miscFlags2;
            Format = (EFormat)metadata.format;
            Dimensions = (TEX_DIMENSION)metadata.dimension;

            Bpp = bpp;
            //Iscubemap = iscubemap;
            Dx10 = dx10;
        }

        public DDSMetadata(
            uint width,
            uint height,
            uint depth,
            uint slicecount,
            uint mipscount,
            uint miscFlags,
            uint miscFlags2,
            EFormat format,
            TEX_DIMENSION dimensions,
            uint bpp,
            //bool iscubemap = false,
            bool dx10 = false)
        {
            Width = width;
            Height = height;
            Mipscount = mipscount;
            Format = format;
            Bpp = bpp;
            Depth = depth;
            MiscFlags = miscFlags;
            MiscFlags2 = miscFlags2;
            Dimensions = dimensions;
            //Iscubemap = iscubemap;
            Slicecount = slicecount;
            Dx10 = dx10;
        }

        // public DDSMetadata(DDS_HEADER ddsheader)
        // {
        //     const uint mask = DDSUtils.DDSCAPS2_CUBEMAP_ALL_FACES & DDSUtils.DDSCAPS2_CUBEMAP;
        //     if ((ddsheader.dwCaps2 & mask) != 0)
        //     {
        //     }
        //
        //     var iscubemap = (ddsheader.dwCaps2 & mask) != 0;
        //
        //     Width = ddsheader.dwWidth;
        //     Height = ddsheader.dwHeight;
        //     Mipscount = ddsheader.dwMipMapCount;
        //
        //
        //
        //     switch (ddsheader.ddspf.dwFourCC)
        //     {
        //         case 0x31545844:    //DXT1
        //             Format = EFormat.BC1_UNORM;
        //             break;
        //
        //         case 0x33545844:    //DXT3
        //             Format = EFormat.BC2_UNORM;
        //             break;
        //
        //         case 0x35545844:    //DXT5
        //             Format = EFormat.BC3_UNORM;
        //             break;
        //
        //         case 0x55344342:    //BC4U
        //             Format = EFormat.BC4_UNORM;
        //             break;
        //
        //         case 0x55354342:    //BC5U
        //             Format = EFormat.BC5_UNORM;
        //             break;
        //         //case
        //         //    Format = EFormat.R8G8B8A8_UNORM:
        //         //    SetPixelmask(DDSPF_A8R8G8B8, ref ddspf); break;
        //         //case
        //         //    Format = EFormat.BC7_UNORM ;          //TODO: dxt10 is currently unsupported
        //         //    dxt10 = true; break;
        //         default:
        //             Format = EFormat.R8G8B8A8_UNORM;
        //             break;
        //     }
        //
        //     Bpp = 16;                                       //TODO: in vanilla this is always 16 ???
        //     Iscubemap = iscubemap;
        //     Slicecount = iscubemap ? (uint)6 : (uint)0;     //TODO: does not account for texarrays
        //     Dx10 = false;
        // }

        #endregion Constructors

        
    }
}
