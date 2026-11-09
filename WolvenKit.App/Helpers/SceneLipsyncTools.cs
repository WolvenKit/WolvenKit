using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Generates scene lipsync anim sets, lipmap entries, and ArchiveXL registrations.
/// </summary>
public class SceneLipsyncTools
{
    private const string lipmapExtension = ".lipmap";
    private const string animSetExtension = ".anims";
    private const string baseLipmapFolder = @"base\localization";
    private const string modsFolder = "mod";
    private const string localizationFolder = "localization";
    private const string lipsyncFolder = "lipsync";
    private const string archiveXlFileNameSuffix = "_lipsync.archive.xl";
    private const string archiveXlExtension = ".xl";
    private const string archiveXlLocalizationKey = "localization";
    private const string archiveXlLipmapsKey = "lipmaps";
    private const string sceneReferenceLanguage = "en-us";
    private const int reportedLineCount = 5;

    private readonly IAppArchiveManager _archiveManager;
    private readonly IArchiveManagerLoader _archiveManagerLoader;
    private readonly IProjectManager _projectManager;
    private readonly Cr2WTools _cr2WTools;
    private readonly ILoggerService _loggerService;

    public SceneLipsyncTools(
        IAppArchiveManager archiveManager,
        IArchiveManagerLoader archiveManagerLoader,
        IProjectManager projectManager,
        Cr2WTools cr2WTools,
        ILoggerService loggerService)
    {
        _archiveManager = archiveManager;
        _archiveManagerLoader = archiveManagerLoader;
        _projectManager = projectManager;
        _cr2WTools = cr2WTools;
        _loggerService = loggerService;
    }

    /// <summary>
    /// Generates per-voice lipsync assets for every installed voice-over language.
    /// </summary>
    /// <remarks>
    /// Existing assets are reused. The scene is read-only and its lines must already name their
    /// animations. Start this on the UI thread because archive loading reports progress there. Unused
    /// generated anim sets are not deleted.
    /// </remarks>
    /// <param name="scene">The scene to read.</param>
    /// <param name="sceneRelativePath">The scene's depot path in the project archive.</param>
    /// <returns>The generated file count and the anim sets the scene should reference.</returns>
    /// <exception cref="InvalidOperationException">
    /// The project, scene path, or game archives are unavailable.
    /// </exception>
    public async Task<SceneLipsyncResult> GenerateLipsyncAnimSetsAsync(scnSceneResource scene, string sceneRelativePath)
    {
        if (_projectManager.ActiveProject is not Cp77Project project)
        {
            throw new InvalidOperationException("Open a project before generating lipsync anim sets.");
        }

        if (Path.IsPathRooted(sceneRelativePath))
        {
            throw new InvalidOperationException(
                $"The scene is not in the project's archive folder. Add it to the project first: {sceneRelativePath}");
        }

        await EnsureGameArchivesLoadedAsync();

        return await Task.Run(() => GenerateLipsyncAnimSets(project, scene, sceneRelativePath));
    }

    /// <summary>Loads the base-game archives if needed.</summary>
    private async Task EnsureGameArchivesLoadedAsync()
    {
        if (_archiveManager.IsManagerLoaded)
        {
            return;
        }

        _loggerService.Info("Lipsync: loading the game archives the animations are copied from...");
        await _archiveManagerLoader.LoadArchiveManagerAsync();

        if (_archiveManager.IsManagerLoaded)
        {
            return;
        }

        // Loading may be skipped while another load runs or when no game path is set.
        throw new InvalidOperationException(_archiveManager.IsManagerLoading
            ? "The game archives are still loading. Wait for WolvenKit to finish loading them, then try again."
            : "The game archives could not be loaded. Check that the game executable path is set in the settings.");
    }

