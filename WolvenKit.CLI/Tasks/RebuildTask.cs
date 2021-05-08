using System.IO;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        /// <summary>
        /// Recombine split buffers and textures in a folder.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="outpath"></param>
        public void RebuildTask(string[] path,
            bool buffers,
            bool textures,
            bool import,
            bool keep,
            bool clean,
            bool unsaferaw
            )
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, p =>
            {
                RebuildTaskInner(p, buffers, textures, import, keep, clean, unsaferaw);
            });
        }

        private void RebuildTaskInner(string path,
            bool buffers,
            bool textures,
            bool import,
            bool keep,
            bool clean,
            bool unsaferaw
        )
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            var inputDirInfo = new DirectoryInfo(path);
            if (!Directory.Exists(path) || !inputDirInfo.Exists)
            {
                _loggerService.LogString("Input path does not exist.", Logtype.Error);
                return;
            }

            var basedir = inputDirInfo;
            if (basedir?.Parent == null)
            {
                return;
            }

            #endregion checks

            _modTools.Recombine(basedir, buffers, textures, import, keep, clean, unsaferaw);

            return;
        }

        #endregion Methods
    }
}
