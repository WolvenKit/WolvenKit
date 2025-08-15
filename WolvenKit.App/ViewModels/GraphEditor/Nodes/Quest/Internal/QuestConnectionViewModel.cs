using WolvenKit.RED4.Types;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;


public partial class QuestConnectionViewModel : ConnectionViewModel
{
    [ObservableProperty]
    private int _pathType = 2; // Default to "live" path (2), dead-end is 1
    
    public graphGraphConnectionDefinition ConnectionDefinition { get; }

    public QuestConnectionViewModel(OutputConnectorViewModel source, InputConnectorViewModel target, graphGraphConnectionDefinition connectionDefinition) : base(source, target)
    {
        ConnectionDefinition = connectionDefinition;
    }
}