using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common;
using WolvenKit.Common.DDS;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class TexconvTests
    {
        private const string s_gameDirectorySetting = "GameDirectory";
        private TexconvNative.TexMetadata s_dds_md = new()
        {
            width = 796,
            height = 300,
            depth = 1,
            arraySize = 1,
            mipLevels = 1,
            miscFlags = 0,
            miscFlags2 = 0,
            format = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM,
            dimension = TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D
        };
        private const int s_ddsBpp = 8;
        private TexconvNative.TexMetadata s_tga_md = new()
        {
            width = 796,
            height = 300,
            depth = 1,
            arraySize = 1,
            mipLevels = 1,
            miscFlags = 0,
            miscFlags2 = 0,
            format = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
            dimension = TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D
        };
        private const int s_tgaBpp = 32;

        private const string testFile1 = "q204_columbarium_1080p";
        private const string testFile2 = "h0_001_wa_c__judy_d02";

        public string GetTestFile() => testFile2;

        [ClassInitialize]
        public static void SetupClass(TestContext _)
        {

        }

        [TestMethod]
        public void GetMetadataFromDDSFile()
        {
            var testFile = Path.GetFullPath($"Resources/{testFile1}.dds");
            //var md = TexconvNative.GetMetadataFromDDSFile(testFile);

            //Assert.AreEqual(md, s_dds_md);

            //var bpp = TexconvNative.BitsPerPixel(md.format);
            //Assert.AreEqual((int)bpp, s_ddsBpp);

            var md = Texconv.GetMetadataFromDDSFile(testFile);
            Assert.AreEqual(md, new DDSMetadata(s_dds_md, s_ddsBpp, true));

        }
        [TestMethod]
        public void GetMetadataFromDDSMemory()
        {
            var testFile = Path.GetFullPath($"Resources/{testFile1}.dds");
            var bytes = File.ReadAllBytes(testFile);

            //var md = TexconvNative.GetMetadataFromDDSMemory(bytes, bytes.Length);
            //Assert.AreEqual(md, s_dds_md);

            //var bpp = TexconvNative.BitsPerPixel(md.format);
            //Assert.AreEqual((int)bpp, s_ddsBpp);

            var md = Texconv.GetMetadataFromDDSMemory(bytes);
            Assert.AreEqual(md, new DDSMetadata(s_dds_md, s_ddsBpp, true));
        }

        [TestMethod]
        public void GetMetadataFromTGAFile()
        {
            var testFile = Path.GetFullPath($"Resources/{testFile1}.tga");

            //var md = TexconvNative.GetMetadataFromTGAFile(testFile);
            //Assert.AreEqual(md, s_tga_md);

            //var bpp = TexconvNative.BitsPerPixel(md.format);
            //Assert.AreEqual((int)bpp, s_tgaBpp);

            var md = Texconv.GetMetadataFromTGAFile(testFile);
            Assert.AreEqual(md, new DDSMetadata(s_tga_md, s_tgaBpp, true));
        }

        [TestMethod]
        public void ComputePitch()
        {
            var testFile = Path.GetFullPath($"Resources/{testFile1}.dds");
            var md = Texconv.GetMetadataFromDDSFile(testFile);

            // slicepitch 1048576
            var slicepitch = Texconv.ComputeSlicePitch((int)md.Width, (int)md.Height, md.Format);
            Assert.AreEqual(238800, slicepitch);

            //rowpitch 
            var rowpitch = Texconv.ComputeRowPitch((int)md.Width, (int)md.Height, md.Format);
            Assert.AreEqual(3184, rowpitch);
        }

        [TestMethod]
        public void ConvertAndSaveDdsImage()
        {
            var testFile = Path.GetFullPath($"Resources/{testFile1}.dds");
            Directory.CreateDirectory(Path.GetFullPath("texc"));
            var bytes = File.ReadAllBytes(testFile);

            var outFile2 = Path.GetFullPath(Path.Combine("texc", $"{GetTestFile()}.tga"));
            using var ms = new MemoryStream(bytes);
            ms.Seek(0, SeekOrigin.Begin);
            Assert.IsTrue(Texconv.ConvertFromDdsAndSave(ms, outFile2, TexconvNative.ESaveFileTypes.TGA, true));

            // verify
            var metadata = new TexconvNative.TexMetadata()
            {
                width = 796,
                height = 300,
                depth = 1,
                arraySize = 1,
                mipLevels = 1,
                miscFlags = 0,
                miscFlags2 = 0,
                format = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
                dimension = TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D
            };

            var md2 = Texconv.GetMetadataFromTGAFile(outFile2);
            Assert.AreEqual(md2, new DDSMetadata(metadata, 32, true));
        }

        [TestMethod]
        [DataRow(EUncookExtension.bmp)]
        [DataRow(EUncookExtension.jpg)]
        [DataRow(EUncookExtension.png)]
        [DataRow(EUncookExtension.tga)]
        [DataRow(EUncookExtension.tiff)]
        public void ConvertFromDds(EUncookExtension type)
        {
            var testFile = Path.GetFullPath($"Resources/{GetTestFile()}.dds");
            var bytes = File.ReadAllBytes(testFile);

            //foreach (var type in Enum.GetValues<EUncookExtension>())
            {
                var outFile = Path.GetFullPath(Path.Combine("texc", $"{GetTestFile()}.{type.ToString()}"));

                //var blob = new TexconvNative.Blob();
                //var len = TexconvNative.ConvertFromDds(bytes, ref blob, Texconv.ToSaveFormat(type));

                using var ms = new MemoryStream(bytes);
                var buffer = Texconv.ConvertFromDds(ms, type);

                File.WriteAllBytes(outFile, buffer);
            }

        }

        [TestMethod]
        [DataRow(EUncookExtension.bmp)]
        [DataRow(EUncookExtension.jpg)]
        [DataRow(EUncookExtension.png)]
        [DataRow(EUncookExtension.tga)]
        [DataRow(EUncookExtension.tiff)]
        public void ConvertToDds(EUncookExtension type)
        {
            var testFile = Path.GetFullPath($"Resources/{GetTestFile()}.{type.ToString()}");
            Directory.CreateDirectory(Path.GetFullPath("texc"));
            var bytes = File.ReadAllBytes(testFile);

            //var blob = new TexconvNative.Blob();
            //var len = TexconvNative.ConvertToDds(bytes, ref blob, TexconvNative.ESaveFileTypes.TGA, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN);
            //var outFile = Path.GetFullPath(Path.Combine("texc", "q204_columbarium_1080p_0.dds"));
            //File.WriteAllBytes(outFile, blob.GetBytes());

            var ms = new MemoryStream(bytes);

            ms.Seek(0, SeekOrigin.Begin);
            var r1 = Texconv.ConvertToDds(ms, type, DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM);
            var outFile1 = Path.GetFullPath(Path.Combine("texc", $"{GetTestFile()}_1.{type}.dds"));
            File.WriteAllBytes(outFile1, r1);

            ms.Seek(0, SeekOrigin.Begin);
            var r3 = Texconv.ConvertToDds(ms, type, DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM);
            var outFile3 = Path.GetFullPath(Path.Combine("texc", $"{GetTestFile()}_3.{type}.dds"));
            File.WriteAllBytes(outFile3, r3);

            ms.Seek(0, SeekOrigin.Begin);
            var r7 = Texconv.ConvertToDds(ms, type, DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM);
            var outFile7 = Path.GetFullPath(Path.Combine("texc", $"{GetTestFile()}_7.{type}.dds"));
            File.WriteAllBytes(outFile7, r7);
        }


    }
}
