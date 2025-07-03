using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using System.Linq;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnDeletionMarkerNodeWrapper : BaseSceneViewModel<scnDeletionMarkerNode>, IDynamicInputNode
{
    public scnDeletionMarkerNodeWrapper(scnDeletionMarkerNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        // Don't add to dictionaries - we'll generate sockets based on actual data
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Output.Clear();

        // Generate all output sockets that exist in the data (needed for loading existing files)
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            var label = GetOutputSocketLabel(socket.Stamp.Name, socket.Stamp.Ordinal);
            var connectorVM = new SceneOutputConnectorViewModel($"({socket.Stamp.Name},{socket.Stamp.Ordinal})", $"({socket.Stamp.Name},{socket.Stamp.Ordinal})", UniqueId, socket);
            connectorVM.Subtitle = label;
            Output.Add(connectorVM);
            SubscribeToSocketDestinations(connectorVM);
        }

        // For loading existing files, create basic input sockets that are commonly used
        // More specific sockets will be added during connection mapping if needed
        AddInputSocket(666, 0);  // Most common: In
        AddInputSocket(666, 1);  // Second most common: In1 (Cancel)
    }

    private void AddInputSocket(ushort name, ushort ordinal)
    {
        var label = GetInputSocketLabel(name, ordinal);
        var input = new SceneInputConnectorViewModel($"({name},{ordinal})", $"({name},{ordinal})", UniqueId, name, ordinal);
        input.Subtitle = label;
        Input.Add(input);
    }

    private string GetOutputSocketLabel(ushort name, ushort ordinal)
    {
        if (name == 666)
        {
            return ordinal switch
            {
                0 => "Out",
                1 => "Out1", 
                2 => "Out2",
                3 => "Out3",
                _ => $"Out{ordinal}"
            };
        }
        return $"Out_{name}_{ordinal}";
    }

    private string GetInputSocketLabel(ushort name, ushort ordinal)
    {
        if (name == 666)
        {
            return ordinal switch
            {
                0 => "In",
                1 => "In1",
                2 => "In2", 
                3 => "In3",
                _ => $"In{ordinal}"
            };
        }
        else if (name == 1026)
        {
            return ordinal switch
            {
                0 => "Failsafe",
                _ => $"Failsafe{ordinal}"
            };
        }
        return $"In_{name}_{ordinal}";
    }

    public BaseConnectorViewModel AddInput()
    {
        // Find the next available ordinal for 666 sockets
        var existing666Sockets = Input.Where(i => (i as SceneInputConnectorViewModel)?.NameId == 666).ToList();
        ushort nextOrdinal = 0;
        if (existing666Sockets.Any())
        {
            nextOrdinal = (ushort)(existing666Sockets.Max(i => (i as SceneInputConnectorViewModel)?.Ordinal ?? 0) + 1);
        }

        AddInputSocket(666, nextOrdinal);

        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return Input.Last();
    }

    public BaseConnectorViewModel AddInputWithCoordinates(ushort name, ushort ordinal)
    {
        // Check if socket already exists
        var existingSocket = Input.FirstOrDefault(i => 
            (i as SceneInputConnectorViewModel)?.NameId == name && 
            (i as SceneInputConnectorViewModel)?.Ordinal == ordinal);
            
        if (existingSocket != null)
        {
            return existingSocket;
        }

        AddInputSocket(name, ordinal);

        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return Input.Last();
    }

    public void RemoveInput() 
    {
        // Only remove 666-type sockets with higher ordinals, keep (666,0), (666,1) and any 1026 sockets
        var removableSocket = Input
            .OfType<SceneInputConnectorViewModel>()
            .Where(i => i.NameId == 666 && i.Ordinal > 1)
            .OrderByDescending(i => i.Ordinal)
            .FirstOrDefault();

        if (removableSocket != null)
        {
            Input.Remove(removableSocket);
            
            // Notify UI and mark document dirty
            NotifySocketsChanged();
        }
    }
}