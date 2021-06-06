using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CP77Tools.Commands
{
    public class ArchiveCommand : Command
    {
        #region Fields

        private new const string Description = "Target an archive to display information of it.";
        private new const string Name = "archive";

        #endregion Fields

        #region Constructors

        public ArchiveCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to .archive."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<bool>(new[] { "--diff", "-d" }, "Dump archive json for diff"));
            AddOption(new Option<bool>(new[] { "--list", "-l" }, "List all files in archive"));

            Handler = CommandHandler.Create<string[], string, string, bool, bool, IHost>(Action);
        }

        private void Action(string[] path, string pattern, string regex, bool diff, bool list, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ArchiveTask(path, pattern, regex, diff, list);
        }

        #endregion Constructors
    }
}
