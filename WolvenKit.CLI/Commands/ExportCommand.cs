using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;

namespace CP77Tools.Commands
{
    public class ExportCommand : Command
    {
        private new const string Description = "Export a file or list of files into raw files.";
        private new const string Name = "export";

        public ExportCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("path", "Input path to file/directory or list of files/directories."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "[Deprecated] Input path to file/directory or list of files/directories."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path for all files to export to."));

            AddOption(new Option<EUncookExtension?>(new[] { "--uext" }, "Format to uncook textures into (tga, bmp, jpg, png, dds), DDS by default."));
            AddOption(new Option<bool?>(new[] { "--flip", "-f" }, "Flips textures vertically."));
            AddOption(new Option<ECookedFileFormat[]>(new[] { "--forcebuffers", "-fb" }, "Force uncooking to buffers for given extension. e.g. mesh."));

            Handler = CommandHandler.Create<string[], DirectoryInfo, EUncookExtension?, bool?, ECookedFileFormat[], IHost>(Action);
        }

        private void Action(string[] path, DirectoryInfo outpath, EUncookExtension? uext, bool? flip, ECookedFileFormat[] forcebuffers, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ExportTask(path, outpath, uext, flip, forcebuffers);
        }
    }
}
