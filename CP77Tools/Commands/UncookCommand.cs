using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using WolvenKit.Common.DDS;

namespace CP77Tools.Commands
{
    public class UncookCommand : Command
    {
        private static string Name = "uncook";
        private static string Description = "Target an archive to uncook files.";
        
        public UncookCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path to .archive."));
            AddOption(new Option<string>(new[] {"--outpath", "-o"}, "Output directory to extract files to."));
            AddOption(new Option<string>(new[] {"--pattern", "-w"}, "Use optional search pattern, e.g. *.ink. If both regex and pattern is defined, pattern will be used first"));
            AddOption(new Option<string>(new[] {"--regex", "-r"}, "Use optional regex pattern."));
            AddOption(new Option<EUncookExtension>(new[] {"--uext"}, "Uncook extension (tga, bmp, jpg, png, dds). Default is tga."));
            AddOption(new Option<bool>(new[] { "--flip", "-f" }, "Flips textures vertically"));
            AddOption(new Option<ulong>(new[] {"--hash"}, "Extract single file with given hash."));
            
            Handler = CommandHandler.Create<string[], string, 
                EUncookExtension, bool, ulong, string, string>(ConsoleFunctions.UncookTask);
        }
    }
}