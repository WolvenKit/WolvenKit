using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnInterruptManagerNodeWrapper : BaseSceneViewModel<scnInterruptManagerNode>
{
    public scnInterruptManagerNodeWrapper(scnInterruptManagerNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");

        OutputSocketNames.Add(0, "Out");
    }
}