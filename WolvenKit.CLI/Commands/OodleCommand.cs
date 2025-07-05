using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands;

internal class OodleCommand : CommandBase
{
    private const string s_description = "Some helper functions related to Oodle.";
    private const string s_name = "oodle";

    public OodleCommand() : base(s_name, s_description)
    {
        AddCommand(new DecompressCommand());
        AddCommand(new CompressCommand());
    }

    internal class DecompressCommand : CommandBase
    {
        private const string s_description = "Decompress with oodle kraken.";
        private const string s_name = "decompress";

        public DecompressCommand() : base(s_name, s_description)
        {
            AddArgument(new Argument<FileInfo>("path", "Input path."));
            AddArgument(new Argument<FileInfo>("outpath", () => null, "Output path."));

            SetInternalHandler(CommandHandler.Create<FileInfo, FileInfo, IHost>(Action));
        }

        private int Action(FileInfo path, FileInfo outpath, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            return consoleFunctions.OodleTask(path, outpath, true, false);
        }
    }

    internal class CompressCommand : CommandBase
    {
        private const string s_description = "Compress with oodle kraken.";
        private const string s_name = "compress";

        public CompressCommand() : base(s_name, s_description)
        {
            AddArgument(new Argument<FileInfo>("path", "Input path."));
            AddArgument(new Argument<FileInfo>("outpath", () => null, "Output path."));

            SetInternalHandler(CommandHandler.Create<FileInfo, FileInfo, IHost>(Action));
        }

        private int Action(FileInfo path, FileInfo outpath, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            return consoleFunctions.OodleTask(path, outpath, false, true);
        }
    }
}
