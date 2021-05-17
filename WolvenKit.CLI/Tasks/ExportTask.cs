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
                _loggerService.Warning("Please fill in an input path.");
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
                _loggerService.Warning("Please fill in an input path.");
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                _loggerService.Warning("Input file does not exist.");
                return 0;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

            if (_modTools.Export(new FileInfo(path), uncookext, flip))

            {
                watch.Stop();
                _loggerService.Success($"Successfully exported {path} in {watch.ElapsedMilliseconds.ToString()}ms.");
            }
            else
            {
                watch.Stop();
                _loggerService.Error($"Failed to export {path}.");
            }

            return 1;
        }

        #endregion Methods
    }
}
