using System;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;

public class DynamicQuestViewModel<T> : BaseQuestViewModel<T> where T : DynamicGraphNodeDefinition
{
    public DynamicQuestViewModel(DynamicBaseClass node) : base(new DynamicGraphNodeDefinition())
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

public class DynamicQuestViewModel : DynamicQuestViewModel<DynamicGraphNodeDefinition>
{
    public DynamicQuestViewModel(DynamicBaseClass node) : base(node)
    {
    }
}