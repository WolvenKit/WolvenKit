using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DynamicData.Kernel;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public static class SaveGameHelper
{
    public static string GetSaveDirectory() =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "Saved Games", "CD Projekt Red", "Cyberpunk 2077");

    public static List<SaveGame> GetSaveGames()
    {
        var saveDir = GetSaveDirectory();
        if (!Directory.Exists(saveDir))
        {
            return [];
        }

        return Directory.GetDirectories(saveDir)
            .Select(folder => new { Folder = folder, Save = Path.Combine(folder, "sav.dat") })
            .Where(x => File.Exists(x.Save))
            .Select(x => new SaveGame(
                new DirectoryInfo(x.Folder).Name,
                Path.Combine(x.Folder, "screenshot.png"),
                x.Save,
                new DirectoryInfo(x.Folder).LastWriteTime))
            .OrderByDescending(x => x.LastModified)
            .AsList();
    }

    public static string? GetLastSaveName()
    {
        var saveDir = GetSaveDirectory();
        if (!Directory.Exists(saveDir))
        {
            return null;
        }

        var saveDirectoryNames = Directory.GetDirectories(saveDir)
            .Select(folder => new { Folder = folder, Save = Path.Combine(folder, "sav.dat") })
            .Where(x => File.Exists(x.Save))
            .Select(x => new { DirName = new DirectoryInfo(x.Folder).Name, LastModified = new DirectoryInfo(x.Folder).LastWriteTime })
            .OrderByDescending(x => x.LastModified)
            .Select(x => x.DirName);

        return saveDirectoryNames.FirstOrDefault();
    }
}
