using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HelixToolkit.SharpDX.Core;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using IMaterial = WolvenKit.RED4.Types.IMaterial;

namespace WolvenKit.App.Helpers;

public partial class ProjectResourceTools
{
    private readonly IProjectManager _projectManager;

    private readonly IArchiveManager _archiveManager;

    private readonly ILoggerService _loggerService;

    private readonly ISettingsManager _settingsService;

    private readonly Cr2WTools _crwWTools;


    private static readonly List<string> s_ignoredDependencyPartials =
    [
        ".mltemplate",
        ".mt",
        ".remt",
        Path.Join("base", "surfaces", "microblends"),
        Path.Join("base", "materials"),
        Path.Join("base", "fx"),
        Path.Join("ep1", "materials"),
        Path.Join("ep1", "fx"),
        "engine",
    ];

    public static bool IsIgnoredDependency(IGameFile gameFile)
    {
        return s_ignoredDependencyPartials.Contains(gameFile.Extension) ||
               s_ignoredDependencyPartials.Any(p => gameFile.FileName.StartsWith(p));
    }

    private static bool IsIgnoredDependency(ResourcePath resourcePath)
    {
        return resourcePath.GetResolvedText() is not string path ||
               Path.GetExtension(path) is not string extension ||
               s_ignoredDependencyPartials.Contains(extension) ||
               s_ignoredDependencyPartials.Any(p => path.StartsWith(p));
    }


    /// <summary>
    /// File extensions from source/archive that require updating of resource files
    /// </summary>
    private static readonly List<string> s_replaceInResourceFileExtensions =
    [
        ".ent",
        ".app",
        ".mesh",
        ".csv",
        ".json",
        ".anims",
        ".workspot",
        ".morphtarget",
        ".inkcharcustomization"
    ];

    /// <summary>
    /// File extensions in resources that we want to update
    /// </summary>
    private static readonly List<string> s_resourceFileExtensions =
    [
        ".lua",
        ".xl",
        ".json",
        ".yaml",
        ".yml",
        ".reds",
        ".tweak",
        ".txt"
    ];

    /// <summary>
    /// Extensions of files that we don't need to update
    /// </summary>
    private static readonly List<string> s_fileExtensionsWithoutPaths = [".xbm", ".mlmask", ".txt"];

    private readonly SemaphoreSlim _semaphore = new(1, 1);

    public ProjectResourceTools(IProjectManager projectManager, IArchiveManager archiveManager,
        ILoggerService loggerService, ISettingsManager settingsServiceManager, Cr2WTools cr2WTools)
    {
        _projectManager = projectManager;
        _archiveManager = archiveManager;
        _loggerService = loggerService;
        _settingsService = settingsServiceManager;
        _crwWTools = cr2WTools;
    }

