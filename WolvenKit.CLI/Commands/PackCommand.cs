using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class PackCommand : Command
    {
        private new const string Description = "Pack the contents of a folder into an .archive file.";
        private new const string Name = "pack";

        public PackCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("path", "Input path. Must be a folder/list of folders."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "[Deprecated] Input path. Must be a folder/list of folders."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory to create all archives.\nIf not specified, will output in the same directory."));

            Handler = CommandHandler.Create<string[], DirectoryInfo, IHost>(Action);
        }

        private void Action(string[] path, DirectoryInfo outpath, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.PackTask(path, outpath);
        }
    }
}
