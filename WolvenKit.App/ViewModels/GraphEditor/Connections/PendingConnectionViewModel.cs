namespace WolvenKit.App.ViewModels.GraphEditor;

public class PendingConnectionViewModel
{
    public BaseConnectorViewModel Source { get; set; } = default!;
    public object? Target { get; set; }
}