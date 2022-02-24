using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Murmur3;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class Murmur3Tests
    {
        private const uint s_seed = 0x5EEDBA5E;

        [TestMethod]
        [DataRow("This is a longer string than usual.", 0x85D823B6u)]
        [DataRow("Hello!", 0xFA23C62Fu)]
        [DataRow("Records", 0x92C1A109u)]
        [DataRow("TweakDB", 0xF1851BEBu)]
        [DataRow("WolvenKit", 0x131C522Fu)]
        public void Murmur3_32(string source, uint expected)
        {
            var hash = Murmur32.Hash(source, s_seed);
            var expectedBytes = BitConverter.GetBytes(expected);
            var hashBytes = BitConverter.GetBytes(hash);

            Assert.IsTrue(hashBytes.SequenceEqual(expectedBytes), $"{hash} != {expected}");
        }
    }
}
