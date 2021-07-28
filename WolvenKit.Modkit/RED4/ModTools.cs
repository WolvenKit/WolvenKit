using System;
using CP77.CR2W;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        private readonly ILoggerService _loggerService;
        private readonly IProgressService<double> _progressService;
        private readonly IHashService _hashService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly MeshTools _meshTools;
        //private readonly MaterialTools _materialTools;


        public ModTools(
            ILoggerService loggerService,
            IProgressService<double> progressService,
            IHashService hashService,
            Red4ParserService wolvenkitFileService,
            MeshTools meshTools
        //MaterialTools materialTools
        )
        {
            _loggerService = loggerService;
            _progressService = progressService;
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _meshTools = meshTools;
            //_materialTools = materialTools;
        }
    }
}
