using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using Microsoft.Extensions.Options;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        private readonly ILoggerService _loggerService;
        private readonly ModTools _modTools;
        private readonly IHashService _hashService;
        private readonly IProgress<double> _progressService;
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
            IProgress<double> progress,
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
