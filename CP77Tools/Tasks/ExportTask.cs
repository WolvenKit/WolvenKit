using System;
using System.IO;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using Newtonsoft.Json;
using WolvenKit.Common.Tools.DDS;
using CP77.CR2W;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        public static void ExportTask(string[] path, EUncookExtension uncookext)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ExportTaskInner(file, uncookext);
            });

        }

        private static int ExportTaskInner(string path, EUncookExtension uncookext)
        {

            #region checks

            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path.", Logtype.Error);
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                logger.LogString("Input file does not exist.", Logtype.Error);
                return 0;
            }

            #endregion

            if (ModTools.Export(new FileInfo(path), uncookext) == 1)
            {
                logger.LogString($"Successfully exported {path}.", Logtype.Success);
            }
            else
            {
                logger.LogString($"Failed to export {path}.", Logtype.Error);
            }

            return 1;
        }
    }
}