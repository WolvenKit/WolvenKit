
namespace WolvenKit.RED4.Types;

public partial class entGarmentSkinnedMeshComponent
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
            "acceptDismemberment", 
            "autoHideDistance", 
            "isEnabled", 
            "isReplicable", 
            "navigationImpact", 
            "order",
            "overrideMeshNavigationImpact", 
            "renderSceneLayerMask", 
            "visibilityAnimationParam"
            ]);
    }
}
