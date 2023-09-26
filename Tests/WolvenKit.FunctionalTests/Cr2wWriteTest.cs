#define IS_PARALLEL

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.FunctionalTests.Model;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;
using WolvenKit.RED4.Types;

#if IS_PARALLEL
using System.Threading.Tasks;
#endif

namespace WolvenKit.FunctionalTests
{
    [TestClass]
    public class Cr2wWriteTest : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        private const bool TEST_EXISTING = true;
        private const bool WRITE_FAILED = false;
        private const bool DECOMPRESS_BUFFERS = true;

        #region test methods

        //[TestMethod]
        //public void Test_All_Extensions()
        //{
        //    Test_Extension();
        //}

        [TestMethod]
        public void Write_acousticdata() => Test_Extension(".acousticdata");

        [TestMethod]
        public void Write_actionanimdb() => Test_Extension(".actionanimdb");

        [TestMethod]
        public void Write_aiarch() => Test_Extension(".aiarch");

        [TestMethod]
        public void Write_animgraph() => Test_Extension(".animgraph");

        [TestMethod]
        public void Write_anims() => Test_Extension(".anims");

        [TestMethod]
        public void Write_app() => Test_Extension(".app");

        [TestMethod]
        public void Write_archetypes() => Test_Extension(".archetypes");

        [TestMethod]
        public void Write_areas() => Test_Extension(".areas");

        [TestMethod]
        public void Write_audio_metadata() => Test_Extension(".audio_metadata");

        [TestMethod]
        public void Write_audiovehcurveset() => Test_Extension(".audiovehcurveset");

        [TestMethod]
        public void Write_behavior() => Test_Extension(".behavior");

        [TestMethod]
        public void Write_bikecurveset() => Test_Extension(".bikecurveset");

        [TestMethod]
        public void Write_bin() => Test_Extension(".bin");

        [TestMethod]
        public void Write_bk2() => Test_Extension(".bk2");

        [TestMethod]
        public void Write_bnk() => Test_Extension(".bnk");

        [TestMethod]
        public void Write_camcurveset() => Test_Extension(".camcurveset");

        [TestMethod]
        public void Write_ccstate() => Test_Extension(".ccstate");

        [TestMethod]
        public void Write_cfoliage() => Test_Extension(".cfoliage");

        [TestMethod]
        public void Write_charcustpreset() => Test_Extension(".charcustpreset");

        [TestMethod]
        public void Write_chromaset() => Test_Extension(".chromaset");

        [TestMethod]
        public void Write_cminimap() => Test_Extension(".cminimap");

        [TestMethod]
        public void Write_community() => Test_Extension(".community");

        [TestMethod]
        public void Write_conversations() => Test_Extension(".conversations");

        [TestMethod]
        public void Write_cooked_mlsetup() => Test_Extension(".cooked_mlsetup");

        [TestMethod]
        public void Write_cookedanims() => Test_Extension(".cookedanims");

        [TestMethod]
        public void Write_cookedapp() => Test_Extension(".cookedapp");

        [TestMethod]
        public void Write_cookedprefab() => Test_Extension(".cookedprefab");

        [TestMethod]
        public void Write_credits() => Test_Extension(".credits");

        [TestMethod]
        public void Write_csv() => Test_Extension(".csv");

        [TestMethod]
        public void Write_cubemap() => Test_Extension(".cubemap");

        [TestMethod]
        public void Write_curveresset() => Test_Extension(".curveresset");

        [TestMethod]
        public void Write_curveset() => Test_Extension(".curveset");

        [TestMethod]
        public void Write_dat() => Test_Extension(".dat");

        [TestMethod]
        public void Write_devices() => Test_Extension(".devices");

        [TestMethod]
        public void Write_dtex() => Test_Extension(".dtex");

        [TestMethod]
        public void Write_effect() => Test_Extension(".effect");

        [TestMethod]
        public void Write_ent() => Test_Extension(".ent");

        [TestMethod]
        public void Write_env() => Test_Extension(".env");

        [TestMethod]
        public void Write_envparam() => Test_Extension(".envparam");

        [TestMethod]
        public void Write_envprobe() => Test_Extension(".envprobe");

