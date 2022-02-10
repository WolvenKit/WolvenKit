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
using WolvenKit.RED4.Types;
using WolvenKit.Modkit.RED4.Sounds;
using System.Text.Json;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class _DumpInfo : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void DumpSoundEvents()
        {
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var eventsInfo = s_groupedFiles[".json"].FirstOrDefault(x => x.Name.Contains("eventsmetadata.json"));
            if (eventsInfo != null)
            {
                var hash = eventsInfo.Key;
                var archive = eventsInfo.Archive as Archive;

                using var originalMemoryStream = new MemoryStream();
                ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);
                if (!parser.TryReadRed4File(originalMemoryStream, out var originalFile))
                {
                    Assert.Fail("failed to find the file");
                    return;
                }
                if (originalFile.RootChunk is not JsonResource jsonRes)
                {
                    Assert.Fail("not a JsonResource");
                    return;
                }
                if (jsonRes.Root.GetValue() is not audioAudioEventArray eventArray)
                {
                    Assert.Fail("not an audioAudioEventArray");
                    return;
                }

                var md = new SoundEventMetadata();
                var events = eventArray.Events;
                foreach (var e in events)
                {
                    var item = new SoundEvent()
                    {
                        Name = e.RedId.ToString(),
                        Tags = e.Tags.Select(x => x.ToString()).ToList(),
                    };
                    md.Events.Add(item);
                }

                var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
                Directory.CreateDirectory(resultDir);
                var path = Path.Combine(resultDir, "soundEvents.json");

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                var jsonString = JsonSerializer.Serialize(md, options);
                File.WriteAllText(path, jsonString);

                // test
                var _metadata = JsonSerializer.Deserialize<SoundEventMetadata>(File.ReadAllText(path), options);
            }
        }

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

                var archives = s_bm.Archives.KeyValues.Select(_ => _.Value).ToList();

                for (var i = 0; i < archives.Count; i++)
                {
                    var ar = archives[i];
                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        if (fileInfoEntry is FileEntry fe && fe.NameOrHash == hash.ToString())
                        {
                            missing.Add(hash);
                        }
                        else
                        {
                            used.Add(hash);
                        }
                    }
                }

                // write all used and all missing hashes

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

                using (var usedWriter = File.CreateText(usedhashtxt))
                {
                    for (var i = 0; i < used.Count; i++)
                    {
                        var mh = used[i];
                        usedWriter.WriteLine(_hashService.Get(mh));
                    }
                }

                var allhashes = _hashService.GetAllHashes().ToList();
                var unused = allhashes.Except(used).ToList();

                var unusedhashtxt = Path.Combine(resultDir, "unusedhashes.txt");

                using (var unusedWriter = File.CreateText(unusedhashtxt))
                {
                    for (var i = 0; i < unused.Count; i++)
                    {
                        var h = unused[i];

                        unusedWriter.WriteLine(_hashService.Get(h));
                    }
                }

                //compress all used and all missing hashes
                CompressFile(unusedhashtxt, resultDir);
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