    /// <summary>Generates lipsync assets after validating the project and game archives.</summary>
    private SceneLipsyncResult GenerateLipsyncAnimSets(Cp77Project project, scnSceneResource scene, string sceneRelativePath)
    {
        var baseLipmaps = FindBaseLipmaps();
        if (baseLipmaps.Count == 0)
        {
            throw new InvalidOperationException(
                $"The game has no lipsync to copy from: no lipmap was found in {baseLipmapFolder}. Is a voice-over language installed?");
        }

        var voices = SceneEditingHelper.CollectLipsyncVoices(scene);
        foreach (var voice in voices.Where(voice => !voice.HasVoicetag))
        {
            _loggerService.Warning(
                $"Lipsync: actor '{voice.ActorName}' has no voicetag, so its {voice.Lines.Count} line(s) get no lipsync. " +
                "Give the actor the voicetag of the character who recorded them.");
        }

        var lipsyncVoices = voices.Where(voice => voice.HasVoicetag && voice.AnimationNames.Any()).ToList();
        if (lipsyncVoices.Count == 0)
        {
            _loggerService.Warning(
                "Lipsync: no dialogue line names a lipsync animation and is spoken by an actor with a voicetag.");
        }

        CUInt64 scenePathHash = ResourcePath.CalculateHash(sceneRelativePath);
        // Match the folder convention used by the quest generator.
        var modFolder = Path.Join(modsFolder, project.Name);

        var projectFiles = project.ModFiles;
        var sceneName = Path.GetFileNameWithoutExtension(sceneRelativePath);
        var sceneAnimSetFolders = FindSceneAnimSetFolders(projectFiles, sceneName);
        var projectLipmaps = ReadProjectLipmaps(project, projectFiles);

        var sceneAnimSetsByVoicetag = new Dictionary<CRUID, ResourcePath>();
        var lipmapsByLanguage = new Dictionary<string, string>();
        var writtenAnimSets = 0;

        foreach (var (language, baseLipmapPath) in baseLipmaps)
        {
            var animSetFolder = GetAnimSetFolder(sceneAnimSetFolders, modFolder, language, sceneName);
            var voiceStates = CreateVoiceGenerationStates(lipsyncVoices, animSetFolder);
            var projectLipmap = SelectProjectLipmap(
                projectLipmaps, modFolder, project.Name, language, scenePathHash);

            // Reuse generated animations before searching base-game assets.
            ReuseGeneratedAnimations(
                project, language, voiceStates, projectLipmap.Mapping?.GetSceneEntry(scenePathHash));

            if (voiceStates.Any(state => state.WantedNames.Count > 0))
            {
                _loggerService.Info($"Lipsync ({language}): searching the base game anim sets for the lines still without animation...");
                CopyVoiceAnimations(language, voiceStates, ReadAnimSetsByVoicetag(baseLipmapPath));
            }
            else if (lipsyncVoices.Count > 0)
            {
                _loggerService.Info(
                    $"Lipsync ({language}): every line naming an animation has one generated before, so the base game is not searched.");
            }

            var entry = new animLipsyncMappingSceneEntry();

            foreach (var state in voiceStates)
            {
                ReportLinesWithoutAnimation(language, state.Voice, state.MissingNames);

                if (state.AnimSet.Animations.Count == 0)
                {
                    continue;
                }

                WriteFile(project, state.OutputPath, state.AnimSet);

                entry.ActorVoiceTags.Add(state.Voice.VoicetagId);
                entry.AnimSets.Add(new CResourceAsyncReference<animAnimSet>(state.OutputPath));
                writtenAnimSets++;

                if (language == sceneReferenceLanguage)
                {
                    sceneAnimSetsByVoicetag[state.Voice.VoicetagId] = state.OutputPath;
                }
                else
                {
                    sceneAnimSetsByVoicetag.TryAdd(state.Voice.VoicetagId, state.OutputPath);
                }

                _loggerService.Info(
                    $"Lipsync ({language}): wrote {state.AnimSet.Animations.Count} animation(s) of " +
                    $"'{state.Voice.ActorName}' to {state.OutputPath}");
            }

            if (WriteSceneEntry(
                    project, projectLipmap.RelativePath, projectLipmap.Mapping, language, scenePathHash, entry))
            {
                lipmapsByLanguage.Add(language, projectLipmap.RelativePath);
            }

            if (entry.AnimSets.Count > 0)
            {
                _loggerService.Info(
                    $"Lipsync ({language}): registered the scene's anim sets in {projectLipmap.RelativePath}");
            }
        }

        RegisterLipmaps(project, lipmapsByLanguage);

        return new SceneLipsyncResult(writtenAnimSets, sceneAnimSetsByVoicetag);
    }

