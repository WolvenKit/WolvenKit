using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Oodle;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.Common.RED4.Archive
{
    public class LxrsFooter
    {
        public const int MIN_LENGTH = 20;

        public const uint s_magic = 0x4C585253; //1397905484;
        private const uint s_version = 1;


        private readonly List<string> _fileInfos;

        public LxrsFooter(List<string> fileInfos)
        {
            _fileInfos = fileInfos;
        }

        public List<string> FileInfos => _fileInfos;

        public void Write(BinaryWriter bw)
        {
            bw.Write(LxrsFooter.s_magic);
            bw.Write(LxrsFooter.s_version);

            using var ms = new MemoryStream();
            using var tempBw = new BinaryWriter(ms);
            foreach (var s in FileInfos)
            {
                tempBw.WriteCR2WString(s);
            }

            var inbuffer = ms.ToByteArray();

            IEnumerable<byte> outBuffer = new List<byte>();
            var r = OodleHelper.Compress(
                inbuffer,
                inbuffer.Length,
                ref outBuffer,
                OodleNative.OodleLZ_Compressor.Kraken,
                OodleNative.OodleLZ_Compression.Normal,
                false);

            bw.Write(inbuffer.Length);      //size
            bw.Write(outBuffer.Count());    //zsize
            bw.Write(FileInfos.Count());    //count
            bw.Write(outBuffer.ToArray());
        }

        public void Read(BinaryReader br)
        {
            var magic = br.ReadUInt32();
            if (magic != s_magic)
            {
                throw new InvalidParsingException("not a valid Archive");
            }

            var version = br.ReadUInt32();
            var size = br.ReadInt32();
            var zsize = br.ReadInt32();
            var count = br.ReadInt32();

            var inbuffer = br.ReadBytes(zsize);

            if (size > zsize)
            {
                // buffer is compressed
                var outBuffer = new byte[size];
                var r = OodleHelper.Decompress(inbuffer, outBuffer);
                using var ms = new MemoryStream(outBuffer);
                using var tempbr = new BinaryReader(ms);
                for (var i = 0; i < count; i++)
                {
                    FileInfos.Add(tempbr.ReadCR2WString());
                }
            }
            else if (size < zsize)
            {
                // error
                // extract as .bin file
            }
            else
            {
                // no compression
                using var ms = new MemoryStream(inbuffer);
                using var tempbr = new BinaryReader(ms);
                for (var i = 0; i < count; i++)
                {
                    FileInfos.Add(tempbr.ReadCR2WString());
                }
            }
        }
    }
}
