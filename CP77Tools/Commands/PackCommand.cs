using System.CommandLine;
using System.CommandLine.Invocation;

namespace CP77Tools.Commands
{
    public class PackCommand : Command
    {
        #region Fields

        private new const string Description = "Pack the contents of a folder into an .archive file.";
        private new const string Name = "pack";

        #endregion Fields

        #region Constructors

        public PackCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path. Must be a folder/list of folders."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory to create archive.\nIf not specified, will output in the same directory."));

            Handler = CommandHandler.Create<string[], string>(Tasks.ConsoleFunctions.PackTask);
        }

        #endregion Constructors
    }
}
