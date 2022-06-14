using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Utility
{
    [TestClass]
    public class DumpInfo : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void DumpExtensionInfo()
        {
            var parser = _host.Services.GetRequiredService<Red4ParserService>();

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
            ArgumentNullException.ThrowIfNull(s_bm);

            var parsers = _host.Services.GetRequiredService<Red4ParserService>();
            var _hashService = _host.Services.GetRequiredService<IHashService>();

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            // load new hashes
            var newHashesPath = Path.Combine(s_testResultsDirectory, "resourcePaths.txt");
            var newHashes = new Dictionary<ulong, string>();
            if (File.Exists(newHashesPath))
            {
                var lines = File.ReadAllLines(newHashesPath);
                foreach (var line in lines)
                {
                    var hash = FNV1A64HashAlgorithm.HashString(line);
                    if (!_hashService.Contains(hash))
                    {
                        if (!newHashes.ContainsKey(hash))
                        {
                            newHashes.Add(hash, line);
                        }
                    }
                }
                Console.WriteLine($"Loaded {newHashes.Count} new hashes from {newHashesPath}");
            }

            {
                List<ulong> newAdded = new();
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
                        if (hash == 6507781686736237035)
                        {

                        }

                        hashes.Add(hash);
                        if (fileInfoEntry is FileEntry fe && fe.NameOrHash == hash.ToString())
                        {
                            if (newHashes.ContainsKey(hash))
                            {
                                used.Add(hash);
                                newAdded.Add(hash);
                            }
                            else
                            {
                                missing.Add(hash);
                                info_missing[ar.Name].Add(hash);
                            }
                        }
                        else
                        {
                            used.Add(hash);
                        }
                    }

                    using var tw = File.CreateText(Path.Combine(resultDir, $"{ar.Name}_hashes.txt"));
                    foreach (var h in hashes)
                    {
                        tw.WriteLine(h);
                    }
                }

                Console.WriteLine($"Added {newAdded.Count} new hashes");

                // write all used and all missing hashes
                var info = Path.Combine(resultDir, $"_info_hashes.txt");
                var info_json = JsonSerializer.Serialize(info_missing, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                });
                File.WriteAllText(info, info_json);

                var missinghashtxt = Path.Combine(resultDir, "missinghashes.txt");
                missing = missing.OrderBy(x => x).Distinct().ToList();
                using (var missingWriter = File.CreateText(missinghashtxt))
                {
                    for (var i = 0; i < missing.Count; i++)
                    {
                        var mh = missing[i];
                        missingWriter.WriteLine(mh);
                    }
                }

                var usedhashtxt = Path.Combine(resultDir, "usedhashes.txt");
                var usedStrings = new List<string>();
                foreach (var hash in used)
                {
                    var str = "";
                    if (_hashService.Contains(hash))
                    {
                        str = _hashService.Get(hash);
                    }
                    else if (newHashes.ContainsKey(hash))
                    {
                        str = newHashes[hash];
                    }
                    else
                    {
                        continue;
                    }
                    usedStrings.Add(str);
                }
                usedStrings = usedStrings.OrderBy(x => x).Distinct().ToList();
                File.WriteAllLines(usedhashtxt, usedStrings);

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

        [TestMethod]
        public void DumpStrings()
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory, "infodump");
            Directory.CreateDirectory(resultDir);

            var existingFiles = new ConcurrentDictionary<string, byte>();
            foreach (var file in Directory.GetFiles(resultDir))
            {
                existingFiles.TryAdd(file, 0);
            }

            var archives = s_bm.Archives.KeyValues.Select(_ => _.Value).ToList();
            foreach (var gameArchive in archives)
            {
                if (gameArchive is not Archive archive)
                {
                    continue;
                }

                Parallel.ForEach(archive.Files, pair =>
                {
                    if (pair.Value is not FileEntry fileEntry)
                    {
                        return;
                    }

                    var resultPath = Path.Combine(resultDir, fileEntry.NameHash64 + ".txt");
                    if (existingFiles.TryRemove(resultPath, out _))
                    {
                        return;
                    }

                    try
                    {
                        using var ms = new MemoryStream();
                        archive.CopyFileToStream(ms, fileEntry.NameHash64, false);
                        ms.Seek(0, SeekOrigin.Begin);

                        using var reader = new CR2WReader(ms);
                        reader.CollectData = true;

                        if (reader.ReadFile(out _) == EFileReadErrorCodes.NoError)
                        {
                            reader.DataCollection.CleanUp();

                            reader.DataCollection.FileName = fileEntry.NameOrHash;
                            reader.DataCollection.Hash = fileEntry.NameHash64;

                            var json = JsonSerializer.Serialize(reader.DataCollection, new JsonSerializerOptions { WriteIndented = true });
                            File.WriteAllText(resultPath, json);
                        }
                    }
                    catch (Exception)
                    {
                        // ignore
                    }
                });
            }
        }
    }
}
