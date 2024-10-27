using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Activator = System.Activator;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests;

public class QuestGraphService(
    GraphData data,
    questQuestPhaseResource resource,
    QuestGraphFactory factory,
    ILoggerService log) : BaseGraphService(data, new LayoutService(data), new IdGraphCache(data), log)
{
    private static List<Type>? s_questNodeTypes;
    private ushort _currentQuestNodeId;

    private graphGraphDefinition Graph
    {
        get
        {
            resource.Graph ??= new CHandle<graphGraphDefinition>(new questGraphDefinition());
            return resource.Graph.Chunk!;
        }
    }

    public override List<Type> GetNodeTypes() =>
        s_questNodeTypes ??= AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(graphGraphNodeDefinition).IsAssignableFrom(x) && !x.IsAbstract)
            .ToList();

    private BaseQuestViewModel WrapNode(graphGraphNodeDefinition node, bool isNew)
    {
        var view = factory.CreateView(node, Context, resource, this);
        view.GenerateSockets();
        return view;
    }

    public override void CreateNode(Type type, Point point)
    {
        _log.Debug($"Creating Node: ${type}");
        var instance = InternalCreateQuestNode(type);
        var wrappedInstance = WrapNode(instance, true);
        wrappedInstance.Location = point;

        Graph.Nodes.Add(new CHandle<graphGraphNodeDefinition>(instance));
        if (GetNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        _log.Debug($"Created Node: ${wrappedInstance}");
        Nodes.Add(wrappedInstance);
    }

    public override void RemoveNode(NodeViewModel node)
    {
        if (node is not BaseQuestViewModel questNode)
        {
            return;
        }

        foreach (var inputConnectorViewModel in questNode.Input)
        {
            Disconnect(inputConnectorViewModel);
        }

        foreach (var outputConnectorViewModel in questNode.Output)
        {
            Disconnect(outputConnectorViewModel);
        }

        for (var i = Graph.Nodes.Count - 1; i >= 0; i--)
        {
            if (!ReferenceEquals(Graph.Nodes[i].Chunk, questNode.Data))
            {
                continue;
            }

            Graph.Nodes.RemoveAt(i);

            if (GetNodesChunkViewModel() is { } nodeViews)
            {
                nodeViews.RecalculateProperties();
            }
        }

        Nodes.Remove(questNode);
    }

    public override void Connect(OutputConnectorViewModel source, InputConnectorViewModel target)
    {
        if (source is not QuestOutputConnectorViewModel questSource ||
            target is not QuestInputConnectorViewModel questTarget)
        {
            _log.Debug("Source is not QuestOutputConnectorViewModel or target is not the other");
            return;
        }

        var graphGraphConnectionDefinition = new graphGraphConnectionDefinition
        {
            Source = new CWeakHandle<graphGraphSocketDefinition>(questSource.Data),
            Destination = new CWeakHandle<graphGraphSocketDefinition>(questTarget.Data)
        };
        var handle = new CHandle<graphGraphConnectionDefinition>(graphGraphConnectionDefinition);

        questSource.Data.Connections.Add(handle);
        questTarget.Data.Connections.Add(handle);

        Connections.Add(new QuestConnectionViewModel(questSource, questTarget, graphGraphConnectionDefinition));
        RefreshCVM([questSource.Data, questTarget.Data]);
    }

    public override void Disconnect(BaseConnectorViewModel connector)
    {
        switch (connector)
        {
            case QuestOutputConnectorViewModel outputConnector:
            {
                for (var i = Connections.Count - 1; i >= 0; i--)
                {
                    if (Connections[i].Source == outputConnector)
                    {
                        RemoveConnection((QuestConnectionViewModel)Connections[i]);
                    }
                }

                break;
            }
            case QuestInputConnectorViewModel inputConnector:
            {
                for (var i = Connections.Count - 1; i >= 0; i--)
                {
                    if (Connections[i].Target == inputConnector)
                    {
                        RemoveConnection((QuestConnectionViewModel)Connections[i]);
                    }
                }

                break;
            }
        }
    }

    private void AddConnection(QuestOutputConnectorViewModel source, QuestInputConnectorViewModel destination)
    {
        var connection = new graphGraphConnectionDefinition
        {
            Source = new CWeakHandle<graphGraphSocketDefinition>(source.Data),
            Destination = new CWeakHandle<graphGraphSocketDefinition>(destination.Data)
        };

        source.Data.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));
        destination.Data.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));

        Connections.Add(new QuestConnectionViewModel(source, destination, connection));
    }

    private void RemoveConnection(QuestConnectionViewModel questConnection)
    {
        var questSource = (QuestOutputConnectorViewModel)questConnection.Source;
        var questDestination = (QuestInputConnectorViewModel)questConnection.Target;

        for (var i = questSource.Data.Connections.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(questSource.Data.Connections[i].Chunk, questConnection.ConnectionDefinition))
            {
                questSource.Data.Connections.RemoveAt(i);
                questSource.IsConnected = questSource.Data.Connections.Count > 0;
            }
        }

        for (var i = questDestination.Data.Connections.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(questDestination.Data.Connections[i].Chunk, questConnection.ConnectionDefinition))
            {
                questDestination.Data.Connections.RemoveAt(i);
                questDestination.IsConnected = questDestination.Data.Connections.Count > 0;
            }
        }

        Connections.Remove(questConnection);
    }

    public override void GenerateGraph()
    {
        _log.Debug("Generating graph....");
        var socketNodeLookup = new Dictionary<graphGraphSocketDefinition, QuestInputConnectorViewModel>();

        var nodeCache = new Dictionary<uint, BaseQuestViewModel>();
        foreach (var nodeHandle in Graph.Nodes)
        {
            ArgumentNullException.ThrowIfNull(nodeHandle.Chunk);

            var node = nodeHandle.Chunk;

            if (node is questNodeDefinition nodeDefinition)
            {
                _currentQuestNodeId = Math.Max(_currentQuestNodeId, nodeDefinition.Id);
            }

            var nvm = WrapNode(node, false);

            nodeCache.TryAdd(nvm.UniqueId, nvm);
            Nodes.Add(nvm);

            foreach (var inputConnector in nvm.Input)
            {
                var questInputConnector = (QuestInputConnectorViewModel)inputConnector;
                socketNodeLookup.TryAdd(questInputConnector.Data, questInputConnector);
            }
        }

        foreach (var node in Nodes)
        {
            var questNode = (BaseQuestViewModel)node;

            foreach (var outputConnector in questNode.Output)
            {
                var questOutputConnector = (QuestOutputConnectorViewModel)outputConnector;

                foreach (var connectionHandle in questOutputConnector.Data.Connections)
                {
                    var connection = connectionHandle.Chunk!;

                    Connections.Add(new QuestConnectionViewModel(questOutputConnector,
                        socketNodeLookup[connection.Destination.Chunk!], connection));
                }
            }
        }
    }

    private graphGraphNodeDefinition InternalCreateQuestNode(Type type)
    {
        var instance = Activator.CreateInstance(type);
        if (instance is not graphGraphNodeDefinition questNode)
        {
            throw new Exception();
        }

        if (instance is questNodeDefinition nodeDefinition)
        {
            nodeDefinition.Id = ++_currentQuestNodeId;
        }

        return questNode;
    }

    public void RecalculateSockets(INeedsRecalculation nodeViewModel)
    {
        if (nodeViewModel is not BaseQuestViewModel phaseNode)
        {
            return;
        }

        var inputCache = new Dictionary<string, List<QuestOutputConnectorViewModel>>();
        foreach (var inputConnectorViewModel in phaseNode.Input)
        {
            var questInputConnectorViewModel = (QuestInputConnectorViewModel)inputConnectorViewModel;

            if (questInputConnectorViewModel.Data.Connections.Count > 0)
            {
                inputCache.TryAdd(questInputConnectorViewModel.Name, new List<QuestOutputConnectorViewModel>());
                foreach (var connection in questInputConnectorViewModel.Data.Connections)
                {
                    var source = connection.Chunk!.Source.Chunk!;

                    for (var i = source.Connections.Count - 1; i >= 0; i--)
                    {
                        if (ReferenceEquals(source.Connections[i].Chunk, connection.Chunk))
                        {
                            source.Connections.RemoveAt(i);
                        }
                    }

                    for (var i = Connections.Count - 1; i >= 0; i--)
                    {
                        var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)Connections[i].Source;

                        if (ReferenceEquals(questOutputConnectorViewModel.Data, source) &&
                            ReferenceEquals(Connections[i].Target, questInputConnectorViewModel))
                        {
                            questOutputConnectorViewModel.IsConnected =
                                questOutputConnectorViewModel.Data.Connections.Count > 0;

                            inputCache[questInputConnectorViewModel.Name].Add(questOutputConnectorViewModel);
                            Connections.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        var outputCache = new Dictionary<string, List<QuestInputConnectorViewModel>>();
        foreach (var outputConnectorViewModel in phaseNode.Output)
        {
            var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)outputConnectorViewModel;

            if (questOutputConnectorViewModel.Data.Connections.Count > 0)
            {
                outputCache.TryAdd(questOutputConnectorViewModel.Name, new List<QuestInputConnectorViewModel>());
                foreach (var connection in questOutputConnectorViewModel.Data.Connections)
                {
                    var destination = connection.Chunk!.Destination.Chunk!;

                    for (var i = destination.Connections.Count - 1; i >= 0; i--)
                    {
                        if (ReferenceEquals(destination.Connections[i].Chunk, connection.Chunk))
                        {
                            destination.Connections.RemoveAt(i);
                        }
                    }

                    for (var i = Connections.Count - 1; i >= 0; i--)
                    {
                        var questInputConnectorViewModel = (QuestInputConnectorViewModel)Connections[i].Target;

                        if (ReferenceEquals(Connections[i].Source, questOutputConnectorViewModel) &&
                            ReferenceEquals(questInputConnectorViewModel.Data, destination))
                        {
                            questInputConnectorViewModel.IsConnected =
                                questInputConnectorViewModel.Data.Connections.Count > 0;

                            outputCache[questOutputConnectorViewModel.Name].Add(questInputConnectorViewModel);
                            Connections.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        nodeViewModel.RecalculateSockets();

        foreach (var inputConnectorViewModel in phaseNode.Input)
        {
            var questInputConnectorViewModel = (QuestInputConnectorViewModel)inputConnectorViewModel;

            if (inputCache.TryGetValue(questInputConnectorViewModel.Name, out var sockets))
            {
                foreach (var questOutputConnectorViewModel in sockets)
                {
                    AddConnection(questOutputConnectorViewModel, questInputConnectorViewModel);
                }
            }
        }

        foreach (var outputConnectorViewModel in phaseNode.Output)
        {
            var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)outputConnectorViewModel;

            if (outputCache.TryGetValue(questOutputConnectorViewModel.Name, out var sockets))
            {
                foreach (var questInputConnectorViewModel in sockets)
                {
                    AddConnection(questOutputConnectorViewModel, questInputConnectorViewModel);
                }
            }
        }
    }

    private void RefreshCVM(questSocketDefinition[] sockets)
    {
        if (GetNodesChunkViewModel() is { } nodes)
        {
            var list = new List<ChunkViewModel>();
            foreach (var property in nodes.GetAllProperties())
            {
                foreach (var socket in sockets)
                {
                    if (ReferenceEquals(property.Data, socket.Connections))
                    {
                        list.Add(property.Parent!);
                    }
                }
            }

            foreach (var model in list)
            {
                model.RecalculateProperties();
            }
        }
    }

    public override string CleanTypeName(string typeName)
    {
        if (typeName.StartsWith("quest"))
        {
            typeName = typeName[5..];
        }
        else if (typeName.StartsWith("scn"))
        {
            typeName = typeName[3..];
        }

        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14];
        }
        else if (typeName.EndsWith("Node"))
        {
            typeName = typeName[..^4];
        }

        return typeName;
    }
}