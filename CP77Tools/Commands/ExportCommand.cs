using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using WolvenKit.Common.DDS;

namespace CP77Tools.Commands
{
    public class ExportCommand : Command
    {
        private new const string Name = "export";
        private new const string Description = "Export a file or list of files into raw files.";

        public ExportCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path to file or list of files."));
            AddOption(new Option<EUncookExtension>(new[] { "--uext" }, "Format to uncook textures into (tga, bmp, jpg, png, dds), TGA by default."));
            AddOption(new Option<bool>(new[] { "--flip", "-f" }, "Flips textures vertically (can help with legibility if there's text)."));

            Handler = CommandHandler.Create<string[], EUncookExtension, bool>(ConsoleFunctions.ExportTask);
        }
    }
}
