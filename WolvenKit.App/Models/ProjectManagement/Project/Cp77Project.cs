using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models.ProjectManagement.Project;

public sealed partial class Cp77Project : IEquatable<Cp77Project>, ICloneable
{
    public const string ProjectFileExtension = ".cpmodproj";

    public Cp77Project(string location, string name, string modName, Dictionary<DateTime, string> openProjectFiles)
    {
        Location = location;
        Name = name;
        ModName = modName;
        OpenProjectFiles = openProjectFiles;
    }

    public Cp77Project(string location, string name, string modName) : this(location, name, modName, [])
    {
        // use other constructor
    }

    public string Name { get; set; }

    /// <summary>
    /// Relative paths to currently open files. Will be written to <see cref="ProjectFileExtension"/> file.
    /// </summary>
    public Dictionary<DateTime, string> OpenProjectFiles { get; set; } = [];

    /// <summary>
    /// Location of active project (the folder containing the .cdproj file)
    /// </summary>
    public string Location { get; set; }

    public string ModName { get; set; }

    public int ActiveTab { get; set; } = 0;

    public string? Author { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Version { get; set; }

    public static GameType GameType => GameType.Cyberpunk2077;


    /// <summary>
    /// Returns all files inside <see cref="FileDirectory"/>
    /// </summary>
    public List<string> Files
    {
        get
        {
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }

            return Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories)
                .Select(file => file[(FileDirectory.Length + 1)..])
                .ToList();
        }
    }


    /// <summary>
    /// Returns all files inside <see cref="ModDirectory"/>
    /// </summary>
    public List<string> ModFiles
    {
        get
        {
            if (!Directory.Exists(ModDirectory))
            {
                Directory.CreateDirectory(ModDirectory);
            }

            return Directory.EnumerateFiles(ModDirectory, "*", SearchOption.AllDirectories)
                .Select(file => file[(ModDirectory.Length + 1)..])
                .ToList();
        }
    }

    /// <summary>
    /// Returns all files inside <see cref="ResourcesDirectory"/>
    /// </summary>
    public List<string> ResourceFiles
    {
        get
        {
            if (!Directory.Exists(ResourcesDirectory))
            {
                Directory.CreateDirectory(ResourcesDirectory);
            }

            return Directory.EnumerateFiles(ResourcesDirectory, "*", SearchOption.AllDirectories)
                .Select(file => file[(ResourcesDirectory.Length + 1)..])
                .ToList();
        }
    }


    /// <summary>
    /// Returns all files inside <see cref="RawDirectory"/>
    /// </summary>
    public List<string> RawFiles
    {
        get
        {
            if (!Directory.Exists(RawDirectory))
            {
                Directory.CreateDirectory(RawDirectory);
            }

            return Directory.EnumerateFiles(RawDirectory, "*", SearchOption.AllDirectories)
                .Select(file => file[(RawDirectory.Length + 1)..])
                .ToList();
        }
    }


    /// <summary>
    /// Absolute path to root level directory (where the .csproj file is)
    /// </summary>
    public string ProjectDirectory
    {
        get
        {
            var oldDir = Path.Combine(Path.GetDirectoryName(Location).NotNull(), Name).NotNull();
            return Directory.Exists(oldDir) ? oldDir : Path.GetDirectoryName(Location).NotNull();
        }
    }

    /// <summary>
    /// Absolute path to /source
    /// </summary>
    public string FileDirectory
    {
        get
        {
            var oldDir = Path.Combine(ProjectDirectory, "files");
            if (Directory.Exists(oldDir))
            {
                return oldDir;
            }

            var dir = Path.Combine(ProjectDirectory, "source");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Absolute path to /source/archive
    /// </summary>
    public string ModDirectory
    {
        get
        {
            var oldDir = Path.Combine(FileDirectory, "Mod");
            if (Directory.Exists(oldDir))
            {
                return oldDir;
            }

            var dir = Path.Combine(FileDirectory, "archive");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /_backups
    /// </summary>
    public string BackupDirectory
    {
        get
        {
            var dir = Path.Combine(ProjectDirectory, "_backups");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Absolute path to /source/raw
    /// </summary>
    public string RawDirectory
    {
        get
        {
            var oldDir = Path.Combine(FileDirectory, "Raw");
            if (DirExistsMatchCase(oldDir))
            {
                return oldDir;
            }

            var dir = Path.Combine(FileDirectory, "raw");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }


    /// <summary>
    /// Absolute path to /source/customSounds
    /// </summary>
    public string SoundDirectory
    {
        get
        {
            var dir = Path.Combine(FileDirectory, "customSounds");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Absolute path to /source/resources
    /// </summary>
    public string ResourcesDirectory
    {
        get
        {
            var dir = Path.Combine(FileDirectory, "resources");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }


    /// <summary>
    /// Path to /source/resources/r6/tweaks
    /// </summary>
    public string ResourceTweakDirectory
    {
        get
        {
            var dir = Path.Combine(ResourcesDirectory, "r6", "tweaks", Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /source/resources/r6/scripts
    /// </summary>
    public string ResourceScriptsDirectory
    {
        get
        {
            var dir = Path.Combine(ResourcesDirectory, "r6", "scripts", Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed
    /// </summary>
    public string PackedRootDirectory
    {
        get
        {
            var dir = Path.Combine(ProjectDirectory, "packed");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed/mods
    /// </summary>
    public string PackedRedModDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRootDirectory, "mods", ModName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed/mods
    /// </summary>
    public string PackedLegacyModDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRootDirectory, "archive", "pc", "mod");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }


    #region project_state_files

    private const string s_projectFilesDirName = ".projectFiles";
    private const string s_projectTreeStateFileName = "fileTreeState.json";

    /// <summary>
    /// Path to <see cref="ProjectDirectory"/>/<see cref="s_projectFilesDirName"/>, where we store temp files
    /// with interface states (e.g. file tree, open files, etc.)
    ///
    /// If we create many more files, we may need to expose this and handle the paths somewhere else
    /// </summary>
    private string InterfaceStateFileDirectory
    {
        get
        {
            var directory = Path.Combine(ProjectDirectory, s_projectFilesDirName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return directory;
        }
    }

    /// <summary>
    /// Path to <see cref="InterfaceStateFileDirectory"/>/<see cref="s_projectTreeStateFileName"/>
    /// where we store the serialized project explorer tree state
    /// </summary>
    public string InterfaceProjectTreeStatePath
    {
        get
        {
            var oldPath = Path.Combine(ProjectDirectory, s_projectTreeStateFileName);
            var newPath = Path.Combine(InterfaceStateFileDirectory, s_projectTreeStateFileName);
            if (File.Exists(oldPath))
            {
                if (!File.Exists(newPath))
                {
                    File.Move(oldPath, newPath, true);
                }
                else
                {
                    File.Delete(oldPath);
                }
            }

            if (!File.Exists(newPath))
            {
                File.WriteAllLines(newPath, ["{}"]);
            }

            return newPath;
        }
    }

    #endregion

    /// <summary>
    /// Path to /packed/archive/pc/mod or /packed/mods
    /// </summary>
    public string GetPackedArchiveDirectory(bool isRedMod)
    {
        var dir = isRedMod ? Path.Combine(PackedRedModDirectory, "archives") : Path.Combine(PackedRootDirectory, "archive", "pc", "mod");

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    /// <summary>
    /// Path to /packed/customSounds
    /// </summary>
    public string PackedSoundsDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRedModDirectory, "customSounds");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed/r6/tweaks
    /// </summary>
    public string PackedTweakDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRootDirectory, "r6", "tweaks");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }


    // Methods

    public static bool DirExistsMatchCase(string path)
    {
        // If it definitely doesn't return false
        if (!Directory.Exists(path))
        {
            return false;
        }

        // Figure out if the case (of the final part) is the same
        var thisDir = Path.GetFileName(path);
        var actualDir = Path.GetFileName(Directory.GetDirectories(Path.GetDirectoryName(path).NotNull(), thisDir)[0]);
        return thisDir == actualDir;
    }

    public void CreateDefaultDirectories()
    {
        // create top-level directories
        _ = ModDirectory;
        _ = RawDirectory;
        _ = ResourcesDirectory;
    }

    public (string, string) SplitFilePath(string fullPath) =>
        (GetAbsoluteSubDirPath(fullPath), GetRelativePath(fullPath));

    /// <returns>The absolute path to the subdirectory containing the file, e.g. C:\CyberpunkFiles\...\source\archive</returns>
    public string GetAbsoluteSubDirPath(string absolutePath)
    {
        if (absolutePath.StartsWith(ModDirectory, StringComparison.Ordinal) ||
            absolutePath.StartsWith(s_relativeModDir))
        {
            return ModDirectory;
        }

        if (absolutePath.StartsWith(RawDirectory, StringComparison.Ordinal) ||
            absolutePath.StartsWith(s_relativeRawDir))
        {
            return RawDirectory;
        }

        if (absolutePath.StartsWith(PackedRootDirectory, StringComparison.Ordinal) ||
            absolutePath.StartsWith(s_relativePackedDir))
        {
            return PackedRootDirectory;
        }

        if (absolutePath.StartsWith(ResourcesDirectory, StringComparison.Ordinal))
        {
            return ResourcesDirectory;
        }

        if (absolutePath.StartsWith(FileDirectory, StringComparison.Ordinal))
        {
            return FileDirectory;
        }

        return "";
    }

    private static bool IsResourceFile(string fileNameOrPath) =>
        Path.GetExtension(fileNameOrPath) switch
        {
            ".xl" => true,
            ".yaml" => true,
            ".yml" => true,
            ".lua" => true,
            ".reds" => true,
            _ => false,
        };


    public string GetAbsolutePath(string relativeOrAbsolutePath)
    {
        if (Path.IsPathRooted(relativeOrAbsolutePath))
        {
            return relativeOrAbsolutePath;
        }

        var (prefix, relativePath) = SplitFilePath(relativeOrAbsolutePath);
        prefix = prefix.Replace(ProjectDirectory, "");

        if (relativePath == relativeOrAbsolutePath)
        {
            return Path.Join(ModDirectory, prefix, relativePath);
        }

        if (prefix != "")
        {
            return Path.Join(FileDirectory, prefix, relativePath);
        }

        return Path.Join(prefix, relativePath);
    }


    private static readonly string s_tweakSubfolder = Path.Join("r6", "tweaks");

    public string GetAbsolutePath(string fileName, string? rootRelativeFolder)
    {
        rootRelativeFolder ??= "";
        switch (Path.GetExtension(fileName))
        {
            case ".yaml" when string.IsNullOrEmpty(rootRelativeFolder):
                rootRelativeFolder = s_tweakSubfolder;
                break;
            case ".yaml" when !rootRelativeFolder.StartsWith(s_tweakSubfolder):
                rootRelativeFolder = Path.Join(s_tweakSubfolder, rootRelativeFolder);
                break;
            default:
                break;
        }

        return Path.GetExtension(fileName) switch
        {
            ".xl" => Path.Join(ResourcesDirectory, fileName),
            ".yaml" => Path.Join(ResourcesDirectory, rootRelativeFolder, fileName),
            _ => Path.Join(ModDirectory, rootRelativeFolder, fileName)
        };
    }

    private const string s_relativeModDir = "wkitmoddir";
    private const string s_relativeRawDir = "wkitrawdir";
    private const string s_relativePackedDir = "wkitpackeddir";

    public string GetRelativePath(string absolutePath)
    {
        if (absolutePath.Equals(FileDirectory, StringComparison.Ordinal))
        {
            return "";
        }

        // hack so that we get proper hashes
        if (absolutePath.Equals(ModDirectory, StringComparison.Ordinal))
        {
            return s_relativeModDir;
        }

        if (absolutePath.Equals(RawDirectory, StringComparison.Ordinal))
        {
            return s_relativeRawDir;
        }

        if (absolutePath.Equals(PackedRootDirectory, StringComparison.Ordinal))
        {
            return s_relativePackedDir;
        }

        if (GetAbsoluteSubDirPath(absolutePath) is string s && s != "")
        {
            return absolutePath[(s.Length + 1)..];
        }

        return absolutePath;
    }



    // Conversions

    public FileSystemArchive AsArchive() => new(this);

    #region implements ICloneable

    public object Clone()
    {
        Cp77Project clone = new(Location, Name, ModName)
        {
            Author = Author, Email = Email, Version = Version, OpenProjectFiles = OpenProjectFiles
        };
        return clone;
    }

    #endregion implements ICloneable

    #region implements IEquatable

    public bool Equals(Cp77Project? other) =>
        other is not null && (ReferenceEquals(this, other) || string.Equals(Location, other.Location));

    public override bool Equals(object? obj) =>
        obj is not null && (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((Cp77Project)obj));

    public override int GetHashCode() => Location != null ? Location.GetHashCode() : 0;

    public ModInfo GetInfo()
    {
        ModInfo modInfo = new(ModName, Version ?? "1.0") { Description = Description, };
        return modInfo;
    }

    #endregion implements IEquatable

    public override string ToString() => Location;

    public ResourcePath GetResourcePathFromRoot(string fullPath)
    {
        var relPath = GetRelativePath(fullPath);
        if (ulong.TryParse(Path.GetFileNameWithoutExtension(relPath), out var hash))
        {
            return hash;
        }

        return relPath;
    }

    public ResourcePath GetRelativeResourcePath(string fullPath)
    {
        var ret = new ResourcePath();
        if (!fullPath.StartsWith(ModDirectory, StringComparison.Ordinal))
        {
            return ret;
        }


        var relPath = GetRelativePath(fullPath);
        if (ulong.TryParse(Path.GetFileNameWithoutExtension(relPath), out var hash))
        {
            return hash;
        }

        return relPath;
    }

    public async Task<IDictionary<string, List<string>>> GetAllReferencesAsync(
        IProgressService<double> progressService,
        ILoggerService loggerService,
        List<string> filePaths)
    {
        if (filePaths.Count == 0)
        {
            filePaths.AddRange(ModFiles);
        }

        SortedDictionary<string, List<string>> references = new();

        progressService?.Report(0);
        var totalFiles = filePaths.Count;
        var processedFiles = 0;
        var progressIncrement = totalFiles > 0 ? 100.0 / totalFiles : 100;

        await Task.Run(() =>
        {
            Parallel.ForEach(filePaths, filePath =>
            {
                try
                {
                    CR2WFile? cr2WFile;
                    List<string> resourcePaths = [];

                    using (var fs = File.Open(GetAbsolutePath(filePath), FileMode.Open))
                    using (var cr = new CR2WReader(fs))
                    {
                        if (cr.ReadFile(out cr2WFile) != RED4.Archive.IO.EFileReadErrorCodes.NoError || cr2WFile is null)
                        {
                            return;
                        }

                        // check if it's a factory
                        if (cr2WFile.RootChunk is C2dArray { CompiledData: CArray<CArray<CString>> data })
                        {
                            // Grab the second string from CompiledData, if it's a depotPath
                            var paths = data
                                .Where(c => c.Count == 3).Select(cStrings => cStrings[1])
                                .Where(potentialDepotPath => potentialDepotPath.GetString().Contains(Path.DirectorySeparatorChar))
                                .Select(potentialDepotPath => (string)potentialDepotPath).ToList();
                            resourcePaths.AddRange(paths);
                        }
                        else
                        {
                            foreach (var redRef in cr2WFile.FindType(typeof(IRedRef)).Select(r => r.Value)
                                         .OfType<IRedRef>())
                            {
                                if (redRef.DepotPath == ResourcePath.Empty)
                                {
                                    continue;
                                }

                                resourcePaths.AddRange(
                                    ResolveResourcePaths(redRef.DepotPath.GetResolvedText(), cr2WFile));
                            }

                            // Check redStrings that contain resource paths. This happens inside quest files.
                            foreach (var result in cr2WFile.FindType(typeof(IRedString))
                                         .Select(r => r.Value)
                                         .OfType<IRedString>()
                                         .Select(r => r.GetString())
                                         .Where(s => s?.IsFilePath() == true)
                                    )
                            {
                                resourcePaths.AddRange(ResolveResourcePaths(result, cr2WFile));
                            }

                            foreach (var cr2WImport in cr2WFile.Info.Imports)
                            {
                                resourcePaths.AddRange(ResolveResourcePaths(cr2WImport.DepotPath.GetResolvedText(),
                                    cr2WFile));
                            }
                        }
                    }

                    if (resourcePaths.Count <= 0)
                    {
                        return;
                    }

                    lock (references)
                    {
                        references.Add(filePath, resourcePaths.Distinct().ToList());
                    }
                }
                catch (Exception e)
                {
                    loggerService.Error($"Results will be incomplete: Failed to read {filePath} ({e.Message})");
                }

                // Update progress
                var currentProgress = Interlocked.Increment(ref processedFiles) * progressIncrement;
                progressService?.Report(currentProgress);

            });

            // Get file paths from resource files. Yes, with a regex - parsing them would be way more effort
            Parallel.ForEach(
                Files.Where(f => f.EndsWith(".xl") || f.EndsWith(".yaml") || f.EndsWith(".lua") || f.EndsWith(".reds")),
                filePath =>
            {
                var absolutePath = Path.Combine(FileDirectory, filePath);
                if (!File.Exists(absolutePath))
                {
                    return;
                }

                var fileContent = File.ReadAllText(absolutePath);

                // Get anything with double or single slashes, then replace double slashes
                var refs = ResourceFilePathsRegex().Matches(fileContent).Where(m => m.Success)
                    .Select(m => m.Value.Replace(@"\\", @"\").Replace(@"/", @"\"))
                    .ToList();

                if (refs.Count <= 0)
                {
                    return;
                }

                lock (references)
                {
                    if (!references.TryAdd(filePath, refs))
                    {
                        references[filePath].AddRange(refs);
                    }
                }
            });
        });

        // Order entries by file name
        return references.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);

        // Deal with ArchiveXL substitution and empty/falsy strings
        static IEnumerable<string> ResolveResourcePaths(string? resourcePath, CR2WFile cr2WFile)
        {
            if (string.IsNullOrEmpty(resourcePath))
            {
                return [];
            }

            if (!resourcePath.StartsWith(ArchiveXlHelper.ArchiveXLSubstitutionPrefix))
            {
                return [resourcePath];
            }

            if (cr2WFile.RootChunk is not CMesh mesh)
            {
                return ArchiveXlHelper.ResolveDynamicPaths(resourcePath);
            }

            // TODO: We need to pass the correct material name for the substitution here
            return ArchiveXlHelper.ResolveMaterialSubstitutions(resourcePath, mesh.Appearances);
        }
    }

    private static readonly List<string> s_allowedDeadReferencePartials =
    [
        // in psiberx we trust
        @"archive_xl\characters\common",
        @"archive_xl\characters\head\player_base_heads",
        @"archive_xl\common\null.morphtarget",
        // xbae's photo mode anims - will do nothing if not present
        @"base\animations\xbaebsae\pm_facials",
        // CDPR originals - they have them in all of their NPCS, surely it'll be fine to just ignore them
        @"base\fx\characters\npc\kerenzikov",
        @"base\animations\anim_motion_database\cover_action.csv",
        @"ep1\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_death.anims",
    ];

    public Task<IDictionary<string, List<string>>> ScanForBrokenReferencePathsAsync(IArchiveManager archiveManager,
        ILoggerService loggerService, IProgressService<double> progressService) =>
        ScanForBrokenReferencePathsAsync(archiveManager, loggerService, progressService, new SortedDictionary<string, List<string>>());

    public async Task<IDictionary<string, List<string>>> ScanForBrokenReferencePathsAsync(IArchiveManager archiveManager,
        ILoggerService loggerService, IProgressService<double> progressService, IDictionary<string, List<string>> references)
    {
        if (references.Count == 0)
        {
            references.AddRange(await GetAllReferencesAsync(progressService, loggerService, []));
        }

        SortedDictionary<string, List<string>> brokenReferences = new();

        progressService.IsIndeterminate = true;
        progressService.Report(0);
        var totalFiles = references.Count;
        var processedFiles = 0;
        var progressIncrement = totalFiles > 0 ? 100.0 / totalFiles : 100;

        await Task.Run(() =>
        {
            Parallel.ForEach(references, (kvp, state) =>
            {
                // path is either not in the project/game, or it is the file itself
                var pathsWithError = kvp.Value
                    .Distinct()
                    // Some dead references are allowed - e.g. xbae's facial animation pack
                    .Where(filePath => s_allowedDeadReferencePartials.All(part => !filePath.StartsWith(part)))
                    .Where(filePath =>
                        // Warn if file references itself
                        filePath == kvp.Key ||
                        // Warn if file is not in same mod or basegame
                        (!ModFiles.Contains(filePath) && archiveManager.GetGameFile(filePath, true,
                            true) is null))
                    .ToList();

                if (pathsWithError.Count > 0)
                {
                    lock (brokenReferences)
                    {
                        brokenReferences.Add(kvp.Key, pathsWithError);
                    }
                }

                // Update progress
                var currentProgress = Interlocked.Increment(ref processedFiles) * progressIncrement;
                progressService.IsIndeterminate = false;
                progressService.Report(currentProgress);
            });
        });
        progressService.Completed();
        return brokenReferences;
    }

    /// <summary>
    /// Will match any file paths with forward or backward slashes and a file extension
    /// </summary>
    /// <example>
    /// <code>
    /// folder/subfolder/atelier_icon.inkatlas
    /// folder\subfolder\atelier_icon.inkatlas
    /// folder\\subfolder\\atelier_icon.inkatlas
    /// </code>
    /// </example>
    [GeneratedRegex(@"(((\w+\/)|(\w+\\\\?))+\w+\.\w+)")]
    private static partial Regex ResourceFilePathsRegex();

    private int _numEmptyFolders = 0;

    public void DeleteEmptyFolders(ILoggerService loggerService)
    {
        _numEmptyFolders = 0;
        DeleteEmptyFolders(ModDirectory);
        loggerService.Success($"Deleted {_numEmptyFolders} empty folders");
    }

    private void DeleteEmptyFolders(string directory)
    {
        foreach (var subdirectory in Directory.GetDirectories(directory))
        {
            DeleteEmptyFolders(subdirectory);

            if (Directory.GetFiles(subdirectory).Length == 0 && Directory.GetDirectories(subdirectory).Length == 0)
            {
                _numEmptyFolders += 1;
                Directory.Delete(subdirectory);
            }
        }
    }

    /// <summary>
    /// Gets all folders under a given directory as list. Defaults to mod directory.
    /// <param name="subdirParam">Pass <see cref="ModDirectory"/>, <see cref="ResourcesDirectory"/>, <see cref="RawDirectory"/></param>
    /// </summary>
    public List<string> GetAllFolders(string? subdirParam)
    {
        var filesToSearch = ModFiles;
        var subdirectory = subdirParam ?? ModDirectory;

        if (subdirectory == RawDirectory)
        {
            filesToSearch = RawFiles;
        }
        else if (subdirectory == ResourcesDirectory)
        {
            filesToSearch = ResourceFiles;
        }

        return filesToSearch
            .Select(Path.GetDirectoryName)
            .Where(f => f is not null && f != subdirectory &&
                        Directory.Exists(Path.Combine(subdirectory, f)))
            .Select(f => f!)
            .Distinct()
            .ToList();
    }
}

