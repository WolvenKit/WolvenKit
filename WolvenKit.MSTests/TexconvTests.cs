using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.Core.Compression;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class TexconvTests
    {
        private const string s_gameDirectorySetting = "GameDirectory";

        [ClassInitialize]
        public static void SetupClass(TestContext _)
        {
            
        }

        [TestMethod]
        public void GetMetadataFromDDSFile()
        {
            var testFile = Path.GetFullPath("Resources/q204_columbarium_1080p.dds");
            var md = TexconvNative.GetMetadataFromDDSFile(testFile);

            Assert.IsNotNull(md);
        }

        [TestMethod]
        public void GetMetadataFromTGAFile()
        {
            var testFile = Path.GetFullPath("Resources/q204_columbarium_1080p.tga");
            var md = TexconvNative.GetMetadataFromDDSFile(testFile);

            Assert.IsNotNull(md);
        }

        [TestMethod]
        public void GetMetadataFromDDSMemory()
        {
            var testFile = Path.GetFullPath("Resources/q204_columbarium_1080p.dds");
            var bytes = File.ReadAllBytes(testFile);

            var md = TexconvNative.GetMetadataFromDDSMemory(bytes, bytes.Length);

            Assert.IsNotNull(md);
        }

        [TestMethod]
        public void ConvertFromDdsArray()
        {
            var testFile = Path.GetFullPath("Resources/q204_columbarium_1080p.dds");
            var bytes = File.ReadAllBytes(testFile);

            var pnt = TexconvNative.ConvertFromDdsArray(bytes, bytes.Length, TexconvNative.ESaveFileTypes.TGA);
            //byte[] managedArray = new byte[size];
            //Marshal.Copy(pnt, managedArray, 0, size);

            Assert.IsNotNull(pnt);
        }

        [TestMethod]
        public void ConvertAndSaveDdsImage()
        {
            var testFile = Path.GetFullPath("Resources/q204_columbarium_1080p.dds");
            Directory.CreateDirectory(Path.GetFullPath("out"));
            var outFile = "q204_columbarium_1080p.tga";
            var bytes = File.ReadAllBytes(testFile);

            var pnt = TexconvNative.ConvertAndSaveDdsImage(bytes, bytes.Length, outFile, TexconvNative.ESaveFileTypes.TGA);
        }
    }
}
