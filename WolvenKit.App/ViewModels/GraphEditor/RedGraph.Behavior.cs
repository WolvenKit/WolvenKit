using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Behavior;
using WolvenKit.RED4.Types;
using WpfPoint = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor;

public partial class RedGraph
{
    private static List<Type>? s_behaviorNodeTypes;

    public static RedGraph GenerateBehaviorGraph(string title, AIbehaviorResource behaviorResource, RedDocumentViewModel doc)
    {
        var graph = new RedGraph(title, behaviorResource)
        {
            DocumentViewModel = doc,
            StateParents = ".behavior"
        };

        PopulateBehaviorGraph(graph, behaviorResource, doc);

        return graph;
    }

    private static void PopulateBehaviorGraph(
        RedGraph graph,
        AIbehaviorResource behaviorResource,
        RedDocumentViewModel? doc,
        IReadOnlyDictionary<AIbehaviorTreeNodeDefinition, WpfPoint>? locations = null)
    {
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

        BehaviorNodeViewModel Traverse(AIbehaviorTreeNodeDefinition node, string path, bool isRoot = false)
        {
            if (!nodeCache.TryGetValue(node, out var nodeViewModel))
            {
                nodeViewModel = new BehaviorNodeViewModel(node, nextId++, path, isRoot)
                {
                    DocumentViewModel = doc
                };

                if (locations != null && locations.TryGetValue(node, out var location))
                {
                    nodeViewModel.Location = location;
                }

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

    public List<Type> GetBehaviorNodeTypes()
    {
        s_behaviorNodeTypes ??= typeof(AIbehaviorTreeNodeDefinition).Assembly
            .GetTypes()
            .Where(type => typeof(AIbehaviorTreeNodeDefinition).IsAssignableFrom(type) &&
                           !type.IsAbstract &&
                           !type.Name.Contains("FSM", StringComparison.Ordinal))
            .OrderBy(type => type.Name)
            .ToList();

        return s_behaviorNodeTypes;
    }

    public List<Type> GetBehaviorWrapperNodeTypes() =>
        GetBehaviorNodeTypes()
            .Where(CanBehaviorTypeContainChild)
            .ToList();

    public bool CanEditBehaviorChildConnection(ConnectionViewModel connection) =>
        TryGetBehaviorChildSlot(connection, out _);

    public bool CanCreateBehaviorRoot() =>
        _data is AIbehaviorResource behaviorResource && GetHandleValue(behaviorResource.Root) == null;

    public bool CanAddBehaviorChild(BehaviorNodeViewModel parent)
    {
        return parent.Data switch
        {
            AIbehaviorCompositeTreeNodeDefinition composite => CanAddBehaviorCompositeChild(composite),
            AIbehaviorDecoratorNodeDefinition decorator => GetHandleValue(decorator.Child) == null,
            _ => false
        };
    }

    public uint CreateBehaviorRoot(Type type, System.Windows.Point location)
    {
        if (_data is not AIbehaviorResource behaviorResource)
        {
            throw new InvalidOperationException("Cannot create behavior root on non-behavior graph.");
        }

        if (GetHandleValue(behaviorResource.Root) != null)
        {
            throw new InvalidOperationException("Behavior resource already has a root node.");
        }

        var behaviorNode = InternalCreateBehaviorNode(type);
        behaviorResource.Root = new CHandle<AIbehaviorTreeNodeDefinition>(behaviorNode);

        var nodeViewModel = CreateBehaviorNodeViewModel(behaviorNode, "root", true);
        nodeViewModel.Location = location;
        Nodes.Add(nodeViewModel);

        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);

        return nodeViewModel.UniqueId;
    }

    public uint AddBehaviorChild(BehaviorNodeViewModel parent, Type type)
    {
        if (GraphType != RedGraphType.Behavior)
        {
            throw new InvalidOperationException("Cannot add behavior child on non-behavior graph.");
        }

        var behaviorNode = InternalCreateBehaviorNode(type);
        string slotName;
        string slotTitle;
        string nodePath;
        var siblingIndex = 0;

        switch (parent.Data)
        {
            case AIbehaviorCompositeTreeNodeDefinition compositeNode:
                if (!CanAddBehaviorCompositeChild(compositeNode))
                {
                    throw new InvalidOperationException($"{parent.Title} cannot contain more child nodes.");
                }

                siblingIndex = compositeNode.Children.Count;
                compositeNode.Children.Add(new CHandle<AIbehaviorTreeNodeDefinition>(behaviorNode));
                slotName = $"Child{siblingIndex}";
                slotTitle = $"Child {siblingIndex}";
                nodePath = $"{parent.NodePath}.children[{siblingIndex}]";
                break;

            case AIbehaviorDecoratorNodeDefinition decoratorNode:
                if (GetHandleValue(decoratorNode.Child) != null)
                {
                    throw new InvalidOperationException("Behavior decorator already has a child node.");
                }

                decoratorNode.Child = new CHandle<AIbehaviorTreeNodeDefinition>(behaviorNode);
                slotName = "Child";
                slotTitle = "Child";
                nodePath = $"{parent.NodePath}.child";
                break;

            default:
                throw new InvalidOperationException($"{parent.Title} cannot contain behavior child nodes.");
        }

        var childViewModel = CreateBehaviorNodeViewModel(behaviorNode, nodePath, false);
        childViewModel.Location = GetBehaviorChildLocation(parent, siblingIndex);
        Nodes.Add(childViewModel);

        var output = parent.AddChildOutput(slotName, slotTitle);
        var input = childViewModel.Input.First();
        Connections.Add(new ConnectionViewModel(output, input));

        parent.RefreshDetails();
        parent.UpdateSocketVisibility();
        childViewModel.UpdateSocketVisibility();

        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);

        return childViewModel.UniqueId;
    }

    public bool CanMoveBehaviorChild(ConnectionViewModel connection, int delta)
    {
        if (!TryGetBehaviorChildSlot(connection, out var slot) ||
            slot.Parent.Data is not AIbehaviorCompositeTreeNodeDefinition compositeNode ||
            slot.ChildIndex < 0)
        {
            return false;
        }

        var newIndex = slot.ChildIndex + delta;
        return newIndex >= 0 && newIndex < compositeNode.Children.Count;
    }

    public uint MoveBehaviorChild(ConnectionViewModel connection, int delta)
    {
        if (!TryGetBehaviorChildSlot(connection, out var slot) ||
            slot.Parent.Data is not AIbehaviorCompositeTreeNodeDefinition compositeNode ||
            slot.ChildIndex < 0)
        {
            throw new InvalidOperationException("Selected behavior connection is not a movable child slot.");
        }

        var newIndex = slot.ChildIndex + delta;
        if (newIndex < 0 || newIndex >= compositeNode.Children.Count)
        {
            throw new InvalidOperationException("Cannot move behavior child outside its parent child list.");
        }

        var movedNode = GetHandleValue(compositeNode.Children[slot.ChildIndex]);
        var swappedNode = GetHandleValue(compositeNode.Children[newIndex]);
        var swappedViewModel = swappedNode == null ? null : FindBehaviorNode(swappedNode);

        var locationOverrides = new Dictionary<AIbehaviorTreeNodeDefinition, WpfPoint>(ReferenceEqualityComparer.Instance);
        if (movedNode != null && swappedViewModel != null)
        {
            locationOverrides[movedNode] = swappedViewModel.Location;
        }

        if (swappedNode != null)
        {
            locationOverrides[swappedNode] = slot.Child.Location;
        }

        var handle = compositeNode.Children[slot.ChildIndex];
        compositeNode.Children[slot.ChildIndex] = compositeNode.Children[newIndex];
        compositeNode.Children[newIndex] = handle;

        return FinishBehaviorStructureEdit(movedNode, locationOverrides);
    }

    public uint ReplaceBehaviorChild(ConnectionViewModel connection, Type type)
    {
        if (!TryGetBehaviorChildSlot(connection, out var slot))
        {
            throw new InvalidOperationException("Selected behavior connection is not a child slot.");
        }

        var behaviorNode = InternalCreateBehaviorNode(type);
        SetBehaviorChildSlot(slot, behaviorNode);

        var locationOverrides = new Dictionary<AIbehaviorTreeNodeDefinition, WpfPoint>(ReferenceEqualityComparer.Instance)
        {
            [behaviorNode] = slot.Child.Location
        };

        return FinishBehaviorStructureEdit(behaviorNode, locationOverrides);
    }

    public uint WrapBehaviorChild(ConnectionViewModel connection, Type type)
    {
        if (!TryGetBehaviorChildSlot(connection, out var slot))
        {
            throw new InvalidOperationException("Selected behavior connection is not a child slot.");
        }

        if (!GetBehaviorWrapperNodeTypes().Contains(type))
        {
            throw new InvalidOperationException($"{type.Name} cannot wrap behavior child nodes.");
        }

        var wrapperNode = InternalCreateBehaviorNode(type);
        if (!TryAttachBehaviorChild(wrapperNode, (AIbehaviorTreeNodeDefinition)slot.Child.Data))
        {
            throw new InvalidOperationException($"{type.Name} cannot contain behavior child nodes.");
        }

        SetBehaviorChildSlot(slot, wrapperNode);

        var locationOverrides = new Dictionary<AIbehaviorTreeNodeDefinition, WpfPoint>(ReferenceEqualityComparer.Instance)
        {
            [wrapperNode] = slot.Child.Location,
            [(AIbehaviorTreeNodeDefinition)slot.Child.Data] = new(slot.Child.Location.X + 420, slot.Child.Location.Y)
        };

        return FinishBehaviorStructureEdit(wrapperNode, locationOverrides);
    }

    public uint DeleteBehaviorChild(ConnectionViewModel connection)
    {
        if (!TryGetBehaviorChildSlot(connection, out var slot))
        {
            throw new InvalidOperationException("Selected behavior connection is not a child slot.");
        }

        var parentNode = (AIbehaviorTreeNodeDefinition)slot.Parent.Data;
        switch (parentNode)
        {
            case AIbehaviorCompositeTreeNodeDefinition compositeNode when slot.ChildIndex >= 0:
                compositeNode.Children.RemoveAt(slot.ChildIndex);
                break;

            case AIbehaviorDecoratorNodeDefinition decoratorNode:
                decoratorNode.Child = new CHandle<AIbehaviorTreeNodeDefinition>();
                break;

            default:
                throw new InvalidOperationException("Selected behavior connection is not a child slot.");
        }

        return FinishBehaviorStructureEdit(parentNode);
    }

    private static bool CanAddBehaviorCompositeChild(AIbehaviorCompositeTreeNodeDefinition compositeNode) =>
        compositeNode is not AIbehaviorIfElseNodeDefinition || compositeNode.Children.Count < 2;

    private static bool CanBehaviorTypeContainChild(Type type) =>
        typeof(AIbehaviorCompositeTreeNodeDefinition).IsAssignableFrom(type) ||
        typeof(AIbehaviorDecoratorNodeDefinition).IsAssignableFrom(type);

    private uint FinishBehaviorStructureEdit(
        AIbehaviorTreeNodeDefinition? selectedNode,
        IReadOnlyDictionary<AIbehaviorTreeNodeDefinition, WpfPoint>? locationOverrides = null)
    {
        RebuildBehaviorGraph(locationOverrides);
        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);

        return selectedNode == null ? 0 : GetBehaviorNodeId(selectedNode);
    }

