using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
//using W3Edit.Textures;
using WolvenKit.Common;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    using DDS;

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
        public Byte IsCube;
        public Byte unk1;

        public long Size { get; set; }
        public UInt32 ZSize { get; set; }
        public Byte Part;

        public List<Tuple<uint, uint>> MipMapInfo = new List<Tuple<uint, uint>>();

        public Dictionary<Int16,ETextureFormat> formats = new Dictionary<Int16,ETextureFormat>()
        {
            //Resource Format     dwFlags     dwRGBBitCount   dwRBitMask  dwGBitMask  dwBBitMask  dwABitMask
            {0x0,ETextureFormat.TEXFMT_R8G8B8A8}, 
            {0x3FD,ETextureFormat.TEXFMT_R8G8B8A8}, //DDS_RGBA    32  0xff0000 	0xff00 	0xff 	0xff000000
            {0x407,ETextureFormat.TEXFMT_BC1},  //DDS_FOURCC 	"DXT1"
            {0x408,ETextureFormat.TEXFMT_BC3},  //DDS_FOURCC  "DXT5"
            {0x409, ETextureFormat.TEXFMT_BC6H},    
            {0x40A, ETextureFormat.TEXFMT_BC7}, 
            {0x40B,ETextureFormat.TEXFMT_Float_R16G16B16A16},   //DDS_FOURCC 	113
            {0x40C,ETextureFormat.TEXFMT_Float_R32G32B32A32},   //DDS_FOURCC 	116
            {0x40D, ETextureFormat.TEXFMT_BC2}, //DDS_FOURCC  "DXT3"
            {0x40E, ETextureFormat.TEXFMT_BC4}, //DDS_FOURCC  "BC4U"
            {0x40F, ETextureFormat.TEXFMT_BC5}  //DDS_FOURCC  "ATI2"
        };

        public TextureCacheItem(IWitcherArchiveType parent)
        {
            Bundle = parent;
        }

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream((PageOFfset * 4096) + 9, ZSize, MemoryMappedFileAccess.Read))
                {
                    ETextureFormat format = formats[Type];

                    bool iscubemap = IsCube == 1;

                    var (header, dxt10header) = DDSUtils.GenerateHeader(
                        BaseWidth,
                        BaseHeight,
                        (uint)Mipcount,
                        format,
                        BaseAlignment,
                        iscubemap,
                        SliceCount
                        );


                    DDSUtils.WriteHeader(output, header, dxt10header);
                    //if ( format != ETextureFormat.TEXFMT_R8G8B8A8)
                    new ZlibStream(viewstream, CompressionMode.Decompress).CopyTo(output);

                }

                for (int i = 0; i < NumMipOffsets; i++)
                {
                    
                    var mippageoffset = MipMapInfo[i].Item1;
                    var mipzsize = MipMapInfo[i].Item2;

                    //extract mipmaps
                    using (var viewstream = file.CreateViewStream((mippageoffset), mipzsize, MemoryMappedFileAccess.Read))
                    {
                        new ZlibStream(viewstream, CompressionMode.Decompress).CopyTo(output);
                    }
                }
            }
        }

        public void Extract(string fullpath)
        {
            fullpath = Path.ChangeExtension(fullpath, "dds");

            Directory.CreateDirectory(Path.GetDirectoryName(fullpath) ?? "");
            if (File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }

            using (var output = new FileStream(fullpath, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
            }
        }
    }
}
