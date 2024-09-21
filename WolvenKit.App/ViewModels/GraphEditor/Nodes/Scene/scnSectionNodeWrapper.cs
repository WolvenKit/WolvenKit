using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnSectionNodeWrapper : BaseSceneViewModel<scnSectionNode>
{
    public scnSectionNodeWrapper(scnSectionNode scnSectionNode, scnSceneResource scnSceneResource) : base(scnSectionNode)
    {
        Details["Section Duration"] = scnSectionNode.SectionDuration.Stu.ToString() + "ms";
        Details["Ff Strategy"] = scnSectionNode.FfStrategy.ToEnumString();

        var events = scnSectionNode.Events;
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

        Title += NodeProperties.SetNameFromNotablePoints(scnSectionNode.NodeId.Id, scnSceneResource);
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var title = $"Out{i} - Name: " + _castedData.OutputSockets[i].Stamp.Name + ", Ordinal: " + _castedData.OutputSockets[i].Stamp.Ordinal;
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, _castedData.OutputSockets[i]));
        }
    }
}