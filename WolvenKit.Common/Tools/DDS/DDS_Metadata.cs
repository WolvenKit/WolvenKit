using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using static WolvenKit.DDS.TexconvWrapper;

/// <summary>
/// DDS aka DirectDraw Surface is an obsolete image file format, property Microsoft
/// </summary>
namespace WolvenKit.DDS
{
    public struct DDSMetadata
    {
        public uint Width { get; }
        public uint Height { get;}
        public uint Mipscount { get;}
        public EFormat Format { get;}
        //public uint Bpp { get;}
        public bool Iscubemap { get; }
        public uint Slicecount { get; }
        public bool Normal { get;}

        public DDSMetadata(uint width, uint height, uint mipscount = 0,
            EFormat format = EFormat.R8G8B8A8_UNORM, uint bpp = 16,
            bool iscubemap = false, uint slicecount = 0, bool normal = false)
        {
            Width = width;
            Height = height;
            Mipscount = mipscount;
            Format = format;
            //Bpp = bpp;
            Iscubemap = iscubemap;
            Slicecount = slicecount;
            Normal = normal;
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
            Format = EFormat.R8G8B8A8_UNORM; //TODO unused
            //Bpp = bpp;
            Iscubemap = iscubemap;
            Slicecount = 0; //TODO
            Normal = false; //TODO
        }
    }
}
