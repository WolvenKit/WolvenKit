using System.IO;

namespace WolvenKit.Common
{
    /// <summary>
    /// Any game file
    /// </summary>
    public interface IGameFile
    {
        #region Properties

        string ArchiveName { get; set; }
        string Name { get; }

        /// <summary>
        /// Uncompressed asset size in bytes
        /// </summary>
        uint Size { get; set; }

        /// <summary>
        /// Compressed asset asize in bytes
        /// </summary>
        uint ZSize { get; set; }

        #endregion Properties

    }



    public interface Cp77GameFile : IGameFile
    {

    }

    public interface Tw3GameFile : IGameFile
    {
        string CompressionType { get; }

        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        long PageOffset { get; set; }
    }
}
