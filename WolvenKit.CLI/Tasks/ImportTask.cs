using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

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

            Parallel.ForEach(path, p =>
            {
                ImportTaskInner(p, outDir, keep);
            });
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

            // create import settings //TODO: get them from somewhere in the CLI
            var settings = new GlobalImportArgs().Register(
                new XbmImportArgs() { Keep = keep },
                new MeshImportArgs() { Keep = keep },
                new CommonImportArgs() { Keep = keep }
            );

            var outDirectory = string.IsNullOrEmpty(outDir) ? null : new DirectoryInfo(outDir);


            // a directory was selected to import
            if (isDirectory)
            {
                // process buffers
                _modTools.RebuildFolder(basedir, outDirectory);

                // process all other files
                _modTools.ImportFolder(basedir, outDirectory);
            }
            // just a single file was selected
            else
            {
                // check if the file can be directly imported
                var ext = Path.GetExtension(rawFile.FullName).TrimStart('.');
                // if not, rebuild the single file
                if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
                {
                    // buffers can not be rebuilt on their own
                    if (!settings.Get<CommonImportArgs>().Keep)
                    {
                        return;
                    }

                    if (_modTools.RebuildBuffer(rawFile, outDirectory))
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
                    if (_modTools.Import(rawFile, settings, outDirectory))
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

        #endregion Methods
    }
}
