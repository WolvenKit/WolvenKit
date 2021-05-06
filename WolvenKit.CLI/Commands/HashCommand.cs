using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class HashCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to hashes.";
        private new const string Name = "hash";

        #endregion Fields

        #region Constructors

        public HashCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--input", "-i" }, "Create FNV1A hash of a given string."));
            AddOption(new Option<bool>(new[] { "--missing", "-m" }, "List missing hashes."));
            AddOption(new Option<string>(new[] { "--prepare", "-p" }, "[Debug] Prepares a hash list for packing."));

            Handler = CommandHandler.Create<string[], bool, string>(ConsoleFunctions.HashTask);
        }

        #endregion Constructors
    }
}
