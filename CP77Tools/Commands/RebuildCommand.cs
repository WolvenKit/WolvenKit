using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class RebuildCommand : Command
    {
        #region Fields

        private new const string Description = "Recombine split buffers and textures in a folder.";
        private new const string Name = "rebuild";

        #endregion Fields

        #region Constructors

        public RebuildCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" },
                "Input path. Must be a folder/list of folders."));
            AddOption(new Option<bool>(new[] { "--buffers", "-b" },
                "Recombine buffers."));
            AddOption(new Option<bool>(new[] { "--textures", "-t" },
                "Recombine textures."));
            AddOption(new Option<bool>(new[] { "--import", "-i" },
                "Optionally import missing raw files into their REDEngine formats."));
            AddOption(new Option<bool>(new[] { "--keep" },
                "Optionally keep existing CR2W files intact and only append the buffer."));
            AddOption(new Option<bool>(new[] { "--clean" },
                "Optionally remove buffers and textures after successful recombination."));
            AddOption(new Option<bool>(new[] { "--unsaferaw" },
                "Optionally add raw assets (DDS textures, FBX models) as buffers without check."));

            Handler = CommandHandler.Create<string[], bool, bool, bool, bool, bool, bool>(Tasks.ConsoleFunctions.RebuildTask);
        }

        #endregion Constructors
    }
}
