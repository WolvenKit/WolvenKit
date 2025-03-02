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
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.Archive
{
    public partial class ArchiveManager : ObservableObject, IArchiveManager
    {
        public ArchiveManager(
            IHashService hashService,
            Red4ParserService wolvenkitFileService,
            ILoggerService logger,
            IProgressService<double> progressService
        )
        {
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _logger = logger;
            _progressServiceService = progressService;
        }
        
        #region Fields

        private readonly IHashService _hashService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly ILoggerService _logger;
        private readonly IProgressService<double> _progressServiceService;
        
        [ObservableProperty] private bool _isManagerLoading;
        [ObservableProperty] private bool _isManagerLoaded;

        private static readonly List<string> s_loadOrder = ["memoryresident", "ep1", "basegame", "audio", "lang"];

        #endregion Fields

        #region properties

        public SourceCache<IGameArchive, string> Archives { get; set; } = new(x => x.ArchiveAbsolutePath);

        public IGameArchive? ProjectArchive { get; set; }

        public virtual string[] GetIgnoredArchiveNames() => [];

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

        public bool IsInitialized { get; private set; }

        public virtual void Initialize(FileInfo executable, bool scanArchives = false)
        {
            if (IsInitialized)
            {
                return;
            }

            if (!GetGameArchives().Any())
            {
                LoadGameArchives(executable);
            }

            if (!GetModArchives().Any())
            {
                LoadModArchives(executable, scanArchives);
            }

            IsInitialized = true;
        }
        
        
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
        /// Load a single mod bundle and optionally analyze its content.
        /// </summary>
        /// <param name="absoluteFilepath"> absolute path of file to process </param>
        /// <param name="analyzeFiles"></param>
        /// <param name="forceRescan"></param>
        public void LoadModArchive(string absoluteFilepath, bool analyzeFiles = true, bool forceRescan = false)
        {
            if (!forceRescan && Archives.Lookup(absoluteFilepath).HasValue)
            {
                return;
            }

            var archiveName = Path.GetFileName(absoluteFilepath).Replace(".archive", "");
            var archive = _wolvenkitFileService.ReadRed4Archive(absoluteFilepath, _hashService);

            if (archive == null)
            {
                _logger.Warning($"Unable to load mod archive: {archiveName}");
                return;
            }

            archive.Source = EArchiveSource.Mod;
            Archives.AddOrUpdate(archive);

            if (!analyzeFiles)
            {
                return;
            }

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
                _logger.Warning($"Error while loading the following mod archive: {archiveName}");
                _logger.Warning("  You can exclude it from analysis in the settings under 'Exclude archives from scan by name'");
            }
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        public virtual void LoadModArchives(FileInfo executable, bool analyzeFiles = true, string[]? ignoredArchives = null)
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

            ignoredArchives ??= [];
            
            IsManagerLoading = true;
            _progressServiceService.IsIndeterminate = true;

            // clear all mod archives
            foreach (var item in GetModArchives().Select(x => x.ArchiveAbsolutePath))
            {
                Archives.Remove(item);
            }

            var redModBasePath = Path.Combine(di.Parent.Parent.FullName, "mods");
            var legacyModPath = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "mod");
            var redModModsJson = Path.Combine(di.Parent.Parent.FullName, "r6", "cache", "modded", "mods.json");
            var legacyModlistTxt = Path.Combine(legacyModPath, "modlist.txt");

            
            var redModFiles = new List<string>();
            var legacyFiles = new List<string>();

            var enabledButNotDeployed = new List<string>();
            var enabledButDontExist = new List<string>();


            if (Directory.Exists(legacyModPath))
            {
                legacyFiles.AddRange(Directory.GetFiles(legacyModPath, "*.archive", SearchOption.TopDirectoryOnly));
            }

            if (Directory.Exists(redModBasePath))
            {
                // load all archive files in redmod folders, recursively, we don't care if the installation is valid
                foreach (var folder in Directory.GetDirectories(redModBasePath))
                {
                    var redModArchivesDir = Path.Combine(redModBasePath, folder, "archives");
                    if (!Directory.Exists(redModArchivesDir))
                    {
                        continue;
                    }

                    var modArchives = Directory.GetFiles(redModArchivesDir, "*.archive", SearchOption.AllDirectories).ToList();
                    modArchives.Sort(string.CompareOrdinal);
                    modArchives.Reverse();

                    redModFiles.AddRange(modArchives);
                }
            }

            // now check if they're valid
            if (File.Exists(redModModsJson))
            {
                var modsJson = File.Open(redModModsJson, FileMode.Open);

                var redModElement = JsonSerializer.Deserialize<JsonElement>(modsJson);
                var modsArr = redModElement.GetProperty("mods").EnumerateArray();

                foreach (var mod in modsArr.Where(mod => mod.GetProperty("enabled").GetBoolean()))
                {
                    var folder = mod.GetProperty("folder").GetString().NotNull();

                    if (!mod.GetProperty("deployed").GetBoolean())
                    {
                        enabledButNotDeployed.Add(folder);
                    }

                    if (!Directory.Exists(Path.Combine(redModBasePath, folder)))
                    {
                        enabledButDontExist.Add($"mods/{folder}");
                    }
                }

                modsJson.Close();
            }


            // parse legacy mod txt
            if (File.Exists(legacyModlistTxt))
            {
                var legacyOrder = File.ReadAllLines(legacyModlistTxt)
                    .Where(line => line.Length > 0);

                foreach (var archiveName in legacyOrder)
                {
                    var archiveFile = Path.Combine(legacyModPath, $"{archiveName}.archive");
                    if (!File.Exists(archiveFile))
                    {
                        enabledButDontExist.Add(archiveFile);
                    }
                    else if (!legacyFiles.Contains(archiveFile))
                    {
                        legacyFiles.Add(archiveFile);
                    }
                }
            }

            // Print warnings:
            if (enabledButNotDeployed.Count != 0 || enabledButDontExist.Count != 0)
            {
                _logger.Warning("Scanning mods has found irregularities. If everything works, you can ignore these warnings:");
                if (enabledButNotDeployed.Count != 0)
                {
                    _logger.Warning(
                        "The following mods are enabled, but not deployed. The game will not load them. Check your mod manager:");
                    _logger.Warning(string.Join('\n', enabledButNotDeployed));
                }

                if (enabledButDontExist.Count != 0)
                {
                    _logger.Warning("The following mods are enabled, but could not be found. Make sure they're installed correctly:");
                    _logger.Warning(string.Join('\n', enabledButDontExist));
                }
            }

            // Get num total entries for progress display
            var numTotalEntries = redModFiles.Count + legacyFiles.Count;

            legacyFiles.Sort(string.CompareOrdinal);

            var progress = 0;

            _progressServiceService.IsIndeterminate = false;
            foreach (var file in redModFiles.Where(f => !ignoredArchives.Contains(Path.GetFileName(f).Replace(".archive", ""))))
            {
                LoadModArchive(file, analyzeFiles);
                progress += 1;
                _progressServiceService.Report(progress / (float)numTotalEntries);
            }

            foreach (var file in legacyFiles.Where(f => !ignoredArchives.Contains(Path.GetFileName(f).Replace(".archive", ""))))
            {
                LoadModArchive(file, analyzeFiles);
                progress += 1;
                _progressServiceService.Report(progress / (float)numTotalEntries); 
            }

            _progressServiceService.Completed(); 

            IsManagerLoading = false;
            IsManagerLoaded = true;
        }

        public virtual void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true, string[]? ignoredArchives = null)
        {
            if (!Directory.Exists(archiveBasePath))
            {
                return;
            }

            IsManagerLoading = true;
            ignoredArchives ??= [];

            var files = Directory.GetFiles(archiveBasePath, "*.archive", SearchOption.AllDirectories)
                .ToList();

            if (files.Count == 0)
            {
                return;
            }

            files.Sort(string.CompareOrdinal);

            var progress = 0;
            var totalFiles = (double)files.Count;

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Replace(".archive", "");
                if (ignoredArchives.Contains(fileName))
                {
                    _logger.Info($"{fileName} ignored via settings, skipping...");
                    continue;
                }
                LoadModArchive(file, analyzeFiles);
                progress += 1;
                _progressServiceService.Report(progress / totalFiles);
            }

            files = files.Where(f => !ignoredArchives.Contains(Path.GetFileName(f).Replace(".archive", ""))).ToList();

            // set relative paths
            foreach (var archive in Archives.Items)
            {
                if (!files.Contains(archive.ArchiveAbsolutePath))
                {
                    continue;
                }

                if (archive.ArchiveAbsolutePath.Contains(archiveBasePath))
                {
                    archive.ArchiveRelativePath = Path.GetRelativePath(archiveBasePath, archive.ArchiveAbsolutePath);
                }
            }

            IsManagerLoading = false;
            IsManagerLoaded = true;

            _progressServiceService.Completed();
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
            Dictionary<string, IEnumerable<IGameFile>> ret = [];
            
            // project files
            if (searchScope is (ArchiveManagerScope.LocalProject or ArchiveManagerScope.Everywhere) && ProjectArchive is not null)
            {
                ret.MergeRange(ProjectArchive.Files.Values
                    .GroupBy(gameFile => gameFile.Extension)
                    .ToDictionary(gameFiles => gameFiles.Key, gameFiles => gameFiles.Select(x => x))); 
            }
            
            // base game files
            if (searchScope is ArchiveManagerScope.Basegame or ArchiveManagerScope.Everywhere or ArchiveManagerScope.BasegameAndMods)
            {
                ret.MergeRange(GetGameArchives()
                    .SelectMany(archive => archive.Files.Values)
                    .GroupBy(gameFile => gameFile.Extension)
                    .ToDictionary(gameFiles => gameFiles.Key, gameFiles => gameFiles.Select(x => x)));
            }
            
            // mods
            if (searchScope is ArchiveManagerScope.Mods or ArchiveManagerScope.BasegameAndMods or ArchiveManagerScope.Everywhere)
            {
                ret.MergeRange(  GetModArchives()
                    .SelectMany(archive => archive.Files.Values)
                    .GroupBy(gameFile => gameFile.Extension)
                    .ToDictionary(gameFiles => gameFiles.Key, gameFiles => gameFiles.Select(x => x)));
            }

            return ret;
        }


        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ResourcePath path, ArchiveManagerScope searchScope) =>
            Lookup(HashHelper.CalculateDepotPathHash(path), searchScope);

        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ResourcePath path) => Lookup(path, ArchiveManagerScope.Everywhere); 
        
        
        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ulong hash) => Lookup(hash, ArchiveManagerScope.Everywhere);


        /// <inheritdoc />
        public Optional<IGameFile> Lookup(ulong hash, ArchiveManagerScope searchScope)
        {
            
            // Check project archive
            if (searchScope is ArchiveManagerScope.LocalProject or ArchiveManagerScope.Everywhere && ProjectArchive is not null)
            {
                if (ProjectArchive.Files.TryGetValue(hash, out var value))
                {
                    return Optional<IGameFile>.ToOptional(value);
                }
            }
            
            if (searchScope is ArchiveManagerScope.Mods or ArchiveManagerScope.BasegameAndMods or ArchiveManagerScope.Everywhere)
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

            if (searchScope is not (ArchiveManagerScope.Basegame or ArchiveManagerScope.BasegameAndMods or ArchiveManagerScope.Everywhere))
            {
                return Optional<IGameFile>.None;
            }

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

            return Optional<IGameFile>.None;
        }

        public List<IGameFile> Search(string search, ArchiveManagerScope searchScope) =>
            Archives
                .Items
                .Where(x => searchScope switch
                {
                    ArchiveManagerScope.Basegame => x.Source is EArchiveSource.Base,
                    ArchiveManagerScope.Mods => x.Source is EArchiveSource.Mod,
                    ArchiveManagerScope.Everywhere => true,
                    _ => false,
                })
                .SelectMany(x => x.Files.Values)
                .Where(file => file.FileName.Contains(search))
                .GroupBy(x => x.Key)
                .Select(x => x.First())
                .ToList();

        public IGameFile? GetGameFile(ResourcePath path, bool includeMods = true, bool includeProject = true)
        {
            var filePath = path.GetResolvedText() ?? "";
            
            // check if the file is in the project archive
            if (includeProject && ProjectArchive != null && ProjectArchive.Files.TryGetValue(path, out var projectFile))
            {
                return projectFile;
            }

            var fileHash = ResourcePath.CalculateHash(filePath);

            // check if the file is in a mod archive
            if (includeMods)
            {
                var modFile = GetModArchives()
                    .Select(x => x.Files)
                    .Where(x => x.ContainsKey(path) || x.ContainsKey(fileHash))
                    .Select(x => x[path] ?? x[fileHash])
                    .FirstOrDefault();

                if (modFile != null)
                {
                    return modFile;
                }
            }

            // check if the file is in a base archive
            var baseFile = GetGameArchives()
                .Select(x => x.Files)
                .Where(x => x.ContainsKey(path) || x.ContainsKey(fileHash))
                .Select(x => x[path] ?? x[fileHash])
                .FirstOrDefault();

            return baseFile; // this can be null
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
