using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.MSTests.Model;
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
            db.SaveChanges();

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

        [TestMethod]
        public void cSetUses()
        {
            var sw = new Stopwatch();
            var parser = ServiceLocator.Default.ResolveType<Red4ParserService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();

            using var db = new RedDBContext();

            // set uses files
            Console.WriteLine($"set uses files...");
            sw.Restart();
            foreach (var file in db.Files)
            {
                var hash = file.RedFileId;
                var bfile = s_bm.Lookup(hash);
                if (!bfile.HasValue)
                {
                    continue;
                }

                // extract file from bundle manager
                using var originalMemoryStream = new MemoryStream();
                ModTools.ExtractSingleToStream(bfile.Value.Archive as Archive, hash, originalMemoryStream);
                var cr2w = parser.TryReadRED4FileHeaders(originalMemoryStream);
                if (cr2w is not null)
                {
                    if (cr2w.Imports.Any())
                    {
                        var imports = cr2w.Imports.Select(x => FNV1A64HashAlgorithm.HashString(x.DepotPathStr));
                        file.Uses = imports.ToArray();
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
        public void _TestDb()
        {
            var sw = new Stopwatch();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();

            using var db = new RedDBContext();

            var judy = db.Files.Where(x => x.Name.Contains("judy"));

            foreach (var item in judy)
            {
                Console.WriteLine(item.Name);   
            }
        }
    }
}
