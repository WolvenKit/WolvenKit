using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;

namespace WolvenKit.Cache
{

    public class CollisionCacheItemHeader
    {
        public uint Unk1 { get; set; }
        public uint Unk2 { get; set; }
        public uint Unk3 { get; set; }

        public List<CollisionCacheItemHeaderItem> Items { get; set; } = new List<CollisionCacheItemHeaderItem>();

        public void Read(BinaryReader br)
        {
            Unk1 = br.ReadUInt32();
            Unk2 = br.ReadUInt32();
            Unk3 = br.ReadUInt32();

            uint _count = br.ReadUInt32();
            for (int i = 0; i < _count; i++)
            {
                // read item
                var item = new CollisionCacheItemHeaderItem
                {
                    Name = W3ReaderExtensions.ReadLengthPrefixedString(br)
                };

                var _count2 = br.ReadVLQInt32();
                for (int j = 0; j < _count2; j++)
                {
                    item.Strings.Add(W3ReaderExtensions.ReadLengthPrefixedString(br));                        
                }

                item.Unk4 = br.ReadBytes(70).ToList();
                item.FileSize = br.ReadUInt32();
                item.Flag = br.ReadSByte();

                
                Items.Add(item);
            }
        }
        public void Write(BinaryWriter bw)
        {
            bw.Write(Unk1);
            bw.Write(Unk2);
            bw.Write(Unk3);

            int _count = Items.Count;
            bw.Write(_count);
            for (int i = 0; i < _count; i++)
            {
                var item = Items[i];

                bw.WriteLengthPrefixedString(item.Name);

                bw.WriteVLQInt32(item.Strings.Count);
                foreach (var s in item.Strings)
                {
                    bw.WriteLengthPrefixedString(s);
                }

                bw.Write(item.Unk4.ToArray());
                bw.Write(item.FileSize);
                bw.Write(item.Flag);
            }
        }
    }

    public class CollisionCacheItemHeaderItem
    {
        public string Name { get; set; }
        public List<string> Strings { get; set; } = new List<string>();
        public List<byte> Unk4 { get; set; } = new List<byte>();
        public uint FileSize { get; set; }
        public sbyte Flag { get; set; }
    }

    /// <summary>
    /// Files packed into Collision.cache. Zlib compressed nxb/p3d file.
    /// </summary>
    public class CollisionCacheItem : IGameFile
    {
        public IGameArchive Archive { get; set; }
        public string Name { get; set; }
        public uint Size { get; set; }
        public uint ZSize { get; set; }
        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        public long PageOffset { get; set; }
        public string CompressionType => "Zlib";
        public uint NameOffset;
        public uint Unk1; //?
        public ulong Unk2; //Null
        public uint Unk3; 
        public byte[] unk4;
        public byte[] unk5;
        public ulong Comtype; // 1 = w2ter, 2 = mesh, 3 = redcloth, 4 = redapex, 5 = reddest
        public byte[] Tail;

        public CollisionCacheItemHeader REDheader;

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Archive.ArchiveAbsolutePath, FileMode.Open))
            using (var viewstream = file.CreateViewStream(PageOffset, ZSize, MemoryMappedFileAccess.Read))
            {
                var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);

                // seek magic bytes
                if (!(Comtype == 5 || Comtype == 1))
                {
                    using (MemoryStream ms = new MemoryStream())
                    using (var br = new BinaryReader(ms))
                    {
                        zlib.CopyTo(ms);

                        var p = zlib.Position;
                        ms.Seek(0, SeekOrigin.Begin);

                        REDheader = new CollisionCacheItemHeader();
                        REDheader.Read(br);

                        foreach (var item in REDheader.Items)
                        {
                            var buffer = br.ReadBytes((int)item.FileSize);
                            new MemoryStream(buffer).CopyTo(output);
                        }
                    }
                }
                else
                {
                    zlib.CopyTo(output);
                }
            }
        }
    }
}
