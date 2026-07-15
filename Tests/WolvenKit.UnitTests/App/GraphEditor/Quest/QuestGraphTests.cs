using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;
using WolvenKit.UnitTests.App.GraphEditor.Shared;
using Point = System.Windows.Point;

namespace WolvenKit.UnitTests.App.GraphEditor.Quest;

[TestClass]
[DoNotParallelize]
public class QuestGraphTests
{
    [TestMethod]
    public void GenerateGraphCreatesExpectedWrappersAndConnection()
    {
        var start = new questStartNodeDefinition { Id = 1 };
        GraphTestHelpers.AddQuestSocket(start, "CutDestination", Enums.questSocketType.CutDestination);
        var output = GraphTestHelpers.AddQuestSocket(start, "Out", Enums.questSocketType.Output);

        var end = new questEndNodeDefinition { Id = 2 };
        GraphTestHelpers.AddQuestSocket(end, "CutDestination", Enums.questSocketType.CutDestination);
        var input = GraphTestHelpers.AddQuestSocket(end, "In", Enums.questSocketType.Input);
        var connectionData = GraphTestHelpers.ConnectQuestSockets(output, input);
        var graphData = GraphTestHelpers.CreateQuestGraph(start, end);

        using var graph = GenerateGraph(graphData);

        Assert.AreEqual(RedGraphType.Quest, graph.GraphType);
        Assert.AreEqual(2, graph.Nodes.Count);
        Assert.AreEqual(2, graph.CanvasItems.Count);
        Assert.IsInstanceOfType(graph.Nodes[0], typeof(questStartNodeDefinitionWrapper));
        Assert.IsInstanceOfType(graph.Nodes[1], typeof(questEndNodeDefinitionWrapper));

        var connection = graph.Connections.Cast<QuestConnectionViewModel>().Single();
        Assert.AreSame(connectionData, connection.ConnectionDefinition);
        Assert.AreSame(output, ((QuestOutputConnectorViewModel)connection.Source).Data);
        Assert.AreSame(input, ((QuestInputConnectorViewModel)connection.Target).Data);
        Assert.IsTrue(connection.Source.IsConnected);
        Assert.IsTrue(connection.Target.IsConnected);
    }

    [TestMethod]
    public void ConnectAndDisconnectSynchronizesBackingSockets()
    {
        var graphData = GraphTestHelpers.CreateQuestGraph();
        using var graph = GenerateGraph(graphData);
        graph.CreateQuestNode(typeof(questStartNodeDefinition), new Point());
        graph.CreateQuestNode(typeof(questEndNodeDefinition), new Point());

        var source = graph.Nodes
            .OfType<questStartNodeDefinitionWrapper>()
            .Single()
            .Output
            .Cast<QuestOutputConnectorViewModel>()
            .Single();
        var target = graph.Nodes
            .OfType<questEndNodeDefinitionWrapper>()
            .Single()
            .Input
            .Cast<QuestInputConnectorViewModel>()
            .Single(connector => connector.Name == "In");

        graph.PendingConnection.Source = source;
        graph.PendingConnection.Target = target;
        graph.Connect();

        var connection = graph.Connections.Cast<QuestConnectionViewModel>().Single();
        Assert.AreEqual(1, source.Data.Connections.Count);
        Assert.AreEqual(1, target.Data.Connections.Count);
        Assert.AreSame(source.Data, connection.ConnectionDefinition.Source.GetValue());
        Assert.AreSame(target.Data, connection.ConnectionDefinition.Destination.GetValue());

        graph.RemoveQuestConnectionPublic(connection);

        Assert.AreEqual(0, graph.Connections.Count);
        Assert.AreEqual(0, source.Data.Connections.Count);
        Assert.AreEqual(0, target.Data.Connections.Count);
        Assert.IsFalse(source.IsConnected);
        Assert.IsFalse(target.IsConnected);
    }

