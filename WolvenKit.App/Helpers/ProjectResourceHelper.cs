using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class ProjectResourceHelper
{
    private static IProjectManager? s_projectManager;
    private static IProjectManager? GetProjectManager() => s_projectManager ??= Locator.Current.GetService<IProjectManager>();

    private static IArchiveManager? s_archiveManager;
    private static IArchiveManager? GetArchiveManager() => s_archiveManager ??= Locator.Current.GetService<IArchiveManager>();

    private static ILoggerService? s_loggerService;
    private static ILoggerService? GetLoggerService() => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

    private static IWatcherService? s_projectWatcher;

    private static WatcherService? GetProjectWatcher()
    {
        s_projectWatcher ??= Locator.Current.GetService<IWatcherService>();
        return (WatcherService?)s_projectWatcher;
    }

    private static RED4Controller? s_red4Controller;

    private static RED4Controller GetRed4Controller()
    {
        s_red4Controller ??= new RED4Controller(
            GetLoggerService()!,
            Locator.Current.GetService<INotificationService>()!,
            Locator.Current.GetService<IProjectManager>()!,
            Locator.Current.GetService<ISettingsManager>()!,
            Locator.Current.GetService<IHashService>()!,
            Locator.Current.GetService<IModTools>()!,
            Locator.Current.GetService<IAppArchiveManager>()!,
            Locator.Current.GetService<IProgressService<double>>()!,
            Locator.Current.GetService<IPluginService>()!,
            Locator.Current.GetService<IModifierViewStateService>()!,
            Locator.Current.GetService<Red4ParserService>()!
        );
        return s_red4Controller;
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

        GetProjectWatcher()?.UnwatchProject(currentProject);

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

        foreach (var path in allFilePaths)
        {
            try
            {
                if (!fileGroups.TryGetValue(path, out var groups) || groups.Count < 2)
                {
                    AddFileToProjectFolder(archiveRoot, path, destFolderRelativePath, pathReplacements);
                    continue;
                }

                var uniqueSubfolderPath = GetUniqueSubfolderPath(allFilePaths, groups.First().GetResolvedText() ?? "");
                AddFileToProjectFolder(archiveRoot, path, Path.Combine(destFolderRelativePath, uniqueSubfolderPath), pathReplacements);
            }
            catch (FileNotFoundException e)
            {
                filesNotFound.Add(e.Message);
            }
        }

        GetProjectWatcher()?.WatchProject(currentProject);
        if (GetLoggerService() is not ILoggerService svc || filesNotFound.Count <= 0)
        {
            return pathReplacements;
        }

        svc.Warning("The following files could not be found. You can try switching to the Mod Browser and analyzing your archives:");
        svc.Warning(string.Join('\n', filesNotFound));

        return pathReplacements;
    }


    private static void AddFileToProjectFolder(string projectRoot, ResourcePath resourcePath, ResourcePath targetResourcePath,
        Dictionary<string, string> pathReplacements)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath || string.IsNullOrEmpty(sourceRelativePath))
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

        // pop it into our map
        pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, Path.GetFileName(sourceRelativePath)));

        if (!Directory.Exists(targetAbsolutePath))
        {
            Directory.CreateDirectory(targetAbsolutePath);
        }

        if (File.Exists(targetAbsoluteFile))
        {
            File.Delete(targetAbsoluteFile);
        }

        File.Move(sourceAbsolutePath, targetAbsoluteFile, true);
    }
}