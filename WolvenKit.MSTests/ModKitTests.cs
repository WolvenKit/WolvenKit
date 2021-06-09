using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W.Archive;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class ModKitTests : GameUnitTest
    {
        private const bool KEEP = true;
        private const bool RANDOM = true;
        private const int LIMIT = 1000;

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #region Methods

        [TestMethod]
        [DataRow(ERedExtension.xbm)]
        //[DataRow(ERedExtension.mesh)]
        public void Test_Rebuild(ERedExtension extension)
        {
            var ext = $".{extension.ToString()}";
            var infiles = s_groupedFiles[ext].ToList();

            var modtools = ServiceLocator.Default.ResolveType<ModTools>();
            var resultDir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory, "temp"));
            if (!resultDir.Exists)
            {
                Directory.CreateDirectory(resultDir.FullName);
            }
            var logDir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory, "logs"));
            if (!resultDir.Exists)
            {
                Directory.CreateDirectory(logDir.FullName);
            }

            var isettings = new GlobalImportArgs().Register(
                new XbmImportArgs() { Keep = KEEP },
                new MeshImportArgs() { Keep = KEEP },
                new CommonImportArgs() { Keep = KEEP }
            );
            var esettings = new GlobalExportArgs();

            var fails = new List<FileEntry>();

            // random tests
            var random = new Random();
            var filesToTest = infiles;
            if (RANDOM)
            {
                filesToTest = infiles.OrderBy(a => random.Next()).Take(LIMIT).ToList();
            }

            for (var i = 0; i < filesToTest.Count; i++)
            {
                var fileEntry = filesToTest[i];
                // skip files without buffers
                var hasBuffers = (fileEntry.SegmentsEnd - fileEntry.SegmentsStart) > 1;
                if (!hasBuffers)
                {
                    continue;
                }

                var ar = fileEntry.Archive as Archive;
                using var cr2wstream = new MemoryStream();
                ar.CopyFileToStream(cr2wstream, fileEntry.NameHash64, false);
                var originalBytes = cr2wstream.ToByteArray();


                // uncook
                var resUncook = modtools.UncookSingle(fileEntry.Archive as Archive, fileEntry.Key, resultDir, esettings,
                    resultDir);

                if (!resUncook)
                {
                    fails.Add(fileEntry);
                }

                // rebuild
                var allfiles = resultDir.GetFiles("*", SearchOption.AllDirectories);
                var rawfile = allfiles.FirstOrDefault(_ => _.Extension != ext);
                if (rawfile == null)
                {
                    Assert.Fail($"No raw file found in {resultDir}");
                }

                var resImport = modtools.Import(rawfile, isettings);
                if (!resImport)
                {
                    fails.Add(fileEntry);
                }

                // compare
                var redfile = allfiles.FirstOrDefault(_ => _.Extension == ext);
                if (redfile == null)
                {
                    Assert.Fail($"No red file found in {resultDir}");
                }

                var newbytes = File.ReadAllBytes(redfile.FullName);

                if (!originalBytes.SequenceEqual(newbytes))
                {
                    fails.Add(fileEntry);

                    var filename = Path.GetFileName(fileEntry.FileName);
                    var dbgOriginalFile = Path.Combine(logDir.FullName, filename);
                    var dbgNewFile = Path.Combine(logDir.FullName, $"{filename}.new");
                    File.WriteAllBytes(dbgOriginalFile, originalBytes);
                    File.WriteAllBytes(dbgNewFile, newbytes);
                }
                else
                {
                }

                // clean temp dir
                try
                {
                    foreach (var fileInfo in allfiles)
                    {
                        fileInfo.Delete();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }


            if (fails.Count > 0)
            {
                foreach (var fileEntry in fails)
                {
                    Console.WriteLine(fileEntry.FileName);
                }
            }
            

            Assert.AreEqual(0, fails.Count);


            // cleanup
            var allf = resultDir.GetFiles("*", SearchOption.AllDirectories);
            foreach (var fileInfo in allf)
            {
                fileInfo.Delete();
            }
            var alld = resultDir.GetDirectories();
            foreach (var directoryInfo in alld)
            {
                directoryInfo.Delete(true);
            }
        }

        #endregion Methods
    }
}
