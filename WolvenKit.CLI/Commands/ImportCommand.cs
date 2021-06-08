using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class ImportCommand : Command
    {
        #region Fields

        private new const string Description = "Import raw files into redengine files.";
        private new const string Name = "import";

        #endregion Fields

        #region Constructors

        public ImportCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" },
                "Input path. Must be a folder/list of folders or files."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory path"));
            AddOption(new Option<bool>(new[] { "--keep", "-k" },
                "Optionally keep existing CR2W files intact and only append the buffer."));

            Handler = CommandHandler.Create<string[],string, bool, bool, IHost>(Action);
        }

        private void Action(string[] path, string outpath, bool keep, bool clean, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ImportTask(path, outpath, keep);
        }

        #endregion Constructors
    }
}
