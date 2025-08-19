using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using System.Threading.Tasks;
using System;
using WolvenKit.App.Interaction;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.Modkit.Scripting;


namespace WolvenKit.App.Helpers;

internal class MultilayerProperties
{
    public string[]? MetalLevelsIn { get; set; }
    public string[]? MetalLevelsOut { get; set; }
    public string[]? RoughLevelsIn { get; set; }
    public string[]? RoughLevelsOut { get; set; }
    public string[]? Overrides { get; set; }
    public string[]? NormalScale { get; set; }

    public void Reset()
    {
        MetalLevelsIn = null;
        MetalLevelsOut = null;
        RoughLevelsIn = null;
        RoughLevelsOut = null;
        Overrides = null;
        NormalScale = null;
    }
}
public class DocumentTools
{
    private readonly ILoggerService _loggerService;
    private readonly Cr2WTools _cr2WTools;
    private readonly MeshTools _meshTools;
    private readonly IArchiveManager _archiveManager;
    private readonly IProjectManager _projectManager;
    private readonly ProjectResourceTools _projectResourceTools;
    private readonly ISettingsManager _settingsManager;


    public static Regex PlaceholderRegex { get; } = new Regex(@"^[-=_]+$");

    // Class-level CR2WFile cache
    private readonly Dictionary<string, CR2WFile?> _cr2wFileCache = new();

    // LFU + TTL cache for filtered results (file path + filter)
    private readonly Dictionary<(string filePath, string filter), FilteredCacheEntry> _filteredResultsCache = new();
    private readonly SortedDictionary<int, HashSet<(string filePath, string filter)>> _frequencyMap = new();
    private readonly Dictionary<(string filePath, string filter), int> _keyFrequency = new();
    private const int FilteredCacheLimit = 100;
    private const int FilteredCacheTTLMinutes = 30;
    private DateTime _lastCleanupTime = DateTime.UtcNow;
    private const int CleanupIntervalMinutes = 5; // Only cleanup every 5 minutes

    public DocumentTools(ILoggerService loggerService, Cr2WTools cr2WTools, IArchiveManager archiveManager,
        IProjectManager projectManager, MeshTools meshTools, ProjectResourceTools projectResourceTools,
        ISettingsManager settingsManager)
    {
        _loggerService = loggerService;
        _cr2WTools = cr2WTools;
        _archiveManager = archiveManager;
        _projectManager = projectManager;
        _meshTools = meshTools;
        _projectResourceTools = projectResourceTools;
        _settingsManager = settingsManager;
    }


    // Cache entry with metadata for LFU + TTL
    private class FilteredCacheEntry
    {
        public List<string> Results { get; set; }
        public DateTime CachedAt { get; set; }

        public FilteredCacheEntry(List<string> results)
        {
            Results = results;
            CachedAt = DateTime.UtcNow;
        }

        public bool IsExpired => DateTime.UtcNow.Subtract(CachedAt).TotalMinutes > FilteredCacheTTLMinutes;
    }



    // Helper methods for LFU cache operations
    private void IncrementFrequency((string filePath, string filter) key)
    {
        if (!_keyFrequency.ContainsKey(key)) return;

        var oldFreq = _keyFrequency[key];
        var newFreq = oldFreq + 1;

        // Remove from old frequency bucket
        if (_frequencyMap.ContainsKey(oldFreq))
        {
            _frequencyMap[oldFreq].Remove(key);
            if (_frequencyMap[oldFreq].Count == 0)
            {
                _frequencyMap.Remove(oldFreq);
            }
        }

        // Add to new frequency bucket
        if (!_frequencyMap.ContainsKey(newFreq))
        {
            _frequencyMap[newFreq] = new HashSet<(string filePath, string filter)>();
        }
        _frequencyMap[newFreq].Add(key);
        _keyFrequency[key] = newFreq;
    }

    private void RemoveFromCache((string filePath, string filter) key)
    {
        if (_filteredResultsCache.Remove(key))
        {
            if (_keyFrequency.TryGetValue(key, out var freq))
            {
                if (_frequencyMap.ContainsKey(freq))
                {
                    _frequencyMap[freq].Remove(key);
                    if (_frequencyMap[freq].Count == 0)
                    {
                        _frequencyMap.Remove(freq);
                    }
                }
                _keyFrequency.Remove(key);
            }
        }
    }

    private void EvictLeastFrequentlyUsed()
    {
        if (_frequencyMap.Count == 0) return;

        var leastFreq = _frequencyMap.First().Key;
        var leastFreqSet = _frequencyMap[leastFreq];

        if (leastFreqSet.Count > 0)
        {
            var keyToEvict = leastFreqSet.First();
            RemoveFromCache(keyToEvict);
        }
    }

    private void CleanupExpiredEntries()
    {
        // Lazy cleanup - only run every 5 minutes
        var now = DateTime.UtcNow;
        if (now.Subtract(_lastCleanupTime).TotalMinutes < CleanupIntervalMinutes)
        {
            return;
        }
        _lastCleanupTime = now;

        var expiredKeys = _filteredResultsCache
            .Where(kvp => kvp.Value.IsExpired)
            .Select(kvp => kvp.Key)
            .ToList();

        foreach (var key in expiredKeys)
        {
            RemoveFromCache(key);
        }
    }


    #region journalFile

    public async Task<List<string>> GetAllJournalPathsAsync(bool forceCacheRefresh, string? filter = null, bool sortAndDistinct = true)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
            return [];

        var journalPaths = CollectProjectFiles(".journal");

