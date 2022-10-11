using System;
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
    [Obsolete("Use ConvertCommand")]
    public class CR2WCommand : Command
    {
        private new const string Description = "[DEPRECATED] cr2w file conversion command.";
        private new const string Name = "cr2w";

        public CR2WCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("path", "Input path to a CR2W file or folder."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "[Deprecated] Input path to a CR2W file or folder."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory path."));
            AddOption(new Option<bool>(new[] { "--deserialize", "-d" }, "Create a CR2W file from json."));
            AddOption(new Option<bool>(new[] { "--serialize", "-s" }, "Serialize the CR2W file to json."));

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
