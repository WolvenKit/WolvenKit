using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

/// <summary>
/// Various enums, mod default filesystem structure, atomic-file compression service manager (Cr2wResourceManager class),
/// FNV1A hash functions, logger service...
/// </summary>
namespace WolvenKit.Common
{
    /// <summary>
    /// Any game file
    /// </summary>
    public interface IWitcherFile
    {
        IWitcherArchive Bundle { get; set; }
        string Name { get; set; }
        /// <summary>
        /// Uncompressed asset size in bytes
        /// </summary>
        long Size { get; set; }
        /// <summary>
        /// Compressed asset asize in bytes
        /// </summary>
        uint ZSize { get; set; }
        long PageOffset { get; set; }
        string CompressionType { get; }

        void Extract(Stream output);
        string Extract(BundleFileExtractArgs e);
    }



}
