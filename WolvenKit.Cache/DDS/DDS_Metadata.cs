using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Cache.DDS
{
    public struct DDSMetadata
    {
        public uint Width { get; }
        public uint Height { get;}
        public uint Mipscount { get;}
        public ETextureFormat Format { get;}
        public uint Bpp { get;}
        public bool Iscubemap { get; }
        public uint Slicecount { get; }
        public bool Normal { get;}
        public bool DXT10 { get;}

        public DDSMetadata(uint width, uint height, uint mipscount = 0,
            ETextureFormat format = ETextureFormat.TEXFMT_R8G8B8A8, uint bpp = 16,
            bool iscubemap = false, uint slicecount = 0, bool normal = false, bool dxt10 = false)
        {
            Width = width;
            Height = height;
            Mipscount = mipscount;
            Format = format;
            Bpp = bpp;
            Iscubemap = iscubemap;
            Slicecount = slicecount;
            Normal = normal;
            DXT10 = dxt10;
        }

    }
}
