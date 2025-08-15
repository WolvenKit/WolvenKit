namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public class SceneInputConnectorViewModel : InputConnectorViewModel
{
    public ushort NameId { get; set; }
    public ushort Ordinal { get; }

    public SceneInputConnectorViewModel(string name, string title, uint ownerId, ushort nameId = 0, ushort ordinal = 0) : base(name, title, ownerId)
    {
        NameId = nameId;
        Ordinal = ordinal;
    }
}