    /// <summary>Returns an existing language-specific scene folder, or the default folder.</summary>
    private static string GetAnimSetFolder(
        List<string> sceneAnimSetFolders,
        string modFolder,
        string language,
        string sceneName) =>
        sceneAnimSetFolders.FirstOrDefault(folder => IsForLanguage(folder, language))
        ?? Path.Join(modFolder, localizationFolder, language, lipsyncFolder, sceneName);

    /// <summary>Finds project anim-set folders named after the scene.</summary>
    private static List<string> FindSceneAnimSetFolders(List<string> projectFiles, string sceneName) =>
        projectFiles
            .Where(path => path.EndsWith(animSetExtension, StringComparison.OrdinalIgnoreCase))
            .Select(Path.GetDirectoryName)
            .OfType<string>()
            .Where(folder => string.Equals(Path.GetFileName(folder), sceneName, StringComparison.OrdinalIgnoreCase))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(folder => folder, StringComparer.OrdinalIgnoreCase)
            .ToList();

    /// <summary>Selects a language lipmap, preferring one that already contains the scene.</summary>
    private static (string RelativePath, animLipsyncMapping? Mapping) SelectProjectLipmap(
        List<(string RelativePath, animLipsyncMapping Mapping)> projectLipmaps,
        string modFolder,
        string projectName,
        string language,
        CUInt64 scenePathHash)
    {
        var languageLipmaps = GetLanguageLipmaps(projectLipmaps, language);
        var selectedLipmap = languageLipmaps
            .FirstOrDefault(lipmap => lipmap.Mapping.GetSceneEntry(scenePathHash) is not null);

        if (selectedLipmap.Mapping is not null)
        {
            return selectedLipmap;
        }

        if (languageLipmaps.FirstOrDefault() is { Mapping: not null } firstLipmap)
        {
            return firstLipmap;
        }

        return (Path.Join(modFolder, localizationFolder, language, projectName + lipmapExtension), null);
    }

    /// <summary>Filters lipmaps by language metadata or path.</summary>
    private static List<(string RelativePath, animLipsyncMapping Mapping)> GetLanguageLipmaps(
        List<(string RelativePath, animLipsyncMapping Mapping)> projectLipmaps,
        string language) =>
        projectLipmaps
            .Where(lipmap => CName.IsNullOrEmpty(lipmap.Mapping.LanguageCodeName)
                ? IsForLanguage(lipmap.RelativePath, language)
                : string.Equals((string?)lipmap.Mapping.LanguageCodeName, language, StringComparison.OrdinalIgnoreCase))
            .ToList();

    /// <summary>Reuses previously generated animations that the scene still needs.</summary>
    private void ReuseGeneratedAnimations(
        Cp77Project project,
        string language,
        List<VoiceGenerationState> voiceStates,
        animLipsyncMappingSceneEntry? generatedEntry)
    {
        foreach (var state in voiceStates)
        {
            foreach (var generatedPath in GetGeneratedAnimSetPaths(state.Voice, generatedEntry, state.OutputPath))
            {
                if (state.MissingNames.Count == 0)
                {
                    break;
                }

                if (ReadProjectResource<animAnimSet>(project, generatedPath) is { } generated &&
                    CanTakeAnimationsOf(state.AnimSet, generated))
                {
                    CopyAnimations(language, generated, generatedPath, state.AnimSet, state.MissingNames);
                }
            }

            RefreshWantedNames(state);

            if (state.AnimSet.Animations.Count > 0)
            {
                _loggerService.Info(
                    $"Lipsync ({language}): reused {state.AnimSet.Animations.Count} animation(s) of " +
                    $"'{state.Voice.ActorName}' generated before.");
            }
        }
    }

