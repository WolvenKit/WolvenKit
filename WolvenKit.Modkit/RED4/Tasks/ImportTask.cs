using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public async Task<int> ImportTask(FileSystemInfo[] path, DirectoryInfo outDir, bool keep)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Error("Please fill in an input path.");
                return 1;
            }

            var result = 0;
            foreach (var p in path)
            {
                result += await ImportTaskInner(p, outDir, keep);
            }
            return result;
        }

        private async Task<int> ImportTaskInner(FileSystemInfo path, DirectoryInfo outDirectory, bool keep)
        {
            #region checks

            if (path is null)
            {
                _loggerService.Error("Please fill in an input path.");
                return 1;
            }
            if (!path.Exists)
            {
                _loggerService.Error("Input path does not exist.");
                return 1;
            }
            if (outDirectory is not null && !outDirectory.Exists)
            {
                _loggerService.Error("Please fill in a valid outdirectory path.");
                return 1;
            }

            #endregion checks

            var settings = new GlobalImportArgs().Register(
                _commonImportArgs.Value,
                _xbmImportArgs.Value,
                _gltfImportArgs.Value
            );
            settings.Get<CommonImportArgs>().Keep = keep;
            settings.Get<XbmImportArgs>().Keep = keep;
            settings.Get<GltfImportArgs>().Keep = keep;

            switch (path)
            {
                case FileInfo file:
                    var rawRelative = new RedRelativePath(file.Directory, file.GetRelativePath(file.Directory));
                    // check if the file can be directly imported
                    // if not, rebuild the single file
                    if (!Enum.TryParse(rawRelative.Extension, true, out ERawFileFormat extAsEnum))
                    {
                        // buffers can not be rebuilt on their own
                        if (!settings.Get<CommonImportArgs>().Keep)
                        {
                            return 1;
                        }

                        // outdir needs to be the parent dir of the redfile to rebuild !! (user needs to take care of that)
                        if (_modTools.RebuildBuffer(rawRelative, outDirectory))
                        {
                            _loggerService.Success($"Successfully imported {path} to {outDirectory.FullName}");
                            return 0;
                        }
                        else
                        {
                            _loggerService.Error($"Failed to import {path}");
                            return 1;
                        }
                    }
                    // the raw file can be imported directly
                    else
                    {

                        if (await _modTools.Import(rawRelative, settings, outDirectory))
                        {
                            _loggerService.Success($"Successfully imported {path}");
                            return 0;
                        }
                        else
                        {
                            _loggerService.Error($"Failed to import {path}");
                            return 1;
                        }
                    }
                case DirectoryInfo directory:
                    var result = await _modTools.ImportFolder(directory, settings, outDirectory);
                    return result ? 1 : 0;
                default:
                    _loggerService.Error("Not a valid file or directory name.");
                    return 1;
            }
        }
    }
}
