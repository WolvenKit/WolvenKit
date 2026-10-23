using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class SaveSerializationTests
    {
        [TestMethod]
        public void Package_NewDynamicPropertySurvivesWriteAndReload()
        {
            var loaded = ReadPackage(WritePackage(new gameSavedStatsData { Seed = 7 }));
            loaded.AddDynamicProperty("addedByEditor", typeof(CUInt32));
            loaded.SetProperty("addedByEditor", (CUInt32)42u);

            var reloaded = ReadPackage(WritePackage(loaded));

            Assert.AreEqual((CUInt32)42u, reloaded.GetProperty("addedByEditor"));
            Assert.AreEqual(7u, (uint)((gameSavedStatsData)reloaded).Seed);
        }

        [TestMethod]
        public void Package_RenamedDynamicPropertySurvivesWriteAndReload()
        {
            var original = new gameSavedStatsData();
            original.AddDynamicProperty("beforeRename", typeof(CUInt32));
            original.SetProperty("beforeRename", (CUInt32)42u);
            var loaded = ReadPackage(WritePackage(original));
            loaded.RenameDynamicProperty("beforeRename", "afterRename");

            var reloaded = ReadPackage(WritePackage(loaded));

            Assert.IsFalse(reloaded.HasProperty("beforeRename"));
            Assert.AreEqual((CUInt32)42u, reloaded.GetProperty("afterRename"));
        }

        [TestMethod]
        public void Package_PreservesPresentDefaultFieldsAndTheirOrder()
        {
            using var stream = new MemoryStream(CreateSlicePayload());
            using var reader = new PersistencySystem2Reader(stream);
            var loaded = new gameBufferSlice();
            reader.ReadClass(loaded, (uint)stream.Length);

            var reloaded = ReadPackage(WritePackage(loaded));

            CollectionAssert.AreEqual(new[] { "combined", "offset" }, reloaded.GetPropertiesInSerializedOrder().Select(x => x.Info.RedName).ToArray());
            Assert.AreEqual((CUInt32)0u, reloaded.GetProperty("offset"));
        }

        [TestMethod]
        public void PS2_AssigningDataUpdatesTypeFiltering()
        {
            var entry = new PS2Entry { Id = 1, Data = new gameSavedStatsData() };
            var system = new PersistencySystem2 { Entries = [entry] };

            Assert.IsTrue(entry.Is<gameSavedStatsData>());
            Assert.AreEqual(1, system.OfType<gameSavedStatsData>().Count());

            entry.Data = new gameBufferSlice();

            Assert.IsFalse(entry.Is<gameSavedStatsData>());
            Assert.IsTrue(entry.Is<gameBufferSlice>());
            Assert.AreEqual(0, system.OfType<gameSavedStatsData>().Count());
            Assert.AreEqual(1, system.OfType<gameBufferSlice>().Count());
        }

        [TestMethod]
        public void PS2_AssigningUnknownDataKeepsItsOriginalHash()
        {
            var hash = SaveHashHelper.GetHashFromType(typeof(gameBufferSlice));
            var entry = new PS2Entry { Id = 1, Data = new UnknownRedClass { Hash = hash, Buffer = [1, 2, 3] } };

            Assert.AreEqual(hash, entry.ClassHash);
            Assert.IsTrue(entry.Is<gameBufferSlice>());
        }

        [TestMethod]
        public void PS2_LazyAndDecodedEntriesPreserveTerminatorPaddingAndFieldOrder()
        {
            var payload = CreateSlicePayload().Concat(new byte[] { 0xAB, 0xCD, 0xEF }).ToArray();
            using var stream = new MemoryStream();
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                writer.Write(0); // ids
                writer.Write(0u);
                writer.Write(1); // entries
                writer.Write(1ul);
                writer.Write(SaveHashHelper.GetHashFromType(typeof(gameBufferSlice)));
                writer.Write(payload.Length);
                writer.Write(payload);
            }
            var original = stream.ToArray();
            stream.Position = 0;
            using var reader = new BinaryReader(stream);
            var parser = new PersistencySystem2Parser();
            var node = new NodeEntry();
            parser.Read(reader, node);
            var entry = ((PersistencySystem2)node.Value).Entries[0];

            Assert.IsFalse(entry.IsDecoded);
            Assert.IsTrue(entry.Is<gameBufferSlice>());
            Assert.IsFalse(entry.IsDecoded);
            CollectionAssert.AreEqual(original, WritePS2(parser, node));
            Assert.IsFalse(entry.IsDecoded);

            Assert.IsInstanceOfType(entry.Data, typeof(gameBufferSlice));
            Assert.IsTrue(entry.IsDecoded);
            CollectionAssert.AreEqual(new byte[8].Concat(new byte[] { 0xAB, 0xCD, 0xEF }).ToArray(), entry.Trailing);
            CollectionAssert.AreEqual(original, WritePS2(parser, node));
        }

        private static byte[] CreateSlicePayload()
        {
            using var stream = new MemoryStream();
            using var writer = new BinaryWriter(stream, Encoding.UTF8, true);
            foreach (var (name, value) in new[] { ("combined", 3u), ("offset", 0u) })
            {
                var property = RedReflection.GetTypeInfo(typeof(gameBufferSlice)).GetPropertyInfoByRedName(name)!;
                writer.Write(FNV1A64HashAlgorithm.HashString(name));
                writer.Write(SaveHashHelper.GetRedTypeHash(property));
                writer.Write(value);
            }
            writer.Write(0ul);
            return stream.ToArray();
        }

        private static byte[] WritePS2(PersistencySystem2Parser parser, NodeEntry node)
        {
            using var stream = new MemoryStream();
            using var writer = new NodeWriter(stream);
            parser.Write(writer, node);
            return stream.ToArray();
        }

        private static byte[] WritePackage(RedBaseClass value)
        {
            using var stream = new MemoryStream();
            using var writer = new RedPackageWriter(stream, Encoding.UTF8, true);
            writer.WritePackage(new RedPackage { Chunks = [value], ChunkDictionary = new() { [value] = 1 } });
            return stream.ToArray();
        }

        private static RedBaseClass ReadPackage(byte[] bytes)
        {
            using var reader = new RedPackageReader(new MemoryStream(bytes));
            var buffer = new RedBuffer();
            reader.ReadBuffer(buffer);
            return ((RedPackage)buffer.Data!).RootChunk;
        }
    }
}
