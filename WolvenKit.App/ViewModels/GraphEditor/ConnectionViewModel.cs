namespace WolvenKit.App.ViewModels.GraphEditor;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class ConnectionViewModel : ObservableObject
{
    [ObservableProperty] private bool _isSelected;

    public ConnectionViewModel(OutputConnectorViewModel source, InputConnectorViewModel target)
    {
        Source = source;
        Target = target;

        Source.IsConnected = true;
        Target.IsConnected = true;
    }

    public OutputConnectorViewModel Source { get; }
    public InputConnectorViewModel Target { get; }
}