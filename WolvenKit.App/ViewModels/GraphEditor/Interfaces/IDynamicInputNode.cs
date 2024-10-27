using System.Collections.ObjectModel;

namespace WolvenKit.App.ViewModels.GraphEditor;

public interface IDynamicInputNode
{
    public ObservableCollection<InputConnectorViewModel> Input { get; }

    public BaseConnectorViewModel AddInput();
    public void RemoveInput();
}

public interface IDynamicOutputNode
{
    public ObservableCollection<OutputConnectorViewModel> Output { get; }

    public BaseConnectorViewModel AddOutput();
    public void RemoveOutput();
}