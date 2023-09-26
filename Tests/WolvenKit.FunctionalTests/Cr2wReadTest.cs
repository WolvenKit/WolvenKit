#define IS_PARALLEL

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.FunctionalTests.Model;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

#if IS_PARALLEL
using System.Threading.Tasks;
#endif

namespace WolvenKit.FunctionalTests
{
    [TestClass]
    public class Cr2wReadTest : GameUnitTest
    {
        #region Methods

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        private const bool TEST_EXISTING = true;
        private const bool DECOMPRESS_BUFFERS = true;

        #endregion Methods

        #region test methods

        //[TestMethod]
        //public void Test_All_Extensions()
        //{
        //    Test_Extension();
        //}

        [TestMethod]
        public void Read_bin() => Test_Extension(".bin");

        [TestMethod]
        public void Read_acousticdata() => Test_Extension(".acousticdata");

        [TestMethod]
        public void Read_actionanimdb() => Test_Extension(".actionanimdb");

        [TestMethod]
        public void Read_aiarch() => Test_Extension(".aiarch");

        [TestMethod]
        public void Read_animgraph() => Test_Extension(".animgraph");

        [TestMethod]
        public void Read_anims() => Test_Extension(".anims");

        [TestMethod]
        public void Read_app() => Test_Extension(".app");

        [TestMethod]
        public void Read_archetypes() => Test_Extension(".archetypes");

        [TestMethod]
        public void Read_areas() => Test_Extension(".areas");

        [TestMethod]
        public void Read_audio_metadata() => Test_Extension(".audio_metadata");

        [TestMethod]
        public void Read_audiovehcurveset() => Test_Extension(".audiovehcurveset");

        [TestMethod]
        public void Read_behavior() => Test_Extension(".behavior");

        [TestMethod]
        public void Read_bikecurveset() => Test_Extension(".bikecurveset");

        [TestMethod]
        public void Read_bk2() => Test_Extension(".bk2");

        [TestMethod]
        public void Read_bnk() => Test_Extension(".bnk");

        [TestMethod]
        public void Read_camcurveset() => Test_Extension(".camcurveset");

        [TestMethod]
        public void Read_ccstate() => Test_Extension(".ccstate");

        [TestMethod]
        public void Read_cfoliage() => Test_Extension(".cfoliage");

        [TestMethod]
        public void Read_charcustpreset() => Test_Extension(".charcustpreset");

        [TestMethod]
        public void Read_chromaset() => Test_Extension(".chromaset");

        [TestMethod]
        public void Read_cminimap() => Test_Extension(".cminimap");

        [TestMethod]
        public void Read_community() => Test_Extension(".community");

        [TestMethod]
        public void Read_conversations() => Test_Extension(".conversations");

        [TestMethod]
        public void Read_cooked_mlsetup() => Test_Extension(".cooked_mlsetup");

        [TestMethod]
        public void Read_cookedanims() => Test_Extension(".cookedanims");

        [TestMethod]
        public void Read_cookedapp() => Test_Extension(".cookedapp");

        [TestMethod]
        public void Read_cookedprefab() => Test_Extension(".cookedprefab");

        [TestMethod]
        public void Read_credits() => Test_Extension(".credits");

        [TestMethod]
        public void Read_csv() => Test_Extension(".csv");

        [TestMethod]
        public void Read_cubemap() => Test_Extension(".cubemap");

        [TestMethod]
        public void Read_curveresset() => Test_Extension(".curveresset");

        [TestMethod]
        public void Read_curveset() => Test_Extension(".curveset");

        [TestMethod]
        public void Read_dat() => Test_Extension(".dat");

        [TestMethod]
        public void Read_devices() => Test_Extension(".devices");

        [TestMethod]
        public void Read_dtex() => Test_Extension(".dtex");

        [TestMethod]
        public void Read_effect() => Test_Extension(".effect");

        [TestMethod]
        public void Read_ent() => Test_Extension(".ent");

        [TestMethod]
        public void Read_env() => Test_Extension(".env");

        [TestMethod]
        public void Read_envparam() => Test_Extension(".envparam");

        [TestMethod]
        public void Read_envprobe() => Test_Extension(".envprobe");

        [TestMethod]
        public void Read_es() => Test_Extension(".es");

        [TestMethod]
        public void Read_facialcustom() => Test_Extension(".facialcustom");

        [TestMethod]
        public void Read_facialsetup() => Test_Extension(".facialsetup");

        [TestMethod]
        public void Read_fb2tl() => Test_Extension(".fb2tl");

        [TestMethod]
        public void Read_fnt() => Test_Extension(".fnt");

        [TestMethod]
        public void Read_folbrush() => Test_Extension(".folbrush");

