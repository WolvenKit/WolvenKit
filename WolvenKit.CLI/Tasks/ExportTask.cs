using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void ExportTask(string[] path, EUncookExtension uncookext, bool flip)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ExportTaskInner(file, uncookext, flip);
            });
        }

        private int ExportTaskInner(string path, EUncookExtension uncookext, bool flip)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                _loggerService.LogString("Input file does not exist.", Logtype.Error);
                return 0;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

            if (_modTools.Export(new FileInfo(path), uncookext, flip))

            {
                watch.Stop();
                _loggerService.LogString($"Successfully exported {path} in {watch.ElapsedMilliseconds.ToString()}ms.", Logtype.Success);
            }
            else
            {
                watch.Stop();
                _loggerService.LogString($"Failed to export {path}.", Logtype.Error);
            }

            return 1;
        }

        #endregion Methods
    }
}
