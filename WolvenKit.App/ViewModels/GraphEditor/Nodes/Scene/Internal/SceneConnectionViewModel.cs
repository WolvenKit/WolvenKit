using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public partial class SceneConnectionViewModel : ConnectionViewModel
{
    [ObservableProperty]
    private int _pathType = 2; // Default to "live" path (2), dead-end is 1
    
    public SceneConnectionViewModel(OutputConnectorViewModel source, InputConnectorViewModel target) : base(source, target)
    {
    }
}