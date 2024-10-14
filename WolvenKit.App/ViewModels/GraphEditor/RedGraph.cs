using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using Nodify;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class RedGraph : IDisposable
{
    private readonly GraphData _data;
    private readonly IGraphService _graphService;
    private readonly ILoggerService _log;

    public RedGraph(
        GraphData data,
        IGraphService graphService,
        ILoggerService log)
    {
        _data = data;
        _graphService = graphService;
        _log = log;

        data.ConnectCommand = new RelayCommand(Connect);
        data.DisconnectCommand = new RelayCommand<BaseConnectorViewModel>(Disconnect);
        data.ItemsDragCompletedCommand = new RelayCommand(ItemsDragCompleted);

        GenerateGraph();
    }

    public RelayCommand? ConnectCommand => _data.ConnectCommand;
    public RelayCommand<BaseConnectorViewModel>? DisconnectCommand => _data.DisconnectCommand;
    public RelayCommand? ItemsDragCompletedCommand => _data.ItemsDragCompletedCommand;

    public string Title => _data.Title;

    public PendingConnectionViewModel PendingConnection => _data.PendingConnection;

    public GraphContext Context => _data.Context;

    public RedDocumentViewModel DocumentViewModel
    { // TODO ldlework - really needed?
        get => _data.Context.DocumentViewModel;
        set => _data.Context.DocumentViewModel = value;
    }
    public ObservableCollection<NodeViewModel> Nodes => _data.Nodes;
    public ObservableCollection<ConnectionViewModel> Connections => _data.Connections;

    public NodifyEditor? Editor
    {
        get => _data.Editor;
        set => _data.Editor = value;
    }

    public string StateParents
    {
        get => Context.StateParents;
        set => Context.StateParents = value;
    }

    public string CleanTypeName(string typeName) => _graphService.CleanTypeName(typeName);

    public void GenerateGraph() => _graphService.GenerateGraph();

    public void Connect()
    {
        if (PendingConnection.Target is IDynamicInputNode dynIn)
        {
            PendingConnection.Target = dynIn.AddInput();
        }

        if (PendingConnection.Target is IDynamicOutputNode dynOut)
        {
            PendingConnection.Target = dynOut.AddOutput();
        }

        if (PendingConnection is { Source: OutputConnectorViewModel output, Target: InputConnectorViewModel input })
        {
            _graphService.Connect(output, input);
        }
    }

    public void Disconnect(BaseConnectorViewModel? baseConnectorViewModel)
    {
        if (baseConnectorViewModel != null)
        {
            _graphService.Disconnect(baseConnectorViewModel);
        }
    }

    public List<Type> GetNodeTypes() => _graphService.GetNodeTypes();

    public void CreateNode(Type type, System.Windows.Point point) => _graphService.CreateNode(type, point);

    public void RemoveNode(NodeViewModel node, bool save = true)
    {
        if (!Nodes.Contains(node))
            return;

        _graphService.RemoveNode(node);

        if (save)
        {
            _graphService.SaveLayout();
        }
    }

    public void RemoveNodes(IList<object> nodes)
    {
        var removableNodes = nodes.OfType<NodeViewModel>().ToList();
        foreach (var node in removableNodes)
        {
            RemoveNode(node, false);
        }

        _graphService.SaveLayout();
    }

    public void CenterOnSelectedNodes(IList<object> nodes) => _graphService.CenterOnSelectedNodes(nodes);

    public void ArrangeNodes(double xOffset = 0, double yOffset = 0) => _graphService.ArrangeNodes(xOffset, yOffset);

    public bool GraphStateLoad() => _graphService.LoadLayout();

    public void GraphStateSave() => _graphService.SaveLayout();

    private void ItemsDragCompleted() => GraphStateSave();

    public virtual ChunkViewModel? GetNodesChunkViewModel()
    {
        if (Context.DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            // _log.Debug("No document model.");
            return null;
        }

        return dataViewModel.Chunks[0].GetPropertyFromPath("graph.nodes");
    }

    private bool _disposed = false;

    public void Dispose()
    {
        if (!_disposed)
            return;

        foreach (var node in Nodes)
        {
            (node as IDisposable)?.Dispose();
        }

        (_graphService as IDisposable)?.Dispose();

        _disposed = true;
    }
}