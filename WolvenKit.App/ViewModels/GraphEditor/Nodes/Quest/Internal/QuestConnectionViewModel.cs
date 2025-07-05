using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;


public class QuestConnectionViewModel : ConnectionViewModel
{
    public graphGraphConnectionDefinition ConnectionDefinition { get; }

    public QuestConnectionViewModel(OutputConnectorViewModel source, InputConnectorViewModel target, graphGraphConnectionDefinition connectionDefinition) : base(source, target)
    {
        ConnectionDefinition = connectionDefinition;
    }
}