        [TestMethod]
        public void Write_es() => Test_Extension(".es");

        [TestMethod]
        public void Write_facialcustom() => Test_Extension(".facialcustom");

        [TestMethod]
        public void Write_facialsetup() => Test_Extension(".facialsetup");

        [TestMethod]
        public void Write_fb2tl() => Test_Extension(".fb2tl");

        [TestMethod]
        public void Write_fnt() => Test_Extension(".fnt");

        [TestMethod]
        public void Write_folbrush() => Test_Extension(".folbrush");

        [TestMethod]
        public void Write_foldest() => Test_Extension(".foldest");

        [TestMethod]
        public void Write_fp() => Test_Extension(".fp");

        [TestMethod]
        public void Write_game() => Test_Extension(".game");

        [TestMethod]
        public void Write_gamedef() => Test_Extension(".gamedef");

        [TestMethod]
        public void Write_garmentlayerparams() => Test_Extension(".garmentlayerparams");

        [TestMethod]
        public void Write_genericanimdb() => Test_Extension(".genericanimdb");

        [TestMethod]
        public void Write_geometry_cache() => Test_Extension(".geometry_cache");

        [TestMethod]
        public void Write_gidata() => Test_Extension(".gidata");

        [TestMethod]
        public void Write_gradient() => Test_Extension(".gradient");

        [TestMethod]
        public void Write_hitrepresentation() => Test_Extension(".hitrepresentation");

        [TestMethod]
        public void Write_hp() => Test_Extension(".hp");

        [TestMethod]
        public void Write_ies() => Test_Extension(".ies");

        [TestMethod]
        public void Write_inkanim() => Test_Extension(".inkanim");

        [TestMethod]
        public void Write_inkatlas() => Test_Extension(".inkatlas");

        [TestMethod]
        public void Write_inkcharcustomization() => Test_Extension(".inkcharcustomization");

        [TestMethod]
        public void Write_inkenginesettings() => Test_Extension(".inkenginesettings");

        [TestMethod]
        public void Write_inkfontfamily() => Test_Extension(".inkfontfamily");

        [TestMethod]
        public void Write_inkfullscreencomposition() => Test_Extension(".inkfullscreencomposition");

        [TestMethod]
        public void Write_inkgamesettings() => Test_Extension(".inkgamesettings");

        [TestMethod]
        public void Write_inkhud() => Test_Extension(".inkhud");

        [TestMethod]
        public void Write_inklayers() => Test_Extension(".inklayers");

        [TestMethod]
        public void Write_inkmenu() => Test_Extension(".inkmenu");

        [TestMethod]
        public void Write_inkshapecollection() => Test_Extension(".inkshapecollection");

        [TestMethod]
        public void Write_inkstyle() => Test_Extension(".inkstyle");

        [TestMethod]
        public void Write_inktypography() => Test_Extension(".inktypography");

        [TestMethod]
        public void Write_inkwidget() => Test_Extension(".inkwidget");

        [TestMethod]
        public void Write_interaction() => Test_Extension(".interaction");

        [TestMethod]
        public void Write_journal() => Test_Extension(".journal");

        [TestMethod]
        public void Write_journaldesc() => Test_Extension(".journaldesc");

        [TestMethod]
        public void Write_json() => Test_Extension(".json");

        [TestMethod]
        public void Write_lane_connections() => Test_Extension(".lane_connections");

        [TestMethod]
        public void Write_lane_polygons() => Test_Extension(".lane_polygons");

        [TestMethod]
        public void Write_lane_spots() => Test_Extension(".lane_spots");

        [TestMethod]
        public void Write_lights() => Test_Extension(".lights");

        [TestMethod]
        public void Write_lipmap() => Test_Extension(".lipmap");

        [TestMethod]
        public void Write_location() => Test_Extension(".location");

        [TestMethod]
        public void Write_locopaths() => Test_Extension(".locopaths");

        [TestMethod]
        public void Write_loot() => Test_Extension(".loot");

        [TestMethod]
        public void Write_mappins() => Test_Extension(".mappins");

        [TestMethod]
        public void Write_matlib() => Test_Extension(".matlib");

        [TestMethod]
        public void Write_mesh() => Test_Extension(".mesh");

