using WolvenKit.App.ViewModels.GraphEditor.Nodes;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class InputConnectorViewModel : BaseConnectorViewModel
{
    public InputConnectorViewModel(string name, string title, uint ownerId) : base(name, title, ownerId)
    {
    }
}