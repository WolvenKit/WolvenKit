using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class ConflictsCommand : CommandBase
{
    private const string s_description = "Lists all mod conflicts in your mods.";
    private const string s_name = "conflicts";

    public ConflictsCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<DirectoryInfo>("path", () => new DirectoryInfo(Path.GetFullPath(Environment.CurrentDirectory)), "Path to your Cyberpunk 2077 game folder (if left empty it will use the current working directory)."));

        AddOption(new Option<bool>(new[] { "--structured", "-s" }, "Print structured output (json)."));

        SetInternalHandler(CommandHandler.Create<DirectoryInfo, bool, IHost>(Action));
    }

    private static int Action(DirectoryInfo path, bool structured, IHost host)
    {
        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (!path.Exists)
        {
            logger.Error("Incorrect input path: Directory does not exist");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        // check if game dir
        if (!path.Name.Equals("Cyberpunk 2077"))
        {
            logger.Error("Incorrect input path: Not game folder");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }
        var gameExe = new FileInfo(Path.Combine(path.FullName, "bin", "x64", "Cyberpunk2077.exe"));
        if (!gameExe.Exists)
        {
            logger.Error("Incorrect input path: Not game folder");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }


        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.ConflictsTask(path, structured);
    }
}