        [TestMethod]
        public void Write_mi() => Test_Extension(".mi");

        [TestMethod]
        public void Write_mlmask() => Test_Extension(".mlmask");

        [TestMethod]
        public void Write_mlsetup() => Test_Extension(".mlsetup");

        [TestMethod]
        public void Write_mltemplate() => Test_Extension(".mltemplate");

        [TestMethod]
        public void Write_morphtarget() => Test_Extension(".morphtarget");

        [TestMethod]
        public void Write_mt() => Test_Extension(".mt");

        [TestMethod]
        public void Write_null_areas() => Test_Extension(".null_areas");

        [TestMethod]
        public void Write_opusinfo() => Test_Extension(".opusinfo");

        [TestMethod]
        public void Write_opuspak() => Test_Extension(".opuspak");

        [TestMethod]
        public void Write_particle() => Test_Extension(".particle");

        [TestMethod]
        public void Write_phys() => Test_Extension(".phys");

        [TestMethod]
        public void Write_physicalscene() => Test_Extension(".physicalscene");

        [TestMethod]
        public void Write_physmatlib() => Test_Extension(".physmatlib");

        [TestMethod]
        public void Write_poimappins() => Test_Extension(".poimappins");

        [TestMethod]
        public void Write_psrep() => Test_Extension(".psrep");

        [TestMethod]
        public void Write_quest() => Test_Extension(".quest");

        [TestMethod]
        public void Write_questphase() => Test_Extension(".questphase");

        [TestMethod]
        public void Write_regionset() => Test_Extension(".regionset");

        [TestMethod]
        public void Write_remt() => Test_Extension(".remt");

        [TestMethod]
        public void Write_reps() => Test_Extension(".reps");

        [TestMethod]
        public void Write_reslist() => Test_Extension(".reslist");

        [TestMethod]
        public void Write_rig() => Test_Extension(".rig");

        [TestMethod]
        public void Write_scene() => Test_Extension(".scene");

        [TestMethod]
        public void Write_scenerid() => Test_Extension(".scenerid");

        [TestMethod]
        public void Write_scenesversions() => Test_Extension(".scenesversions");

        [TestMethod]
        public void Write_smartobject() => Test_Extension(".smartobject");

        [TestMethod]
        public void Write_smartobjects() => Test_Extension(".smartobjects");

        [TestMethod]
        public void Write_sp() => Test_Extension(".sp");

        [TestMethod]
        public void Write_spatial_representation() => Test_Extension(".spatial_representation");

        [TestMethod]
        public void Write_streamingblock() => Test_Extension(".streamingblock");

        [TestMethod]
        public void Write_streamingquerydata() => Test_Extension(".streamingquerydata");

        [TestMethod]
        public void Write_streamingsector() => Test_Extension(".streamingsector");

        [TestMethod]
        public void Write_streamingsector_inplace() => Test_Extension(".streamingsector_inplace");

        [TestMethod]
        public void Write_streamingworld() => Test_Extension(".streamingworld");

        [TestMethod]
        public void Write_terrainsetup() => Test_Extension(".terrainsetup");

        [TestMethod]
        public void Write_texarray() => Test_Extension(".texarray");

        [TestMethod]
        public void Write_traffic_collisions() => Test_Extension(".traffic_collisions");

        [TestMethod]
        public void Write_traffic_persistent() => Test_Extension(".traffic_persistent");

        [TestMethod]
        public void Write_vehcommoncurveset() => Test_Extension(".vehcommoncurveset");

        [TestMethod]
        public void Write_vehcurveset() => Test_Extension(".vehcurveset");

        [TestMethod]
        public void Write_voicetags() => Test_Extension(".voicetags");

        [TestMethod]
        public void Write_w2mesh() => Test_Extension(".w2mesh");

        [TestMethod]
        public void Write_w2mi() => Test_Extension(".w2mi");

        [TestMethod]
        public void Write_wem() => Test_Extension(".wem");

        [TestMethod]
        public void Write_workspot() => Test_Extension(".workspot");

        [TestMethod]
        public void Write_xbm() => Test_Extension(".xbm");

        [TestMethod]
        public void Write_xcube() => Test_Extension(".xcube");

