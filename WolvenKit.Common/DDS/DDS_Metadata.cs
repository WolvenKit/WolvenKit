using static WolvenKit.Common.DDS.TexconvNative;

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
        public DXGI_FORMAT Format { get; }
        public TEX_DIMENSION Dimensions { get; }


        public uint Bpp { get; }
        public bool Dx10 { get; }

        #endregion Properties

        public bool IsCubeMap() => (MiscFlags & 0x4L) != 0;


        #region Constructors

        //public DDSMetadata(Image metadata,
        //    uint bpp,
        //    bool dx10)
        //{
        //    Width = (uint)metadata.Width;
        //    Height = (uint)metadata.Height;
        //    Depth = (uint)metadata.depth;
        //    Slicecount = (uint)metadata.arraySize;
        //    Mipscount = (uint)metadata.mipLevels;
        //    MiscFlags = (uint)metadata.miscFlags;
        //    MiscFlags2 = (uint)metadata.miscFlags2;
        //    Format = (DXGI_FORMAT)metadata.format;
        //    Dimensions = (TEX_DIMENSION)metadata.dimension;

        //    Bpp = bpp;
        //    Dx10 = dx10;
        //}

        public DDSMetadata(TexMetadata metadata,
            uint bpp,
            bool dx10)
        {
            Width = (uint)metadata.width;
            Height = (uint)metadata.height;
            Depth = (uint)metadata.depth;
            Slicecount = (uint)metadata.arraySize;
            Mipscount = (uint)metadata.mipLevels;
            MiscFlags = (uint)metadata.miscFlags;
            MiscFlags2 = (uint)metadata.miscFlags2;
            Format = metadata.format;
            Dimensions = metadata.dimension;

            Bpp = bpp;
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
            DXGI_FORMAT format,
            TEX_DIMENSION dimensions,
            uint bpp,
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
            Slicecount = slicecount;
            Dx10 = dx10;
        }

        #endregion Constructors


    }
}
