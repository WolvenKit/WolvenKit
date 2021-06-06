#define IS_ASYNC
#undef IS_ASYNC

using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CP77Tools.Commands
{
    public class UnbundleCommand : Command
    {
        #region Fields

        private new const string Description = "Target an archive to extract files from.";
        private new const string Name = "unbundle";

        #endregion Fields

        #region Constructors

        public UnbundleCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to .archive."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory to extract files to."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<string>(new[] { "--hash" }, "Extract single file with a given hash. If a path is supplied, all hashes will be extracted."));
            AddOption(new Option<bool>(new[] { "--DEBUG_decompress" }, "Decompresses all buffers in the unbundled files."));

            Handler = CommandHandler.Create<string[], string, string, string, string, bool, IHost>(Action);
        }

        private void Action(string[] path, string outpath, string pattern, string regex, string hash, bool DEBUG_decompress, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();

#if IS_ASYNC
            Task.WhenAll(consoleFunctions.UnbundleTaskAsync(path, outpath, hash, pattern, regex, DEBUG_decompress)).Wait();
#else
            consoleFunctions.UnbundleTask(path, outpath, hash, pattern, regex, DEBUG_decompress);
#endif
        }

        #endregion Constructors
    }
}