        #endregion test methods

        private void Test_Extension(string extension)
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            // Run Test
            List<WriteTestResult> results = new();
            List<IGameFile> filesToTest = new();
            var resultPath = Path.Combine(resultDir, $"write.{extension[1..]}.csv");
            if (File.Exists(resultPath) && TEST_EXISTING)
            {
                foreach (var line in File.ReadAllLines(resultPath)
                    .Skip(1)
                    .Where(_ => !string.IsNullOrEmpty(_)))
                {
                    if (ulong.TryParse(line.Split(',').First(), out var hash))
                    {
                        if (s_bm.Lookup(hash).Value is FileEntry entry)
                        {
                            filesToTest.Add(entry);
                        }
                    }
                }
            }
            else
            {
                filesToTest = s_groupedFiles[extension].ToList();
            }

            results = Write_Archive_Items(filesToTest).ToList();

            // Evaluate
            var successCount = results.Count(r => r.Success);

            // Write
            if (s_writeToFile)
            {
                if (results.Any(r => !r.Success))
                {
                    var csv = TestResultAsCsv(results.Where(r => !r.Success));
                    File.WriteAllText(resultPath, csv);
                }
            }

            // Logging
            var totalCount = filesToTest.Count;
            var sb = new StringBuilder();
            sb.AppendLine(
                $"{extension} -> Successful Writes: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");

            var success = results.All(r => r.Success);

            var logPath = Path.Combine(resultDir, $"w_logfile_{(string.IsNullOrEmpty(extension) ? string.Empty : $"{extension[1..]}_")}{DateTime.Now:yyyyMMddHHmmss}.log");
            File.WriteAllText(logPath, sb.ToString());
            Console.WriteLine(sb.ToString());

