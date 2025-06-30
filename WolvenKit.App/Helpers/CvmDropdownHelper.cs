using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Extensions;
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
            case gameJournalPath journalPath when cvm.Name is "realPath":
                ret = documentTools.GetAllJournalPaths(forceCacheRefresh);
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

            default:
                break;
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
            
            #region questPhase
            graphGraphNodeDefinition when cvm.Name is ("phaseResource" or "sceneFile") => true,
            #endregion
            _ => false
        };
    }

    /// <summary>
    /// Show the refresh button (e.g. to load data from a different file)?
    /// </summary>
    public static bool ShouldShowRefreshButton(ChunkViewModel cvm)
    {
        if (cvm.ParentData is gameJournalPath && cvm.Name is "realPath")
        {
            return true;
        }
        
        if (cvm.ParentData is graphGraphNodeDefinition && cvm.Name is "phaseResource" or "sceneFile")
        {
            return true;
        }

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