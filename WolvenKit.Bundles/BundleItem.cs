using System.IO;
using System.IO.MemoryMappedFiles;
using Doboz;
using Ionic.Zlib;
using LZ4;
using Snappy;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;

namespace WolvenKit.Bundles
{
    public class BundleItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        public string Name { get; set; }
        public byte[] Hash { get; set; }
        public uint Empty { get; set; }
        public long Size { get; set; }
        public uint ZSize { get; set; }
        public long PageOFfset { get; set; }
        public ulong TimeStamp { get; set; }
        public byte[] Zero { get; set; }
        public uint CRC { get; set; }
        public uint Compression { get; set; }
        public string DateString { get; set; }

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

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Bundle.FileName, FileMode.Open))
            using (var viewstream = file.CreateViewStream(PageOFfset, ZSize, MemoryMappedFileAccess.Read))
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
                        var uncompressed = LZ4Codec.Decode(buffer, 0, c, (int) Size);
                        output.Write(uncompressed, 0, uncompressed.Length);
                        break;
                    }
                    case "Snappy":
                    {
                        var buffer = new byte[ZSize];
                        var c = viewstream.Read(buffer, 0, buffer.Length);
                        var uncompressed = SnappyCodec.Uncompress(buffer);
                        output.Write(uncompressed,0,uncompressed.Length);
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

        public string Extract(BundleFileExtractArgs e)
        {
            using (var output = new FileStream(e.FileName, FileMode.Create, FileAccess.Write))
            {
                Extract(output);
                output.Close();
            }

            return e.FileName;
        }
    }
}