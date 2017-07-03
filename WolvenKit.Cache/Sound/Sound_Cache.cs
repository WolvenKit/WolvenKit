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
    /// <summary>
    /// The soud archives of Witcher 3. Contains .wem and .bnk sound files.
    /// </summary>
    public class SoundCache : IWitcherArchiveType
    {
        public byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public long Version = 2;
        public long Unknown1;
        public long InfoOffset;
        public long FileCount;
        public long NamesOffset;
        public long NamesSize;
        public long buffsize;
        public long checksum;
        public string TypeName { get { return "SoundCache"; } }
        public string FileName { get; set; }

        public string Names => Files.Aggregate("\0",(c, n) => c += n.Name) + "\0";

        public string GetInfo()
        {
            var buff = new StringBuilder();

            return buff.ToString();
        }

        public SoundCache(string fileName)
        {
            FileName = fileName;
            Read(new BinaryReader(new FileStream(fileName, FileMode.Open)));
        }

        public List<SoundCacheItem> Files;

        /// <summary>
        /// Calculates the FNV64 hash for the soundcache.
        /// </summary>
        /// <returns></returns>
        public uint CalculateBuffer()
        {
            uint fnvHash = 0x811C9DC5;
            byte[] data = Encoding.ASCII.GetBytes(this.Names + this.GetInfo());
            for (int i = 0; i < data.Length; i++)
            {
                fnvHash ^= data[i];
                fnvHash *= 0x1000193;
            }
            fnvHash *= 0x1000193; //TODO: Check if this is actually needed.
            return fnvHash;
        }

        /// <summary>
        /// Reads the soundcache file.
        /// </summary>
        /// <param name="br">The binaryreader to read the file contents from.</param>
        public void Read(BinaryReader br)
        {
            Files = new List<SoundCacheItem>();
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new InvalidDataException("Wrong Magic in soundcache!");
            Version = br.ReadInt32();
            Unknown1 = br.ReadInt64();
            if (Version >= 2)
            {
                InfoOffset = br.ReadInt64();
                FileCount = br.ReadInt64();
                NamesOffset = br.ReadInt64();
                NamesSize = br.ReadInt64();
            }
            else
            {
                InfoOffset = br.ReadUInt32();
                FileCount = br.ReadUInt32();
                NamesOffset = br.ReadUInt32();
                NamesSize = br.ReadUInt32();
            }
            buffsize = br.ReadInt64();
            checksum = br.ReadInt64();
            br.BaseStream.Seek(InfoOffset, SeekOrigin.Begin);
            for (var i = 0; i < FileCount; i++)
            {
                var sf = new SoundCacheItem(this);
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
                f.Name = f.Bundle.TypeName + "\\" + br.ReadCR2WString();
                f.ParentFile = this.FileName;
            }
        }

        /// <summary>
        /// Packs files into a soundcache file.
        /// </summary>
        /// <param name="Files">The files to pack. Have to be *.bnk & *.wem</param>
        /// <param name="OutPath">The path to write the completed soundcache to.</param>
        public void Write(List<string> Files,string OutPath)
        {
            using (var bw = new BinaryWriter(new FileStream(OutPath, FileMode.Create)))
            {
                var data_offset = 0;

                bw.Write(Magic);
                bw.Write(Version);
                bw.Write(Unknown1);
                if (Version >= 2)
                {
                    bw.Write(InfoOffset);
                    bw.Write(FileCount);
                    bw.Write(NamesOffset);
                    bw.Write(NamesSize);
                }
                else
                {
                    bw.Write((UInt32)InfoOffset);
                    bw.Write((UInt32)Files.Count);
                    bw.Write((UInt32)NamesOffset);
                    bw.Write((UInt32)NamesSize);
                }
                bw.Write(buffsize);
                bw.Write(checksum);

                foreach (var soundfile in Files)
                {
                    bw.WriteCR2WString(Path.GetFileName(soundfile));
                }
            }
        }
    }

    public class SoundCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        /// <summary>
        /// Name of the bundled item in the archive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of the cache file this file is in. (Needed for Extracting the file)
        /// </summary>
        public string ParentFile;

        
        public long NameOffset;
        public long Offset { get; set; }

        public long Size { get; set; }
        public uint ZSize { get; set; }
        public string DateString { get; set; }

        public SoundCacheItem(IWitcherArchiveType Parent)
        {
            this.Bundle = Parent;
        }

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
