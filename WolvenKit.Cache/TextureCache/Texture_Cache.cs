using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    public class TextureCache : IWitcherArchiveType
    {
        //The images packed into this Texture cache file
        public List<TextureCacheItem> Files;

        public EBundleType TypeName => EBundleType.TextureCache;
        public string FileName { get; set; }
        public List<uint> Chunkoffsets;
        public UInt64 Crc;
        public UInt32 UsedPages;
        public UInt32 EntryCount;
        public UInt32 StringTableSize;
        public UInt32 MipOffsetTableSize;
        public UInt32 IDString;
        public UInt32 Version;
        public List<string> Names;

        public TextureCache()
        {

            Chunkoffsets = new List<uint>();
            Names = new List<string>();
            Files = new List<TextureCacheItem>();
        }

        public TextureCache(string filename)
        {
            this.Read(filename);
        }

        public void Read(string filepath)
        {
            try
            {
                FileName = filepath;
                Chunkoffsets = new List<uint>();
                using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
                {
                    Files = new List<TextureCacheItem>();
                    br.BaseStream.Seek(-32, SeekOrigin.End);
                    Crc = br.ReadUInt64();
                    UsedPages = br.ReadUInt32();
                    EntryCount = br.ReadUInt32();
                    StringTableSize = br.ReadUInt32();
                    MipOffsetTableSize = br.ReadUInt32();
                    IDString = br.ReadUInt32();
                    Version = br.ReadUInt32();
                    //JMP to the top of the info table:
                    //32 is the the size of the stuff we read so far.
                    //Every entry has 52 bytes of info
                    //The stringtable
                    //Every offset is 4 bytes
                    //The sum of this is how much we need to jump from the back
                    var jmp = -(32 + (EntryCount * 52) + StringTableSize + (MipOffsetTableSize * 4));
                    br.BaseStream.Seek(jmp, SeekOrigin.End);
                    for (var i = 0; i < MipOffsetTableSize; i++)
                    {
                        Chunkoffsets.Add(br.ReadUInt32());
                    }
                    Names = new List<string>();
                    for (var i = 0; i < EntryCount; i++)
                    {
                        Names.Add(br.ReadCR2WString());
                    }
                    for (var i = 0; i < EntryCount; i++)
                    {
                        var ti = new TextureCacheItem(this)
                        {
                            Name = Names[i],
                            ParentFile = FileName,
                            Hash = br.ReadUInt32(),
                            /*-------------TextureCacheEntryBase---------------*/
                            PathStringIndex = br.ReadInt32(),
                            PageOFfset = br.ReadInt32(),
                            CompressedSize = br.ReadInt32(),
                            UncompressedSize = br.ReadInt32(),
                            BaseAlignment = br.ReadUInt32(),
                            BaseWidth = br.ReadUInt16(),
                            BaseHeight = br.ReadUInt16(),
                            Mipcount = br.ReadUInt16(),
                            SliceCount = br.ReadUInt16(),
                            MipOffsetIndex = br.ReadInt32(),
                            NumMipOffsets = br.ReadInt32(),
                            TimeStamp = br.ReadInt64(),
                            /*-------------TextureCacheEntryBase---------------*/
                            Type1 = br.ReadByte(),
                            Type2 = br.ReadByte(),
                            IsCube = br.ReadByte(),
                            Unk1 = br.ReadByte()
                        };
                        Files.Add(ti);
                    }
                    //BUG: "C:\\Users\\bence.hambalko\\Documents\\The Witcher 3\\bin\\x64\\..\\..\\Mods\\modW3EE\\content\\texture.cache" dies here! Investigate!!!!!!!!!!!!!
                    foreach (var t in Files)
                    {
                        br.BaseStream.Seek(t.PageOFfset * 4096, SeekOrigin.Begin);
                        t.ZSize = br.ReadUInt32(); //Compressed size
                        t.Size = br.ReadInt32(); //Uncompressed size
                        t.SliceIdx = br.ReadByte(); //maybe the 48bit part of OFFSET

                        var lastpos = br.BaseStream.Position + t.ZSize;


                        for (int i = 0; i < t.NumMipOffsets; i++)
                        {
                            br.BaseStream.Seek(lastpos, SeekOrigin.Begin);

                            var mzsize = br.ReadUInt32();
                            t.MipMapInfo.Add(new Tuple<uint, uint>(
                                (uint)lastpos + 9, // mipmap offset
                                mzsize));  //zsize

                            lastpos += 9 + mzsize;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Assert(e != null);
            }
        }

        public static void Write(BinaryWriter bw)
        {
            //TODO: Finish this!
        }
    }
}
