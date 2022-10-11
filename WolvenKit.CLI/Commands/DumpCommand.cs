using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class DumpCommand : Command
    {
        private new const string Description = "Target an archive or a directory to dump archive information.";
        private new const string Name = "dump";

        public DumpCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("path", "Input path to an .archive or directory (runs over all archives in directory)."));

            AddOption(new Option<bool>(new[] { "--imports", "-i" }, "Dump all imports (all filenames referenced by files in the archive)."));
            AddOption(new Option<bool>(new[] { "--missinghashes", "-m" }, "List missing hashes for all input archives."));
            AddOption(new Option<bool>(new[] { "--texinfo" }, "Dump all XBM info."));
            AddOption(new Option<bool>(new[] { "--dump", "-d" }, "Dump archive information."));
            AddOption(new Option<bool>(new[] { "--list", "-l" }, "List archive contents."));


            Handler = CommandHandler.Create<string[], bool, bool, bool, bool, bool, IHost>(Action);
        }

        private void Action(string[] path, bool imports, bool missinghashes, bool texinfo, bool dump, bool list, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.DumpTask(path, imports, missinghashes, texinfo, dump, list);
        }
    }
}
