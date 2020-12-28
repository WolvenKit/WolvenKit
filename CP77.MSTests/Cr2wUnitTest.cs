using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.CR2W.Archive;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Services;

namespace CP77.MSTests
{
    [TestClass]
    public class Cr2wUnitTest
    {
        static Dictionary<string, MemoryMappedFile> memorymappedbundles;
        static ArchiveManager bm;
        private static Dictionary<string, List<ArchiveItem>> GroupedFiles;


        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
            ServiceLocator.Default.RegisterType<IHashService, HashService>();
            ServiceLocator.Default.RegisterType<IAppSettingsService, AppSettingsService>();

            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            hashService.ReloadLocally();

            DirectoryInfo finaldir;
            // check for CP77_DIR environment variable
            var CP77_DIR = System.Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(CP77_DIR) && new DirectoryInfo(CP77_DIR).Exists)
                finaldir = new DirectoryInfo(CP77_DIR);
            else
                return;


            memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            DirectoryInfo gameArchiveDir;
            try
            {
                gameArchiveDir = new DirectoryInfo(Path.Combine(finaldir.Parent.Parent.FullName, "archive", "pc", "content"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            bm = new ArchiveManager(gameArchiveDir);
            GroupedFiles = bm.GroupedFiles;
            //var singlefiles = bm.Files.Values
            //    .Select(_ => _.FirstOrDefault())
            //    .Where(_ => _ != null)
            //    .ToList();
            //var query = singlefiles.GroupBy(
            //    f => f.Extension,
            //    file => file,
            //    (ext, items) => new
            //    {
            //        Key = ext,
            //        File = items.Where(_ => _.Extension == ext)
            //    }).ToList();
        }




        [TestMethod]
        public async Task ent()
        {
            await Task.Run(() => StressTestExt(".ent"));
        }


        private void StressTestExt(string ext)
        {
            var files = GroupedFiles[ext];

            
            
        }
    }
}