    private void RebuildBehaviorGraph(IReadOnlyDictionary<AIbehaviorTreeNodeDefinition, WpfPoint>? locationOverrides = null)
    {
        if (_data is not AIbehaviorResource behaviorResource)
        {
            throw new InvalidOperationException("Cannot rebuild behavior graph on non-behavior graph.");
        }

        var locations = new Dictionary<AIbehaviorTreeNodeDefinition, WpfPoint>(ReferenceEqualityComparer.Instance);
        foreach (var node in Nodes.OfType<BehaviorNodeViewModel>())
        {
            locations[(AIbehaviorTreeNodeDefinition)node.Data] = node.Location;
        }

        if (locationOverrides != null)
        {
            foreach (var (node, location) in locationOverrides)
            {
                locations[node] = location;
            }
        }

        Connections.Clear();

        foreach (var node in Nodes.ToList())
        {
            node.Dispose();
        }
        Nodes.Clear();

        PopulateBehaviorGraph(this, behaviorResource, DocumentViewModel, locations);
    }

    private bool TryGetBehaviorChildSlot(ConnectionViewModel connection, out BehaviorConnectionSlot slot)
    {
        slot = default;

        if (GraphType != RedGraphType.Behavior ||
            Nodes.FirstOrDefault(x => x.UniqueId == connection.Source.OwnerId) is not BehaviorNodeViewModel parent ||
            Nodes.FirstOrDefault(x => x.UniqueId == connection.Target.OwnerId) is not BehaviorNodeViewModel child)
        {
            return false;
        }

        switch (parent.Data)
        {
            case AIbehaviorCompositeTreeNodeDefinition compositeNode:
                if (!TryGetCompositeChildIndex(connection.Source.Name, out var childIndex) ||
                    childIndex < 0 ||
                    childIndex >= compositeNode.Children.Count)
                {
                    return false;
                }

                slot = new BehaviorConnectionSlot(parent, child, childIndex);
                return true;

            case AIbehaviorDecoratorNodeDefinition when connection.Source.Name == "Child":
                slot = new BehaviorConnectionSlot(parent, child, -1);
                return true;

            default:
                return false;
        }
    }

