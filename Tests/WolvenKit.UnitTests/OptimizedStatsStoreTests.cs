using System;
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

        [TestMethod]
        public void ReplacingStatModifiers_IsCommitted()
        {
            var map = CreateMapWithTwoEntities();
            var store = new OptimizedStatsStore(map);
            var data = store.Get(gameStatIDType.EntityID, s_firstEntity)!;
            data.StatModifiers = new() { new CHandle<gameStatModifierData_Deprecated>(Modifier(10)) };

            Assert.IsTrue(store.HasChanges);
            Assert.AreEqual(0, map.ValuesOptimized[0].StatModifiers.Count);
            store.Commit();

            var reloaded = new OptimizedStatsStore(map).Get(gameStatIDType.EntityID, s_firstEntity)!;
            Assert.AreEqual(10f, (float)((gameConstantStatModifierData_Deprecated)reloaded.StatModifiers[0].Chunk!).Value);
            Assert.IsFalse(store.HasChanges);
        }

        [TestMethod]
        public void EditingStatModifiers_IsIsolatedUntilCommit()
        {
            var map = CreateMapWithTwoEntities();
            map.ValuesOptimized[0].StatModifiers.Add(new CHandle<gameStatModifierData_Deprecated>(Modifier(5)));
            var store = new OptimizedStatsStore(map);
            var data = store.Get(gameStatIDType.EntityID, s_firstEntity)!;
            ((gameConstantStatModifierData_Deprecated)data.StatModifiers[0].Chunk!).Value = 10;

            Assert.IsTrue(store.HasChanges);
            Assert.AreEqual(5f, (float)((gameConstantStatModifierData_Deprecated)map.ValuesOptimized[0].StatModifiers[0].Chunk!).Value);
            store.Commit();
            Assert.IsFalse(store.HasChanges);
            Assert.AreEqual(10f, (float)((gameConstantStatModifierData_Deprecated)map.ValuesOptimized[0].StatModifiers[0].Chunk!).Value);

            data.StatModifiers.Clear();
            Assert.IsTrue(store.HasChanges);
            Assert.AreEqual(1, map.ValuesOptimized[0].StatModifiers.Count);
            store.Commit();
            Assert.AreEqual(0, new OptimizedStatsStore(map).Get(gameStatIDType.EntityID, s_firstEntity)!.StatModifiers.Count);
        }

        [DataTestMethod]
        [DataRow("records")]
        [DataRow("inactive")]
        [DataRow("slices")]
        public void FullSharedTable_RejectsNewValuesBeforeMutatingTheBatch(string table)
        {
            var map = CreateMapWithTwoEntities();
            FillTable(map, table, ushort.MaxValue + 1);
            var arena = map.SharedDataBuffer.Buffer.GetBytes();
            var store = new OptimizedStatsStore(map);
            store.Get(gameStatIDType.EntityID, s_firstEntity)!.Seed = 123;
            var second = store.Get(gameStatIDType.EntityID, s_secondEntity)!;
            switch (table)
            {
                case "records":
                    second.RecordID = "Character.Other";
                    break;
                case "inactive":
                    second.InactiveStats.Add(gamedataStatType.Reflexes);
                    break;
                case "slices":
                    ((ModifiersBuffer)second.ModifiersBuffer.Data!).Entries.Add(Modifier(10));
                    break;
            }

            Assert.ThrowsException<InvalidOperationException>(() => store.Commit());
            Assert.AreEqual(1u, (uint)map.ValuesOptimized[0].Seed);
            Assert.AreEqual(2u, (uint)map.ValuesOptimized[1].Seed);
            Assert.AreEqual(2, map.ValuesOptimized.Count);
            Assert.AreSame(arena, map.SharedDataBuffer.Buffer.GetBytes());
            Assert.IsTrue(store.HasChanges);
        }

        [DataTestMethod]
        [DataRow("records")]
        [DataRow("inactive")]
        [DataRow("slices")]
        public void FullSharedTable_StillReusesExistingValues(string table)
        {
            var map = CreateMapWithTwoEntities();
            FillTable(map, table, ushort.MaxValue + 1);
            var store = new OptimizedStatsStore(map);
            store.Create(gameStatIDType.EntityID, 3, CreateStats(seed: 3, modifiers: [Modifier(5)], forced: []));

            store.Commit();

            Assert.AreEqual(3, map.ValuesOptimized.Count);
            Assert.AreEqual(3u, (uint)new OptimizedStatsStore(map).Get(gameStatIDType.EntityID, 3)!.Seed);
            Assert.IsFalse(store.HasChanges);
        }

        [TestMethod]
        public void SharedRecordTable_LastRepresentableIndexIsUsable()
        {
            var map = CreateMapWithTwoEntities();
            FillTable(map, "records", ushort.MaxValue);
            var store = new OptimizedStatsStore(map);
            store.Get(gameStatIDType.EntityID, s_firstEntity)!.RecordID = "Character.Last";
            store.Commit();

            Assert.AreEqual(ushort.MaxValue, (ushort)map.ValuesOptimized[0].RecordIDIndex);
            Assert.AreEqual((TweakDBID)"Character.Last", new OptimizedStatsStore(map).Get(gameStatIDType.EntityID, s_firstEntity)!.RecordID);
        }

        [TestMethod]
        public void SharedRecordTable_BatchCannotOverbookTheLastSlot()
        {
            var map = CreateMapWithTwoEntities();
            FillTable(map, "records", ushort.MaxValue);
            var store = new OptimizedStatsStore(map);
            store.Get(gameStatIDType.EntityID, s_firstEntity)!.RecordID = "Character.FirstNew";
            store.Get(gameStatIDType.EntityID, s_secondEntity)!.RecordID = "Character.SecondNew";

            Assert.ThrowsException<InvalidOperationException>(() => store.Commit());
            Assert.AreEqual((int)ushort.MaxValue, map.SharedRecordId.Count);
            Assert.AreEqual((ushort)0, (ushort)map.ValuesOptimized[0].RecordIDIndex);
            Assert.AreEqual((ushort)0, (ushort)map.ValuesOptimized[1].RecordIDIndex);
        }

        private static void FillTable(gameStatsStateMapStructure map, string table, int count)
        {
            switch (table)
            {
                case "records":
                    while (map.SharedRecordId.Count < count)
                    {
                        map.SharedRecordId.Add(map.SharedRecordId[0]);
                    }
                    break;
                case "inactive":
                    while (map.SharedInactiveStats.Count < count)
                    {
                        map.SharedInactiveStats.Add(map.SharedInactiveStats[0]);
                    }
                    break;
                case "slices":
                    while (map.SharedBufferSlices.Count < count)
                    {
                        map.SharedBufferSlices.Add(map.SharedBufferSlices[0]);
                    }
                    break;
            }
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
