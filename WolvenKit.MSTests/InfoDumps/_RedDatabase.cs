using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Database;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class _RedDataBase : GameUnitTest
    {

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void aGenerateDB()
        {
            using var db = new RedDBContext();

            var sw = new Stopwatch();
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            var allFiles = s_bm.Archives.Items
                                .SelectMany(x => x.Files.Values)
                                .ToList();

            Console.WriteLine($"collect all models...");
            sw.Restart();
            var dblist = new Dictionary<ulong, RedFile>();
            foreach (var file in allFiles)
            {
                if (dblist.ContainsKey(file.Key))
                {
                    continue;
                }
                var redFile = new RedFile() { RedFileId = file.Key, Name = file.Name };
                dblist.Add(redFile.RedFileId, redFile);
            }

            sw.Stop();
            Console.WriteLine($"collect all models: {sw.ElapsedMilliseconds}ms");

            // add to DB
            Console.WriteLine($"add to DB...");
            sw.Restart();
            foreach (var (_, redFile) in dblist)
            {
                db.Add(redFile);
            }
            db.SaveChanges();
            sw.Stop();
            Console.WriteLine($"add to DB: {sw.ElapsedMilliseconds}ms");
        }

        private void CleanDataBase()
        {
            var sw = new Stopwatch();

            using var db = new RedDBContext();

            Console.WriteLine($"clean database...");
            sw.Start();
            if (db.Files != null && db.Files.Any())
            {
                db.Files.RemoveRange(db.Files);
            }
            db.SaveChanges();

            sw.Stop();
            Console.WriteLine($"clean database: {sw.ElapsedMilliseconds}ms");
        }

        [TestMethod]
        public void bAddArchiveNames()
        {
            using var db = new RedDBContext();
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();

            foreach (var item in db.Files)
            {
                var file = s_bm.Lookup(item.RedFileId);
                if (file.HasValue)
                {
                    item.Archive = Path.GetFileNameWithoutExtension(file.Value.Archive.Name);
                }
            }
            db.SaveChanges();
        }

        /// <summary>
        /// You can use the resources_XXX zip and extract it to <resultDir> to speed up the generation
        /// </summary>
        [TestMethod]
        public void cSetUses()
        {
            var sw = new Stopwatch();
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);
            using var db = new RedDBContext();

            // set uses files
            Console.WriteLine($"set uses files...");
            sw.Restart();

            var excludedExtensions = new List<string>() { ".wem", ".bin", ".bnk", ".opuspak", ".opusinfo", ".bk2", ".dat" };

            // Run Test
            foreach (var (ext, files) in s_groupedFiles.Where(_ => !excludedExtensions.Contains(_.Key)))
            {
                var dbDict = new ConcurrentDictionary<ulong, ulong[]>();

                var dataFile = Path.Combine(resultDir, $"{ext[1..]}.txt");
                if (File.Exists(dataFile))
                {
                    var lines = File.ReadAllLines(dataFile);
                    foreach (var line in lines)
                    {
                        var keysplits = line.Split(": ");
                        var key = ulong.Parse(keysplits[0]);
                        var uses = keysplits[1].Split(',').Select(x => ulong.Parse(x)).ToArray();

                        dbDict.AddOrUpdate(key, uses, (key, values) => uses);
                    }
                }
                else
                {
                    Parallel.ForEach(files, file =>
                    {
                        var hash = file.Key;
                        var archive = file.Archive as Archive;

                        try
                        {
                            using var originalMemoryStream = new MemoryStream();
                            ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);

                            using var reader = new CR2WReader(originalMemoryStream);

                            var cr2w = parser.TryReadRed4FileHeaders(originalMemoryStream);
                            if (cr2w != null)
                            {
                                if (cr2w.Imports.Any())
                                {
                                    var imports = cr2w.Imports.Select(x => FNV1A64HashAlgorithm.HashString(x.DepotPath)).ToArray();
                                    dbDict.AddOrUpdate(hash, imports, (key, oldValue) => imports);
                                }
                            }
                            else
                            {

                            }
                        }
                        catch (Exception)
                        {

                        }
                    });

                    using var strw = new StringWriter();
                    foreach (var (key, uses) in dbDict)
                    {
                        strw.WriteLine($"{key}: {string.Join(",", uses)}");
                    }
                    File.WriteAllText(Path.Combine(resultDir, $"{ext[1..]}.txt"), strw.ToString());
                }

                foreach (var info in dbDict)
                {
                    var hash = info.Key;
                    var dbfile = db.Find(typeof(RedFile), hash);
                    if (dbfile is RedFile redfile)
                    {
                        redfile.Uses = info.Value;
                    }
                }
            }

            sw.Stop();
            Console.WriteLine($"set uses files: {sw.ElapsedMilliseconds}ms");

            db.SaveChanges();
        }

        [TestMethod]
        public void dSetusedBy()
        {
            var sw = new Stopwatch();
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();

            using var db = new RedDBContext();

            // set usedby files
            Console.WriteLine($"set usedby files...");
            sw.Restart();
            foreach (var file in db.Files)
            {
                var hash = file.RedFileId;
                var usedBy = db.Files.Where(x => x.Uses.Contains(hash));

                if (usedBy.Any())
                {
                    file.UsedBy = usedBy.Select(x => x.RedFileId).ToArray();
                }

            }
            sw.Stop();
            Console.WriteLine($"set usedby files: {sw.ElapsedMilliseconds}ms");
        }

        [TestMethod]
        public void _TestWhere()
        {
            using var db = new RedDBContext();

            var judy = db.Files
                .Where(x => x.Name.Contains("judy"))
                .ToList();

            foreach (var item in judy)
            {
                var hash = item.RedFileId;
                var x = db.Files
                    .Where(delegate (RedFile x)
                    {
                        return x.Uses != null && x.Uses.Contains(hash);
                    })
                    .ToList();

                var uses = item.Uses != null ? string.Join('-', item.Uses) : "";
                var usedby = string.Join('-', x.Select(_ => _.RedFileId));
                Console.WriteLine($"{item.RedFileId}, {item.Archive}, {item.Name}, {uses}, {usedby}");   
            }
        }
        
    }
}
