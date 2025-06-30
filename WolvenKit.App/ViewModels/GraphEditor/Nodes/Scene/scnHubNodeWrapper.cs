using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnHubNodeWrapper : BaseSceneViewModel<scnHubNode>, IDynamicInputNode
{
    public scnHubNodeWrapper(scnHubNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
    }

    internal override void GenerateSockets()
    {
        // Add fixed input sockets
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));  // Added CutDestination input socket
        
        // Generate output sockets
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

        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Input));
        OnPropertyChanged(nameof(Data));

        return input;
    }

    public void RemoveInput() 
    {
        Input.Remove(Input[^1]);
        
        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Input));
        OnPropertyChanged(nameof(Data));
    }
}