        if (forceCacheRefresh)
        {
            foreach (var journal in journalPaths)
            {
                if (activeProject.GetAbsolutePath(journal) is string absolutePath)
                {
                    _cr2wFileCache.Remove(absolutePath);
                    // Remove all filtered cache entries for this file
                    foreach (var key in _filteredResultsCache.Keys.Where(k => k.filePath == absolutePath).ToList())
                    {
                        RemoveFromCache(key);
                    }
                }
            }
            // Remove all filtered cache entries for the current filter value
            if (!string.IsNullOrEmpty(filter))
            {
                foreach (var key in _filteredResultsCache.Keys.Where(k => k.filter == filter).ToList())
                {
                    RemoveFromCache(key);
                }
            }
        }

        var validJournalPaths = journalPaths
            .Select(journal => new { journal, absolutePath = activeProject.GetAbsolutePath(journal) })
            .Where(x => x.absolutePath is not null && File.Exists(x.absolutePath))
            .ToList();

        var tasks = validJournalPaths.Select(async x =>
        {
            if (!_cr2wFileCache.TryGetValue(x.absolutePath!, out var cr2w))
            {
                cr2w = _cr2WTools.ReadCr2W(x.absolutePath!);
                _cr2wFileCache[x.absolutePath!] = cr2w;
            }
            return await GetJournalIDsAsync(cr2w, x.absolutePath!, filter);
        });

