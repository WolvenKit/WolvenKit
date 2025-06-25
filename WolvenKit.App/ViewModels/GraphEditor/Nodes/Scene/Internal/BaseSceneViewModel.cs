using System.Windows.Media;
using WolvenKit.RED4.Types;
using System.Collections.Generic;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public abstract class BaseSceneViewModel : NodeViewModel, IRefreshableDetails
{
    public override uint UniqueId => ((scnSceneGraphNode)Data).NodeId.Id;

    public Brush Background { get; protected set; }
    public Brush ContentBackground { get; protected set; }

    protected BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        Title = $"[{UniqueId}] {Data.GetType().Name[3..^4]}";
        Background = GetBackgroundForNodeType(scnSceneGraphNode);
        ContentBackground = GetContentBackgroundForNodeType(scnSceneGraphNode);
        
        // Check if this is a simple node type that should have uniform colors
        UpdateBackgroundsBasedOnNodeType(scnSceneGraphNode);
    }

    protected override void UpdateTitle()
    {
        // Format scene node titles properly
        Title = $"[{UniqueId}] {Data.GetType().Name[3..^4]}";
    }

    /// <summary>
    /// Refresh the node's visual details without regenerating sockets
    /// Override in derived classes to update specific details
    /// </summary>
    public virtual void RefreshDetails()
    {
        // Create a new dictionary to trigger UI update (WPF needs reference change)
        var newDetails = new Dictionary<string, string>();
        
        // Set new dictionary
        Details = newDetails;
        
        // Base implementation just refreshes the title
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    protected void UpdateBackgroundsBasedOnDetails()
    {
        // If no details, use the same color for both header and content
        if (Details.Count == 0)
        {
            ContentBackground = Background;
        }
    }

    private void UpdateBackgroundsBasedOnNodeType(scnSceneGraphNode node)
    {
        // Simple logical/control nodes that should have uniform colors
        if (node is scnAndNode or scnXorNode or scnHubNode or 
            scnDeletionMarkerNode or scnCutControlNode or scnInterruptManagerNode)
        {
            ContentBackground = Background;
        }
    }

    private static Brush GetBackgroundForNodeType(scnSceneGraphNode node)
    {
        // Create a slight dark tint background based on node type
        return node switch
        {
            scnStartNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33228B22")), // Dark green tint
            scnEndNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B22222")), // Dark red tint
            scnChoiceNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332288B2")), // Dark blue tint
            scnQuestNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2B222")), // Dark yellow tint
            scnSectionNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B222B2")), // Dark purple tint
            scnRandomizerNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3322B2B2")), // Dark cyan tint
            scnHubNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2AA22")), // Dark orange tint
            scnAndNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AA22")), // Dark lime tint
            scnXorNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2255")), // Dark pink tint
            _ => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33444444")) // Default dark gray tint
        };
    }

    private static Brush GetContentBackgroundForNodeType(scnSceneGraphNode node)
    {
        // Create a very subtle tint background for content area (much lighter than header)
        return node switch
        {
            scnStartNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11228B22")), // Very subtle green tint
            scnEndNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B22222")), // Very subtle red tint
            scnChoiceNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#112288B2")), // Very subtle blue tint
            scnQuestNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2B222")), // Very subtle yellow tint
            scnSectionNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B222B2")), // Very subtle purple tint
            scnRandomizerNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1122B2B2")), // Very subtle cyan tint
            scnHubNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2AA22")), // Very subtle orange tint
            scnAndNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1155AA22")), // Very subtle lime tint
            scnXorNode => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA2255")), // Very subtle pink tint
            _ => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11444444")) // Very subtle default gray tint
        };
    }
}

public abstract class BaseSceneViewModel<T> : BaseSceneViewModel where T : scnSceneGraphNode
{
    protected T _castedData => (T)Data;

    public BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
    }

    internal override void GenerateSockets()
    {
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }
}