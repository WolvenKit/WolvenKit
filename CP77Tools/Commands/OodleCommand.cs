using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class OodleCommand : Command
    {
        private new const string Name = "oodle";
        private new const string Description = "Some helper functions related to Oodle.";

        public OodleCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] {"--path", "-p"}, "Input path."));
            AddOption(new Option<string>(new []{"--outpath", "-o"}, "Output path."));
            AddOption(new Option<bool>(new[] {"--decompress", "-d"}, "Decompress KARK-compressed (Kraken) files."));

            Handler = CommandHandler.Create<string,string, bool>(Tasks.ConsoleFunctions.OodleTask);
        }
    }
}
