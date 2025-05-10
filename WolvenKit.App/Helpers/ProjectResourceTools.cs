using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

    private readonly Cr2WTools _crwWTools;

    public ProjectResourceTools(IProjectManager projectManager, IArchiveManager archiveManager,
        ILoggerService loggerService, ISettingsManager settingsManager, Cr2WTools cr2WTools)
    {
        _projectManager = projectManager;
        _archiveManager = archiveManager;
        _loggerService = loggerService;
        _settingsService = settingsManager;
        _crwWTools = cr2WTools;
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

        var projectRootPath = string.Join(Path.DirectorySeparatorChar,
            absoluteFolderPrefix.ToLower().Split(Path.DirectorySeparatorChar)[..^1]);

        string SetAbsolutePath(string relativePath)
        {
            var inputPath = relativePath;
            if (Regex.IsMatch(inputPath, @"^\.+\\"))
            {
                inputPath = new Uri(new Uri(absoluteFolderPrefix), new Uri(inputPath, UriKind.Relative)).LocalPath;
            }

            if (Path.IsPathRooted(inputPath))
            {
                if (inputPath.ToLower().StartsWith(string.Join(Path.DirectorySeparatorChar, projectRootPath.ToLower())))
                {
                    return inputPath;
                }

                throw new Exception($"Path: \"{inputPath}\" is not a valid absolute path inside the project.");
            }

            return Path.Join(absoluteFolderPrefix, inputPath);
        }

        string destAbsPath;
        string sourceFileOrDirAbsPath;

        try
        {
            destRelPath = FileHelper.SanitizePath(destRelPath);
            destAbsPath = SetAbsolutePath(destRelPath);

            sourceRelPath = FileHelper.SanitizePath(sourceRelPath);
            sourceFileOrDirAbsPath = SetAbsolutePath(sourceRelPath);
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to move \"{sourcePath}\" to \"{destPath}\": {e.Message}");
            return;
        }

        // Don't copy a directory on itself
        if (sourceFileOrDirAbsPath.Equals(destAbsPath, StringComparison.OrdinalIgnoreCase))
        {
            _loggerService.Info($"Skipping {sourceFileOrDirAbsPath} (refusing to copy on itself)...");
            return;
        }

        var sourceIsDirectory = Directory.Exists(sourceFileOrDirAbsPath);

        List<string> files = [];

        if (sourceIsDirectory)
        {
            files.AddRange(Directory.EnumerateFiles(sourceFileOrDirAbsPath, "*", SearchOption.AllDirectories));
        }
        else
        {
            files.Add(sourceFileOrDirAbsPath);
        }

        // the user is moving an empty directory
        if (files.Count == 0 && sourceIsDirectory)
        {
            MoveDirectoryAndChildren(sourceFileOrDirAbsPath, destAbsPath);
            DeleteEmptyDirectoriesRecursive(sourceFileOrDirAbsPath);
            return;
        }

        files = files.Distinct().ToList();

        var existingFiles = files.Where(file =>
        {
            var relativePath = Path.GetRelativePath(sourceFileOrDirAbsPath, file);
            var targetFilePath = Path.Combine(destAbsPath, relativePath);
            return File.Exists(targetFilePath);
        }).ToList();

        if (existingFiles.Count > 0)
        {
            var response = Interactions.ShowQuestionYesNo((
                $"Do you want to overwrite the existing files {string.Join('\n', existingFiles)}?",
                "One or more files already exists!"));

            if (!response)
            {
                files = files.Except(existingFiles).ToList();
            }
        }

        var fileReplacements = new Dictionary<string, string>();

        foreach (var sourceAbsPath in files)
        {
            // If the file is not a folder, this is just the dest path
            var targetAbsPath = sourceAbsPath.Replace(sourceFileOrDirAbsPath, destAbsPath);

            if (!fileReplacements.TryAdd(sourceAbsPath, targetAbsPath))
            {
                continue;
            }

            await MoveFile(sourceAbsPath, targetAbsPath, activeProject, sourceIsDirectory);                
        }

        // Delete only files that were successfully replaced
        var successfulReplacements = fileReplacements.Where((kvp) => File.Exists(kvp.Value)).ToDictionary();

        foreach (var originalFile in successfulReplacements.Keys.Where(File.Exists))
        {
            File.Delete(originalFile);
        }

        // Delete empty directories
        if (successfulReplacements.Count > 0)
        {
            DeleteEmptyDirectoriesRecursive(sourceFileOrDirAbsPath);
        }

        if (!refactor)
        {
            return;
        }

        ReplacePathInProject(activeProject, successfulReplacements);
    }

    private static void MoveDirectoryAndChildren(string sourceAbsPath, string destAbsPath)
    {
        if (!Directory.Exists(sourceAbsPath))
        {
            return;
        }

        if (!Directory.Exists(destAbsPath))
        {
            Directory.CreateDirectory(destAbsPath);
        }

        foreach (var directory in Directory.GetDirectories(sourceAbsPath, "*", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(sourceAbsPath, directory);
            var targetDirPath = Path.Combine(destAbsPath, relativePath);

            Directory.CreateDirectory(targetDirPath);
        }

        Directory.Delete(sourceAbsPath, true);
    }

    /// <summary>
    /// Deletes all empty directories in a tree (directories not containing files), finally deleting the root if it's empty
    /// </summary>
    private static void DeleteEmptyDirectoriesRecursive(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            return;
        }

        foreach (var subDirectory in Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories))
        {
            DeleteEmptyDirectoriesRecursive(subDirectory);
        }

        // if the directory has no children, delete it
        if (Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories).Length == 0 && 
              Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories).Length == 0)
        {
            Directory.Delete(directoryPath, true);
        }
    }

    private Task MoveFile(string sourcePath, string targetPath, Cp77Project activeProject, bool isDirectory)
    {
        try
        {
            var sourceIsTarget = string.Equals(sourcePath, targetPath, StringComparison.CurrentCultureIgnoreCase);
            if (sourceIsTarget)
            {
                return Task.CompletedTask;
            }

            if (File.Exists(targetPath))
            {
                File.Delete(targetPath);
            }

            var tempId = Guid.NewGuid();
            var tempPath = $"{targetPath}_{tempId}.tmp";

            Directory.CreateDirectory(Path.GetDirectoryName(targetPath)!);

            // Move the file to a temporary location first
            File.Move(sourcePath, tempPath);
            File.Move(tempPath, targetPath, true);

            _loggerService.Info(
                $"Moved \"{activeProject.GetRelativePath(sourcePath)}\" to \"{activeProject.GetRelativePath(targetPath)}\"");
        }
        catch (Exception e)
        {
            _loggerService.Error($"Error when trying to move \"{sourcePath}\": {e.Message}");
        }

        return Task.CompletedTask;
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

    private async void ReplacePathInProject(Cp77Project? activeProject, Dictionary<string, string> pathReplacements)
    {
        List<string> failedFiles = [];
        if (activeProject is null)
        {
            return;
        }

        Task[] tasks = [ReplaceInResourceFilesAsync(), ReplaceInCr2WFilesAsync()];

        await Task.WhenAll(tasks);
        
        if (failedFiles.Count <= 0)
        {
            return;
        }

        _loggerService.Error($"Failed to auto-update references in the following files:");
        failedFiles.ForEach((path) => _loggerService.Error($"  {path}"));

        return;

        async Task ReplaceInResourceFilesAsync()
        {
            var resourceFiles = Directory.GetFiles(activeProject.ResourcesDirectory, "*.*", SearchOption.AllDirectories)
                .Where(f => Path.GetExtension(f) is string s && s_resourceFileExtensions.Contains(s.ToLower()))
                .ToList();

            var resourceTasks = resourceFiles.Select(async absoluteFilePath =>
            {
                try
                {
                    var fileContent = await File.ReadAllLinesAsync(absoluteFilePath);

                    // Remove duplicate backslashes
                    var hasDuplicateBackslashes = fileContent.Any(s => s.Contains(@"\\"));
                    if (hasDuplicateBackslashes)
                    {
                        fileContent = fileContent.Select(str => str.Replace(@"\\", @"\")).ToArray();
                    }

                    var newFileContent = fileContent.ToArray();
                    foreach (var (oldAbsPath, newAbsPath) in pathReplacements)
                    {
                        if (!oldAbsPath.Contains(activeProject.ModDirectory) ||
                            Path.GetExtension(oldAbsPath) is not string fileExtension ||
                            !s_replaceInResourceFileExtensions.Contains(fileExtension))
                        {
                            continue;
                        }

                        var oldPathStr = activeProject.GetResourcePathFromRoot(oldAbsPath).GetResolvedText();
                        var newPathStr = activeProject.GetResourcePathFromRoot(newAbsPath).GetResolvedText();

                        if (string.IsNullOrEmpty(oldPathStr) || string.IsNullOrEmpty(newPathStr))
                        {
                            continue;
                        }

                        var oldPathWithForwardSlashes = oldPathStr.Replace("\\", "/");
                        var newPathWithForwardSlashes = newPathStr.Replace("\\", "/");

                        newFileContent = newFileContent.Select(line => line
                            .Replace(oldPathStr, newPathStr)
                            .Replace(oldPathWithForwardSlashes, newPathWithForwardSlashes)
                        ).ToArray();
                    }

                    if (!newFileContent.SequenceEqual(fileContent))
                    {
                        if (hasDuplicateBackslashes || absoluteFilePath.EndsWith(".lua"))
                        {
                            newFileContent = newFileContent.Select(line => line.Replace(@"\", @"\\")).ToArray();
                        }

                        await File.WriteAllLinesAsync(absoluteFilePath, newFileContent);
                    }
                }
                catch (Exception)
                {
                    failedFiles.Add(absoluteFilePath.RelativePath(activeProject.ResourcesDirectory));
                }
            });

            await Task.WhenAll(resourceTasks);
        }

        async Task ReplaceInCr2WFilesAsync()
        {
            var files = Directory.GetFiles(activeProject.ModDirectory, "*.*", SearchOption.AllDirectories)
                .Where(f => Path.GetExtension(f) is string s && !string.IsNullOrEmpty(s) &&
                            !s_fileExtensionsWithoutPaths.Contains(s))
                .ToList();

            var cr2WTasks = files.Select(absoluteFilePath =>
            {
                try
                {
                    if (_crwWTools.ReadCr2W(absoluteFilePath) is not CR2WFile cr2W)
                    {
                        return Task.CompletedTask;
                    }

                    var wasModified = false;
                    Dictionary<string, string> foundReplacements = new();

                    foreach (var (oldAbsPath, newAbsPath) in pathReplacements)
                    {
                        if (!oldAbsPath.Contains(activeProject.ModDirectory))
                        {
                            continue;
                        }

                        var oldPathStr = activeProject.GetRelativePath(oldAbsPath);
                        var newPathStr = activeProject.GetRelativePath(newAbsPath);

                        if (string.IsNullOrEmpty(oldPathStr) || string.IsNullOrEmpty(newPathStr))
                        {
                            continue;
                        }

                        cr2W = ReplacePathInFile(cr2W, oldPathStr, newPathStr, out var b, absoluteFilePath);
                        if (!b)
                        {
                            continue;
                        }

                        wasModified = true;
                        foundReplacements.Add(oldPathStr, newPathStr);
                    }

                    if (!wasModified)
                    {
                        return Task.CompletedTask;
                    }

                    _loggerService?.Debug(
                        $"Replaced the following paths in \"{activeProject.GetRelativePath(absoluteFilePath)}\"\n\t: {string.Join(",\n\t", foundReplacements.Select(kvp => $"{kvp.Key} -> {kvp.Value}"))}");

                    _crwWTools.WriteCr2W(cr2W, absoluteFilePath);
                }
                catch (Exception err)
                {
                    _loggerService?.Error(err.Message);
                    failedFiles.Add(absoluteFilePath.RelativePath(activeProject.ModDirectory));
                }

                return Task.CompletedTask;
            });

            await Task.WhenAll(cr2WTasks);
      
            return;

            CR2WFile ReplacePathInFile(CR2WFile cr2W, string oldPathStr, string newPathStr, out bool wasModified,
                string originalPath)
            {
                wasModified = false;

                if (oldPathStr == newPathStr)
                {
                    return cr2W;
                }

                // Mesh needs to replace in strings for @context materials
                if ((cr2W.RootChunk is JsonResource or C2dArray or CMesh) &&
                    ReplaceInStrings())
                {
                    wasModified = true;
                }


                if ((cr2W.RootChunk is not (JsonResource or C2dArray)) &&
                    ReplaceInIRedRefs())
                {
                    wasModified = true;
                }

                return cr2W;


                bool ReplaceInStrings()
                {
                    var ret = false;
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
                        if (searchResult.Item2 is not IRedType parent)
                        {
                            continue;
                        }

                        switch (parent)
                        {
                            case IList list when int.TryParse(resultName, out var idx):
                                list[idx] = (CString)stringValue.Replace(oldPathStr, newPathStr);
                                ret = true;
                                break;
                            // CPUNameU64
                            case CKeyValuePair kvp when resultName == "Value" && kvp.Value is CName str &&
                                                        str.GetResolvedText() is string s:
                                kvp.Value = (CName)s.Replace(oldPathStr, newPathStr);
                                ret = true;
                                break;
                        }
                    }

                    return ret;
                }

                bool ReplaceInIRedRefs()
                {
                    var refs = cr2W.FindType(typeof(IRedRef));
                    var ret = false;
                    foreach (var result in refs)
                    {
                        if (result.Value is not IRedRef resourceReference ||
                            resourceReference.DepotPath == ResourcePath.Empty)
                        {
                            continue;
                        }

                        var oldDepotPathStr = resourceReference.DepotPath.GetResolvedText();

                        if (resourceReference.DepotPath.GetResolvedText() != oldPathStr)
                        {
                            continue;
                        }

                        var parentPath = string.Join('.', result.Path.Split('.')[..^1]);

                        var newValue = (IRedRef)RedTypeManager.CreateRedType(resourceReference.RedType,
                            (ResourcePath)newPathStr,
                            resourceReference.Flags);

                        if (result.Name.Contains(':'))
                        {
                            var parts = result.Name.Split(':');
                            if (parts.Length != 2)
                            {
                                throw new Exception($"Failed to split {result.Name} in two parts");
                            }

                            var parentArray = cr2W.GetFromXPath(string.Join('.', parentPath, parts[0]));
                            if (int.TryParse(parts[1], out var index) &&
                                parentArray is { Item1: true, Item2: IList arr })
                            {
                                arr[index] = newValue;
                                ret = true;
                                continue;
                            }
                        }

                        var parentClass = cr2W.GetFromXPath(parentPath);

                        if (!parentClass.Item1)
                        {
                            throw new Exception($"Failed to find {result.Name} in {parentPath}");
                        }

                        switch (parentClass.Item2)
                        {
                            case null:
                                throw new InvalidDataException("Item2 should not be null");
                            case RedBaseClass cls:
                                cls.SetProperty(result.Name, newValue);
                                break;
                            case CKeyValuePair kvp:
                                kvp.Value = newValue;
                                break;
                            case IRedHandle handle
                                when handle.GetValue() is gameuiAppearanceInfo appInfo:
                                appInfo.Resource =
                                    new CResourceAsyncReference<appearanceAppearanceResource>(newValue.DepotPath);
                                break;
                            case IRedHandle ira:
                                throw new NotImplementedException(
                                    $"Can't replace in IRedHandle property type {ira.RedType}, please file a ticket");
                            default:
                                throw new NotImplementedException(
                                    $"Can't replace in property type {parentClass.Item2?.GetType().Name}, please file a ticket");
                        }


                        ret = true;
                    }

                    return ret;
                }
            }

  
             
        }
    }

    /// <summary>
    /// Deletes empty parent directories of a given file or folder path.
    /// </summary>
    /// <param name="absolutePath">Absolute path to file or folder</param>
    /// <param name="activeProject">Current Wolvenkit project (so we don't delete too many folders)</param>
    public static void DeleteEmptyParents(string? absolutePath, Cp77Project activeProject)
    {
        var absoluteFolderPath = absolutePath;

        if (Path.HasExtension(absolutePath) || !Directory.Exists(absolutePath))
        {
            absoluteFolderPath = Path.GetDirectoryName(absolutePath);
        }

        // No directory to delete
        if (absoluteFolderPath is null || !Directory.Exists(absoluteFolderPath))
        {
            return;
        }

        // Do not delete anything directly under the source directory or outside of the project
        if (absoluteFolderPath == activeProject.FileDirectory ||
            Path.GetDirectoryName(absoluteFolderPath) == activeProject.FileDirectory ||
            !absoluteFolderPath.StartsWith(activeProject.FileDirectory))
        {
            return;
        }

        // directory is not empty, return;
        if (Directory.GetFiles(absoluteFolderPath).Length + Directory.GetDirectories(absoluteFolderPath).Length > 0)
        {
            return;
        }

        Directory.Delete(absoluteFolderPath);
        DeleteEmptyParents(absoluteFolderPath, activeProject);
    } 

}