using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class WwiseCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to Wwise.";
        private new const string Name = "wwise";

        #endregion Fields

        #region Constructors

        public WwiseCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] { "--path", "-p" }, "Input path."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output path."));
            AddOption(new Option<bool>(new[] { "--wem", "-w" }, "Convert WEM to OGG."));

            Handler = CommandHandler.Create<string, string, bool, IHost>(Action);
        }

        private void Action(string path, string outpath, bool wem, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.WwiseTask(path, outpath, wem);
        }

        #endregion Constructors
    }
}
