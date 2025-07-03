using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnAndNodeWrapper : BaseSceneViewModel<scnAndNode>, IDynamicInputNode
{
    public scnAndNodeWrapper(scnAndNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");

        OutputSocketNames.Add(0, "Out");
    }

    internal override void GenerateSockets()
    {
        // First generate base sockets from dictionaries
        base.GenerateSockets();
        
        // Then add any additional dynamic input sockets beyond the base ones
        for (ushort i = (ushort)InputSocketNames.Count; i < _castedData.NumInSockets; i++)
        {
            var input = new SceneInputConnectorViewModel($"In{i}", $"In{i}", UniqueId, 0, i);
            input.Subtitle = $"(0,{i})";
            Input.Add(input);
        }
    }

    public BaseConnectorViewModel AddInput()
    {
        var index = (ushort)Input.Count;
        var input = new SceneInputConnectorViewModel($"In{index}", $"In{index}", UniqueId, 0, index);
        input.Subtitle = $"(0,{index})";

        Input.Add(input);
        _castedData.NumInSockets++;

        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return input;
    }

    public void RemoveInput()
    {
        // Only remove if we have more than the base socket count
        if (Input.Count > InputSocketNames.Count)
        {
            Input.Remove(Input[^1]);
            _castedData.NumInSockets--;
            
            // Notify UI and mark document dirty
            NotifySocketsChanged();
        }
    }
}