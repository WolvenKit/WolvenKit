using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class TweakCommand : Command
    {
        #region Fields

        private new const string Description = "Convert .tweak files into TweakDB .bin files.";
        private new const string Name = "tweak";

        #endregion Fields

        #region Constructors

        public TweakCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] { "--path", "-p" },
                "Input directory for .tweak files. Defaults to current directory"));
            AddOption(new Option<string>(new[] { "--outpath", "-o" },
                "Optional output directory path. Defaults to current directory"));
            AddOption(new Option<bool>(new[] { "--keep", "-k" },
                "Optionally keep existing files if an output directory is specified"));

            Handler = CommandHandler.Create<string, string, bool, IHost>(Action);
        }

        private void Action(string path, string outpath, bool keep, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.TweakTask(path, outpath, keep);
        }

        #endregion Constructors
    }
}
