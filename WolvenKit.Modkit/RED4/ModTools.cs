using System;
using System.IO;
using Catel.IoC;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;

namespace CP77.CR2W
{
    public partial class ModTools
    {
        private readonly ILoggerService _loggerService;
        private readonly IProgress<double> _progressService;
        private readonly IHashService _hashService;
        private readonly IWolvenkitFileService _wolvenkitFileService;


        public ModTools(
            ILoggerService loggerService,
            IProgress<double> progressService,
            IHashService hashService,
            IWolvenkitFileService wolvenkitFileService
        )
        {
            _loggerService = loggerService;
            _progressService = progressService;
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
        }


        #region Methods

        public CR2WFile TryReadCr2WFile(Stream stream) => _wolvenkitFileService.TryReadCr2WFile(stream) as CR2WFile;

        public CR2WFile TryReadCr2WFile(BinaryReader br) => _wolvenkitFileService.TryReadCr2WFile(br) as CR2WFile;

        public CR2WFile TryReadCr2WFileHeaders(Stream stream) => _wolvenkitFileService.TryReadCr2WFileHeaders(stream) as CR2WFile;

        public CR2WFile TryReadCr2WFileHeaders(BinaryReader br) => _wolvenkitFileService.TryReadCr2WFileHeaders(br) as CR2WFile;

        #endregion Methods
    }
}
