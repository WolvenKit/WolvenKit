using System.IO;

namespace WolvenKit.Common
{
    /// <summary>
    /// Any game file
    /// </summary>
    public interface IGameFile
    {
        #region Properties

        public IGameArchive Archive { get; set; }

        ulong Key { get; }

        string Name { get; }

        /// <summary>
        /// Uncompressed asset size in bytes
        /// </summary>
        uint Size { get; set; }

        /// <summary>
        /// Compressed asset asize in bytes
        /// </summary>
        uint ZSize { get; set; }

        public string Extension { get; }


        #endregion Properties

        public void Extract(Stream output);
    }



    public interface Cp77GameFile : IGameFile
    {
        public uint SegmentsStart { get; set; }
        public uint SegmentsEnd { get; set; }

        public string FileName { get; }
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
