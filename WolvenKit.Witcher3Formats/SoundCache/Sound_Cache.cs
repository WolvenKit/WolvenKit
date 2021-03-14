using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WolvenKit.Common;
using WolvenKit.RED3.CR2W;

namespace WolvenKit.Wwise
{
    /// <summary>
    /// The soud archives of Witcher 3. Contains .wem and .bnk sound files.
    /// </summary>
    public class SoundCache : IGameArchive
    {
        #region Fields

        public const long BIT_LENGTH_32 = 1;
        public const long BIT_LENGTH_64 = 2;
        public const long CACHE_BUFFER_SIZE = 4096;

        public static long DataOffset = 0x30;

        public static SoundBanksInfoXML info = new SoundBanksInfoXML(Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SoundCache", "soundbanksinfo.xml"));

        public static byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public static UInt32 Unk3 = 1;
        public static UInt32 Unknown1 = 0x00000000;
        public static UInt32 Unknown2 = 0x00000000;
        public static long Version = 1;
        public long buffsize;
        public long checksum;
        public long FileCount;

        /// <summary>
        /// The files packed into the original soundcache.
        /// </summary>
        public List<SoundCacheItem> Files;

        public long InfoOffset;
        public long NamesOffset;
        public long NamesSize;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Normal constructor.
        /// </summary>
        /// <param name="fileName"></param>
        public SoundCache(string fileName)
        {
            ArchiveAbsolutePath = fileName;
            using (var br = new BinaryReader(new FileStream(fileName, FileMode.Open)))
                Read(br);
        }

        /// <summary>
        /// Empty ctor
        /// </summary>
        public SoundCache()
        {
        }

        #endregion Constructors

        #region Properties

        public string ArchiveAbsolutePath { get; set; }
        public EArchiveType TypeName => EArchiveType.SoundCache;

        #endregion Properties

        #region Methods

        public static string GetIDFromPath(string path)
        {
            var split = path.Split(Path.DirectorySeparatorChar);
            var actualpath = split.SkipWhile(x => x != EArchiveType.SoundCache.ToString()).Skip(1).Aggregate("", (c, n) => c += Path.DirectorySeparatorChar + n).Trim().Trim(Path.DirectorySeparatorChar);
            if (actualpath.EndsWith(".wem"))
            {
                if (info.StreamedFiles.Any(x => x.Path == actualpath))
                {
                    return info.StreamedFiles.First(x => x.Path == actualpath).Id + ".wem";
                }
            }
            if (actualpath.EndsWith(".bnk"))
            {
                if (info.StreamedFiles.Any(x => x.Path == actualpath))
                {
                    return info.StreamedFiles.First(x => x.Path == actualpath).Id + ".bnk";
                }
            }
            return Path.GetFileName(path);
        }

        /// <summary>
        /// Calculates the total size of the data.
        /// </summary>
        /// <param name="FileList">The list of file to calculate the sum of.</param>
        /// <returns>The size of the files.</returns>
        public static long TotalDataSize(List<string> FileList) => FileList.Sum(x => new FileInfo(x).Length);

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
                        data_array[i].PageOffset = -1;
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
                bw.Write((CalculateChecksum(FileList)));
                //Write the actual contents of the files.
                for (int i = 0; i < FileList.Count; i++)
                    if (data_array[i].PageOffset != -1)
                        bw.Write(File.ReadAllBytes(FileList[i]));
                //Write filenames and the offsets and such for the files.
                bw.Write(GetNames(FileList));
                bw.Write(GetInfo(FileList));
            }
        }

        /// <summary>
        /// Reads the soundcache file.
        /// </summary>
        /// <param name="br">The binaryreader to read the file contents from.</param>
        public void Read(BinaryReader br)
        {
            Files = new List<SoundCacheItem>();
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new InvalidDataException("Wrong ID string in sound cache.");
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
                    sf.PageOffset = br.ReadInt64();
                    sf.Size = (uint)br.ReadInt64();
                }
                else
                {
                    sf.NameOffset = br.ReadUInt32();
                    sf.PageOffset = br.ReadUInt32();
                    sf.Size = br.ReadUInt32();
                }
                Files.Add(sf);
            }
            foreach (var f in Files)
            {
                br.BaseStream.Seek(NamesOffset + f.NameOffset, SeekOrigin.Begin);
                f.Name = br.ReadCR2WString();
                if (f.Name.EndsWith(".wem") && info.StreamedFiles.Any(x => x.Id == (f.Name.Split('.')[0])))
                {
                    f.Name = info.StreamedFiles.First(x => x.Id == (f.Name.Split('.')[0])).Path;
                }
                f.ParentFile = this.ArchiveAbsolutePath;
            }
        }

        /// <summary>
        /// Builds the details of the files. Note: This is just a placeholder array. For actual details call BuildInfo();
        /// </summary>
        /// <param name="FileList">The list of details to build the info for.</param>
        /// <returns>The initialized list of files.</returns>
        private static List<SoundCacheItem> BuildInfo(List<string> FileList)
        {
            var res = new List<SoundCacheItem>();
            foreach (var item in FileList)
                res.Add(new SoundCacheItem(null));
            return res;
        }

        /// <summary>
        /// Calculates the FNV1A64 hash (with a slight change) for the soundcache.
        /// </summary>
        /// <returns></returns>
        private static ulong CalculateChecksum(List<string> Files2Buffer)
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
        /// Builds the fileinfo table. Offset,size etc.
        /// </summary>
        /// <param name="FileList">The list of files to build the info for.</param>
        /// <returns></returns>
        private static byte[] GetInfo(List<string> FileList)
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
                        name_offset += Path.GetFileName(GetIDFromPath(item)).Length + 1;
                        bw.Write((UInt64)base_offset);
                        base_offset += new FileInfo(item).Length;
                        bw.Write((UInt64)(new FileInfo(item).Length));
                    }
                    else
                    {
                        bw.Write((UInt32)name_offset);
                        name_offset += Path.GetFileName(GetIDFromPath(item)).Length + 1;
                        bw.Write((UInt32)base_offset);
                        base_offset += new FileInfo(item).Length;
                        bw.Write((UInt32)(new FileInfo(item).Length));
                    }
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Returns the concated null terminated names string.
        /// </summary>
        /// <param name="FileList">The list of files to concat.</param>
        /// <returns>The concatenated string.</returns>
        private static byte[] GetNames(List<string> FileList)
        {
            return Encoding.UTF8.GetBytes(string.Join("\0", FileList.Select(x => Path.GetFileName(GetIDFromPath(x)).Trim())) + "\0");
        }

        #endregion Methods
    }
}
