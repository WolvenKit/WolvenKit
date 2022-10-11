using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;

namespace CP77Tools.Tasks
{
    public interface IConsoleFunctions
    {
        public void ArchiveTask(string[] path, string pattern, string regex, bool diff, bool list);
        public void UnbundleTask(string[] path, DirectoryInfo outpath, string hash, string pattern, string regex,
            bool DEBUG_decompress = false);
        public Task Cr2wTask(string[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
            string regex, ETextConvertFormat format);
        public void ExportTask(string[] path, DirectoryInfo outDir, EUncookExtension? uncookext, bool? flip,
            ECookedFileFormat[] forcebuffers);
        public Task ImportTask(string[] path, DirectoryInfo outDir, bool keep);
        public int OodleTask(FileInfo path, FileInfo outpath, bool decompress, bool compress);
        public void PackTask(string[] path, DirectoryInfo outpath);
        public void UncookTask(string[] path, UncookTaskOptions options);
    }

    public partial class ConsoleFunctions : IConsoleFunctions
    {
        private readonly ILoggerService _loggerService;
        private readonly IModTools _modTools;
        private readonly IHashService _hashService;
        private readonly IProgressService<double> _progressService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly IArchiveManager _archiveManager;

        private readonly IOptions<CommonImportArgs> _commonImportArgs;
        private readonly IOptions<XbmImportArgs> _xbmImportArgs;
        private readonly IOptions<GltfImportArgs> _gltfImportArgs;
        private readonly IOptions<XbmExportArgs> _xbmExportArgs;
        private readonly IOptions<MeshExportArgs> _meshExportArgs;
        private readonly IOptions<MorphTargetExportArgs> _morphTargetExportArgs;
        private readonly IOptions<MlmaskExportArgs> _mlmaskExportArgs;
        private readonly IOptions<WemExportArgs> _wemExportArgs;
        private readonly IOptions<AnimationExportArgs> _animationExportArgs;


        public ConsoleFunctions(
            ILoggerService loggerService,
            IHashService hashService,
            IProgressService<double> progress,
            Red4ParserService wolvenkitFileService,
            IModTools modTools,
            IArchiveManager archiveManager,

            IOptions<CommonImportArgs> commonImportArgs,
            IOptions<XbmImportArgs> xbmImportArgs,
            IOptions<GltfImportArgs> gltfImportArgs,
            IOptions<XbmExportArgs> xbmExportArgs,
            IOptions<MeshExportArgs> meshExportArgs,
            IOptions<MorphTargetExportArgs> morphTargetExportArgs,
            IOptions<MlmaskExportArgs> mlmaskExportArgs,
            IOptions<WemExportArgs> wemExportArgs,
            IOptions<AnimationExportArgs> animationExportArgs
        )
        {
            _loggerService = loggerService;
            _modTools = modTools;
            _progressService = progress;
            _hashService = hashService;
            _archiveManager = archiveManager;

            _commonImportArgs = commonImportArgs;
            _xbmImportArgs = xbmImportArgs;
            _gltfImportArgs = gltfImportArgs;
            _wolvenkitFileService = wolvenkitFileService;
            _xbmExportArgs = xbmExportArgs;
            _meshExportArgs = meshExportArgs;
            _morphTargetExportArgs = morphTargetExportArgs;
            _mlmaskExportArgs = mlmaskExportArgs;
            _wemExportArgs = wemExportArgs;
            _animationExportArgs = animationExportArgs;
        }


    }
}
