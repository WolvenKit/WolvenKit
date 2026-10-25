using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.RED4.Types;
using WolvenKit.UnitTests.App.GraphEditor.Shared;

namespace WolvenKit.UnitTests.App.GraphEditor;

[TestClass]
[DoNotParallelize]
public class NodeSelectionServiceTests
{
    [TestMethod]
    public void SelectingSameNodeTypeInAnotherDocumentPreservesBothSelections()
    {
        using var first = new GraphDocumentTestFixture("first.scene");
        using var second = new GraphDocumentTestFixture("second.scene");
        using var firstNode = CreateNode(first.Document);
        using var secondNode = CreateNode(second.Document);
        var service = new NodeSelectionService();

        service.SetSelectedNode(firstNode);
        service.SetSelectedNode(secondNode);

        Assert.AreSame(firstNode, service.GetSelectedNode(first.Document));
        Assert.AreSame(secondNode, service.GetSelectedNode(second.Document));
        Assert.AreSame(secondNode, service.SelectedNode);
    }

    [TestMethod]
    public void ClearingInactiveEditorSelectionPreservesActiveDocument()
    {
        using var first = new GraphDocumentTestFixture("first.scene");
        using var second = new GraphDocumentTestFixture("second.scene");
        using var firstNode = CreateNode(first.Document);
        using var secondNode = CreateNode(second.Document);
        var service = new NodeSelectionService();
        service.SetSelectedNode(firstNode);
        service.SetSelectedNode(secondNode);

        service.SetSelectedNode(null, firstNode);

        Assert.IsNull(service.GetSelectedNode(first.Document));
        Assert.AreSame(secondNode, service.GetSelectedNode(second.Document));
        Assert.AreSame(secondNode, service.SelectedNode);
    }

    [TestMethod]
    public void DisposingInactiveDocumentClearsOnlyItsSelection()
    {
        using var first = new GraphDocumentTestFixture("first.scene");
        using var second = new GraphDocumentTestFixture("second.scene");
        using var firstNode = CreateNode(first.Document);
        using var secondNode = CreateNode(second.Document);
        var service = NodeSelectionService.Instance;
        service.SetSelectedNode(firstNode);
        service.SetSelectedNode(secondNode);

        first.Document.Dispose();

        Assert.IsNull(service.GetSelectedNode(first.Document));
        Assert.AreSame(secondNode, service.GetSelectedNode(second.Document));
        Assert.AreSame(secondNode, service.SelectedNode);
    }

    [TestMethod]
    public void TimelinesKeepTheirOwnSectionWhenAnotherDocumentChangesSelection()
    {
        using var first = new GraphDocumentTestFixture("first.scene");
        using var second = new GraphDocumentTestFixture("second.scene");
        using var firstNode = new scnSectionNodeWrapper(new scnSectionNode
        {
            NodeId = new scnNodeId { Id = 1 },
            SectionDuration = new scnSceneTime { Stu = 1000 }
        }, new scnSceneResource()) { DocumentViewModel = first.Document };
        using var secondNode = new scnSectionNodeWrapper(new scnSectionNode
        {
            NodeId = new scnNodeId { Id = 1 },
            SectionDuration = new scnSceneTime { Stu = 2000 }
        }, new scnSceneResource()) { DocumentViewModel = second.Document };
        using var firstTimeline = new TimelineService(first.Document);
        using var secondTimeline = new TimelineService(second.Document);
        var service = NodeSelectionService.Instance;

        service.SetSelectedNode(firstNode);
        service.SetSelectedNode(secondNode);

        Assert.AreSame(firstNode, firstTimeline.NodeWrapper);
        Assert.AreEqual(1000U, firstTimeline.SectionDuration);
        Assert.AreSame(secondNode, secondTimeline.NodeWrapper);
        Assert.AreEqual(2000U, secondTimeline.SectionDuration);

        service.ClearSelectionForDocument(first.Document);

        Assert.IsFalse(firstTimeline.HasSectionNode);
        Assert.AreSame(secondNode, secondTimeline.NodeWrapper);
        Assert.AreEqual(2000U, secondTimeline.SectionDuration);
    }

    [TestMethod]
    public void SameTypeNodeDataHasIndependentPropertySelections()
    {
        var firstData = new scnAndNode();
        var secondData = new scnAndNode();
        var first = NodePropertiesSelectionService.ForData(firstData);
        var second = NodePropertiesSelectionService.ForData(secondData);

        Assert.AreSame(first, NodePropertiesSelectionService.ForData(firstData));
        Assert.AreNotSame(first, second);
        Assert.AreNotSame(first.SelectedProperties, second.SelectedProperties);
    }

    private static scnAndNodeWrapper CreateNode(RedDocumentViewModel document) =>
        new(new scnAndNode { NodeId = new scnNodeId { Id = 1 } }) { DocumentViewModel = document };
}
