using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;


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
