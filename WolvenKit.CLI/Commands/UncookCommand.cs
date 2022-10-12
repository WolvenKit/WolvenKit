using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands
{
    public class UncookCommand : Command
    {
        private new const string Description = "Target an archive to uncook files fom.";
        private new const string Name = "uncook";
        public UncookCommand() : base(Name, Description)
        {
            AddAlias("unbundle-and-export");
            AddAlias("extract-and-export");

            AddArgument(new Argument<FileSystemInfo[]>("path", "Input paths to .archive files or folders."));

            // deprecated. keep for backwards compatibility
            AddOption(new Option<FileSystemInfo[]>(new[] { "--path", "-p" }, "[Deprecated] Input paths to .archive files or folders."));

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output directory to extract main files to."));

            AddOption(new Option<string>(new[] { "--raw", "-or" }, "Optional seperate directory to extract raw files to."));
            AddOption(new Option<string>(new[] { "--pattern", "-w" }, "Use optional search pattern (e.g. *.ink), if both regex and pattern is defined, pattern will be prioritized."));
            AddOption(new Option<string>(new[] { "--regex", "-r" }, "Use optional regex pattern."));
            AddOption(new Option<EUncookExtension?>(new[] { "--uext" }, "Format to uncook to (tga, bmp, jpg, png, dds), TGA by default."));
            AddOption(new Option<bool?>(new[] { "--flip", "-f" }, "Flip textures vertically (can help with legibility if there's text)."));
            AddOption(new Option<ulong>(new[] { "--hash" }, "Extract single file with a given hash."));
            AddOption(new Option<bool>(new[] { "--unbundle", "-u" }, "Also unbundle files."));
            AddOption(new Option<ECookedFileFormat[]>(new[] { "--forcebuffers", "-fb" }, "Force uncooking to buffers for given extension. e.g. mesh"));
            AddOption(new Option<bool>(new[] { "--serialize", "-s" }, "Serialize to JSON"));
            AddOption(new Option<MeshExportType?>(new[] { "--mesh-export-type" }, "Mesh export type (Default, WithMaterials, WithRig, Multimesh)."));
            AddOption(new Option<string>(new[] { "--mesh-export-material-repo" }, "Location of the material repo, if not specified, it uses the outpath."));

            Handler = CommandHandler
                .Create<FileSystemInfo[], DirectoryInfo, string, EUncookExtension?, bool?, ulong, string, string, bool, ECookedFileFormat[], bool?, MeshExportType?, string
                    , IHost>(Action);
        }

        private void Action(FileSystemInfo[] path, DirectoryInfo outpath, string raw, EUncookExtension? uext, bool? flip, ulong hash, string pattern,
            string regex, bool unbundle, ECookedFileFormat[] forcebuffers, bool? serialize, MeshExportType? meshExportType, string meshExportMaterialRepo, IHost host)
        {
            var serviceProvider = host.Services;
            var logger = serviceProvider.GetRequiredService<ILoggerService>();

            if (path == null || path.Length < 1)
            {
                logger.Warning("Please fill in an input path.");
                return;
            }

            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.UncookTask(path, new UncookTaskOptions
            {
                outpath = outpath,
                rawOutDir = raw,
                uext = uext,
                flip = flip,
                hash = hash,
                pattern = pattern,
                regex = regex,
                unbundle = unbundle,
                forcebuffers = forcebuffers,
                serialize = serialize,
                meshExportType = meshExportType,
                meshExportMaterialRepo = meshExportMaterialRepo
            });
        }
    }
}
