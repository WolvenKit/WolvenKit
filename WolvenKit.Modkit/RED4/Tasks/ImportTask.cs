using System;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        /// <summary>
        /// Recombine split buffers and textures in a folder.
        /// </summary>
        /// <param name="path">Files or folders to import</param>
        /// <param name="outDir">Outdirectory to create redengine files in</param>
        /// <param name="keep">use existing redengine files in outdirectory</param>
        public void ImportTask(string[] path,
            string outDir,
            bool keep
            )
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, p => ImportTaskInner(p, outDir, keep));
        }

        private void ImportTaskInner(string path,
            string outDir,
            bool keep)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            if (!string.IsNullOrEmpty(outDir) && !Directory.Exists(outDir))
            {
                _loggerService.Warning("Please fill in a valid outdirectory path.");
                return;
            }

            var rawFile = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);

            if (!rawFile.Exists && !inputDirInfo.Exists)
            {
                _loggerService.Warning("Input path does not exist.");
                return;
            }

            var isDirectory = !rawFile.Exists;
            var basedir = rawFile.Exists
                ? new FileInfo(path).Directory
                : inputDirInfo;

            #endregion checks

            // create import settings


            var settings = new GlobalImportArgs().Register(
                _commonImportArgs.Value,
                _xbmImportArgs.Value,
                _gltfImportArgs.Value
            );
            settings.Get<CommonImportArgs>().Keep = keep;
            settings.Get<XbmImportArgs>().Keep = keep;
            settings.Get<GltfImportArgs>().Keep = keep;

            var outDirectory = string.IsNullOrEmpty(outDir) ? null : new DirectoryInfo(outDir);

            // a directory was selected to import
            if (isDirectory)
            {
                _modTools.ImportFolder(basedir, settings, outDirectory);
            }
            // just a single file was selected
            else
            {
                var rawRelative = new RedRelativePath(rawFile.Directory, rawFile.GetRelativePath(rawFile.Directory));
                // check if the file can be directly imported
                // if not, rebuild the single file
                if (!Enum.TryParse(rawRelative.Extension, true, out ERawFileFormat extAsEnum))
                {
                    // buffers can not be rebuilt on their own
                    if (!settings.Get<CommonImportArgs>().Keep)
                    {
                        return;
                    }

                    // outdir needs to be the parent dir of the redfile to rebuild !! (user needs to take care of that)
                    if (_modTools.RebuildBuffer(rawRelative, outDirectory))
                    {
                        _loggerService.Success($"Successfully imported {path} to {outDirectory.FullName}");
                    }
                    else
                    {
                        _loggerService.Error($"Failed to import {path}");
                    }
                }
                // the raw file can be imported directly
                else
                {

                    if (_modTools.Import(rawRelative, settings, outDirectory))
                    {
                        _loggerService.Success($"Successfully imported {path}");
                    }
                    else
                    {
                        _loggerService.Error($"Failed to import {path}");
                    }
                }


            }
        }
    }
}
