using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Common.Services;
using CP77.CR2W;
using CP77.CR2W.Archive;
using CP77.CR2W.Resources;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WolvenKit.Common;

namespace CP77.MSTests
{
    [TestClass]
    public class Cr2wUnitTest
    {
        private const string GameDirectorySetting = "GameDirectory";
        private const string WriteToFileSetting = "WriteToFile";
        
        private static Dictionary<string, MemoryMappedFile> memorymappedbundles;
        private static ArchiveManager bm;
        private static Dictionary<string, List<ArchiveItem>> GroupedFiles;

        private static IConfigurationRoot _config;

        private static string TestResultsDirectory = "_CR2WTestResults";
        private static string GameDirectoryPath;
        private static bool WriteToFile;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            
            GameDirectoryPath = _config.GetSection(GameDirectorySetting).Value;
            WriteToFile = Boolean.Parse(_config.GetSection(WriteToFileSetting).Value);

            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
            ServiceLocator.Default.RegisterType<IHashService, HashService>();
            ServiceLocator.Default.RegisterType<IAppSettingsService, AppSettingsService>();

            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            hashService.ReloadLocally();

            if (string.IsNullOrEmpty(GameDirectoryPath))
                throw new ConfigurationErrorsException($"'{GameDirectorySetting}' is not configured");

            var gameDirectory = new DirectoryInfo(GameDirectoryPath);

            if (!gameDirectory.Exists)
                throw new ConfigurationErrorsException($"'{GameDirectorySetting}' is not a valid directory");

            memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            DirectoryInfo gameArchiveDir;
            try
            {
                gameArchiveDir = new DirectoryInfo(Path.Combine(gameDirectory.FullName, "archive", "pc", "content"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            bm = new ArchiveManager(gameArchiveDir);
            GroupedFiles = bm.GroupedFiles;
        }

        [TestMethod]
        public void Test_All_Extensions()
        {
            Test_Extension();
        }

        [TestMethod]
        public void Test_Can_Read_acousticdata()
        {
            Test_Extension(".acousticdata");
        }

        [TestMethod]
        public void Test_Can_Read_actionanimdb()
        {
            Test_Extension(".actionanimdb");
        }

        [TestMethod]
        public void Test_Can_Read_aiarch()
        {
            Test_Extension(".aiarch");
        }

        [TestMethod]
        public void Test_Can_Read_animgraph()
        {
            Test_Extension(".animgraph");
        }

        [TestMethod]
        public void Test_Can_Read_anims()
        {
            Test_Extension(".anims");
        }

        [TestMethod]
        public void Test_Can_Read_app()
        {
            Test_Extension(".app");
        }

        [TestMethod]
        public void Test_Can_Read_archetypes()
        {
            Test_Extension(".archetypes");
        }

        [TestMethod]
        public void Test_Can_Read_areas()
        {
            Test_Extension(".areas");
        }

        [TestMethod]
        public void Test_Can_Read_audio_metadata()
        {
            Test_Extension(".audio_metadata");
        }

        [TestMethod]
        public void Test_Can_Read_audiovehcurveset()
        {
            Test_Extension(".audiovehcurveset");
        }

        [TestMethod]
        public void Test_Can_Read_behavior()
        {
            Test_Extension(".behavior");
        }

        [TestMethod]
        public void Test_Can_Read_bikecurveset()
        {
            Test_Extension(".bikecurveset");
        }

        [TestMethod]
        public void Test_Can_Read_bin()
        {
            Test_Extension(".bin");
        }

        [TestMethod]
        public void Test_Can_Read_bk2()
        {
            Test_Extension(".bk2");
        }

        [TestMethod]
        public void Test_Can_Read_bnk()
        {
            Test_Extension(".bnk");
        }

        [TestMethod]
        public void Test_Can_Read_camcurveset()
        {
            Test_Extension(".camcurveset");
        }

        [TestMethod]
        public void Test_Can_Read_cfoliage()
        {
            Test_Extension(".cfoliage");
        }

        [TestMethod]
        public void Test_Can_Read_charcustpreset()
        {
            Test_Extension(".charcustpreset");
        }

        [TestMethod]
        public void Test_Can_Read_cminimap()
        {
            Test_Extension(".cminimap");
        }

        [TestMethod]
        public void Test_Can_Read_community()
        {
            Test_Extension(".community");
        }

        [TestMethod]
        public void Test_Can_Read_conversations()
        {
            Test_Extension(".conversations");
        }

        [TestMethod]
        public void Test_Can_Read_cooked_mlsetup()
        {
            Test_Extension(".cooked_mlsetup");
        }

        [TestMethod]
        public void Test_Can_Read_cookedanims()
        {
            Test_Extension(".cookedanims");
        }

        [TestMethod]
        public void Test_Can_Read_cookedapp()
        {
            Test_Extension(".cookedapp");
        }

        [TestMethod]
        public void Test_Can_Read_credits()
        {
            Test_Extension(".credits");
        }

        [TestMethod]
        public void Test_Can_Read_csv()
        {
            Test_Extension(".csv");
        }

        [TestMethod]
        public void Test_Can_Read_cubemap()
        {
            Test_Extension(".cubemap");
        }

        [TestMethod]
        public void Test_Can_Read_curveset()
        {
            Test_Extension(".curveset");
        }

        [TestMethod]
        public void Test_Can_Read_dat()
        {
            Test_Extension(".dat");
        }

        [TestMethod]
        public void Test_Can_Read_devices()
        {
            Test_Extension(".devices");
        }

        [TestMethod]
        public void Test_Can_Read_dtex()
        {
            Test_Extension(".dtex");
        }

        [TestMethod]
        public void Test_Can_Read_effect()
        {
            Test_Extension(".effect");
        }

        [TestMethod]
        public void Test_Can_Read_ent()
        {
            Test_Extension(".ent");
        }

        [TestMethod]
        public void Test_Can_Read_env()
        {
            Test_Extension(".env");
        }

        [TestMethod]
        public void Test_Can_Read_envparam()
        {
            Test_Extension(".envparam");
        }

        [TestMethod]
        public void Test_Can_Read_envprobe()
        {
            Test_Extension(".envprobe");
        }

        [TestMethod]
        public void Test_Can_Read_es()
        {
            Test_Extension(".es");
        }

        [TestMethod]
        public void Test_Can_Read_facialcustom()
        {
            Test_Extension(".facialcustom");
        }

        [TestMethod]
        public void Test_Can_Read_facialsetup()
        {
            Test_Extension(".facialsetup");
        }

        [TestMethod]
        public void Test_Can_Read_fb2tl()
        {
            Test_Extension(".fb2tl");
        }

        [TestMethod]
        public void Test_Can_Read_fnt()
        {
            Test_Extension(".fnt");
        }

        [TestMethod]
        public void Test_Can_Read_folbrush()
        {
            Test_Extension(".folbrush");
        }

        [TestMethod]
        public void Test_Can_Read_foldest()
        {
            Test_Extension(".foldest");
        }

        [TestMethod]
        public void Test_Can_Read_fp()
        {
            Test_Extension(".fp");
        }

        [TestMethod]
        public void Test_Can_Read_gamedef()
        {
            Test_Extension(".gamedef");
        }

        [TestMethod]
        public void Test_Can_Read_garmentlayerparams()
        {
            Test_Extension(".garmentlayerparams");
        }

        [TestMethod]
        public void Test_Can_Read_genericanimdb()
        {
            Test_Extension(".genericanimdb");
        }

        [TestMethod]
        public void Test_Can_Read_geometry_cache()
        {
            Test_Extension(".geometry_cache");
        }

        [TestMethod]
        public void Test_Can_Read_gidata()
        {
            Test_Extension(".gidata");
        }

        [TestMethod]
        public void Test_Can_Read_gradient()
        {
            Test_Extension(".gradient");
        }

        [TestMethod]
        public void Test_Can_Read_hitrepresentation()
        {
            Test_Extension(".hitrepresentation");
        }

        [TestMethod]
        public void Test_Can_Read_hp()
        {
            Test_Extension(".hp");
        }

        [TestMethod]
        public void Test_Can_Read_ies()
        {
            Test_Extension(".ies");
        }

        [TestMethod]
        public void Test_Can_Read_inkanim()
        {
            Test_Extension(".inkanim");
        }

        [TestMethod]
        public void Test_Can_Read_inkatlas()
        {
            Test_Extension(".inkatlas");
        }

        [TestMethod]
        public void Test_Can_Read_inkcharcustomization()
        {
            Test_Extension(".inkcharcustomization");
        }

        [TestMethod]
        public void Test_Can_Read_inkfontfamily()
        {
            Test_Extension(".inkfontfamily");
        }

        [TestMethod]
        public void Test_Can_Read_inkfullscreencomposition()
        {
            Test_Extension(".inkfullscreencomposition");
        }

        [TestMethod]
        public void Test_Can_Read_inkgamesettings()
        {
            Test_Extension(".inkgamesettings");
        }

        [TestMethod]
        public void Test_Can_Read_inkhud()
        {
            Test_Extension(".inkhud");
        }

        [TestMethod]
        public void Test_Can_Read_inklayers()
        {
            Test_Extension(".inklayers");
        }

        [TestMethod]
        public void Test_Can_Read_inkmenu()
        {
            Test_Extension(".inkmenu");
        }

        [TestMethod]
        public void Test_Can_Read_inkshapecollection()
        {
            Test_Extension(".inkshapecollection");
        }

        [TestMethod]
        public void Test_Can_Read_inkstyle()
        {
            Test_Extension(".inkstyle");
        }

        [TestMethod]
        public void Test_Can_Read_inktypography()
        {
            Test_Extension(".inktypography");
        }

        [TestMethod]
        public void Test_Can_Read_inkwidget()
        {
            Test_Extension(".inkwidget");
        }

        [TestMethod]
        public void Test_Can_Read_interaction()
        {
            Test_Extension(".interaction");
        }

        [TestMethod]
        public void Test_Can_Read_journal()
        {
            Test_Extension(".journal");
        }

        [TestMethod]
        public void Test_Can_Read_journaldesc()
        {
            Test_Extension(".journaldesc");
        }

        [TestMethod]
        public void Test_Can_Read_json()
        {
            Test_Extension(".json");
        }

        [TestMethod]
        public void Test_Can_Read_lane_connections()
        {
            Test_Extension(".lane_connections");
        }

        [TestMethod]
        public void Test_Can_Read_lane_polygons()
        {
            Test_Extension(".lane_polygons");
        }

        [TestMethod]
        public void Test_Can_Read_lane_spots()
        {
            Test_Extension(".lane_spots");
        }

        [TestMethod]
        public void Test_Can_Read_lights()
        {
            Test_Extension(".lights");
        }

        [TestMethod]
        public void Test_Can_Read_lipmap()
        {
            Test_Extension(".lipmap");
        }

        [TestMethod]
        public void Test_Can_Read_location()
        {
            Test_Extension(".location");
        }

        [TestMethod]
        public void Test_Can_Read_locopaths()
        {
            Test_Extension(".locopaths");
        }

        [TestMethod]
        public void Test_Can_Read_loot()
        {
            Test_Extension(".loot");
        }

        [TestMethod]
        public void Test_Can_Read_mappins()
        {
            Test_Extension(".mappins");
        }

        [TestMethod]
        public void Test_Can_Read_mesh()
        {
            Test_Extension(".mesh");
        }

        [TestMethod]
        public void Test_Can_Read_mi()
        {
            Test_Extension(".mi");
        }

        [TestMethod]
        public void Test_Can_Read_mlmask()
        {
            Test_Extension(".mlmask");
        }

        [TestMethod]
        public void Test_Can_Read_mlsetup()
        {
            Test_Extension(".mlsetup");
        }

        [TestMethod]
        public void Test_Can_Read_mltemplate()
        {
            Test_Extension(".mltemplate");
        }

        [TestMethod]
        public void Test_Can_Read_morphtarget()
        {
            Test_Extension(".morphtarget");
        }

        [TestMethod]
        public void Test_Can_Read_mt()
        {
            Test_Extension(".mt");
        }

        [TestMethod]
        public void Test_Can_Read_navmesh()
        {
            Test_Extension(".navmesh");
        }

        [TestMethod]
        public void Test_Can_Read_null_areas()
        {
            Test_Extension(".null_areas");
        }

        [TestMethod]
        public void Test_Can_Read_opusinfo()
        {
            Test_Extension(".opusinfo");
        }

        [TestMethod]
        public void Test_Can_Read_opuspak()
        {
            Test_Extension(".opuspak");
        }

        [TestMethod]
        public void Test_Can_Read_particle()
        {
            Test_Extension(".particle");
        }

        [TestMethod]
        public void Test_Can_Read_phys()
        {
            Test_Extension(".phys");
        }

        [TestMethod]
        public void Test_Can_Read_physicalscene()
        {
            Test_Extension(".physicalscene");
        }

        [TestMethod]
        public void Test_Can_Read_physmatlib()
        {
            Test_Extension(".physmatlib");
        }

        [TestMethod]
        public void Test_Can_Read_poimappins()
        {
            Test_Extension(".poimappins");
        }

        [TestMethod]
        public void Test_Can_Read_psrep()
        {
            Test_Extension(".psrep");
        }

        [TestMethod]
        public void Test_Can_Read_quest()
        {
            Test_Extension(".quest");
        }

        [TestMethod]
        public void Test_Can_Read_questphase()
        {
            Test_Extension(".questphase");
        }

        [TestMethod]
        public void Test_Can_Read_regionset()
        {
            Test_Extension(".regionset");
        }

        [TestMethod]
        public void Test_Can_Read_remt()
        {
            Test_Extension(".remt");
        }

        [TestMethod]
        public void Test_Can_Read_reslist()
        {
            Test_Extension(".reslist");
        }

        [TestMethod]
        public void Test_Can_Read_rig()
        {
            Test_Extension(".rig");
        }

        [TestMethod]
        public void Test_Can_Read_scene()
        {
            Test_Extension(".scene");
        }

        [TestMethod]
        public void Test_Can_Read_scenerid()
        {
            Test_Extension(".scenerid");
        }

        [TestMethod]
        public void Test_Can_Read_scenesversions()
        {
            Test_Extension(".scenesversions");
        }

        [TestMethod]
        public void Test_Can_Read_smartobject()
        {
            Test_Extension(".smartobject");
        }

        [TestMethod]
        public void Test_Can_Read_smartobjects()
        {
            Test_Extension(".smartobjects");
        }

        [TestMethod]
        public void Test_Can_Read_sp()
        {
            Test_Extension(".sp");
        }

        [TestMethod]
        public void Test_Can_Read_spatial_representation()
        {
            Test_Extension(".spatial_representation");
        }

        [TestMethod]
        public void Test_Can_Read_streamingquerydata()
        {
            Test_Extension(".streamingquerydata");
        }

        [TestMethod]
        public void Test_Can_Read_streamingsector()
        {
            Test_Extension(".streamingsector");
        }

        [TestMethod]
        public void Test_Can_Read_streamingsector_inplace()
        {
            Test_Extension(".streamingsector_inplace");
        }

        [TestMethod]
        public void Test_Can_Read_streamingworld()
        {
            Test_Extension(".streamingworld");
        }

        [TestMethod]
        public void Test_Can_Read_terrainsetup()
        {
            Test_Extension(".terrainsetup");
        }

        [TestMethod]
        public void Test_Can_Read_texarray()
        {
            Test_Extension(".texarray");
        }

        [TestMethod]
        public void Test_Can_Read_traffic_collisions()
        {
            Test_Extension(".traffic_collisions");
        }

        [TestMethod]
        public void Test_Can_Read_traffic_persistent()
        {
            Test_Extension(".traffic_persistent");
        }

        [TestMethod]
        public void Test_Can_Read_voicetags()
        {
            Test_Extension(".voicetags");
        }

        [TestMethod]
        public void Test_Can_Read_w2mesh()
        {
            Test_Extension(".w2mesh");
        }

        [TestMethod]
        public void Test_Can_Read_w2mi()
        {
            Test_Extension(".w2mi");
        }

        [TestMethod]
        public void Test_Can_Read_wem()
        {
            Test_Extension(".wem");
        }

        [TestMethod]
        public void Test_Can_Read_workspot()
        {
            Test_Extension(".workspot");
        }

        [TestMethod]
        public void Test_Can_Read_xbm()
        {
            Test_Extension(".xbm");
        }

        [TestMethod]
        public void Test_Can_Read_xcube()
        {
            Test_Extension(".xcube");
        }

        private void Test_Extension(string extension = null)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, TestResultsDirectory);
            Directory.CreateDirectory(resultDir);

            var success = true;

            List<string> files;

            if (string.IsNullOrEmpty(extension))
                files = GroupedFiles.Keys.ToList();
            else
                files = GroupedFiles.Keys.Where(k => k.Equals(extension)).ToList();

            var sb = new StringBuilder();
            
            Parallel.ForEach(files, ext =>
            {
                var results = Read_Archive_Items(GroupedFiles[ext]);

                var successCount = results.Count(r => r.Success);
                var totalCount = GroupedFiles[ext].Count;
                
                sb.AppendLine($"{ext} -> Successful Reads: {successCount} / {totalCount} ({(int)(((double)successCount / (double)totalCount) * 100)}%)");

                if (success && results.Any(r => !r.Success)) success = false;
                
                if (WriteToFile)
                {
                    if (results.Any(r => !r.Success))
                    {
                        var resultPath = Path.Combine(resultDir, $"{ext[1..]}.csv");
                        var csv = TestResultAsCsv(results.Where(r => !r.Success));
                        File.WriteAllText(resultPath, csv);
                    }
                }
            });
            
            var logPath = Path.Combine(resultDir, $"logfile_{(string.IsNullOrEmpty(extension) ? string.Empty : $"{extension[1..]}_")}{DateTime.Now:yyyyMMddHHmmss}.log");
            File.WriteAllText(logPath, sb.ToString());
            Console.WriteLine(sb.ToString());

            if (!success) Assert.Fail();
        }