    /// <summary>Gets possible outputs from a previous generation, without duplicates.</summary>
    private static List<string> GetGeneratedAnimSetPaths(
        SceneLipsyncVoice voice,
        animLipsyncMappingSceneEntry? generatedEntry,
        string animSetPath)
    {
        var paths = new List<string>();

        if (generatedEntry is not null)
        {
            foreach (var (voicetag, animSet) in generatedEntry.ActorVoiceTags.Zip(generatedEntry.AnimSets))
            {
                if (voicetag.Equals(voice.VoicetagId) &&
                    animSet.DepotPath.GetResolvedText() is { } path &&
                    !paths.Contains(path, StringComparer.OrdinalIgnoreCase))
                {
                    paths.Add(path);
                }
            }
        }

        if (!paths.Contains(animSetPath, StringComparer.OrdinalIgnoreCase))
        {
            paths.Add(animSetPath);
        }

        return paths;
    }

    private T? ReadProjectResource<T>(Cp77Project project, string relativePath) where T : CResource =>
        _cr2WTools.ReadCr2WNoException(Path.Join(project.ModDirectory, relativePath))?.RootChunk as T;

    private T? ReadBaseResource<T>(ResourcePath path) where T : CResource =>
        _archiveManager.GetCR2WFile(path, false, false)?.RootChunk as T;

    /// <summary>Reads valid project lipmaps in path order.</summary>
    private List<(string RelativePath, animLipsyncMapping Mapping)> ReadProjectLipmaps(
        Cp77Project project,
        List<string> projectFiles)
    {
        var lipmaps = new List<(string RelativePath, animLipsyncMapping Mapping)>();

        foreach (var relativePath in projectFiles
                     .Where(path => path.EndsWith(lipmapExtension, StringComparison.OrdinalIgnoreCase))
                     .OrderBy(path => path, StringComparer.OrdinalIgnoreCase))
        {
            if (ReadProjectResource<animLipsyncMapping>(project, relativePath) is { } mapping)
            {
                lipmaps.Add((relativePath, mapping));
            }
        }

        return lipmaps;
    }

    /// <summary>Checks whether a path segment or file name matches a language code.</summary>
    private static bool IsForLanguage(string relativePath, string language) =>
        Path.ChangeExtension(relativePath, null)
            .Split(Path.DirectorySeparatorChar)
            .Contains(language, StringComparer.OrdinalIgnoreCase);

    /// <summary>Finds installed base-game lipmaps by language code.</summary>
    private List<(string Language, ResourcePath Path)> FindBaseLipmaps() =>
        _archiveManager.Search(lipmapExtension, ArchiveManagerScope.Basegame)
            .Select(file => file.FileName)
            .Where(path => path.EndsWith(lipmapExtension, StringComparison.OrdinalIgnoreCase) &&
                           string.Equals(Path.GetDirectoryName(path), baseLipmapFolder, StringComparison.OrdinalIgnoreCase))
            .Select(path => (Path.GetFileNameWithoutExtension(path), (ResourcePath)path))
            .OrderBy(lipmap => lipmap.Item1, StringComparer.Ordinal)
            .ToList();

    /// <summary>Collects unique anim-set paths for each voicetag in a base-game lipmap.</summary>
    private Dictionary<CRUID, List<ResourcePath>> ReadAnimSetsByVoicetag(ResourcePath lipmapPath)
    {
        var animSetsByVoicetag = new Dictionary<CRUID, List<ResourcePath>>();

        if (ReadBaseResource<animLipsyncMapping>(lipmapPath) is not { } mapping)
        {
            _loggerService.Warning($"Lipsync: could not read the base game lipmap {lipmapPath.GetResolvedText()}.");
            return animSetsByVoicetag;
        }

        foreach (var sceneEntry in mapping.SceneEntries)
        {
            foreach (var (voicetag, animSet) in sceneEntry.ActorVoiceTags.Zip(sceneEntry.AnimSets))
            {
                if (!animSetsByVoicetag.TryGetValue(voicetag, out var animSetPaths))
                {
                    animSetPaths = [];
                    animSetsByVoicetag.Add(voicetag, animSetPaths);
                }

                if (!animSetPaths.Contains(animSet.DepotPath))
                {
                    animSetPaths.Add(animSet.DepotPath);
                }
            }
        }

        return animSetsByVoicetag;
    }

