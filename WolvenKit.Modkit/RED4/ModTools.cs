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
        private readonly ILoggerService Logger;
        private readonly IProgress<double> _progressService;

        public ModTools(
            ILoggerService loggerService,
            IProgress<double> progressService
        )
        {
            Logger = loggerService;
            _progressService = progressService;
        }


        #region Methods

        public static CR2WFile TryReadCr2WFile(Stream stream) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFile(stream) as CR2WFile;

        public static CR2WFile TryReadCr2WFile(BinaryReader br) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFile(br) as CR2WFile;

        public static CR2WFile TryReadCr2WFileHeaders(Stream stream) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFileHeaders(stream) as CR2WFile;

        public static CR2WFile TryReadCr2WFileHeaders(BinaryReader br) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFileHeaders(br) as CR2WFile;

        #endregion Methods
    }
}
