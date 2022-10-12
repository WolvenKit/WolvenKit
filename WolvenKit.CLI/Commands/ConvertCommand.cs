using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands
{
    internal class ConvertCommand : CommandBase
    {
        private const string s_description = "Target a specific CR2W (extracted) and dump file info.";
        private const string s_name = "convert";

        public ConvertCommand() : base(s_name, s_description)
        {
            AddCommand(new DeserializeCommand());
            AddCommand(new SerializeCommand());
        }

        public class DeserializeCommand : CommandBase
        {
            private const string s_description = "Create a CR2W file from json.";
            private const string s_name = "deserialize";

            public DeserializeCommand() : base(s_name, s_description)
            {
                AddAlias("deserialise");
                AddAlias("d");

                AddArgument(new Argument<FileSystemInfo[]>("path", "Input path to a CR2W file or folder."));

                AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path."));

                AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
                AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

                SetHandler(CommandHandler.Create<FileSystemInfo[], DirectoryInfo, bool, bool, string, string, IHost>(Action));
            }

            private async Task Action(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
                string regex, IHost host)
            {
                var serviceProvider = host.Services;
                var logger = serviceProvider.GetRequiredService<ILoggerService>();

                if (path is null || path.Length < 1)
                {
                    logger.Error("Please fill in an input path.");
                    return;
                }

                if (!deserialize && !serialize)
                {
                    logger.Error("Please specify either -s or -d.");
                    return;
                }

                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                await consoleFunctions.Cr2wTask(path, outpath, deserialize, serialize, pattern, regex, ETextConvertFormat.json);
            }
        }

        public class SerializeCommand : CommandBase
        {
            private const string s_description = "Serialize the CR2W file to json.";
            private const string s_name = "serialize";

            public SerializeCommand() : base(s_name, s_description)
            {
                AddAlias("serialise");
                AddAlias("s");

                AddArgument(new Argument<FileSystemInfo[]>("path", "Input path to a CR2W file or folder."));

                AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path."));

                AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
                AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

                SetHandler(CommandHandler.Create<FileSystemInfo[], DirectoryInfo, bool, bool, string, string, IHost>(Action));
            }

            private async Task Action(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
                string regex, IHost host)
            {
                var serviceProvider = host.Services;
                var logger = serviceProvider.GetRequiredService<ILoggerService>();

                if (path is null || path.Length < 1)
                {
                    logger.Error("Please fill in an input path.");
                    return;
                }

                if (!deserialize && !serialize)
                {
                    logger.Error("Please specify either -s or -d.");
                    return;
                }

                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                await consoleFunctions.Cr2wTask(path, outpath, deserialize, serialize, pattern, regex, ETextConvertFormat.json);
            }
        }
    }
}
