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
using WolvenKit.Common.Tools;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    public class TextureCache : IWitcherArchive
    {
        // constants
        public static byte[] Magic = { (byte)'H', (byte)'C', (byte)'X', (byte)'T' };
        private const uint MagicInt = 1415070536;

        public EBundleType TypeName => EBundleType.TextureCache;

        public string ArchiveAbsolutePath { get; set; }


        #region Properties
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

        #region Write
        public void LoadFiles(string inputfolder)
        {
            var di = new DirectoryInfo(inputfolder);
            if (!di.Exists)
                return;
            var inputfiles = di.GetFiles("*.dds", SearchOption.AllDirectories)
                .Select(_ => _.FullName);

            // clear data
            Files.Clear();
            Names.Clear();
            MipOffsets.Clear();

            foreach (var filename in inputfiles)
            {
                var ext = Path.GetExtension(filename);
                var relativepath = filename.Substring(di.FullName.Length + 1);

                switch (ext)
                {
                    case ".xbm":
                        {
                            // read cr2wfile
                            var cr2w = new CR2WFile()
                            {
                                FileName = filename,
                            };
                            using (var cfs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                            using (var reader = new BinaryReader(cfs))
                            {
                                var errorcode = cr2w.Read(reader);
                                if (errorcode != EFileReadErrorCodes.NoError)
                                    continue;
                            }

                            // check if CBitmapTexture
                            if (!(cr2w.chunks.FirstOrDefault()?.data is CBitmapTexture xbm))
                            {
                                continue;
                            }


                            break;
                        }
                    case ".dds":
                        {
                            var ddsheader = DDSUtils.ReadHeader(filename);

                            #region Create Table Item
                            var (type1, type2) =
                                CommonImageTools.GetREDEngineByteFromEFormat(ddsheader.Format);

                            if (ddsheader.Width % 2 != 0 || ddsheader.Height % 2 != 0)
                                continue;

                            var maxSide = Math.Max(ddsheader.Width, ddsheader.Height);
                            //var minSide = Math.Min(ddsheader.Width, ddsheader.Height);
                            var realmipscount = Math.Max(1, Math.Log10(maxSide / 32)/Math.Log10(2));
                            if (ddsheader.Mipscount == 1)
                                realmipscount = 0;

                            var ti = new TextureCacheItem(this)
                            {
                                Name = relativepath,
                                FullName = filename,
                                
                                Hash = (uint)FNV1A64HashAlgorithm.HashString(relativepath),

                                /*------------- TextureCache Data ---------------*/
                                // NOTE: these need to be populated after writing the files
                                ParentFile = "",        //done
                                StringTableOffset = -1, //done
                                PageOffset = 0,        //done
                                CompressedSize = 0,    //done
                                UncompressedSize = 0,  //done
                                MipOffsetIndex = -1,    //done

                                /*------------- Image data ---------------*/
                                NumMipOffsets = (int)realmipscount,
                                BaseAlignment = ddsheader.Bpp,
                                BaseWidth = (ushort)ddsheader.Width,
                                BaseHeight = (ushort)ddsheader.Height,
                                Mipcount = (ushort)ddsheader.Mipscount,
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
                            
                            break;
                        }

                }
            }
        }


        public void Write(string outpath)
        {
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

                    // cubemaps
                    if (ti.IsCube != 0)
                    {

                    }
                    // xbms
                    else
                    {
                        //using (var readfs = new FileStream(ddsfile, FileMode.Open, FileAccess.Read))
                        //using (var br = new BinaryReader(readfs))
                        using (var file = MemoryMappedFile.CreateFromFile(ddsfile, FileMode.Open))
                        {
                            var ddsoffset = (uint)128; // dds header size
                            var startoffset = cacheFileStream.Position;

                            // copy main image and mipmaps to the texture.cache
                            // no mipmaps means NumMipOffsets is 0
                            for (int i = 0; i < ti.NumMipOffsets + 1; i++)
                            {
                                // first idx is the main image. check for alignment
                                // subsequent mipmaps are appended
                                // last 6 mips are concatenated into one compressed buffer
                                uint mipWidth = (uint)(ti.BaseWidth / (Math.Pow(2, i)));
                                uint mipHeight = (uint)(ti.BaseHeight / (Math.Pow(2, i)));
                                var size = DDSUtils.CalculateMipMapSize(mipWidth, mipHeight, ti.Format);
                                // TODO: non-square textures. fml
                                if (mipWidth == 32)
                                    size = 696;
                                if (i == 0)
                                {
                                    if (cacheFileStream.Position % 4096 != 0)
                                        throw new CacheWritingException(
                                            $"{ti.Name} Improperly aligned (pos: {cacheFileStream.Position}).");
                                    ti.PageOffset = (uint)(cacheFileStream.Position / 4096);
                                }

                                
                                byte idx = (byte)(ti.NumMipOffsets - i);

                                using (var viewstream = file.CreateViewStream(ddsoffset, size, MemoryMappedFileAccess.Read))
                                using (var zlibstream = new ZlibStream(viewstream, CompressionMode.Compress))
                                using (var mipms = new MemoryStream())
                                {
                                    zlibstream.CopyTo(mipms);

                                    // each compressed image has a header (9 bytes: zsize, size, idx)
                                    var zsize = (uint) mipms.Length;
                                    if (i == 0)
                                    {
                                        ti.Size = size;
                                        ti.ZSize = zsize;
                                    }

                                    // write to cache file
                                    // header
                                    var mipmapoffset = cacheFileStream.Position;
                                    cacheWriter.Write(zsize);
                                    cacheWriter.Write(size);
                                    cacheWriter.Write(idx);
                                    // compressed image
                                    mipms.Seek(0, SeekOrigin.Begin);
                                    mipms.CopyTo(cacheFileStream);

                                    ti.UncompressedSize += size;

                                    if (i != 0)
                                    {
                                        ti.MipMapInfo.Add(new MipmapInfo(mipmapoffset, (uint) zsize, (uint) size, idx));
                                        MipOffsets.Add((uint)mipmapoffset);
                                    }
                                }

                                ti.MipOffsetIndex = MipOffsets.Count;
                                ddsoffset += size;
                            }

                            // padding to next page (4096 byte pages)
                            var endoffset = cacheFileStream.Position;
                            page = (int) (endoffset / 4096);
                            var paddinglen = (4096 * (page + 1)) - endoffset;
                            var padding = new byte[paddinglen];
                            cacheWriter.Write(padding);

                            ti.CompressedSize = (uint)(endoffset - startoffset);
                        }
                    }

                }

                #endregion

                // calculate final stats
                UsedPages = (uint)page + 1;
                EntryCount = (uint)Files.Count;
                MipTableEntryCount = (uint)MipOffsets.Count;

                // write tables
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

                // write footer
                WriteFooter(cacheWriter);
            }



            void WriteFooter(BinaryWriter bw)
            {
                bw.Write(Crc);

                bw.Write(UsedPages);
                bw.Write(EntryCount);

                bw.Write(StringTableSize);
                bw.Write(MipTableEntryCount);

                bw.Write(MagicInt);
                bw.Write(Version);
            }
        }

        /// <summary>
        /// 
        /// </summary>
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
    }
}