    private RED4Controller? _red4Controller = null;
    private RED4Controller GetRed4Controller()
    {
        if (_red4Controller is not null)
        {
            return _red4Controller;
        }

        if (GameControllerFactory.GetInstance() is GameControllerFactory factory)
        {
            _red4Controller ??= factory.GetRed4Controller();
            return _red4Controller;
        }

        _red4Controller ??= GameControllerFactory.CreateInstance(
            _projectManager,
            Locator.Current.GetService<RED4Controller>()!,
            Locator.Current.GetService<MockGameController>()!
        ).GetRed4Controller();
        return _red4Controller;
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

    public async Task<Dictionary<string, string>> AddDependenciesToProjectPathAsync(
        string destFolderRelativePath,
        HashSet<ResourcePath> resourcePaths,
        bool skipExistingFiles = false
    )
    {
        if (resourcePaths.Count == 0 || _projectManager.ActiveProject is not Cp77Project currentProject)
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
                    // ReSharper disable once VariableHidesOuterVariable
                    if (resourcePaths.Count == 0 || _projectManager.ActiveProject is not Cp77Project currentProject)
                    {
                        tcs.SetResult();
                        return;
                    }

                    var archiveRoot = currentProject.ModDirectory;
                    var absoluteTargetFolder = Path.Combine(archiveRoot, destFolderRelativePath);

                    Directory.CreateDirectory(absoluteTargetFolder); // will do nothing if dir exists

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

                    var overwriteFiles = !skipExistingFiles
                                         && (existingFiles.Count == 0 ||
                                             Interactions.ShowConfirmation((
                                                 $"The following files already exist in the project. Do you want to overwrite them?\n{string.Join('\n', existingFiles)}",
                                                 "Files Already Exist",
                                                 WMessageBoxImage.Question,
                                                 WMessageBoxButtons.YesNo)) is WMessageBoxResult
                                                 .Yes);

                    List<string> filesToRemove = [];
                    foreach (var kvp in pathsAndDestinations)
                    {
                        try
                        {
                            AddFileToProjectFolder(archiveRoot, kvp.Key, kvp.Value, pathReplacements, overwriteFiles,
                                skipExistingFiles);
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
            currentProject.DeleteEmptyFolders(_loggerService);
            _semaphore.Release();
        }
    }

    public void AddToProject(ResourcePath resourcePath)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath
            || string.IsNullOrEmpty(sourceRelativePath)
            || _projectManager.ActiveProject is not { } project
            )
        {
            return;
        }

        if (project.ModFiles.Contains(sourceRelativePath))
        {
            // not aborting here will lead to the file becoming corrupted
            _loggerService.Info("This file is already in your project!");
            return;
        }

        var resPathHash = resourcePath.GetRedHash();
        // we can't add it
        if (resPathHash is 0 || GetRed4Controller() is not RED4Controller controller)
        {
            return;
        }

        if (_archiveManager.Lookup(resPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
        {
            controller.AddToMod(basegameFile.Value, ArchiveManagerScope.Basegame);
        }
        else if (_archiveManager.Lookup(resPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
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
    /// <param name="pathReplacements">Dictionary with replacements in path (string => string)</param>
    /// <param name="overwriteFiles">boolean: overwrite files?</param>
    /// <param name="skipExistingFiles">boolean: skip files silently?</param>
    /// <exception cref="FileNotFoundException"></exception>
    private void AddFileToProjectFolder(string projectRoot, ResourcePath resourcePath, ResourcePath targetResourcePath,
        Dictionary<string, string> pathReplacements, bool overwriteFiles, bool skipExistingFiles)
    {
        if (resourcePath.GetResolvedText() is not string sourceRelativePath
            || string.IsNullOrEmpty(sourceRelativePath) || _projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var resPathHash = resourcePath.GetRedHash();

        // we can't add it
        if (resPathHash is 0 || GetRed4Controller() is not RED4Controller controller)
        {
            return;
        }

        // we don't know where to put it
        if (targetResourcePath.GetResolvedText() is not string targetRelativePath || string.IsNullOrEmpty(targetRelativePath))
        {
            return;
        }

        var fileName = Path.GetFileName(sourceRelativePath);
        var targetAbsolutePath = Path.Combine(projectRoot, targetRelativePath);

        // We already have this file
        if (activeProject.Files.Contains(resourcePath.GetResolvedText()!) || File.Exists(targetAbsolutePath))
        {
            if (skipExistingFiles)
            {
                pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, fileName));
            }
            return;
        }

        if (_archiveManager.Lookup(resPathHash, ArchiveManagerScope.Mods) is { HasValue: true } modFile)
        {
            controller.AddToMod(modFile.Value, ArchiveManagerScope.Mods);
        }
        else if (_archiveManager.Lookup(resPathHash, ArchiveManagerScope.Basegame) is { HasValue: true } basegameFile)
        {
            controller.AddToMod(basegameFile.Value, ArchiveManagerScope.Basegame);
        }
        else
        {
            throw new FileNotFoundException(targetRelativePath);
        }

        var sourceAbsolutePath = Path.Combine(projectRoot, sourceRelativePath);
        var targetAbsoluteFile = Path.Combine(targetAbsolutePath, fileName);

        if (File.Exists(targetAbsoluteFile))
        {
            if (skipExistingFiles)
            {
                pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, fileName));
                return;
            }

            if (overwriteFiles)
            {
                File.Delete(targetAbsoluteFile);
            }
        }

        if (!Directory.Exists(targetAbsolutePath))
        {
            Directory.CreateDirectory(targetAbsolutePath);
        }

        File.Move(sourceAbsolutePath, targetAbsoluteFile, true);

        // pop it into our map
        pathReplacements.TryAdd(sourceRelativePath, Path.Combine(targetRelativePath, fileName));
    }

    private const string s_tempDirSuffix = "_wolvenkit_tempdir";

    // TODO: Remove stupid AbsoluteFolderPrefix
    public async Task MoveAndRefactorAsync(string sourcePath, string destPath, string absoluteFolderPrefix,
        bool refactor)
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return;
        }

        var originalSourcePath = sourcePath;

        var sourceRelPath = sourcePath;
        var destRelPath = destPath;

        var projectRootPath = string.Join(Path.DirectorySeparatorChar,
            absoluteFolderPrefix.ToLower().Split(Path.DirectorySeparatorChar)[..^1]);

        string destAbsPath;
        string sourceFileOrDirAbsPath;

        try
        {
            destRelPath = FileHelper.SanitizePath(destRelPath);
            destAbsPath = ToAbsolutePath(destRelPath);

            sourceRelPath = FileHelper.SanitizePath(sourceRelPath);
            sourceFileOrDirAbsPath = ToAbsolutePath(sourceRelPath);
        }
        catch (Exception e)
        {
            _loggerService.Error($"Failed to move \"{sourcePath}\" to \"{destPath}\": {e.Message}");
            return;
        }

        if (sourceFileOrDirAbsPath == destAbsPath)
        {
            _loggerService.Info($"Skipping {sourceFileOrDirAbsPath} (refusing to copy on itself)...");
            return;
        }

        /*
         * User wants to change the case of a file or directory (usually to lower).
         * This leads to all kinds of havoc (files vanishing etc.), so we do a three-way move.
         */
        if (sourceFileOrDirAbsPath.Equals(destAbsPath, StringComparison.OrdinalIgnoreCase))
        {
            var newSourceDir = $"{destAbsPath.TrimEnd(Path.DirectorySeparatorChar)}{s_tempDirSuffix}";
            await MoveAndRefactorAsync(sourceFileOrDirAbsPath, newSourceDir, absoluteFolderPrefix, refactor);
            sourceFileOrDirAbsPath = newSourceDir;
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
            Directory.Move(sourceFileOrDirAbsPath, destAbsPath);
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

        // Maybe the user doesn't want to overwrite files, and nothing is left
        if (files.Count == 0)
        {
            return;
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

            await MoveFileAsync(sourceAbsPath, targetAbsPath);

            // Do not log if we're moving to a temp folder (for case sensitivity)
            if (destAbsPath.Contains(s_tempDirSuffix))
            {
                continue;
            }

            var relativeSourcePath = activeProject.GetRelativePath(sourceAbsPath);

            // We've been moving across temp directories
            if (originalSourcePath != sourceFileOrDirAbsPath)
            {
                var relativeTempPath = activeProject.GetRelativePath(sourceFileOrDirAbsPath);
                var relativePath = activeProject.GetRelativePath(originalSourcePath);
                relativeSourcePath = relativeSourcePath.Replace(relativeTempPath, relativePath);
            }

            var relativeDestPath = activeProject.GetRelativePath(targetAbsPath);
            _loggerService.Info($"Moved \"{relativeSourcePath}\" to \"{relativeDestPath}\"");

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

        await ReplacePathInProjectAsync(activeProject, successfulReplacements);
        return;

        string ToAbsolutePath(string relativePath)
        {
            var inputPath = relativePath;
            if (Regex.IsMatch(inputPath, @"^\.+\\"))
            {
                inputPath = new Uri(new Uri(absoluteFolderPrefix), new Uri(inputPath, UriKind.Relative)).LocalPath;
            }

            if (!Path.IsPathRooted(inputPath))
            {
                return Path.Join(absoluteFolderPrefix, inputPath);
            }

            if (inputPath.StartsWith(string.Join(Path.DirectorySeparatorChar, projectRootPath),
                    StringComparison.CurrentCultureIgnoreCase))
            {
                return inputPath;
            }

            throw new InvalidDataException($"{relativePath} is not a valid path");
        }
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

    /// <summary>
    /// When moving a directory into a subdirectory of itself, File.Move will simply delete it.
    /// So we're putting it into a tempdir first.
    ///
    /// Example for breaking case: /base/meshes => /base/meshes/turret
    /// </summary>
    private Task MoveFileAsync(string sourcePath, string targetPath)
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
        }
        catch (Exception e)
        {
            _loggerService.Error($"Error when trying to move \"{sourcePath}\": {e.Message}");
        }

        return Task.CompletedTask;
    }

    public async Task ReplacePathInProjectAsync(Cp77Project? activeProject, Dictionary<string, string> pathReplacements,
        params string[] fileExtensions)
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
                .Where(f => Path.GetExtension(f) is string s && s_resourceFileExtensions.Contains(s.ToLower()) &&
                            (fileExtensions.Length == 0 || fileExtensions.Contains(s.ToLower())))
                .ToList();

            // add ext.json files from raw folder
            resourceFiles.AddRange(Directory.GetFiles(activeProject.RawDirectory, "*.json", SearchOption.AllDirectories)
                .Where(f => f.EndsWith(".json") && f.HasTwoExtensions()));

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

                    // Take care of forward slashes (e.g. lua)
                    var hasForwardSlashes = fileContent.Any(s => s.Contains('/'));

                    var newFileContent = fileContent.ToArray();
                    foreach (var (oldAbsPath, newAbsPath) in pathReplacements)
                    {
                        if (!oldAbsPath.Contains(activeProject.ModDirectory) ||
                            Path.GetExtension(oldAbsPath) is not string fileExtension ||
                            !s_replaceInResourceFileExtensions.Contains(fileExtension))
                        {
                            continue;
                        }

                        var oldPathStr = activeProject.GetResourcePathFromRoot(oldAbsPath).GetResolvedText()
                            ?.SanitizeFilePath();
                        var newPathStr = activeProject.GetResourcePathFromRoot(newAbsPath).GetResolvedText()?
                            .SanitizeFilePath();

                        if (string.IsNullOrEmpty(oldPathStr) || string.IsNullOrEmpty(newPathStr) ||
                            oldPathStr == newPathStr)
                        {
                            continue;
                        }

                        var oldPathWithForwardSlashes = oldPathStr.SanitizeFilePath(true);
                        var newPathWithForwardSlashes = newPathStr.SanitizeFilePath(true);

                        newFileContent = newFileContent.Select(line => line
                            .Replace(oldPathStr, newPathStr)
                            .Replace(oldPathWithForwardSlashes, newPathWithForwardSlashes)
                        ).ToArray();
                    }

                    if (!newFileContent.SequenceEqual(fileContent))
                    {
                        if (hasDuplicateBackslashes)
                        {
                            newFileContent = newFileContent.Select(line => line.Replace(@"\", @"\\")).ToArray();
                        }
                        else if (hasForwardSlashes)
                        {
                            newFileContent = newFileContent.Select(line => line.Replace(@"\", @"/")).ToArray();
                        }

                        await File.WriteAllLinesAsync(absoluteFilePath, newFileContent);
                    }
                }
                catch (Exception err)
                {
                    _loggerService.Error(err.Message);
                    failedFiles.Add(absoluteFilePath.RelativePath(activeProject.ResourcesDirectory));
                }
            });

            await Task.WhenAll(resourceTasks);
        }

        async Task ReplaceInCr2WFilesAsync()
        {
            var files = Directory.GetFiles(activeProject.ModDirectory, "*.*", SearchOption.AllDirectories)
                .Where(f => Path.GetExtension(f) is string s && !string.IsNullOrEmpty(s) &&
                            !s_fileExtensionsWithoutPaths.Contains(s) &&
                            (fileExtensions.Length == 0 || fileExtensions.Contains(s.ToLower()))
                )
                .ToList();

            var cr2WTasks = files
                .Where(s => !s.HasTwoExtensions() ||
                            !s.EndsWith(".json", StringComparison.OrdinalIgnoreCase)) // ignore xyz.json files)
                .Select(absoluteFilePath =>
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
                        var oldPathStr = activeProject.GetRelativePath(oldAbsPath);
                        var newPathStr = activeProject.GetRelativePath(newAbsPath);

                        if (string.IsNullOrEmpty(oldPathStr) || string.IsNullOrEmpty(newPathStr))
                        {
                            continue;
                        }

                        cr2W = ReplacePathInFile(cr2W, oldPathStr, newPathStr, out var b);
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

                    _loggerService.Debug(
                        $"Replaced the following paths in \"{activeProject.GetRelativePath(absoluteFilePath)}\"\n\t: {string.Join(",\n\t", foundReplacements.Select(kvp => $"{kvp.Key} -> {kvp.Value}"))}");

                    _crwWTools.WriteCr2W(cr2W, absoluteFilePath);
                }
                catch (Exception err)
                {
                    _loggerService.Error(err.Message);
                    failedFiles.Add(absoluteFilePath.RelativePath(activeProject.ModDirectory));
                }

                return Task.CompletedTask;
            });