        [TestMethod]
        public void Read_foldest() => Test_Extension(".foldest");

        [TestMethod]
        public void Read_fp() => Test_Extension(".fp");

        [TestMethod]
        public void Read_gamed() => Test_Extension(".game");

        [TestMethod]
        public void Read_gamedef() => Test_Extension(".gamedef");

        [TestMethod]
        public void Read_garmentlayerparams() => Test_Extension(".garmentlayerparams");

        [TestMethod]
        public void Read_genericanimdb() => Test_Extension(".genericanimdb");

        [TestMethod]
        public void Read_geometry_cache() => Test_Extension(".geometry_cache");

        [TestMethod]
        public void Read_gidata() => Test_Extension(".gidata");

        [TestMethod]
        public void Read_gradient() => Test_Extension(".gradient");

        [TestMethod]
        public void Read_hitrepresentation() => Test_Extension(".hitrepresentation");

        [TestMethod]
        public void Read_hp() => Test_Extension(".hp");

        [TestMethod]
        public void Read_ies() => Test_Extension(".ies");

        [TestMethod]
        public void Read_inkanim() => Test_Extension(".inkanim");

        [TestMethod]
        public void Read_inkatlas() => Test_Extension(".inkatlas");

        [TestMethod]
        public void Read_inkcharcustomization() => Test_Extension(".inkcharcustomization");

        [TestMethod]
        public void Read_inkenginesettings() => Test_Extension(".inkenginesettings");

        [TestMethod]
        public void Read_inkfontfamily() => Test_Extension(".inkfontfamily");

        [TestMethod]
        public void Read_inkfullscreencomposition() => Test_Extension(".inkfullscreencomposition");

        [TestMethod]
        public void Read_inkgamesettings() => Test_Extension(".inkgamesettings");

        [TestMethod]
        public void Read_inkhud() => Test_Extension(".inkhud");

        [TestMethod]
        public void Read_inklayers() => Test_Extension(".inklayers");

        [TestMethod]
        public void Read_inkmenu() => Test_Extension(".inkmenu");

        [TestMethod]
        public void Read_inkshapecollection() => Test_Extension(".inkshapecollection");

        [TestMethod]
        public void Read_inkstyle() => Test_Extension(".inkstyle");

        [TestMethod]
        public void Read_inktypography() => Test_Extension(".inktypography");

        [TestMethod]
        public void Read_inkwidget() => Test_Extension(".inkwidget");

        [TestMethod]
        public void Read_interaction() => Test_Extension(".interaction");

        [TestMethod]
        public void Read_journal() => Test_Extension(".journal");

        [TestMethod]
        public void Read_journaldesc() => Test_Extension(".journaldesc");

        [TestMethod]
        public void Read_json() => Test_Extension(".json");

        [TestMethod]
        public void Read_lane_connections() => Test_Extension(".lane_connections");

        [TestMethod]
        public void Read_lane_polygons() => Test_Extension(".lane_polygons");

        [TestMethod]
        public void Read_lane_spots() => Test_Extension(".lane_spots");

        [TestMethod]
        public void Read_lights() => Test_Extension(".lights");

        [TestMethod]
        public void Read_lipmap() => Test_Extension(".lipmap");

        [TestMethod]
        public void Read_location() => Test_Extension(".location");

        [TestMethod]
        public void Read_locopaths() => Test_Extension(".locopaths");

        [TestMethod]
        public void Read_loot() => Test_Extension(".loot");

        [TestMethod]
        public void Read_mappins() => Test_Extension(".mappins");

        [TestMethod]
        public void Read_matlib() => Test_Extension(".matlib");

        [TestMethod]
        public void Read_mesh() => Test_Extension(".mesh");

        [TestMethod]
        public void Read_mi() => Test_Extension(".mi");

        [TestMethod]
        public void Read_mlmask() => Test_Extension(".mlmask");

        [TestMethod]
        public void Read_mlsetup() => Test_Extension(".mlsetup");

        [TestMethod]
        public void Read_mltemplate() => Test_Extension(".mltemplate");

        [TestMethod]
        public void Read_morphtarget() => Test_Extension(".morphtarget");

        [TestMethod]
        public void Read_mt() => Test_Extension(".mt");

        // removed in 1.3
        //[TestMethod]
        //public void Read_navmesh() => Test_Extension(".navmesh");

        [TestMethod]
        public void Read_null_areas() => Test_Extension(".null_areas");

        [TestMethod]
        public void Read_opusinfo() => Test_Extension(".opusinfo");

        [TestMethod]
        public void Read_opuspak() => Test_Extension(".opuspak");

        [TestMethod]
        public void Read_particle() => Test_Extension(".particle");

