using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnCutControlNodeWrapper : BaseSceneViewModel<scnCutControlNode>
{
    public scnCutControlNodeWrapper(scnCutControlNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }
}