using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.GraphEditor;

public abstract class BaseGraphService : IGraphService
{
    protected readonly GraphData _data;
    protected readonly ILoggerService _log;
    protected readonly IGraphViewCache _cache;
    protected readonly ILayoutService _layout;

    protected BaseGraphService(GraphData data, ILayoutService layout, IGraphViewCache cache, ILoggerService log)
    {
        _data = data;
        _layout = layout;
        _cache = cache;
        _log = log;
    }

    protected ObservableCollection<NodeViewModel> Nodes => _data.Nodes;
    protected ObservableCollection<ConnectionViewModel> Connections => _data.Connections;
    protected GraphContext Context => _data.Context;

    public abstract void GenerateGraph();

    public abstract void CreateNode(Type type, Point point);
    public abstract void RemoveNode(NodeViewModel node);

    public abstract void Connect(OutputConnectorViewModel source, InputConnectorViewModel target);
    public abstract void Disconnect(BaseConnectorViewModel connector);

    public abstract List<Type> GetNodeTypes();
    public abstract string CleanTypeName(string typeName);
    public virtual bool LoadLayout() => _cache.Load();

    public virtual void SaveLayout() => _cache.Save();

    public virtual void CenterOnSelectedNodes(IList<object> nodes) => _layout.CenterOnSelectedNodes(nodes);

    public virtual void ArrangeNodes(double xOffset, double yOffset) =>
        _layout.ArrangeNodes(xOffset, yOffset);

    public virtual ChunkViewModel? GetNodesChunkViewModel()
    {
        if (Context.DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            _log.Debug("No document model.");
            return null;
        }

        return dataViewModel.Chunks[0].GetPropertyFromPath("graph.nodes");
    }
}