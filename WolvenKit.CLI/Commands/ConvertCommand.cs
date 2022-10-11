using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;

namespace CP77Tools.Commands
{
    public class ConvertCommand : Command
    {
        private new const string Description = "Target a specific CR2W (extracted) and dump file info.";
        private new const string Name = "convert";

        public ConvertCommand() : base(Name, Description)
        {
            AddCommand(new DeserializeCommand());
            AddCommand(new SerializeCommand());
        }

        public class DeserializeCommand : Command
        {
            private new const string Description = "Create a CR2W file from json.";
            private new const string Name = "deserialize";

            public DeserializeCommand() : base(Name, Description)
            {
                AddAlias("deserialise");
                AddAlias("d");

                AddArgument(new Argument<string[]>("path", "Input path to a CR2W file or folder."));

                AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path."));

                AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
                AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

                Handler = CommandHandler
                    .Create<string[], DirectoryInfo, bool, bool, string, string, IHost>(Action);
            }

            private async Task Action(string[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
                string regex, IHost host)
            {
                var serviceProvider = host.Services;
                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                await consoleFunctions.Cr2wTask(path, outpath, deserialize, serialize, pattern, regex, ETextConvertFormat.json);
            }
        }

        public class SerializeCommand : Command
        {
            private new const string Description = "Serialize the CR2W file to json.";
            private new const string Name = "serialize";

            public SerializeCommand() : base(Name, Description)
            {
                AddAlias("serialise");
                AddAlias("s");

                AddArgument(new Argument<string[]>("path", "Input path to a CR2W file or folder."));

                AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path."));

                AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
                AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

                Handler = CommandHandler
                    .Create<string[], DirectoryInfo, bool, bool, string, string, IHost>(Action);
            }

            private async Task Action(string[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
                string regex, IHost host)
            {
                var serviceProvider = host.Services;
                var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
                await consoleFunctions.Cr2wTask(path, outpath, deserialize, serialize, pattern, regex, ETextConvertFormat.json);
            }
        }
    }
}
