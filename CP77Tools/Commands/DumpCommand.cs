using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class DumpCommand : Command
    {
        #region Fields

        private new const string Description = "Target an archive or a directory to dump archive information.";
        private new const string Name = "dump";

        #endregion Fields

        #region Constructors

        public DumpCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to an .archive or directory (runs over all archives in directory)."));
            AddOption(new Option<bool>(new[] { "--imports", "-i" }, "Dump all imports (all filenames referenced by files in the archive)."));
            AddOption(new Option<bool>(new[] { "--missinghashes", "-m" }, "List missing hashes for all input archives."));
            AddOption(new Option<bool>(new[] { "--texinfo" }, "Dump all XBM info."));
            AddOption(new Option<bool>(new[] { "--classinfo" }, "Dump all class info."));
            AddOption(new Option<bool>(new[] { "--dump", "-d" }, "Dump archive information."));
            AddOption(new Option<bool>(new[] { "--list", "-l" }, "List archive contents."));

            Handler = CommandHandler.Create<string[], bool, bool, bool, bool, bool, bool>(ConsoleFunctions.DumpTask);
        }

        #endregion Constructors
    }
}
