using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CP77.CR2W;
using CP77Tools.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WolvenKit.CLI.Services;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Interfaces.Core;
using WolvenKit.Modkit.RED4.Materials;
using WolvenKit.Modkit.RED4.MeshFile;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace WolvenKit.CLI
{
    internal class Debug
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var oodlePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "oo2ext_7_win64.dll");
            OodleLoadLib.Load(oodlePath);

            var host = GenericHost.CreateHostBuilder(args);
            host.ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<WorkerHostedService>();
            });
            host.Build().RunAsync();
        }

        public class WorkerHostedService : IHostedService
        {
            private readonly ILogger _logger;
            private readonly IHashService _hashService;

            public WorkerHostedService(
                ILogger<WorkerHostedService> logger,
                IHashService hashService,
                IHostApplicationLifetime appLifetime)
            {
                _logger = logger;
                _hashService = hashService;
            }

            public Task StartAsync(CancellationToken cancellationToken)
            {
                _logger.LogInformation("StartAsync has been called");

                //DumpNameHashInfo();
                DumpBufferInfo();

                return Task.CompletedTask;
            }

            private void DumpBufferInfo()
            {
                var gameDirectory = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
                var gameBinDir = new DirectoryInfo(Path.Combine(gameDirectory, "bin", "x64"));
                var bm = new ArchiveManager(_hashService);
                bm.LoadAll(gameBinDir.FullName, false);
                var groupedFiles = bm.GroupedFiles;
                _logger.LogInformation("ArchiveManager loaded");

                var exclude = new List<String>()
                {
                    ".wem"
                };
                foreach (var (key, fileEntries) in groupedFiles)
                {
                    if (exclude.Contains(key))
                    {
                        continue;
                    }
                    InspectFiles(groupedFiles, bm, key);
                }

                void InspectFiles(Dictionary<string, IEnumerable<FileEntry>> groupedFiles, ArchiveManager bm, string ext)
                {
                    var fileslist = groupedFiles[ext].ToList();
                    _logger.LogInformation("Loaded {fileslist.Count} {ext} files", fileslist.Count, ext);

                    var logpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logs", $"blog_{ext.TrimStart('.')}.csv");
                    using var fs = new FileStream(logpath, FileMode.Create, FileAccess.Write);
                    using var sw = new StreamWriter(fs);
                    sw.WriteLine($"name;flags");

                    int latest = 0;
                    int unknown = 0;
                    int pre = 0;

                    for (var i = 1; i < fileslist.Count + 1; i++)
                    {
                        var file = fileslist[i - 1];
                        var ar = bm.Archives[file.Archive.ArchiveAbsolutePath] as Archive;
                        using var ms = new MemoryStream();
                        ar.CopyFileToStreamWithoutBuffers(ms, file.NameHash64);

                        var c = new CR2WFile { FileName = file.NameOrHash };
                        ms.Seek(0, SeekOrigin.Begin);
                        using var br = new BinaryReader(ms);
                        try
                        {
                            var readResult = c.ReadHeaders(br);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }

                        var buffers = c.Buffers;
                        foreach (var buffer in buffers)
                        {
                            sw.WriteLine($"{file.Name};{buffer.Flags.ToString("X")}");
                        }


                        var percf = (float)i / (float)fileslist.Count * 100;
                        Console.Write($"\r{i}/{fileslist.Count}-{(int)percf}%");

                    }

                    _logger.LogInformation("[{ext}] unknown: {unknown}, pre: {pre}, latest: {latest}, ", ext, unknown, pre, latest);
                }
            }

            private void DumpNameHashInfo()
            {
                var gameDirectory = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
                var gameBinDir = new DirectoryInfo(Path.Combine(gameDirectory, "bin", "x64"));
                var bm = new ArchiveManager(_hashService);
                bm.LoadAll(gameBinDir.FullName, false);
                var groupedFiles = bm.GroupedFiles;
                _logger.LogInformation("ArchiveManager loaded");




                var exclude = new List<String>()
                {
                    ".wem"
                };
                foreach (var (key, fileEntries) in groupedFiles)
                {
                    if (exclude.Contains(key))
                    {
                        continue;
                    }
                    InspectFiles(groupedFiles, bm, key);
                }

                void InspectFiles(Dictionary<string, IEnumerable<FileEntry>> groupedFiles, ArchiveManager bm, string ext)
                {
                    var fileslist = groupedFiles[ext].ToList();
                    _logger.LogInformation("Loaded {fileslist.Count} {ext} files", fileslist.Count, ext);

                    var logpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logs", $"log_{ext.TrimStart('.')}.csv");
                    using var fs = new FileStream(logpath, FileMode.Create, FileAccess.Write);
                    using var sw = new StreamWriter(fs);
                    sw.WriteLine($"version;buildVersion;hashversion");

                    int latest = 0;
                    int unknown = 0;
                    int pre = 0;

                    for (var i = 1; i < fileslist.Count + 1; i++)
                    {
                        var file = fileslist[i - 1];
                        var ar = bm.Archives[file.Archive.ArchiveAbsolutePath] as Archive;
                        using var ms = new MemoryStream();
                        ar.CopyFileToStreamWithoutBuffers(ms, file.NameHash64);

                        var c = new CR2WFile { FileName = file.NameOrHash };
                        ms.Seek(0, SeekOrigin.Begin);
                        using var br = new BinaryReader(ms);
                        try
                        {
                            var readResult = c.ReadHeaders(br);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }


                        var header = c.Header;
                        var hashversion = c.IdentifyHash();

                        switch (hashversion)
                        {
                            case CR2WFile.EHashVersion.Unknown:
                                unknown++;
                                break;
                            case CR2WFile.EHashVersion.Pre120:
                                pre++;
                                break;
                            case CR2WFile.EHashVersion.Latest:
                                latest++;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                        sw.WriteLine($"{header.version};{header.buildVersion};{hashversion.ToString()}");

                        var percf = (float)i / (float)fileslist.Count * 100;
                        Console.Write($"\r{i}/{fileslist.Count}-{(int)percf}%");

                    }

                    _logger.LogInformation("[{ext}] unknown: {unknown}, pre: {pre}, latest: {latest}, ", ext, unknown, pre, latest);
                }
            }

            public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        }
    }
}
