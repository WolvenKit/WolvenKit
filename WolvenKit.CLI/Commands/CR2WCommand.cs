using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;

namespace CP77Tools.Commands
{
    public class CR2WCommand : Command
    {
        #region Fields

        private new const string Description = "Target a specific CR2W (extracted) and dump file info.";
        private new const string Name = "cr2w";

        #endregion Fields

        #region Constructors

        public CR2WCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to a CR2W file or folder."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output path."));
            AddOption(new Option<bool>(new[] { "--deserialize", "-d" }, "Create a CR2W file from json or xml"));
            AddOption(new Option<bool>(new[] { "--serialize", "-s" }, "Serialize the CR2W file to json or xml."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" },
                "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<ETextConvertFormat>(new[] { "--format", "-ft" },
                "Use optional serialization format. Options are json and xml"));

            Handler = CommandHandler
                .Create<string[], string, bool, bool, string, string, ETextConvertFormat, IHost>(Action);
        }

        private async Task Action(string[] path, string outpath, bool deserialize, bool serialize, string pattern,
            string regex, ETextConvertFormat format, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            await consoleFunctions.Cr2wTask(path, outpath, deserialize, serialize, pattern, regex, format);
        }

        #endregion Constructors
    }
}
