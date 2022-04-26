using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Database;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Utility
{
    [TestClass]
    public class RedDatabase : GameUnitTest
    {

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void aGenerateDB()
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            RedDBContext.ClearDatabase();

            using var db = new RedDBContext();
            foreach (var archive in s_bm.Archives.Items.Reverse())
            {
                db.Add(new RedArchive { Name = archive.Name });
            }
            db.SaveChanges();
        }

        [TestMethod]
        public void bGetAllFiles()
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var infoDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory, "infodump");

            var importDict = new Dictionary<string, ConcurrentDictionary<ulong, ulong[]>>();
            foreach (var archiveInfoDir in Directory.GetDirectories(infoDir))
            {
                var fileImports = new ConcurrentDictionary<ulong, ulong[]>();
                Parallel.ForEach(Directory.GetFiles(archiveInfoDir), infoFile =>
                {
                    var data = JsonSerializer.Deserialize<DataCollection>(File.ReadAllText(infoFile))!;

                    var imports = GetImports(data);
                    if (imports.Count > 0)
                    {
                        fileImports.TryAdd(data.Hash, imports.ToArray());
                    }
                });

                importDict.Add(Path.GetFileName(archiveInfoDir) + ".archive", fileImports);
            }

            using var db = new RedDBContext();

            var files = new List<RedFile>();
            foreach (var dbArchive in db.Archives)
            {
                if (s_bm.Archives.Items.FirstOrDefault(x => x.Name == dbArchive.Name) is not Archive archive)
                {
                    throw new Exception();
                }

                var fileImports = importDict[archive.Name];
                foreach (var (hash, file) in archive.Files)
                {
                    var dbFile = new RedFile { ArchiveId = dbArchive.Id, Hash = hash };

                    if (fileImports.ContainsKey(hash))
                    {
                        dbFile.Uses = new List<RedFileUse>();
                        foreach (var import in fileImports[hash])
                        {
                            dbFile.Uses.Add(new RedFileUse {Hash = import});
                        }
                    }

                    files.Add(dbFile);
                }
            }

            var fileUses = new List<RedFileUse>();
            using (var transaction = db.Database.BeginTransaction())
            {
                db.BulkInsert(files, new BulkConfig { SetOutputIdentity = true });
                foreach (var entity in files)
                {
                    if (entity.Uses != null)
                    {
                        foreach (var subEntity in entity.Uses)
                        {
                            subEntity.RedFileId = entity.Id;
                        }
                        fileUses.AddRange(entity.Uses);
                    }
                }
                db.BulkInsert(fileUses);
                transaction.Commit();
            }

            db.SaveChanges();

            HashSet<ulong> GetImports(DataCollection dc)
            {
                var result = new HashSet<ulong>();

                if (dc.Imports != null)
                {
                    foreach (var import in dc.Imports)
                    {
                        result.Add(FNV1A64HashAlgorithm.HashString(import));
                    }
                }

                if (dc.Buffers != null)
                {
                    foreach (var buffer in dc.Buffers)
                    {
                        result.UnionWith(GetImports(buffer));
                    }
                }

                return result;
            }
        }

        [TestMethod]
        public void cCompress()
        {
            using var db = new RedDBContext();

            if (!File.Exists(db.DbPath))
            {
                throw new Exception();
            }

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);

            var buffer = RedBuffer.CreateBuffer(0, File.ReadAllBytes(db.DbPath));
            File.WriteAllBytes(Path.Combine(resultDir, "red.kark"), buffer.GetCompressedBytes());
        }
    }
}
