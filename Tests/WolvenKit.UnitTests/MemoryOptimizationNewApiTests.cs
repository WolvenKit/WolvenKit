using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    /// <summary>
    /// Covers API and behavior <b>introduced</b> by the "Memory optimizations" and "Further memory
    /// optimizations" commits.
    /// </summary>
    /// <remarks>
    /// Unlike <see cref="MemoryOptimizationRegressionTests"/>, these cannot compile against the
    /// pre-optimization tree — the types and members under test did not exist there. Where a new
    /// member replaced an old expression, the test asserts equivalence by evaluating the old
    /// expression inline, so the guarantee is still checked rather than assumed.
    /// </remarks>
    [TestClass]
    public class MemoryOptimizationNewApiTests
    {
        #region AssemblyTypeIndex

        /// <summary>
        /// Forces the type snapshot to be built before asserting.
        /// </summary>
        /// <remarks>
        /// Building the snapshot calls Assembly.GetTypes(), which can itself trigger assembly loads;
        /// each load invalidates the index. Without warming first, an expectation and the value it is
        /// compared against can be computed from different snapshots, and the assembly set only ever
        /// grows during a test run.
        /// </remarks>
        private static void WarmIndex()
        {
            for (var i = 0; i < 5; i++)
            {
                var before = AssemblyTypeIndex.AllTypes.Length;
                _ = AssemblyTypeIndex.ByName;
                if (AssemblyTypeIndex.AllTypes.Length == before)
                {
                    return;
                }
            }
        }

        [TestMethod]
        public void AssemblyTypeIndex_ByName_MatchesPreviousGroupByExpression()
        {
            WarmIndex();

            // exactly what RedTypeTemplateService.ParseType used to build
            var expected = AssemblyTypeIndex.AllTypes
                .GroupBy(t => t.Name)
                .ToDictionary(g => g.Key, g => g.First());

            var actual = AssemblyTypeIndex.ByName;

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (var (name, type) in expected)
            {
                Assert.IsTrue(actual.TryGetValue(name, out var actualType), $"missing {name}");
                Assert.AreSame(type, actualType, $"different type for {name}");
            }
        }

        [TestMethod]
        public void AssemblyTypeIndex_GetConcreteClassesAssignableTo_MatchesPreviousLinqExpression()
        {
            WarmIndex();

            foreach (var baseType in new[] { typeof(IRedType), typeof(RedBaseClass), typeof(inkWidgetReference) })
            {
                var expected = AssemblyTypeIndex.AllTypes
                    .Where(p => baseType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
                    .ToHashSet();

                var actual = AssemblyTypeIndex.GetConcreteClassesAssignableTo(baseType).ToHashSet();

                Assert.IsTrue(expected.SetEquals(actual), $"mismatch for {baseType.Name}: expected {expected.Count}, got {actual.Count}");
            }
        }

        [TestMethod]
        public void AssemblyTypeIndex_GetConcreteTypesAssignableTo_MatchesPreviousLinqExpression()
        {
            WarmIndex();

            // RedGraph used '!IsAbstract' WITHOUT the IsClass filter - a distinct overload
            var baseType = typeof(IRedType);

            var expected = AssemblyTypeIndex.AllTypes.Where(x => baseType.IsAssignableFrom(x) && !x.IsAbstract).ToHashSet();
            var actual = AssemblyTypeIndex.GetConcreteTypesAssignableTo(baseType).ToHashSet();

            Assert.IsTrue(expected.SetEquals(actual));
        }

        [TestMethod]
        public void AssemblyTypeIndex_ExcludesAbstractTypesAndInterfaces()
        {
            WarmIndex();

            var concrete = AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(IRedType));

            Assert.IsFalse(concrete.Any(t => t.IsAbstract), "abstract type leaked into the concrete set");
            Assert.IsFalse(concrete.Any(t => t.IsInterface), "interface leaked into the concrete set");
            Assert.IsTrue(concrete.Contains(typeof(CMesh)),
                $"CMesh missing from the concrete IRedType set (concrete={concrete.Count}, "
                + $"allTypes={AssemblyTypeIndex.AllTypes.Length}) - the type snapshot is stale");
        }

        [TestMethod]
        public void AssemblyTypeIndex_RepeatedCallsReturnCachedInstance()
        {
            WarmIndex();

            // prime the entry first: the very first call may build the snapshot and load assemblies
            _ = AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(inkWidgetReference));

            Assert.AreSame(
                AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(inkWidgetReference)),
                AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(inkWidgetReference)));
        }

        [TestMethod]
        public void AssemblyTypeIndex_InvalidateRebuildsEquivalentResults()
        {
            WarmIndex();

            var before = AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(CMesh)).ToHashSet();
            var byNameBefore = AssemblyTypeIndex.ByName.Count;

            AssemblyTypeIndex.Invalidate();
            WarmIndex();

            var after = AssemblyTypeIndex.GetConcreteClassesAssignableTo(typeof(CMesh)).ToHashSet();

            // Nothing may disappear across an invalidation. New entries are legitimate: more
            // assemblies may have loaded, which is exactly the case invalidation exists to handle.
            Assert.IsTrue(after.IsSupersetOf(before), "invalidation lost entries from the result set");
            Assert.IsTrue(AssemblyTypeIndex.ByName.Count >= byNameBefore, "invalidation lost named types");
        }

        [TestMethod]
        public void AssemblyTypeIndex_GetFiltered_CachesByKeyAndMatchesPredicate()
        {
            WarmIndex();

            var templatable = AssemblyTypeIndex.GetFiltered("test-templatable", RedTypeTemplateService.IsTypeTemplatable);

            Assert.IsTrue(templatable.All(RedTypeTemplateService.IsTypeTemplatable));
            Assert.AreEqual(
                AssemblyTypeIndex.AllTypes.Count(RedTypeTemplateService.IsTypeTemplatable),
                templatable.Count);

            Assert.AreSame(templatable, AssemblyTypeIndex.GetFiltered("test-templatable", RedTypeTemplateService.IsTypeTemplatable));
        }

        [TestMethod]
        public void AssemblyTypeIndex_FindByName_AgreesWithParseType()
        {
            Assert.AreEqual(RedTypeTemplateService.ParseType("CMesh"), AssemblyTypeIndex.FindByName("CMesh"));
            Assert.IsNull(AssemblyTypeIndex.FindByName("NoSuchType_NewApiTest"));
        }

        #endregion

        #region StringBlob / StringRef

        [TestMethod]
        public void StringBlobBuilder_RoundTripsUtf16Input()
        {
            var values = new[] { "alpha", "", "ünïcödé", "𐐀surrogate", new string('x', 1000) };

            using var builder = new StringBlobBuilder(16);
            var refs = values.Select(v => builder.AddUtf16(v.AsSpan())).ToArray();
            var blob = builder.Build();

            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(values[i], blob.GetString(refs[i]), $"index {i}");
            }
        }

        [TestMethod]
        public void StringBlobBuilder_RoundTripsRawUtf8Input()
        {
            var values = new[] { "alpha", "beta", "ünïcödé" };

            using var builder = new StringBlobBuilder(8);
            var refs = values.Select(v => builder.AddUtf8(Encoding.UTF8.GetBytes(v))).ToArray();
            var blob = builder.Build();

            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(values[i], blob.GetString(refs[i]));
                CollectionAssert.AreEqual(Encoding.UTF8.GetBytes(values[i]), blob.Slice(refs[i]).ToArray());
            }
        }

        [TestMethod]
        public void StringBlobBuilder_GrowsBeyondInitialCapacity()
        {
            using var builder = new StringBlobBuilder(1);
            var refs = Enumerable.Range(0, 2000).Select(i => builder.AddUtf16($"entry_{i}".AsSpan())).ToArray();
            var blob = builder.Build();

            for (var i = 0; i < refs.Length; i++)
            {
                Assert.AreEqual($"entry_{i}", blob.GetString(refs[i]));
            }
        }

        [TestMethod]
        public void StringBlob_Empty_IsZeroLength()
        {
            Assert.AreEqual(0, StringBlob.Empty.Size);
            Assert.AreEqual("", StringBlob.Empty.GetString(new StringRef(0, 0)));
        }

        [TestMethod]
        public void StringRef_IsBlittableEightBytes() =>
            Assert.AreEqual(8, System.Runtime.InteropServices.Marshal.SizeOf<StringRef>());

        #endregion

        #region LookupTable blob overload

        [TestMethod]
        public void LookupTable_BlobOverload_MatchesStringOverload()
        {
            var values = Enumerable.Range(0, 3000).Select(i => $"base\\blob\\entry_{i}.mesh").ToArray();

            var viaStrings = new LookupTable(values, 1, s => FNV1A64HashAlgorithm.HashString(s));

            using var builder = new StringBlobBuilder(1024);
            var refs = values.Select(v => builder.AddUtf16(v.AsSpan())).ToArray();
            var viaBlob = new LookupTable(builder.Build(), refs, 4, ResourcePath.CalculateHashUtf8);

            CollectionAssert.AreEqual(viaStrings.ToList(), viaBlob.ToList());

            Assert.AreEqual(values.Length, viaBlob.Count);
            foreach (var value in values)
            {
                var hash = FNV1A64HashAlgorithm.HashString(value);
                Assert.IsTrue(viaBlob.TryGetValue(hash, out var actual));
                Assert.AreEqual(value, actual);
            }
        }

        [TestMethod]
        public void LookupTable_GetUtf8_MatchesGetString()
        {
            var values = new[] { "alpha", "beta", "gamma" };

            using var builder = new StringBlobBuilder(64);
            var refs = values.Select(v => builder.AddUtf16(v.AsSpan())).ToArray();
            var table = new LookupTable(builder.Build(), refs, 1, ResourcePath.CalculateHashUtf8);

            for (var i = 0; i < table.Count; i++)
            {
                Assert.AreEqual(table.GetString(i), Encoding.UTF8.GetString(table.GetUtf8(i)));
                Assert.IsTrue(table.ContainsKey(table.GetKey(i)));
            }
        }

        #endregion

        #region UTF-8 hash overloads

        [TestMethod]
        public void CalculateHashUtf8_MatchesStringOverload_ForAscii()
        {
            foreach (var s in new[] { "", "a", @"base\characters\head.mesh", "0123456789", new string('q', 500) })
            {
                Assert.AreEqual(
                    ResourcePath.CalculateHash(s, false),
                    ResourcePath.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)),
                    $"ResourcePath, input <{s}>");

                Assert.AreEqual(
                    NodeRef.CalculateHash(s),
                    NodeRef.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)),
                    $"NodeRef, input <{s}>");

                Assert.AreEqual(
                    TweakDBID.CalculateHash(s),
                    TweakDBID.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)),
                    $"TweakDBID, input <{s}>");
            }
        }

        [TestMethod]
        public void CalculateHashUtf8_MatchesStringOverload_ForNonAscii()
        {
            // the non-ASCII fallback must defer to the exact string path
            foreach (var s in new[] { "ünïcödé", "ΣΊΣΥΦΟΣ", "𐐀surrogate", "ß" })
            {
                Assert.AreEqual(ResourcePath.CalculateHash(s, false), ResourcePath.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)), $"ResourcePath <{s}>");
                Assert.AreEqual(NodeRef.CalculateHash(s), NodeRef.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)), $"NodeRef <{s}>");
                Assert.AreEqual(TweakDBID.CalculateHash(s), TweakDBID.CalculateHashUtf8(Encoding.UTF8.GetBytes(s)), $"TweakDBID <{s}>");
            }
        }

        [TestMethod]
        public void HashStringWithoutAliasesAscii_MatchesCharOverload()
        {
            foreach (var s in new[]
                     {
                         "", "plain", "$/a/#b/c", "$/test/important;#alias/1", "$/x/#a", ";", "$/a;#b/c",
                         "$/03_night_city/#c_city_center/corpo_plaza", "a#b", "#a",
                     })
            {
                Assert.AreEqual(
                    FNV1A64HashAlgorithm.HashStringWithoutAliases(s),
                    FNV1A64HashAlgorithm.HashStringWithoutAliasesAscii(Encoding.ASCII.GetBytes(s)),
                    $"input <{s}>");
            }
        }

        [TestMethod]
        public void HashStringWithoutAliasesAscii_IsBoundsSafeWhereCharOverloadThrows()
        {
            // Documented divergence. The char overload advances past '#' and then indexes without a
            // bounds check, so a value ENDING in '#' throws IndexOutOfRangeException. The byte
            // overload guards instead. This is strictly more robust and cannot change any existing
            // hash: the only inputs that differ are ones the old code could not hash at all.
            foreach (var s in new[] { "#", "$/a/#", "abc#" })
            {
                Assert.ThrowsException<IndexOutOfRangeException>(
                    () => FNV1A64HashAlgorithm.HashStringWithoutAliases(s),
                    $"expected the char overload to throw for <{s}>");

                // must not throw
                _ = FNV1A64HashAlgorithm.HashStringWithoutAliasesAscii(Encoding.ASCII.GetBytes(s));
            }
        }

        [TestMethod]
        public void Crc32_SpanOverload_MatchesArrayOverload()
        {
            foreach (var s in new[] { "", "hello", "Items.Preset_Lexington_Wilson", new string('z', 1000) })
            {
                var bytes = Encoding.ASCII.GetBytes(s);
                Assert.AreEqual(Crc32Algorithm.Compute(bytes), Crc32Algorithm.Compute(bytes.AsSpan()), $"input <{s}>");
            }
        }

        #endregion

        #region Optimization guarantees

        [TestMethod]
        public void SanitizePath_ReturnsSameInstance_WhenAlreadySanitized()
        {
            // the zero-allocation fast path: an already-normalized path must not be copied
            var alreadyClean = "base\\characters\\head.mesh";
            Assert.AreSame(alreadyClean, ResourcePath.SanitizePath(alreadyClean));
        }

        [TestMethod]
        public void SanitizePath_AllocatesOnlyWhenNormalizationIsNeeded()
        {
            var needsWork = "BASE/CHARACTERS//HEAD.MESH";
            Assert.AreNotSame(needsWork, ResourcePath.SanitizePath(needsWork));
        }

        [TestMethod]
        public void RedReflection_LazyCache_ReturnsSingleInstancePerType()
        {
            // GetOrAdd replaced TryGetValue/TryAdd, which could hand a caller an instance that never
            // made it into the cache. Now that the cache fills lazily, that race is reachable.
            var type = typeof(CMesh);

            var instances = Enumerable.Range(0, 32)
                .AsParallel()
                .Select(_ => RedReflection.GetTypeInfo(type))
                .Distinct()
                .ToList();

            Assert.AreEqual(1, instances.Count, "GetTypeInfo handed out more than one instance for the same type");
        }

        [TestMethod]
        public void RedReflection_LazyCache_StillResolvesRarelyUsedTypes()
        {
            // these are types the eager pre-build used to populate; they must still resolve on demand
            foreach (var name in new[] { "entEntity", "CMesh", "appearanceAppearanceDefinition" })
            {
                var type = RedTypeTemplateService.ParseType(name);
                Assert.IsNotNull(type, $"could not resolve {name}");

                var info = RedReflection.GetTypeInfo(type!);
                Assert.IsNotNull(info);
                Assert.AreEqual(type, info.Type);
            }
        }

        #endregion
    }
}
