using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        #region Methods

        /// <summary>
        /// Exports (Uncooks) a physical REDengine file into it's raw file
        /// </summary>
        /// <param name="cr2wfile"></param>
        /// <param name="args"></param>
        /// <param name="basedir"></param>
        /// <param name="rawoutdir"></param>
        public bool Export(FileInfo cr2wfile, GlobalExportArgs args, DirectoryInfo basedir = null,
            DirectoryInfo rawoutdir = null)
        {
            #region checks

            if (cr2wfile == null)
            {
                return false;
            }

            if (!cr2wfile.Exists)
            {
                return false;
            }

            if (cr2wfile.Directory is {Exists: false})
            {
                return false;
            }

            // if no basedir is supplied use the file directory
            if (basedir is not {Exists: true})
            {
                basedir = cr2wfile.Directory;
            }
            if (rawoutdir is not { Exists: true })
            {
                rawoutdir = cr2wfile.Directory;
            }

            if (!cr2wfile.FullName.Contains(basedir.FullName))
            {
                return false;
            }

            #endregion checks

            var ext = Path.GetExtension(cr2wfile.FullName).TrimStart('.');

            // read file
            using var fs = new FileStream(cr2wfile.FullName, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);

            var relpath = cr2wfile.FullName.RelativePath(basedir);
            return UncookBuffers(fs, relpath, args, rawoutdir);
        }

        #endregion Methods
    }
}
