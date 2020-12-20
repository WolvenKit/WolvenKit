using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.DDS;

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

            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!inputFileInfo.Exists && !inputDirInfo.Exists)
            {
                logger.LogString("Input path does not exist", Logtype.Error);
                return;
            }

            if (inputFileInfo.Exists == true && inputFileInfo.Extension != ".archive")
            {
                logger.LogString("Input file is not an .archive", Logtype.Error);
                return;
            }

            var basedir = inputFileInfo.Exists ? new FileInfo(path).Directory : inputDirInfo;
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

            Archive.WriteFromFolder(basedir, outDir);

            return;
        }
    }
}