using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using Microsoft.Extensions.Options;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace CP77Tools.Tasks
{
    public interface IConsoleFunctions
    {
        public void ArchiveTask(string[] path, string pattern, string regex, bool diff, bool list);
        public void UnbundleTask(string[] path, string outpath, string hash, string pattern, string regex,
            bool DEBUG_decompress = false);
        public void Cr2wTask(string[] path, string outpath, bool deserialize, bool serialize, string pattern,
            string regex, ESerializeFormat format);
        public void ExportTask(string[] path, string outDir, EUncookExtension? uncookext, bool? flip,
            ECookedFileFormat[] forcebuffers);
        public void ImportTask(string[] path, string outDir, bool keep);
        public int OodleTask(string path, string outpath, bool decompress, bool compress);
        public void PackTask(string[] path, string outpath);
        public void UncookTask(string[] path, string outpath, string rawOutDir,
            EUncookExtension? uext, bool? flip, ulong hash, string pattern, string regex, bool unbundle,
            ECookedFileFormat[] forcebuffers);
    }

    public partial class ConsoleFunctions : IConsoleFunctions
    {
        private readonly ILoggerService _loggerService;
        private readonly ModTools _modTools;
        private readonly IHashService _hashService;
        private readonly IProgressService<double> _progressService;
        private readonly Red4ParserService _wolvenkitFileService;

        private readonly IOptions<CommonImportArgs> _commonImportArgs;
        private readonly IOptions<XbmImportArgs> _xbmImportArgs;
        private readonly IOptions<MeshImportArgs> _meshImportArgs;
        private readonly IOptions<XbmExportArgs> _xbmExportArgs;
        private readonly IOptions<MeshExportArgs> _meshExportArgs;
        private readonly IOptions<MorphTargetExportArgs> _morphTargetExportArgs;
        private readonly IOptions<MlmaskExportArgs> _mlmaskExportArgs;
        private readonly IOptions<WemExportArgs> _wemExportArgs;


        public ConsoleFunctions(
            ILoggerService loggerService,
            IHashService hashService,
            IProgressService<double> progress,
            Red4ParserService wolvenkitFileService,
            ModTools modTools,

            IOptions<CommonImportArgs> commonImportArgs,
            IOptions<XbmImportArgs> xbmImportArgs,
            IOptions<MeshImportArgs> meshImportArgs,
            IOptions<XbmExportArgs> xbmExportArgs,
            IOptions<MeshExportArgs> meshExportArgs,
            IOptions<MorphTargetExportArgs> morphTargetExportArgs,
            IOptions<MlmaskExportArgs> mlmaskExportArgs,
            IOptions<WemExportArgs> wemExportArgs
        )
        {
            _loggerService = loggerService;
            _modTools = modTools;
            _progressService = progress;
            _hashService = hashService;

            _commonImportArgs = commonImportArgs;
            _xbmImportArgs = xbmImportArgs;
            _meshImportArgs = meshImportArgs;
            _wolvenkitFileService = wolvenkitFileService;
            _xbmExportArgs = xbmExportArgs;
            _meshExportArgs = meshExportArgs;
            _morphTargetExportArgs = morphTargetExportArgs;
            _mlmaskExportArgs = mlmaskExportArgs;
            _wemExportArgs = wemExportArgs;
        }


    }
}
