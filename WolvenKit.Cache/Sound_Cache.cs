using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using WolvenKit.CR2W;
using WolvenKit.Interfaces;

namespace WolvenKit.Cache
{
    public class SoundCache : IWitcherArchiveType
    {
        public byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public long Version = 2;
        public long Unknown1;
        public long InfoOffset;
        public long FileCount;
        public long NamesOffset;
        public long NamesSize;
        public long Unknown2;
        public long Unknown3;
        public string FileName { get; set; }

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
            Unknown2 = br.ReadInt64();
            Unknown3 = br.ReadInt64();
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
            bw.Write(Files.Sum(x=> Encoding.Default.GetBytes(x.Name).Length+1)); //Sum(bw.WriteCR2WString()); Name + 0x00
            bw.Write(Unknown2);
            bw.Write(Unknown3);

            foreach (var soundfile in Files)
            {
                bw.WriteCR2WString(soundfile.Name);
            }

            //TODO: Write file contents and names
        }
    }

    public class SoundCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        //Name of the bundled item in the archive.
        public string Name { get; set; }
        //Name of the cache file this file is in. (Needed for Extract() )
        public string ParentFile;

        public long NameOffset;
        public long Offset { get; set; }

        public long Size { get; set; }
        public uint ZSize { get; set; }
        public string DateString { get; set; }

        public string CompressionType
        {
            get
            {
                  return "None";
            }
        }

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
