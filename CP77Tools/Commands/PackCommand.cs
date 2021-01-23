using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class PackCommand : Command
    {
        private static string Name = "pack";
        private static string Description = "Pack a folder of files into an .archive file.";
        
        public PackCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path. Must be a folder or a list of folders."));
            AddOption(new Option<string>(new[] {"--outpath", "-o"}, "Output directory to create archive.\nIf not specified, will output twill be in place."));
            
            Handler = CommandHandler.Create<string[], string>(Tasks.ConsoleFunctions.PackTask);
        }
    }
}