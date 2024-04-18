using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public abstract class BaseSceneViewModel : NodeViewModel
{
    public override uint UniqueId => ((scnSceneGraphNode)Data).NodeId.Id;

    protected BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        Title = $"[{UniqueId}] {Data.GetType().Name[3..^4]}";
    }
}

public abstract class BaseSceneViewModel<T> : BaseSceneViewModel where T : scnSceneGraphNode
{
    protected T _castedData => (T)Data;

    public BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
    }

    internal override void GenerateSockets()
    {
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }
}