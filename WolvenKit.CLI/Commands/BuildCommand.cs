using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class BuildCommand : CommandBase
{
    private const string s_description = "Builds all WolvenKit .cpmodproj project(s) found in <paths>.";
    private const string s_name = "build";

    public BuildCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<DirectoryInfo[]>("paths", "Input folder(s) containing WolvenKit .cpmodproj project(s)."));

        SetInternalHandler(CommandHandler.Create<DirectoryInfo[], IHost>(Action));
    }

    private int Action(DirectoryInfo[] paths, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (paths == null || paths.Length < 1)
        {
            logger.Error("Input path(s) missing for build.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.BuildTask(paths);
    }
}
