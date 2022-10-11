using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class OodleCommand : Command
    {
        private new const string Description = "Some helper functions related to Oodle.";
        private new const string Name = "oodle";

        public OodleCommand() : base(Name, Description)
        {
            AddCommand(new DecompressCommand());
            AddCommand(new CompressCommand());
        }

        public class DecompressCommand : Command
        {
            private new const string Description = "Decompress with oodle kraken.";
            private new const string Name = "decompress";

            public DecompressCommand() : base(Name, Description)
            {
                AddArgument(new Argument<FileInfo>("path", "Input path."));
                AddArgument(new Argument<FileInfo>("outpath", () => null, "Output path."));

                Handler = CommandHandler.Create<FileInfo, FileInfo, IHost>(Action);
            }

            private void Action(FileInfo path, FileInfo outpath, IHost host)
            {
                var serviceProvider = host.Services;
                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                consoleFunctions.OodleTask(path, outpath, true, false);
            }
        }

        public class CompressCommand : Command
        {
            private new const string Description = "Compress with oodle kraken.";
            private new const string Name = "compress";

            public CompressCommand() : base(Name, Description)
            {
                AddArgument(new Argument<FileInfo>("path", "Input path."));
                AddArgument(new Argument<FileInfo>("outpath", () => null, "Output path."));

                Handler = CommandHandler.Create<FileInfo, FileInfo, IHost>(Action);
            }

            private void Action(FileInfo path, FileInfo outpath, IHost host)
            {
                var serviceProvider = host.Services;
                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                consoleFunctions.OodleTask(path, outpath, false, true);
            }
        }
    }



}
