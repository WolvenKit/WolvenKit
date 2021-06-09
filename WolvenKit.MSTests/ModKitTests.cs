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
        private const string s_LIMIT = "LIMIT";
        private const string s_KEEP = "KEEP";

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #region Methods

        [TestMethod]
        //[DataRow(ERedExtension.xbm)]
        [DataRow(ERedExtension.mesh)]
        public void Test_ImportExport(ERedExtension extension)
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
            if (!logDir.Exists)
            {
                Directory.CreateDirectory(logDir.FullName);
            }

            var isKeep = bool.Parse(s_config.GetSection(s_KEEP).Value);
            var isettings = new GlobalImportArgs().Register(
                new XbmImportArgs() { Keep = isKeep },
                new MeshImportArgs() { Keep = isKeep },
                new CommonImportArgs() { Keep = isKeep }
            );
            var esettings = new GlobalExportArgs();

            var uncookfails = new List<FileEntry>();
            var importfails = new List<FileEntry>();
            var equalfails = new List<FileEntry>();

            // random tests
            var random = new Random();
            var limit = int.Parse(s_config.GetSection(s_LIMIT).Value);
            var filesToTest = infiles.OrderBy(a => random.Next()).Take(limit).ToList();

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
                    resultDir, ECookedFileFormat.NONE);

                if (!resUncook)
                {
                    uncookfails.Add(fileEntry);
                    Cleanup();
                    continue;
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
                    importfails.Add(fileEntry);
                    Cleanup();
                    continue;
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
                    equalfails.Add(fileEntry);

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
                Cleanup();
            }


            if (uncookfails.Count > 0)
            {
                foreach (var fileEntry in uncookfails)
                {
                    Console.WriteLine($"Failed to uncook - {fileEntry.FileName}");
                }
            }
            if (importfails.Count > 0)
            {
                foreach (var fileEntry in importfails)
                {
                    Console.WriteLine($"Failed to import - {fileEntry.FileName}");
                }
            }
            if (equalfails.Count > 0)
            {
                foreach (var fileEntry in equalfails)
                {
                    Console.WriteLine($"Not binary equal - {fileEntry.FileName}");
                }
            }

            Assert.AreEqual(0, uncookfails.Count + importfails.Count + equalfails.Count);


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

            void Cleanup()
            {
                var allfiles = resultDir.GetFiles("*", SearchOption.AllDirectories);
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
        }



        #endregion Methods
    }
}
