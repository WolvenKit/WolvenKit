using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnSectionNodeWrapper : BaseSceneViewModel<scnSectionNode>
{
    public scnSectionNodeWrapper(scnSectionNode scnSectionNode) : base(scnSectionNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        
        OutputSocketNames.Add(0, "Out");
        OutputSocketNames.Add(1, "CancelForward");
        //OutputSocketNames.Add(2, "TransmitSignal");
        //OutputSocketNames.Add(3, "StopWork");
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        foreach (var (socketNameId, socketName) in InputSocketNames)
        {
            Input.Add(new SceneInputConnectorViewModel(socketName, socketName, UniqueId, socketNameId, 0));
        }

        Output.Clear();
        foreach (var (socketNameId, socketName) in OutputSocketNames)
        {
            var sockets = _castedData.OutputSockets
                .Where(x => x.Stamp.Name == socketNameId)
                .OrderBy(x => (ushort)x.Stamp.Ordinal)
                .ToList();

            if (sockets.Count > 0)
            {
                foreach (var socket in sockets)
                {
                    Output.Add(new SceneOutputConnectorViewModel($"{socketName}_{socket.Stamp.Ordinal}", $"{socketName}_{socket.Stamp.Ordinal}", UniqueId, socket));
                }
            }
            else
            {
                Output.Add(new SceneOutputConnectorViewModel($"{socketName}_0", $"{socketName}_0", UniqueId));
            }
        }

        foreach (var sceneEvent in _castedData.Events)
        {
            if (sceneEvent.Chunk is not scneventsSocket eventSocket)
            {
                continue;
            }

            var sockets = _castedData.OutputSockets
                .Where(x => x.Stamp.Name == eventSocket.OsockStamp.Name)
                .OrderBy(x => (ushort)x.Stamp.Ordinal)
                .ToList();

            foreach (var socket in sockets)
            {
                Output.Add(new SceneOutputConnectorViewModel($"Event {socket.Stamp.Name}_{socket.Stamp.Ordinal}", $"Event {socket.Stamp.Name}_{socket.Stamp.Ordinal}", UniqueId, socket));
            }
        }
    }
}