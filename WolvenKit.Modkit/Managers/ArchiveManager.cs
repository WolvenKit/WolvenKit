using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using DynamicData;
using DynamicData.Kernel;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using Path = System.IO.Path;

namespace WolvenKit.RED4.CR2W.Archive
{
    public class ArchiveManager : RED4ArchiveManager
    {
        #region Fields

        public const string Version = "1.1";

        private readonly IHashService _hashService;

        private readonly Red4ParserService _wolvenkitFileService;

        private readonly ILoggerService _logger;

        private readonly SourceList<RedFileSystemModel> _rootCache;

        private readonly SourceList<RedFileSystemModel> _modCache;
        private bool _isManagerLoading;
        private bool _isManagerLoaded;

        private static readonly List<string> s_loadOrder = new() { "memoryresident", "ep1", "basegame", "audio", "lang" };

        #endregion Fields

        #region Constructors

        public ArchiveManager(IHashService hashService, Red4ParserService wolvenkitFileService, ILoggerService logger)
        {
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _logger = logger;

            _rootCache = new SourceList<RedFileSystemModel>();
            _modCache = new SourceList<RedFileSystemModel>();
        }

        #endregion Constructors

        #region properties

        public override bool IsManagerLoading
        {
            get => _isManagerLoading;
            set => SetProperty(ref _isManagerLoading, value);
        }

        public override bool IsManagerLoaded
        {
            get => _isManagerLoaded;
            set => SetProperty(ref _isManagerLoaded, value);
        }


        public override SourceCache<IGameArchive, string> Archives { get; set; } = new(x => x.ArchiveAbsolutePath);

        public override SourceCache<IGameArchive, string> ModArchives { get; set; } = new(x => x.ArchiveAbsolutePath);


        public IObservable<IChangeSet<IGameArchive, string>> ConnectArchives() => Archives.Connect();


        public override IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot() => _rootCache.Connect();

        public override IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot() => _modCache.Connect();

        public override EArchiveType TypeName => EArchiveType.Archive;

        #endregion properties

        #region methods

        //[ProtoAfterDeserialization]
        //public void AfterDeserializationCallback()
        //{
        //    foreach (var archive in Archives.Values)
        //    {
        //        var fileEntries = (archive as Archive).Index.FileEntries.Values;
        //        foreach (var file in fileEntries)
        //        {
        //            file.Archive = archive;
        //            archive.Files.Add(file.Key, file);
        //            file.SetHashService(_hashService);
        //        }
        //        var deps = (archive as Archive).Index.Dependencies;
        //        foreach (var d in deps)
        //        {
        //            d.SetHashService(_hashService);
        //        }
        //    }

        //    Items.Edit(innerList =>
        //    {
        //        innerList.Clear();
        //        innerList.AddOrUpdate(Archives.Values.SelectMany(_ => _.Files));
        //    });

        //    RebuildRootNode();
        //}

        #region sorting

        private static int CompareArchives(string? x, string? y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x is null)
            {
                return -1;
            }

            if (y is null)
            {
                return 1;
            }

            var baseX = Path.GetFileName(x);
            baseX = baseX[..baseX.IndexOf("_", StringComparison.Ordinal)];

            var baseY = Path.GetFileName(y);
            baseY = baseY[..baseY.IndexOf("_", StringComparison.Ordinal)];

            var retVal = s_loadOrder.IndexOf(baseX).CompareTo(s_loadOrder.IndexOf(baseY));
            return retVal != 0 ? retVal : string.Compare(x, y, StringComparison.Ordinal);
        }

        #endregion

        #region loading

        /// <summary>
        /// Loads all archives from a folder
        /// </summary>
        /// <param name="archiveDir"></param>
        public override void LoadFromFolder(DirectoryInfo archiveDir)
        {
            if (!archiveDir.Exists)
            {
                return;
            }

            var redModFolder = archivedir.Name.Contains(Path.DirectorySeparatorChar + "mods" + Path.DirectorySeparatorChar);

            IsManagerLoading = true;
            var archiveFiles = Directory.GetFiles(archivedir.FullName, "*.archive",
                new EnumerationOptions { RecurseSubdirectories = redModFolder}).ToList();

            archiveFiles.Sort(CompareArchives);

            foreach (var file in archiveFiles)
            {
                LoadArchive(file);
            }

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        /// <summary>
        /// Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="executable"></param>
        /// <param name="rebuildtree"></param>
        public override void LoadGameArchives(FileInfo executable, bool rebuildtree = true)
        {
            var di = executable.Directory;
            if (di?.Parent?.Parent is null)
            {
                return;
            }
            if (!di.Exists)
            {
                return;
            }

            IsManagerLoading = true;

            var sw = new Stopwatch();
            var sw2 = new Stopwatch();
            sw.Start();
            sw2.Start();

            var cnt = 0;

            var baseDir = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "content");
            var baseFiles = Directory.GetFiles(baseDir, "*.archive").ToList();
            baseFiles.Sort(CompareArchives);

            var totalCnt = baseFiles.Count;

            var ep1Dir = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "ep1");
            if (Directory.Exists(ep1Dir))
            {
                var ep1Files = Directory.GetFiles(ep1Dir, "*.archive").ToList();
                ep1Files.Sort(CompareArchives);

                totalCnt += ep1Files.Count;

                foreach (var file in ep1Files)
                {
                    sw.Restart();

                    LoadArchive(file, EArchiveSource.EP1);
                    cnt++;

                    _logger.Debug($"Loaded archive {Path.GetFileName(file)} {cnt}/{totalCnt} in {sw.ElapsedMilliseconds}ms");
                }
            }

