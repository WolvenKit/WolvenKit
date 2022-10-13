using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class PackCommand : CommandBase
{
    private const string s_description = "Pack resource files into an .archive file.";
    private const string s_name = "pack";

    public PackCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<DirectoryInfo[]>("path", "Input folder or folders."));

        // deprecated. keep for backwards compatibility
        AddOption(new Option<DirectoryInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input folder or folders."));

        // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
        AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory to create all archives.\nIf not specified, will output in the same directory."));

        SetInternalHandler(CommandHandler.Create<DirectoryInfo[], string, IHost>(Action));
    }

    private int Action(DirectoryInfo[] path, string outpath, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (path == null || path.Length < 1)
        {
            logger.Error("Please fill in an input path.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.PackTask(path, new DirectoryInfo(outpath));
    }
}
