using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.CLI.MSTests;
using WolvenKit.RED4.CR2W.Archive;

namespace CP77.MSTests
{
    [TestClass]
    public class ArchiveTests : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #region Methods

        [TestMethod]
        public void Test_Unbundle()
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            var totalCount = s_bm.Archives.SelectMany(_ => _.Value.Files.Keys).Count();
            var results = new ConcurrentBag<ArchiveTestResult>();

            Parallel.ForEach(s_bm.Archives, file =>
            {
                var (archivename, archive) = file;
                Parallel.ForEach(archive.Files, keyvalue =>
                {
                    var (hash, _) = keyvalue;
                    var ms = new MemoryStream();
                    try
                    {
                        ModTools.ExtractSingleToStream(archive, hash, ms);
                        results.Add(new ArchiveTestResult()
                        {
                            ArchiveName = archivename,
                            Hash = hash.ToString(),
                            Success = true
                        });
                    }
                    catch (Exception e)
                    {
                        results.Add(new ArchiveTestResult()
                        {
                            ArchiveName = archivename,
                            Hash = hash.ToString(),
                            Success = false,
                            ExceptionType = e.GetType(),
                            Message = $"{e.Message}"
                        });
                    }
                });
            });

            // Check success
            var successCount = results.Count(r => r.Success);
            var sb = new StringBuilder();
            sb.AppendLine(
                $"Successfully unbundled: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");
            var success = results.All(r => r.Success);
            if (success)
            {
                return;
            }

            var msg = $"Successful Writes: {successCount} / {totalCount}. ";
            Assert.Fail(msg);
        }

        [TestMethod]
        public void Test_Uncook()
        {
            
        }

        #endregion Methods
    }
}
