using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnDeletionMarkerNodeWrapper : BaseSceneViewModel<scnDeletionMarkerNode>
{
    public scnDeletionMarkerNodeWrapper(scnDeletionMarkerNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(666, "In");

        OutputSocketNames.Add(666, "Out");
    }
}