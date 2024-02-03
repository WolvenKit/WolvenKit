using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public abstract class BaseSceneViewModel : NodeViewModel
{
    public override uint UniqueId => ((scnSceneGraphNode)Data).NodeId.Id;

    public Dictionary<ushort, string> InputSocketNames = new();
    public Dictionary<ushort, string> OutputSocketNames = new();

    protected BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        Title = $"{Data.GetType().Name[3..^4]} [{UniqueId}]";
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
    }
}