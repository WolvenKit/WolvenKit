using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Catel.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProtoBuf.Meta;
using WolvenKit.Common;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.CLI.MSTests
{
    [TestClass]
    public class GameUnitTest
    {
        #region Fields

        internal const string s_testResultsDirectory = "_CR2WTestResults";
        internal static ArchiveManager s_bm;
        internal static Dictionary<string, IEnumerable<FileEntry>> s_groupedFiles;
        internal static bool s_writeToFile;
        private const string s_gameDirectorySetting = "GameDirectory";
        private const string s_writeToFileSetting = "WriteToFile";
        private static IConfigurationRoot s_config;
        public static string s_gameDirectoryPath;

        #endregion Fields

        #region Methods

        protected static void Setup(TestContext context)
        {
            ServiceLocator.Default.RegisterInstance<ILoggerService>(new CatelLoggerService(false));
            ServiceLocator.Default.RegisterType<IHashService, HashService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();


            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));

            Console.WriteLine("BaseTestClass.BaseTestInitialize()");

            s_config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // check for CP77_DIR environment variable first
            // overrides hardcoded appsettings.json
            var cp77Dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(cp77Dir) && new DirectoryInfo(cp77Dir).Exists)
            {
                s_gameDirectoryPath = cp77Dir;
            }
            else
            {
                s_gameDirectoryPath = s_config.GetSection(s_gameDirectorySetting).Value;
            }

            if (string.IsNullOrEmpty(s_gameDirectoryPath))
            {
                throw new ConfigurationErrorsException($"'{s_gameDirectorySetting}' is not configured");
            }

            var gameDirectory = new DirectoryInfo(s_gameDirectoryPath);
            if (!gameDirectory.Exists)
            {
                throw new ConfigurationErrorsException($"'{s_gameDirectorySetting}' is not a valid directory");
            }

            // copy oodle dll
            var gameBinDir = new DirectoryInfo(Path.Combine(gameDirectory.FullName, "bin", "x64"));
            var oodleInfo = new FileInfo(Path.Combine(gameBinDir.FullName, "oo2ext_7_win64.dll"));
            if (!oodleInfo.Exists)
            {
                throw new DecompressionException("Could not find oo2ext_7_win64.dll.");
            }

            var ass = AppDomain.CurrentDomain.BaseDirectory;
            var destFileName = Path.Combine(ass, "oo2ext_7_win64.dll");
            if (!File.Exists(destFileName))
            {
                oodleInfo.CopyTo(destFileName);
            }

            s_writeToFile = bool.Parse(s_config.GetSection(s_writeToFileSetting).Value);

            
            s_bm = new ArchiveManager(hashService);
            s_bm.LoadAll(gameBinDir.FullName);
            s_groupedFiles = s_bm.GroupedFiles;
        }

        #endregion Methods
    }
}
