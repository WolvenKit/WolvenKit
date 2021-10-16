using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.MSTests
{
    [TestClass]
    public class DumpInfoTests : GameUnitTest
    {
        private const string s_LIMIT = "LIMIT";
        private const string s_KEEP = "KEEP";

        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        [TestMethod]
        public void DumpExtensionInfo()
        {
            var parsers = ServiceLocator.Default.ResolveType<Red4ParserService>();

            var results = new Dictionary<string, ConcurrentDictionary<string, ulong>>();
            foreach (var e in s_groupedFiles)
            {
                results.Add(e.Key, new ConcurrentDictionary<string, ulong>());
            }

            var excludedExtensions = new List<string>() { ".wem", ".bin", ".bnk" };

            // Run Test
            foreach (var item in s_groupedFiles.Where(_ => !excludedExtensions.Contains(_.Key)))
            {
                var ext = item.Key;
                var files = item.Value;

                Parallel.ForEach(files, file =>
                {
                    var hash = file.Key;
                    var archive = file.Archive as Archive;

                    try
                    {
                        using var originalMemoryStream = new MemoryStream();
                        ModTools.ExtractSingleToStream(archive, hash, originalMemoryStream);
                        var originalFile = parsers.TryReadRED4FileHeaders(originalMemoryStream);
                        if (originalFile != null)
                        {
                            var c = originalFile.StringDictionary[1];
                            results[ext].TryAdd(c, 0);
                        }
                        else
                        {

                        }
                    }
                    catch (Exception)
                    {

                    }

                });

            }

            var resultDir = Path.Combine(Environment.CurrentDirectory, s_testResultsDirectory);
            Directory.CreateDirectory(resultDir);

            using var sw = new StringWriter();
            foreach (var (key, classes) in results)
            {
                sw.WriteLine($"{key}: {string.Join(",", classes.Keys.ToList())}");
            }
            File.WriteAllText(Path.Combine(resultDir, "classes.txt"), sw.ToString());
        }



    }
}
