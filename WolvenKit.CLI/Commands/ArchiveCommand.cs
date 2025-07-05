using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace CP77Tools.Commands;

internal class ArchiveCommand : CommandBase
{
    private const string s_description = "Display information of an .archive file.";
    private const string s_name = "archive";

    public ArchiveCommand() : base(s_name, s_description)
    {
        AddAlias("archiveinfo");

        AddArgument(new Argument<FileSystemInfo[]>("path", "Input archives path. Can be a file or a folder or a list of files/folders."));

        AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
        AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));
        AddOption(new Option<bool>(new[] { "--diff", "-d" }, "Dump archive json for diff."));
        AddOption(new Option<bool>(new[] { "--list", "-l" }, "List all files in archive."));

        SetInternalHandler(CommandHandler.Create<FileSystemInfo[], string, string, bool, bool, IHost>(Action));
    }

    private static int Action(FileSystemInfo[] path, string pattern, string regex, bool diff, bool list, IHost host)
    {

        var serviceProvider = host.Services;
        var logger = serviceProvider.GetRequiredService<ILoggerService>();

        if (path is null)
        {
            logger.Error("Please fill in an input path.");
            return 1;
        }
        if (path == null || path.Length < 1)
        {
            logger.Error("Please fill in an input path.");
            return 1;
        }

        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.ArchiveTask(path, pattern, regex, diff, list);
    }
}
