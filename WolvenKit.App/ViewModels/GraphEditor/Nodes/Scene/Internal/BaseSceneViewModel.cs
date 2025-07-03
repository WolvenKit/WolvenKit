using System;
using System.Windows.Media;
using WolvenKit.RED4.Types;
using System.Collections.Generic;
using WolvenKit.App.Services;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using System.Reflection;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

public abstract class BaseSceneViewModel : NodeViewModel, IRefreshableDetails
{
    private readonly scnSceneResource? _sceneResource;
    
    public override uint UniqueId => ((scnSceneGraphNode)Data).NodeId.Id;

    public Dictionary<ushort, string> InputSocketNames = new();
    public Dictionary<ushort, string> OutputSocketNames = new();

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

    /// <summary>
    /// Whether this node is a player node (has refLocalPlayer set to true)
    /// </summary>
    public bool IsPlayerNode { get; protected set; }

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
        
        // Detect if this is a player node
        DetectPlayerNode(scnSceneGraphNode);
        
        Title = Data.GetType().Name[3..^4]; // ID is now shown separately via NodeIdText
        Background = GraphNodeColors.GetBackgroundForSceneNodeType(scnSceneGraphNode);
        ContentBackground = GraphNodeColors.GetContentBackgroundForSceneNodeType(scnSceneGraphNode);
        
