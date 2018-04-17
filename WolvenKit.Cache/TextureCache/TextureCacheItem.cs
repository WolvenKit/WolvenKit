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
        public Int16 Mipcount;
        public UInt16 SliceCount;
        public Int32 MipOffsetIndex;
        public Int32 NumMipOffsets;
        public Int64 TimeStamp;
        public byte Type;
        public byte TypeB;
        public Int16 ActaulType;
        public Int16 IsCube;

        public long Size { get; set; }
        public UInt32 ZSize { get; set; }
        public Byte Part;

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
                    uint fmt = 0;
                    if (Type == 7) fmt = 1;
                    else if (Type == 8 || Type == 15 || Type == 10) fmt = 4;
                    else if (Type == 13) fmt = 3;
                    else if (Type == 14) fmt = 6;
                    else if (Type == 253 || Type == 0) fmt = 0;
                    else throw new Exception("Invalid image!");
                    var cubemap = (Type == 3 || Type == 0) && (SliceCount == 6);
                    uint depth = 0;
                    if (SliceCount > 1 && Type == 4) depth = SliceCount;
                    if (Type == 3 && Type == 253) BaseAlignment = 32;       
                    var header = new DDSHeader().generate(
                            BaseWidth,
                            BaseHeight,
                            1,
                            fmt,
                            BaseAlignment,
                            cubemap,
                            depth)
                        .Concat(BitConverter.GetBytes((Int32)0)).ToArray();
                    output.Write(header,0,header.Length);
                    if (!(SliceCount == 6 && (Type == 253 || Type == 0)))
                    {
                        var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);
                        zlib.CopyTo(output);
                    }
                }
            }
        }

        public void Extract(string filename)
        {
            filename = Path.ChangeExtension(filename, ".dds");
            using (var output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
            }
        }
    }
}
