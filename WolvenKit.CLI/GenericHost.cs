using System;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WolvenKit.CLI.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.CLI;

internal static class GenericHost
{
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                var assemblyFolder = Path.GetDirectoryName(System.AppContext.BaseDirectory);

                configuration.SetBasePath(assemblyFolder);
                configuration.AddJsonFile("appsettings.json");
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddColorConsoleLogger(configuration =>
                {
                    configuration.LogLevels.Add(LogLevel.Warning, ConsoleColor.DarkYellow);
                    configuration.LogLevels.Add(LogLevel.Error, ConsoleColor.DarkMagenta);
                    configuration.LogLevels.Add(LogLevel.Critical, ConsoleColor.Red);
                });
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddScoped<ILoggerService, MicrosoftLoggerService>();
                services.AddScoped<IProgressService<double>, PercentProgressService>();
                //services.AddScoped<IProgress<double>, ProgressBar>();

                services.AddSingleton<IHashService, HashService>();
                services.AddSingleton<ITweakDBService, TweakDBService>();
                services.AddSingleton<ILocKeyService, LocKeyService>();

                services.AddSingleton<IHookService, HookService>();

                //services.AddScoped<TweakDBService>();
                services.AddScoped<Red4ParserService>();
                services.AddScoped<MeshTools>();        //RIG, Cp77FileService
                services.AddSingleton<IArchiveManager, ArchiveManager>();
                services.AddSingleton<IModTools, ModTools>();

                //services.AddScoped<MaterialTools>();    //ModTools, Cp77FileService, CookingUtilities

                services.AddOptions<CommonImportArgs>().Bind(hostContext.Configuration.GetSection("CommonImportArgs"));
                services.AddOptions<XbmImportArgs>().Bind(hostContext.Configuration.GetSection("XbmImportArgs"));
                services.AddOptions<GltfImportArgs>().Bind(hostContext.Configuration.GetSection("GltfImportArgs"));

                services.AddOptions<XbmExportArgs>().Bind(hostContext.Configuration.GetSection("XbmExportArgs"));
                services.AddOptions<MeshExportArgs>().Bind(hostContext.Configuration.GetSection("MeshExportArgs"));
                services.AddOptions<AnimationExportArgs>().Bind(hostContext.Configuration.GetSection("AnimationExportArgs"));
                services.AddOptions<MorphTargetExportArgs>().Bind(hostContext.Configuration.GetSection("MorphTargetExportArgs"));
                services.AddOptions<MlmaskExportArgs>().Bind(hostContext.Configuration.GetSection("MlmaskExportArgs"));
                services.AddOptions<WemExportArgs>().Bind(hostContext.Configuration.GetSection("WemExportArgs"));

                services.AddScoped<ConsoleFunctions>();
            }
        );
    }
}
