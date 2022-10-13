using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class ExportCommand : CommandBase
{
    private const string s_description = "Export a file or list of files into raw files.";
    private const string s_name = "export";

    public ExportCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<FileSystemInfo[]>("path", "Input path to file/directory or list of files/directories."));

        // deprecated. keep for backwards compatibility
        AddOption(new Option<FileSystemInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input path to file/directory or list of files/directories."));

        AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path for all files to export to."));

        AddOption(new Option<EUncookExtension?>(new[] { "--uext" }, "Format to uncook textures into (tga, bmp, jpg, png, dds), DDS by default."));
        AddOption(new Option<bool?>(new[] { "--flip", "-f" }, "Flips textures vertically."));
        AddOption(new Option<ECookedFileFormat[]>(new[] { "--forcebuffers", "-fb" }, "Force uncooking to buffers for given extension. e.g. mesh."));

        SetInternalHandler(CommandHandler.Create<FileSystemInfo[], DirectoryInfo, EUncookExtension?, bool?, ECookedFileFormat[], IHost>(Action));
    }

    private int Action(FileSystemInfo[] path, DirectoryInfo outpath, EUncookExtension? uext, bool? flip, ECookedFileFormat[] forcebuffers, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (path is null || path.Length < 1)
        {
            logger.Error("Please fill in an input path.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.ExportTask(path, outpath, uext, flip, forcebuffers);
    }
}
