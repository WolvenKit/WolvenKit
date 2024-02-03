using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnRewindableSectionNodeWrapper : BaseSceneViewModel<scnRewindableSectionNode>
{
    public scnRewindableSectionNodeWrapper(scnRewindableSectionNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        InputSocketNames.Add(2, "Pause");
        InputSocketNames.Add(3, "ForwardNormal");
        InputSocketNames.Add(4, "ForwardSlow");
        InputSocketNames.Add(5, "ForwardFast");
        InputSocketNames.Add(6, "BackwardNormal");
        InputSocketNames.Add(7, "BackwardSlow");
        InputSocketNames.Add(8, "BackwardFast");
        InputSocketNames.Add(9, "ForwardVeryFast");
        InputSocketNames.Add(10, "BackwardVeryFast");

        OutputSocketNames.Add(0, "CancelFwd");
        OutputSocketNames.Add(1, "TransmitSignal");
        //OutputSocketNames.Add(2, "StopWork");
    }
}