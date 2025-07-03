using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnXorNodeWrapper : BaseSceneViewModel<scnXorNode>, IDynamicInputNode
{
    public scnXorNodeWrapper(scnXorNode scnXorNode) : base(scnXorNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        
        OutputSocketNames.Add(0, "Out");
    }

    internal override void GenerateSockets()
    {
        // Generate base sockets from dictionaries
        base.GenerateSockets();
    }

    public BaseConnectorViewModel AddInput()
    {
        var index = (ushort)Input.Count;
        var input = new SceneInputConnectorViewModel($"In{index}", $"In{index}", UniqueId, 0, index);
        input.Subtitle = $"(0,{index})";

        Input.Add(input);

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
            
            // Notify UI and mark document dirty
            NotifySocketsChanged();
        }
    }
}