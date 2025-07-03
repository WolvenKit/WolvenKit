using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;


public class SceneOutputConnectorViewModel : OutputConnectorViewModel
{
    public scnOutputSocket? Data { get; set; }
    public ushort NameId { get; }
    public ushort Ordinal { get; }

    public SceneOutputConnectorViewModel(string name, string title, uint ownerId, ushort nameId, ushort ordinal, scnOutputSocket? data = null) : base(name, title, ownerId)
    {
        Data = data;
        NameId = nameId;
        Ordinal = ordinal;
    }
}