using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
//using W3Edit.Textures;
using WolvenKit.Common;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Cache
{
    using DDS;

    public class TextureCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        public string DateString { get; set; }

        public string CompressionType => "Zlib";

        public string ParentFile;

        public string Name { get; set; }
        public Int32 Hash;
        public Int32 PathStringIndex;
        public long PageOFfset { get; set; }
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
        public Int16 Type;
        public Byte IsCube;
        public Byte Unk1;

        public long Size { get; set; }
        public UInt32 ZSize { get; set; }
        public Byte SliceIdx;

        public List<Tuple<uint, uint>> MipMapInfo = new List<Tuple<uint, uint>>();

        public Dictionary<Int16,ETextureFormat> formats = new Dictionary<Int16,ETextureFormat>()
        {
            {0x0,ETextureFormat.TEXFMT_R8G8B8A8}, 
            {0x3FD,ETextureFormat.TEXFMT_R8G8B8A8}, //DDS_RGBA    32  0xff0000 	0xff00 	0xff 	0xff000000
            {0x407,ETextureFormat.TEXFMT_BC1},  //DDS_FOURCC 	"DXT1"
            {0x408,ETextureFormat.TEXFMT_BC3},  //DDS_FOURCC  "DXT5"
            {0x409, ETextureFormat.TEXFMT_BC6H},    
            {0x40A, ETextureFormat.TEXFMT_BC7}, 
            {0x40B,ETextureFormat.TEXFMT_Float_R16G16B16A16},   //DDS_FOURCC 	113
            {0x40C,ETextureFormat.TEXFMT_Float_R32G32B32A32},   //DDS_FOURCC 	116
            {0x40D, ETextureFormat.TEXFMT_BC2}, //DDS_FOURCC  "DXT3"
            {0x40E, ETextureFormat.TEXFMT_BC4}, //DDS_FOURCC  "BC4U"
            {0x40F, ETextureFormat.TEXFMT_BC5}  //DDS_FOURCC  "ATI2"
        };

        public TextureCacheItem(IWitcherArchiveType parent)
        {
            Bundle = parent;
        }

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                // generate header
                ETextureFormat format = formats[Type];
                var metadata = new DDSMetadata(
                    BaseWidth,
                    BaseHeight,
                    (uint)Mipcount,
                    format,
                    BaseAlignment,
                    IsCube == 1,
                    SliceCount,
                    false,
                    false);
                DDSUtils.GenerateAndWriteHeader(output, metadata);

                
                if (IsCube == 0)
                {
                    using (var viewstream = file.CreateViewStream((PageOFfset * 4096) + 9, ZSize, MemoryMappedFileAccess.Read))
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
                        using (var vs = file.CreateViewStream((PageOFfset * 4096) + 9, ZSize, MemoryMappedFileAccess.Read))
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

        public void Extract(string fullpath)
        {
            fullpath = Path.ChangeExtension(fullpath, "dds");

            Directory.CreateDirectory(Path.GetDirectoryName(fullpath) ?? "");
            if (File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }

            using (var output = new FileStream(fullpath, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
            }
        }
    }
}