        var results = await Task.WhenAll(tasks);
        IEnumerable<string> allIds = results.SelectMany(ids => ids);
        if (sortAndDistinct && (string.IsNullOrEmpty(filter) || sortAndDistinct))
        {
            allIds = allIds.Distinct().OrderBy(x => x);
        }
        return allIds.ToList();
    }

    private async Task<List<string>> GetJournalIDsAsync(CR2WFile? cr2W, string absoluteFilePath, string? filter = null)
    {
        if (cr2W == null || string.IsNullOrEmpty(filter)) return [];

        var filterKey = (absoluteFilePath, filter);

        CleanupExpiredEntries();

        if (_filteredResultsCache.TryGetValue(filterKey, out var cachedFiltered) && !cachedFiltered.IsExpired)
        {
            IncrementFrequency(filterKey);
            return cachedFiltered.Results;
        }

        var entriesIDs = await ProcessJournalEntries(cr2W, filter);

        _filteredResultsCache[filterKey] = new FilteredCacheEntry(entriesIDs);
        _keyFrequency[filterKey] = 1;

        if (!_frequencyMap.ContainsKey(1))
        {
            _frequencyMap[1] = new HashSet<(string filePath, string filter)>();
        }
        _frequencyMap[1].Add(filterKey);

        if (_filteredResultsCache.Count > FilteredCacheLimit)
        {
            EvictLeastFrequentlyUsed();
        }

        return entriesIDs;
    }

    private async Task<List<string>> ProcessJournalEntries(CR2WFile? cr2W, string filter)
    {
        if (cr2W?.RootChunk is not gameJournalResource journalResource ||
            journalResource.Entry.Chunk is not gameJournalContainerEntry journalEntry)
        {
            return [];
        }

        var rootPath = journalResource.Entry.Chunk?.Id.ToString() ?? "";
        var entriesIDs = new List<string>(50);

        await ProcessEntries(journalEntry.Entries, entriesIDs, rootPath, filter);

        return entriesIDs;
    }

    private Task ProcessEntries(IList<CHandle<gameJournalEntry>> entries, List<string> results, string currentPath, string filterStr)
    {
        if (entries.Count == 0) return Task.CompletedTask;

        // Use parallel processing for larger entry sets
        if (entries.Count > 5)
        {
            var bag = new System.Collections.Concurrent.ConcurrentBag<string>();
            System.Threading.Tasks.Parallel.ForEach(entries, entry =>
            {
                if (entry.Chunk != null)
                {
                    ProcessEntry(entry, currentPath, filterStr, bag);
                }
            });
            results.AddRange(bag);
        }
        else
        {
            // Sequential processing for small entry sets
            foreach (var entry in entries)
            {
                if (entry.Chunk != null)
                {
                    ProcessEntry(entry, currentPath, filterStr, results);
                }
            }
        }
        return Task.CompletedTask;
    }

    private void ProcessEntry(CHandle<gameJournalEntry> entry, string currentPath, string filterStr, object results)
    {
        var entryId = entry.Chunk!.Id.ToString();
        var entryPath = string.IsNullOrEmpty(currentPath) ? entryId : $"{currentPath}/{entryId}";

        // Check if this entry matches the filter
        if (ContainsFilter(entryPath, filterStr))
        {
            // Handle both ICollection<string> and ConcurrentBag<string>
            if (results is ICollection<string> collection)
            {
                collection.Add(entryPath);
            }
            else if (results is System.Collections.Concurrent.ConcurrentBag<string> bag)
            {
                bag.Add(entryPath);
            }
        }

        // Always process children if it's a container entry
        if (entry.Chunk is gameJournalContainerEntry containerEntry)
        {
            ProcessContainerChildren(containerEntry.Entries, entryPath, filterStr, results);
        }
    }

    private void ProcessContainerChildren(IList<CHandle<gameJournalEntry>> entries, string parentPath, string filterStr, object results)
    {
        var stack = new Stack<(IList<CHandle<gameJournalEntry>>, string)>();
        stack.Push((entries, parentPath));

        while (stack.Count > 0)
        {
            var (currentEntries, currentPath) = stack.Pop();
            foreach (var entry in currentEntries)
            {
                if (entry.Chunk == null) continue;

                var entryId = entry.Chunk.Id.ToString();
                var entryPath = $"{currentPath}/{entryId}";

                // Check if this entry matches the filter
                if (ContainsFilter(entryPath, filterStr))
                {
                    if (results is ICollection<string> collection)
                    {
                        collection.Add(entryPath);
                    }
                    else if (results is System.Collections.Concurrent.ConcurrentBag<string> bag)
                    {
                        bag.Add(entryPath);
                    }
                }

                // Always add children to stack if it's a container
                if (entry.Chunk is gameJournalContainerEntry containerEntry)
                {
                    stack.Push((containerEntry.Entries, entryPath));
                }
            }
        }
    }

    // Optimized filter checking with case-insensitive comparison
    private static bool ContainsFilter(string text, string filter)
    {
        return text.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    #endregion

    # region appfile

    public static List<string> GetAllComponentNames(List<appearanceAppearanceDefinition> appearances) => appearances
        .SelectMany(app => app.Components)
            .Select(c => c.Name.GetResolvedText() ?? "").Where(c => !string.IsNullOrEmpty(c)).Distinct().ToList();

    public List<string> ConnectAppToEntFile(string absoluteAppFilePath, string absoluteEntFilePath,
        bool clearExistingEntries = false)
    {
        if (!File.Exists(absoluteAppFilePath))
        {
            _loggerService.Error("App file does not exist.");
            return [];
        }

        if (!File.Exists(absoluteEntFilePath))
        {
            _loggerService.Error("Ent file does not exist.");
            return [];
        }

        var appCr2W = _cr2WTools.ReadCr2W(absoluteAppFilePath);
        var entCr2W = _cr2WTools.ReadCr2W(absoluteEntFilePath);

        if (entCr2W.RootChunk is not entEntityTemplate ent)
        {
            _loggerService.Error($"invalid .ent file: {absoluteEntFilePath}!");
            return [];
        }

        if (appCr2W.RootChunk is not appearanceAppearanceResource)
        {
            _loggerService.Error($"invalid .app file: {absoluteAppFilePath}!");
            return [];
        }

        var appAppearanceNames = GetAppearanceNamesFromApp(appCr2W);

        if (clearExistingEntries)
        {
            ent.Appearances.Clear();
        }

        var entAppearanceNames = ent.Appearances.Select(a => a.AppearanceName.GetResolvedText())
            .Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s!)
            .ToList();

        var missingAppearances = appAppearanceNames.Except(entAppearanceNames).ToList();
        if (missingAppearances.Count == 0)
        {
            return appAppearanceNames;
        }

        var appearancePrefix = ent.Appearances
            .Where(eA => appAppearanceNames.Contains(eA.AppearanceName.GetResolvedText() ?? ""))
            .Select(eA =>
                (eA.Name.GetResolvedText() ?? "").Replace(eA.AppearanceName.GetResolvedText() ?? "", ""))
            .FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? "";

        var relativeAppFilePath = absoluteAppFilePath.Split("archive")[^1];

        foreach (var appName in appAppearanceNames.Except(entAppearanceNames))
        {
            var newAppearance = new entTemplateAppearance()
            {
                AppearanceName = appName,
                Name = $"{appearancePrefix}{appName}",
                AppearanceResource = new CResourceAsyncReference<appearanceAppearanceResource>(relativeAppFilePath)
            };
            ent.Appearances.Add(newAppearance);
        }

        if (!entAppearanceNames.Contains(ent.DefaultAppearance.GetResolvedText() ?? ""))
        {
            ent.DefaultAppearance = ent.Appearances.LastOrDefault()?.Name.GetResolvedText() ?? "";
        }

        _cr2WTools.WriteCr2W(entCr2W, absoluteEntFilePath);
        return appAppearanceNames;
    }

    private static readonly Dictionary<string, List<string>> s_appAppearancesByPath = [];

    public CR2WFile? GetCr2W(string relativePath, bool preferFromMod = true)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return null;
        }

        var absolutePath = activeProject.GetAbsolutePath(relativePath);

        if (File.Exists(absolutePath))
        {
            return _cr2WTools.ReadCr2W(absolutePath);
        }

        CR2WFile? ret = null;
        if (preferFromMod)
        {
            ret = _archiveManager.GetCR2WFile(relativePath, true);
            if (ret is not null)
            {
                return ret;
            }

            if (!Interactions.ShowQuestionYesNo((
                    "Scan mod archives now?\nDepending on how many mods you have installed, this can take a few moments. Wolvenkit will be unresponsive.",
                    "Scan mod archives now?")))
            {
                return null;
            }

            _projectResourceTools.ScanModArchives();
            ret = _archiveManager.GetCR2WFile(relativePath, true);
            if (ret is not null)
            {
                return ret;
            }
        }

        ret = _archiveManager.GetCR2WFile(relativePath, false);
        return ret ?? _archiveManager.GetCR2WFile(relativePath);
    }

    public List<string> GetAppearanceNamesFromApp(ResourcePath relativeAppResourcePath, bool refreshCache)
    {
        if (relativeAppResourcePath.GetResolvedText() is not string relativeAppFilePath ||
            _projectManager.ActiveProject is not { } activeProject)
        {
            return [];
        }

        if (refreshCache)
        {
            s_appAppearancesByPath.Remove(relativeAppFilePath);
        }

        if (s_appAppearancesByPath.TryGetValue(relativeAppFilePath, out var cachedList))
        {
            return cachedList;
        }

        List<string> appAppearances = [];

        // initial opening of file
        if (!refreshCache || GetCr2W(relativeAppFilePath) is not CR2WFile cr2W)
        {
            s_appAppearancesByPath.Add(relativeAppFilePath, appAppearances);
            return appAppearances;
        }

        appAppearances = GetAppearanceNamesFromApp(cr2W);

        s_appAppearancesByPath.Add(relativeAppFilePath, appAppearances);
        return appAppearances;
    }


    private static readonly Dictionary<string, List<string>> s_meshAppearancesByPath = [];


    public List<string> GetAppearanceNamesFromMesh(ResourcePath? relativeMeshResourcePath, bool refreshCache)
    {
        if (relativeMeshResourcePath?.GetResolvedText() is not string relativeMeshFilePath ||
            _projectManager.ActiveProject is not { } activeProject)
        {
            return [];
        }

        if (refreshCache)
        {
            s_meshAppearancesByPath.Remove(relativeMeshFilePath);
        }

        if (s_meshAppearancesByPath.TryGetValue(relativeMeshFilePath, out var cachedList))
        {
            return cachedList;
        }

        // initial opening of file
        if (!refreshCache)
        {
            return [];
        }

        List<string> meshAppearances = [];

        if (activeProject.GetAbsolutePath(relativeMeshFilePath) is string absolutePath && File.Exists(absolutePath))
        {
            if (_cr2WTools.ReadCr2W(absolutePath) is CR2WFile cr2W)
            {
                meshAppearances = GetAppearanceNamesFromMesh(cr2W);
            }

            s_meshAppearancesByPath.Add(relativeMeshFilePath, meshAppearances);
            return meshAppearances;
        }

        var meshFile = _archiveManager.GetGameFile(relativeMeshFilePath);

        if (meshFile is null)
        {
            s_meshAppearancesByPath.Add(relativeMeshFilePath, meshAppearances);
            return meshAppearances;
        }

        switch (meshFile.Scope)
        {
            case ArchiveManagerScope.Mods:
                meshAppearances = GetAppearanceNamesFromMesh(_archiveManager.GetCR2WFile(meshFile.FileName));
                break;
            case ArchiveManagerScope.Basegame:
                meshAppearances = GetAppearanceNamesFromMesh(_archiveManager.GetCR2WFile(meshFile.FileName, false));
                break;
            default:
                break;
        }

        s_meshAppearancesByPath.Add(relativeMeshFilePath, meshAppearances);
        return meshAppearances;
    }

    private List<string> GetAppearanceNamesFromMesh(CR2WFile? cr2W)
    {
        if (cr2W?.RootChunk is not CMesh mesh)
        {
            return [];
        }

        return mesh.Appearances.Select(app => app.Chunk?.Name.ToString()).Where(x => !string.IsNullOrEmpty(x))
            .Select(x => x!).ToList();
    }


    private List<string> GetAppearanceNamesFromApp(CR2WFile? cr2W)
    {
        if (cr2W?.RootChunk is not appearanceAppearanceResource app)
        {
            return [];
        }

        return app.Appearances.Select(a => a.Chunk?.Name.GetResolvedText())
            .Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s!)
            .Where(s => !PlaceholderRegex.IsMatch(s))
            .ToList();
    }

    /// <summary>
    /// Sets facial animations. Normally, we'd be defaulting to female because who has masc characters anyway,
    /// yet in this case we have big/massive, who all default to the male animset.
    /// </summary>
    public void SetFacialAnimations(string absoluteAppFilePath, PhotomodeBodyGender bodyGender)
    {
        var facialAnim = SelectAnimationPathViewModel.FacialAnimPathMale;
        var selectedAnims = SelectAnimationPathViewModel.PhotomodeAnimEntriesMaleDefault;

        if (bodyGender is PhotomodeBodyGender.Female)
        {
            facialAnim = SelectAnimationPathViewModel.FacialAnimPathFemale;
            selectedAnims = SelectAnimationPathViewModel.PhotomodeAnimEntriesFemaleDefault;
        }

        SetFacialAnimations(absoluteAppFilePath, facialAnim, null, selectedAnims);
    }

    public void SetFacialAnimations(string absoluteAppFilePath, string? facialAnim, string? animGraph,
        List<string> selectedAnims)
    {
        if (string.IsNullOrEmpty(facialAnim) && string.IsNullOrEmpty(animGraph) && selectedAnims.Count == 0)
        {
            return;
        }

        if (!File.Exists(absoluteAppFilePath))
        {
            _loggerService.Error($".app file {absoluteAppFilePath} does not exist.");
            return;
        }

        var appCr2W = _cr2WTools.ReadCr2W(absoluteAppFilePath);

        if (appCr2W.RootChunk is not appearanceAppearanceResource app)
        {
            _loggerService.Error($"invalid .app file: {absoluteAppFilePath}!");
            return;
        }

        var facialAnimWritten = false;
        var facialGraphWritten = false;
        var animationsWritten = false;

        foreach (var appearance in app.Appearances
                     .Where(a => a.Chunk is not null))
        {
            foreach (var anim in appearance.Chunk!.Components.OfType<entAnimatedComponent>()
                         .Where(c => c.Name == "face_rig"))
            {
                if (!string.IsNullOrEmpty(facialAnim))
                {
                    anim.Graph = new CResourceReference<animAnimGraph>(facialAnim);
                    facialAnimWritten = true;
                }

                if (!string.IsNullOrEmpty(animGraph))
                {
                    anim.FacialSetup = new CResourceAsyncReference<animFacialSetup>(animGraph);
                    facialGraphWritten = true;
                }
            }

            if (selectedAnims.Count == 0)
            {
                continue;
            }

            foreach (var setup in appearance.Chunk!.Components.OfType<entAnimationSetupExtensionComponent>())
            {
                setup.Animations.Gameplay.Clear();
                foreach (var selectedAnim in selectedAnims)
                {
                    setup.Animations.Gameplay.Add(new animAnimSetupEntry()
                    {
                        Priority = 200,
                        AnimSet = new CResourceAsyncReference<animAnimSet>(selectedAnim),
                        VariableNames = []
                    });
                }

                animationsWritten = true;
            }

        }

        if (!facialAnimWritten && !facialGraphWritten && !animationsWritten)
        {
            return;
        }

        if (facialAnimWritten)
        {
            _loggerService.Success($"set facial animation to {facialAnim}");
        }

        if (facialGraphWritten)
        {
            _loggerService.Success($"set animgraph to {animGraph}");
        }

        if (animationsWritten)
        {
            _loggerService.Success($"Wrote {selectedAnims.Count} animations");
        }

        _cr2WTools.WriteCr2W(appCr2W, absoluteAppFilePath);
    }

    # endregion

    # region cvmDropdown
    private static readonly List<string> s_materialShaders = [];

    private static readonly List<string> s_multilayerMaterials = [];
    private static readonly List<string> s_microblendMaterials = [];

    public IEnumerable<string?> GetAllBaseMaterials(bool forceCacheRefresh)
    {
        if (forceCacheRefresh)
        {
            s_materialShaders.Clear();
        }

        if (s_materialShaders.Count > 0)
        {
            return s_materialShaders.Order();
        }


        s_materialShaders.AddRange(
            _archiveManager.Search(".mt", ArchiveManagerScope.Everywhere).Select(s => s.FileName).Distinct());
        s_materialShaders.AddRange(_archiveManager.Search(".remt", ArchiveManagerScope.Everywhere)
            .Select(s => s.FileName).Distinct());

        return s_materialShaders.Order();
    }

    public IEnumerable<string?> GetAllMultilayerTemplates(bool forceCacheRefresh)
    {
        if (forceCacheRefresh)
        {
            s_multilayerMaterials.Clear();
        }

        if (s_multilayerMaterials.Count > 0)
        {
            return s_multilayerMaterials.Order();
        }

        s_multilayerMaterials.AddRange(
            _archiveManager.Search(".mltemplate", ArchiveManagerScope.Everywhere).Select(s => s.FileName).Distinct());
        s_multilayerMaterials.AddRange(_projectManager.ActiveProject?.Files.Where(f => f.EndsWith(".mltemplate")) ??
                                       []);

        return s_multilayerMaterials.Order().Distinct();
    }

    public IEnumerable<string?> GetAllMicroblends(bool forceCacheRefresh)
    {
        if (forceCacheRefresh)
        {
            s_microblendMaterials.Clear();
        }

        if (s_microblendMaterials.Count > 0)
        {
            return s_microblendMaterials.Order();
        }

        s_microblendMaterials.AddRange(
            _archiveManager.Search("base\\surfaces\\microblends", ArchiveManagerScope.Everywhere)
                .Select(s => s.FileName)
                .Where(s => s.EndsWith(".xbm"))
                .Distinct());

        s_microblendMaterials.AddRange(_projectManager.ActiveProject?.Files
            .Where(f => f.Contains("microblend") && f.EndsWith(".xbm")) ?? []);

        return s_multilayerMaterials.Order().Distinct();
    }


    private static readonly Dictionary<string, List<CMaterialParameter>> s_materialProperties = [];

    public IList<string> GetFilesByType(IRedType cvmResolvedData)
    {
        if (cvmResolvedData is not CKeyValuePair kvp)
        {
            return [];
        }

        return kvp.Value switch
        {
            CFloat => [],
            CResourceReference<ITexture> => CollectProjectFiles(".xbm"),
            CResourceReference<Multilayer_Setup> => CollectProjectFiles(".mlsetup"),
            CResourceReference<Multilayer_Mask> => CollectProjectFiles(".mlmask"),
            CColor => [],
            CResourceReference<CGradient> => [],
            Vector4 => [],
            CName => [],
            CResourceReference<CFoliageProfile> => CollectProjectFiles(".fp"), // ?
            CResourceReference<CHairProfile> => CollectProjectFiles(".hp"),
            CResourceReference<CSkinProfile> => CollectProjectFiles(".sp"),
            CResourceReference<CTerrainSetup> => [],
            _ => []
        };
    }

    private static List<string> FilterByType(IRedType cvmResolvedData, List<CMaterialParameter> templateMaterials)
    {
        if (cvmResolvedData is not CKeyValuePair kvp)
        {
            return [];
        }

        return kvp.Value switch
        {
            CFloat => templateMaterials.Where(m => m is CMaterialParameterScalar)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<ITexture> => templateMaterials
                .Where(m => m is CMaterialParameterTexture)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<Multilayer_Mask> => templateMaterials.Where(m => m is CMaterialParameterMultilayerMask)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<Multilayer_Setup> => templateMaterials.Where(m => m is CMaterialParameterMultilayerSetup)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CColor => templateMaterials.Where(m => m is CMaterialParameterColor)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<CGradient> => templateMaterials.Where(m => m is CMaterialParameterGradient)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            Vector4 => templateMaterials.Where(m => m is CMaterialParameterVector)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CName => templateMaterials.Where(m => m is CMaterialParameterCpuNameU64)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<CFoliageProfile> => templateMaterials
                .Where(m => m is CMaterialParameterFoliageParameters)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<CHairProfile> => templateMaterials.Where(m => m is CMaterialParameterHairParameters)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<CSkinProfile> => templateMaterials.Where(m => m is CMaterialParameterSkinParameters)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            CResourceReference<CTerrainSetup> => templateMaterials.Where(m => m is CMaterialParameterTerrainSetup)
                .Select(m => m.ParameterName.GetResolvedText() ?? "")
                .ToList(),
            _ => []
        };
    }

    private CR2WFile? ReadCr2WFromRelativePath(string relativePath)
    {
        if (string.IsNullOrEmpty(relativePath))
        {
            return null;
        }

        if (_projectManager.ActiveProject is { } activeProject &&
            activeProject.GetAbsolutePath(relativePath) is string s && File.Exists(s))
        {
            return _cr2WTools.ReadCr2W(s);
        }

        return _archiveManager.GetCR2WFile(relativePath);
    }

    public List<string> GetMaterialKeys(IRedType cvmResolvedData, string materialPath, bool forceCacheRefresh)
    {
        List<string> ret = [];

        if (forceCacheRefresh)
        {
            s_materialProperties.Remove(materialPath);
        }

        if (s_materialProperties.TryGetValue(materialPath, out var cachedList) && cachedList.Count > 0)
        {
            ret.AddRange(FilterByType(cvmResolvedData, cachedList));
        }
        else if (materialPath.EndsWith(".mi") &&
                 ReadCr2WFromRelativePath(materialPath) is { RootChunk: CMaterialInstance mi } &&
                 mi.BaseMaterial.DepotPath.GetResolvedText() is string baseMaterial)
        {
            ret.AddRange(GetMaterialKeys(cvmResolvedData, baseMaterial, forceCacheRefresh));
        }
        else if (ReadCr2WFromRelativePath(materialPath) is not { RootChunk: CMaterialTemplate template })
        {
            ret = [];
        }
        else if (forceCacheRefresh)
        {
            s_materialProperties.Remove(materialPath);
            List<CMaterialParameter> templateMaterials = [];

            var matMaterials = template.Parameters[2];
            templateMaterials.AddRange(matMaterials.OfType<IRedHandle<CMaterialParameter>>()
                .Select(e => e.GetValue())
                .OfType<CMaterialParameter>());

            s_materialProperties.TryAdd(materialPath, templateMaterials);

            // return only those parameters which match the kvp's type
            ret = FilterByType(cvmResolvedData, templateMaterials);
        }

        return ret.Distinct().Order().ToList();
    }

    #endregion


    private static readonly string s_archiveString = "archive" + Path.DirectorySeparatorChar;

    public IList<string> CollectProjectFiles(string fileExtension)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return [];
        }

        return activeProject.Files.Where(f => f.EndsWith(fileExtension)).Select(s => s.Replace(s_archiveString, ""))
            .ToList();
    }

    /// <summary>
    /// Returns a list of absolute paths to .xl files patching the current mesh.
    /// If no project files are found, it will search in the base game installation folder.
    /// </summary>
    /// <param name="pathToPatch"></param>
    /// <returns></returns>
    public List<string> FindPatchFilePaths(string pathToPatch)
    {
        List<string> ret = [];

        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return ret;
        }

        // first, find in all .xl files in project
        foreach (var path in CollectProjectFiles(".xl"))
        {
            var absolutePath = Path.Join(activeProject.FileDirectory, path);
            if (!File.Exists(absolutePath) || File.ReadAllText(absolutePath) is not string fileContent ||
                !fileContent.Contains(pathToPatch))
            {
                continue;
            }

            // If file content contains the patch path, add it to the list
            ret.Add(absolutePath);
        }

        if (ret.Count > 0)
        {
            return ret;
        }

        List<string> filePaths = [];

        // no files found in mod folder - now get all .xl files in base game installation
        if (_settingsManager.GetRED4GameModDir() is string redModDir && !string.IsNullOrEmpty(redModDir) &&
            Directory.Exists(redModDir))
        {
            filePaths.AddRange(new DirectoryInfo(redModDir).EnumerateFiles().Where(f => f.Extension == ".xl")
                .Select(f => f.FullName));
        }

        if (_settingsManager.GetRED4GameLegacyModDir() is string modDir && !string.IsNullOrEmpty(modDir) &&
            Directory.Exists(modDir))
        {
            filePaths.AddRange(new DirectoryInfo(modDir).EnumerateFiles().Where(f => f.Extension == ".xl")
                .Select(f => f.FullName));
        }

        if (_settingsManager.ExtraModDirPath is string extraModDir && !string.IsNullOrEmpty(extraModDir) &&
            Directory.Exists(extraModDir))
        {
            filePaths.AddRange(new DirectoryInfo(extraModDir).EnumerateFiles().Where(f => f.Extension == ".xl")
                .Select(f => f.FullName));
        }

        filePaths.ForEach(absolutePath =>
        {
            if (!File.Exists(absolutePath) || File.ReadAllText(absolutePath) is not string fileContent ||
                !fileContent.Contains(pathToPatch))

            {
                return;
            }

            ret.Add(absolutePath);
        });


        return ret;
    }

    public List<string> FindPatchMeshPaths(string pathToPatch)
    {
        List<string> ret = [];

        var patchFiles = FindPatchFilePaths(pathToPatch);

        foreach (var patchFile in patchFiles)
        {
            if (File.ReadAllText(patchFile) is not string yamlText)
            {
                continue;
            }

            if (ArchiveXlHelper.YamlToObject(yamlText) is not Dictionary<object, object> yamlObject ||
                yamlObject.TryGetValue("resource", out var resource) == false ||
                resource is not Dictionary<object, object> r ||
                r.TryGetValue("patch", out var patchValue) != true ||
                patchValue is not Dictionary<object, object> patchDict)
            {
                continue;
            }

            foreach (var kvp in patchDict)
            {
                if (kvp.Key is not string patchMesh || kvp.Value is not List<object> patchedMeshes ||
                    patchedMeshes.OfType<string>().All(path => path != pathToPatch))
                {
                    continue;
                }

                ret.Add(patchMesh);
            }
        }


        return ret;
    }

    public void ClearMeshMaterials(CR2WFile? meshCr2W)
    {
        if (meshCr2W?.RootChunk is not CMesh mesh)
        {
            return;
        }

        mesh.Appearances.Clear();
        mesh.MaterialEntries.Clear();
        mesh.LocalMaterialBuffer.Materials.Clear();
        mesh.ExternalMaterials.Clear();
        mesh.PreloadExternalMaterials.Clear();
        mesh.PreloadLocalMaterialInstances.Clear();
    }

    public bool AppendMeshMaterials(CR2WFile? sourceCr2W, CR2WFile? destCr2W, string sourcePath = "",
        string destPath = "")
    {
        var wasChanged = false;

        if (sourceCr2W is null)
        {
            _loggerService.Error($"source file {sourcePath} not found. Can't copy...");
            return wasChanged;
        }

        if (destCr2W is null)
        {
            _loggerService.Error($"target file {destCr2W} not found. Can't copy...");
            return wasChanged;
        }

        if (sourceCr2W.RootChunk is not CMesh sourceMesh || destCr2W.RootChunk is not CMesh destMesh)
        {
            _loggerService.Error($"source file {sourcePath} or target file {destPath} is not a valid mesh.");
            return wasChanged;
        }


        // ReSharper disable ForCanBeConvertedToForeach
        CArray<CHandle<meshMeshAppearance>> appearances = [];
        for (var i = 0; i < destMesh.Appearances.Count; i++)
        {
            appearances.Add(destMesh.Appearances[i]);
        }

        for (var i = 0; i < sourceMesh.Appearances.Count; i++)
        {
            appearances.Add(sourceMesh.Appearances[i]);
        }

        wasChanged = wasChanged || destMesh.Appearances.Count != appearances.Count;
        destMesh.Appearances = appearances;

        CArray<CMeshMaterialEntry> materialEntries = [];
        for (var i = 0; i < destMesh.MaterialEntries.Count; i++)
        {
            materialEntries.Add(destMesh.MaterialEntries[i]);
        }
        for (var i = 0; i < sourceMesh.MaterialEntries.Count; i++)
        {
            materialEntries.Add(sourceMesh.MaterialEntries[i]);
        }

        // now reindex properties
        var localMaterialIndex = 0;
        var externalMaterialIndex = 0;
        for (var i = 0; i < materialEntries.Count; i++)
        {
            var material = materialEntries[i];
            if (material.IsLocalInstance)
            {
                material.Index = (CUInt16)localMaterialIndex;
                localMaterialIndex += 1;
            }
            else
            {
                material.Index = (CUInt16)externalMaterialIndex;
                externalMaterialIndex += 1;
            }
        }
        wasChanged = wasChanged || destMesh.MaterialEntries.Count != materialEntries.Count;
        destMesh.MaterialEntries = materialEntries;

        CArray<IMaterial> localMaterials = [];
        for (var i = 0; i < destMesh.LocalMaterialBuffer.Materials.Count; i++)
        {
            localMaterials.Add(destMesh.LocalMaterialBuffer.Materials[i]);
        }

        for (var i = 0; i < sourceMesh.LocalMaterialBuffer.Materials.Count; i++)
        {
            localMaterials.Add(sourceMesh.LocalMaterialBuffer.Materials[i]);
        }

        wasChanged = wasChanged || destMesh.LocalMaterialBuffer.Materials.Count != localMaterials.Count;
        destMesh.LocalMaterialBuffer.Materials = localMaterials;

        CArray<CResourceAsyncReference<IMaterial>> externalMaterials = [];
        for (var i = 0; i < destMesh.ExternalMaterials.Count; i++)
        {
            externalMaterials.Add(destMesh.ExternalMaterials[i]);
        }

        for (var i = 0; i < sourceMesh.ExternalMaterials.Count; i++)
        {
            externalMaterials.Add(sourceMesh.ExternalMaterials[i]);
        }

        wasChanged = wasChanged || destMesh.ExternalMaterials.Count != externalMaterials.Count;
        destMesh.ExternalMaterials = externalMaterials;

        CArray<CResourceReference<IMaterial>> preloadExternalMaterials = [];
        for (var i = 0; i < destMesh.PreloadExternalMaterials.Count; i++)
        {
            preloadExternalMaterials.Add(destMesh.PreloadExternalMaterials[i]);
        }

        for (var i = 0; i < sourceMesh.PreloadExternalMaterials.Count; i++)
        {
            preloadExternalMaterials.Add(sourceMesh.PreloadExternalMaterials[i]);
        }

        wasChanged = wasChanged || destMesh.PreloadExternalMaterials.Count != preloadExternalMaterials.Count;
        destMesh.PreloadExternalMaterials = preloadExternalMaterials;


        CArray<CHandle<IMaterial>> preloadLocalMaterialInstances = [];
        for (var i = 0; i < destMesh.PreloadLocalMaterialInstances.Count; i++)
        {
            preloadLocalMaterialInstances.Add(destMesh.PreloadLocalMaterialInstances[i]);
        }

        for (var i = 0; i < sourceMesh.PreloadLocalMaterialInstances.Count; i++)
        {
            preloadLocalMaterialInstances.Add(sourceMesh.PreloadLocalMaterialInstances[i]);
        }

        wasChanged = wasChanged || destMesh.PreloadLocalMaterialInstances.Count != preloadLocalMaterialInstances.Count;
        destMesh.PreloadLocalMaterialInstances = preloadLocalMaterialInstances;

        // ReSharper restore ForCanBeConvertedToForeach

        return wasChanged;
    }

    public bool CopyMeshMaterials(string sourcePath, string destPath)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return false;
        }

        List<string> meshPaths = [sourcePath];
        if (sourcePath == SelectDropdownEntryDialogViewModel.ButtonClickResult)
        {
            meshPaths = FindPatchMeshPaths(activeProject.GetRelativePath(destPath));
        }

        var destCr2W = GetCr2W(destPath) ??
                       throw new InvalidDataException($"target file {destPath} not found. Can't copy...");


        if (destCr2W.RootChunk is not CMesh destMesh)
        {
            throw new InvalidDataException($"target file {destPath} is not a valid mesh.");
        }

        ClearMeshMaterials(destCr2W);

        if (!meshPaths.Select(sourceMeshPath =>
                AppendMeshMaterials(GetCr2W(sourceMeshPath), destCr2W, sourcePath, destPath)).Contains(true))
        {
            return false;
        }

        if (meshPaths.Count == 1)
        {
            _loggerService.Success($"Copied materials from {meshPaths}");
        }
        else
        {
            _loggerService.Success($"Copied materials from the following files: \n\t {string.Join("\n\t", meshPaths)}");
        }
        _cr2WTools.WriteCr2W(destCr2W, destPath);
        return true;
    }


    private static readonly Dictionary<string, MultilayerProperties> s_multilayerPropertiesCache = [];

    public string[] GetMultilayerProperties(string materialPath, string propertyKey, bool forceCacheRefresh)
    {
        if (!s_multilayerPropertiesCache.TryGetValue(materialPath, out var mlProperties))
        {
            if (!forceCacheRefresh)
            {
                return [];
            }

            mlProperties = new MultilayerProperties();
            s_multilayerPropertiesCache.Add(materialPath, mlProperties);
        }
        else if (forceCacheRefresh)
        {
            mlProperties.Reset();
        }

        switch (propertyKey)
        {
            case "metalLevelsIn":
                mlProperties.MetalLevelsIn ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.MetalLevelsIn;
            case "metalLevelsOut":
                mlProperties.MetalLevelsOut ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.MetalLevelsOut;
            case "roughnessLevelsIn":
                mlProperties.RoughLevelsIn ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.RoughLevelsIn;
            case "roughnessLevelsOut":
                mlProperties.RoughLevelsOut ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.RoughLevelsOut;
            case "colorScale":
                mlProperties.Overrides ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.Overrides;
            case "normalStrength":
                mlProperties.NormalScale ??=
                    GetMultilayerPropertiesFromFile(materialPath, propertyKey);
                return mlProperties.NormalScale;
            default:
                return [];
        }
    }

    private string[] GetMultilayerPropertiesFromFile(string materialPath, string propertyKey)
    {
        if (ReadCr2WFromRelativePath(materialPath) is not { RootChunk: Multilayer_LayerTemplate template })
        {
            return [];
        }

        var ret = propertyKey switch
        {
            "metalLevelsIn" => template.Overrides.MetalLevelsIn.Select(i => i.ToString()),
            "metalLevelsOut" => template.Overrides.MetalLevelsOut.Select(i => i.ToString()),
            "roughnessLevelsIn" => template.Overrides.RoughLevelsIn.Select(i => i.ToString()),
            "roughnessLevelsOut" => template.Overrides.RoughLevelsOut.Select(i => i.ToString()),
            "colorScale" => template.Overrides.ColorScale.Select(i => i.ToString()),
            "normalStrength" => template.Overrides.NormalStrength.Select(i => i.ToString()),
            _ => [],
        };


        return ret.Where(s => !string.IsNullOrEmpty(s)).Select(s => s!).ToArray();
    }

    public List<IRedRef> CollectDependencies(IRedRef redRef)
    {
        if (redRef.DepotPath == ResourcePath.Empty || redRef.DepotPath.GetResolvedText() is not string depotPath)
        {
            return [];
        }

        if (!(depotPath.EndsWith(".app") || depotPath.EndsWith(".ent")))
        {
            return [redRef];
        }

        if (ReadCr2WFromRelativePath(depotPath) is not { } cr2W)
        {
            _loggerService.Error("failed to read cr2w file: " + depotPath);
            return [];
        }

        var refs = cr2W.FindType(typeof(IRedRef))
            .Select(r => r.Value)
            .OfType<IRedRef>()
            .Where(r => r.DepotPath != ResourcePath.Empty)
            .SelectMany(CollectDependencies)
            .DistinctBy(r => r.DepotPath.GetResolvedText() ?? "")
            .ToList();

        return refs;
    }
}
