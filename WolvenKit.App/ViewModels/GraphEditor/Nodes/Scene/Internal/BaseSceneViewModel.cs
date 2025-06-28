using System.Windows.Media;
using WolvenKit.RED4.Types;
using System.Collections.Generic;
using WolvenKit.App.Services;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public abstract class BaseSceneViewModel : NodeViewModel, IRefreshableDetails
{
    private readonly scnSceneResource? _sceneResource;
    
    public override uint UniqueId => ((scnSceneGraphNode)Data).NodeId.Id;

    public Brush Background { get; protected set; }
    public Brush ContentBackground { get; protected set; }

    /// <summary>
    /// The notable point associated with this node, if any
    /// </summary>
    public scnNotablePoint? NotablePoint { get; private set; }

    /// <summary>
    /// Whether this node has a notable point marker
    /// </summary>
    public bool HasNotablePoint => NotablePoint != null;

    /// <summary>
    /// The notable point name for display
    /// </summary>
    public string NotablePointName => NotablePoint?.Name.GetResolvedText() ?? string.Empty;

    protected BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode, scnSceneResource? sceneResource = null) : base(scnSceneGraphNode)
    {
        _sceneResource = sceneResource;
        
        // Find and cache the notable point for this node
        if (_sceneResource != null)
        {
            NotablePoint = _sceneResource
                .NotablePoints
                .FirstOrDefault(x => x.NodeId.Id == scnSceneGraphNode.NodeId.Id);
        }
        
        Title = $"[{UniqueId}] {Data.GetType().Name[3..^4]}";
        Background = GraphNodeColors.GetBackgroundForSceneNodeType(scnSceneGraphNode);
        ContentBackground = GraphNodeColors.GetContentBackgroundForSceneNodeType(scnSceneGraphNode);
        
        // Check if this is a simple node type that should have uniform colors
        UpdateBackgroundsBasedOnNodeType(scnSceneGraphNode);
    }

    protected override void UpdateTitle()
    {
        // Format scene node titles properly
        Title = $"[{UniqueId}] {Data.GetType().Name[3..^4]}";
        
        // Notable point information is now shown in the visual indicator bar, not in the title
        
        // Notify UI that notable point properties may have changed
        OnPropertyChanged(nameof(HasNotablePoint));
        OnPropertyChanged(nameof(NotablePointName));
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

    /// <summary>
    /// Override RefreshFromData to avoid regenerating sockets unnecessarily
    /// Socket counts are unchanged when connections are made/removed
    /// </summary>
    public override void RefreshFromData()
    {
        UpdateTitle();
        OnPropertyChanged(nameof(Title));

        // DON'T regenerate sockets here – counts are unchanged
        TriggerPropertyChanged(nameof(Output));
        TriggerPropertyChanged(nameof(Input));
        OnPropertyChanged(nameof(Data));
        
        // Refresh details if implemented by derived class (this is important for property sync)
        if (this is IRefreshableDetails refreshable)
        {
            refreshable.RefreshDetails();
        }
    }
}

public abstract class BaseSceneViewModel<T> : BaseSceneViewModel where T : scnSceneGraphNode
{
    protected T _castedData => (T)Data;

    public BaseSceneViewModel(scnSceneGraphNode scnSceneGraphNode, scnSceneResource? sceneResource = null) : base(scnSceneGraphNode, sceneResource)
    {
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        
        // Add Cut input socket for all scene nodes by default (except End nodes)
        // Quest nodes handle their own sockets differently
        // Start nodes CAN receive Cut connections (1 found in data), End nodes cannot (0 found)
        if (Data is not scnEndNode)
        {
            Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));
        }

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }
}