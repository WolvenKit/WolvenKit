using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class CR2WCommand : Command
    {
        #region Fields

        private new const string Description = "Target a specific CR2W (extracted) and dump file info.";
        private new const string Name = "cr2w";

        #endregion Fields

        #region Constructors

        public CR2WCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to a CR2W file."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output path."));
            AddOption(new Option<bool>(new[] { "--chunks", "-c" }, "Dump all class information."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));

            Handler = CommandHandler.Create<string[], string, bool, string, string, IHost>(Action);
        }

        private void Action(string[] path, string outpath, bool chunks, string pattern, string regex, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.Cr2wTask(path, outpath, chunks, pattern, regex);
        }

        #endregion Constructors
    }
}
