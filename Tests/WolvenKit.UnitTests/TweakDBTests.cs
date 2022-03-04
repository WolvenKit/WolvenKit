using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class TweakDBTests
    {
        private static readonly RecyclableMemoryStreamManager s_streamManager = new();

        [TestMethod]
        public void Serialize_Fundamentals() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IRedType value, byte[] expected)>
            {
                new ((CBool)false , new byte[] { 0x00 }),
                new ((CBool)true, new byte[] { 0x01 }),
                new ((CInt8)0x50, new byte[] { 0x50 }),
                new ((CUInt8)0xA0, new byte[] { 0xA0 }),
                new ((CInt16)(-0x83), new byte[] { 0x7D, 0xFF }),
                new ((CUInt16)0xFFFF, new byte[] { 0xFF, 0xFF }),
                new ((CInt32)0x7FFFFFFF, new byte[] { 0xFF, 0xFF, 0xFF, 0x7F }),
                new ((CUInt32)0xFFFFFFFF, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }),
                new ((CInt64)0x7FFFFFFFFFFFFFFF, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF,0xFF, 0xFF, 0xFF, 0x7F }),
                new ((CUInt64)0xFFFFFFFFFFFFFFFF, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }),
                new ((CFloat)123.5f, new byte[] { 0x00, 0x00, 0xF7, 0x42 })
            });

        [TestMethod]
        public void Serialize_Simples() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IRedType value, byte[] expected)>
            {
                new ((CName)"AName", new byte[] { 0x85, 0x41, 0x4E, 0x61, 0x6D, 0x65 }),
                new ((CName)"ScriptGameInstance", new byte[] { 0x92, 0x53, 0x63, 0x72, 0x69, 0x70, 0x74, 0x47, 0x61, 0x6D, 0x65, 0x49, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65 }),
                new ((CName)"Color", new byte[] { 0x85, 0x43,0x6F, 0x6C, 0x6F, 0x72 }),
                new ((CString)"AString", new byte[] { 0x87, 0x41, 0x53, 0x74, 0x72, 0x69, 0x6E, 0x67 }),
                new ((CString)"Hello!", new byte[] { 0x86, 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x21 }),
                new ((CString)"This is a longer string :(", new byte[] { 0x9A, 0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x61, 0x20, 0x6C, 0x6F, 0x6E, 0x67, 0x65, 0x72, 0x20, 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x3A, 0x28 }),
            });

        [TestMethod]
        public void Serialize_Complexes() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IRedType value, byte[] expected)>
            {
                new (
                    new CColor
                    {
                        Red = 50,
                        Green = 10,
                        Blue = 255,
                        Alpha = 150
                    },
                    new byte[]
                    {
                        0x00,
                        0x83, 0x52, 0x65, 0x64, 0x85, 0x55, 0x69, 0x6E, 0x74, 0x38, 0x05, 0x00, 0x00, 0x00, 0x32,
                        0x85, 0x47, 0x72, 0x65, 0x65, 0x6E, 0x85, 0x55, 0x69, 0x6E, 0x74, 0x38, 0x05, 0x00, 0x00, 0x00, 0x0A,
                        0x84, 0x42, 0x6C, 0x75, 0x65, 0x85, 0x55, 0x69, 0x6E, 0x74, 0x38, 0x05, 0x00, 0x00, 0x00, 0xFF,
                        0x85, 0x41, 0x6C, 0x70, 0x68, 0x61, 0x85, 0x55, 0x69, 0x6E, 0x74, 0x38, 0x05, 0x00, 0x00, 0x00, 0x96,
                        0x84, 0x4E, 0x6F, 0x6E, 0x65
                    }
                ),
                new (
                    new EulerAngles
                    {
                        Pitch = 150.79f,
                        Yaw = 15.0f,
                        Roll = 360.063f
                    },
                    new byte[]
                    {
                        0x00,
                        0x85, 0x50, 0x69, 0x74, 0x63, 0x68, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x3D, 0xCA, 0x16, 0x43,
                        0x83, 0x59, 0x61, 0x77, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70, 0x41,
                        0x84, 0x52, 0x6F, 0x6C, 0x6C, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x10, 0x08, 0xB4, 0x43,
                        0x84, 0x4E, 0x6F, 0x6E, 0x65
                    }
                ),
                new (
                    new Quaternion
                    {
                        I = 150.79f,
                        J = 15.0f,
                        K = 360.063f,
                        R = 123.321f
                    },
                    new byte[]
                    {
                        0x00,
                        0x81, 0x69, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x3D, 0xCA, 0x16, 0x43,
                        0x81, 0x6A, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70, 0x41,
                        0x81, 0x6B, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x10, 0x08, 0xB4, 0x43,
                        0x81, 0x72, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x5A, 0xA4, 0xF6, 0x42,
                        0x84, 0x4E, 0x6F, 0x6E, 0x65
                    }
                ),
                new (
                    new Vector2
                    {
                        X = 150.79f,
                        Y = 360.063f
                    },
                    new byte[]
                    {
                        0x00,
                        0x81, 0x58, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x3D, 0xCA, 0x16, 0x43,
                        0x81, 0x59, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x10, 0x08, 0xB4, 0x43,
                        0x84, 0x4E, 0x6F, 0x6E, 0x65
                    }
                ),
                new (
                    new Vector3
                    {
                        X = 150.79f,
                        Z = 360.063f,
                        Y = 123.321f
                    },
                    new byte[]
                    {
                        0x00,
                        0x81, 0x58, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x3D, 0xCA, 0x16, 0x43,
                        0x81, 0x59, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x5A, 0xA4, 0xF6, 0x42,
                        0x81, 0x5A, 0x85, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x08, 0x00, 0x00, 0x00, 0x10, 0x08, 0xB4, 0x43,
                        0x84, 0x4E, 0x6F, 0x6E, 0x65
                    }
                )
            });

        [TestMethod]
        public void Serialize_Db_ExpectedOutput()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new TweakDBWriter(stream);

            var db = new TweakDB();
            db.Add("FirstItem", (CBool)true);
            db.Add("SecondItem", (CInt32)500);

            db.Add("PhotoModeBackgrounds.bg_new_bg", new Record
            {
                Type = "PhotoModeBackground",
                Members = new Dictionary<string, IRedType>
                {
                    { "locked", (CBool)true }
                }
            });

            db.Save(writer);

            var expected = new byte[]
            {
                0x47, 0xDB, 0xB1, 0x0B, // Magic
                0x05, 0x00, 0x00, 0x00, // Blob version
                0x04, 0x00, 0x00, 0x00, // Parser version
                0x00, 0x00, 0x00, 0x00, // Records Checksum
                0x20, 0x00, 0x00, 0x00, // Flats offset
                0x75, 0x00, 0x00, 0x00, // Records offset
                0x85, 0x00, 0x00, 0x00, // Queries offset
                0x89, 0x00, 0x00, 0x00, // Group tags offset

                // Flats.
                0x02, 0x00, 0x00, 0x00, // Types count

                // Bool type
                0x9D, 0x88, 0x20, 0xC8, 0xA7, 0xD5, 0xBD, 0xF7, // Name
                0x01, 0x00, 0x00, 0x00, // Count

                // Int32 type
                0xBF, 0x21, 0xA6, 0xB4, 0xF5, 0x27, 0xA1, 0xB9, // Name
                0x01, 0x00, 0x00, 0x00, // Count

                // Bool values
                0x01, 0x00, 0x00, 0x00, // Count
                0x01, // Bool = true
                0x02, 0x00, 0x00, 0x00, // Flats count
                0xED, 0x78, 0x5B, 0xE0, 0x09, 0x00, 0x00, 0x00, // TweakDBID = FirstItem
                0x00, 0x00, 0x00, 0x00, // Value index
                0x20, 0x81, 0xD4, 0xCA, 0x25, 0x00, 0x00, 0x00, // TweakDBID = PhotoModeBackgrounds.bg_new_bg.locked
                0x00, 0x00, 0x00, 0x00, // Value index

                // Int32 values
                0x01, 0x00, 0x00, 0x00, // Count
                0xF4, 0x01, 0x00, 0x00, // Int32 = 500
                0x01, 0x00, 0x00, 0x00, // Flats count
                0x19, 0xE0, 0xE6, 0x44, 0x0A, 0x00, 0x00, 0x00, // TweakDBID = SecondItem
                0x00, 0x00, 0x00, 0x00, // Value index

                // Records
                0x01, 0x00, 0x00, 0x00, // Count
                0xDC, 0x3C, 0x3D, 0x36, 0x1E, 0x00, 0x00, 0x00, // TweakDBID = PhotoModeBackgrounds.bg_new_bg
                0xE1, 0x79, 0x4E, 0xEA,
                
                // Queries
                0x00, 0x00, 0x00, 0x00, // Count

                // Group tags
                0x00, 0x00, 0x00, 0x00, // Count
            };

            stream.TryGetBuffer(out var buffer);
            Assert.IsTrue(buffer.SequenceEqual(expected), "buffer != expected");
        }

        [TestMethod]
        public void Serialize_Db_AddItem_Unique_ShouldNotThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("FirstItem", (CBool)true);
            db.Add("SecondItem", (CInt32)500);
            db.Add("ThirdItem", (CInt32)500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Serialize_Db_AddItem_Duplicate_ShouldThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("FirstItem", (CBool)true);
            db.Add("FirstItem", (CInt32)500);
        }

        [TestMethod]
        public void Serialize_Db_Name_UnderMaxmimumLength_ShouldNotThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("SomeName", (CBool)true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Serialize_Db_Name_TooLong_ShouldThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();

            var name = string.Empty;
            for (var i = 0; i <= byte.MaxValue; i++)
            {
                name += i.ToString();
            }

            db.Add(name, (CBool)true);
        }

        private static void SerializeAndAssert(List<(IRedType value, byte[] expected)> tests)
        {
            foreach (var (value, expected) in tests)
            {
                SerializeAndAssert(value, expected);
            }
        }

        private static void SerializeAndAssert(IRedType value, byte[] expected)
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new TweakDBWriter(stream);
            writer.Write(value);

            stream.TryGetBuffer(out var buffer);
            Assert.IsTrue(buffer.SequenceEqual(expected), $"[{value}]: buffer != expected");
        }
    }
}
