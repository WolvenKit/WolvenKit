using System.CommandLine;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.CLI;
using WolvenKit.Common;
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

        SetInternalHandler(CommandHandlerEx.Create<FileSystemInfo[], string, string, string, EUncookExtension?, ulong, string, string, bool, ECookedFileFormat[], 
        bool?, MeshExporterType?, MeshExportType?, string, bool?, bool?, IHost>(Action));
    }

    private int Action(FileSystemInfo[] path, string outpath, string gamepath, string raw, EUncookExtension? uext, ulong hash, string pattern,
        string regex, bool unbundle, ECookedFileFormat[] forcebuffers, bool? serialize, MeshExporterType? meshExporterType, MeshExportType? meshExportType, string meshExportMaterialRepo, 
        bool? meshExportLodFilter, bool? meshExportExperimentalMergedExport, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if ((path == null || path.Length < 1) && string.IsNullOrEmpty(gamepath))
        {
            logger.Error("Please fill in an input path.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.UncookTask(path, new UncookTaskOptions
        {
            outpath = string.IsNullOrEmpty(outpath) ? null : new DirectoryInfo(outpath),
            rawOutDir = raw,
            gamepath = gamepath,
            uext = uext,
            hash = hash,
            pattern = pattern,
            regex = regex,
            unbundle = unbundle,
            forcebuffers = forcebuffers,
            serialize = serialize,
            meshExporterType = meshExporterType,
            meshExportType = meshExportType,
            meshExportMaterialRepo = meshExportMaterialRepo,
            meshExportLodFilter = meshExportLodFilter,
            meshExportExperimentalMergedExport = meshExportExperimentalMergedExport
        });
    }
}