    /// <summary>Copies missing animations, searching the voice's voicetag first.</summary>
    /// <remarks>Either the female or male animation satisfies a line.</remarks>
    private void CopyVoiceAnimations(
        string language,
        List<VoiceGenerationState> voiceStates,
        Dictionary<CRUID, List<ResourcePath>> animSetsByVoicetag)
    {
        foreach (var state in voiceStates)
        {
            if (state.WantedNames.Count == 0)
            {
                continue;
            }

            if (!animSetsByVoicetag.TryGetValue(state.Voice.VoicetagId, out var sourcePaths))
            {
                _loggerService.Warning(
                    $"Lipsync ({language}): the base game has no lipsync for the voicetag of '{state.Voice.ActorName}'. " +
                    "Its lines are searched for under the other voicetags.");
                continue;
            }

            foreach (var sourcePath in sourcePaths)
            {
                if (ReadBaseResource<animAnimSet>(sourcePath) is not { } source)
                {
                    continue;
                }

                CopyWantedAnimations(language, state, source, sourcePath, state.Voice.VoicetagId);
                if (state.WantedNames.Count == 0)
                {
                    break;
                }
            }
        }

        CopyAnimationsOfOtherVoicetags(language, voiceStates, animSetsByVoicetag);
    }

    /// <summary>Searches other voicetags for animations still missing from each voice.</summary>
    private void CopyAnimationsOfOtherVoicetags(
        string language,
        List<VoiceGenerationState> voiceStates,
        Dictionary<CRUID, List<ResourcePath>> animSetsByVoicetag)
    {
        var wantedVoiceCount = voiceStates.Count(state => state.WantedNames.Count > 0);
        if (wantedVoiceCount == 0)
        {
            return;
        }

        _loggerService.Info(
            $"Lipsync ({language}): searching the anim sets of the other voicetags for the lines of " +
            $"{wantedVoiceCount} voice(s) still without animation. This can take a while...");

        foreach (var (voicetag, sourcePaths) in animSetsByVoicetag)
        {
            foreach (var sourcePath in sourcePaths)
            {
                var searchingStates = voiceStates
                    .Where(state => state.WantedNames.Count > 0 && !state.Voice.VoicetagId.Equals(voicetag))
                    .ToList();

                if (searchingStates.Count == 0)
                {
                    break;
                }

                if (ReadBaseResource<animAnimSet>(sourcePath) is not { } source)
                {
                    continue;
                }

                foreach (var state in searchingStates)
                {
                    CopyWantedAnimations(language, state, source, sourcePath, voicetag);
                }
            }

            if (voiceStates.All(state => state.WantedNames.Count == 0))
            {
                return;
            }
        }
    }

    /// <summary>Copies wanted animations from a compatible source anim set.</summary>
    private void CopyWantedAnimations(
        string language,
        VoiceGenerationState state,
        animAnimSet source,
        ResourcePath sourcePath,
        CRUID sourceVoicetag)
    {
        var isOtherVoicetag = !sourceVoicetag.Equals(state.Voice.VoicetagId);

        if (!CanTakeAnimationsOf(state.AnimSet, source))
        {
            if (isOtherVoicetag && source.Animations.Any(handle =>
                    handle?.Chunk is { Animation.Chunk: { } animation } && state.WantedNames.Contains(animation.Name)))
            {
                _loggerService.Warning(
                    $"Lipsync ({language}): {sourcePath.GetResolvedText()}, recorded under voicetag {(ulong)sourceVoicetag}, " +
                    $"holds animations of '{state.Voice.ActorName}' but for another rig than the " +
                    $"{state.AnimSet.Animations.Count} " +
                    "animation(s) already copied, so they were left out: an anim set drives a single rig.");
            }

            return;
        }

        var copiedNames = CopyAnimations(language, source, sourcePath, state.AnimSet, state.WantedNames);
        if (copiedNames.Count == 0)
        {
            return;
        }

        state.MissingNames.ExceptWith(copiedNames);

        if (isOtherVoicetag)
        {
            _loggerService.Warning(
                $"Lipsync ({language}): copied {string.Join(", ", copiedNames)} of '{state.Voice.ActorName}' from " +
                $"{sourcePath.GetResolvedText()}, recorded under voicetag {(ulong)sourceVoicetag} rather than the actor's. " +
                "Check the actor's voicetag: an animation recorded for another character may not fit its face.");
        }

        RefreshWantedNames(state);
    }

