using WolvenKit.Core.Interfaces;

namespace WolvenKit.Common
{
    public interface Tw3GameFile : IGameFile
    {
        string CompressionType { get; }

        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        long PageOffset { get; set; }
    }
}
