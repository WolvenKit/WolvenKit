using System;
using CP77.CR2W;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.MeshFile;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        private readonly ILoggerService _loggerService;
        private readonly IProgress<double> _progressService;
        private readonly IHashService _hashService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly MeshTools _meshTools;
        private readonly TargetTools _targetTools;
        private readonly MESHIMPORTER _meshimporter;
        //private readonly MaterialTools _materialTools;


        public ModTools(
            ILoggerService loggerService,
            IProgress<double> progressService,
            IHashService hashService,
            Red4ParserService wolvenkitFileService,
            MeshTools meshTools,
            TargetTools targetTools,
            MESHIMPORTER meshimporter
        //MaterialTools materialTools
        )
        {
            _loggerService = loggerService;
            _progressService = progressService;
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _meshTools = meshTools;
            _targetTools = targetTools;
            _meshimporter = meshimporter;
            //_materialTools = materialTools;
        }
    }
}
