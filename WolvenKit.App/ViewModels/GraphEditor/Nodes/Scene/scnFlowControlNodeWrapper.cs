using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnFlowControlNodeWrapper : BaseSceneViewModel<scnFlowControlNode>
{
    public scnFlowControlNodeWrapper(scnFlowControlNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        Details.Add("IsOpen", _castedData.IsOpen.ToString());
        Details.Add("OpensAt", _castedData.OpensAt.ToString());
        Details.Add("ClosesAt", _castedData.ClosesAt.ToString());

        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Open");
        InputSocketNames.Add(2, "Close");
        InputSocketNames.Add(3, "Toggle");
        InputSocketNames.Add(4, "Cancel");

        OutputSocketNames.Add(0, "Out");
    }
} 