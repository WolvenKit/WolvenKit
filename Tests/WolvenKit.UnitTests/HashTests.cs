using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class HashTests
    {
        private const string s_used = "WolvenKit.Common.Resources.usedhashes.kark";

        [TestMethod]
        public void CompareMemoryNormal()
        {
            List<string> originals = new();
            Dictionary<ulong, string> hashDictionary = new();
            hashDictionary.EnsureCapacity(500_000);

            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            var before = GC.GetTotalMemory(true);

            Assembly assembly;
            using (mlc)
            {
                assembly = mlc.LoadFromAssemblyPath("WolvenKit.Common.dll");
                using var stream = assembly.GetManifestResourceStream(s_used).NotNull();

                // read KARK header
                var oodleCompression = stream.ReadStruct<uint>();
                if (oodleCompression != Oodle.KARK)
                {
                    throw new DecompressionException($"Incorrect hash file.");
                }

                var outputsize = stream.ReadStruct<uint>();

                // read the rest of the stream
                var outputbuffer = new byte[outputsize];
                var inbuffer = stream.ToByteArray(true);
                Oodle.Decompress(inbuffer, outputbuffer);


                using var ms = new MemoryStream(outputbuffer);
                using var sr = new StreamReader(ms);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    var hash = FNV1A64HashAlgorithm.HashString(line);

                    if (hashDictionary.ContainsKey(hash))
                    {
                        continue;
                    }
                    hashDictionary.Add(hash, line);
                }
            }

            var after = GC.GetTotalMemory(true);
            double diff = after - before;
            Console.WriteLine($"Memory: {diff}");

            // compare
            var failed = 0;
            foreach (var s in originals)
            {
                var hash = FNV1A64HashAlgorithm.HashString(s);

                var gottenString = hashDictionary[hash].ToString();
                if (!gottenString.Equals(s))
                {
                    failed++;
                }
            }
        }

        [TestMethod]
        public void CompareMemorySAsciiString()
        {
            //float result = 1;
            //for (int i = 2; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result *= i;
            //    }
            //    else
            //    {
            //        result /= i;
            //    }
            //}

            List<string> originals = new();
            Dictionary<ulong, SAsciiString> hashDictionary = new();
            hashDictionary.EnsureCapacity(500_000);

            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            var before = GC.GetTotalMemory(true);

            Assembly assembly;
            using (mlc)
            {
                assembly = mlc.LoadFromAssemblyPath("WolvenKit.Common.dll");
                using var stream = assembly.GetManifestResourceStream(s_used).NotNull();

                // read KARK header
                var oodleCompression = stream.ReadStruct<uint>();
                if (oodleCompression != Oodle.KARK)
                {
                    throw new DecompressionException($"Incorrect hash file.");
                }

                var outputsize = stream.ReadStruct<uint>();

                // read the rest of the stream
                var outputbuffer = new byte[outputsize];
                var inbuffer = stream.ToByteArray(true);
                Oodle.Decompress(inbuffer, outputbuffer);


                using var ms = new MemoryStream(outputbuffer);
                using var sr = new StreamReader(ms);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    var hash = FNV1A64HashAlgorithm.HashString(line);

                    if (hashDictionary.ContainsKey(hash))
                    {
                        continue;
                    }
                    hashDictionary.Add(hash, new SAsciiString(line));
                }
            }

            var after = GC.GetTotalMemory(true);
            double diff = after - before;
            Console.WriteLine($"Memory: {diff}");

            // compare
            var failed = 0;
            foreach (var s in originals)
            {
                var hash = FNV1A64HashAlgorithm.HashString(s);

                var gottenString = hashDictionary[hash].ToString();
                if (!gottenString.Equals(s))
                {
                    failed++;
                }
            }

            Assert.AreEqual(0, failed);





        }

        private class MyComparer : IEqualityComparer<SAsciiString>
        {
            public bool Equals(SAsciiString x, SAsciiString y) => x.Equals(y);
            public int GetHashCode(SAsciiString obj) => obj.ToString().GetHashCode();
        }

        [TestMethod]
        public void CompareMemorySAsciiStringChunked()
        {
            List<string> originals = new();
            Dictionary<ulong, uint[]> hashDictionary = new();
            Dictionary<SAsciiString, uint> helperDict = new(new MyComparer());

            hashDictionary.EnsureCapacity(500_000);


            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            var before = GC.GetTotalMemory(true);

            Assembly assembly;
            using (mlc)
            {
                assembly = mlc.LoadFromAssemblyPath("WolvenKit.Common.dll");
                using var stream = assembly.GetManifestResourceStream(s_used).NotNull();

                // read KARK header
                var oodleCompression = stream.ReadStruct<uint>();
                if (oodleCompression != Oodle.KARK)
                {
                    throw new DecompressionException($"Incorrect hash file.");
                }

                var outputsize = stream.ReadStruct<uint>();

                // read the rest of the stream
                var outputbuffer = new byte[outputsize];
                var inbuffer = stream.ToByteArray(true);
                Oodle.Decompress(inbuffer, outputbuffer);


                using var ms = new MemoryStream(outputbuffer);
                using var sr = new StreamReader(ms);

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    originals.Add(line);

                    var hash = FNV1A64HashAlgorithm.HashString(line);
                    var pathParts = line.Split('\\');
                    hashDictionary.Add(hash, new uint[pathParts.Length]);


                    for (var i = 0; i < pathParts.Length; i++)
                    {
                        var s = pathParts[i];
                        var a = new SAsciiString(s);
                        uint idx;

                        if (helperDict.ContainsKey(a))
                        {
                            idx = helperDict[a];
                        }
                        else
                        {
                            //chunks.Add(a);
                            var count = helperDict.Count;
                            helperDict.Add(a, (uint)count);
                            idx = (uint)count;
                        }

                        hashDictionary[hash][i] = idx;
                    }
                }
            }

            var after = GC.GetTotalMemory(true);
            double diff = after - before;
            Console.WriteLine($"Memory: {diff}");



            // compare
            var failed = 0;
            var keys = helperDict.Keys.ToList();
            foreach (var s in originals)
            {
                var hash = FNV1A64HashAlgorithm.HashString(s);

                var gottenString = "";
                for (var i = 0; i < hashDictionary[hash].Length; i++)
                {
                    var idx = hashDictionary[hash][i];
                    gottenString += keys[(int)idx].ToString();
                    if (i < hashDictionary[hash].Length - 1)
                    {
                        gottenString += Path.DirectorySeparatorChar;
                    }
                }

                if (!gottenString.Equals(s))
                {
                    failed++;
                }
            }

            Assert.AreEqual(0, failed);


        }
    }
}
