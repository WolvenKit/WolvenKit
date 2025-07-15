using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using Splat;

namespace WolvenKit.App.Helpers;

/// <summary>
/// This class takes a <see cref="ChunkViewModel"/> and returns a list of compatible strings for the view.
/// </summary>
public abstract class CvmDropdownHelper
{

    // Scanned through 1000+ .app files to find these. If you encounter any others, write a ticket :)
    private static readonly List<string> s_appFileRenderPlane =
        ["renderPlane", "renderPlaneLeftArm", "renderPlaneRightArm"];

    // Any tags for .app files
    private static readonly List<string> s_appTags =
    [
        "AppearanceParts", // enable partsValues for non-player equipment
        "hide_Head", "hide_Torso", "hide_LowerAbdomen", "hide_UpperAbdomen", "hide_CollarBone",
        "hide_Arms", "hide_Thighs", "hide_Calves", "hide_Ankles", "hide_Feet", "hide_Legs",
    ];

    // Any tags for root entity files
    private static readonly List<string> s_rootEntityTags =
    [
        "DynamicAppearance",
        "force_Hair",
        "HighHeels", "FlatShoes", "Boots", "Heels", "Sneakers", "Stilettos", "Metal_feet",
    ];

    // Any tags for mesh entity files
    private static readonly List<string> s_meshEntityTags =
    [
        "PlayerBodyPart", "Tight", "Normal", "Large", "XLarge"
    ];

    private static readonly List<string> s_questHandleParentNames =
    [
        "path", "contact", "caller", "addressee", "briefingPath", "mappinPath"
    ];

    private static readonly List<string> s_appearanceNames =
    [
        "meshAppearance", "appearanceName"
    ];

    private static readonly List<string> s_multilayerProperties =
    [
        "metalLevelsIn",
        "metalLevelsOut",
        "roughLevelsIn",
        "roughLevelsOut",
        "colorScale",
        "normalStrength",
        "microblend"
    ];

    /// <summary>
    /// Finds the scene resource context, either from the root model or from the current document
    /// </summary>
    private static scnSceneResource? GetSceneContext(ChunkViewModel cvm)
    {
        // First try the normal root model approach
        var rootModel = cvm.GetRootModel();
        if (rootModel?.ResolvedData is scnSceneResource sceneFromRoot)
        {
            return sceneFromRoot;
        }


        // If that doesn't work, we might be in the graph editor context
        // Try to get the scene from the current document
        try
        {
            var appViewModel = Locator.Current.GetService<App.ViewModels.Shell.AppViewModel>();

            if (appViewModel?.ActiveDocument is RedDocumentViewModel redDoc)
            {

                // Check if we have a SceneGraphViewModel
                if (redDoc.SelectedTabItemViewModel is SceneGraphViewModel combinedScene)
                {
                    var sceneRootChunk = combinedScene.RDTViewModel.GetRootChunk();

                    if (sceneRootChunk?.ResolvedData is scnSceneResource sceneFromCombined)
                    {
                        return sceneFromCombined;
                    }
                }

                // Check if we have an RDTDataViewModel with scene data
                if (redDoc.SelectedTabItemViewModel is RDTDataViewModel rdtTab)
                {
                    var rdtRootChunk = rdtTab.GetRootChunk();

                    if (rdtRootChunk?.ResolvedData is scnSceneResource sceneFromRdt)
                    {
                        return sceneFromRdt;
                    }
                }
            }
        }
        catch (System.Exception)
        {
            // Fallback gracefully if service lookup fails
        }
        return null;
    }


