using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using WolvenKit.CR2W;
using WolvenKit.Interfaces;
using System.Security.Cryptography;

namespace WolvenKit.Cache
{
    /// <summary>
    /// The soud archives of Witcher 3. Contains .wem and .bnk sound files.
    /// </summary>
    public class SoundCache : IWitcherArchiveType
    {
        public const long BIT_LENGTH_32 = 1;
        public const long BIT_LENGTH_64 = 2;
        public const long CACHE_BUFFER_SIZE = 4096;

        public static byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public static long Version = 1;
        public static UInt32 Unknown1 = 0x00000000;
        public static UInt32 Unknown2 = 0x00000000;
        public long InfoOffset;
        public long FileCount;
        public long NamesOffset;
        public long NamesSize;
        public static UInt32 Unk3 = 1;
        public static long DataOffset = 0x30;
        public long buffsize;
        public long checksum;
        public string TypeName { get { return "SoundCache"; } }
        public string FileName { get; set; }

        /// <summary>
        /// The files packed into the original soundcache.
        /// </summary>
        public List<SoundCacheItem> Files;

        /// <summary>
        /// Normal constructor.
        /// </summary>
        /// <param name="fileName"></param>
        public SoundCache(string fileName)
        {
            FileName = fileName;
            using (var br = new BinaryReader(new FileStream(fileName, FileMode.Open)))
                Read(br);
        }

        /// <summary>
        /// Returns to concated null terminated names string.
        /// </summary>
        /// <param name="FileList">The list of files to concat.</param>
        /// <returns>The concatenated string.</returns>
        public static byte[] GetNames(List<string> FileList)
        {
            return Encoding.UTF8.GetBytes(string.Join("\0",FileList.Select(x=> Path.GetFileName(x).Trim())) + "\0");
        }

        /// <summary>
        /// Calculates the total size of the data.
        /// </summary>
        /// <param name="FileList">The list of file to calculate the sum of.</param>
        /// <returns>The size of the files.</returns>
        public static long TotalDataSize(List<string> FileList) => FileList.Sum(x => new FileInfo(x).Length);

        /// <summary>
        /// Builds the details of the files. Note: This is just a placeholder array. For actual details call BuildInfo();
        /// </summary>
        /// <param name="FileList">The list of details to build the info for.</param>
        /// <returns>The initialized list of files.</returns>
        public static List<SoundCacheItem> BuildInfo(List<string> FileList)
        {
            var res = new List<SoundCacheItem>();
            foreach (var item in FileList)
                res.Add(new SoundCacheItem(null));
            return res;
        }

        /// <summary>
        /// Builds the fileinfo table. Offset,size etc.
        /// </summary>
        /// <param name="FileList">The list of files to build the info for.</param>
        /// <returns></returns>
        public static byte[] GetInfo(List<string> FileList)
        {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                long base_offset = 0x30;
                long name_offset = 0x00;
                foreach (var item in FileList)
                {
                    if (Version >= 2)
                    {
                        bw.Write((UInt64)name_offset);
                        name_offset += Path.GetFileName(item).Length + 1;
                        bw.Write((UInt64)base_offset);
                        base_offset += new FileInfo(item).Length;
                        bw.Write((UInt64)(new FileInfo(item).Length));
                    }
                    else
                    {
                        bw.Write((UInt32)name_offset);
                        name_offset += Path.GetFileName(item).Length + 1;
                        bw.Write((UInt32)base_offset);
                        base_offset += new FileInfo(item).Length;
                        bw.Write((UInt32)(new FileInfo(item).Length));
                    }
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Calculates the FNV1A64 hash (with a slight change) for the soundcache.
        /// </summary>
        /// <returns></returns>
        public static ulong CalculateChecksum(List<string> Files2Buffer)
        {
            byte[] bytes = (GetNames(Files2Buffer).Concat(GetInfo(Files2Buffer))).ToArray();
            const ulong fnv64Offset = 0xcbf29ce484222325;
            const ulong fnv64Prime = 0x100000001b3;
            ulong hash = fnv64Offset;
            foreach (var b in bytes)
            {
                hash = hash ^ b;
                hash = (hash * fnv64Prime) % 0xFFFFFFFFFFFFFFFF;
            }
            return hash;
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
            Unknown1 = br.ReadUInt32();
            Unknown2 = br.ReadUInt32();
            if (Version >= 2)
            {
                InfoOffset = br.ReadInt64();
                FileCount = br.ReadInt64();
                NamesOffset = br.ReadInt64();
            }
            else
            {
                InfoOffset = br.ReadUInt32();
                FileCount = br.ReadUInt32();
                NamesOffset = br.ReadUInt32();
            }
            NamesSize = br.ReadUInt32();
            if (Version >= 2)
                Unk3 = br.ReadUInt32();      
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
        public static void Write(List<string> FileList, string OutPath)
        {
            using (var bw = new BinaryWriter(new FileStream(OutPath, FileMode.Create)))
            {
                var data_array = BuildInfo(FileList);
                var buffersize = FileList.Max(x => new FileInfo(x).Length);

                if ((DataOffset + TotalDataSize(FileList) + GetNames(FileList).Length + GetInfo(FileList).Length) > 0xFFFFFFFF) //Switch to 64bit
                {
                    Version = 2;
                    DataOffset += 0x10;
                    for (int i = 0; i < data_array.Count; i++)
                        data_array[i].Offset = -1;
                }

                if (buffersize <= CACHE_BUFFER_SIZE)
                    buffersize = CACHE_BUFFER_SIZE;
                else
                {
                    var fremainder = buffersize % CACHE_BUFFER_SIZE;
                    buffersize += (CACHE_BUFFER_SIZE - fremainder);
                }      

                bw.Write(Magic);
                bw.Write((UInt32)Version);
                bw.Write(Unknown1);
                bw.Write(Unknown2);

                if (Version >= 2)
                {
                    bw.Write((UInt64)(DataOffset + TotalDataSize(FileList) + GetNames(FileList).Length));
                    bw.Write((UInt64)FileList.Count);
                    bw.Write((UInt64)(DataOffset + TotalDataSize(FileList)));
                }
                else
                {
                    bw.Write((UInt32)(DataOffset + TotalDataSize(FileList) + GetNames(FileList).Length));
                    bw.Write((UInt32)FileList.Count);
                    bw.Write((UInt32)(DataOffset + TotalDataSize(FileList)));
                }
                bw.Write((UInt32)GetNames(FileList).Length);

                if (Version >= 2)
                    bw.Write((Unk3));

                bw.Write((UInt64)buffersize);
                bw.Write((CalculateChecksum(FileList))); //TODO: Check why the last byte is wrong!
                //Write the actual contents of the files.
                for (int i = 0; i < FileList.Count; i++)
                    if (data_array[i].Offset != -1)
                        bw.Write(File.ReadAllBytes(FileList[i]));
                //Write filenames and the offsets and such for the files.
                bw.Write(GetNames(FileList));
                bw.Write(GetInfo(FileList));                
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
