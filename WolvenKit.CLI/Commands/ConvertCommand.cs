using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal class ConvertCommand : CommandBase
{
    private const string s_description = "Convert CR2W (extracted) resource files and convert to json.";
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

            AddArgument(new Argument<FileSystemInfo[]>("path", "Input path to CR2W files or folders."));

            // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory path."));

            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

            SetInternalHandler(CommandHandler.Create<FileSystemInfo[], string, string, string, IHost>(Action));
        }

        private Task<int> Action(FileSystemInfo[] path, string outpath, string pattern,
            string regex, IHost host)
        {
            var serviceProvider = host.Services;
            var logger = serviceProvider.GetRequiredService<ILoggerService>();

            if (path is null || path.Length < 1)
            {
                logger.Error("Please fill in an input path.");
                return Task.FromResult(ConsoleFunctions.ERROR_BAD_ARGUMENTS);
            }

            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            return consoleFunctions.Cr2wTask(path, string.IsNullOrEmpty(outpath) ? null : new DirectoryInfo(outpath), true, false, pattern, regex, ETextConvertFormat.json);
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

            // TODO revert to DirectoryInfo once System.Commandline is updated https://github.com/dotnet/command-line-api/issues/1872
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directory path."));

            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized"));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Regex search pattern."));

            SetInternalHandler(CommandHandler.Create<FileSystemInfo[], string, string, string, IHost>(Action));
        }

        private Task<int> Action(FileSystemInfo[] path, string outpath, string pattern,
            string regex, IHost host)
        {
            var serviceProvider = host.Services;
            var logger = serviceProvider.GetRequiredService<ILoggerService>();

            if (path is null || path.Length < 1)
            {
                logger.Error("Please fill in an input path.");
                return Task.FromResult(ConsoleFunctions.ERROR_BAD_ARGUMENTS);
            }

            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            return consoleFunctions.Cr2wTask(path, string.IsNullOrEmpty(outpath) ? null : new DirectoryInfo(outpath), false, true, pattern, regex, ETextConvertFormat.json);
        }
    }
}