    private static bool TryGetCompositeChildIndex(string sourceName, out int childIndex)
    {
        childIndex = -1;

        return sourceName.StartsWith("Child", StringComparison.Ordinal) &&
               int.TryParse(sourceName["Child".Length..], out childIndex);
    }

    private static void SetBehaviorChildSlot(BehaviorConnectionSlot slot, AIbehaviorTreeNodeDefinition childNode)
    {
        switch (slot.Parent.Data)
        {
            case AIbehaviorCompositeTreeNodeDefinition compositeNode when slot.ChildIndex >= 0:
                compositeNode.Children[slot.ChildIndex] = new CHandle<AIbehaviorTreeNodeDefinition>(childNode);
                break;

            case AIbehaviorDecoratorNodeDefinition decoratorNode:
                decoratorNode.Child = new CHandle<AIbehaviorTreeNodeDefinition>(childNode);
                break;

            default:
                throw new InvalidOperationException("Selected behavior connection is not a child slot.");
        }
    }

    private static bool TryAttachBehaviorChild(AIbehaviorTreeNodeDefinition parentNode, AIbehaviorTreeNodeDefinition childNode)
    {
        switch (parentNode)
        {
            case AIbehaviorCompositeTreeNodeDefinition compositeNode:
                if (!CanAddBehaviorCompositeChild(compositeNode))
                {
                    return false;
                }

                compositeNode.Children.Add(new CHandle<AIbehaviorTreeNodeDefinition>(childNode));
                return true;

            case AIbehaviorDecoratorNodeDefinition decoratorNode when GetHandleValue(decoratorNode.Child) == null:
                decoratorNode.Child = new CHandle<AIbehaviorTreeNodeDefinition>(childNode);
                return true;

            default:
                return false;
        }
    }

