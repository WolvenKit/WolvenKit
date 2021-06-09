using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Tools;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;
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
        //[DataRow("audio_1_general.archive")]
        [DataRow("basegame_1_engine.archive")]
        // [DataRow("basegame_2_mainmenu.archive")]
        // [DataRow("basegame_3_nightcity.archive")]
        // [DataRow("basegame_3_nightcity_gi.archive")]
        // [DataRow("basegame_3_nightcity_terrain.archive")]
        // [DataRow("basegame_4_animation.archive")]
        // [DataRow("basegame_4_appearance.archive")]
        // [DataRow("basegame_4_gamedata.archive")]
        public void Test_Cr2wSerialize(string archivename)
        {
            var parsers = ServiceLocator.Default.ResolveType<Red4ParserService>();

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            var totalCount = s_bm.Items.Count();
            var results = new ConcurrentBag<ArchiveTestResult>();
            var archiveFullName = Path.Combine(s_gameDirectoryPath, "archive", "pc", "content", archivename);

            var archive = s_bm.Archives[archiveFullName] as Archive;
            Parallel.ForEach(archive.Files, keyvalue =>
            {
                var (hash, file) = keyvalue;

                try
                {
                    #region serialize

                    using var ms = new MemoryStream();
                    ModTools.ExtractSingleToStream(archive, hash, ms);

                    var cr2w = parsers.TryReadCr2WFile(ms);
                    if (cr2w == null)
                    {
                        return;
                    }

                    var dto = new Red4W2rcFileDto(cr2w);
                    var json = JsonConvert.SerializeObject(
                        dto,
                        Formatting.Indented
                    );

                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    #endregion

                    #region deserialize

                    var newdto = JsonConvert.DeserializeObject<Red4W2rcFileDto>(json);
                    if (newdto == null)
                    {
                        throw new SerializationException();
                    }

                    var w2rc = newdto.ToW2rc();

                    using var newms = new MemoryStream();
                    using var bw = new BinaryWriter(newms);

                    w2rc.Write(bw);

                    #endregion

                    #region compare

                    var newbytes = newms.ToByteArray();
                    var oldbytes = ms.ToByteArray();
                    if (!oldbytes.SequenceEqual(newbytes))
                    {
                        throw new SerializationException();
                    }
                    else
                    {

                    }

                    #endregion

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

            // Check success
            var successCount = results.Count(r => r.Success);
            var sb = new StringBuilder();
            sb.AppendLine($"Successfully serialized: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");
            var success = results.All(r => r.Success);
            if (success)
            {
                return;
            }

            var msg = $"Successful serialized: {successCount} / {totalCount}. ";
            Assert.Fail(msg);
        }


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
        public void Test_ImportExport(ECookedFileFormat extension)
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
            var limit =  Math.Min(int.Parse(s_config.GetSection(s_LIMIT).Value), infiles.Count);
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

            var totalCount = s_bm.Items.Count();
            var results = new ConcurrentBag<ArchiveTestResult>();
            var archiveFullName = Path.Combine(s_gameDirectoryPath, "archive", "pc", "content", archivename);

            var archive = s_bm.Archives[archiveFullName] as Archive;
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
        public void Test_Uncook(ECookedFileFormat extension)
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

            var exportArgs = new GlobalExportArgs().Register(
                new XbmExportArgs()
                {
                    UncookExtension = EUncookExtension.png,
                    Flip = false
                }
            );

            var uncookfails = new List<FileEntry>();

            // random tests
            var random = new Random();
            var limit =  Math.Min(int.Parse(s_config.GetSection(s_LIMIT).Value), infiles.Count);
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
                var resUncook = modtools.UncookSingle(fileEntry.Archive as Archive, fileEntry.Key, resultDir,
                    exportArgs, resultDir, ECookedFileFormat.NONE);

                if (!resUncook)
                {
                    uncookfails.Add(fileEntry);
                    Cleanup();
                    continue;
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

            Assert.AreEqual(limit,  limit - uncookfails.Count);


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
