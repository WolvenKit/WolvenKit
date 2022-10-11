using System.IO;
using System.Threading.Tasks;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        /// <summary>
        /// Packs a folder or list of folders to .archive files.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="outpath"></param>
        public void PackTask(string[] path, DirectoryInfo outpath)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file => PackTaskInner(file, outpath));
        }

        private void PackTaskInner(string path, DirectoryInfo outpath, int cp = 0)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            var inputDirInfo = new DirectoryInfo(path);
            if (!Directory.Exists(path) || !inputDirInfo.Exists)
            {
                _loggerService.Warning("Input path does not exist.");
                return;
            }

            var basedir = inputDirInfo;
            if (basedir?.Parent == null)
            {
                return;
            }

            DirectoryInfo outDir;
            if (outpath is null)
            {
                outDir = basedir.Parent;
            }
            else
            {
                outDir = outpath;
                if (!outDir.Exists)
                {
                    outDir = Directory.CreateDirectory(outpath.FullName);
                }
            }

            #endregion checks

            var ar = _modTools.Pack(basedir, outDir);
            if (ar != null)
            {
                _loggerService.Success($"Finished packing {ar.ArchiveAbsolutePath}.");
            }
            else
            {
                _loggerService.Error($"Packing failed.");
            }

            return;
        }

        #endregion Methods
    }
}
