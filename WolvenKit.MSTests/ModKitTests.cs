using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ProtoBuf;
using ProtoBuf.Meta;
using WolvenKit.CLI.MSTests;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Archive;

namespace CP77.MSTests
{
    [TestClass]
    public class ModKitTests : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context) => Setup(context);

        #region Methods

        [TestMethod]
        [DataRow(ERedExtension.xbm)]
        [DataRow(ERedExtension.mesh)]
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

            ExportArgs args;
            switch (extension)
            {
                case ERedExtension.mesh:
                    args = new MeshExportArgs();
                    break;
                case ERedExtension.xbm:
                    args = new XbmExportArgs();
                    break;
                default:
                    args = new CommonExportArgs();
                    break;
            }

            foreach (var fileEntry in infiles)
            {
                // skip files without buffers
                var hasBuffers = (fileEntry.SegmentsEnd - fileEntry.SegmentsStart) > 1;
                if (!hasBuffers)
                {
                    continue;
                }

                var ar = fileEntry.Archive as Archive;
                using var ms = new MemoryStream();
                ar.CopyFileToStream(ms, fileEntry.NameHash64, false);




                // uncook
                modtools.UncookSingle(fileEntry.Archive as Archive, fileEntry.Key, resultDir, args, resultDir);

                // rebuild
                modtools.Recombine(resultDir, true, true, false, true, false, true);

                // compare


            }

        }

        #endregion Methods
    }
}
