using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes;

public class scnXorNodeWrapper : BaseSceneViewModel<scnXorNode>, IDynamicInputNode
{
    public scnXorNodeWrapper(scnXorNode scnXorNode) : base(scnXorNode)
    {
    }

    internal override void GenerateSockets()
    {
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }

    public BaseConnectorViewModel AddInput()
    {
        var index = (ushort)Input.Count;
        var input = new SceneInputConnectorViewModel($"In{index}", $"In{index}", UniqueId, index);

        Input.Add(input);

        return input;
    }

    public void RemoveInput() => Input.Remove(Input[^1]);
}