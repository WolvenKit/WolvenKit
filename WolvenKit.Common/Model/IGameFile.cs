using System.IO;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Any game file
    /// </summary>
    public interface IGameFile
    {
        IGameArchive Bundle { get; set; }
        string Name { get; set; }
        /// <summary>
        /// Uncompressed asset size in bytes
        /// </summary>
        uint Size { get; set; }
        /// <summary>
        /// Compressed asset asize in bytes
        /// </summary>
        uint ZSize { get; set; }
        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        long PageOffset { get; set; }
        string CompressionType { get; }

        void Extract(Stream output);
        string Extract(BundleFileExtractArgs e);
    }



}