    public static Dictionary<string, string> GetDropdownOptions(ChunkViewModel cvm, DocumentTools documentTools,
        bool forceCacheRefresh = false, string? filter = null)
    {
        if (cvm.Parent is not ChunkViewModel parent)
        {
            return [];
        }

        IEnumerable<string?> ret = [];
        switch (parent.ResolvedData)
        {
            case gameJournalPath when cvm.Name is "className" && s_questHandleParentNames.Contains(parent.Name):
                ret = RedTypeHelper.GetExtendingClassNames(typeof(gameJournalEntry));
                break;
            case gameJournalPath when cvm.Name is "realPath":
                ret = documentTools.GetAllJournalPathsAsync(forceCacheRefresh, filter).Result;
                break;
            case entISkinTargetComponent when cvm.Name is "renderingPlaneAnimationParam":
                ret = s_appFileRenderPlane;
                break;

            #region appFile
            case CArray<CName> when parent is // tags in .app file appearance
            {
                Name: "tags", Parent: { ResolvedData: redTagList, Parent.ResolvedData: appearanceAppearanceDefinition }
            }:
                ret = s_appTags;
                break;

            case appearanceAppearancePart when cvm.Name is "resource":
                ret = documentTools.CollectProjectFiles(".ent");
                break;

            #endregion

            #region entFile
            // root entity tag
            case CArray<CName>
                when parent.Name is "tags" && cvm.GetRootModel() is
                    { ResolvedData: entEntityTemplate { Entity.Chunk: gameObject } }:
                ret = s_rootEntityTags;
                break;
            // root entity appearance
            case entTemplateAppearance entAppearance when cvm.Name is "appearanceName":
                ret = documentTools.GetAppearanceNamesFromApp(
                    entAppearance.AppearanceResource.DepotPath,
                    forceCacheRefresh);
                break;
            // root entity: .app file paths
            case entTemplateAppearance when cvm.Name is "appearanceResource":
                ret = documentTools.CollectProjectFiles(".app");
                break;
            // mesh entity tag
            case CArray<CName>
                when parent.Name is "tags" && cvm.GetRootModel() is
                    { ResolvedData: entEntityTemplate { Entity.Chunk: not gameObject } }:
                ret = s_meshEntityTags;
                break;
            #endregion

            #region questPhaseFile
            case graphGraphNodeDefinition:
                switch (cvm.Name)
                {
                    case "phaseResource":
                        ret = documentTools.CollectProjectFiles(".questphase");
                        break;
                    case "sceneFile":
                        ret = documentTools.CollectProjectFiles(".scene");
                        break;
                    default:
                        break;
                }
                break;

            #endregion


            #region iComponent

            // mesh entity options
            case entSkinnedMeshComponent meshComp:
                switch (cvm.Name)
                {
                    case "meshAppearance":
                        ret = documentTools.GetAppearanceNamesFromMesh(meshComp.Mesh.DepotPath, forceCacheRefresh);
                        break;
                    case "mesh":
                        ret = documentTools.CollectProjectFiles(".mesh");
                        break;
                    default:
                        break;
                }
                break;
            case entMorphTargetSkinnedMeshComponent morphtargetMeshComp:
                ret = documentTools.GetAppearanceNamesFromMesh(morphtargetMeshComp.MorphResource.DepotPath,
                    forceCacheRefresh);
                break;

            #endregion

            #region mesh

            case CArray<CName> when parent is { Name: "chunkMaterials", Parent.Parent.Parent.ResolvedData: CMesh mesh }:
                ret = mesh.MaterialEntries.Select(entry => entry.Name.GetResolvedText()).Distinct();
                break;
            case CMaterialInstance when cvm.Name is "baseMaterial":
                ret = documentTools.GetAllBaseMaterials(forceCacheRefresh);
                break;
            case CKeyValuePair when parent.Parent?.Parent?.ResolvedData is CMaterialInstance matInstance &&
                                    matInstance.BaseMaterial.DepotPath.GetResolvedText() is string materialPath:
                ret = documentTools.GetMaterialKeys(parent.ResolvedData, materialPath, forceCacheRefresh);
                break;

            #endregion

            #region mlsetup

            case Multilayer_Layer mlLayer:
            {
                if (cvm.Name == "material")
                {
                    ret = documentTools.GetAllMultilayerTemplates(forceCacheRefresh);
                    break;
                }

                if (cvm.Name == "microblend")
                {
                    ret = documentTools.GetAllMicroblends(forceCacheRefresh);
                    break;
                }

                if (mlLayer.Material.DepotPath.GetResolvedText() is string materialPath)
                {
                    ret = documentTools.GetMultilayerProperties(materialPath, cvm.Name, forceCacheRefresh);
                }

                break;
            }

            #endregion

            default:
                break;
        }

        #region scenes

        if (cvm.Name == "id" && ReadSceneOptions() is Dictionary<string, string> dict)
        {
            return dict;
        }

        #endregion

        return (ret ?? []).Distinct().Where(x => !string.IsNullOrEmpty(x)).ToDictionary(x => x!, y => y!);

        Dictionary<string, string>? ReadSceneOptions()
        {
            switch (parent.ResolvedData)
            {
                // Special case for scnActorId.Id - check if we're editing the Id property of a scnActorId
                case scnActorId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Generate dropdown options for actor IDs with actor names
                        // Key = display text, Value = actual ID value
                        var actorOptions = new Dictionary<string, string>();

                        // Add regular actors
                        for (int i = 0; i < scene.Actors.Count; i++)
                        {
                            var actor = scene.Actors[i];
                            string actorName = actor.ActorName; // Implicit conversion from CString to string
                            if (string.IsNullOrEmpty(actorName))
                            {
                                actorName = $"Actor {i}";
                            }

                            actorOptions.Add($"{i}: {actorName}", i.ToString());
                        }

                        // Add player actors
                        for (int i = 0; i < scene.PlayerActors.Count; i++)
                        {
                            var playerActor = scene.PlayerActors[i];
                            var actorId = scene.Actors.Count + i;
                            string actorName = playerActor.PlayerName; // Implicit conversion from CString to string
                            if (string.IsNullOrEmpty(actorName))
                            {
                                actorName = $"Player Actor {i}";
                            }

                            actorOptions.Add($"{actorId}: {actorName}", actorId.ToString());
                        }

                        return actorOptions;
                    }
                    break;
                }
                // Special case for scnPerformerId.Id - check if we're editing the Id property of a scnPerformerId
                case scnPerformerId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context (where IDs should be editable) vs usage context (where dropdown is helpful)
                        // Definition contexts: debugSymbols.performersDebugSymbols, actors, playerActors, props, etc.
                        // Usage contexts: scene events, quest nodes, etc.

                        var parentPath = GetParentPath(cvm);

                        // Skip dropdown if we're in definition contexts
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for performer IDs with performer names from debugSymbols
                        // Key = display text, Value = actual ID value
                        var performerOptions = new Dictionary<string, string>();

                        if (scene.DebugSymbols?.PerformersDebugSymbols != null)
                        {
                            foreach (var performerSymbol in scene.DebugSymbols.PerformersDebugSymbols)
                            {
                                var performerId = performerSymbol.PerformerId.Id;
                                var performerIdValue = ((uint)performerId).ToString();

                                // Try to get performer name from various sources
                                string performerName = $"Performer {performerIdValue}";

                                // Try first name in Names array first (most reliable)
                                if (performerSymbol.EntityRef.Names.Count > 0)
                                {
                                    if (performerSymbol.EntityRef.Names[0] != "None")
                                    {
                                        performerName = performerSymbol.EntityRef.Names[0]!;
                                    }
                                }

                                // If Names didn't work, try Reference (NodeRef)
                                if (performerName == $"Performer {performerIdValue}")
                                {
                                    var referenceString = performerSymbol.EntityRef.Reference.GetResolvedText() ?? "";
                                    if (!string.IsNullOrEmpty(referenceString) && referenceString != "0")
                                    {
                                        // Remove the # prefix if present
                                        performerName = referenceString.StartsWith("#")
                                            ? referenceString.Substring(1)
                                            : referenceString;
                                    }
                                }

                                // Try SceneActorContextName
                                if (performerName == $"Performer {performerIdValue}")
                                {
                                    if (performerSymbol.EntityRef.SceneActorContextName != "None")
                                    {
                                        performerName = performerSymbol.EntityRef.SceneActorContextName!;
                                    }
                                }

                                // Try DynamicEntityUniqueName
                                if (performerName == $"Performer {performerIdValue}")
                                {
                                    if (performerSymbol.EntityRef.DynamicEntityUniqueName != "None")
                                    {
                                        performerName = performerSymbol.EntityRef.DynamicEntityUniqueName!;
                                    }
                                }

                                performerOptions.Add($"{performerIdValue}: {performerName}", performerIdValue);
                            }
                        }

                        return performerOptions;
                    }

