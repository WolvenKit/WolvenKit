using System;
using System.IO;
using System.Linq;
using WolvenKit.Modkit.RED4.Project;

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

            string modName;
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

            var project = new Cp77Project(path.FullName, modName, modName);

            if (!project.CleanPackedDirectory(_loggerService))
            {
                _loggerService.Error("Build failed. Could not clean previous build.");
                return false;
            }

            if (!project.PackProject(this, _loggerService, isRedmod: false))
            {
                _loggerService.Error("Build failed. Could not pack project.");
                return false;
            }

            return true;
        }
    }
}
