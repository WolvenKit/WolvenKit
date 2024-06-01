using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.FunctionalTests
{
    [TestClass]
    public class GameUnitTest
    {
        internal const string s_testResultsDirectory = "_CR2WTestResults";
        internal static Dictionary<string, IEnumerable<IGameFile>> s_groupedFiles = new();
        internal static IArchiveManager? s_bm;
        internal static bool s_writeToFile;
        private const string s_gameDirectorySetting = "GameDirectory";
        private const string s_writeToFileSetting = "WriteToFile";
        protected static IConfigurationRoot? s_config;
        public static string? s_gameDirectoryPath;
        internal static IHost _host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                        .AddScoped<ILoggerService, SerilogWrapper>()
                        .AddScoped<IProgressService<double>, ProgressService<double>>()
                        .AddSingleton<IHashService, HashService>()

                        .AddScoped<IHookService, HookService>()
                        .AddScoped<Red4ParserService>()
                        .AddScoped<MeshTools>()
                        .AddSingleton<IArchiveManager, ArchiveManager>()
                        .AddSingleton<IModTools, ModTools>()
                        .UseMicrosoftDependencyResolver()
                        )
                .Build();

        public GameUnitTest()
        {
            // logging
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            // IoC
            //_host = Host.CreateDefaultBuilder()
            //    .ConfigureServices((_, services) =>
            //        services
            //            .AddScoped<ILoggerService, SerilogWrapper>()
            //            .AddScoped<IProgressService<double>, ProgressService<double>>()
            //            .AddSingleton<IHashService, HashService>()

            //            .AddScoped<Red4ParserService>()
            //            .AddScoped<MeshTools>()
            //            .AddSingleton<IArchiveManager, ArchiveManager>()
            //            .AddSingleton<IModTools, ModTools>()
            //            )
            //    .Build();
        }

        protected static void Setup(TestContext context)
        {
            #region cp77 game dir

            // Init
            Console.WriteLine("BaseTestClass.BaseTestInitialize()");
            s_config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            s_writeToFile = bool.Parse(s_config.GetSection(s_writeToFileSetting).Value!);

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
                throw new DirectoryNotFoundException($"'{s_gameDirectorySetting}' is not configured");
            }

            var gameDirectory = new DirectoryInfo(s_gameDirectoryPath);
            if (!gameDirectory.Exists)
            {
                throw new DirectoryNotFoundException($"'{s_gameDirectorySetting}' is not a valid directory");
            }

            #endregion

            #region oodle

            if (!Oodle.Load())
            {
                Assert.Fail($"Could not load {Core.Constants.Oodle}.");
            }

            #endregion

            //protobuf
            //RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));


            //var hashService = _host.Services.GetRequiredService<IHashService>();
            s_bm = _host.Services.GetRequiredService<IArchiveManager>();

            var exePath = new FileInfo(Path.Combine(gameDirectory.FullName, "bin", "x64", "Cyberpunk2077.exe"));
            s_bm.LoadGameArchives(exePath);
            s_groupedFiles = s_bm.GetGroupedFiles(ArchiveManagerScope.Basegame);

            var keyes = s_groupedFiles.Keys.ToList();
            var keystring = string.Join(',', keyes);
            //Console.WriteLine(keystring);
        }

    }
}
