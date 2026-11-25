using System;
using System.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

/// <summary>
/// The Asset Browser hash of an open file, the same way the Project Explorer finds it: the path relative to the
/// project's archive folder, or the hash itself for files named after it.
/// </summary>
public static class AssetBrowserLookup
{
    /// <param name="filePath">
    /// The document's path: absolute for project files, or a game path (relative) for files opened from the game.
    /// </param>
    /// <param name="modDirectory">The project's archive folder, or null without a project.</param>
    public static bool TryGetHash(string? filePath, string? modDirectory, out ulong hash)
    {
        hash = 0;
        if (string.IsNullOrWhiteSpace(filePath))
        {
            return false;
        }

        string gamePath;
        if (Path.IsPathRooted(filePath))
        {
            if (string.IsNullOrEmpty(modDirectory))
            {
                return false;
            }

            gamePath = Path.GetRelativePath(modDirectory, filePath);
            // not inside the archive folder (raw folder, another project, ...)
            if (gamePath.StartsWith("..", StringComparison.Ordinal) || Path.IsPathRooted(gamePath))
            {
                return false;
            }
        }
        else
        {
            gamePath = filePath;
        }

        // files without a known path are saved as "<hash>.<extension>" at the top of the archive folder
        if (string.IsNullOrEmpty(Path.GetDirectoryName(gamePath))
            && ulong.TryParse(Path.GetFileNameWithoutExtension(gamePath), out hash))
        {
            return true;
        }

        hash = ResourcePath.CalculateHash(gamePath);
        return hash != 0;
    }
}
