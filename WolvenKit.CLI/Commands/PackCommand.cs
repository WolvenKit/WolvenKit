using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    internal class PackCommand : CommandBase
    {
        private const string s_description = "Pack resource files into an .archive file.";
        private const string s_name = "pack";

        public PackCommand() : base(s_name, s_description)
        {
            AddArgument(new Argument<DirectoryInfo[]>("path", "Input folder or folders."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<DirectoryInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input folder or folders."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory to create all archives.\nIf not specified, will output in the same directory."));

            SetHandler(CommandHandler.Create<DirectoryInfo[], DirectoryInfo, IHost>(Action));
        }

        private void Action(DirectoryInfo[] path, DirectoryInfo outpath, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.PackTask(path, outpath);
        }
    }
}
