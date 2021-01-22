using static WolvenKit.Common.Tools.DDS.TexconvWrapper;

namespace WolvenKit.Common.Tools.DDS
{
    public readonly struct DDSMetadata
    {
        public uint Width { get; }
        public uint Height { get;}
        public uint Mipscount { get;}
        public EFormat Format { get;}
        public uint Bpp { get;}
        public bool Iscubemap { get; }
        public uint Slicecount { get; }
        public bool Dx10 { get; }

        public DDSMetadata(uint width, uint height,
            uint mipscount = 0,
            EFormat format = EFormat.R8G8B8A8_UNORM, uint bpp = 16,
            bool iscubemap = false, uint slicecount = 0, bool dx10 = false)
        {
            Width = width;
            Height = height;
            Mipscount = mipscount;
            Format = format;
            Bpp = bpp;
            Iscubemap = iscubemap;
            Slicecount = slicecount;
            Dx10 = dx10;
        }

        public DDSMetadata(DDS_HEADER ddsheader)
        {
            var mask = DDSUtils.DDSCAPS2_CUBEMAP_ALL_FACES & DDSUtils.DDSCAPS2_CUBEMAP;
            if ((ddsheader.dwCaps2 & mask) != 0)
            {

            }

            bool iscubemap = (ddsheader.dwCaps2 & mask) != 0;


            Width = ddsheader.dwWidth;
            Height = ddsheader.dwHeight;
            Mipscount = ddsheader.dwMipMapCount;

            switch (ddsheader.ddspf.dwFourCC)
            {
                case 0x31545844:    //DXT1
                    Format = EFormat.BC1_UNORM;
                    break;
                case 0x33545844:    //DXT3
                    Format = EFormat.BC2_UNORM;
                    break;
                case 0x35545844:    //DXT5
                    Format = EFormat.BC3_UNORM;
                    break;
                case 0x55344342:    //BC4U
                    Format = EFormat.BC4_UNORM;
                    break;
                case 0x55354342:    //BC5U
                    Format = EFormat.BC5_UNORM;
                    break;
                //case
                //    Format = EFormat.R8G8B8A8_UNORM:
                //    SetPixelmask(DDSPF_A8R8G8B8, ref ddspf); break;
                //case 
                //    Format = EFormat.BC7_UNORM ;          //TODO: dxt10 is currently unsupported
                //    dxt10 = true; break;      
                default:
                    Format = EFormat.R8G8B8A8_UNORM;
                    break;
            }
            
            
            Bpp = 16;                                       //TODO: in vanilla this is always 16 ???
            Iscubemap = iscubemap;
            Slicecount = iscubemap ? (uint)6 : (uint)0;     //TODO: does not account for texarrays
            Dx10 = false;
        }
    }
}
