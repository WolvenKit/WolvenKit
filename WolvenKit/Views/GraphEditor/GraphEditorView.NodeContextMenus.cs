using System.Collections.Generic;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Behavior;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.GraphEditor;

public partial class GraphEditorView
{
    private void BuildBehaviorNodeContextMenu(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        menu.StartSection();
        if (node is BehaviorNodeViewModel behaviorNode && Source.CanAddBehaviorChild(behaviorNode))
        {
            var addChildMenu = menu.AddCategory("Add Child");
            AddBehaviorNodeCreationItems(addChildMenu, type =>
            {
                var nodeId = Source.AddBehaviorChild(behaviorNode, type.Type, type.RedTypeTemplateSelectionOption);
                SelectNodeById(nodeId);
            });
        }

        menu.StartSection();
        var toggleSlotsText = node.ShowUnusedSockets ? "Hide Structural Slots" : "Show Structural Slots";
        var toggleSlotsDescription = node.ShowUnusedSockets
            ? "Hides empty structural child slots without removing them"
            : "Shows all structural child slots, including empty ones";
        menu.AddAction(toggleSlotsText, "Eye", "WolvenKitYellow", () =>
        {
            node.ShowUnusedSockets = !node.ShowUnusedSockets;
            Source.GraphStateSave();
        }, toggleSlotsDescription);
    }

    private void BuildMultiNodeContextMenu(GraphContextMenuBuilder menu, IReadOnlyList<NodeViewModel> nodes)
    {
        menu.StartSection();
        menu.AddAction(
            "Destroy Nodes",
            "CloseBoxOutline",
            "WolvenKitRed",
            () => Source.RemoveNodes(nodes),
            "Permanently removes the selected nodes and their connections without leaving deletion markers");

        if (Source.GraphType == RedGraphType.Quest)
        {
            menu.AddAction(
                "Convert to Phase",
                "FolderOutline",
                "WolvenKitRed",
                () => Source.CreatePhaseFromSelection(nodes),
                "Moves the selected nodes into a new inline phase and rewires external connections through it");
        }
    }

    private void BuildSingleNodeContextMenu(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        AddNodeStructureActions(menu, node);
        AddNodeDisplayActions(menu, node);
        AddNodeClipboardActions(menu, node);
        AddNodeLifecycleActions(menu, node);
    }

    private void AddNodeStructureActions(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        menu.StartSection();

        if (node is IDynamicInputNode dynamicInputNode)
        {
            menu.AddAction(
                "Add Input",
                "PlusCircle",
                () => dynamicInputNode.AddInput(),
                "Adds another input socket to this node");
        }

        if (node is IDynamicOutputNode dynamicOutputNode)
        {
            var addLabel = dynamicOutputNode is scnSectionNodeWrapper ? "Add Event Socket" : "Add Output";
            var addDescription = dynamicOutputNode is scnSectionNodeWrapper
                ? "Adds another event output socket to this section"
                : "Adds another output socket to this node";
            menu.AddAction(addLabel, "PlusCircle", () => dynamicOutputNode.AddOutput(), addDescription);
        }

        if (node is scnChoiceNodeWrapper choice)
        {
            menu.AddAction(
                "Add Choice",
                "PlusCircle",
                () => choice.AddChoice(),
                "Adds another choice output to this node");
        }

        if (node is questSwitchNodeDefinitionWrapper switchNode)
        {
            menu.AddAction(
                "Add Case",
                "PlusCircle",
                () => switchNode.AddCondition(),
                "Adds another conditional output case to this switch node");
        }

        if (node is IGraphProvider graphProvider)
        {
            menu.AddAction(
                "Recalculate sockets",
                "Play",
                "WolvenKitGreen",
                () => Source.RecalculateSockets(graphProvider),
                "Rebuilds sockets from the linked phase or scene and reconnects matching socket names");
        }

        if (node is questPhaseNodeDefinitionWrapper phaseNode)
        {
            menu.AddAction(
                "Unpack phase",
                "PackageUp",
                "WolvenKitRed",
                () => Source.UnpackPhase(phaseNode),
                "Moves the nodes from this inline phase into the current graph and rewires its connections");
        }
    }

    private void AddNodeDisplayActions(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        menu.StartSection();

        var toggleSocketsText = node.ShowUnusedSockets ? "Hide Unused Sockets" : "Show Unused Sockets";
        var toggleSocketsDescription = node.ShowUnusedSockets
            ? "Hides unconnected sockets in the graph view without removing them"
            : "Shows all sockets in the graph view, including unconnected ones";
        menu.AddAction(toggleSocketsText, "Eye", "WolvenKitYellow", () =>
        {
            node.ShowUnusedSockets = !node.ShowUnusedSockets;
            Source.GraphStateSave();
        }, toggleSocketsDescription);

        if (node is questSceneNodeDefinitionWrapper sceneNode)
        {
            menu.AddAction(
                "Add Scene To Project",
                "ArrowLeftCircle",
                "WolvenKitYellow",
                sceneNode.AddSceneToProject,
                "Adds the scene file referenced by this node to the active project");
        }
    }

