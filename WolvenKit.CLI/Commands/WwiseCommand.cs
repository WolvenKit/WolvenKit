using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class WwiseCommand : Command
    {
        private new const string Description = "Some helper functions related to Wwise.";
        private new const string Name = "wwise";

        public WwiseCommand() : base(Name, Description)
        {
            AddArgument(new Argument<FileInfo[]>("path", "Input file epath."));
            AddArgument(new Argument<FileInfo[]>("outpath", () => null, "Output file path."));

            AddOption(new Option<bool>(new[] { "--wem", "-w" }, "Convert WEM to OGG."));

            Handler = CommandHandler.Create<FileInfo, FileInfo, bool, IHost>(Action);
        }

        private void Action(FileInfo path, FileInfo outpath, bool wem, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.WwiseTask(path, outpath, wem);
        }
    }
}
