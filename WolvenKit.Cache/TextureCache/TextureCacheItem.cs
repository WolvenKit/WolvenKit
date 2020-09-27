using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using WolvenKit.Common;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    using WolvenKit.Common.Model;
    using WolvenKit.Common.Tools;
    using WolvenKit.DDS;
    using static WolvenKit.CR2W.Types.Enums;

    public class TextureCacheItem : IWitcherFile
    {
        public IWitcherArchive Bundle { get; set; }
        public string DateString { get; set; }

        public string CompressionType => "Zlib";

        public string ParentFile;

        public string Name { get; set; }
        public UInt32 Hash;
        public Int32 PathStringIndex;
        public long PageOffset { get; set; }
        public Int32 CompressedSize;
        public Int32 UncompressedSize;
        public UInt32 BaseAlignment;
        public UInt16 BaseWidth;
        public UInt16 BaseHeight;
        public UInt16 Mipcount;
        public UInt16 SliceCount;
        public Int32 MipOffsetIndex;
        public Int32 NumMipOffsets;
        public Int64 TimeStamp;
        public byte Type1;
        public byte Type2;
        public Byte IsCube;
        public Byte Unk1;

        public long Size { get; set; }
        public UInt32 ZSize { get; set; }
        public Byte SliceIdx;

        public List<Tuple<uint, uint>> MipMapInfo = new List<Tuple<uint, uint>>();

        

        public TextureCacheItem(IWitcherArchive parent)
        {
            Bundle = parent;
        }

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                // generate header
                ETextureFormat format = CommonImageTools.GetTextureFormatFromREDEngineByte(Type1);
                var metadata = new DDSMetadata(
                    BaseWidth,
                    BaseHeight,
                    (uint)Mipcount,
                    format,
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
                        var mippageoffset = MipMapInfo[i].Item1;
                        var mipzsize = MipMapInfo[i].Item2;

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
                            //if ( format != ETextureFormat.TEXFMT_R8G8B8A8)
                            new ZlibStream(vs, CompressionMode.Decompress).CopyTo(imagestream);

                        }
                        //mipmaps
                        var mipmapoffsets = new List<Tuple<long, long>>();
                        foreach (Tuple<uint, uint> v in MipMapInfo)
                        {
                            var beginoffset = mipmapstream.Position;
                            var mipoffset = v.Item1;
                            var mipZsize = v.Item2;

                            using (var temp_vs = file.CreateViewStream((mipoffset), mipZsize, MemoryMappedFileAccess.Read))
                            {
                                new ZlibStream(temp_vs, CompressionMode.Decompress).CopyTo(mipmapstream);
                            }
                            mipmapoffsets.Add(new Tuple<long, long>(beginoffset, mipmapstream.Position - beginoffset));
                        }

                        //assemble mipmaps
                        for (int i = 0; i < 6; i++)
                        {
                            var offset = 0 + (i * imagestream.Length / 6);
                            imagereader.BaseStream.Seek(offset, SeekOrigin.Begin);
                            var facesize = (int)imagestream.Length / 6;
                            var face = imagereader.ReadBytes(facesize);
                            output.Write(face, 0, face.Length);

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

        public string Extract(BundleFileExtractArgs e)
        {
            var newpath = Path.ChangeExtension(e.FileName, "dds");

            // create new directory and delete existing file
            Directory.CreateDirectory(Path.GetDirectoryName(newpath) ?? "");
            if (File.Exists(newpath))
                File.Delete(newpath);

            // extract to dds
            using (var output = new FileStream(newpath, FileMode.Create, FileAccess.Write))
            {
                Extract(output);
            }

            var extractext = e.Extension;
            // do not convert pngs, jpgs and dds
            if (!(Path.GetExtension(e.FileName) == ".dds" || Path.GetExtension(e.FileName) == ".w2l"))
            {
                if (Path.GetExtension(e.FileName) == ".png")
                    extractext = EUncookExtension.png;
                else if (Path.GetExtension(e.FileName) == ".jpg")
                    extractext = EUncookExtension.jpg;


                //convert
                var fi = new FileInfo(newpath);
                if (fi.Exists)
                {
                    TexconvWrapper.Convert(Path.GetDirectoryName(newpath), newpath, extractext);
                }

                // delete old DDS
                fi.Delete();

                
            }

            return newpath;
        }

        void p_Exited(object sender, EventArgs e)
        {
           
        }
    }
}
