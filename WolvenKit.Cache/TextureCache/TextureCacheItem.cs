using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using W3Edit.Textures;
using WolvenKit.CR2W.Types;
using WolvenKit.Interfaces;

namespace WolvenKit.Cache
{
    public class TextureCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        public string DateString { get; set; }

        public string CompressionType => "Zlib";

        public string ParentFile;

        public string Name { get; set; }
        public Int32 Hash;
        public Int32 PathStringIndex;
        public long PageOFfset { get; set; }
        public Int32 CompressedSize;
        public Int32 UncompressedSize;
        public UInt32 BaseAlignment;
        public UInt16 BaseWidth;
        public UInt16 BaseHeight;
        public UInt16 Mipcount;
        public UInt16 SliceCount;
        public Int32 MipOffsetIndex;
        public Int32 NumMipOffsets;
        public Int64 TimeStamp;
        public Int16 Type;
        public Int16 IsCube;

        public long Size { get; set; }
        public UInt32 ZSize { get; set; }
        public Byte Part;

        public enum ETextureFormat
        {
            TEXFMT_A8 = 0x0,
            TEXFMT_A8_Scaleform = 0x1,
            TEXFMT_L8 = 0x2,
            TEXFMT_R8G8B8X8 = 0x3,
            TEXFMT_R8G8B8A8 = 0x4,
            TEXFMT_A8L8 = 0x5,
            TEXFMT_Uint_16_norm = 0x6,
            TEXFMT_Uint_16 = 0x7,
            TEXFMT_Uint_32 = 0x8,
            TEXFMT_R32G32_Uint = 0x9,
            TEXFMT_R16G16_Uint = 0xA,
            TEXFMT_Float_R10G10B10A2 = 0xB,
            TEXFMT_Float_R16G16B16A16 = 0xC,
            TEXFMT_Float_R11G11B10 = 0xD,
            TEXFMT_Float_R16G16 = 0xE,
            TEXFMT_Float_R32G32 = 0xF,
            TEXFMT_Float_R32G32B32A32 = 0x10,
            TEXFMT_Float_R32 = 0x11,
            TEXFMT_Float_R16 = 0x12,
            TEXFMT_D24S8 = 0x13,
            TEXFMT_D24FS8 = 0x14,
            TEXFMT_D32F = 0x15,
            TEXFMT_D16U = 0x16,
            TEXFMT_BC1 = 0x17,
            TEXFMT_BC2 = 0x18,
            TEXFMT_BC3 = 0x19,
            TEXFMT_BC4 = 0x1A,
            TEXFMT_BC5 = 0x1B,
            TEXFMT_BC6H = 0x1C,
            TEXFMT_BC7 = 0x1D,
            TEXFMT_R8_Uint = 0x1E,
            TEXFMT_NULL = 0x1F,
            TEXFMT_Max = 0x20,
        };

        public Dictionary<Int16,ETextureFormat> formats = new Dictionary<Int16,ETextureFormat>()
        {
            {0x3FD,ETextureFormat.TEXFMT_R8G8B8A8},
            {0x407,ETextureFormat.TEXFMT_BC1},
            {0x408,ETextureFormat.TEXFMT_BC3},
            {0x409, ETextureFormat.TEXFMT_BC6H},
            {0x40A, ETextureFormat.TEXFMT_BC7},
            {0x40B,ETextureFormat.TEXFMT_Float_R16G16B16A16},
            {0x40C,ETextureFormat.TEXFMT_Float_R32G32B32A32},
            {0x40D, ETextureFormat.TEXFMT_BC2},
            {0x40E, ETextureFormat.TEXFMT_BC4},
            {0x40F, ETextureFormat.TEXFMT_BC5}
        };

        public TextureCacheItem(IWitcherArchiveType parent)
        {
            Bundle = parent;
        }

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream((PageOFfset * 4096)+9, ZSize, MemoryMappedFileAccess.Read))
                {
                    //TODO: Finish this once we have a proper dds reader/writer
                    byte Dxt = BitConverter.GetBytes(Type)[0];
                    uint fmt = 0;
                    if (Dxt == 7) fmt = 1;
                    else if (Dxt == 8) fmt = 4;
                    else if (Dxt == 10) fmt = 4;
                    else if (Dxt == 13) fmt = 3;
                    else if (Dxt == 14) fmt = 6;
                    else if (Dxt == 15) fmt = 4;
                    else if (Dxt == 253) fmt = 0;
                    else if (Dxt == 0) fmt = 0;
                    else throw new Exception("Invalid image!");
                    var cubemap = (Type == 3 || Type == 0) && (SliceCount == 6);
                    uint depth = 0;
                    if (SliceCount > 1 && Type == 4) depth = SliceCount;
                    if (Type == 3 && Dxt == 253) BaseAlignment = 32;   
                    var header = new DDSHeader().generate(
                            BaseWidth,
                            BaseHeight,
                            Mipcount,
                            fmt,
                            BaseAlignment,
                            IsCube == 1,
                            depth)
                        .Concat(BitConverter.GetBytes((Int32)0)).ToArray();
                    output.Write(header,0,header.Length);
                    if (!(SliceCount == 6 && (Type == 253 || Type == 0)))
                        new ZlibStream(viewstream, CompressionMode.Decompress).CopyTo(output);
                }
            }
        }

        public void Extract(string filename)
        {
            using (var output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
            }
        }
    }
}
