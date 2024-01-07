using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;

public class QuestOutputConnectorViewModel : OutputConnectorViewModel
{
    public questSocketDefinition Data { get; }

    public QuestOutputConnectorViewModel(string name, string title, uint ownerId, questSocketDefinition data) : base(name, title, ownerId)
    {
        Data = data;
    }
}