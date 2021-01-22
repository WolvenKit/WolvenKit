using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class UnbundleCommand : Command
    {
        private static string Name = "unbundle";
        private static string Description = "Target an archive to extract files.";
        
        public UnbundleCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path to .archive."));
            AddOption(new Option<string>(new[] {"--outpath", "-o"}, "Output directory to extract files to."));
            AddOption(new Option<string>(new[] {"--pattern", "-w"}, "Use optional search pattern, e.g. *.ink. If both regex and pattern is defined, pattern will be used first"));
            AddOption(new Option<string>(new[] {"--regex", "-r"}, "Use optional regex pattern."));
            AddOption(new Option<string>(new[] {"--hash"}, "Extract single file with given hash. If a path is supplied it extracts all hashes from that."));
            
            Handler = CommandHandler.Create<string[], string, string, string, string>(ConsoleFunctions.UnbundleTask);
        }
    }
}