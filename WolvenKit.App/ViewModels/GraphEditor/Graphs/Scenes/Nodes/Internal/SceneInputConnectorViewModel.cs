namespace WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes.Internal;

public class SceneInputConnectorViewModel : InputConnectorViewModel
{
    public ushort Ordinal { get; }

    public SceneInputConnectorViewModel(string name, string title, uint ownerId, ushort ordinal) : base(name, title, ownerId)
    {
        Ordinal = ordinal;
    }
}