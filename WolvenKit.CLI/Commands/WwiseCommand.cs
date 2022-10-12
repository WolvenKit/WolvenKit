using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    internal class WwiseCommand : CommandBase
    {
        private const string s_description = "Some helper functions related to Wwise.";
        private const string s_name = "wwise";

        public WwiseCommand() : base(s_name, s_description)
        {
            AddArgument(new Argument<FileInfo[]>("path", "Input file epath."));
            AddArgument(new Argument<FileInfo[]>("outpath", () => null, "Output file path."));

            AddOption(new Option<bool>(new[] { "--wem", "-w" }, "Convert WEM to OGG."));

            SetHandler(CommandHandler.Create<FileInfo, FileInfo, bool, IHost>(Action));
        }

        private void Action(FileInfo path, FileInfo outpath, bool wem, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.WwiseTask(path, outpath, wem);
        }
    }
}
