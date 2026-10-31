using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Core
{
    /// <summary>
    /// Helper utilities for discovering and resolving Cyberpunk 2077 paths across different distribution platforms
    /// (Steam, GOG, Epic Games, and Xbox PC / Microsoft Store GDK).
    /// </summary>
    public static class Red4PathHelper
    {
        private static readonly string[] s_relativeExecutableCandidates =
        [
            Path.Combine("bin", "x64", Constants.Red4Exe),
            Constants.Red4XboxExe,
            Constants.Red4GameLaunchHelper,
            Constants.Red4Exe
        ];

        /// <summary>
        /// Checks whether the provided filename or path corresponds to a known Cyberpunk 2077 executable.
        /// Supports standard "Cyberpunk2077.exe" as well as Xbox PC "cpLauncher.exe" and "gamelaunchhelper.exe".
        /// </summary>
        /// <param name="fileNameOrPath">File name or full file path to test.</param>
        /// <returns>True if the file matches a known Red4 executable name.</returns>
        public static bool IsRed4Executable(string? fileNameOrPath)
        {
            if (string.IsNullOrWhiteSpace(fileNameOrPath))
            {
                return false;
            }

            var fileName = Path.GetFileName(fileNameOrPath);
            return Constants.Red4Exes.Any(x => x.Equals(fileName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Enumerates potential installation locations for Cyberpunk 2077 on Xbox PC (Microsoft Store / GDK)
        /// across all ready fixed and removable drives.
        /// </summary>
        /// <returns>Sequence of existing candidate directory paths.</returns>
        public static IEnumerable<string> GetDefaultXboxGameLocations()
        {
            DriveInfo[] drives;
            try
            {
                drives = DriveInfo.GetDrives();
            }
            catch
            {
                yield break;
            }

            foreach (var drive in drives)
            {
                if (!drive.IsReady)
                {
                    continue;
                }

                if (drive.DriveType != DriveType.Fixed && drive.DriveType != DriveType.Removable)
                {
                    continue;
                }

                var contentPath = Path.Combine(drive.RootDirectory.FullName, "XboxGames", "Cyberpunk 2077", "Content");
                if (Directory.Exists(contentPath))
                {
                    yield return contentPath;
                }
            }
        }

        /// <summary>
        /// Resolves the root directory of the Cyberpunk 2077 game installation (the directory that contains the "archive" folder).
        /// </summary>
        /// <param name="executable">FileInfo representing the executable file.</param>
        /// <returns>The resolved full path to the game root directory, or null if it cannot be determined.</returns>
        public static string? ResolveGameRootDir(FileInfo? executable)
        {
            if (executable is null)
            {
                return null;
            }

            return ResolveGameRootDir(executable.FullName);
        }

        /// <summary>
        /// Resolves the root directory of the Cyberpunk 2077 game installation (the directory that contains the "archive" folder).
        /// Handles both standard layout (&lt;root&gt;/bin/x64/Cyberpunk2077.exe) and Xbox PC layout (&lt;root&gt;/Content/cpLauncher.exe).
        /// Also supports passing the base installation directory (e.g., C:\XboxGames\Cyberpunk 2077) directly.
        /// </summary>
        /// <param name="executableOrDirPath">Path to the game executable or installation folder.</param>
        /// <returns>The resolved full path to the game root directory, or null if it cannot be determined.</returns>
        public static string? ResolveGameRootDir(string? executableOrDirPath)
        {
            if (string.IsNullOrWhiteSpace(executableOrDirPath))
            {
                return null;
            }

            DirectoryInfo? dirInfo;
            var isOfflineOrMissing = false;

            if (File.Exists(executableOrDirPath))
            {
                dirInfo = new FileInfo(executableOrDirPath).Directory;
            }
            else if (Directory.Exists(executableOrDirPath))
            {
                dirInfo = new DirectoryInfo(executableOrDirPath);
            }
            else
            {
                // Path does not exist on disk (e.g. unmounted drive or moved directory).
                // Parse string path structure without requiring disk existence to preserve caller stability.
                isOfflineOrMissing = true;
                try
                {
                    var isExe = executableOrDirPath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase);
                    dirInfo = isExe ? new FileInfo(executableOrDirPath).Directory : new DirectoryInfo(executableOrDirPath);
                }
                catch
                {
                    return null;
                }
            }

            if (dirInfo is null)
            {
                return null;
            }

            if (isOfflineOrMissing)
            {
                if (dirInfo.Name.Equals("x64", StringComparison.OrdinalIgnoreCase) &&
                    dirInfo.Parent?.Name.Equals("bin", StringComparison.OrdinalIgnoreCase) == true &&
                    dirInfo.Parent.Parent is not null)
                {
                    return dirInfo.Parent.Parent.FullName;
                }

                return dirInfo.FullName;
            }

            // Case 1: Directory directly contains archive/pc/content (e.g. Xbox PC "Content" folder, or standard root directly)
            if (Directory.Exists(Path.Combine(dirInfo.FullName, "archive", "pc", "content")))
            {
                return dirInfo.FullName;
            }

            // Case 2: Xbox PC root folder selected (e.g. "C:\XboxGames\Cyberpunk 2077"), which has a "Content" subfolder
            var contentSubdir = Path.Combine(dirInfo.FullName, "Content");
            if (Directory.Exists(Path.Combine(contentSubdir, "archive", "pc", "content")))
            {
                return contentSubdir;
            }

            // Case 3: Standard Steam/GOG/Epic layout where executable is in <root>/bin/x64
            if (dirInfo.Parent?.Parent is not null && Directory.Exists(Path.Combine(dirInfo.Parent.Parent.FullName, "archive", "pc", "content")))
            {
                return dirInfo.Parent.Parent.FullName;
            }

            // Case 4: Selected directory is <root>/bin (one level up)
            if (dirInfo.Parent is not null && Directory.Exists(Path.Combine(dirInfo.Parent.FullName, "archive", "pc", "content")))
            {
                return dirInfo.Parent.FullName;
            }

            // Fallback: If located in bin/x64, navigate up two levels
            if (dirInfo.Name.Equals("x64", StringComparison.OrdinalIgnoreCase) &&
                dirInfo.Parent?.Name.Equals("bin", StringComparison.OrdinalIgnoreCase) == true &&
                dirInfo.Parent.Parent is not null)
            {
                return dirInfo.Parent.Parent.FullName;
            }

            return dirInfo.FullName;
        }

        /// <summary>
        /// Resolves the full path to the Oodle decompression library (oo2ext_7_win64.dll).
        /// Checks both standard &lt;root&gt;/bin/x64/ and direct &lt;root&gt;/ (used by Xbox PC GDK).
        /// </summary>
        /// <param name="gameRootDir">The resolved game root directory.</param>
        /// <param name="executablePath">Optional path to the game executable.</param>
        /// <returns>The path to the Oodle DLL if found, or the expected standard path as fallback.</returns>
        public static string? ResolveOodleDll(string? gameRootDir, string? executablePath = null)
        {
            if (!string.IsNullOrEmpty(gameRootDir) && Directory.Exists(gameRootDir))
            {
                // Standard Steam/GOG/Epic location
                var standardPath = Path.Combine(gameRootDir, "bin", "x64", Constants.Oodle);
                if (File.Exists(standardPath))
                {
                    return standardPath;
                }

                // Xbox PC location (directly in Content)
                var directPath = Path.Combine(gameRootDir, Constants.Oodle);
                if (File.Exists(directPath))
                {
                    return directPath;
                }
            }

            // Next to the executable if specified
            if (!string.IsNullOrEmpty(executablePath) && File.Exists(executablePath))
            {
                var exeDir = Path.GetDirectoryName(executablePath);
                if (!string.IsNullOrEmpty(exeDir))
                {
                    var nextToExe = Path.Combine(exeDir, Constants.Oodle);
                    if (File.Exists(nextToExe))
                    {
                        return nextToExe;
                    }
                }
            }

            // Default fallback to standard path
            return !string.IsNullOrEmpty(gameRootDir)
                ? Path.Combine(gameRootDir, "bin", "x64", Constants.Oodle)
                : null;
        }

        /// <summary>
        /// Resolves an executable file to launch or reference given a game directory or executable path.
        /// </summary>
        /// <param name="gameRootDirOrExe">Path to the game directory or executable.</param>
        /// <returns>FileInfo representing the primary game executable, or null if not found.</returns>
        public static FileInfo? ResolveExecutable(string? gameRootDirOrExe)
        {
            if (string.IsNullOrWhiteSpace(gameRootDirOrExe))
            {
                return null;
            }

            if (File.Exists(gameRootDirOrExe))
            {
                return new FileInfo(gameRootDirOrExe);
            }

            if (!Directory.Exists(gameRootDirOrExe))
            {
                return null;
            }

            var candidateDirs = new[]
            {
                gameRootDirOrExe,
                ResolveGameRootDir(gameRootDirOrExe),
                Path.Combine(gameRootDirOrExe, "Content")
            }.OfType<string>().Where(Directory.Exists).Distinct();

            foreach (var dir in candidateDirs)
            {
                foreach (var rel in s_relativeExecutableCandidates)
                {
                    var candidate = Path.Combine(dir, rel);
                    if (File.Exists(candidate))
                    {
                        return new FileInfo(candidate);
                    }
                }
            }

            return null;
        }
    }
}
