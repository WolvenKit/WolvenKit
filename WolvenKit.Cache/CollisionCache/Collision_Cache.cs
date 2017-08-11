using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W;
using WolvenKit.Interfaces;

namespace WolvenKit.Cache.CollisionCache
{
    public class CollisionCache : IWitcherArchiveType
    {
        public byte[] IdString = { (byte)'C', (byte)'C', (byte)'3', (byte)'W' };
        public uint Version;
        public uint Unknown1;
        public uint Unknown2;
        public uint InfoOffset;
        public uint NumberOfFiles;
        public uint NameTableOffset;
        public uint NamesSize;
        public ulong Buffersize;
        public ulong CheckSum;

        public List<string> FileNames = new List<string>();
        public List<CollisionCacheItem> Files = new List<CollisionCacheItem>(); 

        public string TypeName => "CollisionCache";
        public string FileName { get; set; }

        public CollisionCache(string filename)
        {
            this.FileName = filename;
            using (var br = new BinaryReader(new FileStream(filename, FileMode.Open)))
                this.Read(br);
        }

        public void Read(BinaryReader br)
        {
            if (!br.ReadBytes(4).SequenceEqual(IdString))
                throw new Exception("Invalid file!");
            this.Version = br.ReadUInt32();
            this.Unknown1 = br.ReadUInt32();
            this.Unknown2 = br.ReadUInt32();
            this.InfoOffset = br.ReadUInt32();
            this.NumberOfFiles = br.ReadUInt32();
            this.NameTableOffset = br.ReadUInt32();
            this.NamesSize = br.ReadUInt32();
            this.Buffersize = br.ReadUInt64();
            this.CheckSum = br.ReadUInt64();
            FileNames = new List<string>();
            br.BaseStream.Seek(this.NameTableOffset, SeekOrigin.Begin);
            for (int i = 0; i < this.NumberOfFiles; i++)
            {
                this.FileNames.Add(br.ReadCR2WString());
            }
            foreach (var ci in FileNames.Select(fileName => new CollisionCacheItem
            {
                Name = fileName,
                Bundle = this,
                Unk1 = br.ReadUInt64(),
                NameOffset = br.ReadUInt64(),
                Offset = br.ReadUInt32(),
                ZSize = br.ReadUInt32(),
                Unk2 = br.ReadUInt64(),
                Unk3 = br.ReadUInt64(),
                Unk4 = br.ReadUInt64(),
                Unk5 = br.ReadUInt64(),
                Unk6 = br.ReadUInt64(),
                Comtype = br.ReadUInt64()
            }))
            {
                Debug.WriteLine("Filename: " + ci.Name);
                Files.Add(ci);
            }
        }
    }
}
