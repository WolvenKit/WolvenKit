#nullable enable

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.Helpers;

public static class ProjectResourceHelper
{
    private static IProjectManager? s_projectManager;
    private static IProjectManager? GetProjectManager() => s_projectManager ??= Locator.Current.GetService<IProjectManager>();

    private static IArchiveManager? s_archiveManager;
    private static IArchiveManager? GetArchiveManager() => s_archiveManager ??= Locator.Current.GetService<IArchiveManager>();

    private static ILoggerService? s_loggerService;
    private static ILoggerService? GetLoggerService() => s_loggerService ??= Locator.Current.GetService<ILoggerService>();
    private static RED4Controller GetRed4Controller()
    {
        if (GameControllerFactory.GetInstance() is GameControllerFactory factory)
        {
            return factory.GetRed4Controller();
        }

        return GameControllerFactory.CreateInstance(
            GetProjectManager()!,
            Locator.Current.GetService<RED4Controller>()!,
            Locator.Current.GetService<MockGameController>()!
        ).GetRed4Controller();
    }

    private static string GetUniqueSubfolderPath(IEnumerable<string> allFilePaths, string currentFilePath)
    {
        var fileName = Path.GetFileName(currentFilePath);
        var conflictingPaths = allFilePaths.Where(path => Path.GetFileName(path) == fileName).ToList();

        // Start from the end of the path and move towards the beginning until a unique segment is found
        var segments = Path.GetDirectoryName(currentFilePath)?.Split(Path.DirectorySeparatorChar) ?? [];
        for (var i = segments.Length - 1; i >= 0; i--)
        {
            var potentialUniquePath = string.Join(Path.DirectorySeparatorChar.ToString(), segments.Skip(i));
            if (conflictingPaths.All(path => path.EndsWith(potentialUniquePath)))
            {
                return potentialUniquePath;
            }
        }

        // Fallback, should not happen
        return Path.GetDirectoryName(currentFilePath) ?? "";
    }


    public static Task<Dictionary<string, string>> AddDependenciesToProjectPathAsync(string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths) =>
        Task.Run(() => AddDependenciesToProjectPath(destFolderRelativePath, resourcePaths));

    public static Dictionary<string, string> AddDependenciesToProjectPath(string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths)
    {
        Dictionary<string, string> pathReplacements = new();

        if (resourcePaths.Count == 0 || GetProjectManager()?.ActiveProject is not { } currentProject)
        {
            return pathReplacements;
        }

        var archiveRoot = currentProject.ModDirectory;
        var absoluteTargetFolder = Path.Combine(archiveRoot, destFolderRelativePath);

        if (!Directory.Exists(absoluteTargetFolder))
        {
            Directory.CreateDirectory(absoluteTargetFolder);
        }

        // Group files by their names to identify collisions
        var fileGroups = resourcePaths.GroupBy(r => Path.GetFileName(r.GetResolvedText() ?? "INVALID")).ToDictionary(
            group => group.Key,
            group => group.ToList()
        );
        var allFilePaths = resourcePaths.Select(r => r.GetResolvedText() ?? "").ToArray();

        List<string> filesNotFound = [];

        Dictionary<string, string> pathsAndDestinations = new(); 

        foreach (var path in allFilePaths)
        {
            var uniqueSubfolderPath = "";

            if (fileGroups.TryGetValue(path, out var groups) && groups.Count <= 2)
            {
                uniqueSubfolderPath = Path.PathSeparator + GetUniqueSubfolderPath(allFilePaths, groups.First().GetResolvedText() ?? "");
            }

            pathsAndDestinations[path] = $"{destFolderRelativePath}{uniqueSubfolderPath}";
        }

        //AddFileToProjectFolder(archiveRoot, path, Path.Combine(destFolderRelativePath, uniqueSubfolderPath), pathReplacements);

        List<string> existingFiles = pathsAndDestinations.Where(kvp =>
        {
            var fileName = Path.GetFileName(kvp.Key);
            var absolutePath = Path.Combine(archiveRoot, kvp.Value);
            return File.Exists(Path.Combine(absolutePath, fileName));
        }).Select((kvp) => kvp.Value).ToList();

        var overwriteFiles = existingFiles.Count == 0 || Interactions.ShowConfirmation((
            "The following files already exist in the project. Do you want to overwrite them?",
            "Files Already Exist",
            WMessageBoxImage.Question,
            WMessageBoxButtons.YesNo)) is WMessageBoxResult.Yes;


        foreach (var kvp in pathsAndDestinations)
        {
            try
            {
                AddFileToProjectFolder(archiveRoot, kvp.Key, kvp.Value, pathReplacements, overwriteFiles);
            }
            catch (FileNotFoundException e)
            {
                filesNotFound.Add(e.Message);
            }
        }
      
        if (GetLoggerService() is not ILoggerService svc || filesNotFound.Count <= 0)
        {
            return pathReplacements;
        }

        svc.Warning("The following files could not be found. You can try switching to the Mod Browser and analyzing your archives:");
        svc.Warning(string.Join('\n', filesNotFound));

        return pathReplacements;
    }


    private static void AddFileToProjectFolder(string projectRoot, ResourcePath resourcePath, ResourcePath targetResourcePath,
        Dictionary<string, string> pathReplacements, bool overwriteFiles)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath
            || string.IsNullOrEmpty(sourceRelativePath))
        {
            return;
        }
        
        var refPathHash = HashHelper.CalculateDepotPathHash(resourcePath);

        // we can't add it
        if (refPathHash is 0 || GetArchiveManager() is not IArchiveManager archiveManager ||
            GetRed4Controller() is not RED4Controller controller)
        {
            return;
        }

        // we don't know where to put it
        if (targetResourcePath.GetResolvedText() is not string targetRelativePath || string.IsNullOrEmpty(targetRelativePath))
        {
            return;
        }

        // We already have this file
        if (GetProjectManager()?.ActiveProject?.Files.Contains(resourcePath!) == true)
        {
            return;
        }

        if (archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
        {
            controller.AddToMod(modFile.Value, ArchiveManagerScope.Mods);
        }
        else if (archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
        {
            controller.AddToMod(basegameFile.Value, ArchiveManagerScope.Basegame);
        }
        else
        {
            throw new FileNotFoundException(targetRelativePath);
        }

        var targetAbsolutePath = Path.Combine(projectRoot, targetRelativePath);
        var sourceAbsolutePath = Path.Combine(projectRoot, sourceRelativePath);
        var targetAbsoluteFile = Path.Combine(targetAbsolutePath, Path.GetFileName(sourceRelativePath));

        if (File.Exists(targetAbsoluteFile))
        {
            if (!overwriteFiles)
            {
                return;
            }

            File.Delete(targetAbsoluteFile);
        }

        
        if (!Directory.Exists(targetAbsolutePath))
        {
            Directory.CreateDirectory(targetAbsolutePath);
        }

        // pop it into our map
        pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, Path.GetFileName(sourceRelativePath)));

        File.Move(sourceAbsolutePath, targetAbsoluteFile, true);
    }
}