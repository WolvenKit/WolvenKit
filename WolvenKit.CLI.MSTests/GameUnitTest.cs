using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Catel.IoC;
using WolvenKit.RED4.CR2W.Archive;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;

namespace CP77.MSTests
{
    [TestClass]
    public class GameUnitTest
    {
        #region Fields

        internal const string TestResultsDirectory = "_CR2WTestResults";
        internal static ArchiveManager bm;
        internal static Dictionary<string, List<FileEntry>> GroupedFiles;
        internal static bool WriteToFile;
        private const string GameDirectorySetting = "GameDirectory";
        private const string WriteToFileSetting = "WriteToFile";
        private static IConfigurationRoot _config;
        private static string _gameDirectoryPath;

        #endregion Fields

        #region Methods

        protected static void Setup(TestContext context)
        {
            Console.WriteLine("BaseTestClass.BaseTestInitialize()");

            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // check for CP77_DIR environment variable first
            // overrides hardcoded appsettings.json
            var CP77_DIR = System.Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(CP77_DIR) && new DirectoryInfo(CP77_DIR).Exists)
                _gameDirectoryPath = CP77_DIR;
            else
                _gameDirectoryPath = _config.GetSection(GameDirectorySetting).Value;
            if (string.IsNullOrEmpty(_gameDirectoryPath))
                throw new ConfigurationErrorsException($"'{GameDirectorySetting}' is not configured");
            var gameDirectory = new DirectoryInfo(_gameDirectoryPath);
            if (!gameDirectory.Exists)
                throw new ConfigurationErrorsException($"'{GameDirectorySetting}' is not a valid directory");

            // copy oodle dll
            var gameBinDir = new DirectoryInfo(Path.Combine(gameDirectory.FullName, "bin", "x64"));
            var oodleInfo = new FileInfo(Path.Combine(gameBinDir.FullName, "oo2ext_7_win64.dll"));
            if (!oodleInfo.Exists)
                throw new DecompressionException("Could not find oo2ext_7_win64.dll.");

            var ass = AppDomain.CurrentDomain.BaseDirectory;
            var destFileName = Path.Combine(ass, "oo2ext_7_win64.dll");
            if (!File.Exists(destFileName))
                oodleInfo.CopyTo(destFileName);

            WriteToFile = bool.Parse(_config.GetSection(WriteToFileSetting).Value);

            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
            ServiceLocator.Default.RegisterType<IHashService, HashService>();

            _ = ServiceLocator.Default.ResolveType<IHashService>();

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

        #endregion Methods
    }
}
