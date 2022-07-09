using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;

namespace CP77Tools.Commands
{
    public class UncookCommand : Command
    {
        #region Fields

        private new const string Description = "Target an archive to uncook files fom.";
        private new const string Name = "uncook";

        #endregion Fields

        #region Constructors

        public UncookCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "Input path to .archive."));
            AddOption(new Option<string>(new[] { "--outpath", "-o" }, "Output directpry to extract main files to."));
            AddOption(new Option<string>(new[] { "--raw", "-or" }, "Optional seperate directory to extract raw files to."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<EUncookExtension?>(new[] { "--uext" }, "Format to uncook to (tga, bmp, jpg, png, dds), TGA by default."));
            AddOption(new Option<bool?>(new[] { "--flip", "-f" }, "Flip textures vertically (can help with legibility if there's text)."));
            AddOption(new Option<ulong>(new[] { "--hash" }, "Extract single file with a given hash."));
            AddOption(new Option<bool>(new[] { "--unbundle", "-u" }, "Also unbundle files."));
            AddOption(new Option<ECookedFileFormat[]>(new[] { "--forcebuffers", "-fb" }, "Force uncooking to buffers for given extension. e.g. mesh"));
            AddOption(new Option<bool>(new[] { "--serialize", "-s" }, "Serialize to JSON"));

            Handler = CommandHandler
                .Create<string[], string, string, EUncookExtension?, bool?, ulong, string, string, bool, ECookedFileFormat[], bool?
                    , IHost>(Action);
        }

        private void Action(string[] path, string outpath, string raw, EUncookExtension? uext, bool? flip, ulong hash, string pattern,
            string regex, bool unbundle, ECookedFileFormat[] forcebuffers, bool? serialize, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.UncookTask(path, outpath, raw, uext, flip, hash, pattern, regex, unbundle, forcebuffers, serialize);
        }


        #endregion Constructors
    }
}
