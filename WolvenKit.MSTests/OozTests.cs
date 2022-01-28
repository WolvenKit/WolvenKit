using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Compression;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class OozTests
    {
        private const string s_gameDirectorySetting = "GameDirectory";

        [ClassInitialize]
        public static void SetupClass(TestContext _)
        {
            #region oodle
            var s_config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var s_gameDirectoryPath = "";
            var cp77Dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(cp77Dir) && new DirectoryInfo(cp77Dir).Exists)
            {
                s_gameDirectoryPath = cp77Dir;
            }
            else
            {
                s_gameDirectoryPath = s_config.GetSection(s_gameDirectorySetting).Value;
            }
            var gameDirectory = new DirectoryInfo(s_gameDirectoryPath);
            var gameBinDir = new DirectoryInfo(Path.Combine(gameDirectory.FullName, "bin", "x64"));
            var oodleInfo = new FileInfo(Path.Combine(gameBinDir.FullName, "oo2ext_7_win64.dll"));
            if (!oodleInfo.Exists)
            {
                Assert.Fail("Could not find oo2ext_7_win64.dll.");
            }
            var ass = AppDomain.CurrentDomain.BaseDirectory;
            var appOodleFileName = Path.Combine(ass, "oo2ext_7_win64.dll");
            if (!File.Exists(appOodleFileName))
            {
                oodleInfo.CopyTo(appOodleFileName);
            }

            if (!OodleLib.Load(appOodleFileName))
            {
                Assert.Fail("Could not load oo2ext_7_win64.dll.");
            }

            var kraken = Path.Combine(ass,"lib", "kraken.dll");
            if (!KrakenLib.Load(kraken))
            {
                Assert.Fail("Could not load kraken.dll.");
            }

            #endregion
        }

        [TestMethod]
        public void Kraken_Decompress()
        {
            var testFile = Path.GetFullPath("Resources/oodle.kark");
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
                long unpackedSize = Oodle.Decompress(buffer, outBuffer1);

                var outpath = Path.Combine(outdir, "oodle.txt");
                File.WriteAllBytes(outpath, outBuffer1);
            }

            // kraken
            var outBuffer2 = new byte[size];
            {
                long unpackedSize2 = KrakenLib.Decompress(buffer, outBuffer2);
                var outpath2 = Path.Combine(outdir, "kraken.txt");
                File.WriteAllBytes(outpath2, outBuffer2);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(outBuffer1, outBuffer2));
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
            var path = Path.GetFullPath("Resources/oodle.txt");
            var inbuffer = File.ReadAllBytes(path);
            var compressedBufferSizeNeeded = Oodle.GetCompressedBufferSizeNeeded(inbuffer.Length);
            var outdir = Path.Combine(Environment.CurrentDirectory, "ooz");
            Directory.CreateDirectory(outdir);

            // oodle
            IEnumerable<byte> outBuffer = new List<byte>();
            var r = Oodle.Compress(inbuffer,ref outBuffer, false, (OodleLZNative.CompressionLevel)level);
            var outpath = Path.Combine(outdir, $"{(int)level}_oodle.kark");
            var final = outBuffer.ToArray();
            File.WriteAllBytes(outpath, final);

            //// oodle native
            //var outBuffer1 = new byte[compressedBufferSizeNeeded];
            //var r1 = OodleLZNative.Compress(OodleLZNative.Compressor.Kraken, inbuffer, inbuffer.Length, outBuffer1, (OodleLZNative.CompressionLevel)level);
            //var outpath1 = Path.Combine(outdir, $"{(int)level}_noodle.kark");
            //var final1 = outBuffer.ToArray();
            //File.WriteAllBytes(outpath1, final1);

            // kraken
            var outBuffer2 = new byte[compressedBufferSizeNeeded];
            //var outBuffer2 = new byte[inbuffer.Length + 65536];
            var r2 = KrakenLib.Compress(inbuffer, outBuffer2, (int)level);
            var outpath2 = Path.Combine(outdir, $"{(int)level}_kraken.kark");
            var final2 = outBuffer2.Take(r2).ToArray();
            File.WriteAllBytes(outpath2, final2);
            
            //Assert.IsTrue(Enumerable.SequenceEqual(final, final1));
            //Assert.IsTrue(Enumerable.SequenceEqual(final1, final2));
            Assert.IsTrue(Enumerable.SequenceEqual(final, final2));
        }
    }
}
