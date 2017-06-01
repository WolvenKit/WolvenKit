using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using WolvenKit.CR2W;
using W3SavegameEditor;

namespace WolvenKit.Cache
{
    public class SoundCache
    {
        public byte[] Magic = {(byte) 'C', (byte) 'S', (byte) '3', (byte) 'W'};
        public long Version = 2;
        public long Unknown1; //Possibly NOP
        public long InfoOffset;
        public long FileCount;
        public long NamesOffset;
        public long NamesSize;
        public long BufferSize;
        public long Checksum;
        public string FileName;

        public List<SoundCacheItem> Files;

        public SoundCache(string fileName)
        {
            FileName = fileName;
            Read(new BinaryReader(new FileStream(fileName, FileMode.Open)));
        }

        public void CalculateCheksum()
        {

        }

        public void Read(BinaryReader br)
        {

            Files = new List<SoundCacheItem>();
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new InvalidDataException("Wrong Magic in soundcache!");
            Version = br.ReadInt32();
            if (Version >= 2)
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
            BufferSize = br.ReadInt64();
            Checksum = br.ReadInt64();
            br.BaseStream.Seek(InfoOffset, SeekOrigin.Begin);
            for (var i = 0; i < FileCount; i++)
            {
                var sf = new SoundCacheItem();
                if (Version >= 2)
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
            bw.Write(Version);
            bw.Write(Unknown1);
            bw.Write(InfoOffset);
            bw.Write(Files.Count);
            bw.Write(NamesOffset);
            bw.Write(Files.Sum(x => Encoding.Default.GetBytes(x.Name).Length + 1));
                //Sum(bw.WriteCR2WString()); Name + 0x00
            bw.Write(BufferSize);
            bw.Write(Checksum);

            foreach (var soundfile in Files)
            {
                bw.WriteCR2WString(soundfile.Name);
            }


        }

        private static uint HashFnv(string input)
        {
            const uint FnvHashInitial = 0x811C9DC5;
            const int FnvHashPrime = 0x1000193;
            var fnvHash = FnvHashInitial;
            var data = Encoding.ASCII.GetBytes(input);
            foreach (var t in data)
            {
                fnvHash ^= t;
                fnvHash *= FnvHashPrime;
            }
            fnvHash *= FnvHashPrime;
            return fnvHash;
        }
    }

    public class SoundCacheItem
    {
        //Name of the bundled item in the archive.
        public string Name;
        //Name of the cache file this file is in. (Needed for Extract() )
        public string ParentFile;

        public long NameOffset;
        public long Offset;
        public long Size;

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

        public void Extract(string filename)
        {
            using (var output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
                output.Close();
            }
        }
    }
}
