using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace CP77.CR2W
{
    public static partial class ModTools
    {
        private static readonly ILoggerService Logger = ServiceLocator.Default.ResolveType<ILoggerService>();


        public static CR2WFile TryReadCr2WFile(Stream stream) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFile(stream) as CR2WFile;

        public static CR2WFile TryReadCr2WFile(BinaryReader br) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFile(br) as CR2WFile;

        public static CR2WFile TryReadCr2WFileHeaders(Stream stream) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFileHeaders(stream) as CR2WFile;

        public static CR2WFile TryReadCr2WFileHeaders(BinaryReader br) => ServiceLocator.Default.ResolveType<IWolvenkitFileService>().TryReadCr2WFileHeaders(br) as CR2WFile;


    }
}