    /// <summary>Checks whether the source uses the destination anim set's rig.</summary>
    private static bool CanTakeAnimationsOf(animAnimSet animSet, animAnimSet source) =>
        animSet.Animations.Count == 0 || source.Rig.DepotPath == animSet.Rig.DepotPath;

    /// <summary>Copies named animations and removes successful copies from the requested names.</summary>
    private List<CName> CopyAnimations(
        string language,
        animAnimSet source,
        ResourcePath sourcePath,
        animAnimSet animSet,
        HashSet<CName> names)
    {
        var copiedNames = new List<CName>();

        foreach (var animationHandle in source.Animations)
        {
            if (animationHandle?.Chunk is not { Animation.Chunk: { } animation } sourceAnimation ||
                !names.Contains(animation.Name))
            {
                continue;
            }

            if (!ModTools.CanCopyAnimation(source, sourceAnimation))
            {
                _loggerService.Warning(
                    $"Lipsync ({language}): {animation.Name} in {sourcePath.GetResolvedText()} is not stored in a way " +
                    "that can be copied yet, so it was left out.");
                continue;
            }

            if (animSet.Animations.Count == 0)
            {
                animSet.Rig = new CResourceReference<animRig>(source.Rig.DepotPath, source.Rig.Flags);
            }

            ModTools.CopyAnimation(source, sourceAnimation, animSet.Animations, animSet.AnimationDataChunks);
            names.Remove(animation.Name);
            copiedNames.Add(animation.Name);
        }

        return copiedNames;
    }

    /// <summary>Logs dialogue lines for which no animation was found.</summary>
    private void ReportLinesWithoutAnimation(string language, SceneLipsyncVoice voice, HashSet<CName> missingNames)
    {
        var linesWithoutAnimation = GetLinesWithoutAnimation(voice, missingNames).ToList();
        if (linesWithoutAnimation.Count == 0)
        {
            return;
        }

        var examples = string.Join(", ", linesWithoutAnimation
            .Take(reportedLineCount)
            .Select(line => $"line {(uint)line.ItemId.Id} ({line.FemaleLipsyncAnimationName})"));

        _loggerService.Warning(
            $"Lipsync ({language}): no base game animation was found for {linesWithoutAnimation.Count} of the " +
            $"{voice.Lines.Count} line(s) of '{voice.ActorName}', e.g. {examples}.");
    }

    /// <summary>Gets lines missing both female and male animations.</summary>
    private static IEnumerable<scnscreenplayDialogLine> GetLinesWithoutAnimation(
        SceneLipsyncVoice voice,
        HashSet<CName> missingNames)
    {
        return voice.Lines.Where(line => IsMissing(line.FemaleLipsyncAnimationName) && IsMissing(line.MaleLipsyncAnimationName));

        bool IsMissing(CName name) => CName.IsNullOrEmpty(name) || missingNames.Contains(name);
    }

    /// <summary>Gets missing names for lines with no animation.</summary>
    private static HashSet<CName> GetNamesOfLinesWithoutAnimation(SceneLipsyncVoice voice, HashSet<CName> missingNames) =>
        GetLinesWithoutAnimation(voice, missingNames)
            .SelectMany(line => new[] { line.FemaleLipsyncAnimationName, line.MaleLipsyncAnimationName })
            .Where(missingNames.Contains)
            .ToHashSet();