        private IEnumerable<TestResult> Read_Archive_Items(List<ArchiveItem> files)
        {
            var results = new List<TestResult>();
            
            foreach (var file in files)
                try
                {
                    var (fileBytes, bufferBytes) = (file.Archive as Archive).GetFileData(file.NameHash64, false);

                    using var ms = new MemoryStream(fileBytes);
                    using var br = new BinaryReader(ms);

                    var c = new CR2WFile();
                    var readResult = c.Read(br);

                    switch (readResult)
                    {
                        case EFileReadErrorCodes.NoCr2w:
                            results.Add(new TestResult
                            {
                                ArchiveItem = file,
                                Success = true,
                                Result = TestResult.ResultType.NoCr2W
                            });
                            break;
                        case EFileReadErrorCodes.UnsupportedVersion:
                            results.Add(new TestResult
                            {
                                ArchiveItem = file,
                                Success = false,
                                Result = TestResult.ResultType.UnsupportedVersion,
                                Message = $"Unsupported Version ({c.GetFileHeader().version})"
                            });
                            break;
                        default:
                            var hasAdditionalBytes = c.additionalCr2WFileBytes != null && c.additionalCr2WFileBytes.Any();
                            results.Add(new TestResult
                            {
                                ArchiveItem = file,
                                Success = !hasAdditionalBytes,
                                Result = hasAdditionalBytes ? TestResult.ResultType.HasAdditionalBytes : TestResult.ResultType.NoError,
                                Message = hasAdditionalBytes ? $"Additional Bytes: {c.additionalCr2WFileBytes.Length}" : null,
                                AdditionalBytes = hasAdditionalBytes ? c.additionalCr2WFileBytes.Length : 0
                            });
                            break;
                    }
                }
                catch (Exception e)
                {
                    results.Add(new TestResult
                    {
                        ArchiveItem = file,
                        Success = false,
                        Result = TestResult.ResultType.RuntimeException,
                        ExceptionType = e.GetType(),
                        Message = e.Message
                    });
                }

            return results;
        }

        private string TestResultAsCsv(IEnumerable<TestResult> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine(
                $@"{nameof(ArchiveItem.NameHash64)},{nameof(ArchiveItem.FileName)},{nameof(TestResult.Result)},{nameof(TestResult.Success)},{nameof(TestResult.AdditionalBytes)},{nameof(TestResult.ExceptionType)},{nameof(TestResult.Message)}");

            foreach (var r in results)
            {
                sb.AppendLine(
                    $"{r.ArchiveItem.NameHash64},{r.ArchiveItem.FileName},{r.Result},{r.Success},{r.AdditionalBytes},{r.ExceptionType?.FullName},{r.Message}");
            }

            return sb.ToString();
        }

        private class TestResult
        {
            public enum ResultType
            {
                NoCr2W,
                UnsupportedVersion,
                RuntimeException,
                HasAdditionalBytes,
                NoError
            }
            
            public ArchiveItem ArchiveItem { get; set; }
            
            [JsonConverter(typeof(StringEnumConverter))]
            public ResultType Result { get; set; }
            public int AdditionalBytes { get; set; }
            public bool Success { get; set; }
            public Type ExceptionType { get; set; }
            public string Message { get; set; }
        }
    }
}