    private void AddNodeClipboardActions(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        menu.StartSection();
        menu.AddAction(
            "Duplicate Node",
            "ContentDuplicate",
            "WolvenKitYellow",
            () => Source.DuplicateNode(node),
            "Creates a disconnected copy of this node in the current graph with new IDs");
        menu.AddAction(
            "Copy Node",
            "ContentCopy",
            "WolvenKitYellow",
            () => GraphClipboardManager.CopyNode(node, Source.GraphType),
            "Copies this node to the clipboard for pasting into a compatible graph");

        var templateData = GetTemplateData(node);
        if (templateData != null && RedTypeTemplateService.IsTypeTemplatable(templateData.GetType()))
        {
            menu.AddAction(
                "Create Template from Node",
                "ContentSaveOutline",
                "WolvenKitPurple",
                async () => await _appViewModel.SetActiveDialog(
                    new CreateTemplateFromChunkDialogViewModel(templateData, _redTypeTemplateService, _appViewModel)),
                "Saves this node's data as a reusable template");
        }
    }

    private void AddNodeLifecycleActions(GraphContextMenuBuilder menu, NodeViewModel node)
    {
        menu.StartSection();

        if (Source.GraphType == RedGraphType.Scene && node is BaseSceneViewModel sceneNode)
        {
            AddSceneNodeLifecycleActions(menu, sceneNode);
            return;
        }

        if (Source.GraphType == RedGraphType.Quest && node is BaseQuestViewModel questNode)
        {
            AddQuestNodeLifecycleActions(menu, questNode);
            return;
        }

        AddDestroyNodeAction(menu, node);
    }

    private void AddSceneNodeLifecycleActions(GraphContextMenuBuilder menu, BaseSceneViewModel node)
    {
        menu.AddAction(
            "Detach Node",
            "LinkOff",
            "WolvenKitYellow",
            () => DetachNode(node),
            "Removes all connections to and from this node without removing the node");

        if (node is scnStartNodeWrapper or scnEndNodeWrapper)
        {
            return;
        }

        if (node is scnDeletionMarkerNodeWrapper)
        {
            AddDestroyDeletionMarkerAction(menu, node);
            return;
        }

        if (ShouldSceneNodeUseDeletionMarker(node))
        {
            menu.AddAction(
                "Delete Node",
                "Delete",
                "WolvenKitRed",
                () => Source.ReplaceNodeWithDeletionMarker(node),
                "Replaces this node with a deletion marker while preserving its ID and compatible connections");
        }

        AddDestroyNodeAction(menu, node);
    }

    private void AddQuestNodeLifecycleActions(GraphContextMenuBuilder menu, BaseQuestViewModel node)
    {
        menu.AddAction(
            "Detach Node",
            "LinkOff",
            "WolvenKitYellow",
            () => DetachQuestNode(node),
            "Removes all connections to and from this node without removing the node");

        if (node is questStartNodeDefinitionWrapper or questEndNodeDefinitionWrapper)
        {
            return;
        }

        if (node is questDeletionMarkerNodeDefinitionWrapper)
        {
            AddDestroyDeletionMarkerAction(menu, node);
            return;
        }

        var shouldUseDeletionMarker = node.Data is questSignalStoppingNodeDefinition ||
                                      node.Data.GetType() == typeof(questSwitchNodeDefinition) ||
                                      node.Data.GetType() == typeof(questFlowControlNodeDefinition);
        if (shouldUseDeletionMarker)
        {
            menu.AddAction(
                "Delete Node",
                "Delete",
                "WolvenKitRed",
                () => Source.ReplaceNodeWithQuestDeletionMarker(node),
                "Replaces this node with a deletion marker while preserving its ID and compatible connections");
        }

        AddDestroyNodeAction(menu, node);
    }

    private void AddDestroyNodeAction(GraphContextMenuBuilder menu, NodeViewModel node) =>
        menu.AddAction(
            "Destroy Node",
            "CloseBoxOutline",
            "WolvenKitRed",
            () => Source.RemoveNode(node),
            "Permanently removes this node and its connections without leaving a deletion marker");

    private void AddDestroyDeletionMarkerAction(GraphContextMenuBuilder menu, NodeViewModel node) =>
        menu.AddAction(
            "Destroy Deletion Marker",
            "CloseBoxOutline",
            "WolvenKitRed",
            () => Source.RemoveNode(node),
            "Permanently removes this deletion marker from the graph");

}
