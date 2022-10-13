using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class ImportCommand : CommandBase
{
    private const string s_description = "Import raw files into redengine files.";
    private const string s_name = "import";

    public ImportCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<FileSystemInfo[]>("path", "Input path for raw files. Can be a file or a folder or a list of files/folders."));

        // deprecated. keep for backwards compatibility
        AddOption(new Option<FileSystemInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input path for raw files. Can be a file or a folder or a list of files/folders."));

        // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
        AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory path.  If used with --keep, this is the folder for the redengine files to rebuild."));

        AddOption(new Option<bool>(new[] { "--keep", "-k" }, "Keep existing CR2W files intact and only append the buffer."));

        SetInternalHandler(CommandHandler.Create<FileSystemInfo[], string, bool, IHost>(Action));
    }

    private Task<int> Action(FileSystemInfo[] path, string outpath, bool keep, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (path == null || path.Length < 1)
        {
            logger.Error("Please fill in an input path.");
            return Task.FromResult(ConsoleFunctions.ERROR_BAD_ARGUMENTS);
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.ImportTask(path, new DirectoryInfo(outpath), keep);
    }
}
