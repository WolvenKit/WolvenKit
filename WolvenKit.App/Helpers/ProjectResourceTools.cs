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
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.Common.EFileReadErrorCodes;

namespace WolvenKit.App.Helpers;

public class ProjectResourceTools
{
    private readonly IProjectManager _projectManager;

    private readonly IArchiveManager _archiveManager;

    private readonly ILoggerService _loggerService;

    private readonly ISettingsManager _settingsService;

    public ProjectResourceTools(IProjectManager projectManager, IArchiveManager archiveManager,
        ILoggerService loggerService, ISettingsManager settingsManager)
    {
        _projectManager = projectManager;
        _archiveManager = archiveManager;
        _loggerService = loggerService;
        _settingsService = settingsManager;
    }


    private RED4Controller GetRed4Controller()
    {
        if (GameControllerFactory.GetInstance() is GameControllerFactory factory)
        {
            return factory.GetRed4Controller();
        }

        return GameControllerFactory.CreateInstance(
            _projectManager,
            Locator.Current.GetService<RED4Controller>()!,
            Locator.Current.GetService<MockGameController>()!
        ).GetRed4Controller();
    }

    public string GetAbsolutePath(string fileName, string rootRelativeFolder = "",
        bool appendModderNameFromSettings = false)
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return "";
        }

        if (appendModderNameFromSettings)
        {
            rootRelativeFolder = AppendPersonalDirectory(rootRelativeFolder);
        }
        
        return activeProject.GetAbsolutePath(fileName, rootRelativeFolder);

    }

    public string AppendPersonalDirectory(params string[] filePathParts)
    {
        var filePath = Path.Join(filePathParts);
        if (_settingsService.ModderName is string modderName && modderName != "" && !filePath.Contains(modderName)) 
        {
            filePath = Path.Join(filePath, modderName.ToFileName());
        }

        return filePath.Trim();
    }

    private string GetUniqueSubfolderPath(IEnumerable<string> allFilePaths, string currentFilePath)
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

    public Task<Dictionary<string, string>> AddDependenciesToProjectPathAsync(string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths) =>
        Task.Run(() => AddDependenciesToProjectPath(destFolderRelativePath, resourcePaths));

    private readonly SemaphoreSlim _semaphore = new(1, 1);

    public FileInfo GetFileInfo(string path)
    {
        if (!Path.IsPathRooted(path) && _projectManager.ActiveProject is Cp77Project project)
        {
            path = Path.Join(project.ModDirectory, path);
        }

        if (!File.Exists(path))
        {
            throw new InvalidDataException($"failed to read ${path}");
        }

        return new FileInfo(path);
    }

    private async Task<Dictionary<string, string>> AddDependenciesToProjectPath(string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths)
    {
        if (resourcePaths.Count == 0)
        {
            return [];
        }

        await _semaphore.WaitAsync();
        try
        {
            Dictionary<string, string> pathReplacements = new();
            List<string> filesNotFound = [];

            var tcs = new TaskCompletionSource();

            DispatcherHelper.RunOnMainThread(() =>
            {
                try
                {
                    if (resourcePaths.Count == 0 || _projectManager.ActiveProject is not Cp77Project currentProject)
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


                    var existingFiles = pathsAndDestinations.Where(kvp =>
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

            if (filesNotFound.Count <= 0)
            {
                return pathReplacements;
            }

            _loggerService.Warning(
                "The following files could not be found. You can try switching to the Mod Browser and analyzing your archives:");
            _loggerService.Warning(string.Join('\n', filesNotFound));

            return pathReplacements;
        }
        finally
        {
            _semaphore.Release();
        }
    }


    public void AddToProject(ResourcePath resourcePath)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath
            || string.IsNullOrEmpty(sourceRelativePath))
        {
            return;
        }

        var refPathHash = HashHelper.CalculateDepotPathHash(resourcePath);
        // we can't add it
        if (refPathHash is 0 || GetRed4Controller() is not RED4Controller controller)
        {
            return;
        }

        if (_archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
        {
            controller.AddToMod(basegameFile.Value, ArchiveManagerScope.Basegame);
        }
        else if (_archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
        {
            controller.AddToMod(modFile.Value, ArchiveManagerScope.Mods);
        }
    }

    /// <summary>
    /// Adds a file to the project, then moves it to the target path
    /// </summary>
    /// <param name="projectRoot">the mod directory (e.g. activeProject.ModDirectory) </param>
    /// <param name="resourcePath">Path of original resource</param>
    /// <param name="targetResourcePath">Path of target resource (the original resource will be moved here)</param>
    /// <exception cref="FileNotFoundException"></exception>
    public void AddFileToProjectFolder(string projectRoot, ResourcePath resourcePath,
        ResourcePath targetResourcePath) =>
        AddFileToProjectFolder(projectRoot, resourcePath, targetResourcePath, [], true);

    private void AddFileToProjectFolder(string projectRoot, ResourcePath resourcePath, ResourcePath targetResourcePath,
        Dictionary<string, string> pathReplacements, bool overwriteFiles)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath
            || string.IsNullOrEmpty(sourceRelativePath))
        {
            return;
        }
        
        var refPathHash = HashHelper.CalculateDepotPathHash(resourcePath);

        // we can't add it
        if (refPathHash is 0 || GetRed4Controller() is not RED4Controller controller)
        {
            return;
        }

        // we don't know where to put it
        if (targetResourcePath.GetResolvedText() is not string targetRelativePath || string.IsNullOrEmpty(targetRelativePath))
        {
            return;
        }

        // We already have this file
        if (_projectManager.ActiveProject?.Files.Contains(resourcePath!) == true)
        {
            return;
        }

        if (_archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
        {
            controller.AddToMod(modFile.Value, ArchiveManagerScope.Mods);
        }
        else if (_archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
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


    public async Task MoveAndRefactor(Cp77Project activeProject, string sourcePath, string destPath,
        string absoluteFolderPrefix,
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

                if (response is not (WMessageBoxResult.OK or WMessageBoxResult.Yes))
                {
                    return;
                }
            }

            var parentDir = Path.GetDirectoryName(destAbsPath);

            if (parentDir is not null && !Directory.Exists(parentDir))
            {
                Directory.CreateDirectory(parentDir);
            }

            // moving a file from filename.ext to Filename.ext will delete the file, so move it to .tmp first 
            File.Move(sourceAbsPath, $"{destAbsPath}.tmp", true);
            File.Move($"{destAbsPath}.tmp", destAbsPath, true);

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

                FileHelper.MoveRecursively(sourceAbsPath, destAbsPath, overwriteFiles, _loggerService);

                var sourceInRaw = sourceAbsPath.Replace("archive", "raw");
                if (sourceInRaw != sourceAbsPath && Directory.Exists(sourceInRaw))
                {
                    FileHelper.MoveRecursively(sourceInRaw, destAbsPath.Replace("archive", "raw"), overwriteFiles,
                        _loggerService);
                }

                _loggerService.Info($"Moved {sourceRelPath}{Path.DirectorySeparatorChar}* to {destRelPath}");
            }

            catch (Exception e)
            {
                _loggerService.Info(
                    $"Error when trying to move {sourceRelPath}{Path.DirectorySeparatorChar}*: {e.Message}");
            }

        }

        if (!refactor)
        {
            return;
        }

     
        var newRelPath = activeProject.GetResourcePathFromRoot(destAbsPath);

        ReplacePathInProject(activeProject, sourceAbsPath, newRelPath);
    }

    /// <summary>
    /// File extensions in resources that we want to update  
    /// </summary>
    private static readonly List<string> s_resourceFileExtensions = [".lua", ".xl", ".json", ".yaml", ".yml", ".reds"];

    /// <summary>
    /// Extensions of files that we don't need to update 
    /// </summary>
    private static readonly List<string> s_fileExtensionsWithoutPaths = [".xbm", ".mlmask"];

    /// <summary>
    /// File extensions from source/archive that require updating of resource files  
    /// </summary>
    private static readonly List<string> s_replaceInResourceFileExtensions =
        [".ent", ".app", ".csv", ".json", ".anims", ".workspot"];

    public void ReplacePathInProject(Cp77Project? activeProject, string oldAbsolutePath, ResourcePath newPath)
    {
        if (activeProject is null || oldAbsolutePath.Contains(activeProject.RawDirectory))
        {
            return;
        }

        var oldPath = activeProject.GetResourcePathFromRoot(oldAbsolutePath);
        if (string.Equals(oldPath, newPath, StringComparison.Ordinal))
        {
            return;
        }

        List<string> failedFiles = [];

        ReplaceInCr2WFiles();


        ReplaceInResourceFiles();


        if (failedFiles.Count <= 0)
        {
            return;
        }

        _loggerService.Error($"Failed to auto-update references in the following files:");
        failedFiles.ForEach((path) => _loggerService.Error($"  {path}"));

        return;

        void ReplaceInResourceFiles()
        {
            // if it's not a cr2W file from archive, the resource files won't care
            if (!oldAbsolutePath.Contains(activeProject.ModDirectory))
            {
                return;
            }

            var fileExtension = Path.GetExtension(oldAbsolutePath);

            // Check if we're moving either a folder, or moving a file extension we care about
            var replaceInResourceFiles = string.IsNullOrEmpty(fileExtension) ||
                                         s_replaceInResourceFileExtensions.Contains(fileExtension);

            if (!replaceInResourceFiles ||
                oldPath.GetResolvedText() is not string oldPathStr || string.IsNullOrEmpty(oldPathStr) ||
                newPath.GetResolvedText() is not string newPathStr || string.IsNullOrEmpty(newPathStr))
            {
                return;
            }

            var oldPathWithForwardSlashes = oldPathStr.Replace("\\", "/");
            var newPathWithForwardSlashes = newPathStr.Replace("\\", "/");

            var resourceFiles =
                Directory.GetFiles(activeProject.ResourcesDirectory, "*.*", SearchOption.AllDirectories);

            Parallel.ForEach(resourceFiles, absoluteFilePath =>
            {
                if (!string.IsNullOrEmpty(fileExtension) && !s_resourceFileExtensions.Contains(fileExtension))
                {
                    return;
                }

                try
                {
                    var fileContent = File.ReadLines(absoluteFilePath).ToArray();

                    // remove duplicate backslashes
                    var hasDuplicateBackslashes = fileContent.Any(s => s.Contains(@"\\"));

                    if (hasDuplicateBackslashes)
                    {
                        fileContent = fileContent.Select(str => str.Replace(@"\\", @"\")).ToArray();
                    }

                    // replace both forward and backward slashes
                    var newFileContent = fileContent.Select(line => line
                        .Replace(oldPathStr, newPathStr)
                        .Replace(oldPathWithForwardSlashes, newPathWithForwardSlashes)
                    ).ToArray();

                    if (newFileContent.All(line => fileContent.Contains(line)))
                    {
                        return;
                    }

                    // put duplicate backslashes back
                    if (hasDuplicateBackslashes || absoluteFilePath.EndsWith(".lua"))
                    {
                        newFileContent = newFileContent.Select(line => line.Replace(@"\", @"\\")).ToArray();
                    }


                    File.WriteAllLines(absoluteFilePath, newFileContent);
                }
                catch (Exception)
                {
                    failedFiles.Add(absoluteFilePath.RelativePath(activeProject.ResourcesDirectory));
                }
            });
        }

        void ReplaceInCr2WFiles()
        {
            if (!oldAbsolutePath.Contains(activeProject.ModDirectory))
            {
                return;
            }

            // if it's a resource or raw file, no need to refactor it in mod files 
            var files = Directory.GetFiles(activeProject.ModDirectory, "*.*", SearchOption.AllDirectories);

            Parallel.ForEach(files, file =>
            {
                // Don't process files that will never hold paths
                if (Path.GetExtension(file) is string s && !string.IsNullOrEmpty(s) &&
                    s_fileExtensionsWithoutPaths.Contains(s))
                {
                    return;
                }

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
        }
    }


    public void ReplacePathInFile(Cp77Project? activeProject, string absoluteFilePath, ResourcePath oldPath,
        ResourcePath newPath)
    {
        if (oldPath == newPath || !File.Exists(absoluteFilePath) || activeProject is null)
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

        using (var fs = File.Open(absoluteFilePath, FileMode.Open))
        using (var cr = new CR2WReader(fs))
        {
            if (cr.ReadFile(out cr2W) != (RED4.Archive.IO.EFileReadErrorCodes)EFileReadErrorCodes.NoError ||
                cr2W is null)
            {
                return;
            }

            if (cr2W.RootChunk is JsonResource or C2dArray)
            {
                ReplaceInStrings();
            }
            else
            {
                ReplaceInIRedRefs();
            }
        }

        if (!wasModified)
        {
            return;
        }

        using var fs2 = File.Open(absoluteFilePath, FileMode.Create);
        using var cw = new CR2WWriter(fs2);

        cw.WriteFile(cr2W);

        return;

        void ReplaceInStrings()
        {
            if (oldPathStr is null || newPathStr is null)
            {
                return;
            }

            var refs = cr2W.FindType(typeof(IRedString));
            foreach (var result in refs)
            {
                var stringValue = result.Value switch
                {
                    CString resourcePath => resourcePath.GetString(),
                    _ => result.Value.ToString() ?? ""
                };

                if (string.IsNullOrEmpty(stringValue) || !stringValue.Contains(oldPathStr))
                {
                    continue;
                }

                // we need to get the parent node by xpath
                var resultName = result.Path.Split([':', '.']).LastOrDefault();
                if (string.IsNullOrEmpty(resultName))
                {
                    continue;
                }

                var searchResult = cr2W.GetFromXPath(result.Path[..^(resultName.Length + 1)]);
                if (searchResult.Item2 is not IRedType parent || parent is not IList list ||
                    !int.TryParse(resultName, out var idx))
                {
                    continue;
                }

                list[idx] = (CString)stringValue.Replace(oldPathStr, newPathStr);
                wasModified = true;
            }
        }

        void ReplaceInIRedRefs()
        {
            var refs = cr2W.FindType(typeof(IRedRef));
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

                var newValue = (IRedRef)RedTypeManager.CreateRedType(resourceReference.RedType, newDepotPath,
                    resourceReference.Flags);

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

                    _loggerService?.Debug($"Replaced \"{result.Path}\" in \"{absoluteFilePath}\"");
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
                            throw new NotImplementedException(
                                $"Can't replace in property type {parentClass.Item2?.GetType().Name}");
                    }

                    _loggerService?.Debug($"Replaced \"{result.Path}\" in \"{absoluteFilePath}\"");
                }

                wasModified = true;
            }
        }
    }

}