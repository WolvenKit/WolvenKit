using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class OodleCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to Oodle.";
        private new const string Name = "oodle";

        #endregion Fields

        #region Constructors

        public OodleCommand() : base(Name, Description)
        {
            AddOption(new Option<string>(new[] { "--path", "-p" }, "Input path."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output path."));
            AddOption(new Option<bool>(new[] { "--decompress", "-d" }, "Decompress with oodle kraken."));
            AddOption(new Option<bool>(new[] { "--compress", "-c" }, "Compress with oodle kraken."));

            Handler = CommandHandler.Create<string, string, bool, bool, IHost>(Action);
        }

        private void Action(string path, string outpath, bool decompress, bool compress, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.OodleTask(path, outpath, decompress, compress);
        }

        #endregion Constructors
    }
}
