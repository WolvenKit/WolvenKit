using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        /// <summary>
        /// Builds a project like WolvenKit application. It generates an archive file, and adds extra files (like .xl)
        /// in packed/ directory.
        /// </summary>
        /// <param name="path">Path of the WolvenKit project to build.</param>
        /// <returns>true when the task was executed successfully, false otherwise.</returns>
        public bool Build(DirectoryInfo path)
        {
            if (!path.Exists)
            {
                _loggerService.Error($"Build failed. Could not find directory: \"{path}\".");
                return false;
            }

            // ReSharper disable JoinDeclarationAndInitializer
            Dictionary<string, string> errors = new();
            IEnumerable<string> files;
            DirectoryInfo packedDir;
            DirectoryInfo archiveDir;
            string modName;

            #region Find project

            try
            {
                var projectFile = path.GetFiles("*.cpmodproj", SearchOption.TopDirectoryOnly).Single();
                modName = Path.GetFileNameWithoutExtension(projectFile.Name);
            }
            catch (Exception)
            {
                _loggerService.Error("Build failed. Could not find .cpmodproj file.");
                return false;
            }

            #endregion

            #region Clean

            packedDir = new DirectoryInfo(Path.Combine(path.FullName, "packed"));
            try
            {
                packedDir.Delete(true);
            }
            catch (DirectoryNotFoundException)
            {
                // TOCTOU
            }
            catch (Exception e)
            {
                _loggerService.Error("Build failed. Could not clean previous build:");
                _loggerService.Error(e.Message);
                return false;
            }

            #endregion

            #region Create packed/ directories

            packedDir = new DirectoryInfo(Path.Combine(path.FullName, "packed"));
            archiveDir = new DirectoryInfo(Path.Combine(path.FullName, "packed", "archive", "pc", "mod"));
            try
            {
                packedDir.Create();
                archiveDir.Create();
            }
            catch (IOException e)
            {
                _loggerService.Error("Build failed. Could not create \"packed/\" directories:");
                _loggerService.Error(e.Message);
                return false;
            }

            #endregion

            if (!Pack(path, archiveDir, modName))
            {
                _loggerService.Error("Build failed. Could not create archive file.");
                return false;
            }

            // NOTE: derived from "WolvenKit.App\Controllers\RED4Controller.PackProjectFilesAsync()"

            #region ArchiveXL

            files = GetArchiveXlFiles(path.FullName);
            foreach (var file in files)
            {
                var filename = Path.GetFileName(file);
                try
                {
                    var outputPath = Path.Combine(archiveDir.FullName, filename);
                    File.Copy(file, outputPath);
                }
                catch (Exception e)
                {
                    errors.Add(filename, e.Message);
                }
            }

            if (LogErrors(errors, "ArchiveXL"))
            {
                return false;
            }

            #endregion

            #region Resources

            var resourcesPath = Path.Combine(path.FullName, "source", "resources");
            files = GetResourceFiles(resourcesPath);
            foreach (var file in files)
            {
                var relativeFile = Path.GetRelativePath(resourcesPath, file);
                var relativeDir = Path.Combine(packedDir.FullName, Path.GetDirectoryName(relativeFile).NotNull());
                if (!Directory.Exists(relativeDir))
                {
                    Directory.CreateDirectory(relativeDir);
                }
                
                try
                {
                    var outputPath = Path.Combine(packedDir.FullName, relativeFile);
                    File.Copy(file, outputPath);
                }
                catch (Exception e)
                {
                    errors.Add(relativeFile, e.Message);
                }
            }

            if (LogErrors(errors, "resource"))
            {
                return false;
            }

            #endregion

            return true;
        }

        private bool LogErrors(Dictionary<string, string> errors, string fileType)
        {
            if (errors.Count == 0)
            {
                return false;
            }

            _loggerService.Error($"Build failed. Could not copy {fileType} files:");
            foreach (var error in errors)
            {
                _loggerService.Error($"\t{error.Value}\tin\t{error.Key}");
            }

            return true;
        }

        private static IEnumerable<string> GetArchiveXlFiles(string path) =>
            Directory.EnumerateFiles(path, "*.xl", SearchOption.AllDirectories).ToList();

        private static IEnumerable<string> GetResourceFiles(string path) => Directory
            .EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
            .Where(name => !IsSpecialExtension(name))
            .Where(x => Path.GetFileName(x) != "info.json")
            .ToList();

        private static bool IsSpecialExtension(string filename)
        {
            return Path.GetExtension(filename) switch
            {
                ".xl" or ".script" or ".ws" or ".tweak" => true,
                _ => false,
            };
        }
    }
}