using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnCutControlNodeWrapper : BaseSceneViewModel<scnCutControlNode>
{
    public scnCutControlNodeWrapper(scnCutControlNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");

        OutputSocketNames.Add(0, "True");
        OutputSocketNames.Add(1, "False");
    }
}