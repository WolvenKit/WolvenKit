using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using CP77Tools.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WolvenKit.CLI.Services;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.MeshFile;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.CLI
{
    internal static class GenericHost
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, configuration) =>
                {
                    configuration
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
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
                    services.AddScoped<IProgress<double>, PercentProgressService>();
                    //services.AddScoped<IProgress<double>, ProgressBar>();

                    services.AddSingleton<IHashService, HashService>();


                    services.AddScoped<Red4ParserService>();
                    services.AddScoped<TargetTools>();      //Cp77FileService
                    services.AddScoped<RIG>();              //Cp77FileService
                    services.AddScoped<MESHIMPORTER>();     //Cp77FileService
                    services.AddScoped<MeshTools>();        //RIG, Cp77FileService

                    services.AddScoped<ModTools>();         //Cp77FileService, ILoggerService, IProgress, IHashService, Mesh, Target

                    //services.AddScoped<MaterialTools>();    //ModTools, Cp77FileService, CookingUtilities

                    services.AddOptions<CommonImportArgs>().Bind(hostContext.Configuration.GetSection("CommonImportArgs"));
                    services.AddOptions<XbmImportArgs>().Bind(hostContext.Configuration.GetSection("XbmImportArgs"));
                    services.AddOptions<MeshImportArgs>().Bind(hostContext.Configuration.GetSection("MeshImportArgs"));

                    services.AddOptions<XbmExportArgs>().Bind(hostContext.Configuration.GetSection("XbmExportArgs"));
                    services.AddOptions<MeshExportArgs>().Bind(hostContext.Configuration.GetSection("MeshExportArgs"));
                    services.AddOptions<MorphTargetExportArgs>().Bind(hostContext.Configuration.GetSection("MorphTargetExportArgs"));
                    services.AddOptions<MlmaskExportArgs>().Bind(hostContext.Configuration.GetSection("MlmaskExportArgs"));
                    services.AddOptions<WemExportArgs>().Bind(hostContext.Configuration.GetSection("WemExportArgs"));

                    services.AddScoped<ConsoleFunctions>();
                }
            );
    }
}
