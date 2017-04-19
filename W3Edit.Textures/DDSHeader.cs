using System;
using System.Collections.Generic;

namespace W3Edit.Textures
{
    /// <summary>
    /// DDSHeader class, creates proper DDS header with generate() function
    /// </summary>
    class DDSHeader
    {
        // Implemented from https://github.com/hhrhhr/Lua-utils-for-Witcher-3/blob/master/mod_dds_header.lua
        // DDS header[32]
        private byte _fourcc = 1, _size = 2, _flags = 3, _height = 4;
        private byte _width = 5, _pitch = 6, _depth = 7, _mipmaps = 8;
        // reserved[44]
        //  9 10 11 12
        // 13 14 15 16
        // 17 18 19
        // DDSPixelFormat[32]
        private byte _psize = 20, _pflags = 21, _pfourcc = 22, _pbpp = 23;
        private byte _prmask = 24, _pgmask = 25, _pbmask = 26, _pamask = 27;
        // DDSCaps[16]
        private byte _caps1 = 28, _caps2 = 29, _caps3 = 30, _caps4 = 31;
        //
        private byte _notused = 32;
        // DDSHeader10[20]
        private byte _dxgiFmt = 33, _resDim = 34, _miscFlag = 35, _arraySize = 36;
        private byte _reserved = 37;

        private Dictionary<byte, uint> self = new Dictionary<byte, uint>();

        static uint MAKEFOURCC(string fourcc)
        {
            //    local a, b, c, d = string.byte(fourcc, 1, 4)
            //    return a | (b << 8) | (c << 16) | (d << 24)
            //    return string.unpack("<I", fourcc);
            return (uint)(fourcc[0] | (fourcc[1] << 8) | (fourcc[2] << 16) | (fourcc[3] << 24));
        }

        static uint FOURCC_DDS = MAKEFOURCC("DDS ");
        static uint FOURCC_DXT1 = MAKEFOURCC("DXT1");
        static uint FOURCC_DXT2 = MAKEFOURCC("DXT2");
        static uint FOURCC_DXT3 = MAKEFOURCC("DXT3");
        static uint FOURCC_DXT4 = MAKEFOURCC("DXT4");
        static uint FOURCC_DXT5 = MAKEFOURCC("DXT5");
        static uint FOURCC_RXGB = MAKEFOURCC("RXGB");
        static uint FOURCC_ATI1 = MAKEFOURCC("ATI1");
        static uint FOURCC_ATI2 = MAKEFOURCC("ATI2");
        static uint FOURCC_A2XY = MAKEFOURCC("A2XY");
        static uint FOURCC_DX10 = MAKEFOURCC("DX10");


        static uint Format_RGB = 0;
        static uint Format_RGBA = Format_RGB;
        // DX9 formats.
        public const uint Format_DXT1 = 1;
        public const uint Format_DXT1a = 2; // DXT1 with binary alpha.
        public const uint Format_DXT3 = 3;
        public const uint Format_DXT5 = 4;
        public const uint Format_DXT5n = 5; // Compressed HILO: R= 1, G= y, B= 0, A= x
        // DX10 formats.
        public uint Format_BC1 = Format_DXT1;
        public uint Format_BC1a = Format_DXT1a;
        public uint Format_BC2 = Format_DXT3;
        public uint Format_BC3 = Format_DXT5;
        public uint Format_BC3n = Format_DXT5n;
        public uint Format_BC4 = 6; // ATI1
        public uint Format_BC5 = 7; // 3DC, ATI2

#pragma warning disable 0414
        static uint DDSD_CAPS = 0x00000001;
        static uint DDSD_HEIGHT = 0x00000002;
        static uint DDSD_WIDTH = 0x00000004;
        static uint DDSD_PITCH = 0x00000008;
        static uint DDSD_PIXELFORMAT = 0x00001000;
        static uint DDSD_MIPMAPCOUNT = 0x00020000;
        static uint DDSD_LINEARSIZE = 0x00080000;
        static uint DDSD_DEPTH = 0x00800000;

        static uint DDSCAPS_COMPLEX = 0x00000008;
        static uint DDSCAPS_TEXTURE = 0x00001000;
        static uint DDSCAPS_MIPMAP = 0x00400000;
        static uint DDSCAPS2_VOLUME = 0x00200000;
        static uint DDSCAPS2_CUBEMAP = 0x00000200;
        static uint DDSCAPS2_CUBEMAP_ALL_FACES = 0x0000FC00;

        static uint DDPF_ALPHAPIXELS = 0x00000001;
        static uint DDPF_ALPHA = 0x00000002;
        static uint DDPF_FOURCC = 0x00000004;
        static uint DDPF_RGB = 0x00000040;
        static uint DDPF_NORMAL = 0x80000000; // Custom nv flag

