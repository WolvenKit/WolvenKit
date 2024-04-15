namespace WolvenKit.RED4.Types;

public partial class entMeshComponent
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
            "autoHideDistance", 
            "isEnabled", 
            "isReplicable", 
            "navigationImpact", 
            "numInstances", 
            "order",
            "overrideMeshNavigationImpact", 
            "objectTypeID", 
            "renderSceneLayerMask", 
            "visibilityAnimationParam"
        ]);
    }
}

