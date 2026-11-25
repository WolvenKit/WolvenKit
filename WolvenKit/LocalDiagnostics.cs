#if LOCAL_DIAGNOSTICS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;

namespace WolvenKit;

// Deliberately absent from ordinary builds. No listener, scripting, or remote control.
internal static class LocalDiagnostics
{
    internal static async Task<int> RunAsync(string[] args, IServiceProvider services)
    {
        var index = Array.IndexOf(args, "--local-diagnostics");
        if (index < 0 || args.Length != index + 4)
        {
            return 2;
        }

        var reportPath = Path.GetFullPath(args[index + 3]);
        var results = new List<object>();
        var exitCode = 0;
        string failure = null;
        try
        {
            var raw = new DirectoryInfo(Path.GetFullPath(args[index + 1]));
            var output = Path.GetFullPath(args[index + 2]);
            if (!raw.Exists || output.Equals(raw.FullName, StringComparison.OrdinalIgnoreCase) ||
                Directory.Exists(output) && Directory.EnumerateFileSystemEntries(output).Any())
            {
                throw new ArgumentException("Input must exist; output must be a separate, empty directory.");
            }

            var helper = services.GetRequiredService<ImportExportHelper>();
            var parser = services.GetRequiredService<Red4ParserService>();
            RedImage.LoggerService = services.GetRequiredService<ILoggerService>();
            foreach (var file in raw.GetFiles("*", SearchOption.AllDirectories).OrderBy(x => x.FullName))
            {
                var visible = ImportExportHelper.CanImportFilepath(file.FullName);
                string options = null;
                string error = null;
                var imported = false;
                var parsed = false;
                string rootType = null;
                var relative = Path.GetRelativePath(raw.FullName, file.FullName);
                // Each input gets its own directory: .jpg and .jpeg may share a stem.
                var destination = Directory.CreateDirectory(Path.Combine(output, relative + ".result"));
                var xbm = Path.Combine(destination.FullName, Path.ChangeExtension(relative, "xbm"));
                try
                {
                    if (visible)
                    {
                        var item = new ImportableItemViewModel(file.FullName,
                            services.GetRequiredService<IArchiveManager>(),
                            services.GetRequiredService<IProjectManager>(), parser);
                        options = item.Properties.GetType().Name;
                        if (item.Properties is XbmImportArgs textureArgs)
                        {
                            var settings = new GlobalImportArgs().Register(textureArgs);
                            if (helper.Finalize(textureArgs, settings))
                            {
                                imported = await helper.Import(new RedRelativePath(raw, relative), settings, destination);
                            }
                            if (File.Exists(xbm))
                            {
                                using var stream = File.OpenRead(xbm);
                                parsed = parser.TryReadRed4File(stream, out var redFile);
                                rootType = redFile?.RootChunk?.GetType().Name;
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    error = exception.ToString();
                    exitCode = 1;
                }
                results.Add(new
                {
                    File = relative,
                    Sha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(file.FullName))),
                    VisibleInImportTool = visible, Options = options,
                    Imported = imported, Parsed = parsed, RootType = rootType,
                    Output = File.Exists(xbm) ? xbm : null, Error = error
                });
            }
        }
        catch (Exception exception)
        {
            failure = exception.ToString();
            exitCode = 1;
        }

        Directory.CreateDirectory(Path.GetDirectoryName(reportPath));
        await File.WriteAllTextAsync(reportPath, JsonSerializer.Serialize(new
        {
            Mode = "Local diagnostics: production Import Tool filter, options and import pipeline",
            Executable = Environment.ProcessPath, ProcessId = Environment.ProcessId,
            Version = FileVersionInfo.GetVersionInfo(Environment.ProcessPath).FileVersion,
            Timestamp = DateTimeOffset.UtcNow, Results = results, Error = failure
        }, new JsonSerializerOptions { WriteIndented = true }));
        return exitCode;
    }
}
#endif
