using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions 
{
    public static IEnumerable<string> GetHiddenFieldNames(this entSkinnedMeshComponent _)
    {
        return GetHiddenFieldNames().Concat([
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

