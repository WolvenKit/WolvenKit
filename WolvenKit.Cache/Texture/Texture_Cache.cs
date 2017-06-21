using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using W3Edit.Textures;
using WolvenKit.CR2W;
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
            using (var output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
                output.Close();
            }
        }
    }

    public class TextureCache : IWitcherArchiveType
    {
        //The images packed into this Texture cache file
        public List<TextureCacheItem> Files;

        public string TypeName { get { return "TextureCache"; } }
        public string FileName { get; set; }
        public List<uint> Chunkoffsets;
        public uint TextureCount;
        public uint NamesBlockOffset;
        public uint ChunkOffsetsOffset;
        public uint Magic;
        public uint Version;
        public List<string> Names;

        public TextureCache(string filename)
        {
            this.Read(filename);
        }

        public void Read(string filepath)
        {
            FileName = filepath;
            Chunkoffsets = new List<uint>();
            using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
            {
                Files = new List<TextureCacheItem>();
                br.BaseStream.Seek(-20, SeekOrigin.End);
                TextureCount = br.ReadUInt32();
                NamesBlockOffset = br.ReadUInt32();
                ChunkOffsetsOffset = br.ReadUInt32();
                Magic = br.ReadUInt32();
                Version = br.ReadUInt32();
                var jmp = -(20 + 12 + (TextureCount * 52) + NamesBlockOffset + (ChunkOffsetsOffset * 4));
                br.BaseStream.Seek(jmp, SeekOrigin.End);
                for (var i = 0; i < ChunkOffsetsOffset; i++)
                {
                    Chunkoffsets.Add(br.ReadUInt32());
                }
                Names = new List<string>();
                for (var i = 0; i < TextureCount; i++)
                {
                    Names.Add(br.ReadCR2WString());
                }
                for (var i = 0; i < TextureCount; i++)
                {
                    var ti = new TextureCacheItem(this);
                    ti.Name = ti.Bundle.TypeName + "\\" + Names[i];
                    ti.ParentFile = FileName;
                    ti.Id = br.ReadUInt32();                //number (unique???)
                    ti.Filenameoffset = br.ReadUInt32();    //filename, start offset in block2
                    ti.Offset = br.ReadUInt32();       //* 4096 = start offset, first chunk
                    ti.PackedSize = br.ReadUInt32();       //packed size (all chunks)
                    ti.UnpackedSize = br.ReadUInt32();     //unpacked size
                    ti.Bpp = br.ReadUInt32();               //bpp? always 16
                    ti.Width = br.ReadUInt16();             //width
                    ti.Height = br.ReadUInt16();            //height
                    ti.Mips = br.ReadUInt16();              //mips
                    ti.Typeinfo = br.ReadUInt16();          //1/6/N, single, cubemaps, arrays
                    ti.B1Offset = br.ReadUInt32();          //offset in block1, second packed chunk
                    ti.Rpc = br.ReadUInt32();               //the number of remaining packed chunks
                    ti.Unk1 = br.ReadUInt32();              //???
                    ti.Unk2 = br.ReadUInt32();              //???
                    ti.Dxt = br.ReadByte();                 //0-RGBA?, 7-DXT1, 8-DXT5, 10-???, 13-DXT3, 14-ATI1, 15-???, 253-???
                    ti.Type = br.ReadByte();                //3-cubemaps, 4-texture
                    ti.Unk3 = br.ReadUInt16();              //0/1 ???
                    Files.Add(ti);
                }
                for (var i = 0; i < 3; i++)
                {
                    br.ReadBytes(4);
                }
                foreach (var t in Files)
                {
                    br.BaseStream.Seek(t.Offset * 4096, SeekOrigin.Begin);
                    t.ZSize = br.ReadUInt32();
                    t.Size = br.ReadInt32(); //Uncompressed size
                    t.Part = br.ReadByte();
                }
            }
        }

        public static void Write(BinaryWriter bw)
        {
            //TODO: Finish this!
        }
    }
}
