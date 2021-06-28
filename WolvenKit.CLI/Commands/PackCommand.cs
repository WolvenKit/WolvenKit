using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            Handler = CommandHandler.Create<string[], string, IHost>(Action);
        }

        private void Action(string[] path, string outpath, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.PackTask(path, outpath);
        }

        #endregion Constructors
    }
}
