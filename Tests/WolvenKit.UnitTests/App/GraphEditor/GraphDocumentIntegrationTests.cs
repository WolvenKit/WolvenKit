using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WolvenKit.App.Factories;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using WolvenKit.UnitTests.App.GraphEditor.Shared;
using Point = System.Windows.Point;

namespace WolvenKit.UnitTests.App.GraphEditor;

[TestClass]
[DoNotParallelize]
public class GraphDocumentIntegrationTests
{
    [TestMethod]
    public void QuestGraphMutationsMarkDocumentDirty()
    {
        using var fixture = new GraphDocumentTestFixture("mod\\test.questphase");
        var start = new questStartNodeDefinition { Id = 1 };
        GraphTestHelpers.AddQuestSocket(start, "Out", Enums.questSocketType.Output);
        var end = new questEndNodeDefinition { Id = 2 };
        GraphTestHelpers.AddQuestSocket(end, "In", Enums.questSocketType.Input);
        var graphData = GraphTestHelpers.CreateQuestGraph(start, end);
        using var graph = RedGraph.GenerateQuestGraph("test.questphase", graphData, Mock.Of<INodeWrapperFactory>());
        AttachDocument(graph, fixture.Document);

        graph.CreateQuestNode(typeof(questFactsDBManagerNodeDefinition), new Point());
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.PendingConnection.Source = graph.Nodes.OfType<questStartNodeDefinitionWrapper>().Single().Output.Single();
        graph.PendingConnection.Target = graph.Nodes.OfType<questEndNodeDefinitionWrapper>().Single().Input.Single();
        graph.Connect();
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.RemoveQuestConnectionPublic(graph.Connections.Cast<QuestConnectionViewModel>().Single());
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.RemoveNode(graph.Nodes.OfType<questFactsDBManagerNodeDefinitionWrapper>().Single());
        Assert.IsTrue(fixture.Document.IsDirty);
    }

    [TestMethod]
    public void SceneGraphMutationsMarkDocumentDirty()
    {
        using var fixture = new GraphDocumentTestFixture();
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        GraphTestHelpers.AddSceneOutput(start);
        var end = new scnEndNode { NodeId = new scnNodeId { Id = 2 } };
        var resource = GraphTestHelpers.CreateSceneResource(start, end);
        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource, fixture.Document);

        graph.CreateSceneNode(typeof(scnAndNode), new Point());
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.PendingConnection.Source = graph.Nodes.OfType<scnStartNodeWrapper>().Single().Output.Single();
        graph.PendingConnection.Target = graph.Nodes.OfType<scnEndNodeWrapper>().Single().Input.Single();
        graph.Connect();
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.RemoveSceneConnectionPublic(graph.Connections.Cast<SceneConnectionViewModel>().Single());
        Assert.IsTrue(fixture.Document.IsDirty);

