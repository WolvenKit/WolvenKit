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
        string searchBoxText,
        GraphDocumentSearchState searchState)
    {
        return ApplyGraphSearch(
            searchBoxText,
            searchState,
            () => FindQuestPhaseGraphNodeDataMatches(graph, searchBoxText),
            selectGraphNode: false);
    }

    internal static GraphDocumentSearchMatch? ApplySceneSearch(
        RedGraph graph,
        string searchBoxText,
        GraphDocumentSearchState searchState)
    {
        return ApplyGraphSearch(
            searchBoxText,
            searchState,
            () => FindSceneGraphNodeDataMatches(graph, searchBoxText),
            selectGraphNode: true);
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

    private static GraphDocumentSearchMatch? ApplyGraphSearch(
        string searchBoxText,
        GraphDocumentSearchState searchState,
        Func<IReadOnlyList<GraphDocumentSearchMatch>> findMatches,
        bool selectGraphNode)
    {
        if (string.IsNullOrWhiteSpace(searchBoxText))
        {
            searchState.Reset();
            return null;
        }

        var match = searchState.GetNextMatch(searchBoxText, findMatches);
        if (match is null)
        {
            return null;
        }

        if (selectGraphNode)
        {
            SelectGraphNode(match.Value.Node);
        }

        return match;
    }

    private static IReadOnlyList<GraphDocumentSearchMatch> FindQuestPhaseGraphNodeDataMatches(
        RedGraph graph,
        string searchBoxText)
    {
        var matches = new List<GraphDocumentSearchMatch>();
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
                    matches.Add(new GraphDocumentSearchMatch(node));
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

        return matches;
    }

    private static IReadOnlyList<GraphDocumentSearchMatch> FindSceneGraphNodeDataMatches(
        RedGraph graph,
        string searchBoxText)
    {
        var matches = new List<GraphDocumentSearchMatch>();

        foreach (var node in graph.Nodes)
        {
            if (node.Data is not scnSceneGraphNode)
            {
                continue;
            }

            if (NodeDataMatchesSearch(node, searchBoxText))
            {
                matches.Add(new GraphDocumentSearchMatch(node));
            }
        }

        return matches;
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

internal sealed class GraphDocumentSearchState
{
    private string _searchText = "";
    private IReadOnlyList<GraphDocumentSearchMatch> _matches = [];
    private int _currentIndex = -1;

    public GraphDocumentSearchMatch? GetNextMatch(
        string searchText,
        Func<IReadOnlyList<GraphDocumentSearchMatch>> findMatches)
    {
        if (!string.Equals(_searchText, searchText, StringComparison.Ordinal) || _matches.Count == 0)
        {
            _searchText = searchText;
            _matches = findMatches();
            _currentIndex = -1;
        }

        if (_matches.Count == 0)
        {
            return null;
        }

        _currentIndex = (_currentIndex + 1) % _matches.Count;
        return _matches[_currentIndex];
    }

    public void Reset()
    {
        _searchText = "";
        _matches = [];
        _currentIndex = -1;
    }
}
