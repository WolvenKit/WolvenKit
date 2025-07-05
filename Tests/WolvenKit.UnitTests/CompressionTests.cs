using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Compression;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class CompressionTests
    {
        private const string s_gameDirectorySetting = "GameDirectory";

        private const string s_oodleName = Core.Constants.Oodle;
        private const string s_uncompressedFile = "oodle.txt";
        private const string s_compressedFileSchema = "_oodle.kark";


        [ClassInitialize]
        public static void SetupClass(TestContext _)
        {
            var ass = AppDomain.CurrentDomain.BaseDirectory;
            if (!Oodle.Load())
            {
                Assert.Fail($"Could not load {Core.Constants.Oodle}.");
            }
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        public void Kraken_Decompress(int level)
        {
            var testFile = Path.GetFullPath(Path.Combine("Resources", $"{level}_oodle.kark"));
            var outdir = Path.Combine(Environment.CurrentDirectory, "ooz");
            Directory.CreateDirectory(outdir);

            using var fs = new FileStream(testFile, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);

            var oodleCompression = br.ReadBytes(4);
            if (!oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b }))
            {
                throw new NotImplementedException();
            }
            var size = br.ReadUInt32();
            var buffer = br.ReadBytes((int)fs.Length - 8);

            // oodle
            var outBuffer1 = new byte[size];
            {
                var unpackedSize = Oodle.Decompress(buffer, outBuffer1);

                var outpath = Path.Combine(outdir, "oodle.txt");
                File.WriteAllBytes(outpath, outBuffer1);
            }
#if _WINDOWS
            // kraken
            var outBuffer2 = new byte[size];
            {
                long unpackedSize2 = KrakenNative.Decompress(buffer, outBuffer2);
                var outpath2 = Path.Combine(outdir, "kraken.txt");
                File.WriteAllBytes(outpath2, outBuffer2);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(outBuffer1, outBuffer2));
#endif
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        public void Kraken_Compress(int level)
        {
            var path = Path.GetFullPath(Path.Combine("Resources", s_uncompressedFile));
            var inbuffer = File.ReadAllBytes(path);
            var compressedBufferSizeNeeded = Oodle.GetCompressedBufferSizeNeeded(inbuffer.Length);
            var outdir = Path.Combine(Environment.CurrentDirectory, "ooz");
            Directory.CreateDirectory(outdir);

            // oodle
            //IEnumerable<byte> outBuffer = new List<byte>();
            //var r = Oodle.Compress(inbuffer, ref outBuffer, true, (Oodle.CompressionLevel)level);
            //var outpath = Path.Combine(outdir, $"{level}_oodle.kark");
            //var final = outBuffer.ToArray();
            //File.WriteAllBytes(outpath, final);

#if _WINDOWS
            // kraken
            var outBuffer2 = new byte[compressedBufferSizeNeeded];
            //var outBuffer2 = new byte[inbuffer.Length + 65536];
            var r2 = KrakenNative.Compress(inbuffer, outBuffer2, (int)level);
            var outpath2 = Path.Combine(outdir, $"{(int)level}_kraken.kark");
            var final2 = outBuffer2.Take(r2).ToArray();
            File.WriteAllBytes(outpath2, final2);



            var compareFile = Path.GetFullPath(Path.Combine("Resources", $"{level}_oodle.kark"));
            var compareBytes = File.ReadAllBytes(compareFile);
            Assert.IsTrue(Enumerable.SequenceEqual(final2, compareBytes.Skip(8)));
#endif
        }
    }
}