    private static void RefreshWantedNames(VoiceGenerationState state)
    {
        state.WantedNames.Clear();
        state.WantedNames.UnionWith(GetNamesOfLinesWithoutAnimation(state.Voice, state.MissingNames));
    }

    /// <summary>Writes or removes a scene's lipmap entry.</summary>
    /// <returns>Whether the lipmap still contains any scenes.</returns>
    private bool WriteSceneEntry(
        Cp77Project project,
        string lipmapRelativePath,
        animLipsyncMapping? mapping,
        string language,
        CUInt64 scenePathHash,
        animLipsyncMappingSceneEntry entry)
    {
        if (mapping is null && File.Exists(Path.Join(project.ModDirectory, lipmapRelativePath)))
        {
            throw new InvalidDataException(
                $"{lipmapRelativePath} is in the way of the project's lipmap but is not one. Move it, then try again.");
        }

        if (entry.AnimSets.Count == 0)
        {
            if (mapping is null || !mapping.RemoveSceneEntry(scenePathHash))
            {
                return mapping is { ScenePaths.Count: > 0 };
            }
        }
        else
        {
            mapping ??= new animLipsyncMapping
            {
                CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
                LanguageCodeName = language,
            };
            mapping.SetSceneEntry(scenePathHash, entry);
        }

        WriteFile(project, lipmapRelativePath, mapping);
        return mapping.ScenePaths.Count > 0;
    }

    /// <summary>Registers unlisted lipmaps in the project's lipsync ArchiveXL file.</summary>
    private void RegisterLipmaps(Cp77Project project, Dictionary<string, string> lipmapsByLanguage)
    {
        if (lipmapsByLanguage.Count == 0)
        {
            return;
        }

        var registeredLipmaps = FindRegisteredLipmaps(project);
        var unregisteredLipmaps = lipmapsByLanguage
            .Where(lipmap => !registeredLipmaps.Contains(
                (lipmap.Key.ToLowerInvariant(), (ResourcePath)ResourcePath.CalculateHash(lipmap.Value))))
            .ToList();

        if (unregisteredLipmaps.Count == 0)
        {
            return;
        }

        var archiveXlFileName = project.Name + archiveXlFileNameSuffix;
        var archiveXlAbsolutePath = Path.Join(project.ResourcesDirectory, archiveXlFileName);

        var rootNode = YamlHelper.ReadYamlAsNodes(archiveXlAbsolutePath) ?? new YamlMappingNode();
        var lipmapsNode = YamlHelper.EnsureNestedMapping(rootNode, archiveXlLocalizationKey, archiveXlLipmapsKey);

        var isChanged = false;
        foreach (var (language, lipmapRelativePath) in unregisteredLipmaps)
        {
            isChanged |= YamlHelper.AddToScalarOrSequence(
                lipmapsNode, language, lipmapRelativePath, StringComparison.OrdinalIgnoreCase);
        }

        if (!isChanged)
        {
            return;
        }

        YamlHelper.WriteYaml(archiveXlAbsolutePath, rootNode);
        _loggerService.Info($"Lipsync: registered the lipmaps in {archiveXlFileName}");
    }

    /// <summary>Finds lipmaps registered by the project's ArchiveXL files.</summary>
    private HashSet<(string Language, ResourcePath LipmapPath)> FindRegisteredLipmaps(Cp77Project project)
    {
        var registeredLipmaps = new HashSet<(string Language, ResourcePath LipmapPath)>();

        foreach (var archiveXlRelativePath in project.ResourceFiles
                     .Where(path => path.EndsWith(archiveXlExtension, StringComparison.OrdinalIgnoreCase)))
        {
            YamlMappingNode? rootNode;
            try
            {
                rootNode = YamlHelper.ReadYamlAsNodes(Path.Join(project.ResourcesDirectory, archiveXlRelativePath));
            }
            catch (YamlException ex)
            {
                _loggerService.Warning(
                    $"Lipsync: could not read {archiveXlRelativePath} to check which lipmaps it registers: {ex.Message}");
                continue;
            }

            if (rootNode is null ||
                YamlHelper.FindNestedMapping(rootNode, archiveXlLocalizationKey, archiveXlLipmapsKey) is not { } lipmaps)
            {
                continue;
            }

            foreach (var (languageNode, registeredNode) in lipmaps.Children)
            {
                if (languageNode is not YamlScalarNode { Value: { } language })
                {
                    continue;
                }

                foreach (var pathNode in registeredNode is YamlSequenceNode sequence ? sequence.Children : [registeredNode])
                {
                    if (pathNode is YamlScalarNode { Value: { } path } && !string.IsNullOrWhiteSpace(path))
                    {
                        registeredLipmaps.Add((language.ToLowerInvariant(), (ResourcePath)ResourcePath.CalculateHash(path)));
                    }
                }
            }
        }

        return registeredLipmaps;
    }