            if (!success)
            {
                var msg = $"Successful Writes: {successCount} / {totalCount}. ";

                Assert.Fail(msg);
            }
        }

        private static IEnumerable<WriteTestResult> Write_Archive_Items(IEnumerable<IGameFile> files)
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var results = new ConcurrentBag<WriteTestResult>();

            var filesGroups = files.Select((f, i) => new { Value = f, Index = i })
                .GroupBy(item => item.Value.GetArchive().ArchiveAbsolutePath);

            foreach (var fileGroup in filesGroups)
            {
                var fileList = fileGroup.ToList();

                if (s_bm.Archives.Lookup(fileGroup.Key).Value is not Archive ar)
                {
                    continue;
                }

#if IS_PARALLEL
                Parallel.ForEach(fileList, tmpFile =>
#else
                foreach (var tmpFile in fileList)
#endif
                {
                    if (tmpFile.Value is not FileEntry file)
                    {
                        throw new InvalidGameContextException();
                    }

                    try
                    {
                        using var originalStream = new MemoryStream();
                        ar.ExtractFile(file, originalStream);
                        originalStream.Seek(0, SeekOrigin.Begin);

                        using var originalReader = new CR2WReader(originalStream, Encoding.UTF8, true);
                        originalReader.ParsingError += TypeGlobal.OnParsingError;

                        var readResult = originalReader.ReadFile(out var cr2wFile, DECOMPRESS_BUFFERS);

                        switch (readResult)
                        {
                            case EFileReadErrorCodes.NoCr2w:
                                results.Add(new WriteTestResult
                                {
                                    FileEntry = file,
                                    Success = true,
                                    WriteResult = WriteTestResult.WriteResultType.NoCr2W
                                });
                                break;

                            case EFileReadErrorCodes.UnsupportedVersion:
                                results.Add(new WriteTestResult
                                {
                                    FileEntry = file,
                                    Success = false,
                                    WriteResult = WriteTestResult.WriteResultType.UnsupportedVersion,
                                    Message = $"Unsupported Version ({cr2wFile!.MetaData.Version})"
                                });
                                break;

                            case EFileReadErrorCodes.NoError:
                            {
                                cr2wFile!.MetaData.FileName = file.NameOrHash;

                                using var writeStream = new MemoryStream();
                                using var writer = new CR2WWriter(writeStream, Encoding.UTF8, true);
                                //using var bw = new BinaryWriter(writeStream, Encoding.UTF8, true);

                                // test writing
                                writer.WriteFile(cr2wFile);

                                // test for binary equality
                                originalStream.Seek(0, SeekOrigin.Begin);
                                writeStream.Seek(0, SeekOrigin.Begin);

                                var isBinaryEqual = originalStream.Length == writeStream.Length;
                                if (isBinaryEqual)
                                {
                                    for (var i = 0; i < originalStream.Length; i++)
                                    {
                                        if (originalStream.ReadByte() != writeStream.ReadByte())
                                        {
                                            isBinaryEqual = false;
                                            break;
                                        }
                                    }
                                }

                                if (!isBinaryEqual && WRITE_FAILED)
#pragma warning disable CS0162
                                {
                                    var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory, file.Extension[1..]);
                                    if (!Directory.Exists(resultDir))
                                    {
                                        Directory.CreateDirectory(resultDir);
                                    }

                                    var filename = Path.Combine(resultDir, Path.GetFileName(cr2wFile.MetaData.FileName));

                                    using var oFile = new FileStream($"{filename}.o.bin", FileMode.OpenOrCreate, FileAccess.Write);
                                    originalStream.Seek(0, SeekOrigin.Begin);
                                    originalStream.CopyTo(oFile);
                                    oFile.Flush();

                                    using var nFile = new FileStream($"{filename}.n.bin", FileMode.OpenOrCreate, FileAccess.Write);
                                    writeStream.Seek(0, SeekOrigin.Begin);
                                    writeStream.CopyTo(nFile);
                                    nFile.Flush();
                                }
#pragma warning restore CS0162

                                // test reading again
                                //bw.Seek(0, SeekOrigin.Begin);
                                //using var br2 = new BinaryReader(wms);
                                //var reread = c.Read(br2);
                                //isBinaryEqual = reread == EFileReadErrorCodes.NoError;

                                var res = WriteTestResult.WriteResultType.NoError;
                                var msg = "";

                                if (!isBinaryEqual)
                                {
                                    res |= WriteTestResult.WriteResultType.IsNotBinaryEqual;
                                    msg += $"IsBinaryEqual: {isBinaryEqual}";
                                }

                                results.Add(new WriteTestResult
                                {
                                    FileEntry = file,
                                    Success = isBinaryEqual,
                                    WriteResult = res,
                                    Message = msg,
                                    IsNotBinaryEqual = !isBinaryEqual,
                                });

                                break;
                            }

                            default:
                                throw new Exception();
                        }
                    }
                    catch (Exception e)
                    {
                        results.Add(new WriteTestResult
                        {
                            FileEntry = file,
                            Success = false,
                            WriteResult = WriteTestResult.WriteResultType.RuntimeException,
                            ExceptionType = e.GetType(),
                            Message = $"{e.Message}"
                        });
                    }
#if IS_PARALLEL
                });
#else
                }
#endif

                ar.ReleaseFileHandle();
            }
            return results;
        }

        private string TestResultAsCsv(IEnumerable<WriteTestResult> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine(
                $"{nameof(FileEntry.NameHash64)}," +
                $"{nameof(FileEntry.FileName)}," +
                $"{nameof(FileEntry.Archive.Name)}," +
                $"{nameof(WriteTestResult)}," +
                $"{nameof(WriteTestResult.Success)}," +
                //$"{nameof(WriteTestResult.HasIncorrectStringTable)}," +
                $"{nameof(WriteTestResult.IsNotBinaryEqual)}," +
                $"{nameof(WriteTestResult.ExceptionType)}," +
                $"{nameof(WriteTestResult.Message)}");

            foreach (var r in results)
            {
                sb.AppendLine(
                    $"{r.FileEntry?.NameHash64}," +
                    $"{r.FileEntry?.FileName}," +
                    $"{r.FileEntry?.Archive.Name}," +
                    $"{r.WriteResult}," +
                    $"{r.Success}," +
                    //$"{r.HasIncorrectStringTable}," +
                    $"{r.IsNotBinaryEqual}," +
                    $"{r.ExceptionType?.FullName}," +
                    $"{r.Message}");
            }

            return sb.ToString();
        }
    }
}
