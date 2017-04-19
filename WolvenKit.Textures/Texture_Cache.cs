using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.Textures;
using WolvenKit.CR2W;

namespace WolvenKit.Cache
{
    public class textureinfo
    {
        public string filename;
        public uint id;
        public uint filenameoffset;
        public uint startoffset;
        public uint packed_size;
        public uint unpacked_size;
        public uint bpp;
        public uint width;
        public uint height;
        public uint mips;
        public uint typeinfo;
        public uint b1offset;
        public uint rpc;
        public uint unk1;
        public uint unk2;
        public uint type;
        public uint dxt;
        public uint unk3;
    }

    public class Texture_Cache
    {
        public Dictionary<textureinfo, byte[]> Images;

        public void Read(string filepath)
        {
            using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
            {
                Images = new Dictionary<textureinfo, byte[]>();
                br.BaseStream.Seek(-20, SeekOrigin.End);
                var texturenum = br.ReadUInt32();
                var namesBlock = br.ReadUInt32(); //block2
                var chunksBlock = br.ReadUInt32(); //block1
                var idString = br.ReadUInt32();
                var version = br.ReadUInt32();
                var jmp = -(20 + 12 + (texturenum * 52) + namesBlock + (chunksBlock * 4));
                br.BaseStream.Seek(jmp, SeekOrigin.End);
                var chunkoffsets = new List<uint>();
                for (var i = 0; i < chunksBlock; i++)
                {
                    chunkoffsets.Add(br.ReadUInt32());
                }
                var names = new List<string>();
                for (var i = 0; i < texturenum; i++)
                {
                    names.Add(br.ReadCR2WString());
                }
                for (var i = 0; i < texturenum; i++)
                {
                    var ti = new textureinfo();
                    ti.filename = names[i];
                    ti.id = br.ReadUInt32();                //number (unique???)
                    ti.filenameoffset = br.ReadUInt32();    //filename, start offset in block2
                    ti.startoffset = br.ReadUInt32();       //* 4096 = start offset, first chunk
                    ti.packed_size = br.ReadUInt32();       //packed size (all chunks)
                    ti.unpacked_size = br.ReadUInt32();     //unpacked size
                    ti.bpp = br.ReadUInt32();               //bpp? always 16
                    ti.width = br.ReadUInt16();             //width
                    ti.height = br.ReadUInt16();            //height
                    ti.mips = br.ReadUInt16();              //mips
                    ti.typeinfo = br.ReadUInt16();          //1/6/N, single, cubemaps, arrays
                    ti.b1offset = br.ReadUInt32();          //offset in block1, second packed chunk
                    ti.rpc = br.ReadUInt32();               //the number of remaining packed chunks
                    ti.unk1 = br.ReadUInt32();              //???
                    ti.unk2 = br.ReadUInt32();              //???
                    ti.dxt = br.ReadByte();                 //0-RGBA?, 7-DXT1, 8-DXT5, 10-???, 13-DXT3, 14-ATI1, 15-???, 253-???
                    ti.type = br.ReadByte();                //3-cubemaps, 4-texture
                    ti.unk3 = br.ReadUInt16();              //0/1 ???
                    Images.Add(ti, null);
                }
                for (var i = 0; i < 3; i++)
                {
                    br.ReadBytes(4);
                }
                foreach (var img in Images.Keys.ToList())
                {
                    uint fmt = 0;
                    switch (img.dxt)
                    {
                        case 7:
                            fmt = 1;
                            break;
                        case 8:
                            fmt = 4;
                            break;
                        case 10:
                            fmt = 4;
                            break;
                        case 13:
                            fmt = 3;
                            break;
                        case 14:
                            fmt = 6;
                            break;
                        case 15:
                            fmt = 4;
                            break;
                        case 253:
                            fmt = 0;
                            break;
                        case 0:
                            fmt = 0;
                            break;
                        default:
                            throw new Exception("Invalid image!");
                    }
                    if (img.typeinfo == 6 && (img.dxt == 253 || img.dxt == 0))
                        continue;
                    var cubemap = (img.type == 3 || img.type == 0) && (img.typeinfo == 6);
                    uint depth = 0;
                    if (img.typeinfo > 1 && img.type == 4)
                        depth = img.typeinfo;
                    if (img.type == 3 && img.dxt == 253)
                        img.bpp = 32;
                    br.BaseStream.Seek(img.startoffset * 4096, SeekOrigin.Begin);
                    var zsize = br.ReadInt32();
                    var size = br.ReadInt32();
                    var part = br.ReadByte();
                    var comp = br.ReadBytes(zsize);
                    var header = new DDSHeader();
                    Images[img] =
                        header.generate(img.width, img.height, 1, fmt, img.bpp, cubemap, depth).Concat(new[] { (byte)0x00, (byte)0x00, (byte)0x00, (byte)0x00 })
                            .Concat(ZlibStream.UncompressBuffer(comp))
                            .ToArray();
                }
            }
        }

        public string GetFileName(string s)
        {
            return !s.Contains('\\') ? s : s.Split('\\').Last();
        }

        public static void Write(BinaryWriter bw)
        {
            //TODO: Finish this!
        }
    }
}
