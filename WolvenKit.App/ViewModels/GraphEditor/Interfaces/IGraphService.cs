using System;
using System.Collections.Generic;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.GraphEditor;

public interface IGraphService
{
    void GenerateGraph();
    void CreateNode(Type type, System.Windows.Point point);
    void RemoveNode(NodeViewModel node);
    void Connect(OutputConnectorViewModel source, InputConnectorViewModel target);
    void Disconnect(BaseConnectorViewModel connector);
    List<Type> GetNodeTypes();
    string CleanTypeName(string typeName);
    bool LoadLayout();
    void SaveLayout();
    void CenterOnSelectedNodes(IList<object> nodes);
    void ArrangeNodes(double xOffset, double yOffset);
}