        // enum DXGI_FORMAT
        static uint DXGI_FORMAT_UNKNOWN = 0;
        // enum D3D10_RESOURCE_DIMENSION
        static uint D3D10_RESOURCE_DIMENSION_UNKNOWN = 0;
        static uint D3D10_RESOURCE_DIMENSION_BUFFER = 1;
        static uint D3D10_RESOURCE_DIMENSION_TEXTURE1D = 2;
        static uint D3D10_RESOURCE_DIMENSION_TEXTURE2D = 3;
        static uint D3D10_RESOURCE_DIMENSION_TEXTURE3D = 4;
#pragma warning restore 0414

        // init
        public DDSHeader()
        {
            self[_fourcc] = FOURCC_DDS;
            self[_size] = 124;
            self[_flags] = DDSD_CAPS | DDSD_PIXELFORMAT;
            self[_height] = 0;
            self[_width] = 0;
            self[_pitch] = 0;
            self[_depth] = 0;
            self[_mipmaps] = 0;
            // reserved
            for (byte i = 9; i <= 17; i++)
            {
                self[i] = 0;
            }
            self[18] = MAKEFOURCC("_LUA");
            self[19] = MAKEFOURCC("_DDS");
            // pixel format
            self[_psize] = 32;
            self[_pflags] = 0;
            self[_pfourcc] = 0;
            self[_pbpp] = 0;
            self[_prmask] = 0;
            self[_pgmask] = 0;
            self[_pbmask] = 0;
            self[_pamask] = 0;
            // caps
            self[_caps1] = DDSCAPS_TEXTURE;
            self[_caps2] = 0;
            self[_caps3] = 0;
            self[_caps4] = 0;
            self[_notused] = 0;
            // d3d10
            self[_dxgiFmt] = DXGI_FORMAT_UNKNOWN;
            self[_resDim] = D3D10_RESOURCE_DIMENSION_UNKNOWN;
            self[_miscFlag] = 0;
            self[_arraySize] = 0;
            self[_reserved] = 0;
        }

        private void set_width(uint num)
        {
            self[_flags] = self[_flags] | DDSD_WIDTH;
            self[_width] = num;
        }

        private void set_height(uint num)
        {
            self[_flags] = self[_flags] | DDSD_HEIGHT;
            self[_height] = num;
        }

        private void set_depth(uint num)
        {
            self[_flags] = self[_flags] | DDSD_DEPTH;
            self[_depth] = num;
        }

        private void set_mipmaps(uint num)
        {
            if (num == 0 || num == 1)
            {
                self[_flags] = self[_flags] & ~DDSD_MIPMAPCOUNT;
                if (self[_caps2] == 0)
                    self[_caps1] = DDSCAPS_TEXTURE;
                else
                    self[_caps1] = DDSCAPS_TEXTURE | DDSCAPS_COMPLEX;
            }
            else
            {
                self[_flags] = self[_flags] | DDSD_MIPMAPCOUNT;
                self[_mipmaps] = num;
                self[_caps1] = self[_caps1] | DDSCAPS_COMPLEX | DDSCAPS_MIPMAP;
            }
        }

        private void set_texture_2d()
        {
            self[_resDim] = D3D10_RESOURCE_DIMENSION_TEXTURE2D;
        }

        private void set_texture_3d()
        {
            self[_caps2] = DDSCAPS2_VOLUME;

            self[_resDim] = D3D10_RESOURCE_DIMENSION_TEXTURE3D;
        }

        private void set_texture_cube()
        {
            self[_caps1] = self[_caps1] | DDSCAPS_COMPLEX;
            self[_caps2] = DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_ALL_FACES;

            self[_resDim] = D3D10_RESOURCE_DIMENSION_TEXTURE2D;
            self[_arraySize] = 6;
        }

        private void set_linear(uint size)
        {
            self[_flags] = self[_flags] & ~DDSD_PITCH;
            self[_flags] = self[_flags] | DDSD_LINEARSIZE;
            self[_pitch] = size;
        }

        private void set_pitch(uint pitch)
        {
            self[_flags] = self[_flags] & ~DDSD_LINEARSIZE;
            self[_flags] = self[_flags] | DDSD_PITCH;
            self[_pitch] = pitch;
        }

        private void set_fourcc(uint fourcc)
        {
            self[_pflags] = DDPF_FOURCC;
            self[_pfourcc] = fourcc;

            if (self[_pfourcc] == FOURCC_ATI2)
                self[_pbpp] = FOURCC_A2XY;
            else
                self[_pbpp] = 0;

            self[_prmask] = 0;
            self[_pgmask] = 0;
            self[_pbmask] = 0;
            self[_pamask] = 0;
        }

