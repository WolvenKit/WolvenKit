using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(this CMesh _)
    {
        return GetHiddenIfDefaultFieldNames().Concat([
             "preloadExternalMaterials", 
            "preloadLocalMaterials",
            "preloadLocalMaterialInstances", 
            "preloadLocalMaterials",
            "inplaceResources", 
        ]);
    }

    public static IEnumerable<string> GetHiddenFieldNames(this CMesh _)
    {
        return GetHiddenFieldNames().Concat([
            "boundingBox", 
            "boneNames", 
            "boneVertexEpsilons", 
            "boneRigMatrices", 
            "castGlobalShadowsCachedInCook",
            "castLocalShadowsCachedInCook",
            "castsRayTracedShadowsFromOriginalGeometry", 
            "consoleBias", 
            "floatTrackNames", 
            "forceLoadAllAppearances", 
            "lodBoneMask",
            "isPlayerShadowMesh", 
            "isShadowMesh", 
            "geometryHash",
            "objectType", 
            "resourceVersion", 
            "saveDateTime", 
            "surfaceAreaPerAxis", 
            "useRayTracingShadowLODBias"
        ]);
    }

    public static IEnumerable<string> GetReadonlyFieldNames(this CMesh _)
    {
        return GetReadonlyFieldNames().Concat(["geometryHash", "consoleBias"]);
    }
}