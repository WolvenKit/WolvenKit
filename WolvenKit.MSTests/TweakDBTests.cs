using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class TweakDBTests
    {
        private static readonly RecyclableMemoryStreamManager s_streamManager = new();

        [TestMethod]
        public void Serialize_Fundamentals() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IType value, byte[] expected)>
            {
                new (new CBool { Value = false } , new byte[] { 0x00 }),
                new (new CBool { Value = true }, new byte[] { 0x01 }),
                new (new CInt8 { Value = 0x50 }, new byte[] { 0x50 }),
                new (new CUint8 { Value = 0xA0 }, new byte[] { 0xA0 }),
                new (new CInt16 { Value = -0x83 }, new byte[] { 0x7D, 0xFF }),
                new (new CUint16 { Value = 0xFFFF }, new byte[] { 0xFF, 0xFF }),
                new (new CInt32 { Value = 0x7FFFFFFF }, new byte[] { 0xFF, 0xFF, 0xFF, 0x7F }),
                new (new CUint32 { Value = 0xFFFFFFFF }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }),
                new (new CInt64 { Value = 0x7FFFFFFFFFFFFFFF }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF,0xFF, 0xFF, 0xFF, 0x7F }),
                new (new CUint64 { Value = 0xFFFFFFFFFFFFFFFF }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }),
                new (new CFloat { Value = 123.5f }, new byte[] { 0x00, 0x00, 0xF7, 0x42 })
            });

        [TestMethod]
        public void Serialize_Simples() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IType value, byte[] expected)>
            {
                new (new CName { Text = "AName" }, new byte[] { 0x85, 0x41, 0x4E, 0x61, 0x6D, 0x65 }),
                new (new CName { Text = "ScriptGameInstance" }, new byte[] { 0x92, 0x53, 0x63, 0x72, 0x69, 0x70, 0x74, 0x47, 0x61, 0x6D, 0x65, 0x49, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65 }),
                new (new CName { Text = "Color" }, new byte[] { 0x85, 0x43,0x6F, 0x6C, 0x6F, 0x72 }),
                new (new CString { Text = "AString" }, new byte[] { 0x87, 0x41, 0x53, 0x74, 0x72, 0x69, 0x6E, 0x67 }),
                new (new CString { Text = "Hello!" }, new byte[] { 0x86, 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x21 }),
                new (new CString { Text = "This is a longer string :(" }, new byte[] { 0x9A, 0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x61, 0x20, 0x6C, 0x6F, 0x6E, 0x67, 0x65, 0x72, 0x20, 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x3A, 0x28 }),
            });

        [TestMethod]
        public void Serialize_Complexes() =>
            // Parameterized tests do not work, do our own thing then.
            SerializeAndAssert(new List<(IType value, byte[] expected)>
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
                    new CEulerAngles
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
                    new CQuaternion
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
                    new CVector2
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
                    new CVector3
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
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("FirstItem", new CBool { Value = true });
            db.Add("SecondItem", new CInt32 { Value = 500 });

            db.Save(writer);

            var expected = new byte[]
            {
                0x47, 0xDB, 0xB1, 0x0B, // Magic
                0x05, 0x00, 0x00, 0x00, // Blob version
                0x04, 0x00, 0x00, 0x00, // Parser version
                0x00, 0x00, 0x00, 0x00, // Records Checksum
                0x20, 0x00, 0x00, 0x00, // Flats offset
                0x69, 0x00, 0x00, 0x00, // Records offset
                0x6D, 0x00, 0x00, 0x00, // Queries offset
                0x71, 0x00, 0x00, 0x00, // Group tags offset

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
                0x01, 0x00, 0x00, 0x00, // Flats count
                0xED, 0x78, 0x5B, 0xE0, 0x09, 0x00, 0x00, 0x00, // TweakDBID = FirstItem
                0x00, 0x00, 0x00, 0x00, // Value index

                // Int32 values
                0x01, 0x00, 0x00, 0x00, // Count
                0xF4, 0x01, 0x00, 0x00, // Int32 = 500
                0x01, 0x00, 0x00, 0x00, // Flats count
                0x19, 0xE0, 0xE6, 0x44, 0x0A, 0x00, 0x00, 0x00, // TweakDBID = SecondItem
                0x00, 0x00, 0x00, 0x00, // Value index

                // Records
                0x00, 0x00, 0x00, 0x00, // Count

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
            db.Add("FirstItem", new CBool { Value = true });
            db.Add("SecondItem", new CInt32 { Value = 500 });
            db.Add("ThirdItem", new CInt32 { Value = 500 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Serialize_Db_AddItem_Duplicate_ShouldThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("FirstItem", new CBool { Value = true });
            db.Add("FirstItem", new CInt32 { Value = 500 });
        }

        [TestMethod]
        public void Serialize_Db_Name_UnderMaxmimumLength_ShouldNotThrow()
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);

            var db = new TweakDB();
            db.Add("SomeName", new CBool { Value = true });
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

            db.Add(name, new CBool { Value = true });
        }

        private static void SerializeAndAssert(List<(IType value, byte[] expected)> tests)
        {
            foreach (var (value, expected) in tests)
            {
                SerializeAndAssert(value, expected);
            }
        }

        private static void SerializeAndAssert(IType value, byte[] expected)
        {
            using var stream = s_streamManager.GetStream();
            using var writer = new BinaryWriter(stream);
            value.Serialize(writer);

            stream.TryGetBuffer(out var buffer);
            Assert.IsTrue(buffer.SequenceEqual(expected), $"[{value}]: buffer != expected");
        }
    }
}
