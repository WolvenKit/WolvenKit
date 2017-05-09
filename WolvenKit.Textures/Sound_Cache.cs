using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using WolvenKit.CR2W;

namespace WolvenKit.Cache
{
    public class SoundCache
    {
        public byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public long version = 2;
        public Int64 Unknown1;
        public Int64 InfoOffset;
        public Int64 FileCount;
        public Int64 NamesOffset;
        public Int64 NamesSize;
        public Int64 Unknown2;
        public Int64 Unknown3;
        public string FileName;

        public class SoundCacheItem
        {
            //Name of the bundled item in the archive.
            public string Name;
            //Name of the cache file this file is in. (Needed for Extract() )
            public string ParentFile;

            public Int64 NameOffset;
            public Int64 Offset;
            public Int64 Size;

            public void Extract(Stream output)
            {
                using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
                {
                    using (var viewstream = file.CreateViewStream(Offset, Size, MemoryMappedFileAccess.Read))
                    {
                       viewstream.CopyTo(output);
                    }
                }
            }
        }

        public SoundCache(string fileName)
        {
            FileName = fileName;
            Read(new BinaryReader(new FileStream(fileName, FileMode.Open)));
        }

        public List<SoundCacheItem> Files;

        public void Read(BinaryReader br)
        {

            Files = new List<SoundCacheItem>();
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new InvalidDataException("Wrong Magic in soundcache!");
            version = br.ReadInt32();
            if (version >= 2)
            {
                Unknown1 = br.ReadInt64();
                InfoOffset = br.ReadInt64();
                FileCount = br.ReadInt64();
                NamesOffset = br.ReadInt64();
                NamesSize = br.ReadInt64();
            }
            else
            {
                Unknown1 = br.ReadInt64();
                InfoOffset = br.ReadUInt32();
                FileCount = br.ReadUInt32();
                NamesOffset = br.ReadUInt32();
                NamesSize = br.ReadUInt32();
            }
            Unknown2 = br.ReadInt64();
            Unknown3 = br.ReadInt64();
            br.BaseStream.Seek(InfoOffset, SeekOrigin.Begin);
            for (var i = 0; i < FileCount; i++)
            {
                var sf = new SoundCacheItem();
                if (version >= 2)
                {
                    sf.NameOffset = br.ReadInt64();
                    sf.Offset = br.ReadInt64();
                    sf.Size = br.ReadInt64();
                }
                else
                {
                    sf.NameOffset = br.ReadUInt32();
                    sf.Offset = br.ReadUInt32();
                    sf.Size = br.ReadUInt32();
                }
                Files.Add(sf);
            }
            foreach (var f in Files)
            {
                br.BaseStream.Seek(NamesOffset + f.NameOffset, SeekOrigin.Begin);
                f.Name = br.ReadCR2WString();
                f.ParentFile = this.FileName;
            }
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(Magic);
            bw.Write(version);
            bw.Write(Unknown1);
            bw.Write(InfoOffset);
            bw.Write(FileCount);
            bw.Write(NamesOffset);
            bw.Write(NamesSize);
            bw.Write(Unknown2);
            bw.Write(Unknown3);
            //TODO: Write file contents and names
        }
    }
}