        [TestMethod]
        public void Read_phys() => Test_Extension(".phys");

        [TestMethod]
        public void Read_physicalscene() => Test_Extension(".physicalscene");

        [TestMethod]
        public void Read_physmatlib() => Test_Extension(".physmatlib");

        [TestMethod]
        public void Read_poimappins() => Test_Extension(".poimappins");

        [TestMethod]
        public void Read_psrep() => Test_Extension(".psrep");

        [TestMethod]
        public void Read_quest() => Test_Extension(".quest");

        [TestMethod]
        public void Read_questphase() => Test_Extension(".questphase");

        [TestMethod]
        public void Read_regionset() => Test_Extension(".regionset");

        [TestMethod]
        public void Read_remt() => Test_Extension(".remt");

        [TestMethod]
        public void Read_reps() => Test_Extension(".reps");

        [TestMethod]
        public void Read_reslist() => Test_Extension(".reslist");

        [TestMethod]
        public void Read_rig() => Test_Extension(".rig");

        [TestMethod]
        public void Read_scene() => Test_Extension(".scene");

        [TestMethod]
        public void Read_scenerid() => Test_Extension(".scenerid");

        [TestMethod]
        public void Read_scenesversions() => Test_Extension(".scenesversions");

        [TestMethod]
        public void Read_smartobject() => Test_Extension(".smartobject");

        [TestMethod]
        public void Read_smartobjects() => Test_Extension(".smartobjects");

        [TestMethod]
        public void Read_sp() => Test_Extension(".sp");

        [TestMethod]
        public void Read_spatial_representation() => Test_Extension(".spatial_representation");

        [TestMethod]
        public void Read_streamingquerydata() => Test_Extension(".streamingquerydata");

        [TestMethod]
        public void Read_streamingblock() => Test_Extension(".streamingblock");

        [TestMethod]
        public void Read_streamingsector() => Test_Extension(".streamingsector");

        [TestMethod]
        public void Read_streamingsector_inplace() => Test_Extension(".streamingsector_inplace");

        [TestMethod]
        public void Read_streamingworld() => Test_Extension(".streamingworld");

        [TestMethod]
        public void Read_terrainsetup() => Test_Extension(".terrainsetup");

        [TestMethod]
        public void Read_texarray() => Test_Extension(".texarray");

        [TestMethod]
        public void Read_traffic_collisions() => Test_Extension(".traffic_collisions");

        [TestMethod]
        public void Read_traffic_persistent() => Test_Extension(".traffic_persistent");

        [TestMethod]
        public void Read_vehcommoncurveset() => Test_Extension(".vehcommoncurveset");

        [TestMethod]
        public void Read_vehcurveset() => Test_Extension(".vehcurveset");

        [TestMethod]
        public void Read_voicetags() => Test_Extension(".voicetags");

        [TestMethod]
        public void Read_w2mesh() => Test_Extension(".w2mesh");

        [TestMethod]
        public void Read_w2mi() => Test_Extension(".w2mi");

        [TestMethod]
        public void Read_wem() => Test_Extension(".wem");

        [TestMethod]
        public void Read_workspot() => Test_Extension(".workspot");

        [TestMethod]
        public void Read_xbm() => Test_Extension(".xbm");

        [TestMethod]
        public void Read_xcube() => Test_Extension(".xcube");

        #endregion test methods

        private static IEnumerable<ReadTestResult> Read_Archive_Items(IEnumerable<IGameFile> files)
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var results = new ConcurrentBag<ReadTestResult>();

