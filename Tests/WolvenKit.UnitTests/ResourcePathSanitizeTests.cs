using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    /// <summary>
    /// <see cref="ResourcePath.SanitizePath"/> sits on a hot path and was rewritten to avoid
    /// per-call allocations. These tests pin the exact observable behaviour, including the
    /// ordering interaction between separator collapsing and invariant lowercasing.
    /// </summary>
    [TestClass]
    public class ResourcePathSanitizeTests
    {
        /// <summary>The original implementation, kept verbatim as the behavioural oracle.</summary>
        private static string Reference(string? text)
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

        [TestMethod]
        [DataRow(null, "")]
        [DataRow("", "")]
        [DataRow("   ", "")]
        [DataRow("///\\\\\\", "")]
        [DataRow("a", "a")]
        [DataRow("A", "a")]
        [DataRow("/a/", "a")]
        [DataRow("a//b", "a\\b")]
        [DataRow("a\\\\b", "a\\b")]
        [DataRow("a/\\/b", "a\\b")]
        [DataRow("BASE/CHARACTERS//HEAD.MESH", "base\\characters\\head.mesh")]
        [DataRow("'base\\test.mesh'", "base\\test.mesh")]
        [DataRow("  \"base/test.mesh\"  \r\n", "base\\test.mesh")]
        [DataRow("base\\characters\\Head.mesh", "base\\characters\\head.mesh")]
        public void SanitizePath_ProducesExpectedResult(string? input, string expected) =>
            Assert.AreEqual(expected, ResourcePath.SanitizePath(input));

        [TestMethod]
        public void SanitizePath_MatchesReference_ForEdgeCases()
        {
            string[] cases =
            [
                null!, "", " ", "/", "\\", "//", "\\\\", "'\"'", "\r\n", "a", "/a", "a/",
                "a//b", "a\\\\b", "a/\\/b", "\\\\server\\share\\file", "....", "a.b.c",
                // non-ASCII casing, where per-char and per-string lowering can disagree
                "ÄÖÜ\\ÑOÑO", "İstanbul\\FILE", "ß\\STRASSE", "ǅ\\Ǆ", "ﬁle\\ﬀ", "İıß",
                "ΣΊΣΥΦΟΣ\\ΟΔΥΣΣΕΥΣ",
                // surrogate pairs and lone surrogates
                "𐐀\\𐐨", "😀\\emoji", "𐐀/𐐁", "\uD801\\x", "x\\\uDC00",
            ];

            foreach (var input in cases)
            {
                Assert.AreEqual(Reference(input), ResourcePath.SanitizePath(input), $"input: <{input}>");
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

            var rng = new System.Random(20260807);

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
                Assert.AreEqual(Reference(input), ResourcePath.SanitizePath(input), $"input: <{input}>");
            }
        }
    }
}
