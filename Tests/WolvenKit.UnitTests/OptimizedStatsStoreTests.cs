using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class OptimizedStatsStoreTests
    {
        private const ulong s_firstEntity = 1;
        private const ulong s_secondEntity = 2;

        [TestMethod]
        public void CreatedEntity_RoundTripsThroughSharedTables()
        {
            var map = new gameStatsStateMapStructure();

            var store = new OptimizedStatsStore(map);
            store.Create(gameStatIDType.EntityID, s_firstEntity, CreateStats(seed: 7, modifiers: [Modifier(5)], forced: [Modifier(20)]));
            store.Commit();

            Assert.IsTrue(store.IsOptimized);
            Assert.AreEqual(2, map.SharedBufferSlices.Count);
            Assert.AreEqual(1, map.SharedBufferSlices.Count(x => (x.Combined & OptimizedStatsStore.ForcedSliceFlag) != 0));

            var data = new OptimizedStatsStore(map).Get(gameStatIDType.EntityID, s_firstEntity);

            Assert.IsNotNull(data);
            Assert.AreEqual(7u, (uint)data.Seed);
            Assert.AreEqual((TweakDBID)"Character.Player", data.RecordID);
            CollectionAssert.AreEqual(new[] { gamedataStatType.Strength }, data.InactiveStats.Select(x => (gamedataStatType)x).ToArray());
            CollectionAssert.AreEqual(new[] { 5f }, Values(data.ModifiersBuffer));
            CollectionAssert.AreEqual(new[] { 20f }, Values(data.ForcedModifiersBuffer));
        }

        [TestMethod]
        public void IdenticalModifierLists_ShareOneSlice()
        {
            var map = CreateMapWithTwoEntities();

            var first = map.ValuesOptimized.Single(x => x.EntityHash == s_firstEntity);
            var second = map.ValuesOptimized.Single(x => x.EntityHash == s_secondEntity);

            Assert.AreEqual(1, map.SharedBufferSlices.Count);
            CollectionAssert.AreEqual(first.BufferSliceIndices.ToArray(), second.BufferSliceIndices.ToArray());
            Assert.AreEqual(1, map.SharedRecordId.Count);
        }

        [TestMethod]
        public void EditingSharedSlice_CopiesOnWrite()
        {
            var map = CreateMapWithTwoEntities();
            var originalSlice = map.SharedBufferSlices[0];
            var originalLength = (int)(originalSlice.Combined & OptimizedStatsStore.SliceSizeMask);
            var originalBytes = map.SharedDataBuffer.Buffer.GetBytes().Take(originalLength).ToArray();

            var store = new OptimizedStatsStore(map);
            var data = store.Get(gameStatIDType.EntityID, s_firstEntity)!;
            ((ModifiersBuffer)data.ModifiersBuffer.Data!).Entries.Add(Modifier(1));
            store.Commit();

            Assert.AreEqual(2, map.SharedBufferSlices.Count);
            Assert.AreEqual(originalSlice.Offset, map.SharedBufferSlices[0].Offset);
            Assert.AreEqual(originalSlice.Combined, map.SharedBufferSlices[0].Combined);
            CollectionAssert.AreEqual(originalBytes, map.SharedDataBuffer.Buffer.GetBytes().Take(originalLength).ToArray());

            var reloaded = new OptimizedStatsStore(map);
            CollectionAssert.AreEqual(new[] { 5f, 1f }, Values(reloaded.Get(gameStatIDType.EntityID, s_firstEntity)!.ModifiersBuffer));
            CollectionAssert.AreEqual(new[] { 5f }, Values(reloaded.Get(gameStatIDType.EntityID, s_secondEntity)!.ModifiersBuffer));
        }

        [TestMethod]
        public void UnchangedEntities_AreNotWritten()
        {
            var map = CreateMapWithTwoEntities();
            var arena = map.SharedDataBuffer.Buffer.GetBytes();
            var sliceCount = map.SharedBufferSlices.Count;

            var store = new OptimizedStatsStore(map);
            store.Get(gameStatIDType.EntityID, s_firstEntity);
            store.Get(gameStatIDType.EntityID, s_secondEntity);

            Assert.IsFalse(store.HasChanges);

            store.Commit();

            Assert.AreSame(arena, map.SharedDataBuffer.Buffer.GetBytes());
            Assert.AreEqual(sliceCount, map.SharedBufferSlices.Count);
        }

        private static gameStatsStateMapStructure CreateMapWithTwoEntities()
        {
            var map = new gameStatsStateMapStructure();

            var store = new OptimizedStatsStore(map);
            store.Create(gameStatIDType.EntityID, s_firstEntity, CreateStats(seed: 1, modifiers: [Modifier(5)], forced: []));
            store.Create(gameStatIDType.EntityID, s_secondEntity, CreateStats(seed: 2, modifiers: [Modifier(5)], forced: []));
            store.Commit();

            return map;
        }

        private static gameSavedStatsData CreateStats(uint seed, gameStatModifierData_Deprecated[] modifiers, gameStatModifierData_Deprecated[] forced)
        {
            var data = new gameSavedStatsData
            {
                Seed = seed,
                RecordID = "Character.Player",
                ModifiersBuffer = new DataBuffer { Data = new ModifiersBuffer { Entries = modifiers.ToList() } },
                ForcedModifiersBuffer = new DataBuffer { Data = new ModifiersBuffer { Entries = forced.ToList() } }
            };
            data.InactiveStats.Add(gamedataStatType.Strength);

            return data;
        }

        private static gameConstantStatModifierData_Deprecated Modifier(float value) => new()
        {
            StatType = gamedataStatType.Strength,
            ModifierType = gameStatModifierType.Additive,
            Value = value
        };

        private static float[] Values(DataBuffer buffer) =>
            ((ModifiersBuffer)buffer.Data!).Entries.Cast<gameConstantStatModifierData_Deprecated>().Select(x => (float)x.Value).ToArray();
    }
}
