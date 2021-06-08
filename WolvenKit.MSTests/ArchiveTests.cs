using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ProtoBuf;
using WolvenKit.RED4.CR2W.Archive;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class ArchiveTests : GameUnitTest
    {
        public enum Serialization
        {
            Json,
            NewtonsoftJson,
            Protobuf,
            Zeroformatting
        }

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #region Methods

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
                using var ms = new MemoryStream();
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
        public void Test_Uncook()
        {






        }

        [TestMethod]
        //[DataRow(Serialization.NewtonsoftJson)]
        //[DataRow(Serialization.Zeroformatting)]
        [DataRow(Serialization.Protobuf)]
        public void Test_Serialization(Serialization method)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            switch (method)
            {

                case Serialization.NewtonsoftJson:
                {
                    var chachePath = Path.Combine(resultDir, "archive_cache.json");
                    //using var fs = new FileStream(chachePath, FileMode.Create);
                    File.WriteAllText(chachePath, JsonConvert.SerializeObject(s_bm, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    break;
                }
                case Serialization.Zeroformatting:
                {
                    //var chachePath = Path.Combine(resultDir, "archive_cache.zero");
                    //using var fs = new FileStream(chachePath, FileMode.Create);
                    //ZeroFormatterSerializer.Serialize(fs, s_bm);
                    break;
                }
                case Serialization.Json:
                    break;
                case Serialization.Protobuf:
                {
                    var chachePath = Path.Combine(resultDir, "archive_cache.bin");
                    using var file = File.Create(chachePath);
                    Serializer.Serialize(file, s_bm);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(method), method, null);
            }
        }

        [TestMethod]
        //[DataRow(Serialization.NewtonsoftJson)]
        //[DataRow(Serialization.Zeroformatting)]
        [DataRow(Serialization.Protobuf)]
        public void Test_Deserialization(Serialization method)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            ArchiveManager x;

            switch (method)
            {
                case Serialization.NewtonsoftJson:
                {
                    var chachePath = Path.Combine(resultDir, "archive_cache.json");
                    using var file = File.OpenText(chachePath);
                    var serializer = new JsonSerializer
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    };
                    x = (ArchiveManager)serializer.Deserialize(file, typeof(ArchiveManager));
                    break;
                }
                case Serialization.Protobuf:
                {
                    var chachePath = Path.Combine(resultDir, "archive_cache.bin");
                    using var file = File.OpenRead(chachePath);
                    x = Serializer.Deserialize<ArchiveManager>(file);
                    break;
                }
                case Serialization.Zeroformatting:
                case Serialization.Json:
                default:
                    throw new ArgumentOutOfRangeException(nameof(method), method, null);
            }

            // some lazy checks
            Assert.AreEqual(x.Archives.Count(), s_bm.Archives.Count());
            Assert.AreEqual(x.FileList.Count(), s_bm.FileList.Count());
            Assert.AreEqual(x.GroupedFiles.Count(), s_bm.GroupedFiles.Count());
        }

        #endregion Methods
    }
}