            foreach (var file in baseFiles)
            {
                sw.Restart();

                LoadArchive(file, EArchiveSource.Base);
                cnt++;

                _logger.Debug($"Loaded archive {Path.GetFileName(file)} {cnt}/{totalCnt} in {sw.ElapsedMilliseconds}ms");
            }

            if (rebuildtree)
            {
                sw.Restart();

                RebuildGameRoot(_hashService);

                _logger.Debug($"Finished rebuilding root in {sw.ElapsedMilliseconds}ms");

                _rootCache.Edit(innerCache =>
                {
                    innerCache.Clear();
                    innerCache.Add(RootNode.NotNull());
                });
            }

            sw.Stop();
            sw2.Stop();
            _logger.Success($"Archive Manager loaded in {sw2.ElapsedMilliseconds}ms");

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        /// <summary>
        /// Load a single bundle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="source"></param>
        public override void LoadArchive(string path, EArchiveSource source = EArchiveSource.Unknown)
        {
            if (Archives.Lookup(path).HasValue)
            {
                return;
            }

            var archive = _wolvenkitFileService.ReadRed4Archive(path, _hashService);

            if (archive == null)
            {
                _logger.Warning($"Unable to load game archive: {path}");
                return;
            }

            archive.Source = source;
            Archives.AddOrUpdate(archive);
        }

