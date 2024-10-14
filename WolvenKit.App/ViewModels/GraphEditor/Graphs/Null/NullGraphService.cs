using System;
using System.Collections.Generic;
using System.Windows;

namespace WolvenKit.App.ViewModels.GraphEditor.Null;

public class NullGraphService : IGraphService
{
    public List<Type> GetNodeTypes() => [];

    public void CreateNode(Type type, Point point)
    {
        // Do nothing
    }

    public void RemoveNode(NodeViewModel node)
    {
        // Do nothing
    }

    public void Connect(OutputConnectorViewModel source, InputConnectorViewModel target)
    {
        // Do nothing
    }

    public void Disconnect(BaseConnectorViewModel connector)
    {
        // Do nothing
    }

    public void GenerateGraph()
    {
        // Do nothing
    }

    public string CleanTypeName(string typeName) => typeName;
    public bool LoadLayout() => true;

    public void SaveLayout() { }

    public void CenterOnSelectedNodes(IList<object> nodes) { }

    public void ArrangeNodes(double xOffset, double yOffset) { }
}