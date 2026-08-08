using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.UnitTests
{
    /// <summary>
    /// Behavioral regression suite for upcoming future memory optimization fixes.
    /// </summary>
    [TestClass]
    public class MemoryOptimizationRegressionTests
    {
        #region Hash stability

        [TestMethod]
        public void ResourcePath_CalculateHash_IsStable()
        {
            Assert.AreEqual(8995421073019654957UL, ResourcePath.CalculateHash(@"base\characters\head.mesh", false));
            Assert.AreEqual(12638187200555641996UL, ResourcePath.CalculateHash("a", false));
            Assert.AreEqual(14695981039346656037UL, ResourcePath.CalculateHash(""));
        }

        [TestMethod]
        public void ResourcePath_CalculateHash_SanitizesBeforeHashing()
        {
            Assert.AreEqual(
                ResourcePath.CalculateHash(@"base\characters\head.mesh", false),
                ResourcePath.CalculateHash("BASE/CHARACTERS//HEAD.MESH"));

            Assert.AreEqual(
                ResourcePath.CalculateHash(@"base\characters\head.mesh", false),
                ResourcePath.CalculateHash("  '/BASE\\CHARACTERS//HEAD.MESH/'  "));
        }

        [TestMethod]
        public void NodeRef_CalculateHash_IsStable()
        {
            Assert.AreEqual(4796743598250670598UL, NodeRef.CalculateHash("$/03_night_city/#c_city_center"));
            Assert.AreEqual(8824766866764965240UL, NodeRef.CalculateHash("$/a/b/c"));
            Assert.AreEqual(18252272687975150087UL, NodeRef.CalculateHash("plain"));
            Assert.AreEqual(13215270091511151672UL, NodeRef.CalculateHash("$/x;#alias/y"));
            Assert.AreEqual(0UL, NodeRef.CalculateHash(""));
        }

        [TestMethod]
        public void NodeRef_CalculateHash_SkipsAliasMarkers()
        {
            // '#' is skipped, so these are the same path as far as the hash is concerned
            Assert.AreEqual(NodeRef.CalculateHash("$/a/b/c"), NodeRef.CalculateHash("$/a/#b/c"));

            // a trailing ';#alias' segment is skipped entirely - this collision is by design and is
            // why some noderefs legitimately resolve to a different string than they were built from
            Assert.AreEqual(NodeRef.CalculateHash("$/x/#a"), NodeRef.CalculateHash("$/x/#a;#b"));
        }

        [TestMethod]
        public void TweakDBID_CalculateHash_IsStable()
        {
            Assert.AreEqual(124763843892UL, TweakDBID.CalculateHash("Items.Preset_Lexington_Wilson"));
            Assert.AreEqual(61847598093UL, TweakDBID.CalculateHash("Character.Test"));
            Assert.AreEqual(0UL, TweakDBID.CalculateHash(""));
        }

        [TestMethod]
        public void TweakDBID_CalculateHash_EncodesLengthInHighBits()
        {
            const string name = "Character.Test";
            Assert.AreEqual((ulong)name.Length, TweakDBID.CalculateHash(name) >> 32);
        }

        [TestMethod]
        public void Fnv1A64_IsStable()
        {
            Assert.AreEqual(18007334074686647077UL, FNV1A64HashAlgorithm.HashString("test"));
            Assert.AreEqual(8995421073019654957UL, FNV1A64HashAlgorithm.HashString(@"base\characters\head.mesh"));
            Assert.AreEqual(5967113427344870998UL, FNV1A64HashAlgorithm.HashString("tëst", Encoding.UTF8, false, true));
            Assert.AreEqual(8824766866764965240UL, FNV1A64HashAlgorithm.HashStringWithoutAliases("$/a/#b/c"));
            Assert.AreEqual(17076895143540190469UL, FNV1A64HashAlgorithm.HashStringWithoutAliases("$/test/important;#alias/1"));
        }

        [TestMethod]
        public void Fnv1A64_HashReadOnlySpanBytes_MatchesAsciiHashString()
        {
            foreach (var s in new[] { "", "a", @"base\characters\head.mesh", "0123456789" })
            {
                Assert.AreEqual(
                    FNV1A64HashAlgorithm.HashString(s),
                    FNV1A64HashAlgorithm.HashReadOnlySpan(Encoding.ASCII.GetBytes(s).AsSpan()),
                    $"input: {s}");
            }
        }

        [TestMethod]
        public void Crc32_IsStable()
        {
            Assert.AreEqual(907060870u, Crc32Algorithm.Compute("hello"));
            Assert.AreEqual(209792308u, Crc32Algorithm.Compute("Items.Preset_Lexington_Wilson"));
        }

        #endregion

        #region SanitizePath

        [TestMethod]
        [DataRow(null, "")]
        [DataRow("", "")]
        [DataRow("    ", "")]
        [DataRow("///\\\\\\", "")]
        [DataRow("'\"'", "")]
        [DataRow("a", "a")]
        [DataRow("A", "a")]
        [DataRow("/a/", "a")]
        [DataRow("a//b", "a\\b")]
        [DataRow("a\\\\b", "a\\b")]
        [DataRow("a/\\/\\b", "a\\b")]
        [DataRow("a.b.c", "a.b.c")]
        [DataRow("BASE/CHARACTERS//HEAD.MESH", "base\\characters\\head.mesh")]
        [DataRow("'base\\test.mesh'", "base\\test.mesh")]
        [DataRow("  \"base/test.mesh\"  \r\n", "base\\test.mesh")]
        [DataRow("\\\\server\\\\share\\\\file", "server\\share\\file")]
        public void SanitizePath_ProducesExpectedResult(string? input, string expected) =>
            Assert.AreEqual(expected, ResourcePath.SanitizePath(input));

        [TestMethod]
        public void SanitizePath_IsIdempotent()
        {
            foreach (var s in new[]
                     {
                         "BASE/CHARACTERS//HEAD.MESH", "  '/a//b/'  ", "a", "", "ÄÖÜ\\FILE", "𐐀/𐐁",
                     })
            {
                var once = ResourcePath.SanitizePath(s);
                Assert.AreEqual(once, ResourcePath.SanitizePath(once), $"input: {s}");
            }
        }

        [TestMethod]
        public void SanitizePath_HandlesLengthsAroundInternalBufferBoundary()
        {
            foreach (var length in new[] { 1, 255, 256, 257, 512, 4096 })
            {
                var input = string.Join("\\", Enumerable.Repeat("SEGMENT", (length / 8) + 1));
                Assert.AreEqual(SanitizePathReference(input), ResourcePath.SanitizePath(input), $"length {length}");
            }
        }

        [TestMethod]
        public void SanitizePath_MatchesReference_ForRandomInput()
        {
            var alphabets = new[]
            {
                "ab\\/".ToCharArray(),
                "aA\\/'\" \r\n.".ToCharArray(),
                "abcABC123\\/_-. '\"\r\n".ToCharArray(),
                "aAbBäÄöÖßİıΣσςÆæ\\/. ".ToCharArray(),
            };

            var rng = new Random(20260807);

            for (var iteration = 0; iteration < 50_000; iteration++)
            {
                var alphabet = alphabets[rng.Next(alphabets.Length)];
                var builder = new StringBuilder();

                var length = rng.Next(0, 40);
                for (var i = 0; i < length; i++)
                {
                    if (rng.Next(40) == 0)
                    {
                        builder.Append(char.ConvertFromUtf32(0x10400 + rng.Next(0x28)));
                        continue;
                    }

                    builder.Append(alphabet[rng.Next(alphabet.Length)]);
                }

                var input = builder.ToString();
                Assert.AreEqual(SanitizePathReference(input), ResourcePath.SanitizePath(input), $"input: <{input}>");
            }
        }

        private static string SanitizePathReference(string? text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            var strResult = new StringBuilder();

            char[] trimChars = { '\'', '"', '/', '\\', ' ', '\n', '\r' };
            text = text.Trim(trimChars);

            for (var i = 0; i < text.Length; i++)
            {
                if (strResult.Length == 0)
                {
                    strResult.Append(text[i]);
                    continue;
                }

                if (text[i] == '\\' || text[i] == '/')
                {
                    if (strResult[^1] != ResourcePath.DirectorySeparatorChar)
                    {
                        strResult.Append(ResourcePath.DirectorySeparatorChar);
                    }

                    continue;
                }

                strResult.Append(text[i]);
            }

            return strResult.ToString().ToLowerInvariant();
        }

        #endregion

        #region ReadLengthPrefixedString

        private static BinaryReader ReaderOver(byte[] bytes) => new(new MemoryStream(bytes));

        private static byte[] WriteUtf16Prefixed(params string[] values)
        {
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);

            foreach (var value in values)
            {
                // a positive prefix selects UTF-16; the writer helper only ever emits UTF-8, so the
                // UTF-16 read path has to be constructed by hand
                bw.WriteVLQInt32(value.Length);
                bw.Write(Encoding.Unicode.GetBytes(value));
            }

            bw.Flush();
            return ms.ToArray();
        }

        private static byte[] WriteUtf8Prefixed(params string[] values)
        {
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);

            foreach (var value in values)
            {
                bw.WriteLengthPrefixedString(value);
            }

            bw.Flush();
            return ms.ToArray();
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("a")]
        [DataRow("abc")]
        [DataRow(@"base\characters\head.mesh")]
        [DataRow("ünïcödé ßtring")]
        [DataRow("𐐀 surrogate pair 😀")]
        public void ReadLengthPrefixedString_RoundTripsUtf8(string value)
        {
            using var reader = ReaderOver(WriteUtf8Prefixed(value));
            Assert.AreEqual(value, reader.ReadLengthPrefixedString());
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("a")]
        [DataRow("abc")]
        [DataRow("ünïcödé")]
        public void ReadLengthPrefixedString_ReadsUtf16(string value)
        {
            using var reader = ReaderOver(WriteUtf16Prefixed(value));
            Assert.AreEqual(value, reader.ReadLengthPrefixedString());
        }

        [TestMethod]
        public void ReadLengthPrefixedString_HandlesLengthsAroundInternalBufferBoundary()
        {
            // the optimized reader stack-allocates at or below 256 bytes and rents above it
            foreach (var charCount in new[] { 1, 127, 128, 129, 255, 256, 257, 1000 })
            {
                var value = new string('x', charCount);

                using (var utf8 = ReaderOver(WriteUtf8Prefixed(value)))
                {
                    Assert.AreEqual(value, utf8.ReadLengthPrefixedString(), $"utf8, {charCount} chars");
                }

                using var utf16 = ReaderOver(WriteUtf16Prefixed(value));
                Assert.AreEqual(value, utf16.ReadLengthPrefixedString(), $"utf16, {charCount} chars");
            }
        }

        [TestMethod]
        public void ReadLengthPrefixedString_ReadsSequentiallyWithoutCorruption()
        {
            // guards buffer reuse: a pooled/stack buffer must not leak between consecutive reads
            var values = new[] { "first", "", "third-is-considerably-longer", "d", new string('z', 400), "last" };

            using var reader = ReaderOver(WriteUtf8Prefixed(values));
            foreach (var expected in values)
            {
                Assert.AreEqual(expected, reader.ReadLengthPrefixedString());
            }
        }

        [TestMethod]
        public void ReadLengthPrefixedString_AdvancesStreamByExactlyTheEncodedLength()
        {
            var bytes = WriteUtf8Prefixed("alpha", "beta");
            using var stream = new MemoryStream(bytes);
            using var reader = new BinaryReader(stream);

            Assert.AreEqual("alpha", reader.ReadLengthPrefixedString());
            var afterFirst = stream.Position;

            Assert.AreEqual("beta", reader.ReadLengthPrefixedString());
            Assert.AreEqual(bytes.Length, stream.Position);
            Assert.IsTrue(afterFirst > 0 && afterFirst < bytes.Length);
        }

        [TestMethod]
        public void ReadVLQInt32_RoundTrips()
        {
            foreach (var value in new[] { 0, 1, 63, 64, 8191, 8192, 1_048_575, 1_048_576, -1, -63, -64, -8192 })
            {
                using var ms = new MemoryStream();
                using (var bw = new BinaryWriter(ms, Encoding.UTF8, true))
                {
                    bw.WriteVLQInt32(value);
                }

                ms.Position = 0;
                using var br = new BinaryReader(ms);
                Assert.AreEqual(value, br.ReadVLQInt32(), $"value {value}");
            }
        }

        #endregion

        #region LookupTable

        [TestMethod]
        public void LookupTable_Empty_FindsNothing()
        {
            var table = new LookupTable();

            Assert.IsFalse(table.ContainsKey(0));
            Assert.IsFalse(table.ContainsKey(12345));
            Assert.IsFalse(table.TryGetValue(12345, out var value));
            Assert.IsNull(value);
            Assert.AreEqual(0, table.Count());
        }

        [TestMethod]
        public void LookupTable_FromKeysAndValues_ResolvesEveryEntry()
        {
            var keys = new ulong[] { 30, 10, 20, 40 };
            var values = new[] { "thirty", "ten", "twenty", "forty" };

            var table = new LookupTable(keys, values);

            for (var i = 0; i < keys.Length; i++)
            {
                Assert.IsTrue(table.ContainsKey(keys[i]), $"missing key {keys[i]}");
                Assert.IsTrue(table.TryGetValue(keys[i], out var actual));
                Assert.AreEqual(values[i], actual);
            }

            Assert.IsFalse(table.ContainsKey(999));
            Assert.IsFalse(table.TryGetValue(999, out var missing));
            Assert.IsNull(missing);
        }

        [TestMethod]
        public void LookupTable_FromKeysAndValues_EnumeratesSortedByKey()
        {
            var table = new LookupTable(new ulong[] { 30, 10, 20 }, new[] { "thirty", "ten", "twenty" });

            var pairs = table.ToList();

            CollectionAssert.AreEqual(new ulong[] { 10, 20, 30 }, pairs.Select(p => p.Key).ToArray());
            CollectionAssert.AreEqual(new[] { "ten", "twenty", "thirty" }, pairs.Select(p => p.Value).ToArray());
        }

        [TestMethod]
        public void LookupTable_FromKeysAndValues_ThrowsOnLengthMismatch() =>
            Assert.ThrowsException<ArgumentException>(() => new LookupTable(new ulong[] { 1, 2 }, new[] { "one" }));

        [TestMethod]
        public void LookupTable_FromValuesAndHashFunc_ResolvesEveryEntry()
        {
            var values = new[] { "alpha", "beta", "gamma", "delta", "epsilon" };

            var table = new LookupTable(values, 1, s => FNV1A64HashAlgorithm.HashString(s));

            foreach (var value in values)
            {
                var hash = FNV1A64HashAlgorithm.HashString(value);
                Assert.IsTrue(table.ContainsKey(hash), $"missing {value}");
                Assert.IsTrue(table.TryGetValue(hash, out var actual));
                Assert.AreEqual(value, actual);
            }
        }

        [TestMethod]
        public void LookupTable_FromValuesAndHashFunc_ParallelAndSerialAgree()
        {
            var values = Enumerable.Range(0, 5000).Select(i => $"base\\path\\file_{i}.mesh").ToArray();

            var serial = new LookupTable(values, 1, s => FNV1A64HashAlgorithm.HashString(s));
            var parallel = new LookupTable(values, 8, s => FNV1A64HashAlgorithm.HashString(s));

            CollectionAssert.AreEqual(serial.ToList(), parallel.ToList());

            foreach (var value in values)
            {
                var hash = FNV1A64HashAlgorithm.HashString(value);
                Assert.IsTrue(parallel.TryGetValue(hash, out var actual));
                Assert.AreEqual(value, actual);
            }
        }

        [TestMethod]
        public void LookupTable_HandlesUnicodeAndEmptyValues()
        {
            var values = new[] { "", "ünïcödé", "𐐀surrogate", "ΣΊΣΥΦΟΣ", "plain" };

            var table = new LookupTable(values, 1, s => FNV1A64HashAlgorithm.HashString(s, Encoding.UTF8));

            foreach (var value in values)
            {
                var hash = FNV1A64HashAlgorithm.HashString(value, Encoding.UTF8);
                Assert.IsTrue(table.TryGetValue(hash, out var actual), $"missing <{value}>");
                Assert.AreEqual(value, actual);
            }
        }

        [TestMethod]
        public void LookupTable_SingleEntry_Resolves()
        {
            var table = new LookupTable(new ulong[] { 42 }, new[] { "answer" });

            Assert.IsTrue(table.TryGetValue(42, out var value));
            Assert.AreEqual("answer", value);
            Assert.IsFalse(table.ContainsKey(41));
            Assert.IsFalse(table.ContainsKey(43));
        }

        [TestMethod]
        public void LookupTable_LargeTable_ResolvesEveryEntry()
        {
            const int count = 20_000;
            var keys = Enumerable.Range(0, count).Select(i => (ulong)(i * 7919)).ToArray();
            var values = Enumerable.Range(0, count).Select(i => $"value_{i}").ToArray();

            var table = new LookupTable(keys, values);

            for (var i = 0; i < count; i++)
            {
                Assert.IsTrue(table.TryGetValue(keys[i], out var actual), $"missing index {i}");
                Assert.AreEqual(values[i], actual);
            }
        }

        #endregion

        #region Pool round-trips

        // AddOrGetHash only ever adds to the runtime pool, so these are additive and cannot disturb
        // other tests. Names are deliberately unique to this suite.

        [TestMethod]
        public void ResourcePathPool_AddOrGetHash_RoundTripsSanitized()
        {
            const string raw = "REGRESSIONTEST/Pool//Path.MESH";
            var expected = ResourcePath.SanitizePath(raw);

            var hash = ResourcePathPool.AddOrGetHash(raw);

            Assert.AreEqual(ResourcePath.CalculateHash(expected, false), hash);
            Assert.AreEqual(expected, ResourcePathPool.ResolveHash(hash));
            Assert.IsTrue(ResourcePathPool.IsRuntime(hash) || ResourcePathPool.IsNative(hash));
        }

        [TestMethod]
        public void ResourcePathPool_AddOrGetHash_IsStableAcrossCalls()
        {
            const string raw = @"regressiontest\pool\stable.mesh";

            Assert.AreEqual(ResourcePathPool.AddOrGetHash(raw), ResourcePathPool.AddOrGetHash(raw));
            Assert.AreEqual(ResourcePathPool.AddOrGetHash(raw), ResourcePathPool.AddOrGetHash("REGRESSIONTEST/POOL//STABLE.MESH"));
        }

        [TestMethod]
        public void TweakDBIDPool_AddOrGetHash_RoundTrips()
        {
            const string name = "RegressionTest.PoolEntry";

            var hash = TweakDBIDPool.AddOrGetHash(name);

            Assert.AreEqual(TweakDBID.CalculateHash(name), hash);
            Assert.AreEqual(name, TweakDBIDPool.ResolveHash(hash));
        }

        [TestMethod]
        public void NodeRefPool_AddOrGetHash_RoundTrips()
        {
            const string nodeRef = "$/regressiontest/pool/entry";

            var hash = NodeRefPool.AddOrGetHash(nodeRef);

            Assert.AreEqual(NodeRef.CalculateHash(nodeRef), hash);
            Assert.AreEqual(nodeRef, NodeRefPool.ResolveHash(hash));
        }

        [TestMethod]
        public void NodeRefPool_AddOrGetHash_HandlesAliasSyntaxWithoutThrowing()
        {
            foreach (var nodeRef in new[]
                     {
                         "$/regressiontest/alias/#marker/tail",
                         "$/regressiontest/important;#alias/123",
                         "$/regressiontest/#tailonly",
                     })
            {
                var hash = NodeRefPool.AddOrGetHash(nodeRef);
                Assert.AreEqual(NodeRef.CalculateHash(nodeRef), hash, $"hash mismatch for {nodeRef}");
                Assert.AreEqual(nodeRef, NodeRefPool.ResolveHash(hash), $"round-trip failed for {nodeRef}");
            }
        }

        [TestMethod]
        public void NodeRefPool_AddOrGetHash_EmptyIsZero() => Assert.AreEqual(0UL, NodeRefPool.AddOrGetHash(""));

        [TestMethod]
        public void CNamePool_ResolvesNone() => Assert.AreEqual("None", CNamePool.ResolveHash(0));

        [TestMethod]
        public void ResourcePath_ImplicitConversion_RoundTrips()
        {
            ResourcePath path = @"regressiontest\implicit\conversion.mesh";
            Assert.AreEqual(@"regressiontest\implicit\conversion.mesh", path.GetResolvedText());
            Assert.IsTrue(path.IsResolvable);
        }

        #endregion

        #region RedReflection

        [TestMethod]
        public void RedReflection_GetTypes_ContainsKnownRedTypes()
        {
            var types = RedReflection.GetTypes();

            Assert.IsTrue(types.Count > 1000, $"expected a populated red type cache, got {types.Count}");
            Assert.IsTrue(types.ContainsKey("entEntity"), "entEntity missing from the red type cache");
            Assert.IsTrue(types.ContainsKey("CMesh"), "CMesh missing from the red type cache");
        }

        [TestMethod]
        public void RedReflection_GetTypeInfo_ReturnsPropertiesForKnownType()
        {
            var info = RedReflection.GetTypeInfo(typeof(CMesh));

            Assert.IsNotNull(info);
            Assert.AreEqual(typeof(CMesh), info.Type);
            Assert.IsTrue(info.PropertyInfos.Count > 0, "CMesh should expose RED properties");
        }

        [TestMethod]
        public void RedReflection_GetTypeInfo_IsCachedPerType()
        {
            // whether the cache is filled eagerly or lazily, repeated lookups must agree
            var first = RedReflection.GetTypeInfo(typeof(entEntity));
            var second = RedReflection.GetTypeInfo(typeof(entEntity));

            Assert.AreSame(first, second);
        }

        [TestMethod]
        public void RedReflection_GetTypeInfo_ResolvesNestedPropertyTypes()
        {
            var info = RedReflection.GetTypeInfo(typeof(CMesh));

            foreach (var property in info.PropertyInfos.Take(25))
            {
                Assert.IsNotNull(property.Type, $"property {property.Name} has no type");

                var nested = RedReflection.GetTypeInfo(property.Type);
                Assert.IsNotNull(nested, $"could not resolve type info for {property.Type}");
                Assert.AreEqual(property.Type, nested.Type);
            }
        }

        [TestMethod]
        public void RedReflection_GetTypeInfo_PropertyNamesAreStable()
        {
            var info = RedReflection.GetTypeInfo(typeof(CMesh));

            var names = info.PropertyInfos.Select(p => p.RedName ?? p.Name).ToList();

            CollectionAssert.AllItemsAreNotNull(names);
            CollectionAssert.AllItemsAreUnique(names);
        }

        #endregion

        #region RedTypeTemplateService type resolution

        [TestMethod]
        public void ParseType_ResolvesKnownTypesByName()
        {
            Assert.AreEqual(typeof(CMesh), RedTypeTemplateService.ParseType("CMesh"));
            Assert.AreEqual(typeof(entEntity), RedTypeTemplateService.ParseType("entEntity"));
        }

        [TestMethod]
        public void ParseType_ReturnsNullForUnknownType() =>
            Assert.IsNull(RedTypeTemplateService.ParseType("ThisTypeDoesNotExistAnywhere_RegressionTest"));

        [TestMethod]
        public void ParseType_IsStableAcrossCalls() =>
            Assert.AreSame(RedTypeTemplateService.ParseType("CMesh"), RedTypeTemplateService.ParseType("CMesh"));

        [TestMethod]
        public void IsTypeTemplatable_AcceptsConcreteRedClasses() =>
            Assert.IsTrue(RedTypeTemplateService.IsTypeTemplatable(typeof(CMesh)));

        [TestMethod]
        public void IsTypeTemplatable_RejectsPrimitivesAndNonRedTypes()
        {
            Assert.IsFalse(RedTypeTemplateService.IsTypeTemplatable(typeof(int)));
            Assert.IsFalse(RedTypeTemplateService.IsTypeTemplatable(typeof(string)));
            Assert.IsFalse(RedTypeTemplateService.IsTypeTemplatable(typeof(CName)));
        }

        #endregion
    }
}
