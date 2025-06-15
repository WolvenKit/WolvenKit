using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

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


    public static Dictionary<string, string> GetDropdownOptions(ChunkViewModel cvm, DocumentTools documentTools,
        bool forceCacheRefresh = false)
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

            default:
                break;
        }

        // Special case for scnActorId.Id - check if we're editing the Id property of a scnActorId
        if (cvm.Name == "id" && parent.ResolvedData is scnActorId && cvm.GetRootModel().ResolvedData is scnSceneResource scene)
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

        // Special case for scnPerformerId.Id - check if we're editing the Id property of a scnPerformerId
        if (cvm.Name == "id" && parent.ResolvedData is scnPerformerId && cvm.GetRootModel().ResolvedData is scnSceneResource sceneForPerformer)
        {
            // Generate dropdown options for performer IDs with performer names from debugSymbols
            // Key = display text, Value = actual ID value
            var performerOptions = new Dictionary<string, string>();
            
            if (sceneForPerformer.DebugSymbols?.PerformersDebugSymbols != null)
            {
                foreach (var performerSymbol in sceneForPerformer.DebugSymbols.PerformersDebugSymbols)
                {
                    var performerId = performerSymbol.PerformerId.Id;
                    var performerIdValue = ((uint)performerId).ToString();
                    
                    // Try to get performer name from various sources
                    string performerName = $"Performer {performerIdValue}";
                    
                    // Try first name in Names array first (most reliable)
                    if (performerSymbol.EntityRef.Names.Count > 0)
                    {
                        var firstName = performerSymbol.EntityRef.Names[0].GetResolvedText() ?? "";
                        if (!string.IsNullOrEmpty(firstName))
                        {
                            performerName = firstName;
                        }
                    }
                    
                    // If Names didn't work, try Reference (NodeRef)
                    if (performerName == $"Performer {performerIdValue}")
                    {
                        var referenceString = performerSymbol.EntityRef.Reference.ToString() ?? "";
                        if (!string.IsNullOrEmpty(referenceString) && referenceString != "NodeRef")
                        {
                            // Remove the # prefix if present
                            performerName = referenceString.StartsWith("#") ? referenceString.Substring(1) : referenceString;
                        }
                    }
                    
                    // Try SceneActorContextName
                    if (performerName == $"Performer {performerIdValue}")
                    {
                        var sceneActorContextName = performerSymbol.EntityRef.SceneActorContextName.GetResolvedText() ?? "";
                        if (!string.IsNullOrEmpty(sceneActorContextName))
                        {
                            performerName = sceneActorContextName;
                        }
                    }
                    
                    // Try DynamicEntityUniqueName
                    if (performerName == $"Performer {performerIdValue}")
                    {
                        var dynamicEntityName = performerSymbol.EntityRef.DynamicEntityUniqueName.GetResolvedText() ?? "";
                        if (!string.IsNullOrEmpty(dynamicEntityName))
                        {
                            performerName = dynamicEntityName;
                        }
                    }
                    
                    performerOptions.Add($"{performerIdValue}: {performerName}", performerIdValue);
                }
            }
            
            return performerOptions;
        }

        // Special case for scnSceneWorkspotInstanceId.Id - check if we're editing the Id property of a scnSceneWorkspotInstanceId
        if (cvm.Name == "id" && parent.ResolvedData is scnSceneWorkspotInstanceId && cvm.GetRootModel().ResolvedData is scnSceneResource sceneForWorkspot)
        {
            // Generate dropdown options for workspot instance IDs with workspot resource names
            // Key = display text, Value = actual ID value
            var workspotOptions = new Dictionary<string, string>();
            
            foreach (var workspotInstance in sceneForWorkspot.WorkspotInstances)
            {
                var instanceId = workspotInstance.WorkspotInstanceId.Id;
                var instanceDataId = workspotInstance.DataId.Id;
                
                // Find the workspot resource by DataId
                var workspotResource = sceneForWorkspot.Workspots.FirstOrDefault(w => w.Chunk is scnWorkspotData workspotData && workspotData.DataId.Id == instanceDataId);
                var workspotPath = "Unknown";
                
                if (workspotResource?.Chunk is scnWorkspotData_ExternalWorkspotResource externalWorkspot)
                {
                    workspotPath = externalWorkspot.WorkspotResource.DepotPath.GetResolvedText() ?? "Unknown";
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

        // Special case for scnEffectInstanceId.Id - check if we're editing the Id property of a scnEffectInstanceId
        if (cvm.Name == "id" && parent.ResolvedData is scnEffectInstanceId && cvm.GetRootModel().ResolvedData is scnSceneResource sceneForEffect)
        {
            // Generate dropdown options for effect instance IDs with effect resource names and first RUID
            // Key = display text, Value = actual ID value
            var effectOptions = new Dictionary<string, string>();
            
            foreach (var effectInstance in sceneForEffect.EffectInstances)
            {
                var instanceId = effectInstance.EffectInstanceId.Id;
                var effectId = effectInstance.EffectInstanceId.EffectId.Id;
                
                // Find the effect definition by EffectId
                var effectDef = sceneForEffect.EffectDefinitions.FirstOrDefault(e => e.Id.Id == effectId);
                var effectPath = effectDef?.Effect.DepotPath.GetResolvedText() ?? "Unknown";
                
                // Extract filename without extension
                var filename = System.IO.Path.GetFileNameWithoutExtension(effectPath);
                
                // Get first RUID from compiled effect events
                var firstRuid = "";
                if (effectInstance.CompiledEffect?.EventsSortedByRUID?.Count > 0)
                {
                    firstRuid = effectInstance.CompiledEffect.EventsSortedByRUID[0].EventRUID.ToString();
                }
                
                var displayText = string.IsNullOrEmpty(firstRuid) 
                    ? $"{instanceId}: {filename}" 
                    : $"{instanceId}: {filename} ({firstRuid})";
                    
                effectOptions[displayText] = instanceId.ToString();
            }
            
            return effectOptions;
        }

        return ret.Where(x => !string.IsNullOrEmpty(x)).ToDictionary(x => x!, y => y!);
    }

    /// <summary>
    /// Should this CVM show dropdown options at all?
    /// </summary>
    public static bool HasDropdownOptions(ChunkViewModel cvm)
    {
        if (cvm.Parent is not ChunkViewModel parent)
        {
            return false;
        }



        return parent.ResolvedData switch
        {
            gameJournalPath => s_questHandleParentNames.Contains(parent.Name),

            #region mesh

            CArray<CName> when parent is { Name: "chunkMaterials", Parent.Parent.Parent.ResolvedData: CMesh } =>
                true,
            CKeyValuePair when parent.Parent?.Parent?.ResolvedData is CMaterialInstance matInstance &&
                               !string.IsNullOrEmpty(matInstance.BaseMaterial.DepotPath.GetResolvedText()) => true,

            CMaterialInstance when cvm.Name is "baseMaterial" => true, // resource path, TODO

            #endregion

            #region ent 
            appearanceAppearancePart when cvm.Name is ("appearanceResource" or "resource") => true,
            entSkinnedMeshComponent when s_appearanceNames.Contains(cvm.Name) => true,
            entSkinnedMeshComponent when parent.Name == "mesh" => true,
            entEntityTemplate when s_appearanceNames.Contains(cvm.Name) => true,
            entTemplateAppearance when cvm.Name is ("appearanceName" or "appearanceResource") => true,
            #endregion

            #region app
            appearanceAppearanceResource when s_appearanceNames.Contains(cvm.Name) => true,
            IRedRef when cvm.Name is "resource" && cvm.Parent.ResolvedData is appearanceAppearancePart => true,
            #endregion

            // tags: ent and app
            IRedArray<CName> when parent is { Name: "tags", Parent.ResolvedData: redTagList } => true,

            // scnActorId.Id dropdown
            scnActorId when cvm.Name == "id" && cvm.GetRootModel().ResolvedData is scnSceneResource => true,

            // scnPerformerId.Id dropdown
            scnPerformerId when cvm.Name == "id" && cvm.GetRootModel().ResolvedData is scnSceneResource => true,

            // scnSceneWorkspotInstanceId.Id dropdown
            scnSceneWorkspotInstanceId when cvm.Name == "id" && cvm.GetRootModel().ResolvedData is scnSceneResource => true,

            // scnEffectInstanceId.Id dropdown
            scnEffectInstanceId when cvm.Name == "id" && cvm.GetRootModel().ResolvedData is scnSceneResource => true,

            _ => false
        };
    }

    /// <summary>
    /// Show the refresh button (e.g. to load data from a different file)?
    /// </summary>
    public static bool ShouldShowRefreshButton(ChunkViewModel cvm)
    {
        return cvm.GetRootModel().ResolvedData switch
        {
            entEntityTemplate when s_appearanceNames.Contains(cvm.Name) => true,
            appearanceAppearanceResource when s_appearanceNames.Contains(cvm.Name) => true,
            entTemplateAppearance when cvm.Name == "appearanceName" => true,
            entSkinnedMeshComponent when s_appearanceNames.Contains(cvm.Name) => true,
            CMesh when cvm.Parent?.Parent?.Parent?.ResolvedData is CMaterialInstance matInstance &&
                       !string.IsNullOrEmpty(matInstance.BaseMaterial.DepotPath.GetResolvedText()) => true,
            _ => false
        };
    }
}