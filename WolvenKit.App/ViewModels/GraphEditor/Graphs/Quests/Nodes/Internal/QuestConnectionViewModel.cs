using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;


public class QuestConnectionViewModel : ConnectionViewModel
{
    public graphGraphConnectionDefinition ConnectionDefinition { get; }

    public QuestConnectionViewModel(OutputConnectorViewModel source, InputConnectorViewModel target, graphGraphConnectionDefinition connectionDefinition) : base(source, target)
    {
        ConnectionDefinition = connectionDefinition;
    }
}