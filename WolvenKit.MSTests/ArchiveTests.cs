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
