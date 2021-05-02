using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using Ionic.Zlib;
using WolvenKit.Common;
using WolvenKit.Common.DDS;

namespace WolvenKit.Cache
{
    public class MipmapInfo
    {
        #region Constructors

        public MipmapInfo(long offset, uint zsize, uint size, byte idx)
        {
            Offset = offset;
            Size = size;
            ZSize = zsize;
            Idx = idx;
        }

        #endregion Constructors

        #region Properties

        public byte Idx { get; }
        public long Offset { get; }

        public uint Size { get; }   //unused
        public uint ZSize { get; }

        #endregion Properties

        //unused
    }

    public class TextureCacheItem : IGameFile
    {
        #region Fields

        public readonly List<MipmapInfo> MipMapInfo = new List<MipmapInfo>();
        public UInt32 BaseAlignment;
        public UInt16 BaseHeight;
        public UInt16 BaseWidth;
        public uint CompressedSize;
        public UInt32 Hash;
        public Byte IsCube;
        public UInt16 Mipcount;
        public byte MipIdx;
        public Int32 MipOffsetIndex;
        public Int32 NumMipOffsets;
        public string ParentFile;
        public UInt16 SliceCount;
        public Int32 StringTableOffset;
        public Int64 TimeStamp;
        public byte Type1;
        public byte Type2;
        public uint UncompressedSize;
        public Byte Unk1;

        #endregion Fields

        #region Constructors

        public TextureCacheItem(IGameArchive parent)
        {
            Archive = parent;
        }

        #endregion Constructors

        #region Properties

        public IGameArchive Archive { get; set; }
        public string CompressionType => "Zlib";
        public string DateString { get; set; }
        public EFormat Format { get; set; }
        public string FullName { get; set; }

        public string ArchiveName { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        public long PageOffset { get; set; }

        public uint Size { get; set; }
        public uint ZSize { get; set; }

        #endregion Properties

        #region Methods

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                // generate header
                var metadata = new DDSMetadata(
                    BaseWidth,
                    BaseHeight,
                    (uint)Mipcount,
                    Format,
                    BaseAlignment,
                    IsCube == 1,
                    SliceCount,
                    false
                    );
                DDSUtils.GenerateAndWriteHeader(output, metadata);

                if (IsCube == 0)
                {
                    using (var viewstream = file.CreateViewStream((PageOffset * 4096) + 9, ZSize, MemoryMappedFileAccess.Read))
                    {
                        //if ( format != ETextureFormat.TEXFMT_R8G8B8A8)
                        new ZlibStream(viewstream, CompressionMode.Decompress).CopyTo(output);
                    }
                    for (int i = 0; i < NumMipOffsets; i++)
                    {
                        var mippageoffset = MipMapInfo[i].Offset;
                        var mipzsize = MipMapInfo[i].ZSize;

                        using (var viewstream = file.CreateViewStream((mippageoffset), mipzsize, MemoryMappedFileAccess.Read))
                        {
                            //if ( format != ETextureFormat.TEXFMT_R8G8B8A8)
                            new ZlibStream(viewstream, CompressionMode.Decompress).CopyTo(output);
                        }
                    }
                }
                else
                {
                    using (var imagestream = new MemoryStream())
                    using (var mipmapstream = new MemoryStream())
                    using (var imagereader = new BinaryReader(imagestream))
                    using (var mipmapreader = new BinaryReader(mipmapstream))
                    {
                        // extract to memory
                        // image
                        using (var vs = file.CreateViewStream((PageOffset * 4096) + 9, ZSize, MemoryMappedFileAccess.Read))
                        {
                            // extracts all 6 faces after each other
                            new ZlibStream(vs, CompressionMode.Decompress).CopyTo(imagestream);
                        }
                        //mipmaps
                        // mipmap data <offset, size>
                        var mipmapoffsets = new List<Tuple<long, long>>();
                        foreach (var mipinfo in MipMapInfo)
                        {
                            var beginoffset = mipmapstream.Position;

                            using (var tempvs = file.CreateViewStream(mipinfo.Offset, mipinfo.ZSize, MemoryMappedFileAccess.Read))
                            {
                                new ZlibStream(tempvs, CompressionMode.Decompress).CopyTo(mipmapstream);
                            }
                            mipmapoffsets.Add(new Tuple<long, long>(beginoffset, mipmapstream.Position - beginoffset));
                        }

                        //assemble faces
                        for (int i = 0; i < 6; i++)
                        {
                            // get one face
                            var offset = 0 + (i * imagestream.Length / 6);
                            var facesize = (int)imagestream.Length / 6;

                            imagereader.BaseStream.Seek(offset, SeekOrigin.Begin);
                            var face = imagereader.ReadBytes(facesize);
                            output.Write(face, 0, face.Length);

                            // get mipmaps for face
                            foreach (var o in mipmapoffsets)
                            {
                                var mipsize = (o.Item2 / 6);
                                var moffset = o.Item1 + (i * mipsize);

                                mipmapreader.BaseStream.Seek(moffset, SeekOrigin.Begin);
                                var mipmap = mipmapreader.ReadBytes((int)(mipsize));

                                output.Write(mipmap, 0, mipmap.Length);
                            }
                        }
                    }
                }
            }
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(Hash);
            bw.Write(StringTableOffset);
            // !!! Uses 32bit !!!
            bw.Write((uint)PageOffset);
            bw.Write(CompressedSize);
            bw.Write(UncompressedSize);

            bw.Write(BaseAlignment);
            bw.Write(BaseWidth);
            bw.Write(BaseHeight);
            bw.Write(Mipcount);
            bw.Write(SliceCount);

            bw.Write(MipOffsetIndex);
            bw.Write(NumMipOffsets);
            bw.Write(TimeStamp);

            bw.Write(Type1);
            bw.Write(Type2);
            bw.Write(IsCube);
            bw.Write(Unk1);
        }

        private void p_Exited(object sender, EventArgs e)
        {
        }

        #endregion Methods
    }
}
