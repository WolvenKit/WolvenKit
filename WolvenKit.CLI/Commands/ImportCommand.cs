using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class ImportCommand : Command
    {
        private new const string Description = "Import raw files into redengine files.";
        private new const string Name = "import";

        public ImportCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("path", "Input path for raw files. Can be a file or a folder or a list of files/folders."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "[Deprecated] Input path for raw files. Can be a file or a folder or a list of files/folders."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path.  If used with --keep, this is the folder for the redengine files to rebuild."));

            AddOption(new Option<bool>(new[] { "--keep", "-k" }, "Keep existing CR2W files intact and only append the buffer."));

            Handler = CommandHandler.Create<string[], DirectoryInfo, bool, IHost>(Action);
        }

        private async Task Action(string[] path, DirectoryInfo outpath, bool keep, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            await consoleFunctions.ImportTask(path, outpath, keep);
        }
    }
}
