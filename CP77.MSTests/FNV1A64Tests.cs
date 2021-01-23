using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;

namespace CP77.MSTests
{
    [TestClass]
    public class FNV1A64Tests
    {
        [TestMethod]
        [DataRow("", 0xcbf29ce484222325UL)]
        [DataRow("a", 0xaf63dc4c8601ec8cUL)]
        [DataRow("foobar", 0x85944171f73967e8UL)]
        [DataRow("\0", 0xaf63bd4c8601b7dfUL)]
        [DataRow("a\0", 0x089be207b544f1e4UL)]
        [DataRow("foobar\0", 0x34531ca7168b8f38UL)]
        [DataRow("hi", 0x08ba5f07b55ec3daUL)]
        [DataRow("hi\0", 0x337354193006cb6eUL)]
        [DataRow("hello", 0xa430d84680aabd0bUL)]
        [DataRow("hello\0", 0xa9bc8acca21f39b1UL)]
        [DataRow("127.0.0.1", 0xaabafe7104d914beUL)]
        [DataRow("127.0.0.1\0", 0xf4d3180b3cde3edaUL)]
        [DataRow("127.0.0.2", 0xaabafd7104d9130bUL)]
        [DataRow("127.0.0.2\0", 0xf4cfb20b3cdb5bb1UL)]
        [DataRow("127.0.0.3", 0xaabafc7104d91158UL)]
        [DataRow("127.0.0.3\0", 0xf4cc4c0b3cd87888UL)]
        [DataRow("feedfacedeadbeef", 0xcac54572bb1a6fc8UL)]
        [DataRow("feedfacedeadbeef\0", 0xa7a4c9f3edebf0d8UL)]
        [DataRow("line 1\nline 2\nline 3", 0x7829851fac17b143UL)]
        public void TestFNV1a64(string test, ulong result)
        {
            // Assert.AreEqual(FNV1A64HashAlgorithm.HashString(test), result);
            Assert.AreEqual(FNV1A64HashAlgorithm.HashString(test), result);
        }

        [TestMethod]
        [DataRow("", 0xaf63bd4c8601b7dfUL)]
        [DataRow("a", 0x089be207b544f1e4UL)]
        [DataRow("hi", 0x337354193006cb6eUL)]
        [DataRow("hello", 0xa9bc8acca21f39b1UL)]
        [DataRow("foobar", 0x34531ca7168b8f38UL)]
        [DataRow("feedfacedeadbeef", 0xa7a4c9f3edebf0d8UL)]
        public void TestFNV1a64_NullEnded(string test, ulong result)
        {
            Assert.AreEqual(FNV1A64HashAlgorithm.HashString(test, Encoding.ASCII, true), result);
        }

        [TestMethod]
        [DataRow(new byte[] {0xff, 0x00, 0x00, 0x01}, 0x6961196491cc682dUL)]
        [DataRow(new byte[] {0x01, 0x00, 0x00, 0xff}, 0xad2bb1774799dfe9UL)]
        [DataRow(new byte[] {0xff, 0x00, 0x00, 0x02}, 0x6961166491cc6314UL)]
        [DataRow(new byte[] {0x02, 0x00, 0x00, 0xff}, 0x8d1bb3904a3b1236UL)]
        [DataRow(new byte[] {0xff, 0x00, 0x00, 0x03}, 0x6961176491cc64c7UL)]
        [DataRow(new byte[] {0x03, 0x00, 0x00, 0xff}, 0xed205d87f40434c7UL)]
        [DataRow(new byte[] {0xff, 0x00, 0x00, 0x04}, 0x6961146491cc5faeUL)]
        [DataRow(new byte[] {0x04, 0x00, 0x00, 0xff}, 0xcd3baf5e44f8ad9cUL)]
        [DataRow(new byte[] {0x40, 0x51, 0x4e, 0x44}, 0xe3b36596127cd6d8UL)]
        [DataRow(new byte[] {0x44, 0x4e, 0x51, 0x40}, 0xf77f1072c8e8a646UL)]
        [DataRow(new byte[] {0x40, 0x51, 0x4e, 0x4a}, 0xe3b36396127cd372UL)]
        [DataRow(new byte[] {0x4a, 0x4e, 0x51, 0x40}, 0x6067dce9932ad458UL)]
        [DataRow(new byte[] {0x40, 0x51, 0x4e, 0x54}, 0xe3b37596127cf208UL)]
        [DataRow(new byte[] {0x54, 0x4e, 0x51, 0x40}, 0x4b7b10fa9fe83936UL)]
        public void TestFNV1a64_ByteSpan(byte[] test, ulong result)
        {
            Assert.AreEqual(FNV1A64HashAlgorithm.HashReadOnlySpan(test), result);
        }       
        
