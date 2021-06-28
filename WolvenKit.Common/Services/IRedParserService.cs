using System.IO;
using WolvenKit.Common.Model;

namespace WolvenKit.Common.Services
{
    public interface IRedParserService
    {
        #region Methods

        public IWolvenkitFile TryReadCr2WFile(Stream stream);

        public IWolvenkitFile TryReadCr2WFile(BinaryReader br);

        public IWolvenkitFile TryReadCr2WFileHeaders(Stream stream);

        public IWolvenkitFile TryReadCr2WFileHeaders(BinaryReader br);

        #endregion Methods
    }
}
