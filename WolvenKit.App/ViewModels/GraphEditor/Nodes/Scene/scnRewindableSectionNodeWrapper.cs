using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnRewindableSectionNodeWrapper : BaseSceneViewModel<scnRewindableSectionNode>
{
    public scnRewindableSectionNodeWrapper(scnRewindableSectionNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode)
    {
        Details["Section Duration"] = scnSceneGraphNode.SectionDuration.Stu.ToString() + "ms";
        Details["Ff Strategy"] = scnSceneGraphNode.FfStrategy.ToEnumString();
        Details["Play Speed Modifiers - Backward Fast"] = scnSceneGraphNode.PlaySpeedModifiers.BackwardFast.ToString();
        Details["Play Speed Modifiers - Backward Slow"] = scnSceneGraphNode.PlaySpeedModifiers.BackwardSlow.ToString();
        Details["Play Speed Modifiers - Backward Very Fast"] = scnSceneGraphNode.PlaySpeedModifiers.BackwardVeryFast.ToString();
        Details["Play Speed Modifiers - Forward Fast"] = scnSceneGraphNode.PlaySpeedModifiers.ForwardFast.ToString();
        Details["Play Speed Modifiers - Forward Slow"] = scnSceneGraphNode.PlaySpeedModifiers.ForwardSlow.ToString();
        Details["Play Speed Modifiers - Forward Very Fast"] = scnSceneGraphNode.PlaySpeedModifiers.ForwardVeryFast.ToString();

        var events = scnSceneGraphNode.Events;
        Details["Events"] = events.Count.ToString();

        int counter = 1;
        foreach (var eventClass in events)
        {
            string evName = eventClass?.Chunk?.GetType().Name!;

            if (eventClass?.Chunk is scneventsSocket evSocket)
            {
                evName += " - Name: " + evSocket.OsockStamp.Name.ToString()! + ", Ordinal: " + evSocket.OsockStamp.Ordinal.ToString()!;
            }

            Details["#" + counter.ToString() + " " + eventClass?.Chunk?.StartTime.ToString() + "ms"] = evName;
            counter++;
        }

        Title += NodeProperties.SetNameFromNotablePoints(scnSceneGraphNode.NodeId.Id, scnSceneResource);
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var title = $"Out{i} - Name: " + _castedData.OutputSockets[i].Stamp.Name + ", Ordinal: " + _castedData.OutputSockets[i].Stamp.Ordinal;
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, _castedData.OutputSockets[i]));
        }
    }
}