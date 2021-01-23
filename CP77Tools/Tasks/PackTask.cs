using System.IO;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{

    public static partial class ConsoleFunctions
    {
        /// <summary>
        /// Packs a folder or list of folders to .archive files.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="outpath"></param>
        public static void PackTask(string[] path, string outpath)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                PackTaskInner(file, outpath);
            });

        }

        private static void PackTaskInner(string path, string outpath, int cp = 0)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            var inputDirInfo = new DirectoryInfo(path);
            if (!Directory.Exists(path) || !inputDirInfo.Exists)
            {
                logger.LogString("Input path does not exist", Logtype.Error);
                return;
            }

            var basedir = inputDirInfo;
            if (basedir?.Parent == null) return;

            DirectoryInfo outDir;
            if (string.IsNullOrEmpty(outpath))
            {
                outDir = basedir.Parent;
            }
            else
            {
                outDir = new DirectoryInfo(outpath);
                if (!outDir.Exists) 
                    outDir = Directory.CreateDirectory(outpath);
            }

            #endregion

            var ar = ModTools.Pack(basedir, outDir);
            if (ar != null)
                logger.LogString($"Finished packing {ar.Filepath}.", Logtype.Success);
            else
                logger.LogString($"Packing failed.", Logtype.Error);

            return;
        }
    }
}