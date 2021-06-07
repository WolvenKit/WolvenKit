using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common.DDS;

namespace CP77Tools.Commands
{
    public class ExportCommand : Command
    {
        #region Fields

        private new const string Description = "Export a file or list of files into raw files.";
        private new const string Name = "export";

        #endregion Fields

        #region Constructors

        public ExportCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to file/directory or list of files/directories"));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory path"));
            AddOption(new Option<EUncookExtension>(new[] { "--uext" }, "Format to uncook textures into (tga, bmp, jpg, png, dds), DDS by default"));
            AddOption(new Option<bool>(new[] { "--flip", "-f" }, "Flips textures vertically (can help with legibility if there's text)"));

            Handler = CommandHandler.Create<string[], string, EUncookExtension, bool, IHost>(Action);
        }

        private void Action(string[] path, string outpath, EUncookExtension uext, bool flip, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ExportTask(path, outpath, uext, flip);
        }

        #endregion Constructors
    }
}