                    break;
                }
                // Special case for scnSceneWorkspotInstanceId.Id - check if we're editing the Id property of a scnSceneWorkspotInstanceId
                case scnSceneWorkspotInstanceId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for workspot instance IDs with workspot resource names
                        // Key = display text, Value = actual ID value
                        var workspotOptions = new Dictionary<string, string>();

                        foreach (var workspotInstance in scene.WorkspotInstances)
                        {
                            var instanceId = workspotInstance.WorkspotInstanceId.Id;
                            var instanceDataId = workspotInstance.DataId.Id;

                            // Find the workspot resource by DataId
                            var workspotResource = scene.Workspots.FirstOrDefault(w =>
                                w.Chunk is scnWorkspotData workspotData && workspotData.DataId.Id == instanceDataId);
                            var workspotPath = "Unknown";

                            if (workspotResource?.Chunk is scnWorkspotData_ExternalWorkspotResource externalWorkspot)
                            {
                                workspotPath = externalWorkspot.WorkspotResource.DepotPath.GetResolvedText() ??
                                               "Unknown";
                            }

                            // Extract filename without extension and get origin marker
                            var filename = System.IO.Path.GetFileNameWithoutExtension(workspotPath);
                            var originMarkerText = workspotInstance.OriginMarker.NodeRef.GetResolvedText();
                            var originMarker = string.IsNullOrEmpty(originMarkerText) ? "Unknown" : originMarkerText;

                            var displayText = $"{instanceId}: {filename} ({originMarker})";
                            workspotOptions[displayText] = instanceId.ToString();
                        }

                        return workspotOptions;
                    }
                    break;
                }
                // Special case for scnEffectInstanceId.Id - check if we're editing the Id property of a scnEffectInstanceId
                case scnEffectInstanceId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for effect instance IDs with effect resource names and first RUID
                        // Key = display text, Value = actual ID value
                        var effectOptions = new Dictionary<string, string>();

                        foreach (var effectInstance in scene.EffectInstances)
                        {
                            var instanceId = effectInstance.EffectInstanceId.Id;
                            var effectId = effectInstance.EffectInstanceId.EffectId.Id;
                            var effectDef = scene.EffectDefinitions
                                .FirstOrDefault(e => e.Id.Id == effectId);

                            if (effectDef != null)
                            {
                                var effectPath = effectDef.Effect.DepotPath.GetResolvedText();
                                if (!string.IsNullOrEmpty(effectPath))
                                {
                                    var filename = System.IO.Path.GetFileNameWithoutExtension(effectPath);

                                    // Get first RUID from compiled effect if available
                                    string ruidInfo = "";
                                    if (effectInstance.CompiledEffect?.EventsSortedByRUID != null &&
                                        effectInstance.CompiledEffect.EventsSortedByRUID.Count > 0)
                                    {
                                        ruidInfo = $": {effectInstance.CompiledEffect.EventsSortedByRUID[0].EventRUID}";
                                    }

                                    effectOptions[$"{instanceId}: {filename}{ruidInfo}"] = instanceId.ToString();
                                }
                                else
                                {
                                    effectOptions[$"{instanceId}: [No Effect Path]"] = instanceId.ToString();
                                }
                            }
                            else
                            {
                                effectOptions[$"{instanceId}: [Unknown Effect]"] = instanceId.ToString();
                            }
                        }

                        return effectOptions;
                    }
                    break;
                }
                // Special case for scnPropId.Id - check if we're editing the Id property of a scnPropId
                case scnPropId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for prop IDs with prop names
                        // Key = display text, Value = actual ID value
                        var propOptions = new Dictionary<string, string>();

                        foreach (var propDefinition in scene.Props)
                        {
                            var propId = propDefinition.PropId.Id;
                            var propName = propDefinition.PropName.ToString();

                            if (!string.IsNullOrEmpty(propName))
                            {
                                propOptions[$"{propId}: {propName}"] = propId.ToString();
                            }
                            else
                            {
                                propOptions[$"{propId}: [Unnamed Prop]"] = propId.ToString();
                            }
                        }

                        return propOptions;
                    }
                    break;
                }
                // Special case for scnCinematicAnimSetSRRefId.Id - check if we're editing the Id property of a scnCinematicAnimSetSRRefId
                case scnCinematicAnimSetSRRefId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for cinematic animation set IDs with animation file paths
                        // Key = display text, Value = actual ID value (index)
                        var animSetOptions = new Dictionary<string, string>();

                        if (scene.ResouresReferences?.CinematicAnimSets != null)
                        {
                            for (int i = 0; i < scene.ResouresReferences.CinematicAnimSets.Count; i++)
                            {
                                var animSet = scene.ResouresReferences.CinematicAnimSets[i];
                                var animSetPath = animSet.AsyncAnimSet.DepotPath.GetResolvedText();

                                if (!string.IsNullOrEmpty(animSetPath))
                                {
                                    var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                                    var displayText = $"{i}: {filename}.anims";

                                    animSetOptions[displayText] = i.ToString();
                                }
                                else
                                {
                                    animSetOptions[$"{i}: [No Animation Set Path]"] = i.ToString();
                                }
                            }
                        }

                        return animSetOptions;
                    }

                    break;
                }
                // Special case for scnLipsyncAnimSetSRRefId.Id - check if we're editing the Id property of a scnLipsyncAnimSetSRRefId
                case scnLipsyncAnimSetSRRefId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for lipsync animation set IDs with animation file paths
                        // Key = display text, Value = actual ID value (index)
                        var animSetOptions = new Dictionary<string, string>();

                        if (scene.ResouresReferences?.LipsyncAnimSets != null)
                        {
                            for (int i = 0; i < scene.ResouresReferences.LipsyncAnimSets.Count; i++)
                            {
                                var animSet = scene.ResouresReferences.LipsyncAnimSets[i];
                                var animSetPath = animSet.AsyncRefLipsyncAnimSet.DepotPath.GetResolvedText();

                                if (!string.IsNullOrEmpty(animSetPath))
                                {
                                    var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                                    var displayText = $"{i}: {filename}.anims";
                                    animSetOptions[displayText] = i.ToString();
                                }
                                else
                                {
                                    animSetOptions[$"{i}: [No Animation Set Path]"] = i.ToString();
                                }
                            }
                        }

                        return animSetOptions;
                    }

                    break;
                }
                // Special case for scnDynamicAnimSetSRRefId.Id - check if we're editing the Id property of a scnDynamicAnimSetSRRefId
                case scnDynamicAnimSetSRRefId:
                {
                    var scene = GetSceneContext(cvm);
                    if (scene != null)
                    {
                        // Check if we're in a definition context vs usage context
                        var parentPath = GetParentPath(cvm);
                        if (IsInDefinitionContext(parentPath))
                        {
                            return new Dictionary<string, string>(); // Return empty to use regular integer editor
                        }

                        // Generate dropdown options for dynamic animation set IDs with animation file paths
                        // Key = display text, Value = actual ID value (index)
                        var animSetOptions = new Dictionary<string, string>();

                        if (scene.ResouresReferences?.DynamicAnimSets != null)
                        {
                            for (int i = 0; i < scene.ResouresReferences.DynamicAnimSets.Count; i++)
                            {
                                var animSet = scene.ResouresReferences.DynamicAnimSets[i];
                                var animSetPath = animSet.AsyncAnimSet.DepotPath.GetResolvedText();

                                if (!string.IsNullOrEmpty(animSetPath))
                                {
                                    var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                                    var displayText = $"{i}: {filename}.anims";
                                    animSetOptions[displayText] = i.ToString();
                                }
                                else
                                {
                                    animSetOptions[$"{i}: [No Animation Set Path]"] = i.ToString();
                                }
                            }
                        }

                        return animSetOptions;
                    }

                    break;
                }
            }

            return null;
        }
    }

    /// <summary>
    /// Should this CVM show dropdown options at all?
    /// </summary>
    public static bool HasDropdownOptions(ChunkViewModel cvm)
    {
        var parent = cvm.Parent;
        if (parent == null)
        {
            return false;
        }

        // Check if we're in a definition context first - if so, always use regular editor
        if (cvm.Name == "id")
        {
            var parentPath = GetParentPath(cvm);
            if (IsInDefinitionContext(parentPath))
            {
                return false; // Use regular integer editor for definition contexts
            }
        }

        // This code checks the PARENT MODEL's ResolvedData type - the node CONTAINING the cvm
        return parent.ResolvedData switch
        {
            gameJournalPath when s_questHandleParentNames.Contains(parent.Name) => true,
            gameJournalPath when cvm.Name is "realPath" => true,
            #region mesh

            CArray<CName> when parent is { Name: "chunkMaterials", Parent.Parent.Parent.ResolvedData: CMesh } =>
                true,
            CKeyValuePair when parent.Parent?.Parent?.ResolvedData is CMaterialInstance matInstance &&
                               !string.IsNullOrEmpty(matInstance.BaseMaterial.DepotPath.GetResolvedText()) => true,

            CMaterialInstance when cvm.Name is "baseMaterial" => true, // resource path, TODO

            #endregion

            #region ent

            appearanceAppearancePart when cvm.Name is "appearanceResource" or "resource" => true,
            entSkinnedMeshComponent when s_appearanceNames.Contains(cvm.Name) => true,
            entSkinnedMeshComponent when parent.Name == "mesh" => true,
            entEntityTemplate when s_appearanceNames.Contains(cvm.Name) => true,
            entTemplateAppearance when cvm.Name is "appearanceName" or "appearanceResource" => true,
            #endregion

            #region app

            appearanceAppearanceResource when s_appearanceNames.Contains(cvm.Name) => true,
            IRedRef when cvm is { Name: "resource", Parent.ResolvedData: appearanceAppearancePart } => true,
            #endregion

            #region mlsetup

            Multilayer_Layer mlLayer => (cvm.Name is "material" or "microblend") ||
                                        !string.IsNullOrEmpty(mlLayer.Material.DepotPath.GetResolvedText()),

            #endregion

            // tags: ent and app
            IRedArray<CName> when parent is { Name: "tags", Parent.ResolvedData: redTagList } => true,

            #region scenes
            // scnActorId.Id dropdown - check if this is an id property in a scnActorId and we have scene context
            scnActorId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnPerformerId.Id dropdown
            scnPerformerId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnSceneWorkspotInstanceId.Id dropdown
            scnSceneWorkspotInstanceId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnEffectInstanceId.Id dropdown
            scnEffectInstanceId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnPropId.Id dropdown
            scnPropId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnCinematicAnimSetSRRefId.Id dropdown
            scnCinematicAnimSetSRRefId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnLipsyncAnimSetSRRefId.Id dropdown
            scnLipsyncAnimSetSRRefId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            // scnDynamicAnimSetSRRefId.Id dropdown
            scnDynamicAnimSetSRRefId when cvm.Name == "id" && GetSceneContext(cvm) != null => true,

            #endregion

            #region questPhase

            graphGraphNodeDefinition when cvm.Name is "phaseResource" or "sceneFile" => true,
            #endregion
            _ => false
        };
    }

    /// <summary>
    /// Show the refresh button (e.g. to load data from a different file)?
    /// </summary>
    public static bool ShouldShowRefreshButton(ChunkViewModel cvm)
    {
        if (cvm is { ParentData: gameJournalPath, Name: "realPath" })
        {
            return true;
        }

        if (cvm is { ParentData: graphGraphNodeDefinition, Name: "phaseResource" or "sceneFile" })
        {
            return true;
        }

        // This code checks the ROOT MODEL's ResolvedData type - the first node in the tree view
        return cvm.GetRootModel().ResolvedData switch
        {
            entEntityTemplate when s_appearanceNames.Contains(cvm.Name) => true,
            appearanceAppearanceResource when s_appearanceNames.Contains(cvm.Name) => true,
            entTemplateAppearance when cvm.Name == "appearanceName" => true,
            entSkinnedMeshComponent when s_appearanceNames.Contains(cvm.Name) => true,
            CMesh when cvm.Parent?.Parent?.Parent?.ResolvedData is CMaterialInstance matInstance &&
                       !string.IsNullOrEmpty(matInstance.BaseMaterial.DepotPath.GetResolvedText()) => true,
            Multilayer_Setup when cvm.Parent?.ResolvedData is Multilayer_Layer mlLayer =>
                cvm.Name is "materials" || cvm.Name is "microblend"
                                        || (!string.IsNullOrEmpty(mlLayer.Material.DepotPath.GetResolvedText()) &&
                                            s_multilayerProperties.Contains(cvm.Name)),
            _ => false
        };
    }

    /// <summary>
    /// Show colours in the dropdown menu? (Only for MLSetup so far)
    /// </summary>
    public static bool ShouldShowColourInDropdown(ChunkViewModel cvm)
    {
        return cvm is { ParentData: Multilayer_Layer, Name: "colorScale" };
    }

    /// <summary>
    /// Gets the parent path of a ChunkViewModel to determine context
    /// </summary>
    private static string GetParentPath(ChunkViewModel cvm)
    {
        var pathParts = new List<string>();
        var current = cvm.Parent;

        while (current != null)
        {
            if (!string.IsNullOrEmpty(current.PropertyName))
            {
                pathParts.Add(current.PropertyName);
            }
            else if (!string.IsNullOrEmpty(current.Name))
            {
                pathParts.Add(current.Name);
            }
            current = current.Parent;
        }

        pathParts.Reverse();
        return string.Join(".", pathParts);
    }

    /// <summary>
    /// Determines if we're in a definition context where IDs should be editable
    /// vs usage context where dropdowns are helpful
    /// </summary>
    private static bool IsInDefinitionContext(string parentPath)
    {
        // Usage contexts that can be inside definition paths
        var usagePaths = new[]
        {
            "bodyCinematicAnimSets",
            "lipsyncAnimSet",
            "dynamicAnimSets"
        };
        if (usagePaths.Any(parentPath.Contains))
        {
            return false;
        }

        // Definition contexts where IDs should be directly editable
        var definitionPaths = new[]
        {
            "debugSymbols.performersDebugSymbols",  // Performer definitions
            "actors",                               // Actor definitions
            "playerActors",                         // Player actor definitions
            "props",                                // Prop definitions
            "workspotInstances",                    // Workspot instance definitions
            "effectInstances",                      // Effect instance definitions
            "effectDefinitions"                     // Effect definitions
        };

        return definitionPaths.Any(parentPath.Contains);
    }
}
