using System;
using System.Collections.Generic;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    // Types that should never be changed by the user 
    private static readonly List<Type> s_globalReadonlyTypes =
    [
        typeof(SerializationDeferredDataBuffer),
        typeof(rendRenderTextureBlobMemoryLayout),
        typeof(rendRenderTextureBlobPlacement),
        typeof(rendRenderTextureBlobMipMapInfo),
        typeof(rendRenderTextureBlobTextureInfo),
        typeof(rendRenderTextureBlobSizeInfo),
    ];

    // Properties (by name) that should never be changed by the user
    private static readonly List<string> s_globalReadonlyFields =
    [
        "saveDateTime", "resourceVersion", "cookingPlatform", "renderBuffer"
    ];

    // Fields (by parent class) that should be marked as read-only
    private static readonly Dictionary<Type, List<string>> s_readonlyFields = new()
    {
        { typeof(CBitmapTexture), ["width", "height"] }, // xbm
        { typeof(CMesh), ["geometryHash", "consoleBias"] }, // mesh
    };

    private void CalculateIsReadOnly()
    {
        if (IsReadOnly)
        {
            return;
        }
        if (Parent?.IsReadOnly is true || s_globalReadonlyFields.Contains(Name) || s_globalReadonlyTypes.Contains(ResolvedData.GetType()))
        {
            IsReadOnly = true;
            return;
        }

        if (Parent is not null && s_readonlyFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenFields))
        {
            IsReadOnly = hiddenFields.Contains(Name);
        }
    }

    private void CalculateUserInteractionStates()
    {
        // Either a root field, or a field that isn't initialized yet
        if (Parent is null || ResolvedData is RedDummy)
        {
            return;
        }

        CalculateIsReadOnly();
        CalculateConditionalHiding();
    }

    public bool ExcludeFromSimpleView()
    {
        CalculateConditionalHiding();
        return IsHiddenByNoobFilter;
    }

    /// <summary>
    /// Should this property be hidden from the default view (because the user has toggled the noob filter)?
    /// TODO: Not implemented yet
    /// </summary>
    private void CalculateConditionalHiding()
    {
        // If we're in simple view, hide all "unnecessary" properties from the user
        if (Tab?.IsSimpleViewEnabled != true)
        {
            IsHiddenByNoobFilter = false;
            return;
        }

        // DataBuffers should always be hidden
        if (s_alwaysHiddenFields.Contains(Name) || PropertyType.IsAssignableTo(typeof(DataBuffer)))
        {
            IsHiddenByNoobFilter = true;
            return;
        }

        if (Parent is null)
        {
            return;
        }

        if (s_hiddenFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenFields) && hiddenFields.Contains(Name))
        {
            IsHiddenByNoobFilter = true;
            return;
        }

        // Some fields should be hidden if they are empty, or false 
        if (!s_hideIfHasDefaultValueFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenArrayFields) ||
            !hiddenArrayFields.Contains(Name))
        {
            return;
        }

        if ((IsArray && Properties.Count == 0) // empty array
            || (ResolvedData is CBool boolValue && boolValue == false) //false boolean
            || (ResolvedData is CName cname && (cname.GetResolvedText() ?? "").ToLower().Replace("none", "") == "") // empty cname
           )
        {
            IsHiddenByNoobFilter = true;
        }
    }

    private static readonly List<string> s_alwaysHiddenFields = new()
    {
        "cookingPlatform",
        "topology",
        "topologyData",
        "topologyDataStride",
        "topologyMetadata",
        "topologyMetadataStride",
        "version",
        "vertexBufferSize"
    };


    /// <summary>
    /// Some fields should only be hidden if they are not empty (e.g. preloadLocalMaterials in a mesh, or resolvedDependencies in an app).
    /// </summary>
    private static readonly Dictionary<Type, List<string>> s_hideIfHasDefaultValueFields = new()
    {
        {
            typeof(CMesh), [
                "preloadExternalMaterials", "preloadLocalMaterials", "preloadLocalMaterialInstances", "preloadLocalMaterials",
                "inplaceResources",
            ]
        }, // .app file
        {
            typeof(appearanceAppearanceResource), [
                "censorshipMapping",
            ]
        },
        // .app file: appearance definition
        {
            typeof(appearanceAppearanceDefinition), [
                "looseDependencies",
            ]
        },
    };


    /// <summary>
    /// Some fields can be needed if they are not empty (e.g. preloadLocalMaterials).
    /// </summary>
    private static readonly Dictionary<Type, List<string>> s_hiddenFields = new()
    {
        {
            typeof(CMesh), [
                "boundingBox", "boneNames", "boneVertexEpsilons", "boneRigMatrices", "castGlobalShadowsCachedInCook",
                "castLocalShadowsCachedInCook",
                "castsRayTracedShadowsFromOriginalGeometry", "consoleBias", "floatTrackNames", "forceLoadAllAppearances", "lodBoneMask",
                "isPlayerShadowMesh", "isShadowMesh", "geometryHash",
                "objectType", "resourceVersion", "saveDateTime", "surfaceAreaPerAxis", "useRayTracingShadowLODBias"
            ]
        },
        { // Mesh: Render blob header
            typeof(rendRenderMeshBlobHeader), [
                "bonePositions", "customData", "customDataElemStride", "dataProcessing", "indexBufferOffset", "indexBufferStride",
                "opacityMicromaps", "quantizationOffset", "quantizationScale", "renderChunks"
            ]
        },
        { typeof(inkTextureAtlas), ["activeTexture", "dynamicTexture", "parts", "slices", "texture"] },
        { typeof(inkTextureSlot), ["slices"] },
        // .app file
        {
            typeof(appearanceAppearanceResource), [
                "alternateAppearanceMapping",
                "alternateAppearanceSettingName",
                "alternateAppearanceSuffixes",
                "baseEntity",
                "baseEntityType",
                "baseType",
                "DismEffects",
                "DismWoundConfig",
                "forceCompileProxy",
                "generatePlayerBlockingCollisionForProxy",
                "proxyPolyCount",
                "Wounds",
            ]
        },
        // .app file: appearance definition
        {
            typeof(appearanceAppearanceDefinition), [
                "censorFlags",
                "cookedDataPathOverride",
                "forcedLodDistance",
                "hitRepresentationOverrides",
                "parametersBuffer",
                "parentAppearance",
            ]
        },
        // .app file: appearance definition: parts override - ArchiveXL will handle this
        { typeof(appearanceAppearancePartOverrides), ["partResource"] },
        // .app file: appearance definition: parts override
        { typeof(appearancePartComponentOverrides), ["acceptDismemberment"] },

        /*
         * .ent file
         */
        {
            typeof(entEntityTemplate),
            ["backendDataOverrides", "bindingOverrides", "compiledEntityLODFlags", "componentResolveSettings", "includes", "entity"]
        },
        /*
         * .ent/.app file components
         */
        {
            typeof(entGarmentSkinnedMeshComponent), [
                "acceptDismemberment", "autoHideDistance", "isEnabled", "isReplicable", "navigationImpact", "order",
                "overrideMeshNavigationImpact", "renderSceneLayerMask", "visibilityAnimationParam"
            ]
        },
        {
            typeof(entSkinnedMeshComponent), [
                "acceptDismemberment", "autoHideDistance", "isEnabled", "isReplicable", "navigationImpact", "order",
                "overrideMeshNavigationImpact", "renderSceneLayerMask", "visibilityAnimationParam"
            ]
        },
        {
            typeof(entMeshComponent), [
                "autoHideDistance", "isEnabled", "isReplicable", "navigationImpact", "numInstances", "order",
                "overrideMeshNavigationImpact", "objectTypeID", "renderSceneLayerMask", "visibilityAnimationParam"
            ]
        },
    };
}