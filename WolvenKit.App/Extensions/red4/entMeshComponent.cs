using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenFieldNames(this entMeshComponent _)
    {
        return GetHiddenFieldNames().Concat([
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

