using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class HashCommand : Command
    {
        private new const string Name = "hash";
        private new const string Description = "Some helper functions related to hashes.";

        public HashCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--input", "-i"}, "Create FNV1A hash of given string"));
            AddOption(new Option<bool>(new[] {"--missing", "-m"}, ""));
            
            Handler = CommandHandler.Create<string[], bool>(ConsoleFunctions.HashTask);
        }
    }
}