            await Task.WhenAll(cr2WTasks);
        }
    }

    private CR2WFile ReplacePathInFile(CR2WFile cr2W, string oldPathStr, string newPathStr, out bool wasModified)
    {
        wasModified = false;

        if (oldPathStr == newPathStr || _projectManager.ActiveProject is not { } activeProject)
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
                    resourceReference.DepotPath == ResourcePath.Empty ||
                    resourceReference.DepotPath.GetResolvedText() is not string depotPath)
                {
                    continue;
                }

                if (depotPath.StartsWith(ArchiveXlHelper.ArchiveXLSubstitutionPrefix) && ArchiveXlHelper
                        .ResolveDynamicPaths(depotPath, activeProject).Contains(oldPathStr))
                {
                    // handle dynamic substitution
                    newPathStr = ArchiveXlHelper.ReplaceInDynamicPath(depotPath, newPathStr);
                }
                else if (depotPath != oldPathStr)
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
                    case IRedHandle handle when handle.GetValue() is gameuiAppearanceInfo appInfo:
                        appInfo.Resource =
                            new CResourceAsyncReference<appearanceAppearanceResource>(newValue.DepotPath);
                        break;
                    case IRedHandle handle when handle.GetValue() is CMaterialInstance mInstance:
                        mInstance.BaseMaterial = new CResourceReference<IMaterial>(newValue.DepotPath);
                        break;
                    case IRedHandle ira:
                        throw new WolvenKitException(-1,
                            $"Can't replace in IRedHandle property type {ira.RedType}");
                    default:
                        throw new WolvenKitException(-1,
                            $"Can't replace in property type {parentClass.Item2?.GetType().Name}");
                }


                ret = true;
            }

            return ret;
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

        // Do not delete anything directly under the source directory or outside the project
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

    public void ScanModArchives(bool? executeScan = null, string? archiveName = null)
    {
        if (_settingsService.CP77ExecutablePath is null)
        {
            return;
        }

        var scanArchives = executeScan ?? _settingsService.AnalyzeModArchives;

        var ignoredArchives = _settingsService.ArchiveNamesExcludeFromScan
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(name => name.Replace(".archive", "")).ToArray();

        if (archiveName is null)
        {
            _archiveManager.LoadModArchives(new FileInfo(_settingsService.CP77ExecutablePath), scanArchives,
                ignoredArchives);

            if (Directory.Exists(_settingsService.ExtraModDirPath))
            {
                _archiveManager.LoadAdditionalModArchives(_settingsService.ExtraModDirPath, scanArchives,
                    ignoredArchives);
            }

            return;
        }

        List<string> archivesToScan = [];
        archivesToScan.AddRange(_archiveManager.GetModArchives()
            .Where(archive => archive.Name.Contains(archiveName, StringComparison.OrdinalIgnoreCase))
            .Select(gameArchive => gameArchive.ArchiveAbsolutePath)
            .Where(absolutePath => !ignoredArchives.Contains(Path.GetFileName(absolutePath).Replace(".archive", ""))));

        if (Directory.Exists(_settingsService.ExtraModDirPath))
        {
            archivesToScan.AddRange(Directory
                .GetFiles(_settingsService.ExtraModDirPath, archiveName, SearchOption.AllDirectories)
                .Where(absolutePath =>
                    !ignoredArchives.Contains(Path.GetFileName(absolutePath).Replace(".archive", ""))));
        }

        if (archivesToScan.Count > 0)
        {
            foreach (var absoluteFilepath in archivesToScan)
            {
                _archiveManager.LoadModArchive(absoluteFilepath, scanArchives, !scanArchives);
            }

            return;
        }

        // If no archives match the filter, scan all archives.
        _archiveManager.LoadModArchives(new FileInfo(_settingsService.CP77ExecutablePath), scanArchives,
            ignoredArchives);

        if (Directory.Exists(_settingsService.ExtraModDirPath))
        {
            _archiveManager.LoadAdditionalModArchives(_settingsService.ExtraModDirPath, scanArchives);
        }
    }

    public void InitializeArchiveManager()
    {
        if (_archiveManager.IsInitialized)
        {
            return;
        }

        if (_settingsService.CP77ExecutablePath is null)
        {
            throw new WolvenKitException(0x5000, "Cyberpunk executable not configured");
        }

        _loggerService.Info("Scanning your mods... this can take a moment. Wolvenkit will be unresponsive.");
        _archiveManager.Initialize(new FileInfo(_settingsService.CP77ExecutablePath));
    }

    public List<string> GetProjectFiles(string fileExtension, ProjectFolder folder)
    {
        if (_projectManager.ActiveProject is not { } project)
        {
            return [];
        }

        var projectFiles = folder switch
        {
            ProjectFolder.All => project.Files,
            ProjectFolder.Archive => project.ModFiles,
            ProjectFolder.Raw => project.RawFiles,
            ProjectFolder.Resources => project.ResourceFiles,
            _ => [],
        };

        return projectFiles
            .Where(f => f.HasFileExtension(fileExtension))
            .ToList();
    }

    /// <param name="absolutePath">absolute path of folder</param>
    /// <param name="checkRecursive">get only files in top level directory?</param>
    /// <param name="fileExtension">optional: a file extension to filter by</param>
    /// <param name="allowDuplicateFileExtension">Checks for duplicate file extension, e.g. .json matches .morphtarget.json</param>
    /// <returns></returns>
    public static List<string> GetFilesFromDirectory(string? absolutePath, bool checkRecursive = false,
        string fileExtension = "", bool allowDuplicateFileExtension = false)
    {
        if (absolutePath is null || !Directory.Exists(absolutePath))
        {
            return [];
        }

        return Directory.GetFiles(absolutePath, "*",
                checkRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
            .Where(f =>
            {
                if (string.IsNullOrEmpty(fileExtension))
                {
                    return true;
                }

                return f.HasFileExtension(fileExtension) && (allowDuplicateFileExtension || !f.HasTwoExtensions());
            })
            .Order()
            .ToList();
    }

    /// <summary>
    /// Add a list of item codes to an atelier store and/or a VendorsXL vendor
    /// </summary>
    /// <param name="dialogVmItemCodes"></param>
    /// <param name="relativeYamlPath"></param>
    /// <param name="relativeRedsPath"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void AddItemCodesToStoreFiles(List<string> dialogVmItemCodes, string relativeYamlPath,
        string relativeRedsPath)
    {
        if (_projectManager.ActiveProject is not { } project)
        {
            return;
        }

        AddToYaml();

        AddToReds();

        return;

        void AddToYaml()
        {
            if (string.IsNullOrEmpty(relativeYamlPath) ||
                YamlHelper.ReadYamlAsObject(Path.Join(project.ResourcesDirectory, relativeYamlPath)) is not
                    ExpandoObject yaml)
            {
                return;
            }

            // Get the backing dictionary for mutability
            IDictionary<string, object> yamlDict = yaml!;
            if (yamlDict.Count == 0)
            {
                return;
            }

            var modified = false;

            foreach (var key in yamlDict.Keys)
            {
                if (!key.StartsWith("Character") || yamlDict.Get(key) is not ExpandoObject characterRecord)
                {
                    continue;
                }

                IDictionary<string, object> characterDict = characterRecord!;
                if (!characterDict.AsReadOnly().TryGetValue("items", out var value) ||
                    value is not List<object> items)
                {
                    _loggerService.Error($"Failed finding 'items' entry in '{key}' ({relativeRedsPath})");
                    continue;
                }

                if (dialogVmItemCodes.All(c => items.Contains(c)))
                {
                    _loggerService.Info("All item codes already listed in " + relativeYamlPath);
                    continue;
                }

                items.AddRange(dialogVmItemCodes);

                characterDict["items"] = items.Distinct().ToList();
                modified = true;
            }

            if (!modified)
            {
                return;
            }

            try
            {
                YamlHelper.WriteYaml(Path.Join(project.ResourcesDirectory, relativeYamlPath), yaml);
            }
            catch (Exception ex)
            {
                _loggerService.Error("Failed writing yaml: " + ex.Message);
            }
        }

        void AddToReds()
        {
            if (string.IsNullOrEmpty(relativeRedsPath))
            {
                return;
            }

            var absoluteRedsPath = Path.Join(project.ResourcesDirectory, relativeRedsPath);
            if (!File.Exists(absoluteRedsPath))
            {
                _loggerService.Error("Failed reading atelier store " + relativeRedsPath);
                return;
            }

            var textContent = File.ReadAllText(absoluteRedsPath);

            if (dialogVmItemCodes.All(c => textContent.Contains(c)))
            {
                _loggerService.Info("All item codes already listed in atelier store " + relativeRedsPath);
                return;
            }


            var match = AtelierLastItemCode().Match(textContent);
            if (!match.Success)
            {
                _loggerService.Error(
                    "Failed appending to atelier store: Please make sure your store has at least one item.");
                return;
            }

            try
            {
                var insertIndex = match.Index + match.Length;
                var newItems = $",\n    {string.Join(", ", dialogVmItemCodes.Select(i => $"\"{i}\""))} ";
                textContent = textContent.Insert(insertIndex - 1, newItems);
                File.WriteAllText(absoluteRedsPath, textContent);
            }
            catch (Exception ex)
            {
                _loggerService.Error("Failed writing atelier .reds: " + ex.Message);
            }
        }
    }

    [GeneratedRegex(@"Items\.\w+""(?!,)()(?=\s|\])", RegexOptions.Multiline)]
    private static partial Regex AtelierLastItemCode();

    public HashSet<ResourcePath> GetDependencyPaths(CR2WFile cr2W, bool includeMods = false)
    {
        var materialDependencies = cr2W.FindType(typeof(IRedRef)).Select(r => r.Value)
            .OfType<IRedRef>()
            .Where(refPath => _archiveManager.Lookup(refPath.DepotPath,
                includeMods ? ArchiveManagerScope.BasegameAndMods : ArchiveManagerScope.Basegame).HasValue)
            .Select(r => r.DepotPath)
            .Where(d => !IsIgnoredDependency(d))
            .ToHashSet();

        var miDependencies = materialDependencies.Select(p => p.GetResolvedText()).OfType<string>()
            .Where(p => p.EndsWith(".mi")).Select(p => _crwWTools.ReadCr2WNoException(p)).OfType<CR2WFile>()
            .SelectMany(miCr2W => GetDependencyPaths(miCr2W, includeMods));

        materialDependencies.AddRange(miDependencies);

        return materialDependencies;
    }

    public async Task AddDependenciesToProject(CR2WFile cr2W, string destFolder)
    {
        if (cr2W.RootChunk is not CMesh || _projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var materialDependencies = GetDependencyPaths(cr2W);
        var relativeDestPath = activeProject.GetRelativePath(destFolder);

        // Now ignore any files that are already in target folder
        foreach (var resourcePath in materialDependencies.ToList().Where(p =>
                     p.GetResolvedText() is string s && s.StartsWith(relativeDestPath)))
        {
            materialDependencies.Remove(resourcePath);
        }


        if (materialDependencies.Count == 0)
        {
            return;
        }

        Directory.CreateDirectory(destFolder);

        if (string.IsNullOrEmpty(destFolder))
        {
            _loggerService.Info("Adding dependencies aborted by user input");
            return;
        }

        // Use search and replace to fix file paths
        var pathReplacements = await AddDependenciesToProjectPathAsync(
            destFolder, materialDependencies, true
        );

        if (pathReplacements.Count == 0)
        {
            return;
        }

        HashSet<string> miFiles = [];
        foreach (var kvp in pathReplacements)
        {
            ReplacePathInFile(cr2W, kvp.Key, kvp.Value, out var _);
            if (kvp.Value.EndsWith(".mi"))
            {
                miFiles.Add(kvp.Value);
            }
        }

        // Now take care of any newly-added .mi files
        foreach (var miCr2W in miFiles.Select(p => _crwWTools.ReadCr2WNoException(p)).OfType<CR2WFile>())
        {
            foreach (var kvp in pathReplacements)
            {
                ReplacePathInFile(miCr2W, kvp.Key, kvp.Value, out var _);
            }
        }


        // All files were moved. Occasionally, we have leftover ones (duplicates).
        foreach (var absolutePath in pathReplacements.Keys
                     .Select(relPath => Path.Combine(activeProject.ModDirectory, relPath))
                     .Where(File.Exists))
        {
            try
            {
                File.Delete(absolutePath);
            }
            catch
            {
                // don't delete
            }
        }

        activeProject.DeleteEmptyFolders(_loggerService);
    }

    # region meshFiles

    public List<string> GetAppearanceNames(string relativePath)
    {
        List<string> ret = [];
        if (_projectManager.ActiveProject is not { } activeProject || !activeProject.ModFiles.Contains(relativePath) ||
            _crwWTools.ReadCr2W(Path.Join(activeProject.ModDirectory, relativePath)) is not { } cr2W)
        {
            return ret;
        }

        switch (cr2W.RootChunk)
        {
            case CMesh mesh:
                ret.AddRange(mesh.Appearances.Select(h => h.Chunk)
                    .OfType<meshMeshAppearance>()
                    .Select(a => a.Name.ToString() ?? ""));
                break;
            case appearanceAppearanceResource app:
                ret.AddRange(app.Appearances.Select(a => a.Chunk).OfType<appearanceAppearanceDefinition>()
                    .Select(a => a.Name.ToString() ?? ""));
                break;
            default:
                break;
        }

        return ret.Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();
    }

    #endregion
}
