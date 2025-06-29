using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnAndNodeWrapper : BaseSceneViewModel<scnAndNode>, IDynamicInputNode
{
    public scnAndNodeWrapper(scnAndNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
    }

    internal override void GenerateSockets()
    {
        for (ushort i = 0; i < _castedData.NumInSockets; i++)
        {
            Input.Add(new SceneInputConnectorViewModel($"In{i}", $"In{i}", UniqueId, i));
        }

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
        _castedData.NumInSockets++;

        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Input));
        OnPropertyChanged(nameof(Data));

        return input;
    }

    public void RemoveInput()
    {
        Input.Remove(Input[^1]);
        _castedData.NumInSockets--;
        
        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Input));
        OnPropertyChanged(nameof(Data));
    }
}