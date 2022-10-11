using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class ArchiveCommand : Command
    {
        private new const string Description = "Target an archive to display information of it.";
        private new const string Name = "archive";

        public ArchiveCommand() : base(Name, Description)
        {
            AddAlias("archiveinfo");

            AddArgument(new Argument<string[]>("path", "Input archives path. Can be a file or a folder or a list of files/folders."));

            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));
            AddOption(new Option<bool>(new[] { "--diff", "-d" }, "Dump archive json for diff."));
            AddOption(new Option<bool>(new[] { "--list", "-l" }, "List all files in archive."));

            Handler = CommandHandler.Create<string[], string, string, bool, bool, IHost>(Action);
        }

        private void Action(string[] path, string pattern, string regex, bool diff, bool list, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ArchiveTask(path, pattern, regex, diff, list);
        }
    }
}
