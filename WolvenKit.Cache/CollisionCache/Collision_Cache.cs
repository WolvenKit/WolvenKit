using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using LZ4;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    public class CollisionCache : IWitcherArchiveType
    {
        public const long BIT_LENGTH_32 = 1;
        public const long BIT_LENGTH_64 = 2;
        public const long CACHE_BUFFER_SIZE = 4096;

        public static byte[] Magic = { (byte)'C', (byte)'C', (byte)'3', (byte)'W' };
        public static long Version = 1;
        public static CDateTime date = new CDateTime(null);
        public uint InfoOffset;
        public uint NumberOfFiles;
        public uint NameTableOffset;
        public uint NamesSize;
        public ulong Buffersize;
        public ulong CheckSum;
        public static long DataOffset = 0x30;
        public static UInt32 Unk3 = 1;

        public List<string> FileNames = new List<string>();
        public List<CollisionCacheItem> Files = new List<CollisionCacheItem>(); 

        public EBundleType TypeName => EBundleType.CollisionCache;
        public string FileName { get; set; }

        public CollisionCache(string filename)
        {
            this.FileName = filename;
            using (var br = new BinaryReader(new FileStream(filename, FileMode.Open)))
                this.Read(br);
        }

        public CollisionCache()
        {

        }

        /// <summary>
        /// Returns to concated null terminated names string.
        /// </summary>
        /// <param name="FileList">The list of files to concat.</param>
        /// <returns>The concatenated string.</returns>
        public static byte[] GetNames(List<string> FileList)
        {
            return Encoding.UTF8.GetBytes(string.Join("\0", FileList.Select(x => Path.GetFileName(x).Trim())) + "\0");
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
        public static List<CollisionCacheItem> BuildInfo(List<string> FileList)
        {
            var res = new List<CollisionCacheItem>();
            foreach (var item in FileList)
                res.Add(new CollisionCacheItem());
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

        public void Read(BinaryReader br)
        {
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new Exception("Invalid file!");
            Version = br.ReadUInt32();
            date.Read(br, 8);
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

                NameOffset = br.ReadUInt32(),
                Unk1 = br.ReadUInt32(),
                Unk2 = br.ReadUInt64(), //null
                PageOFfset = br.ReadUInt32(),
                ZSize = br.ReadUInt32(),
                Size = (long)br.ReadUInt32(),
                Unk3 = br.ReadUInt32(),
                guid = br.ReadBytes(16),
                guid2 = br.ReadBytes(16),
                Comtype = br.ReadByte(),
                Tail = br.ReadBytes(7)
            }))
            {
                Console.WriteLine("Filename: " + ci.Name);
                Files.Add(ci);
            }
        }

        public static void Write(List<string> FileList,string outpath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            using (var bw = new BinaryWriter(new FileStream(outpath, FileMode.Create)))
            {
                var data_array = BuildInfo(FileList);
                var buffersize = FileList.Max(x => new FileInfo(x).Length);

                if ((DataOffset + TotalDataSize(FileList) + GetNames(FileList).Length + GetInfo(FileList).Length) > 0xFFFFFFFF) //Switch to 64bit
                {
                    Version = 2;
                    DataOffset += 0x10;
                    for (int i = 0; i < data_array.Count; i++)
                        data_array[i].PageOFfset = -1;
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
                date.Write(bw);

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
                bw.Write((CalculateChecksum(FileList)));
                //Write the actual contents of the files.
                for (int i = 0; i < FileList.Count; i++)
                    if (data_array[i].PageOFfset != -1)
                    {
                        using (var ms = new MemoryStream())
                        {
                            new ZlibStream(new MemoryStream(File.ReadAllBytes(FileList[i])), CompressionMode.Compress).CopyTo(ms);
                            bw.Write(ms.ToArray());
                        }
                    }
                //Write filenames and the offsets and such for the files.
                bw.Write(GetNames(FileList));
                bw.Write(GetInfo(FileList));      
            }
        }
    }
}
