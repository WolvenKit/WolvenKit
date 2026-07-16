using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using WolvenKit.UnitTests.App.GraphEditor.Shared;
using Point = System.Windows.Point;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene;

[TestClass]
[DoNotParallelize]
public class SceneGraphTests
{
    [TestMethod]
    public void GenerateGraphCreatesExpectedWrappersAndConnection()
    {
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        var output = GraphTestHelpers.AddSceneOutput(start);
        var end = new scnEndNode { NodeId = new scnNodeId { Id = 2 } };
        var destination = GraphTestHelpers.ConnectSceneSocket(output, end.NodeId.Id);
        var resource = GraphTestHelpers.CreateSceneResource(start, end);

        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);

        Assert.AreEqual(RedGraphType.Scene, graph.GraphType);
        Assert.AreEqual(2, graph.Nodes.Count);
        Assert.AreEqual(2, graph.CanvasItems.Count);
        Assert.IsInstanceOfType(graph.Nodes[0], typeof(scnStartNodeWrapper));
        Assert.IsInstanceOfType(graph.Nodes[1], typeof(scnEndNodeWrapper));

        var connection = graph.Connections.Cast<SceneConnectionViewModel>().Single();
        Assert.AreSame(output, ((SceneOutputConnectorViewModel)connection.Source).Data);
        Assert.AreEqual((uint)destination.NodeId.Id, connection.Target.OwnerId);
        Assert.AreEqual((ushort)destination.IsockStamp.Name, ((SceneInputConnectorViewModel)connection.Target).NameId);
        Assert.AreEqual((ushort)destination.IsockStamp.Ordinal, ((SceneInputConnectorViewModel)connection.Target).Ordinal);
        Assert.IsTrue(connection.Source.IsConnected);
        Assert.IsTrue(connection.Target.IsConnected);
    }

    [TestMethod]
    public void ConnectAndDisconnectSynchronizesBackingSocket()
    {
        var resource = GraphTestHelpers.CreateSceneResource();
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        graph.CreateSceneNode(typeof(scnStartNode), new Point());
        graph.CreateSceneNode(typeof(scnEndNode), new Point());

        var source = graph.Nodes
            .OfType<scnStartNodeWrapper>()
            .Single()
            .Output
            .Cast<SceneOutputConnectorViewModel>()
            .Single();
        var target = graph.Nodes
            .OfType<scnEndNodeWrapper>()
            .Single()
            .Input
            .Cast<SceneInputConnectorViewModel>()
            .Single();

        graph.PendingConnection.Source = source;
        graph.PendingConnection.Target = target;
        graph.Connect();

        var connection = graph.Connections.Cast<SceneConnectionViewModel>().Single();
        var destination = source.Data!.Destinations.Single();
        Assert.AreEqual(target.OwnerId, (uint)destination.NodeId.Id);
        Assert.AreEqual(target.NameId, (ushort)destination.IsockStamp.Name);
        Assert.AreEqual(target.Ordinal, (ushort)destination.IsockStamp.Ordinal);

        graph.RemoveSceneConnectionPublic(connection);

        Assert.AreEqual(0, graph.Connections.Count);
        Assert.AreEqual(0, source.Data.Destinations.Count);
        Assert.IsFalse(source.IsConnected);
        Assert.IsFalse(target.IsConnected);
    }

    [TestMethod]
    public void RemoveNodeRemovesBackingNodeAndIncidentConnections()
    {
        var resource = GraphTestHelpers.CreateSceneResource();
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        graph.CreateSceneNode(typeof(scnStartNode), new Point());
        graph.CreateSceneNode(typeof(scnEndNode), new Point());

        var sourceNode = graph.Nodes.OfType<scnStartNodeWrapper>().Single();
        var targetNode = graph.Nodes.OfType<scnEndNodeWrapper>().Single();
        graph.PendingConnection.Source = sourceNode.Output.Single();
        graph.PendingConnection.Target = targetNode.Input.Single();
        graph.Connect();

        graph.RemoveNode(targetNode);

        Assert.AreEqual(1, graph.Nodes.Count);
        Assert.AreEqual(1, graph.CanvasItems.Count);
        Assert.AreEqual(1, resource.SceneGraph.Chunk!.Graph.Count);
        Assert.AreSame(sourceNode.Data, resource.SceneGraph.Chunk.Graph[0].GetValue());
        Assert.AreEqual(0, graph.Connections.Count);
        Assert.AreEqual(0, ((SceneOutputConnectorViewModel)sourceNode.Output.Single()).Data!.Destinations.Count);
    }

    [TestMethod]
    public void CreateNodeUsesNextIdAndCreatesStandardSockets()
    {
        var existing = new scnAndNode { NodeId = new scnNodeId { Id = 7 } };
        var resource = GraphTestHelpers.CreateSceneResource(existing);
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);

        var id = graph.CreateSceneNode(typeof(scnAndNode), new Point(10, 20));

        var wrapper = graph.Nodes.OfType<scnAndNodeWrapper>().Single(node => node.UniqueId == id);
        Assert.AreEqual(8U, id);
        CollectionAssert.AreEqual(new[] { "In", "Cancel" }, wrapper.Input.Select(connector => connector.Name).ToArray());
        Assert.AreEqual(1, wrapper.Output.Count);
        var output = (SceneOutputConnectorViewModel)wrapper.Output.Single();
        Assert.AreEqual((ushort)0, output.NameId);
        Assert.AreEqual((ushort)0, output.Ordinal);
        Assert.AreEqual(2, resource.SceneGraph.Chunk!.Graph.Count);
        Assert.AreEqual(new Point(10, 20), wrapper.Location);
    }

    [TestMethod]
    public void CreateEmbeddedQuestNodeKeepsSceneAndQuestIdsAndSocketsInSync()
    {
        var resource = GraphTestHelpers.CreateSceneResource();
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);

        var id = graph.CreateSceneNode(typeof(questConditionNodeDefinition), new Point());

        var wrapper = graph.Nodes.OfType<scnQuestNodeWrapper>().Single();
        var sceneNode = (scnQuestNode)wrapper.Data;
        Assert.AreEqual(id, (uint)sceneNode.NodeId.Id);
        Assert.AreEqual((ushort)id, (ushort)sceneNode.QuestNode.Chunk!.Id);
        Assert.IsInstanceOfType(sceneNode.QuestNode.GetValue(), typeof(questConditionNodeDefinition));
        CollectionAssert.AreEqual(
            new[] { "CutDestination", "In" },
            wrapper.Input.Select(connector => connector.Name).ToArray());
        CollectionAssert.AreEqual(
            new[] { "True", "False" },
            wrapper.Output.Select(connector => connector.Subtitle).ToArray());
        Assert.AreEqual(2, sceneNode.OutputSockets.Count);
    }

    [TestMethod]
    public void RefreshDetailsReflectsChangesToEmbeddedQuestNodeData()
    {
        var resource = GraphTestHelpers.CreateSceneResource();
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        graph.CreateSceneNode(typeof(questFactsDBManagerNodeDefinition), new Point());
        var wrapper = graph.Nodes.OfType<scnQuestNodeWrapper>().Single();
        var sceneNode = (scnQuestNode)wrapper.Data;
        var factsNode = (questFactsDBManagerNodeDefinition)sceneNode.QuestNode.GetValue()!;
        var nodeType = (questSetVar_NodeType)factsNode.Type.GetValue()!;
        nodeType.FactName = "first_fact";
        nodeType.Value = 1;
        wrapper.RefreshDetails();

        Assert.AreEqual("first_fact", wrapper.Details["Fact Name"]);
        Assert.AreEqual("1", wrapper.Details["Value"]);

        nodeType.FactName = "updated_fact";
        nodeType.Value = 2;
        wrapper.RefreshDetails();

        Assert.AreEqual("updated_fact", wrapper.Details["Fact Name"]);
        Assert.AreEqual("2", wrapper.Details["Value"]);
        Assert.IsFalse(wrapper.Details.ContainsValue("first_fact"));
    }

    [TestMethod]
    public void RefreshFromDataPreservesSceneConnectorsAndConnection()
    {
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        var output = GraphTestHelpers.AddSceneOutput(start);
        var end = new scnEndNode { NodeId = new scnNodeId { Id = 2 } };
        GraphTestHelpers.ConnectSceneSocket(output, end.NodeId.Id);
        var resource = GraphTestHelpers.CreateSceneResource(start, end);
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        var startWrapper = graph.Nodes.OfType<scnStartNodeWrapper>().Single();
        var endWrapper = graph.Nodes.OfType<scnEndNodeWrapper>().Single();
        var source = startWrapper.Output.Single();
        var target = endWrapper.Input.Single();
        var connection = graph.Connections.Single();

        startWrapper.RefreshFromData();
        endWrapper.RefreshFromData();

        Assert.AreSame(source, startWrapper.Output.Single());
        Assert.AreSame(target, endWrapper.Input.Single());
        Assert.AreSame(source, connection.Source);
        Assert.AreSame(target, connection.Target);
        Assert.IsTrue(source.IsConnected);
        Assert.IsTrue(target.IsConnected);
    }

    [TestMethod]
    public void GenerateGraphSkipsDestinationForNodeOutsideGraph()
    {
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        var output = GraphTestHelpers.AddSceneOutput(start);
        GraphTestHelpers.ConnectSceneSocket(output, 999);
        var resource = GraphTestHelpers.CreateSceneResource(start);

        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);

        Assert.AreEqual(1, graph.Nodes.Count);
        Assert.AreEqual(0, graph.Connections.Count);
        Assert.AreEqual(1, output.Destinations.Count);
    }

    [TestMethod]
    public void AddAndRemoveDynamicInputKeepsCancelAndBackingCountInSync()
    {
        var node = new scnAndNode
        {
            NodeId = new scnNodeId { Id = 1 },
            NumInSockets = 2
        };
        GraphTestHelpers.AddSceneOutput(node);
        var resource = GraphTestHelpers.CreateSceneResource(node);
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        var wrapper = graph.Nodes.OfType<scnAndNodeWrapper>().Single();

        var connector = (SceneInputConnectorViewModel)wrapper.AddInput();

        Assert.AreEqual((ushort)0, connector.NameId);
        Assert.AreEqual((ushort)1, connector.Ordinal);
        Assert.AreEqual(3U, (uint)node.NumInSockets);
        Assert.AreEqual(3, wrapper.Input.Count);

        wrapper.RemoveInput();

        CollectionAssert.AreEqual(new[] { "In", "Cancel" }, wrapper.Input.Select(input => input.Name).ToArray());
        Assert.AreEqual(2U, (uint)node.NumInSockets);
    }

    [TestMethod]
    public void AddAndRemoveDynamicXorInputKeepsCancelSocket()
    {
        AssertDynamicInputRemovalKeepsCancel(new scnXorNode(), typeof(scnXorNodeWrapper));
    }

    [TestMethod]
    public void AddAndRemoveDynamicHubInputKeepsCancelSocket()
    {
        AssertDynamicInputRemovalKeepsCancel(new scnHubNode(), typeof(scnHubNodeWrapper));
    }

    private static void AssertDynamicInputRemovalKeepsCancel(scnSceneGraphNode node, Type wrapperType)
    {
        node.NodeId = new scnNodeId { Id = 1 };
        GraphTestHelpers.AddSceneOutput(node);
        var resource = GraphTestHelpers.CreateSceneResource(node);
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource);
        var wrapper = (BaseSceneViewModel)graph.Nodes.Single(candidate => candidate.GetType() == wrapperType);
        var dynamicInput = (IDynamicInputNode)wrapper;

        var connector = (SceneInputConnectorViewModel)dynamicInput.AddInput();

        Assert.AreEqual((ushort)0, connector.NameId);
        Assert.AreEqual((ushort)1, connector.Ordinal);

        dynamicInput.RemoveInput();

        CollectionAssert.AreEqual(new[] { "In", "Cancel" }, wrapper.Input.Select(input => input.Name).ToArray());
    }
}