    /// <summary>Creates generation state with unique, sanitized anim-set file names.</summary>
    private static List<VoiceGenerationState> CreateVoiceGenerationStates(
        List<SceneLipsyncVoice> voices,
        string animSetFolder)
    {
        var states = new List<VoiceGenerationState>();
        var usedFileNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var voice in voices)
        {
            var fileName = ((string)voice.ActorName).ToArchiveFileName();
            if (fileName.Length == 0 || !usedFileNames.Add(fileName))
            {
                fileName = $"{fileName}_{(ulong)voice.VoicetagId:x16}".TrimStart('_');
                usedFileNames.Add(fileName);
            }

            states.Add(new VoiceGenerationState(
                voice, Path.Join(animSetFolder, fileName + animSetExtension)));
        }

        return states;
    }

    private sealed class VoiceGenerationState
    {
        public VoiceGenerationState(SceneLipsyncVoice voice, string outputPath)
        {
            Voice = voice;
            OutputPath = outputPath;
            MissingNames.UnionWith(voice.AnimationNames);
        }

        public SceneLipsyncVoice Voice { get; }

        public string OutputPath { get; }

        public animAnimSet AnimSet { get; } = new() { CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC };

        public HashSet<CName> MissingNames { get; } = [];

        public HashSet<CName> WantedNames { get; } = [];
    }

    /// <summary>Writes a resource to the project's archive folder.</summary>
    private void WriteFile(Cp77Project project, string relativePath, CResource resource)
    {
        if (!_cr2WTools.WriteCr2W(new CR2WFile { RootChunk = resource }, Path.Join(project.ModDirectory, relativePath)))
        {
            throw new IOException($"Could not write {relativePath}. The log above says why.");
        }
    }
}

/// <summary>
/// Dialogue lines grouped by voicetag for one generated anim set.
/// </summary>
public sealed class SceneLipsyncVoice
{
    public SceneLipsyncVoice(CRUID voicetagId, CString actorName)
    {
        VoicetagId = voicetagId;
        ActorName = actorName;
    }

    /// <summary>The shared voicetag, or zero for an untagged actor.</summary>
    public CRUID VoicetagId { get; }

    /// <summary>The first matching actor's name.</summary>
    public CString ActorName { get; }

    /// <summary>The lines spoken with this voice, in screenplay order.</summary>
    public List<scnscreenplayDialogLine> Lines { get; } = [];

    /// <summary>
    /// Distinct female and male animation names used by the lines.
    /// </summary>
    public IEnumerable<CName> AnimationNames => Lines
        .SelectMany(line => new[] { line.FemaleLipsyncAnimationName, line.MaleLipsyncAnimationName })
        .Where(name => !CName.IsNullOrEmpty(name))
        .Distinct();

    /// <summary>Whether the voice can be referenced by a lipmap entry.</summary>
    public bool HasVoicetag => (ulong)VoicetagId != 0;
}

/// <summary>Describes the files generated for a scene.</summary>
/// <param name="WrittenAnimSetCount">Number of anim sets written across all languages.</param>
/// <param name="SceneAnimSetsByVoicetag">
/// Anim sets the scene should reference, preferring en-us when available.
/// </param>
public sealed record SceneLipsyncResult(
    int WrittenAnimSetCount,
    IReadOnlyDictionary<CRUID, ResourcePath> SceneAnimSetsByVoicetag);
