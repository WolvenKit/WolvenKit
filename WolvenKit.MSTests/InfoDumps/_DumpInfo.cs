using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Compression;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using System.Text.Json;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class _DumpInfo : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void DumpExtensionInfo()
        {
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();

            var results = new Dictionary<string, ConcurrentDictionary<string, ulong>>();
            foreach (var e in s_groupedFiles)
            {
                results.Add(e.Key, new ConcurrentDictionary<string, ulong>());
            }

            var excludedExtensions = new List<string>() { ".wem", ".bin", ".bnk", ".opuspak", ".opusinfo", ".bk2", ".dat" };

            // Run Test
            foreach (var item in s_groupedFiles.Where(_ => !excludedExtensions.Contains(_.Key)))
            {
                var ext = item.Key;
                var files = item.Value;

                Parallel.ForEach(files, file =>
                {
                    var hash = file.Key;
                    var archive = file.Archive as Archive;

                    try
                    {
                        using var originalMemoryStream = new MemoryStream();
                        ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);
                        if (parser.TryReadRed4FileHeaders(originalMemoryStream, out var originalFile))
                        {
                            results[ext].TryAdd(originalFile.StringDict[1], 0);
                        }
                        else
                        {

                        }
                    }
                    catch (Exception)
                    {

                    }

                });

            }

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            using var sw = new StringWriter();
            foreach (var (key, classes) in results)
            {
                sw.WriteLine($"{key}: {string.Join(",", classes.Keys.ToList())}");
            }
            File.WriteAllText(Path.Combine(resultDir, "classes.txt"), sw.ToString());
        }

        [TestMethod]
        public void DumpMissingHashes()
        {
            var parsers = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var _hashService = ServiceLocator.Default.ResolveType<IHashService>();

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            {
                List<ulong> used = new();
                List<ulong> missing = new();
                var info_missing = new Dictionary<string, List<ulong>>();

                var archives = s_bm.Archives.KeyValues.Select(_ => _.Value).ToList();

                for (var i = 0; i < archives.Count; i++)
                {
                    var ar = archives[i];
                    var hashes = new List<ulong>();
                    info_missing.Add(ar.Name, new List<ulong>());

                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        hashes.Add(hash);
                        if (fileInfoEntry is FileEntry fe && fe.NameOrHash == hash.ToString())
                        {
                            missing.Add(hash);
                            info_missing[ar.Name].Add(hash);
                        }
                        else
                        {
                            used.Add(hash);
                            //results[ar.Name].Add(hash);
                        }
                    }

                    using var tw = File.CreateText(Path.Combine(resultDir, $"{ar.Name}_hashes.txt"));
                    foreach (var h in hashes)
                    {
                        tw.WriteLine(h);
                    }
                }

                // write all used and all missing hashes
                var info = Path.Combine(resultDir, $"_info_hashes.txt");
                var info_json = JsonSerializer.Serialize(info_missing, new JsonSerializerOptions() {
                    WriteIndented = true,
                });
                File.WriteAllText(info, info_json);

                var missinghashtxt = Path.Combine(resultDir, "missinghashes.txt");

                using (var missingWriter = File.CreateText(missinghashtxt))
                {
                    for (var i = 0; i < missing.Count; i++)
                    {
                        var mh = missing[i];
                        missingWriter.WriteLine(mh);
                    }
                }

                var usedhashtxt = Path.Combine(resultDir, "usedhashes.txt");
                var usedStrings = used.Select(s => _hashService.Get(s)).OrderBy(x => x);
                using (var usedWriter = File.CreateText(usedhashtxt))
                {
                    foreach (var s in usedStrings)
                    {
                        usedWriter.WriteLine(s);
                    }
                }

                //var allhashes = _hashService.GetAllHashes().ToList();
                //var unused = allhashes.Except(used).ToList();

                //var unusedhashtxt = Path.Combine(resultDir, "unusedhashes.txt");
                //var unusedStrings = unused.Select(s => _hashService.Get(s)).OrderBy(x => x);
                //using (var unusedWriter = File.CreateText(usedhashtxt))
                //{
                //    foreach (var s in unusedStrings)
                //    {
                //        unusedWriter.WriteLine(s);
                //    }
                //}

                //compress all used and all missing hashes
                //CompressFile(unusedhashtxt, resultDir);
                CompressFile(usedhashtxt, resultDir);

            }


        }

        private void CompressFile(string path, string resultDir)
        {
            var inbuffer = File.ReadAllBytes(path);
            IEnumerable<byte> outBuffer = new List<byte>();

            var r = Oodle.Compress(inbuffer, ref outBuffer, true);

            var filename = $"{Path.GetFileNameWithoutExtension(path)}.kark";
            File.WriteAllBytes(Path.Combine(resultDir, filename), outBuffer.ToArray());
        }
    }
}
