using System.IO;
using System.IO.MemoryMappedFiles;
using Doboz;
using Ionic.Zlib;
using LZ4;
using Snappy;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.Bundles
{
    public class BundleItem : IGameFile
    {
        #region Properties

        public ulong Key => FNV1A64HashAlgorithm.HashString(Name);
        public IGameArchive Archive { get; set; }
        public uint Compression { get; set; }

        public string CompressionType
        {
            get
            {
                switch (Compression)
                {
                    case 0:
                        return "None";

                    case 1:
                        return "Zlib";

                    case 2:
                        return "Snappy";

                    case 3:
                        return "Doboz";

                    case 4:
                        return "Lz4";

                    case 5:
                        return "Lz4";

                    default:
                        return "Unknown";
                }
            }
        }

        public uint CRC { get; set; }
        public string DateString { get; set; }
        public uint Empty { get; set; }
        public byte[] Hash { get; set; }
        public string ArchiveName { get; set; }
        public string Name { get; set; }


        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        public long PageOffset { get; set; }

        public uint Size { get; set; }
        public ulong TimeStamp { get; set; }
        public byte[] Zero { get; set; }
        public uint ZSize { get; set; }

        #endregion Properties

        #region Methods

        public string Extension => Path.GetExtension(Name);

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Archive.ArchiveAbsolutePath, FileMode.Open))
            using (var viewstream = file.CreateViewStream(PageOffset, ZSize, MemoryMappedFileAccess.Read))
            {
                switch (CompressionType)
                {
                    case "None":
                    {
                        viewstream.CopyTo(output);
                        break;
                    }
                    case "Lz4":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = LZ4Codec.Decode(buffer, 0, c, (int)Size);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Snappy":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = SnappyCodec.Uncompress(buffer);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Doboz":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = DobozCodec.Decode(buffer, 0, c);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Zlib":
                    {
                        var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);
                        zlib.CopyTo(output);
                        break;
                    }
                    default:
                        throw new MissingCompressionException("Unhandled compression algorithm.")
                        {
                            Compression = Compression
                        };
                }

                viewstream.Close();
            }
        }

        public void ExtractExistingMMF(Stream output)
        {
            // old deprecated way of loading mmfs still used in unit test
            var hash = Archive.ArchiveAbsolutePath.GetHashMD5();
            using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(hash, MemoryMappedFileRights.Read))
                //using (var viewstream = mmf.CreateViewStream(PageOffset, ZSize, MemoryMappedFileAccess.Read))
                ExtractExistingMMF(output, mmf);
        }

        /// <summary>
        /// Extract existing memory-mapped-file,
        /// decompress with the proper algorithm.
        /// </summary>
        /// <param name="output"></param>
        public void ExtractExistingMMF(Stream output, MemoryMappedFile memorymappedbundle)
        {
            /*                var hash = *//*@"Global\" + *//*Archive.FileName.GetHashMD5();
                        System.Console.WriteLine(hash);
                        using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(hash, MemoryMappedFileRights.Read, HandleInheritability.Inheritable))
            */
            using (var viewstream = memorymappedbundle.CreateViewStream(PageOffset, ZSize, MemoryMappedFileAccess.Read))
            {
                switch (CompressionType)
                {
                    case "None":
                    {
                        viewstream.CopyTo(output);
                        break;
                    }
                    case "Lz4":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = LZ4Codec.Decode(buffer, 0, c, (int)Size);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Snappy":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = SnappyCodec.Uncompress(buffer);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Doboz":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = DobozCodec.Decode(buffer, 0, c);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Zlib":
                    {
                        var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);
                        zlib.CopyTo(output);
                        break;
                    }
                    default:
                        throw new MissingCompressionException("Unhandled compression algorithm.")
                        {
                            Compression = Compression
                        };
                }

                viewstream.Close();
            }
        }

        #endregion Methods
    }
}
