using System;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public class DynamicSceneViewModel<T> : BaseSceneViewModel<T> where T : DynamicSceneGraphNode
{
    public DynamicSceneViewModel(DynamicBaseClass node) : base(new DynamicSceneGraphNode())
    {
        Title = "DynamicNode";

        _castedData.ClassName = node.ClassName;
        foreach (var propertyName in node.GetDynamicPropertyNames())
        {
            var property = node.GetProperty(propertyName);
            ArgumentNullException.ThrowIfNull(property);

            _castedData.AddDynamicProperty(propertyName, property.GetType());
            _castedData.SetProperty(propertyName, property);
        }
    }
}

public class DynamicSceneViewModel : DynamicSceneViewModel<DynamicSceneGraphNode>
{
    public DynamicSceneViewModel(DynamicBaseClass node) : base(node)
    {
    }
}