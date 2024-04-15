
namespace WolvenKit.RED4.Types;

public partial class CMesh
{
    public override IEnumerable<string> GetHiddenIfDefaultFieldNames()
    {
        return base.GetHiddenIfDefaultFieldNames().Concat([
             "preloadExternalMaterials", 
            "preloadLocalMaterials",
            "preloadLocalMaterialInstances", 
            "preloadLocalMaterials",
            "inplaceResources", 
        ]);
    }

    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
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
   
}