    [TestMethod]
    public void RemoveNodeRemovesBackingNodeAndIncidentConnections()
    {
        var graphData = GraphTestHelpers.CreateQuestGraph();
        using var graph = GenerateGraph(graphData);
        graph.CreateQuestNode(typeof(questStartNodeDefinition), new Point());
        graph.CreateQuestNode(typeof(questEndNodeDefinition), new Point());

        var sourceNode = graph.Nodes.OfType<questStartNodeDefinitionWrapper>().Single();
        var targetNode = graph.Nodes.OfType<questEndNodeDefinitionWrapper>().Single();
        graph.PendingConnection.Source = sourceNode.Output.Single();
        graph.PendingConnection.Target = targetNode.Input.Single(connector => connector.Name == "In");
        graph.Connect();

        graph.RemoveNode(targetNode);

        Assert.AreEqual(1, graph.Nodes.Count);
        Assert.AreEqual(1, graph.CanvasItems.Count);
        Assert.AreEqual(1, graphData.Nodes.Count);
        Assert.AreSame(sourceNode.Data, graphData.Nodes[0].GetValue());
        Assert.AreEqual(0, graph.Connections.Count);
        Assert.AreEqual(0, ((QuestOutputConnectorViewModel)sourceNode.Output.Single()).Data.Connections.Count);
    }

    [TestMethod]
    public void CreateNodeUsesNextIdAndCreatesDefaultSockets()
    {
        var existing = new questStartNodeDefinition { Id = 7 };
        var graphData = GraphTestHelpers.CreateQuestGraph(existing);
        using var graph = GenerateGraph(graphData);

        graph.CreateQuestNode(typeof(questStartNodeDefinition), new Point(10, 20));
        graph.CreateQuestNode(typeof(questEndNodeDefinition), new Point(30, 40));

        var start = graph.Nodes.OfType<questStartNodeDefinitionWrapper>().Single(node => node.UniqueId == 8);
        var end = graph.Nodes.OfType<questEndNodeDefinitionWrapper>().Single();

        Assert.AreEqual(8U, start.UniqueId);
        Assert.AreEqual(9U, end.UniqueId);
        CollectionAssert.AreEqual(new[] { "CutDestination" }, start.Input.Select(connector => connector.Name).ToArray());
        CollectionAssert.AreEqual(new[] { "Out" }, start.Output.Select(connector => connector.Name).ToArray());
        CollectionAssert.AreEqual(new[] { "CutDestination", "In" }, end.Input.Select(connector => connector.Name).ToArray());
        Assert.AreEqual(0, end.Output.Count);
        Assert.AreEqual(3, graphData.Nodes.Count);
        Assert.AreEqual(new Point(10, 20), start.Location);
    }

    [TestMethod]
    public void CreateFactsDbNodeInitializesItsOnlySupportedType()
    {
        var graphData = GraphTestHelpers.CreateQuestGraph();
        using var graph = GenerateGraph(graphData);

        graph.CreateQuestNode(typeof(questFactsDBManagerNodeDefinition), new Point());

        var wrapper = graph.Nodes.OfType<questFactsDBManagerNodeDefinitionWrapper>().Single();
        var node = (questFactsDBManagerNodeDefinition)wrapper.Data;
        Assert.IsInstanceOfType(node.Type.GetValue(), typeof(questSetVar_NodeType));
        CollectionAssert.AreEqual(
            new[] { "CutDestination", "In" },
            wrapper.Input.Select(connector => connector.Name).ToArray());
        CollectionAssert.AreEqual(new[] { "Out" }, wrapper.Output.Select(connector => connector.Name).ToArray());
    }

    [TestMethod]
    public void LoadingExistingSocketsDoesNotDuplicateThem()
    {
        var node = new questStartNodeDefinition { Id = 1 };
        GraphTestHelpers.AddQuestSocket(node, "CutDestination", Enums.questSocketType.CutDestination);
        GraphTestHelpers.AddQuestSocket(node, "Out", Enums.questSocketType.Output);
        var graphData = GraphTestHelpers.CreateQuestGraph(node);

        using var graph = GenerateGraph(graphData);

        Assert.AreEqual(2, node.Sockets.Count);
        Assert.AreEqual(1, graph.Nodes.Single().Input.Count);
        Assert.AreEqual(1, graph.Nodes.Single().Output.Count);
    }

    private static RedGraph GenerateGraph(questGraphDefinition graphData) =>
        RedGraph.GenerateQuestGraph("test.questphase", graphData, Mock.Of<INodeWrapperFactory>());
}
