using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.GraphEditor;

internal class NodeTemplateSelector : DataTemplateSelector
{
    public DataTemplate Default { get; set; }
    public DataTemplate SceneStartNode { get; set; }
    public DataTemplate SceneEndNode { get; set; }

    public DataTemplate QuestInputNode { get; set; }
    public DataTemplate QuestOutputNode { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (item is scnStartNodeWrapper)
        {
            return SceneStartNode;
        }

        if (item is scnEndNodeWrapper)
        {
            return SceneEndNode;
        }

        if (item is questInputNodeDefinition)
        {
            return QuestInputNode;
        }

        if (item is questOutputNodeDefinition)
        {
            return QuestOutputNode;
        }

        return Default;
    }
}