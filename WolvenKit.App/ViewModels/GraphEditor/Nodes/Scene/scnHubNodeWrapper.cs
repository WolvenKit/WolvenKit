using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using System.Linq;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnHubNodeWrapper : BaseSceneViewModel<scnHubNode>, IDynamicInputNode
{
    public scnHubNodeWrapper(scnHubNode scnSceneGraphNode) : base(scnSceneGraphNode)
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
        // Find the next available ordinal in the (0,N) sequence
        var existingOrdinals = Input
            .Cast<SceneInputConnectorViewModel>()
            .Where(x => x.NameId == 0)
            .Select(x => x.Ordinal)
            .OrderBy(x => x)
            .ToList();

        // Find first gap or next sequential ordinal
        ushort nextOrdinal = 0;
        foreach (var ordinal in existingOrdinals)
        {
            if (ordinal == nextOrdinal)
            {
                nextOrdinal++;
            }
            else
            {
                break; // Found a gap
            }
        }

        return AddInputWithCoordinates(0, nextOrdinal);
    }

    /// <summary>
    /// Add an input socket with specific coordinates
    /// </summary>
    /// <param name="name">Socket name coordinate</param>
    /// <param name="ordinal">Socket ordinal coordinate</param>
    /// <returns>The created socket</returns>
    public BaseConnectorViewModel AddInputWithCoordinates(ushort name, ushort ordinal)
    {
        // Check if socket already exists
        var existingSocket = Input
            .Cast<SceneInputConnectorViewModel>()
            .FirstOrDefault(x => x.NameId == name && x.Ordinal == ordinal);

        if (existingSocket != null)
        {
            return existingSocket;
        }

        // Create appropriate label
        var label = GetInputSocketLabel(name, ordinal);
        var input = new SceneInputConnectorViewModel(label, label, UniqueId, name, ordinal);
        input.Subtitle = $"({name},{ordinal})";

        // Insert in correct position to maintain coordinate order
        int insertIndex = FindInsertPosition(name, ordinal);
        Input.Insert(insertIndex, input);

        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return input;
    }

    /// <summary>
    /// Find the correct insert position to maintain coordinate ordering
    /// </summary>
    private int FindInsertPosition(ushort name, ushort ordinal)
    {
        for (int i = 0; i < Input.Count; i++)
        {
            var socket = Input[i] as SceneInputConnectorViewModel;
            if (socket != null)
            {
                // Sort by name first, then ordinal
                if (socket.NameId > name || (socket.NameId == name && socket.Ordinal > ordinal))
                {
                    return i;
                }
            }
        }
        return Input.Count; // Insert at end
    }

    /// <summary>
    /// Get label for input socket based on coordinates
    /// </summary>
    private string GetInputSocketLabel(ushort name, ushort ordinal)
    {
        return (name, ordinal) switch
        {
            (0, 0) => "In",
            (0, 1) => "In1",
            (0, var ord) => $"In{ord}",
            (1, 0) => "Cancel",
            (1, var ord) => $"Cancel{ord}",
            (1026, 0) => "Failsafe",
            (1026, var ord) => $"Failsafe{ord}",
            _ => $"In_{name}_{ordinal}"
        };
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