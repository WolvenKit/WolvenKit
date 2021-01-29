using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class VerifyCommand : Command
    {
        private static string Name = "verify";
        private static string Description = "Some helper functions related to cr2w files.";

        public VerifyCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "inpaths"));
            AddOption(new Option<ulong[]>(new[] {"--hashes", "-i"}, "inhashes"));
            
            Handler = CommandHandler.Create<string[], ulong[]> (ConsoleFunctions.VerifyTask);
        }
    }
}