        /// <summary>
        /// Load a single mod bundle
        /// </summary>
        /// <param name="filename">
        /// file to process
        /// </param>
        /// <param name="analyzeFiles"></param>
        public override void LoadModArchive(string filename, bool analyzeFiles = true)
        {
            if (ModArchives.Lookup(filename).HasValue)
            {
                return;
            }

            var archive = _wolvenkitFileService.ReadRed4Archive(filename, _hashService);

            if (archive == null)
            {
                _logger.Warning($"Unable to load mod archive: {filename}");
                return;
            }

            archive.Source = EArchiveSource.Mod;

            if (analyzeFiles)
            {
                var importError = false;
                foreach (var (_, gameFile) in archive.Files)
                {
                    try
                    {
                        using var ms = new MemoryStream();
                        archive.ExtractFile(gameFile, ms);

                        if (_wolvenkitFileService.TryReadRed4FileHeaders(ms, out var info))
                        {
                            info.GetImports();
                        }
                    }
                    catch (Exception)
                    {
                        importError = true;
                        _logger.Debug($"Error while loading the following mod file: {gameFile.FileName}");
                    }
                }
                archive.ReleaseFileHandle();

                if (importError)
                {
                    _logger.Warning($"Error while loading the following mod archive: {filename}");
                }
            }

            ModArchives.AddOrUpdate(archive);
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        public override void LoadModsArchives(FileInfo executable, bool analyzeFiles = true)
        {
            var di = executable.Directory;
            if (di?.Parent?.Parent is null)
            {
                return;
            }
            if (!di.Exists)
            {
                return;
            }

            IsManagerLoading = true;

            ModArchives.Clear();

            var redModBasePath = Path.Combine(di.Parent.Parent.FullName, "mods");
            var legacyModPath = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "mod");
            var redModCache = Path.Combine(di.Parent.Parent.FullName, "r6", "cache", "modded");
            var redModModsJSON = Path.Combine(redModCache, "mods.json");

            var redModFiles = new List<string>();
            if (File.Exists(redModModsJSON)) {
                var modsJSON = File.Open(redModModsJSON, FileMode.Open);

                var redModElement = JsonSerializer.Deserialize<JsonElement>(modsJSON);
                var modsArr = redModElement.GetProperty("mods").EnumerateArray();

                foreach ( var mod in modsArr )
                {
                    // get the properties we care able
                    string folder = mod.GetProperty("folder").GetString().NotNull();
                    bool enabled = mod.GetProperty("enabled").GetBoolean();
                    bool deployed = mod.GetProperty("deployed").GetBoolean();

                    if (!enabled)
                    {
                        _logger.Info($"Skipping disabled REDMod: {folder}");
                        continue;
                    }
                    else
                    {
                        if (!deployed )
                        {
                            _logger.Warning($"REDMod ({folder}) is not deployed, but assets will be available in the Asset Browser.");
                        }

                        var redModArchivesDir = Path.Combine(redModBasePath, folder, "archives");
                        if (Directory.Exists(redModArchivesDir))
                        {
                            // maybe a better way to do this?
                            var modArchives = Directory.GetFiles(redModArchivesDir, "*.archive", SearchOption.TopDirectoryOnly).ToList();
                            modArchives.Sort(string.CompareOrdinal);
                            modArchives.Reverse();

                            redModFiles.AddRange(modArchives);
                        }
                    }
                }
            }

            var legacyFiles = new List<string>();
            if (Directory.Exists(legacyModPath))
            {
                foreach (var archiveFile in Directory.GetFiles(legacyModPath, "*.archive", SearchOption.TopDirectoryOnly))
                {
                    legacyFiles.Add(archiveFile);
                }
            }

            legacyFiles.Sort(string.CompareOrdinal);
            legacyFiles.Reverse();

            // load legacy mods first
            foreach (var file in legacyFiles)
            {
                LoadModArchive(file, analyzeFiles);
            }

            // load REDmod mods second
            foreach (var file in redModFiles)
            {
                LoadModArchive(file, analyzeFiles);
            }

            foreach (var modArchive in ModArchives.Items)
            {
                modArchive.ArchiveRelativePath = Path.GetRelativePath(di.Parent.Parent.FullName, modArchive.ArchiveAbsolutePath);
            }

            RebuildModRoot();

            _modCache.Edit(innerCache =>
            {
                innerCache.Clear();
                innerCache.Add(ModRoots);
            });

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        public override void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true)
        {
            if (!Directory.Exists(archiveBasePath))
            {
                return;
            }

            IsManagerLoading = true;

            var files = new List<string>();
            foreach (var archiveFile in Directory.GetFiles(archiveBasePath, "*.archive", SearchOption.AllDirectories))
            {
                files.Add(archiveFile);
            }

            if (files.Count == 0)
            {
                return;
            }

            files.Sort(string.CompareOrdinal);
            files.Reverse();

            foreach (var file in files)
            {
                LoadModArchive(file, analyzeFiles);
            }

            foreach (var modArchive in ModArchives.Items)
            {
                if (!files.Contains(modArchive.ArchiveAbsolutePath))
                {
                    continue;
                }

                modArchive.ArchiveRelativePath = Path.GetRelativePath(archiveBasePath, modArchive.ArchiveAbsolutePath);
            }

            RebuildModRoot();

            _modCache.Edit(innerCache =>
            {
                innerCache.Clear();
                innerCache.Add(ModRoots);
            });

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        #endregion

        /// <summary>
        /// Get files grouped by extension in all archives
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles() =>
            IsModBrowserActive
            ? ModArchives.Items
              .SelectMany(_ => _.Files.Values)
              .GroupBy(_ => _.Extension)
              .ToDictionary(_ => _.Key, _ => _.Select(x => x))
            : Archives.Items
              .SelectMany(_ => _.Files.Values)
              .GroupBy(_ => _.Extension)
              .ToDictionary(_ => _.Key, _ => _.Select(x => x));

        /// <summary>
        /// Get all files in all archives
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<FileEntry> GetFiles() =>
            IsModBrowserActive
            ? ModArchives.Items
                .SelectMany(_ => _.Files.Values)
                .Cast<FileEntry>()
            : Archives.Items
                .SelectMany(_ => _.Files.Values)
                .Cast<FileEntry>();

        /// <summary>
        /// Checks if a file with the given hash exists in the archivemanager
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool ContainsFile(ulong hash) => Lookup(hash).HasValue;

        /// <summary>
        /// Look up a hash in the ArchiveManager
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public override Optional<IGameFile> Lookup(ulong hash)
        {
            return IsModBrowserActive
                ? Optional<IGameFile>.ToOptional(
                    (from item in ModArchives.Items where item.Files.ContainsKey(hash) select item.Files[hash])
                .FirstOrDefault())
                : Optional<IGameFile>.ToOptional(
                    (from item in Archives.Items where item.Files.ContainsKey(hash) select item.Files[hash])
                .FirstOrDefault());
        }

        /// <summary>
        /// Retrieves a directory with the given fullpath
        /// </summary>
        /// <param name="fullpath"></param>
        /// <param name="expandAll"></param>
        /// <returns></returns>
        public override RedFileSystemModel? LookupDirectory(string fullpath, bool expandAll = false)
        {
            if (IsModBrowserActive)
            {
                foreach (var item in ModRoots)
                {
                    var result = LookupDirectory(fullpath, item, expandAll);
                    if (result is not null)
                    {
                        return result;
                    }
                }
                return null;
            }
            else
            {
                return LookupDirectory(fullpath, RootNode.NotNull(), expandAll);
            }
        }

        private static RedFileSystemModel? LookupDirectory(string fullpath, RedFileSystemModel currentDir, bool expandAll = false)
        {
            var splits = fullpath.Split(Path.DirectorySeparatorChar);
            if (expandAll)
            {
                currentDir.IsExpanded = true;
            }

            for (var i = 0; i < splits.Length; i++)
            {
                var s = splits[i];

                if (currentDir.Directories.ContainsKey(s))
                {
                    currentDir = currentDir.Directories[s];
                    if (expandAll)
                    {
                        currentDir.IsExpanded = true;
                    }
                    if (i == splits.Length - 1)
                    {
                        return currentDir;
                    }
                }
                else
                {
                    return i == splits.Length - 1 ? currentDir : null;
                }
            }
            return null;
        }

        #endregion methods
    }
}
