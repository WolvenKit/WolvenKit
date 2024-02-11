#define IS_ASYNC
#undef IS_ASYNC

using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class UnbundleCommand : CommandBase
{
    private const string s_description = "Target an archive to extract files from.";
    private const string s_name = "unbundle";

    public UnbundleCommand() : base(s_name, s_description)
    {
        AddAlias("extract");

        AddArgument(new Argument<FileSystemInfo[]>("path", "Input paths to .archive files or folders."));

        // deprecated. keep for backwards compatibility
        AddOption(new Option<FileSystemInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input paths to .archive files or folders."));

        // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
        AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory for all input archives."));

        AddOption(new Option<string>(new[] { "--gamepath", "-gp" }, "Path to the Cyberpunk 2077 directory."));

        AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
        AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
        AddOption(new Option<string>(new[] { "--hash" }, "Extract single file with a given hash. If a path is supplied, all hashes will be extracted."));
        AddOption(new Option<bool>(new[] { "--DEBUG_decompress" }, "Decompresses all buffers in the unbundled files."));

        SetInternalHandler(CommandHandler.Create<FileSystemInfo[], string, string, string, string, string, bool, IHost>(Action));
    }

    private int Action(FileSystemInfo[] path, string outpath, string gamepath, string pattern, string regex, string hash, bool DEBUG_decompress, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (path == null || path.Length < 1)
        {
            logger.Error("Please fill in an input path.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();

#if IS_ASYNC
        //Task.WhenAll(consoleFunctions.UnbundleTaskAsync(path, outpath, hash, pattern, regex, DEBUG_decompress)).Wait();#
        throw new NotImplementedException();
#else
        //return consoleFunctions.UnbundleTask(path, string.IsNullOrEmpty(outpath) ? null : new DirectoryInfo(outpath), hash, pattern, regex, DEBUG_decompress);
        return consoleFunctions.UnbundleTask(path, new UnbundleTaskOptions
        {
            outpath = string.IsNullOrEmpty(outpath) ? null : new DirectoryInfo(outpath),
            gamepath = gamepath,
            hash = hash,
            pattern = pattern,
            regex = regex,
            DEBUG_decompress = DEBUG_decompress
        });
#endif
    }
}
