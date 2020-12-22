using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using WolvenKit.Common.Tools.DDS;

namespace CP77Tools.Commands
{
    public class ArchiveCommand : Command
    {
        private static string Name = "archive";
        private static string Description = "Target an archive to extract files or dump information.";
        
        public ArchiveCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] {"--path", "-p"}, "Input path to .archive."));
            AddOption(new Option<string>(new[] {"--outpath", "-o"}, "Output directory to extract files to."));
            AddOption(new Option<string>(new[] {"--pattern", "-w"}, "Use optional search pattern, e.g. *.ink. If bith regex and pattern is definedm, pattern will be used first"));
            AddOption(new Option<string>(new[] {"--regex", "-r"}, "Use optional regex pattern."));
            AddOption(new Option<bool>(new[] {"--extract", "-e"}, "Extract files from archive."));
            AddOption(new Option<bool>(new[] {"--dump", "-d"}, "Dump archive information."));
            AddOption(new Option<bool>(new[] {"--list", "-l"}, "List contents of archive."));
            AddOption(new Option<bool>(new[] {"--uncook", "-u"}, "Uncooks textures from archive."));
            AddOption(new Option<EUncookExtension>(new[] {"--uext"}, "Uncook extension (tga, bmp, jpg, png, dds). Default is tga."));
            AddOption(new Option<ulong>(new[] {"--hash"}, "Extract single file with given hash."));
            
            Handler = CommandHandler.Create<string[], string, bool, bool, bool, bool, EUncookExtension, ulong, string, string>(ConsoleFunctions.ArchiveTask);
        }
    }
}