            var filesGroups = files.Select((f, i) => new { Value = f, Index = i })
                .GroupBy(item => item.Value.GetArchive<Archive>().ArchiveAbsolutePath);

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
                        using var ms = new MemoryStream();
                        ar.ExtractFile(file, ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        using var reader = new CR2WReader(ms);
                        reader.ParsingError += TypeGlobal.OnParsingError;

                        var readResult = reader.ReadFile(out var c, DECOMPRESS_BUFFERS);

                        switch (readResult)
                        {
                            case EFileReadErrorCodes.NoCr2w:
                                results.Add(new ReadTestResult
                                {
                                    FileEntry = file,
                                    Success = true,
                                    ReadResult = ReadTestResult.ReadResultType.NoCr2W
                                });
                                break;

                            case EFileReadErrorCodes.UnsupportedVersion:
                                results.Add(new ReadTestResult
                                {
                                    FileEntry = file,
                                    Success = false,
                                    ReadResult = ReadTestResult.ReadResultType.UnsupportedVersion,
                                    Message = $"Unsupported Version ({c!.MetaData.Version})"
                                });
                                break;

                            case EFileReadErrorCodes.NoError:
                                c!.MetaData.FileName = file.NameOrHash;

                                var res = ReadTestResult.ReadResultType.NoError;
                                var msg = "";

                                var additionalCr2WFileBytes =
                                    (int)(reader.BaseStream.Length - reader.BaseStream.Position);
                                if (additionalCr2WFileBytes > 0)
                                {
                                    res |= ReadTestResult.ReadResultType.HasAdditionalBytes;
                                    msg += $"Additional Bytes: {additionalCr2WFileBytes}";
                                }

                                results.Add(new ReadTestResult
                                {
                                    FileEntry = file,
                                    Success = true /*!hasAdditionalBytes && !hasUnknownBytes*/,
                                    ReadResult = res,
                                    Message = msg,
                                    AdditionalBytes = additionalCr2WFileBytes
                                });
                                break;

                            default:
                                throw new Exception();
                        }
                    }
                    catch (Exception e)
                    {
                        results.Add(new ReadTestResult
                        {
                            FileEntry = file,
                            Success = false,
                            ReadResult = ReadTestResult.ReadResultType.RuntimeException,
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

        private static void Test_Extension(string extension)
        {
            ArgumentNullException.ThrowIfNull(s_bm);
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            // Run Test
            List<ReadTestResult> results = new();
            List<IGameFile> filesToTest = new();
            var resultPath = Path.Combine(resultDir, $"{extension[1..]}.csv");
            if (File.Exists(resultPath) && TEST_EXISTING)
            {
                foreach (var line in File.ReadAllLines(resultPath)
                             .Skip(1)
                             .Where(_ => !string.IsNullOrEmpty(_)))
                {
                    var hashStr = line.Split(',').First();
                    if (ulong.TryParse(hashStr, out var hash) || ulong.TryParse(hashStr.TrimStart('0', 'x'), NumberStyles.HexNumber, null, out hash))
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

            results = Read_Archive_Items(filesToTest).ToList();

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
            var totalCount = s_groupedFiles[extension].Count();
            var sb = new StringBuilder();
            var msg = "";

            var successRead = results.All(r => r.Success);
            var successUb = !results.All(r => r.UnknownBytes > 0);

            if (successUb && successRead)
            {
                return;
            }

            if (!successRead)
            {
                msg +=
                    $"{extension} -> Successful Reads: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)";
            }

            var unknownBytes = results.Sum(r => r.UnknownBytes);
            var additionalBytes = results.Sum(r => r.AdditionalBytes);
            if (unknownBytes > 0)
            {
                msg += $" UnknownBytes: {unknownBytes}. ";
                var unkownTypes = string.Join('\n', results.SelectMany(_ => _.UnknownTypes).Distinct());
                msg += $" UnknownTypes: {unkownTypes}";
            }

            if (additionalBytes > 0)
            {
                msg += $" UnknownBytes: {additionalBytes}. ";
            }

            sb.AppendLine(
                $"{extension} -> Successful Reads: {successCount} / {totalCount} ({(int)(successCount / (double)totalCount * 100)}%)");
            sb.AppendLine(msg);
            var logPath = Path.Combine(resultDir,
                $"logfile_{(string.IsNullOrEmpty(extension) ? string.Empty : $"{extension[1..]}_")}{DateTime.Now:yyyyMMddHHmmss}.log");
            File.WriteAllText(logPath, sb.ToString());
            Console.WriteLine(sb.ToString());

            Assert.Fail(msg);
        }

        private static string TestResultAsCsv(IEnumerable<ReadTestResult> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine(
                $"{nameof(FileEntry.NameHash64)}," +
                $"{nameof(FileEntry.FileName)}," +
                $"{nameof(FileEntry.Archive.Name)}," +
                $"{nameof(ReadTestResult.ReadResult)}," +
                $"{nameof(ReadTestResult.Success)}," +
                $"{nameof(ReadTestResult.AdditionalBytes)}," +
                $"{nameof(ReadTestResult.UnknownBytes)}," +
                $"{nameof(ReadTestResult.ExceptionType)}," +
                $"{nameof(ReadTestResult.Message)}");

            foreach (var r in results)
            {
                sb.AppendLine(
                    $"{string.Format("0x{0:X}", r.FileEntry?.NameHash64)}," +
                    $"{r.FileEntry?.FileName}," +
                    $"{r.FileEntry?.Archive.Name}," +
                    $"{r.ReadResult}," +
                    $"{r.Success}," +
                    $"{r.AdditionalBytes}," +
                    $"{r.UnknownBytes}," +
                    $"{r.ExceptionType?.FullName}," +
                    $"{r.Message}");
            }

            return sb.ToString();
        }
    }
}