        fixture.Document.SetIsDirty(false);
        graph.RemoveNode(graph.Nodes.OfType<scnAndNodeWrapper>().Single());
        Assert.IsTrue(fixture.Document.IsDirty);
    }

    [TestMethod]
    public void SceneGraphGenerationAndRefreshDoNotMarkDocumentDirty()
    {
        using var fixture = new GraphDocumentTestFixture();
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        GraphTestHelpers.AddSceneOutput(start);
        var resource = GraphTestHelpers.CreateSceneResource(start);

        using var graph = RedGraph.GenerateSceneGraph("test.scene", resource, fixture.Document);

        Assert.IsFalse(fixture.Document.IsDirty);

        graph.Nodes.Single().RefreshFromData();

        Assert.IsFalse(fixture.Document.IsDirty);
    }

    [TestMethod]
    public void GraphStateRoundTripRestoresNodeAndCommentMetadata()
    {
        using var fixture = new GraphDocumentTestFixture();
        fixture.EnableStateLoading();
        var node = new scnAndNode { NodeId = new scnNodeId { Id = 1 } };
        GraphTestHelpers.AddSceneOutput(node);
        var resource = GraphTestHelpers.CreateSceneResource(node);

        using (var graph = RedGraph.GenerateSceneGraph("test.scene", resource, fixture.Document))
        {
            graph.GraphStateLoad();
            graph.Nodes.Single().Location = new Point(120, 340);
            graph.Nodes.Single().ShowUnusedSockets = false;
            var comment = graph.AddComment(new Point(20, 40));
            comment.Text = "Stateful comment";
            comment.AccentColor = "#FFFF8800";
            comment.Width = 640;
            comment.Height = 360;
            graph.GraphStateSave();
            graph.GraphCommentStateSave();
        }

        fixture.Document.SetIsDirty(false);
        using var restored = RedGraph.GenerateSceneGraph("test.scene", resource, fixture.Document);
        restored.GraphStateLoad();

        Assert.AreEqual(new Point(120, 340), restored.Nodes.Single().Location);
        Assert.IsFalse(restored.Nodes.Single().ShowUnusedSockets);
        var restoredComment = restored.Comments.Single();
        Assert.AreEqual("Stateful comment", restoredComment.Text);
        Assert.AreEqual("#FFFF8800", restoredComment.AccentColor);
        Assert.AreEqual(new Point(20, 40), restoredComment.Location);
        Assert.AreEqual(640, restoredComment.Width);
        Assert.AreEqual(360, restoredComment.Height);
        Assert.IsFalse(fixture.Document.IsDirty);
    }

    [TestMethod]
    public void StateParentsKeepNestedGraphStateSeparate()
    {
        using var fixture = new GraphDocumentTestFixture("mod\\test.questphase");
        fixture.EnableStateLoading();
        fixture.EnableStateLoading(".phase_7");

        SaveGraphLocation(fixture, "", new Point(10, 20));
        SaveGraphLocation(fixture, ".phase_7", new Point(70, 80));

        Assert.AreEqual(new Point(10, 20), LoadGraphLocation(fixture, ""));
        Assert.AreEqual(new Point(70, 80), LoadGraphLocation(fixture, ".phase_7"));
    }

    [TestMethod]
    public void DisposingGraphUnsubscribesFromNodePropertyUpdates()
    {
        using var fixture = new GraphDocumentTestFixture();
        var start = new scnStartNode { NodeId = new scnNodeId { Id = 1 } };
        GraphTestHelpers.AddSceneOutput(start);
        var resource = GraphTestHelpers.CreateSceneResource(start);
        var graph = RedGraph.GenerateSceneGraph("test.scene", resource, fixture.Document);
        var wrapper = graph.Nodes.Single();
        var notifications = 0;
        wrapper.PropertyChanged += (_, _) => notifications++;

        NodePropertyUpdateService.NotifyPropertyUpdated(wrapper.Data);
        Assert.IsTrue(notifications > 0);

        graph.Dispose();
        notifications = 0;
        NodePropertyUpdateService.NotifyPropertyUpdated(wrapper.Data);

        Assert.AreEqual(0, notifications);
    }

    private static void AttachDocument(RedGraph graph, WolvenKit.App.ViewModels.Documents.RedDocumentViewModel document)
    {
        graph.DocumentViewModel = document;
        foreach (var node in graph.Nodes)
        {
            node.DocumentViewModel = document;
        }
    }

    private static void SaveGraphLocation(GraphDocumentTestFixture fixture, string stateParents, Point location)
    {
        var node = new questStartNodeDefinition { Id = 1 };
        var graphData = GraphTestHelpers.CreateQuestGraph(node);
        using var graph = RedGraph.GenerateQuestGraph("test.questphase", graphData, Mock.Of<INodeWrapperFactory>());
        AttachDocument(graph, fixture.Document);
        graph.StateParents = stateParents;
        graph.GraphStateLoad();
        graph.Nodes.Single().Location = location;
        graph.GraphStateSave();
    }

    private static Point LoadGraphLocation(GraphDocumentTestFixture fixture, string stateParents)
    {
        var node = new questStartNodeDefinition { Id = 1 };
        var graphData = GraphTestHelpers.CreateQuestGraph(node);
        using var graph = RedGraph.GenerateQuestGraph("test.questphase", graphData, Mock.Of<INodeWrapperFactory>());
        AttachDocument(graph, fixture.Document);
        graph.StateParents = stateParents;
        graph.GraphStateLoad();
        return graph.Nodes.Single().Location;
    }

}
