using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.FunctionalTests.Model;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;

namespace WolvenKit.FunctionalTests
{
    [TestClass]
    public class ModKitTests : GameUnitTest
    {
        private const string s_LIMIT = "LIMIT";
        private const string s_KEEP = "KEEP";

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);


        [TestMethod]
        [DataRow(ECookedFileFormat.csv)]
        [DataRow(ECookedFileFormat.cubemap)]
        [DataRow(ECookedFileFormat.envprobe)]
        [DataRow(ECookedFileFormat.mesh)]
        [DataRow(ECookedFileFormat.mlmask)]
        [DataRow(ECookedFileFormat.morphtarget)]
        [DataRow(ECookedFileFormat.texarray)]
        [DataRow(ECookedFileFormat.wem)]
        [DataRow(ECookedFileFormat.xbm)]
        public async Task Test_ImportExport(ECookedFileFormat extension)
        {
            var ext = $".{extension}";
            var infiles = s_groupedFiles[ext].ToList();

            var modtools = _host.Services.GetRequiredService<IModTools>();
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

            ArgumentNullException.ThrowIfNull(s_config);
            var isKeep = bool.Parse(s_config.GetSection(s_KEEP).Value!);
            var isettings = new GlobalImportArgs().Register(
                new XbmImportArgs() { Keep = isKeep },
                new GltfImportArgs() { Keep = isKeep },
                new CommonImportArgs() { Keep = isKeep }
            );
            var esettings = new GlobalExportArgs();

            var uncookfails = new List<FileEntry>();
            var importfails = new List<FileEntry>();
            var equalfails = new List<FileEntry>();

            // random tests
            var random = new Random();
            var limit = Math.Min(int.Parse(s_config.GetSection(s_LIMIT).Value!), infiles.Count);
            var filesToTest = infiles.OrderBy(a => random.Next()).Take(limit).ToList();

            for (var i = 0; i < filesToTest.Count; i++)
            {
                if (filesToTest[i] is not FileEntry fileEntry)
                {
                    throw new InvalidGameContextException();
                }
                // skip files without buffers
                var hasBuffers = (fileEntry.SegmentsEnd - fileEntry.SegmentsStart) > 1;
                if (!hasBuffers)
                {
                    continue;
                }

                using var cr2wstream = new MemoryStream();
                await fileEntry.ExtractAsync(cr2wstream);
                var originalBytes = cr2wstream.ToByteArray();

                // uncook
                if (fileEntry.Archive is not Archive a)
                {
                    Assert.Fail($"Not a RED4 archive");
                    return;
                }
                var resUncook = modtools.UncookSingle(a, fileEntry.Key, resultDir, esettings,
                    resultDir);

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
                if (rawfile.Directory == null)
                {
                    Assert.Fail($"No raw file found in {resultDir}");
                }

                var redrelative = new RedRelativePath(rawfile.Directory, rawfile.Name);
                var resImport = await modtools.Import(redrelative, isettings);
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

        [TestMethod]
        [DataRow("audio_1_general.archive")]
        [DataRow("audio_2_soundbanks.archive")]
        [DataRow("basegame_1_engine.archive")]
        [DataRow("basegame_2_mainmenu.archive")]
        [DataRow("basegame_3_nightcity.archive")]
        [DataRow("basegame_3_nightcity_gi.archive")]
        [DataRow("basegame_3_nightcity_terrain.archive")]
        [DataRow("basegame_4_animation.archive")]
        [DataRow("basegame_4_appearance.archive")]
        [DataRow("basegame_4_gamedata.archive")]
        [DataRow("basegame_5_video.archive")]
        //[DataRow("lang_ar_text.archive")]
        //[DataRow("lang_cs_text.archive")]
        //[DataRow("lang_de_text.archive")]
        //[DataRow("lang_en_text.archive")]
        //[DataRow("lang_en_voice.archive")]
        //[DataRow("lang_es-es_text.archive")]
        //[DataRow("lang_es-mx_text.archive")]
        //[DataRow("lang_fr_text.archive")]
        //[DataRow("lang_hu_text.archive")]
        //[DataRow("lang_it_text.archive")]
        //[DataRow("lang_ja_text.archive")]
        //[DataRow("lang_ko_text.archive")]
        //[DataRow("lang_pl_text.archive")]
        //[DataRow("lang_pt_text.archive")]
        //[DataRow("lang_ru_text.archive")]
        //[DataRow("lang_th_text.archive")]
        //[DataRow("lang_tr_text.archive")]
        //[DataRow("lang_zh-cn_text.archive")]
        //[DataRow("lang_zh-tw_text.archive")]
        public void Test_Unbundle(string archivename)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);
            ArgumentNullException.ThrowIfNull(s_gameDirectoryPath);
            ArgumentNullException.ThrowIfNull(s_bm);

            var results = new ConcurrentBag<ArchiveTestResult>();
            var archiveFullName = Path.Combine(s_gameDirectoryPath, "archive", "pc", "content", archivename);

            var archive = s_bm.Archives.Lookup(archiveFullName).Value as Archive;
            ArgumentNullException.ThrowIfNull(archive);
            Parallel.ForEach(archive.Files, keyvalue =>
            {
                var (hash, _) = keyvalue;

                try
                {
                    using (var ms = new MemoryStream())
                    {
                        ModTools.ExtractSingleToStream(archive, hash, ms);
                    }
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

            var totalCount = archive.Files.Count;

            // Check success
            var successCount = results.Count(r => r.Success);
            var sb = new StringBuilder();
            sb.AppendLine($"Successfully unbundled: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");
            var success = results.All(r => r.Success);
            if (success)
            {
                return;
            }

            var msg = $"Successful Writes: {successCount} / {totalCount}. ";
            Assert.Fail(msg);
        }

        //public enum ECookedFileFormat
        //{
        //    wem,
        //    mesh,
        //    xbm,
        //    csv,
        //    //app,
        //    //ent,
        //    //json,
        //    mlmask,
        //    cubemap,
        //    envprobe,
        //    texarray,
        //    morphtarget,
        //    fnt,
        //    opusinfo,
        //    anims
        //}


        [TestMethod]
        [DataRow(ECookedFileFormat.wem)]
        [DataRow(ECookedFileFormat.mesh)]
        [DataRow(ECookedFileFormat.xbm)]
        [DataRow(ECookedFileFormat.csv)]
        [DataRow(ECookedFileFormat.mlmask)]
        [DataRow(ECookedFileFormat.cubemap)]
        [DataRow(ECookedFileFormat.envprobe)]
        [DataRow(ECookedFileFormat.texarray)]
        [DataRow(ECookedFileFormat.morphtarget)]
        [DataRow(ECookedFileFormat.fnt)]
        [DataRow(ECookedFileFormat.opusinfo)]
        [DataRow(ECookedFileFormat.anims)]
        public void Test_Uncook(ECookedFileFormat extension)
        {
            ArgumentNullException.ThrowIfNull(s_config);
            Environment.SetEnvironmentVariable("WOLVENKIT_ENVIRONMENT", "Testing", EnvironmentVariableTarget.Process);

            var ext = $".{extension}";
            var infiles = s_groupedFiles[ext].ToList();

            var modtools = _host.Services.GetRequiredService<IModTools>();
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

            var exportArgs = new GlobalExportArgs().Register(
                new XbmExportArgs()
                {
                    UncookExtension = EUncookExtension.png
                }
            );

            var uncookfails = new List<FileEntry>();

            // random tests
            //var random = new Random();
            //var limit = Math.Min(int.Parse(s_config.GetSection(s_LIMIT).Value), infiles.Count);
            //var filesToTest = infiles.OrderBy(a => random.Next()).Take(limit).ToList();
            var filesToTest = infiles.ToList();

            Parallel.ForEach(filesToTest, file =>
            //foreach (var fileEntry in filesToTest)
            {
                if (file is not FileEntry fileEntry)
                {
                    throw new InvalidGameContextException();
                }

                // skip files without buffers
                var hasBuffers = (fileEntry.SegmentsEnd - fileEntry.SegmentsStart) > 1;
                if (!hasBuffers)
                {
                    //continue;
                    return;
                }

                // uncook
                if (fileEntry.Archive is not Archive a)
                {
                    Assert.Fail($"Not a RED4 archive");
                    return;
                }
                var resUncook = modtools.UncookSingle(a, fileEntry.Key, resultDir,
                    exportArgs, resultDir);

                if (!resUncook)
                {
                    uncookfails.Add(fileEntry);
                }
            }
            );

            if (uncookfails.Count > 0)
            {
                foreach (var fileEntry in uncookfails)
                {
                    Console.WriteLine($"Failed to uncook - {fileEntry.FileName}");
                }
            }

            Assert.AreEqual(filesToTest.Count, filesToTest.Count - uncookfails.Count);
            //Assert.AreEqual(limit, limit - uncookfails.Count);
        }

    }
}
