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
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path. Can be a path to one .archive, or the content directory.\nIf this is a directory, all archives in it will be processed."));
            AddOption(new Option<string>(new[] {"--outpath", "-o"}, "Output directory to extract files to.\nIf not specified, will output to a new child directory, in place."));
            
            Handler = CommandHandler.Create<string[], string>(Tasks.ConsoleFunctions.PackTask);
        }
    }
}