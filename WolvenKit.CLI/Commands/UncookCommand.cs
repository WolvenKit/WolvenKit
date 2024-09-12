using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Linq;
using CP77Tools.Tasks;
using DynamicData.Kernel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.CLI;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class UncookCommand : CommandBase
{
    private const string s_description = "Target an archive to uncook files fom.";
    private const string s_name = "uncook";
    public UncookCommand() : base(s_name, s_description)
    {
        AddAlias("unbundle-and-export");
        AddAlias("extract-and-export");

        AddArgument(new Argument<FileSystemInfo[]>("path", "Input paths to .archive files or folders."));

        // deprecated. keep for backwards compatibility
        AddOption(new Option<FileSystemInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input paths to .archive files or folders."));

        // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
        AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory to extract main files to."));

        AddOption(new Option<string>(new[] { "--gamepath", "-gp" }, "Path to the Cyberpunk 2077 directory."));

        AddOption(new Option<string>(new[] { "--raw", "-or" }, "Optional seperate directory to extract raw files to."));
        AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
        AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
        AddOption(new Option<EUncookExtension?>(new[] { "--uext" }, "Format to uncook to (tga, bmp, jpg, png, dds), TGA by default."));
        AddOption(new Option<ulong>(new[] { "--hash" }, "Extract single file with a given hash."));
        AddOption(new Option<bool>(new[] { "--unbundle", "-u" }, "Also unbundle files."));
        AddOption(new Option<ECookedFileFormat[]>(new[] { "--forcebuffers", "-fb" }, "Force uncooking to buffers for given extension. e.g. mesh"));
        AddOption(new Option<bool>(new[] { "--serialize", "-s" }, "Serialize to JSON"));
        AddOption(new Option<MeshExporterType?>(new[] { "--mesh-exporter-type" }, "Mesh exporter type (Default, Experimental)."));
        AddOption(new Option<MeshExportType?>(new[] { "--mesh-export-type" }, "Mesh export type (MeshOnly, WithMaterials (Default), WithRig, Multimesh)."));
        AddOption(new Option<string>(new[] { "--mesh-export-material-repo" }, "Location of the material repo, if not specified, it uses the outpath."));
        AddOption(new Option<bool>(new[] { "--mesh-export-lod-filter" }, "Filter out lod models."));
        AddOption(new Option<bool>(new[] { "--mesh-export-experimental-merged-export" }, "[EXPERIMENTAL] Merged mesh export. (Only supports Default or WithMaterials, re-import not supported)"));
        AddOption(new Option<bool>(new[] { "--opus-dump-json" }, "Dump .opusinfo file as JSON."));
        AddOption(new Option<string>(new[] { "--opus-hashes" }, "Comma-separated list of hashes to export from .opusinfo."));

        SetInternalHandler(CommandHandler.Create(Action));
    }

    private record UncookArguments : UncookTaskOptions
    {
        public FileSystemInfo[] path { get; init; }
        public new string outpath { get; init; }
        public new string gamepath { get; init; }
        public new string raw { get; init; }
        public new string opusHashes { get; init; }
    }

    private int Action(UncookArguments args, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if ((args.path == null || args.path.Length < 1) && args.gamepath == null)
        {
            logger.Error("Please fill in an input path.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var options = args as UncookTaskOptions;
        options.outpath = string.IsNullOrEmpty(args.outpath) ? null : new DirectoryInfo(args.outpath);
        options.gamepath = string.IsNullOrEmpty(args.gamepath) ? null : new DirectoryInfo(args.gamepath);
        options.raw = string.IsNullOrEmpty(args.raw) ? null : new DirectoryInfo(args.raw);

        if (string.IsNullOrEmpty(args.opusHashes))
        {
            options.opusHashes = null;
        }
        else
        {
            var split = args.opusHashes.Split(",");
            if (split.Length == 1 && split[0] == "*")
            {
                options.opusExportAll = true;
            }
            else
            {
                options.opusHashes = split.Select((hash, i) => uint.Parse(hash)).AsList();
            }
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.UncookTask(args.path, options);
    }
}
