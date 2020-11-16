using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    public class TextureCache : IWitcherArchive
    {
        #region Properties
        // constants
        public static byte[] Magic = { (byte)'H', (byte)'C', (byte)'X', (byte)'T' };
        private const uint MagicInt = 1415070536;

        public EBundleType TypeName => EBundleType.TextureCache;

        public string ArchiveAbsolutePath { get; set; }


        
        //The images packed into these Texture cache files
        public List<TextureCacheItem> Files;
        private List<string> Names;
        private List<uint> MipOffsets;

        // Footer
        private ulong Crc;
        private uint UsedPages;            // used pages for the compressed files (excluding info tables in the cache)         
        private uint EntryCount;
        private uint StringTableSize;
        private uint MipTableEntryCount;   // number of entries in the mipOffsetTable
        private uint Version;

        #endregion

        #region Constructors
        public TextureCache()
        {
            MipOffsets = new List<uint>();
            Names = new List<string>();
            Files = new List<TextureCacheItem>();

            Version = 6;
        }

        /// <summary>
        /// Deserialize TextureCache from texture.cache file
        /// </summary>
        /// <param name="filename"></param>
        public TextureCache(string filename)
        {
            MipOffsets = new List<uint>();
            Names = new List<string>();
            Files = new List<TextureCacheItem>();

            this.Read(filename);
        }
        #endregion

        #region Read
        private void Read(string filepath)
        {
            try
            {
                ArchiveAbsolutePath = filepath;
                MipOffsets = new List<uint>();
                using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
                {
                    Files = new List<TextureCacheItem>();
                    Names = new List<string>();

                    #region Footer
                    br.BaseStream.Seek(-32, SeekOrigin.End);

                    Crc = br.ReadUInt64();
                    UsedPages = br.ReadUInt32();
                    EntryCount = br.ReadUInt32();
                    StringTableSize = br.ReadUInt32();
                    MipTableEntryCount = br.ReadUInt32();
                    var magic = br.ReadUInt32();
                    if (magic != MagicInt)
                        throw new Exception("Invalid file!");
                    Version = br.ReadUInt32();
                    #endregion

                    
                    // JMP to the top of the info table:
                    // 32 is the the size of the stuff we read so far.
                    // + Every entry has 52 bytes of info
                    // + The stringtablesize (found in the footer)
                    // + MipTableEntryCount * offset is 4 bytes
                    // The sum of this is how much we need to jump from the back
                    var stringtableoffset = -(32 + (EntryCount * 52) + StringTableSize + (MipTableEntryCount * 4));
                    br.BaseStream.Seek(stringtableoffset, SeekOrigin.End);

                    #region MipMapTable
                    for (var i = 0; i < MipTableEntryCount; i++)
                    {
                        MipOffsets.Add(br.ReadUInt32());
                    }
                    #endregion

                    #region StringTable
                    for (var i = 0; i < EntryCount; i++)
                    {
                        Names.Add(br.ReadCR2WString());
                    }
                    #endregion

                    #region EntryTable
                    // jump to entry table
                    var entrytableoffset = -(32 + (EntryCount * 52));
                    br.BaseStream.Seek(entrytableoffset, SeekOrigin.End);

                    for (var i = 0; i < EntryCount; i++)
                    {
                        var ti = new TextureCacheItem(this)
                        {
                            Name = Names[i],
                            ParentFile = ArchiveAbsolutePath,

                            Hash = br.ReadUInt32(),
                            /*-------------TextureCacheEntryBase---------------*/
                            StringTableOffset = br.ReadInt32(),
                            PageOffset = br.ReadUInt32(),
                            CompressedSize = br.ReadUInt32(),
                            UncompressedSize = br.ReadUInt32(),

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
                        ti.Format = CommonImageTools.GetEFormatFromREDEngineByte(ti.Type1);
                        Files.Add(ti);
                    }

                    #endregion

                    //BUG: "C:\\Users\\bence.hambalko\\Documents\\The Witcher 3\\bin\\x64\\..\\..\\Mods\\modW3EE\\content\\texture.cache" dies here! Investigate!!!!!!!!!!!!!
                    foreach (var t in Files)
                    {
                        br.BaseStream.Seek(t.PageOffset * 4096, SeekOrigin.Begin);
                        t.ZSize = br.ReadUInt32(); //Compressed size
                        t.Size = br.ReadUInt32(); //Uncompressed size
                        t.MipIdx = br.ReadByte(); //maybe the 48bit part of OFFSET

                        var lastpos = br.BaseStream.Position + t.ZSize;


                        for (int i = 0; i < t.NumMipOffsets; i++)
                        {
                            br.BaseStream.Seek(lastpos, SeekOrigin.Begin);

                            var mzsize = br.ReadUInt32();
                            var msize = br.ReadUInt32();
                            var midx = br.ReadByte();

                            t.MipMapInfo.Add(new MipmapInfo(lastpos + 9, mzsize, msize, midx));

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
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputfolder"></param>
        public void LoadFiles(string inputfolder, ILoggerService logger = null)
        {
            

            var di = new DirectoryInfo(inputfolder);
            if (!di.Exists)
                return;
            var inputfiles = di.GetFiles("*.dds", SearchOption.AllDirectories)
                .Select(_ => _.FullName).ToList();

            logger?.LogString($"[TextureCache] Begin caching.", Logtype.Important);
            logger?.LogString($"[TextureCache] Found {inputfiles.Count} files.", Logtype.Important);

            // clear data
            Files.Clear();
            Names.Clear();
            MipOffsets.Clear();

            foreach (var filename in inputfiles)
            {
                var ext = Path.GetExtension(filename);
                

                switch (ext)
                {
                    //case ".xbm":
                    //    {
                    //        // read cr2wfile
                    //        var cr2w = new CR2WFile()
                    //        {
                    //            FileName = filename,
                    //        };
                    //        using (var cfs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    //        using (var reader = new BinaryReader(cfs))
                    //        {
                    //            var errorcode = cr2w.Read(reader);
                    //            if (errorcode != EFileReadErrorCodes.NoError)
                    //                continue;
                    //        }

                    //        // check if CBitmapTexture
                    //        if (!(cr2w.chunks.FirstOrDefault()?.data is CBitmapTexture xbm))
                    //        {
                    //            continue;
                    //        }


                    //        break;
                    //    }
                    case ".DDS":
                    case ".dds":
                        {
                            var ddsheader = DDSUtils.ReadHeader(filename);

                            var redpath = Path.ChangeExtension(filename, ddsheader.Iscubemap ? ".w2cube" : ".xbm");
                            var relativepath = redpath.Substring(di.FullName.Length + 1);

                            #region Create Table Item
                            var (type1, type2) =
                                CommonImageTools.GetREDEngineByteFromEFormat(ddsheader.Format);

                            if (ddsheader.Width % 2 != 0 || ddsheader.Height % 2 != 0)
                                continue;

                            var maxSide = Math.Max(ddsheader.Width, ddsheader.Height);
                            //var minSide = Math.Min(ddsheader.Width, ddsheader.Height);
                            var realmipscount = Math.Max(1, Math.Log10(maxSide / 32)/Math.Log10(2));
                            if (ddsheader.Mipscount == 1) //TODO: fix this
                                realmipscount = 0;
                            if (ddsheader.Mipscount == 0) //TODO: fix this
                            {
                                realmipscount = 0;

                            }

                            var ti = new TextureCacheItem(this)
                            {
                                Name = relativepath,
                                FullName = filename,
                                
                                Hash = HashKey(relativepath),

                                /*------------- TextureCache Data ---------------*/
                                // NOTE: these need to be populated after writing the files
                                ParentFile = "",        //done
                                StringTableOffset = -1, //done
                                PageOffset = 0,        //done
                                CompressedSize = 0,    //done
                                UncompressedSize = 0,  //done
                                MipOffsetIndex = 0,    //done

                                /*------------- Image data ---------------*/
                                NumMipOffsets = (int)realmipscount,
                                BaseAlignment = ddsheader.Bpp,
                                BaseWidth = (ushort)ddsheader.Width,
                                BaseHeight = (ushort)ddsheader.Height,
                                Mipcount = (ushort)Math.Max(1,ddsheader.Mipscount),
                                SliceCount = (ushort)ddsheader.Slicecount, //TODO

                                TimeStamp = 0 /*(long)CDateTime.Now.ToUInt64()*/, //NOTE: Not even CDPR could be bothered to use their own Timestamps

                                Type1 = type1,
                                Type2 = type2,
                                IsCube = ddsheader.Iscubemap ? (byte)1 : (byte)0,
                                Unk1 = 0x00, //TODO: figure this out

                                Format = CommonImageTools.GetEFormatFromREDEngineByte(type1)
                            };
                            #endregion

                            Files.Add(ti);
                            Names.Add(ti.Name);

                            logger?.LogString($"Cached {ti.Name}", Logtype.Normal);

                            break;
                        }

                }
            }

            logger?.LogString($"[TextureCache] Caching sucessful.", Logtype.Success);
        }
        
        #region Write
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outpath"></param>
        public void Write(string outpath, ILoggerService logger = null)
        {
            logger?.LogString($"[TextureCache] Begin writing.", Logtype.Important);
            logger?.LogString($"[TextureCache] Found {Files.Count} files.", Logtype.Important);
            int page = 0;

            using (var cacheFileStream = new FileStream(outpath, FileMode.Create, FileAccess.Write))
            using (var cacheWriter = new BinaryWriter(cacheFileStream))
            {
                // write files
                #region Write Compressed Files

                foreach (var ti in Files)
                {
                    ti.ParentFile = outpath;
                    var ddsfile = ti.FullName;
                    if (!File.Exists(ddsfile))
                        continue;

                    // checks
                    long ddssize = -1;
                    // get dds file size //TODO: make this better
                    using (var readfs = new FileStream(ddsfile, FileMode.Open, FileAccess.Read))
                    {
                        ddssize = readfs.Length - 128;
                    }
                    if (ti.IsCube != 0)
                    {
                        if (ddssize % 6 != 0)
                            throw new CacheWritingException($"{ti.Name} incorrect cubemap (not divisible by 6).");
                    }
                    ti.UncompressedSize = (uint)ddssize;
                    var ddsoffset = (uint)128; // dds header size
                    var startoffset = cacheFileStream.Position;

                    // check for alignment
                    if (cacheFileStream.Position % 4096 != 0)
                        throw new CacheWritingException($"{ti.Name} Improperly aligned (pos: {cacheFileStream.Position}).");

                    // cubemaps
                    if (ti.IsCube != 0)
                    {
                        // dds cube textures are structured in 6 faces (each with mipmaps)
                        // files in the texture cache are structured by mipmaps (each with 6 faces) 
                        // sigh...
                        using (var file = MemoryMappedFile.CreateFromFile(ddsfile, FileMode.Open))
                        {
                            #region Main Image
                            // get main image
                            var imgsize = DDSUtils.CalculateMipMapSize(ti.BaseWidth, ti.BaseHeight, ti.Format);
                            ti.PageOffset = (uint)(cacheFileStream.Position / 4096);

                            // all faces and mipmaps get compressed at once 
                            using (var allfacesms = new MemoryStream())
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    var faceoffset = 128 + ddssize / 6 * i;
                                    using (var vs = file.CreateViewStream(faceoffset, imgsize,
                                        MemoryMappedFileAccess.Read))
                                    {
                                        vs.CopyTo(allfacesms);
                                    }
                                }

                                // compress the assembled stream of all faces
                                ti.Size = 6 * imgsize;
                                ti.ZSize = (uint)WriteImgFromStream(allfacesms, cacheWriter, (byte)(ti.NumMipOffsets)).Item1;
                            }
                            #endregion

                            #region MipMaps 
                            // no mipmaps means NumMipOffsets is 0
                            var totalmipmapsizeuptonow = 0;
                            for (int i = 0; i < ti.NumMipOffsets; i++)
                            {
                                uint mipWidth = (uint)(ti.BaseWidth / (Math.Pow(2, i + 1)));
                                uint mipHeight = (uint)(ti.BaseHeight / (Math.Pow(2, i + 1)));
                                var mipsize = DDSUtils.CalculateMipMapSize(mipWidth, mipHeight, ti.Format);
                                // last 6 mips are concatenated into one compressed buffer
                                // TODO: non-square textures. fml
                                if (mipWidth == 32)
                                    mipsize = 696;
                                byte idx = (byte)(ti.NumMipOffsets - 1 - i);
                                

                                // all faces and mipmaps get compressed at once 
                                using (var allmips = new MemoryStream())
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        // find correct mip: divide dds by 6 + the main size + the size of all mips before the current one
                                        
                                        var mipoffset = (ddssize / 6 * j) + (ti.Size / 6) + (totalmipmapsizeuptonow);
                                        using (var vs = file.CreateViewStream(mipoffset, mipsize,
                                            MemoryMappedFileAccess.Read))
                                        {
                                            vs.CopyTo(allmips);
                                        }
                                    }

                                    // compress the assembled stream of all mipmaps
                                    totalmipmapsizeuptonow += (int)mipsize;
                                    mipsize *= 6; //TODO
                                    var (zsize, offset) = WriteImgFromStream(allmips, cacheWriter, idx);
                                    ti.MipMapInfo.Add(new MipmapInfo(offset, (uint)zsize, (uint)mipsize, idx));
                                    MipOffsets.Add((uint)offset);
                                }


                                ti.MipOffsetIndex = MipOffsets.Count;
                                ddsoffset += mipsize;
                            }
                            #endregion
                        }
                    }
                    else
                    {
                        using (var file = MemoryMappedFile.CreateFromFile(ddsfile, FileMode.Open))
                        {
                            #region Main Image
                            // get main image
                            ti.Size = DDSUtils.CalculateMipMapSize(ti.BaseWidth, ti.BaseHeight, ti.Format);
                            ti.PageOffset = (uint)(cacheFileStream.Position / 4096);

                            // compress image
                            using (var vs = file.CreateViewStream(ddsoffset, ti.Size, MemoryMappedFileAccess.Read))
                            {
                                ti.ZSize = (uint)WriteImgFromStream(vs, cacheWriter, (byte)(ti.NumMipOffsets)).Item1;
                            }
                            #endregion

                            #region MipMaps 
                            // no mipmaps means NumMipOffsets is 0
                            for (int i = 0; i < ti.NumMipOffsets; i++)
                            {
                                uint mipWidth = (uint) (ti.BaseWidth / (Math.Pow(2, i + 1)));
                                uint mipHeight = (uint) (ti.BaseHeight / (Math.Pow(2, i + 1)));
                                var mipsize = DDSUtils.CalculateMipMapSize(mipWidth, mipHeight, ti.Format);

                                // last 6 mips are concatenated into one compressed buffer
                                // TODO: non-square textures. fml
                                if (mipWidth == 32)
                                    mipsize = 696;

                                byte idx = (byte)(ti.NumMipOffsets - 1 - i);

                                // compress image and write to cache
                                using (var viewstream =
                                    file.CreateViewStream(ddsoffset, mipsize, MemoryMappedFileAccess.Read))
                                {
                                    var (zsize, offset) = WriteImgFromStream(viewstream, cacheWriter, idx);
                                    ti.MipMapInfo.Add(new MipmapInfo(offset, (uint)zsize, (uint)mipsize, idx));
                                    MipOffsets.Add((uint)offset);
                                }

                                ti.MipOffsetIndex = MipOffsets.Count;
                                ddsoffset += mipsize;
                            }
                            #endregion
                        }
                    }

                    //TODO: check if the complete dds file is read

                    // padding to next page (4096 byte pages)
                    var endoffset = cacheFileStream.Position;
                    page = (int)(endoffset / 4096);
                    var paddinglen = (4096 * (page + 1)) - endoffset;
                    var padding = new byte[paddinglen];
                    cacheWriter.Write(padding);

                    ti.CompressedSize = (uint)(endoffset - startoffset);

                    logger?.LogString($"Written {ti.Name}", Logtype.Normal);
                }

                #endregion

                // calculate final stats
                UsedPages = (uint)page + 1;
                EntryCount = (uint)Files.Count;
                MipTableEntryCount = (uint)MipOffsets.Count;

                // write tables
                #region Tables
                foreach (var mipOffset in MipOffsets)
                {
                    cacheWriter.Write(mipOffset);
                }


                using (var ms = new MemoryStream())
                using (var bw = new BinaryWriter(ms))
                {
                    // mipmaptable
                    var startpos = ms.Position;
                    
                    var endpos = ms.Position;

                    // string table
                    //updates this.StringTableSize and all textureCacheItem.StringTableOffset
                    //startpos = ms.Position;
                    foreach (var textureCacheItem in Files)
                    {
                        var filename = textureCacheItem.Name;
                        bw.WriteCR2WString(filename);
                        textureCacheItem.StringTableOffset = (int) bw.BaseStream.Position;
                    }
                    endpos = ms.Position;
                    StringTableSize = (uint)(endpos - startpos);

                    // entry table
                    startpos = ms.Position;
                    foreach (var textureCacheItem in Files)
                    {
                        textureCacheItem.Write(bw);
                    }
                    endpos = ms.Position;

                    Crc = CalculateChecksum(ms.ToArray());

                    ms.Seek(0, SeekOrigin.Begin);
                    ms.CopyTo(cacheFileStream);
                }
                #endregion

                // write footer
                WriteFooter(cacheWriter);

                logger?.LogString($"[TextureCache] Writing sucessful.", Logtype.Success);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bw"></param>
        private void WriteFooter(BinaryWriter bw)
        {
            bw.Write(Crc);

            bw.Write(UsedPages);
            bw.Write(EntryCount);

            bw.Write(StringTableSize);
            bw.Write(MipTableEntryCount);

            bw.Write(MagicInt);
            bw.Write(Version);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inStream"></param>
        /// <param name="outWriter"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static (int, long) WriteImgFromStream(Stream inStream, BinaryWriter outWriter, byte n)
        {
            int size = (int)inStream.Length;
            int zsize = -1;
            long offset = -1;
            inStream.Seek(0, SeekOrigin.Begin);

            using (var zlibstream = new ZlibStream(inStream, CompressionMode.Compress))
            using (var tempms = new MemoryStream())
            {
                zlibstream.CopyTo(tempms);
                zsize = (int)tempms.Length;

                // write header
                offset = outWriter.BaseStream.Position;
                outWriter.Write(zsize);
                outWriter.Write(size);
                outWriter.Write(n);

                // write compressed image
                tempms.Seek(0, SeekOrigin.Begin);
                tempms.CopyTo(outWriter.BaseStream);
            }

            return (zsize, offset);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static ulong CalculateChecksum(IEnumerable<byte> bytes)
        {
            const ulong fnv64Offset = 0xcbf29ce484222325;
            const ulong fnv64Prime = 0x100000001b3;
            ulong hash = fnv64Offset;
            foreach (var b in bytes)
            {
                hash ^= b;
                hash = (hash * fnv64Prime) % 0xFFFFFFFFFFFFFFFF;
            }
            return hash;
        }

        public ulong DBG_crc => CalculateMyChecksum();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ulong CalculateMyChecksum()
        {
            // write tables
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                // mipmaptable
                var startpos = ms.Position;
                //foreach (var mipOffset in MipOffsets)
                //{
                //    bw.Write(mipOffset);
                //}
                var endpos = ms.Position;

                // string table
                startpos = ms.Position;
                foreach (var name in Names)
                {
                    bw.WriteCR2WString(name);
                }
                endpos = ms.Position;

                // entry table
                startpos = ms.Position;
                foreach (var textureCacheItem in Files)
                {
                    textureCacheItem.Write(bw);
                }
                endpos = ms.Position;

                return CalculateChecksum(ms.ToArray());
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void DumpInfo()
        {
            const string head = "Format\t" +
                                "Format2\t" +
                                "BPP\t" +
                                "Width\t" +
                                "Height\t" +
                                "Size\t" +
                                "PageOffset\t" +
                                "CompressedSize\t" +
                                "UncompressedSize\t" +
                                "MipOffsetIndex\t" +
                                "NumMipOffsets\t" +
                                "TimeStamp\t" +
                                "Mips\t" +
                                "Slices\t" +
                                "Cube\t" +
                                "Unk1\t" +
                                "Hash\t" +
                                "Name\t" +
                                "Extension\t" +
                                "MipmapCount\t" +
                                "Mipmaps";

            // dump chache info
            using (var writer = File.CreateText($"{this.ArchiveAbsolutePath}.info"))
            {
                writer.WriteLine($"ArchiveAbsolutePath: {ArchiveAbsolutePath}\r\n");

                writer.WriteLine($"CRC: {Crc}\r\n");
                writer.WriteLine($"UsedPages: {UsedPages}\r\n");
                writer.WriteLine($"EntryCount: {EntryCount}\r\n");
                writer.WriteLine($"StringTableSize: {StringTableSize}\r\n");
                writer.WriteLine($"MipTableEntryCount: {MipTableEntryCount}\r\n");
                writer.WriteLine($"Version: {Version}\r\n");
            }

            // dump and extract files
            using (var writer = File.CreateText($"{this.ArchiveAbsolutePath}.txt"))
            {
                // write header
                writer.WriteLine(head);

                // write info elements
                foreach (var x in Files)
                {
                    string ext = x.Name.Split('.').Last();

                    string info = $"{x.Type1:X2}\t" +
                                  $"{x.Type2:X2}\t" +
                                  $"{x.BaseAlignment}\t" +
                                  $"{x.BaseWidth}\t" +
                                  $"{x.BaseHeight}\t" +
                                  $"{x.Size}\t" +
                                  $"{x.PageOffset}\t" +
                                  $"{x.CompressedSize}\t" +
                                  $"{x.UncompressedSize}\t" +
                                  $"{x.MipOffsetIndex}\t" +
                                  $"{x.NumMipOffsets}\t" +
                                  $"{x.TimeStamp}\t" +
                                  $"{x.Mipcount}\t" +
                                  $"{x.SliceCount}\t" +
                                  $"{x.IsCube.ToString("X2")}\t" +
                                  $"{x.Unk1.ToString()}/{x.Unk1.ToString("X2")}\t" +
                                  $"{x.Hash}\t" +
                                  $"{x.Name}\t"
                        ;
                    info += $"{x.Name.Split('.').Last()}\t";
                    info += $"{x.MipMapInfo.Count()}\t";
                    info += "<";
                    foreach (var y in x.MipMapInfo)
                    {
                        info += $"<{y.Size},{y.ZSize}>";
                    }

                    info += ">";

                    writer.WriteLine(info);
                }
            }
        }

        private uint HashKey(string key)
        {
            char[] keyConverted = key.ToCharArray();
            uint hash = 0;
            foreach (char c in keyConverted)
            {
                hash *= 31;
                hash += (uint)c;
            }
            return hash;
        }
    }
}
