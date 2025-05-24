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

namespace WolvenKit.App.Helpers;

public class DocumentTools
{
    private readonly ILoggerService _loggerService;
    private readonly Cr2WTools _cr2WTools;
    private readonly IArchiveManager _archiveManager;
    private readonly IProjectManager _projectManager;

    public static Regex PlaceholderRegex { get; } = new Regex(@"^[-=_]+$");

    public DocumentTools(ILoggerService loggerService, Cr2WTools cr2WTools, IArchiveManager archiveManager,
        IProjectManager projectManager)
    {
        _loggerService = loggerService;
        _cr2WTools = cr2WTools;
        _archiveManager = archiveManager;
        _projectManager = projectManager;
    }


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

        // initial opening of file
        if (!refreshCache)
        {
            return [];
        }
        
        List<string> appAppearances = [];

        if (activeProject.GetAbsolutePath(relativeAppFilePath) is string absolutePath && File.Exists(absolutePath))
        {
            if (_cr2WTools.ReadCr2W(absolutePath) is CR2WFile cr2W)
            {
                appAppearances = GetAppearanceNamesFromApp(cr2W);
            }

            s_appAppearancesByPath.Add(relativeAppFilePath, appAppearances);
            return appAppearances;
        }

        var appFile = _archiveManager.GetGameFile(relativeAppResourcePath, true, false);
        if (appFile is null)
        {
            s_appAppearancesByPath.Add(relativeAppFilePath, []);
            return [];
        }

        switch (appFile.Scope)
        {
            case ArchiveManagerScope.Mods:
                appAppearances = GetAppearanceNamesFromApp(_archiveManager.GetCR2WFile(appFile.FileName, true));
                break;
            case ArchiveManagerScope.Basegame:
                appAppearances = GetAppearanceNamesFromApp(_archiveManager.GetCR2WFile(appFile.FileName, false));
                break;
            default:
                break;
        }

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

        var meshFile = _archiveManager.GetGameFile(relativeMeshFilePath, true, true);

        if (meshFile is null)
        {
            s_meshAppearancesByPath.Add(relativeMeshFilePath, meshAppearances);
            return meshAppearances;
        }

        switch (meshFile.Scope)
        {
            case ArchiveManagerScope.Mods:
                meshAppearances = GetAppearanceNamesFromMesh(_archiveManager.GetCR2WFile(meshFile.FileName, true));
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


    private static readonly Dictionary<string, List<CMaterialParameter>> s_materialProperties = [];

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

        return _archiveManager.GetCR2WFile(relativePath, true, true);
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
        else if (ReadCr2WFromRelativePath(materialPath) is not { RootChunk: CMaterialTemplate template })
        {
            ret = [];
        }
        else if (forceCacheRefresh)
        {
            s_materialProperties.Remove(materialPath);
            List<CMaterialParameter> templateMaterials = [];

            var matMaterials = template.Parameters[2];
            for (var i = 0; i < matMaterials.Count; i++)
            {
                if (matMaterials[i] is not IRedHandle<CMaterialParameter> entry ||
                    entry.GetValue() is not CMaterialParameter material)
                {
                    continue;
                }

                templateMaterials.Add(material);
            }

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
}