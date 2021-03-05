using System.IO;

namespace WolvenKit.Common
{
    /// <summary>
    /// Any game file
    /// </summary>
    public interface IGameFile
    {
        #region Properties

        IGameArchive Archive { get; set; }
        string CompressionType { get; }
        string Name { get; set; }

        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        long PageOffset { get; set; }

        /// <summary>
        /// Uncompressed asset size in bytes
        /// </summary>
        uint Size { get; set; }

        /// <summary>
        /// Compressed asset asize in bytes
        /// </summary>
        uint ZSize { get; set; }

        #endregion Properties

        #region Methods

        void Extract(Stream output);

        #endregion Methods
    }
}
