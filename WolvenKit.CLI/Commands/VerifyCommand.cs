using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class VerifyCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to CR2W files.";
        private new const string Name = "verify";

        #endregion Fields

        #region Constructors

        public VerifyCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "inpaths"));
            AddOption(new Option<ulong[]>(new[] { "--hashes", "-i" }, "inhashes"));

            Handler = CommandHandler.Create<string[], ulong[]>(ConsoleFunctions.VerifyTask);
        }

        #endregion Constructors
    }
}
