using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class RebuildCommand : Command
    {
        private static string Name = "rebuild";
        private static string Description = "Recombine split buffers and textures in a folder.";
        
        public RebuildCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, 
                "Input path. Must be a folder or a list of folders."));
            AddOption(new Option<bool>(new[] {"--buffers", "-b"}, 
                "Recombine buffers"));
            AddOption(new Option<bool>(new[] {"--textures", "-t"}, 
                "Recombine textures"));
            AddOption(new Option<bool>(new[] {"--import", "-i"}, 
                "Optionally import missing raw files into their redengine formats."));
            AddOption(new Option<bool>(new[] {"--keep"}, 
                "Optionally keep existing cr2w files intact and only append the buffer"));
            AddOption(new Option<bool>(new[] {"--clean"}, 
                "Optionally remove buffers and textures after successful recombination."));
            AddOption(new Option<bool>(new[] {"--unsaferaw"}, 
                "Optionally add raw assets (dds textures, fbx) as buffers without check."));

            Handler = CommandHandler.Create<string[], bool, bool, bool, bool, bool, bool>(Tasks.ConsoleFunctions.RebuildTask);
        }
    }
}