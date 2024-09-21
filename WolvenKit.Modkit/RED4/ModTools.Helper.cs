using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.Modkit.RED4;

public enum FindFileResult
{
    NoError,
    FileNotFound,
    NoCR2W
}

public record FindFileRecord(ICyberGameArchive? Archive, CR2WFile? File, List<IRedImport>? Imports, bool IsEmbedded = false);

public partial class ModTools
{
    private FindFileResult TryFindFile(ResourcePath path, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        var status = InternalTryFindFile(path, out result, excludeCustomArchives);

        var pathStr = path.GetResolvedText();
        if (status == FindFileResult.FileNotFound)
        {
            if (string.IsNullOrEmpty(pathStr))
            {
                _loggerService?.Warning($"The file with the hash \"{(ulong)path}\" could not be found!");
            }
            else
            {
                _loggerService?.Warning($"The file \"{pathStr}\" could not be found!");
            }
        }

        if (status == FindFileResult.NoCR2W)
        {
            if (string.IsNullOrEmpty(pathStr))
            {
                _loggerService?.Error($"The file with the hash \"{(ulong)path}\" could not be parsed!");
            }
            else
            {
                _loggerService?.Error($"The file \"{pathStr}\" could not be parsed!");
            }
        }

        return status;
    }

    private FindFileResult InternalTryFindFile(ulong hash, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        var gameFile = _archiveManager.GetGameFile(hash, true, !excludeCustomArchives);
        if (gameFile == null)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.FileNotFound;
        }

        var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Seek(0, SeekOrigin.Begin);

        using var reader = new CR2WReader(ms);
        reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

        if (reader.ReadFile(out var file) != EFileReadErrorCodes.NoError)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.NoCR2W;
        }

        result = new FindFileRecord((ICyberGameArchive)gameFile.GetArchive(), file, reader.ImportsList);
        return FindFileResult.NoError;
    }

    private bool UncookFile(string path, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false) => UncookFile(FNV1A64HashAlgorithm.HashString(path), matRepo, args, excludeCustomArchives);

    private bool UncookFile(ulong hash, string matRepo, GlobalExportArgs args, bool excludeCustomArchives = false)
    {
        if (InternalTryFindFile(hash, out var result, excludeCustomArchives) != FindFileResult.NoError)
        {
            return false;
        }

        var di = new DirectoryInfo(matRepo);
        if (!di.Exists)
        {
            di.Create();
        }

        return UncookSingle(result!.Archive!, hash, di, args);
    }

    private static readonly string s_modFolder = Path.DirectorySeparatorChar + "mod" + Path.DirectorySeparatorChar;
    private static readonly string s_hotFolder = Path.DirectorySeparatorChar + "hot" + Path.DirectorySeparatorChar;
    
    /// <summary>
    /// Install a packed mod to the game directory.
    /// </summary>
    /// <param name="packedDirectory">The Wolvenkit project's "packed" directory</param>
    /// <param name="gameRootDir">The game's root directory</param>
    /// <param name="installToHot">Will install .archive files to archive/pc/hot rather than archive/pc/mod</param>
    /// <returns></returns>
    public bool InstallFiles(DirectoryInfo packedDirectory, DirectoryInfo gameRootDir, bool installToHot = false)
    {
        var createTweakFile = installToHot && packedDirectory.GetDirectories("tweaks", SearchOption.AllDirectories).Any(); 
        
        foreach (var file in packedDirectory.GetFiles("*", SearchOption.AllDirectories))
        {
            // Get the relative path of the file with respect to the packedDirectory
            var relativePath = file.FullName[(packedDirectory.FullName.Length + 1)..];

            if (file.FullName.EndsWith(".archive") && installToHot)
            {
                relativePath = relativePath.Replace(s_modFolder, s_hotFolder);
            }

            var destinationPath = Path.Combine(gameRootDir.FullName, relativePath);

            try
            {
                // Create the directory if it doesn't exist
                if (Path.GetDirectoryName(destinationPath) is string dirPath && !Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                // Overwrite files
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }

                File.Move(file.FullName, destinationPath);
            }
            catch (Exception _)
            {
                _loggerService.Error($"Failed to copy ${relativePath}:" + _.Message);
                return false;
            }
        }

        if (!createTweakFile)
        {
            return true;
        }

        var tweakFilePath = Path.Combine(gameRootDir.FullName, @"red4ext\plugins\RedHotTools\.hot-tweaks");
        if (!File.Exists(tweakFilePath))
        {
            File.Create(tweakFilePath).Close();
        }
        return true;
    }

}