    private BehaviorNodeViewModel CreateBehaviorNodeViewModel(AIbehaviorTreeNodeDefinition behaviorNode, string nodePath, bool isRoot)
    {
        var nodeViewModel = new BehaviorNodeViewModel(behaviorNode, GetNextBehaviorNodeId(), nodePath, isRoot)
        {
            DocumentViewModel = DocumentViewModel,
            IsInitialLoad = false
        };

        return nodeViewModel;
    }

    private uint GetNextBehaviorNodeId()
    {
        var maxId = 0u;
        foreach (var node in Nodes.OfType<BehaviorNodeViewModel>())
        {
            maxId = Math.Max(maxId, node.UniqueId);
        }

        return maxId + 1;
    }

    private AIbehaviorTreeNodeDefinition InternalCreateBehaviorNode(Type type)
    {
        if (!GetBehaviorNodeTypes().Contains(type))
        {
            throw new InvalidOperationException($"{type.Name} is not a supported behavior node type.");
        }

        if (System.Activator.CreateInstance(type) is not AIbehaviorTreeNodeDefinition behaviorNode)
        {
            throw new InvalidOperationException($"Failed to create behavior node of type {type.Name}.");
        }

        return behaviorNode;
    }

    private static System.Windows.Point GetBehaviorChildLocation(BehaviorNodeViewModel parent, int siblingIndex) =>
        new(parent.Location.X + 420, parent.Location.Y + (siblingIndex * 170));

    private BehaviorNodeViewModel? FindBehaviorNode(AIbehaviorTreeNodeDefinition node) =>
        Nodes.OfType<BehaviorNodeViewModel>().FirstOrDefault(x => ReferenceEquals(x.Data, node));

    private uint GetBehaviorNodeId(AIbehaviorTreeNodeDefinition node) =>
        FindBehaviorNode(node)?.UniqueId ?? 0;

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

    private readonly record struct BehaviorConnectionSlot(BehaviorNodeViewModel Parent, BehaviorNodeViewModel Child, int ChildIndex);
}