        private void set_pixel_format(uint bpp, uint rmask, uint gmask, uint bmask, uint amask)
        {
            //assert((rmask & gmask) == 0);
            //assert((rmask & bmask) == 0);
            //assert((rmask & amask) == 0);
            //assert((gmask & bmask) == 0);
            //assert((gmask & amask) == 0);
            //assert((bmask & amask) == 0);

            self[_pflags] = DDPF_RGB;
            if (amask != 0)
                self[_pflags] = self[_pflags] | DDPF_ALPHAPIXELS;

            if (bpp == 0)
            {
                uint total = rmask | gmask | bmask | amask;
                while (total != 0)
                {
                    bpp = bpp + 1;
                    total = total >> 1;
                }
            }

            //assert(bpp > 0 and bpp <= 32);

            // align to 8
            if (bpp <= 8)
                bpp = 8;
            else if (bpp <= 16)
                bpp = 16;
            else if (bpp <= 24)
                bpp = 24;
            else
                bpp = 32;

            self[_pfourcc] = 0;
            self[_pbpp] = bpp;
            self[_prmask] = rmask;
            self[_pgmask] = gmask;
            self[_pbmask] = bmask;
            self[_pamask] = amask;
        }

        private void set_normal_flag(bool b)
        {
            if (b)
                self[_pflags] = self[_pflags] | DDPF_NORMAL;
            else
                self[_pflags] = self[_pflags] & ~DDPF_NORMAL;
        }

        private bool hasDX10Header()
        {
            return self[_pfourcc] == FOURCC_DX10; // This is according to AMD
            //return self[_pfourcc] == 0-- This is according to MS
        }


        //-----------------------------------------------------------------------------

        private uint computePitch(uint width, uint bpp)
        {
            uint pitch = (bpp + 7); // 8 * width
            return (pitch + 3); // 4 * 4
        }


        private uint[] BS = new uint[] { 8, 8, 16, 16, 16, 8, 16 };

        private uint blockSize(uint fmt)
        {
            return BS[fmt];
        }

        private uint computeImageSize(uint width, uint height, uint depth, uint bpp, uint fmt)
        {
            if (fmt == Format_RGBA)
                return computePitch(width, bpp) * depth * height;
            else
                return blockSize(fmt) * ((width + 3) / 4) * ((height + 3) / 4);
        }

        //-----------------------------------------------------------------------------
        /// <summary>
        /// Generates proper DDS header
        /// </summary>
        /// <returns>Header in List of bytes</returns>
        public List<byte> generate(uint width = 256, uint height = 256, uint mips = 1, uint fmt = Format_DXT1, uint bpp = 16, bool cubemap = false, uint depth = 0, bool normal = false)
        {
            set_width(width);
            set_height(height);
            set_mipmaps(mips);

            if (depth > 0)
            {
                set_depth(depth);
                set_texture_3d();
            }
            else
            {
                set_texture_2d();
            }

            if (cubemap)
                set_texture_cube();

            if (fmt == Format_RGBA)
            {
                set_pitch(computePitch(width, bpp));
                if (bpp == 8)
                    set_pixel_format(bpp, 0x0f00, 0x00f0, 0x000f, 0xf000);
                else if (bpp == 16)
                    // -TODO: check this
                    set_pixel_format(bpp, 0x03f000, 0x000fc0, 0x00003f, 0xfc0000);
                else if (bpp == 32)
                    set_pixel_format(bpp, 0x00ff0000, 0x0000ff00, 0x000000ff, 0xff000000);
            }
            else
            {
                set_linear(computeImageSize(width, height, depth, bpp, fmt));
                if (fmt == Format_DXT1 || fmt == Format_DXT1a)
                {
                    set_fourcc(FOURCC_DXT1);
                    if (normal) set_normal_flag(true);
                }
                else if (fmt == Format_DXT3)
                    set_fourcc(FOURCC_DXT3);
                else if (fmt == Format_DXT5)
                    set_fourcc(FOURCC_DXT5);
                else if (fmt == Format_DXT5n)
                {
                    set_fourcc(FOURCC_DXT5);
                    if (normal) set_normal_flag(true);
                }
                else if (fmt == Format_BC4)
                    set_fourcc(FOURCC_ATI1);
                else if (fmt == Format_DXT3)
                {
                    set_fourcc(FOURCC_ATI2);
                    if (normal) set_normal_flag(true);
                }
            }

            // -TODO: swapBytes()

            uint header_size = (128 / 4);
            if (hasDX10Header())
                header_size = ((128 + 20) / 4);

            List<byte> header = new List<byte>();
            for (byte i = 1; i < header_size; i++)
                header.AddRange(BitConverter.GetBytes(self[i]));

            return header;
        }
    }
}