        [TestMethod]
        [DataRow("\xff\x00\x00\x01", 0x6961196491cc682dUL)]
        [DataRow("\x01\x00\x00\xff", 0xad2bb1774799dfe9UL)]
        [DataRow("\xff\x00\x00\x02", 0x6961166491cc6314UL)]
        [DataRow("\x02\x00\x00\xff", 0x8d1bb3904a3b1236UL)]
        [DataRow("\xff\x00\x00\x03", 0x6961176491cc64c7UL)]
        [DataRow("\x03\x00\x00\xff", 0xed205d87f40434c7UL)]
        [DataRow("\xff\x00\x00\x04", 0x6961146491cc5faeUL)]
        [DataRow("\x04\x00\x00\xff", 0xcd3baf5e44f8ad9cUL)]
        [DataRow("\x40\x51\x4e\x44", 0xe3b36596127cd6d8UL)]
        [DataRow("\x44\x4e\x51\x40", 0xf77f1072c8e8a646UL)]
        [DataRow("\x40\x51\x4e\x4a", 0xe3b36396127cd372UL)]
        [DataRow("\x4a\x4e\x51\x40", 0x6067dce9932ad458UL)]
        [DataRow("\x40\x51\x4e\x54", 0xe3b37596127cf208UL)]
        [DataRow("\x54\x4e\x51\x40", 0x4b7b10fa9fe83936UL)]
        [DataRow("", 0xcbf29ce484222325UL)]
        [DataRow("a", 0xaf63dc4c8601ec8cUL)]
        [DataRow("foobar", 0x85944171f73967e8UL)]
        [DataRow("\0", 0xaf63bd4c8601b7dfUL)]
        [DataRow("a\0", 0x089be207b544f1e4UL)]
        [DataRow("foobar\0", 0x34531ca7168b8f38UL)]
        [DataRow("hi", 0x08ba5f07b55ec3daUL)]
        [DataRow("hi\0", 0x337354193006cb6eUL)]
        [DataRow("hello", 0xa430d84680aabd0bUL)]
        [DataRow("hello\0", 0xa9bc8acca21f39b1UL)]
        [DataRow("127.0.0.1", 0xaabafe7104d914beUL)]
        [DataRow("127.0.0.1\0", 0xf4d3180b3cde3edaUL)]
        [DataRow("127.0.0.2", 0xaabafd7104d9130bUL)]
        [DataRow("127.0.0.2\0", 0xf4cfb20b3cdb5bb1UL)]
        [DataRow("127.0.0.3", 0xaabafc7104d91158UL)]
        [DataRow("127.0.0.3\0", 0xf4cc4c0b3cd87888UL)]
        [DataRow("feedfacedeadbeef", 0xcac54572bb1a6fc8UL)]
        [DataRow("feedfacedeadbeef\0", 0xa7a4c9f3edebf0d8UL)]
        [DataRow("line 1\nline 2\nline 3", 0x7829851fac17b143UL)]
        public void TestFNV1a64_CharSpan(string test, ulong result)
        {
            Assert.AreEqual(FNV1A64HashAlgorithm.HashReadOnlySpan(test.AsSpan()), result);
        }
    }
}