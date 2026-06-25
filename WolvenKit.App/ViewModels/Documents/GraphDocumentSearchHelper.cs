using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.RED4.Types;
using GraphNodeViewModel = WolvenKit.App.ViewModels.GraphEditor.NodeViewModel;

namespace WolvenKit.App.ViewModels.Documents;

public static class GraphDocumentSearchHelper
{
    internal static GraphDocumentSearchMatch? ApplyQuestPhaseSearch(
        RedGraph graph,
        string searchBoxText)
    {
        if (string.IsNullOrWhiteSpace(searchBoxText))
        {
            return null;
        }

        return FindFirstQuestPhaseGraphNodeDataMatch(graph, searchBoxText);
    }

    internal static GraphDocumentSearchMatch? ApplySceneSearch(
        RedGraph graph,
        string searchBoxText)
    {
        if (string.IsNullOrWhiteSpace(searchBoxText))
        {
            return null;
        }

        var match = FindFirstSceneGraphNodeDataMatch(graph, searchBoxText);
        if (match is not null)
        {
            SelectGraphNode(match.Value.Node);
        }

        return match;
    }

    public static void SelectGraphNode(GraphNodeViewModel targetNode)
    {
        if (targetNode.DocumentViewModel == null)
        {
            NodeSelectionService.Instance.SelectedNode = targetNode;
            return;
        }

        var graph = FindGraphContainingNode(targetNode.DocumentViewModel.TabItemViewModels, targetNode);

        graph?.Editor?.SelectedItems?.Clear();
        graph?.Editor?.SelectedItems?.Add(targetNode);
        NodeSelectionService.Instance.SelectedNode = targetNode;

        graph?.CenterOnSelectedNodes(new List<object> { targetNode });
    }

    private static GraphDocumentSearchMatch? FindFirstQuestPhaseGraphNodeDataMatch(
        RedGraph graph,
        string searchBoxText)
    {
        var visited = new HashSet<RedGraph>();
        var pendingGraphs = new Queue<RedGraph>();
        pendingGraphs.Enqueue(graph);

        while (pendingGraphs.TryDequeue(out var currentGraph))
        {
            if (!visited.Add(currentGraph))
            {
                continue;
            }

            foreach (var node in currentGraph.Nodes)
            {
                if (NodeDataMatchesSearch(node, searchBoxText, skipEmbeddedGraphPayload: true))
                {
                    return new GraphDocumentSearchMatch(node);
                }
            }

            foreach (var provider in currentGraph.Nodes.OfType<IGraphProvider>())
            {
                if (!CanSearchNestedQuestPhaseGraph(provider))
                {
                    continue;
                }

                if (provider.Graph is { } subGraph)
                {
                    pendingGraphs.Enqueue(subGraph);
                }
            }
        }

        return null;
    }

    private static GraphDocumentSearchMatch? FindFirstSceneGraphNodeDataMatch(
        RedGraph graph,
        string searchBoxText)
    {
        foreach (var node in graph.Nodes)
        {
            if (node.Data is not scnSceneGraphNode)
            {
                continue;
            }

            if (NodeDataMatchesSearch(node, searchBoxText))
            {
                return new GraphDocumentSearchMatch(node);
            }
        }

        return null;
    }

    private static bool CanSearchNestedQuestPhaseGraph(IGraphProvider provider) =>
        provider is GraphNodeViewModel { Data: questPhaseNodeDefinition { PhaseResource.IsSet: false } };

    private static bool NodeDataMatchesSearch(
        GraphNodeViewModel node,
        string searchBoxText,
        bool skipEmbeddedGraphPayload = false)
    {
        if (node.Data.GetType().Name.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) ||
            node.UniqueId.ToString().Contains(searchBoxText, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        try
        {
            return node.Data
                .GetEnumerator(node.Data.GetType().Name)
                .Any(entry =>
                    !ShouldSkipGraphSearchProperty(node.Data, entry.propPath, skipEmbeddedGraphPayload) &&
                    RedPropertyMatchesSearch(entry.propPath, entry.value, searchBoxText));
        }
        catch
        {
            return false;
        }
    }

    private static bool ShouldSkipGraphSearchProperty(
        IRedType nodeData,
        string propPath,
        bool skipEmbeddedGraphPayload) =>
        skipEmbeddedGraphPayload &&
        nodeData is questPhaseNodeDefinition &&
        propPath.Contains(nameof(questPhaseNodeDefinition.PhaseGraph), StringComparison.OrdinalIgnoreCase);

    private static bool RedPropertyMatchesSearch(string propPath, IRedType value, string searchBoxText)
    {
        if (propPath.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) ||
            value.GetType().Name.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (StringHelper.StringifyRedType(value).Contains(searchBoxText, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (value is IRedString redString &&
            redString.GetString()?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true)
        {
            return true;
        }

        if (value is IRedRef redRef &&
            redRef.DepotPath.GetResolvedText()?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true)
        {
            return true;
        }

        if (value is IRedHashHolder hashHolder &&
            hashHolder.GetRedHash().ToString().Contains(searchBoxText, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        return value.ToString()?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true;
    }

    private static RedGraph? FindGraphContainingNode(
        IEnumerable<RedDocumentTabViewModel> tabs,
        GraphNodeViewModel targetNode)
    {
        foreach (var tab in tabs)
        {
            var graph = tab switch
            {
                QuestPhaseGraphViewModel questPhase => FindGraphContainingNode(questPhase.MainGraph, targetNode, []),
                SceneGraphViewModel scene => FindGraphContainingNode(scene.MainGraph, targetNode, []),
                _ => null
            };

            if (graph is not null)
            {
                return graph;
            }
        }

        return null;
    }

    private static RedGraph? FindGraphContainingNode(
        RedGraph graph,
        GraphNodeViewModel targetNode,
        HashSet<RedGraph> visited)
    {
        if (!visited.Add(graph))
        {
            return null;
        }

        if (graph.Nodes.Contains(targetNode))
        {
            return graph;
        }

        foreach (var provider in graph.Nodes.OfType<IGraphProvider>())
        {
            if (provider.Graph is not { } subGraph)
            {
                continue;
            }

            var nestedMatch = FindGraphContainingNode(subGraph, targetNode, visited);
            if (nestedMatch is not null)
            {
                return nestedMatch;
            }
        }

        return null;
    }
}

internal readonly record struct GraphDocumentSearchMatch(GraphNodeViewModel Node);
