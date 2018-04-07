using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using W3Edit.Textures;
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
        public uint Id;
        public uint Filenameoffset;
        public long Offset { get; set; }
        public uint PackedSize;
        public uint UnpackedSize;
        public uint Bpp;
        public uint Width;
        public uint Height;
        public uint Mips;
        public uint Typeinfo;
        public uint B1Offset;
        public uint Rpc;
        public uint Unk1;
        public uint Unk2;
        public uint Type;
        public uint Dxt;
        public uint Unk3;

        public long Size { get; set; }
        public uint ZSize { get; set; }
        public uint Part;

        public TextureCacheItem(IWitcherArchiveType parent)
        {
            Bundle = parent;
        }

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream((Offset * 4096)+9, ZSize, MemoryMappedFileAccess.Read))
                {
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
                    var cubemap = (Type == 3 || Type == 0) && (Typeinfo == 6);
                    uint depth = 0;
                    if (Typeinfo > 1 && Type == 4) depth = Typeinfo;
                    if (Type == 3 && Dxt == 253) Bpp = 32;                  
                    var header = new DDSHeader().generate(Width, Height, 1, fmt, Bpp, cubemap, depth)
                            .Concat(new[] { (byte)0x00, (byte)0x00, (byte)0x00, (byte)0x00 }).ToArray();
                    output.Write(header,0,header.Length);
                    if (!(Typeinfo == 6 && (Dxt == 253 || Dxt == 0)))
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
