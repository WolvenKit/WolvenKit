using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Behavior;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor;

public partial class RedGraph
{
    public static RedGraph GenerateBehaviorGraph(string title, AIbehaviorResource behaviorResource, RedDocumentViewModel doc)
    {
        var graph = new RedGraph(title, behaviorResource)
        {
            DocumentViewModel = doc,
            StateParents = ".behavior"
        };

        var nodeCache = new Dictionary<AIbehaviorTreeNodeDefinition, BehaviorNodeViewModel>(ReferenceEqualityComparer.Instance);
        var traversedNodes = new HashSet<AIbehaviorTreeNodeDefinition>(ReferenceEqualityComparer.Instance);
        var nextId = 1u;

        var rootNode = GetHandleValue(behaviorResource.Root);
        if (rootNode != null)
        {
            Traverse(rootNode, "root", true);
        }

        foreach (var node in graph.Nodes)
        {
            node.IsInitialLoad = false;
        }

        return graph;

        BehaviorNodeViewModel Traverse(AIbehaviorTreeNodeDefinition node, string path, bool isRoot = false)
        {
            if (!nodeCache.TryGetValue(node, out var nodeViewModel))
            {
                nodeViewModel = new BehaviorNodeViewModel(node, nextId++, path, isRoot)
                {
                    DocumentViewModel = doc
                };
                nodeCache.Add(node, nodeViewModel);
                graph.Nodes.Add(nodeViewModel);
            }

            if (!traversedNodes.Add(node))
            {
                return nodeViewModel;
            }

            foreach (var child in GetStructuralChildren(node, path))
            {
                if (child.Node == null)
                {
                    continue;
                }

                var childViewModel = Traverse(child.Node, child.Path);
                var output = nodeViewModel.AddChildOutput(child.Name, child.Title);
                var input = childViewModel.Input.First();
                graph.Connections.Add(new ConnectionViewModel(output, input));
            }

            return nodeViewModel;
        }
    }

    private static IEnumerable<BehaviorChildSlot> GetStructuralChildren(AIbehaviorTreeNodeDefinition node, string path)
    {
        switch (node)
        {
            case AIbehaviorFSMTreeNodeDefinition fsmNode:
                for (var i = 0; i < fsmNode.States.Count; i++)
                {
                    yield return new BehaviorChildSlot(
                        $"State{i}",
                        $"State {i}",
                        GetHandleValue(fsmNode.States[i]),
                        $"{path}.states[{i}]");
                }

                var initialState = GetHandleValue(fsmNode.InitialState);
                if (initialState != null && fsmNode.States.All(x => !ReferenceEquals(GetHandleValue(x), initialState)))
                {
                    yield return new BehaviorChildSlot("Initial", "Initial", initialState, $"{path}.initialState");
                }

                break;

            case AIbehaviorFSMStateDefinition stateNode:
                yield return new BehaviorChildSlot("Behavior", "Behavior", GetHandleValue(stateNode.BehaviorRoot), $"{path}.behaviorRoot");
                break;

            case AIbehaviorCompositeTreeNodeDefinition compositeNode:
                for (var i = 0; i < compositeNode.Children.Count; i++)
                {
                    yield return new BehaviorChildSlot(
                        $"Child{i}",
                        $"Child {i}",
                        GetHandleValue(compositeNode.Children[i]),
                        $"{path}.children[{i}]");
                }

                break;

            case AIbehaviorDecoratorNodeDefinition decoratorNode:
                yield return new BehaviorChildSlot("Child", "Child", GetHandleValue(decoratorNode.Child), $"{path}.child");
                break;
        }
    }

    private static T? GetHandleValue<T>(CHandle<T>? handle) where T : RedBaseClass => handle?.GetValue() as T;

    private readonly record struct BehaviorChildSlot(string Name, string Title, AIbehaviorTreeNodeDefinition? Node, string Path);
}
