using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class UnbundleCommand : Command
    {
        #region Fields

        private new const string Description = "Target an archive to extract files from.";
        private new const string Name = "unbundle";

        #endregion Fields

        #region Constructors

        public UnbundleCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to .archive."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory to extract files to."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<string>(new[] { "--hash" }, "Extract single file with a given hash. If a path is supplied, all hashes will be extracted."));

            Handler = CommandHandler.Create<string[], string, string, string, string>(ConsoleFunctions.UnbundleTask);
        }

        #endregion Constructors
    }
}
