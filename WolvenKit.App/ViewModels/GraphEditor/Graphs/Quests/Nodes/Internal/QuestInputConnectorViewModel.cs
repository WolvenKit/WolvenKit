using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;

public class QuestInputConnectorViewModel : InputConnectorViewModel
{
    public questSocketDefinition Data { get; }

    public QuestInputConnectorViewModel(string name, string title, uint ownerId, questSocketDefinition data) : base(name, title, ownerId)
    {
        Data = data;
    }
}