        // Check if this is a simple node type that should have uniform colors
        UpdateBackgroundsBasedOnNodeType(scnSceneGraphNode);
    }

    protected override void UpdateTitle()
    {
        // Format scene node titles properly  
        Title = Data.GetType().Name[3..^4]; // ID is now shown separately via NodeIdText
        
        // Notable point information is now shown in the visual indicator bar, not in the title
        
        // Notify UI that notable point properties may have changed
        OnPropertyChanged(nameof(HasNotablePoint));
        OnPropertyChanged(nameof(NotablePointName));
        
        // Also notify about player node properties in case they changed
        OnPropertyChanged(nameof(IsPlayerNode));
    }

    /// <summary>
    /// Detect if this node is a player node (has refLocalPlayer set to true anywhere in its structure)
    /// </summary>
    private void DetectPlayerNode(scnSceneGraphNode scnSceneGraphNode)
    {
        try
        {
            // Choice nodes are always player-involved by nature, so we don't need to show the banner
            if (scnSceneGraphNode is scnChoiceNode)
            {
                IsPlayerNode = false;
                return;
            }
            
            // Check for player node patterns recursively
            IsPlayerNode = CheckForPlayerNodeRecursively(scnSceneGraphNode);
        }
        catch (System.Exception)
        {
            // If detection fails, assume it's not a player node
            IsPlayerNode = false;
        }
    }

    /// <summary>
    /// Recursively check an object for player node indicators
    /// </summary>
    protected bool CheckForPlayerNodeRecursively(object obj)
    {
        if (obj == null) return false;

        // Check questUniversalRef for refLocalPlayer
        if (obj is questUniversalRef universalRef && universalRef.RefLocalPlayer == true)
        {
            return true;
        }

        // Check gameEntityReference for player references
        if (obj is gameEntityReference entityRef)
        {
            // Check if reference contains player identifier
            var resolvedText = entityRef.Reference.GetResolvedText()!;
            if (!string.IsNullOrEmpty(resolvedText) && 
                (resolvedText.Contains("player", StringComparison.OrdinalIgnoreCase) ||
                 resolvedText == "#player"))
            {
                return true;
            }
            
            // Check dynamic entity unique name for player
            var dynamicEntityName = entityRef.DynamicEntityUniqueName.GetResolvedText();
            if (!string.IsNullOrEmpty(dynamicEntityName) &&
                dynamicEntityName.Contains("player", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        // Check various quest node types that have specific player flags
        if (obj is questNodeDefinition questNode)
        {
            return CheckQuestNodeForPlayerFlags(questNode);
        }

        // For IRedBaseHandle, check the contained value
        if (obj is IRedBaseHandle handle)
        {
            var handleValue = handle.GetValue();
            if (handleValue != null)
            {
                return CheckForPlayerNodeRecursively(handleValue);
            }
        }

        // For collections, check each item
        if (obj is System.Collections.IEnumerable enumerable and not string)
        {
            foreach (var item in enumerable)
            {
                if (item != null)
                {
                    if (CheckForPlayerNodeRecursively(item))
                        return true;
                }
            }
        }

        // For RedBaseClass objects, check all properties
        if (obj is RedBaseClass redObj)
        {
            return CheckRedBaseClassForPlayerFlags(redObj);
        }

        return false;
    }

    /// <summary>
    /// Check quest node definitions for player-related flags
    /// </summary>
    private bool CheckQuestNodeForPlayerFlags(questNodeDefinition questNode)
    {
        // Check common quest node types that have player-specific properties
        switch (questNode)
        {
            case questTeleportPuppetNodeDefinition teleportNode:
                if (teleportNode.EntityReference?.Chunk?.RefLocalPlayer == true)
                    return true;
                break;
                
            case questCharacterManagerNodeDefinition charManagerNode:
                // Check specific properties instead of full recursion to avoid stack overflow
                if (CheckSpecificPropertiesForPlayer(charManagerNode))
                    return true;
                break;
                
            case questSceneManagerNodeDefinition sceneManagerNode:
                // Check specific properties instead of full recursion to avoid stack overflow
                if (CheckSpecificPropertiesForPlayer(sceneManagerNode))
                    return true;
                break;
        }

        // Check all properties of the quest node recursively (but avoid circular references)
        return CheckRedBaseClassForPlayerFlags(questNode);
    }

    /// <summary>
    /// Check specific properties for player flags without full recursion to avoid stack overflow
    /// </summary>
    private bool CheckSpecificPropertiesForPlayer(RedBaseClass obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        
        foreach (var prop in properties)
        {
            try
            {
                // Skip properties that might cause circular references
                if (prop.Name == "Chunk" || prop.Name == "Parent") continue;
                
                var value = prop.GetValue(obj);
                if (value != null)
                {
                    // Check for direct player-related boolean properties
                    if (prop.Name.Contains("Player", System.StringComparison.OrdinalIgnoreCase) ||
                        prop.Name.Contains("refLocalPlayer", System.StringComparison.OrdinalIgnoreCase))
                    {
                        if (value is CBool boolValue && boolValue == true)
                        {
                            return true;
                        }
                    }
                    
                    // Check direct questUniversalRef properties for refLocalPlayer
                    if (value is questUniversalRef universalRef && universalRef.RefLocalPlayer == true)
                    {
                        return true;
                    }
                    
                    // Check gameEntityReference for player references
                    if (value is gameEntityReference entityRef)
                    {
                        var resolvedText = entityRef.Reference.GetResolvedText()!;
                        if (!string.IsNullOrEmpty(resolvedText) && 
                            (resolvedText.Contains("player", StringComparison.OrdinalIgnoreCase) ||
                             resolvedText == "#player"))
                        {
                            return true;
                        }
                        
                        var dynamicEntityName = entityRef.DynamicEntityUniqueName.GetResolvedText();
                        if (!string.IsNullOrEmpty(dynamicEntityName) &&
                            dynamicEntityName.Contains("player", StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                    
                    // Check handles that contain questUniversalRef or gameEntityReference
                    if (value is IRedBaseHandle handle)
                    {
                        var handleValue = handle.GetValue();
                        if (handleValue is questUniversalRef handleUniversalRef && handleUniversalRef.RefLocalPlayer == true)
                        {
                            return true;
                        }
                        if (handleValue is gameEntityReference handleEntityRef)
                        {
                            var handleResolvedText = handleEntityRef.Reference.GetResolvedText()!;
                            if (!string.IsNullOrEmpty(handleResolvedText) && 
                                (handleResolvedText.Contains("player", StringComparison.OrdinalIgnoreCase) ||
                                 handleResolvedText == "#player"))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                // Skip properties that cause exceptions
                continue;
            }
        }
        
        return false;
    }

    /// <summary>
    /// Check RedBaseClass properties for player flags
    /// </summary>
    private bool CheckRedBaseClassForPlayerFlags(RedBaseClass obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        
        foreach (var prop in properties)
        {
            try
            {
                // Skip properties that might cause issues
                if (prop.Name == "Chunk" || prop.Name == "Parent") continue;
                
                var value = prop.GetValue(obj);
                if (value != null)
                {
                    // Check for specific player-related properties
                    if (prop.Name.Contains("Player", System.StringComparison.OrdinalIgnoreCase) ||
                        prop.Name.Contains("refLocalPlayer", System.StringComparison.OrdinalIgnoreCase))
                    {
                        if (value is CBool boolValue && boolValue == true)
                        {
                            return true;
                        }
                    }
                    
                    // Recursively check the property value
                    if (CheckForPlayerNodeRecursively(value))
                        return true;
                }
            }
            catch (System.Exception)
            {
                // Skip properties that cause exceptions
                continue;
            }
        }
        
        return false;
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
        foreach (var (socketNameId, socketName) in InputSocketNames)
        {
            var input = new SceneInputConnectorViewModel(socketName, socketName, UniqueId, socketNameId, 0);
            input.Subtitle = $"({socketNameId},0)";
            Input.Add(input);
        }

        Output.Clear();
        foreach (var (socketNameId, socketName) in OutputSocketNames)
        {
            var sockets = _castedData.OutputSockets
                .Where(x => x.Stamp.Name == socketNameId)
                .OrderBy(x => (ushort)x.Stamp.Ordinal)
                .ToList();

            if (sockets.Count > 0)
            {
                foreach (var socket in sockets)
                {
                    // Only add ordinal suffix if there are multiple sockets with the same name
                    var baseName = sockets.Count > 1 ? $"{socketName}_{socket.Stamp.Ordinal}" : socketName;
                    var nameAndTitle = $"({socket.Stamp.Name},{socket.Stamp.Ordinal})";
                    var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socket.Stamp.Name, socket.Stamp.Ordinal, socket);
                    output.Subtitle = baseName;
                    Output.Add(output);
                    // Explicit subscription to guarantee property panel sync
                    SubscribeToSocketDestinations(output);
                }
            }
            else
            {
                // Virtual socket - no ordinal suffix needed for static sockets
                var nameAndTitle = $"({socketNameId},0)";
                var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socketNameId, 0);
                output.Subtitle = socketName;
                Output.Add(output);
                // Explicit subscription to guarantee property panel sync (even for virtual sockets)
                SubscribeToSocketDestinations(output);
            }
        }
    }
}