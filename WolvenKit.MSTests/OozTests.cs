using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Tools.Oodle;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class OozTests
    {
        private const string s_gameDirectorySetting = "GameDirectory";

        [ClassInitialize]
        public static void SetupClass(TestContext context)
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
            if (!OodleLoadLib.Load(appOodleFileName))
            {
                Assert.Fail("Could not load oo2ext_7_win64.dll.");
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
            if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
            {
                throw new NotImplementedException();
            }
            var size = br.ReadUInt32();
            var buffer = br.ReadBytes((int)fs.Length - 8);

            // oodle
            var outBuffer1 = new byte[size];
            {
                long unpackedSize = OodleHelper.Decompress(buffer, outBuffer1);
               
                var outpath = Path.Combine(outdir, "oodle.txt");
                File.WriteAllBytes(outpath, outBuffer1);
            }

            // ooz
            var outBuffer2 = new byte[size];
            {
                long unpackedSize2 = OozNative.Kraken_Decompress(buffer, buffer.Length, outBuffer2, outBuffer2.Length);
                var outpath2 = Path.Combine(outdir, "ooz.txt");
                File.WriteAllBytes(outpath2, outBuffer2);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(outBuffer1, outBuffer2));
        }

        [TestMethod]
        public void Kraken_Compress()
        {
            var path = Path.GetFullPath("Resources/oodle.txt");
            var inbuffer = File.ReadAllBytes(path);
            var outdir = Path.Combine(Environment.CurrentDirectory, "ooz");
            Directory.CreateDirectory(outdir);

            //oodle
            IEnumerable<byte> outBuffer1 = new List<byte>();
            {
                var r = OodleHelper.Compress(
                    inbuffer,
                    inbuffer.Length,
                    ref outBuffer1,
                    OodleNative.OodleLZ_Compressor.Kraken,
                    OodleNative.OodleLZ_Compression.Normal,
                    true);
                var outpath = Path.Combine(outdir, "oodle.kark");
                File.WriteAllBytes(outpath, outBuffer1.ToArray());
            }

            //ooz
            IEnumerable<byte> outBuffer2 = new List<byte>();
            {
                var r2 = OozNative.Kraken_Compress(inbuffer, inbuffer.Length, outBuffer2.ToArray());
                var outpath = Path.Combine(outdir, "ooz.kark");
                File.WriteAllBytes(outpath, outBuffer2.ToArray());
            }
            Assert.IsTrue(Enumerable.SequenceEqual(outBuffer1, outBuffer2));
        }
    }
}
