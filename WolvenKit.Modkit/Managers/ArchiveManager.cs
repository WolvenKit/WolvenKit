using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using DynamicData.Kernel;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.Archive
{
    public partial class ArchiveManager : ObservableObject, IArchiveManager
    {
        #region Fields

        protected readonly IHashService _hashService;
        protected readonly Red4ParserService _wolvenkitFileService;
        protected readonly ILoggerService _logger;

        [ObservableProperty] private bool _isManagerLoading;
        [ObservableProperty] private bool _isManagerLoaded;

        private static readonly List<string> s_loadOrder = new() { "memoryresident", "ep1", "basegame", "audio", "lang" };

        #endregion Fields

        #region Constructors

        public ArchiveManager(IHashService hashService, Red4ParserService wolvenkitFileService, ILoggerService logger)
        {
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _logger = logger;
        }

        #endregion Constructors

        #region properties

        public SourceCache<IGameArchive, string> Archives { get; set; } = new(x => x.ArchiveAbsolutePath);

        public IGameArchive? ProjectArchive { get; set; }

        #endregion properties

        #region methods

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
        /// Load every non-mod bundle it can find in ..\..\content and ..\..\DLC
        /// </summary>
        /// <param name="executable"></param>
        public virtual void LoadGameArchives(FileInfo executable)
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
            var baseFiles = Directory.GetFiles(baseDir, "*.archive")
                .Where(CheckFileName)
                .ToList();
            baseFiles.Sort(CompareArchives);

            var totalCnt = baseFiles.Count;

            var ep1Dir = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "ep1");
            if (Directory.Exists(ep1Dir))
            {
                var ep1Files = Directory.GetFiles(ep1Dir, "*.archive")
                    .Where(CheckFileName)
                    .ToList();
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

            sw.Stop();
            sw2.Stop();
            _logger.Success($"Archive Manager loaded in {sw2.ElapsedMilliseconds}ms");

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        private bool CheckFileName(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            var index = fileName.IndexOf('_');

            var valid = false;
            if (index != -1)
            {
                valid = s_loadOrder.Contains(fileName[..index]);
            }

            if (!valid)
            {
                _logger.Warning($"Non base archive in base folder found. Skip loading: {filePath}");
            }

            return valid;
        }

        /// <summary>
        /// Load a single bundle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="source"></param>
        public void LoadArchive(string path, EArchiveSource source = EArchiveSource.Unknown)
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
        public void LoadModArchive(string filename, bool analyzeFiles = true)
        {
            if (Archives.Lookup(filename).HasValue)
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

            Archives.AddOrUpdate(archive);
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        public virtual void LoadModsArchives(FileInfo executable, bool analyzeFiles = true)
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

            // clear all mod archives
            foreach (var item in GetModArchives().Select(x => x.ArchiveAbsolutePath))
            {
                Archives.Remove(item);
            }

            var redModBasePath = Path.Combine(di.Parent.Parent.FullName, "mods");
            var legacyModPath = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "mod");
            var redModCache = Path.Combine(di.Parent.Parent.FullName, "r6", "cache", "modded");
            var redModModsJSON = Path.Combine(redModCache, "mods.json");
            var legacyModlistTxt = Path.Combine(legacyModPath, "modlist.txt");

            // parse redmod files
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
                            _logger.Warning($"REDMod ({folder}) is enabled but not deployed. Assets will still be available in the Asset Browser.");
                        }

                        var redModArchivesDir = Path.Combine(redModBasePath, folder, "archives");
                        if (Directory.Exists(redModArchivesDir))
                        {
                            var modArchives = Directory.GetFiles(redModArchivesDir, "*.archive", SearchOption.TopDirectoryOnly).ToList();
                            modArchives.Sort(string.CompareOrdinal);
                            modArchives.Reverse();

                            redModFiles.AddRange(modArchives);
                        }
                    }
                }
                modsJSON.Close();
            }

            var legacyModTxtFiles = new List<string>();
            if (File.Exists(legacyModlistTxt))
            {
                var legacyOrder = File.ReadAllLines(legacyModlistTxt)
                    .Where(line => line.Length > 0);

                foreach (var archiveName in legacyOrder)
                {
                    var archiveFile = Path.Combine(legacyModPath, $"{archiveName}.archive");
                    if (File.Exists(archiveFile))
                    {
                        legacyModTxtFiles.Add(archiveFile);
                    }
                    else
                    {
                        _logger.Warning($"\"{archiveName}\" is present in \"modslist.txt\" but does not exist. Skipping.");
                    }
                }
            }

            var legacyFiles = new List<string>();
            if (Directory.Exists(legacyModPath))
            {
                foreach (var archiveFile in Directory.GetFiles(legacyModPath, "*.archive", SearchOption.TopDirectoryOnly))
                {
                    if (!legacyModlistTxt.Contains(archiveFile))
                    {
                        legacyFiles.Add(archiveFile);
                    }
                    else
                    {
                        _logger.Debug($"Skipping {archiveFile} during legacy loading.");
                    }
                }

                legacyFiles.Sort(string.CompareOrdinal);
            }

            
            // load legacy mods in "modlist.txt"
            foreach (var file in legacyModTxtFiles)
            {
                LoadModArchive(file, analyzeFiles);
            }

            // legacy mods that aren't in "modlist.txt" next
            foreach (var file in legacyFiles)
            {
                LoadModArchive(file, analyzeFiles);
            }
            
            // load REDmod mods last
            foreach (var file in redModFiles)
            {
                LoadModArchive(file, analyzeFiles);
            }

            foreach (var modArchive in GetModArchives())
            {
                modArchive.ArchiveRelativePath = Path.GetRelativePath(di.Parent.Parent.FullName, modArchive.ArchiveAbsolutePath);
            }

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        public virtual void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true)
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

            foreach (var file in files)
            {
                LoadModArchive(file, analyzeFiles);
            }

            // set relative paths
            foreach (var archive in Archives.Items)
            {
                if (!files.Contains(archive.ArchiveAbsolutePath))
                {
                    continue;
                }

                archive.ArchiveRelativePath = Path.GetRelativePath(archiveBasePath, archive.ArchiveAbsolutePath);
            }

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        #endregion

        public virtual Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles() => 
            GetGroupedFiles(ArchiveManagerScope.Basegame);

        /// <summary>
        /// Get files grouped by extension in all archives of selected search scope
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles(ArchiveManagerScope searchScope)
        {
            if (searchScope is ArchiveManagerScope.Mods)
            {
                return GetModArchives()
                    .SelectMany(archive => archive.Files.Values)
                    .GroupBy(gameFile => gameFile.Extension)
                    .ToDictionary(gameFiles => gameFiles.Key, gameFiles => gameFiles.Select(x => x));
            }

            if (searchScope is ArchiveManagerScope.Basegame)
            {
                return GetGameArchives()
                    .SelectMany(archive => archive.Files.Values)
                    .GroupBy(gameFile => gameFile.Extension)
                    .ToDictionary(gameFiles => gameFiles.Key, gameFiles => gameFiles.Select(x => x));
            }

            throw new NotSupportedException(nameof(searchScope));
        }

        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ulong hash) => Lookup(hash, ArchiveManagerScope.Everywhere);

        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ulong hash, ArchiveManagerScope searchScope)
        {
            if (searchScope is ArchiveManagerScope.Mods or ArchiveManagerScope.Everywhere)
            {
                // first check the mod archives
                foreach (var item in GetModArchives())
                {
                    if (item.Files.TryGetValue(hash, out var value))
                    {
                        return Optional<IGameFile>.ToOptional(value);
                    }
                }
            }

            if (searchScope is ArchiveManagerScope.Basegame or ArchiveManagerScope.Everywhere)
            {
                // then check the ep1 archives
                foreach (var item in GetEp1Archives())
                {
                    if (item.Files.TryGetValue(hash, out var value))
                    {
                        return Optional<IGameFile>.ToOptional(value);
                    }
                }

                // then check the base archives
                foreach (var item in GetBaseArchives())
                {
                    if (item.Files.TryGetValue(hash, out var value))
                    {
                        return Optional<IGameFile>.ToOptional(value);
                    }
                }
            }

            return Optional<IGameFile>.None;
        }

        public IGameFile? GetGameFile(ResourcePath path, bool includeMods = true, bool includeProject = true)
        {
            // check if the file is in the project archive
            if (includeProject && ProjectArchive != null && ProjectArchive.Files.TryGetValue(path, out var projectFile))
            {
                return projectFile;
            }

            // check if the file is in a mod archive
            if (includeMods)
            {
                var modFile = GetModArchives()
                    .Select(x => x.Files)
                    .Where(x => x.ContainsKey(path))
                    .Select(x => x[path])
                    .FirstOrDefault();

                if (modFile != null)
                {
                    return modFile;
                }
            }

            // check if the file is in a base archive
            var baseFile = Archives
                .Items
                .Where(x => x.Source == EArchiveSource.Base)
                .Select(x => x.Files)
                .Where(x => x.ContainsKey(path))
                .Select(x => x[path])
                .FirstOrDefault();

            if (baseFile != null)
            {
                return baseFile;
            }

            return null;
        }

        public CR2WFile? GetCR2WFile(ResourcePath path, bool includeMods = true, bool includeProject = true)
        {
            var gameFile = GetGameFile(path, includeMods, includeProject);

            if (gameFile != null)
            {
                using var ms = new MemoryStream();
                gameFile.Extract(ms);
                ms.Position = 0;

                if (_wolvenkitFileService.TryReadRed4File(ms, out var redFile))
                {
                    return redFile;
                }
            }

            return null;
        }

        public IEnumerable<IGameArchive> GetModArchives() => Archives.Items.Where(x => x.Source is EArchiveSource.Mod);
        public IEnumerable<IGameArchive> GetBaseArchives() => Archives.Items.Where(x => x.Source is EArchiveSource.Base);
        public IEnumerable<IGameArchive> GetEp1Archives() => Archives.Items.Where(x => x.Source is EArchiveSource.EP1);
        public IEnumerable<IGameArchive> GetGameArchives() => Archives.Items.Where(x => x.Source is EArchiveSource.EP1 or EArchiveSource.Base);

        #endregion methods
    }
}
