#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.Common.EFileReadErrorCodes;

namespace WolvenKit.App.Helpers;

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

    private static readonly SemaphoreSlim semaphore = new(1, 1);

    private static async Task<Dictionary<string, string>> AddDependenciesToProjectPath(string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths)
    {
        if (resourcePaths.Count == 0)
        {
            return [];
        }
        
        await semaphore.WaitAsync();
        try
        {
            Dictionary<string, string> pathReplacements = new();
            List<string> filesNotFound = [];

            var tcs = new TaskCompletionSource();

            DispatcherHelper.RunOnMainThread(() =>
            {
                try
                {
                    if (resourcePaths.Count == 0 || GetProjectManager()?.ActiveProject is not { } currentProject)
                    {
                        tcs.SetResult();
                        return;
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

                    Dictionary<string, string> pathsAndDestinations = new();

                    foreach (var path in allFilePaths)
                    {
                        var uniqueSubfolderPath = "";

                        if (fileGroups.TryGetValue(path, out var groups) && groups.Count <= 2)
                        {
                            uniqueSubfolderPath = Path.PathSeparator +
                                                  GetUniqueSubfolderPath(allFilePaths, groups.First().GetResolvedText() ?? "");
                        }

                        var targetPath = $"{destFolderRelativePath}{uniqueSubfolderPath}";
                        if (targetPath != path)
                        {
                            pathsAndDestinations[path] = targetPath;
                        }
                    }


                    List<string> existingFiles = pathsAndDestinations.Where(kvp =>
                    {
                        var fileName = Path.GetFileName(kvp.Key);
                        var absolutePath = Path.Combine(archiveRoot, kvp.Value);
                        return File.Exists(Path.Combine(absolutePath, fileName)) && !Directory.Exists(Path.Combine(absolutePath, fileName));
                    }).Select((kvp) => kvp.Key).ToList();

                    var overwriteFiles = existingFiles.Count == 0 || Interactions.ShowConfirmation((
                        $"The following files already exist in the project. Do you want to overwrite them?\n{string.Join('\n', existingFiles)}",
                        "Files Already Exist",
                        WMessageBoxImage.Question,
                        WMessageBoxButtons.YesNo)) is WMessageBoxResult.Yes;

                    List<string> filesToRemove = [];
                    foreach (var kvp in pathsAndDestinations)
                    {
                        try
                        {
                            AddFileToProjectFolder(archiveRoot, kvp.Key, kvp.Value, pathReplacements, overwriteFiles);
                        }
                        catch (FileNotFoundException e)
                        {
                            filesNotFound.Add(e.Message);
                            filesToRemove.Add(kvp.Key);
                        }
                    }

                    foreach (var relPath in filesToRemove)
                    {
                        pathsAndDestinations.Remove(relPath);
                        pathReplacements.Remove(relPath);
                    }
                }
                finally
                {
                    tcs.SetResult();
                }
            });

            await tcs.Task;

            if (GetLoggerService() is not ILoggerService svc || filesNotFound.Count <= 0)
            {
                return pathReplacements;
            }

            svc.Warning("The following files could not be found. You can try switching to the Mod Browser and analyzing your archives:");
            svc.Warning(string.Join('\n', filesNotFound));

            return pathReplacements;
        }
        finally
        {
            semaphore.Release();
        }
    }


    public static void AddToProject(ResourcePath resourcePath)
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

        if (archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
        {
            controller.AddToMod(basegameFile.Value, ArchiveManagerScope.Basegame);
        }
        else if (archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
        {
            controller.AddToMod(modFile.Value, ArchiveManagerScope.Mods);
        }
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

        File.Move(sourceAbsolutePath, targetAbsoluteFile, true);

        // pop it into our map
        pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, Path.GetFileName(sourceRelativePath)));
    }


    public static async Task MoveAndRefactor(Cp77Project activeProject, string sourcePath, string destPath, string absoluteFolderPrefix,
        bool refactor)
    {
        var sourceRelPath = sourcePath;
        var destRelPath = destPath;

        // Make sure that we can deal with both absolute and relative paths
        if (Path.IsPathRooted(sourceRelPath))
        {
            (_, sourceRelPath) = activeProject.SplitFilePath(sourcePath);
        }

        if (Path.IsPathRooted(destRelPath))
        {
            (_, destRelPath) = activeProject.SplitFilePath(destPath);
        }

        // If we're given a directory here, make sure that we have a file path
        var destAbsPath = Path.Join(absoluteFolderPrefix, destRelPath);

        // don't copy a directory on itself
        if (sourceRelPath == destRelPath)
        {
            return;
        }

        var sourceAbsPath = Path.Join(absoluteFolderPrefix, sourceRelPath);
        var sourceIsDirectory = Directory.Exists(sourceAbsPath);
        var overwriteFiles = false;

        if (!sourceIsDirectory)
        {
            if (File.Exists(destAbsPath))
            {
                var response = await Interactions.ShowMessageBoxAsync(
                    $"Do you want to overwrite the existing file {destRelPath}?",
                    "File already exists!");

                if (response is WMessageBoxResult.OK or WMessageBoxResult.Yes)
                {
                    File.Delete(destAbsPath);
                }
            }

            var parentDir = Path.GetDirectoryName(destAbsPath);

            if (!Directory.Exists(parentDir) && parentDir is not null)
            {
                Directory.CreateDirectory(parentDir);
            }

            File.Move(sourceAbsPath, destAbsPath);

            var sourceInRaw = sourceAbsPath.Replace("archive", "raw");
            if (sourceInRaw != sourceAbsPath && File.Exists(sourceInRaw))
            {
                File.Move(sourceInRaw, destAbsPath.Replace("archive", "raw"), true);
            }
            
        }
        else
        {
            /*
             * We're moving a directory
             */
            try
            {
                if (Directory.Exists(destAbsPath) && Directory.EnumerateFiles(destAbsPath).Any())
                {
                    var response = await Interactions.ShowMessageBoxAsync(
                        $"Directory {destRelPath} already exists and is not empty. Do you want to overwrite existing files?",
                        "Directory already exists!");
                    overwriteFiles = response is WMessageBoxResult.OK or WMessageBoxResult.Yes;
                }

                FileHelper.MoveRecursively(sourceAbsPath, destAbsPath, overwriteFiles, GetLoggerService());

                var sourceInRaw = sourceAbsPath.Replace("archive", "raw");
                if (sourceInRaw != sourceAbsPath && Directory.Exists(sourceInRaw))
                {
                    FileHelper.MoveRecursively(sourceInRaw, destAbsPath.Replace("archive", "raw"), overwriteFiles, GetLoggerService());
                }

                GetLoggerService()?.Info($"Moved {sourceRelPath}{Path.DirectorySeparatorChar}* to {destRelPath}");
            }

            catch (Exception e)
            {
                GetLoggerService()?.Info($"Error when trying to move {sourceRelPath}{Path.DirectorySeparatorChar}*: {e.Message}");
            }

        }

        if (!refactor)
        {
            return;
        }

        var oldRelPath = activeProject.GetResourcePathFromRoot(sourceAbsPath);
        var newRelPath = activeProject.GetResourcePathFromRoot(destAbsPath);

        ReplacePathInProject(activeProject, oldRelPath, newRelPath);
    }

    public static void ReplacePathInProject(Cp77Project? activeProject, ResourcePath oldPath, ResourcePath newPath)
    {
        if (oldPath == newPath || activeProject is null)
        {
            return;
        }

        List<string> failedFiles = [];

        var files = Directory.GetFiles(activeProject.ModDirectory, "*.*", SearchOption.AllDirectories);
        Parallel.ForEach(files, file =>
        {
            var hash = activeProject.GetResourcePathFromRoot(file);
            if (hash == newPath)
            {
                return;
            }

            try
            {
                ReplacePathInFile(activeProject, file, oldPath, newPath);
            }
            catch (Exception)
            {
                failedFiles.Add(file.RelativePath(activeProject.ModDirectory));
            }
        });

        if (failedFiles.Count <= 0)
        {
            return;
        }

        GetLoggerService()?.Error($"Failed to auto-update references in the following files:");
        failedFiles.ForEach((path) => GetLoggerService()?.Error($"  {path}"));
    }


    public static void ReplacePathInFile(Cp77Project? activeProject, string filePath, ResourcePath oldPath, ResourcePath newPath)
    {
        if (oldPath == newPath || !File.Exists(filePath) || activeProject is null)
        {
            return;
        }

        var oldPathStr = oldPath.GetResolvedText();
        var newPathStr = newPath.GetResolvedText();

        CR2WFile? cr2W;
        var wasModified = false;
        var isDirectory = newPathStr != null && Directory.Exists(Path.Join(activeProject.ModDirectory, newPathStr));
        if (isDirectory)
        {
            // Can't replace path if either is null
            if (oldPathStr == null || newPathStr == null)
            {
                return;
            }

            oldPathStr += ResourcePath.DirectorySeparatorChar;
            newPathStr += ResourcePath.DirectorySeparatorChar;
        }


        using (var fs = File.Open(filePath, FileMode.Open))
        using (var cr = new CR2WReader(fs))
        {
            if (cr.ReadFile(out cr2W) != (RED4.Archive.IO.EFileReadErrorCodes)EFileReadErrorCodes.NoError)
            {
                return;
            }

            var refs = cr2W!.FindType(typeof(IRedRef));
            foreach (var result in refs)
            {
                if (result.Value is not IRedRef resourceReference || resourceReference.DepotPath == ResourcePath.Empty)
                {
                    continue;
                }

                var oldDepotPathStr = resourceReference.DepotPath.GetResolvedText();

                ResourcePath newDepotPath;
                if (isDirectory)
                {
                    if (oldDepotPathStr == null)
                    {
                        continue;
                    }

                    var isArchiveXL = oldDepotPathStr.StartsWith('*');
                    if (isArchiveXL)
                    {
                        oldDepotPathStr = oldDepotPathStr[1..];
                    }

                    if (!oldDepotPathStr.StartsWith(oldPathStr!))
                    {
                        continue;
                    }

                    var newDepotPathStr = newPathStr! + oldDepotPathStr[oldPathStr!.Length..];
                    if (isArchiveXL)
                    {
                        newDepotPathStr = "*" + newDepotPathStr;
                    }

                    newDepotPath = newDepotPathStr;
                }
                else
                {
                    if (resourceReference.DepotPath != oldPath)
                    {
                        continue;
                    }

                    newDepotPath = newPath;
                }

                var parentPath = string.Join('.', result.Path.Split('.')[..^1]);

                var newValue = (IRedRef)RedTypeManager.CreateRedType(resourceReference.RedType, newDepotPath, resourceReference.Flags);

                if (result.Name.Contains(':'))
                {
                    var parts = result.Name.Split(':');
                    if (parts.Length != 2 || !int.TryParse(parts[1], out var index))
                    {
                        throw new Exception();
                    }

                    var parentArray = cr2W.GetFromXPath(string.Join('.', parentPath, parts[0]));
                    if (!parentArray.Item1 || parentArray.Item2 is not IList arr)
                    {
                        throw new Exception();
                    }

                    GetLoggerService()?.Debug($"Replaced \"{result.Path}\" in \"{filePath}\"");
                    arr[index] = newValue;
                }
                else
                {
                    var parentClass = cr2W.GetFromXPath(parentPath);

                    if (!parentClass.Item1)
                    {
                        throw new Exception();
                    }

                    switch (parentClass.Item2)
                    {
                        case null:
                            throw new Exception();
                        case RedBaseClass cls:
                            cls.SetProperty(result.Name, newValue);
                            break;
                        case CKeyValuePair kvp:
                            kvp.Value = newValue;
                            break;
                        default:
                            throw new NotImplementedException($"Can't replace in property type {parentClass.Item2?.GetType().Name}");
                    }

                    GetLoggerService()?.Debug($"Replaced \"{result.Path}\" in \"{filePath}\"");
                }

                wasModified = true;
            }
        }

        if (!wasModified)
        {
            return;
        }

        using var fs2 = File.Open(filePath, FileMode.Create);
        using var cw = new CR2WWriter(fs2);

        cw.WriteFile(cr2W);
    }

}