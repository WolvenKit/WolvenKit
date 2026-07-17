using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.GraphEditor.Shared;

internal static class GraphTestHelpers
{
    public static questGraphDefinition CreateQuestGraph(params graphGraphNodeDefinition[] nodes)
    {
        var graph = new questGraphDefinition();
        foreach (var node in nodes)
        {
            graph.Nodes.Add(new CHandle<graphGraphNodeDefinition>(node));
        }

        return graph;
    }

    public static questSocketDefinition AddQuestSocket(
        graphGraphNodeDefinition node,
        string name,
        Enums.questSocketType type)
    {
        var socket = new questSocketDefinition { Name = name, Type = type };
        node.Sockets.Add(new CHandle<graphGraphSocketDefinition>(socket));
        return socket;
    }

    public static graphGraphConnectionDefinition ConnectQuestSockets(
        questSocketDefinition source,
        questSocketDefinition destination)
    {
        var connection = new graphGraphConnectionDefinition
        {
            Source = new CWeakHandle<graphGraphSocketDefinition>(source),
            Destination = new CWeakHandle<graphGraphSocketDefinition>(destination)
        };

        source.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));
        destination.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));
        return connection;
    }

    public static scnSceneResource CreateSceneResource(params scnSceneGraphNode[] nodes)
    {
        var sceneGraph = new scnSceneGraph();
        var resource = new scnSceneResource
        {
            SceneGraph = new CHandle<scnSceneGraph>(sceneGraph)
        };

        foreach (var node in nodes)
        {
            sceneGraph.Graph.Add(new CHandle<scnSceneGraphNode>(node));

            if (node is scnStartNode)
            {
                resource.EntryPoints.Add(new scnEntryPoint { NodeId = new scnNodeId { Id = node.NodeId.Id } });
            }
            else if (node is scnEndNode)
            {
                resource.ExitPoints.Add(new scnExitPoint { NodeId = new scnNodeId { Id = node.NodeId.Id } });
            }
        }

        return resource;
    }

    public static scnOutputSocket AddSceneOutput(
        scnSceneGraphNode node,
        ushort name = 0,
        ushort ordinal = 0)
    {
        var socket = new scnOutputSocket
        {
            Stamp = new scnOutputSocketStamp { Name = name, Ordinal = ordinal }
        };
        node.OutputSockets.Add(socket);
        return socket;
    }

    public static scnInputSocketId ConnectSceneSocket(
        scnOutputSocket source,
        uint targetNodeId,
        ushort inputName = 0,
        ushort inputOrdinal = 0)
    {
        var destination = new scnInputSocketId
        {
            NodeId = new scnNodeId { Id = targetNodeId },
            IsockStamp = new scnInputSocketStamp { Name = inputName, Ordinal = inputOrdinal }
        };
        source.Destinations.Add(destination);
        return destination;
    }
}
