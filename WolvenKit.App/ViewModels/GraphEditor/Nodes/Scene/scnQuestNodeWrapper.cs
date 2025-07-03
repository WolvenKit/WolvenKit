using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using Splat;
using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnQuestNodeWrapper : BaseSceneViewModel<scnQuestNode>
{
    public scnQuestNodeWrapper(scnQuestNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode)
    {
        if (_castedData.QuestNode != null)
        {
            //_castedData.QuestNode.PropertyChanged += QuestNodeOnPropertyChanged;
        }

        // Override title and background to show the actual quest node type
        if (_castedData.QuestNode?.Chunk != null)
        {
            var questNodeType = NodeProperties.GetNameFromClass(_castedData.QuestNode.Chunk);
            Title = questNodeType; // ID is now shown separately via NodeIdText
            Background = GraphNodeColors.GetBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
            ContentBackground = GraphNodeColors.GetContentBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
        }
        else
        {
            Title = "Quest"; // ID is now shown separately via NodeIdText
        }

        // Get properties but exclude the redundant "Type" since it's already shown in the title
        var questNodeDetails = NodeProperties.GetPropertiesFor(_castedData.QuestNode?.Chunk, scnSceneResource);
        foreach (var kvp in questNodeDetails)
        {
            // Skip the "Type" entry as it's redundant with the title for scene quest nodes
            if (kvp.Key != "Type")
            {
                Details[kvp.Key] = kvp.Value;
            }
        }

        Title += NodeProperties.SetNameFromNotablePoints(scnSceneGraphNode.NodeId.Id, scnSceneResource);
    }

    internal override void GenerateSockets()
    {
        // Generate input sockets dynamically from the IsockMappings
        for (ushort i = 0; i < _castedData.IsockMappings.Count; i++)
        {
            var mappingName = _castedData.IsockMappings[i].GetResolvedText();
            if (string.IsNullOrEmpty(mappingName))
            {
                // Fallback for empty mappings
                mappingName = $"Input_{i}";
            }

            // The NameId for quest nodes is always 0, the ordinal 'i' is the index into the mapping array.
            var input = new SceneInputConnectorViewModel(mappingName, mappingName, UniqueId, 0, i);
            input.Subtitle = $"(0,{i})";
            Input.Add(input);
        }

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            string name;
            
            // Check if there's a mapping label for this output
            if (_castedData.OsockMappings.Count > i)
            {
                var mappingText = _castedData.OsockMappings[i].GetResolvedText();
                if (!string.IsNullOrEmpty(mappingText))
                {
                    // Use just the mapping label
                    name = mappingText;
                }
                else
                {
                    // Fallback if mapping is empty
                    name = _castedData.OutputSockets.Count == 1 ? "Out" : $"Out_{i}";
                }
            }
            else
            {
                // No mapping - use simple naming
                name = _castedData.OutputSockets.Count == 1 ? "Out" : $"Out_{i}";
            }

            var nameAndTitle = $"({socket.Stamp.Name},{socket.Stamp.Ordinal})";
            var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socket.Stamp.Name, socket.Stamp.Ordinal, socket);
            output.Subtitle = name;
            Output.Add(output);
        }
    }

    protected override void DataOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
    {
        base.DataOnPropertyChanging(sender, e);

        if (e.PropertyName == nameof(scnQuestNode.QuestNode))
        {
            if (_castedData.QuestNode != null)
            {
                //_castedData.QuestNode.PropertyChanged -= QuestNodeOnPropertyChanged;
            }
        }
    }

    protected override void DataOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        base.DataOnPropertyChanged(sender, e);

        if (e.PropertyName == nameof(scnQuestNode.QuestNode))
        {
            if (_castedData.QuestNode != null)
            {
                //_castedData.QuestNode.PropertyChanged += QuestNodeOnPropertyChanged;
            }
        }
    }

    private void QuestNodeOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (_castedData.QuestNode.Chunk == null || _castedData.QuestNode.Chunk.Id == (ushort)_castedData.NodeId.Id)
        {
            return;
        }

        _castedData.QuestNode.Chunk.Id = (ushort)_castedData.NodeId.Id;
        _castedData.QuestNode.Chunk.Sockets ??= new CArray<CHandle<graphGraphSocketDefinition>>();
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "Cancel", Type = Enums.questSocketType.CutDestination });
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input });
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output });
    }

    /// <summary>
    /// Override to handle quest node details properly for scene quest nodes
    /// </summary>
    public override void RefreshDetails()
    {
        var loggerService = Locator.Current.GetService<ILoggerService>();
        
        try
        {
            // Create a new Details dictionary to trigger UI updates
            var tempDetails = new Dictionary<string, string>();
            
            // Get the scene resource from our parent document if possible
            scnSceneResource? sceneResource = null;
            if (DocumentViewModel?.SelectedTabItemViewModel is SceneGraphViewModel combinedScene)
            {
                sceneResource = combinedScene.RDTViewModel.GetData() as scnSceneResource;
            }

            // Get details from the nested quest node
            if (_castedData.QuestNode?.Chunk != null)
            {
                var questNodeDetails = NodeProperties.GetPropertiesFor(_castedData.QuestNode.Chunk, sceneResource);
                foreach (var kvp in questNodeDetails)
                {
                    // Skip the "Type" entry as it's redundant with the title for scene quest nodes
                    if (kvp.Key != "Type")
                    {
                        tempDetails[kvp.Key] = kvp.Value;
                    }
                }
                
            }
            else
            {
                // For nodes without a quest node, we don't show type since it would just be generic "Quest"
                // The title already indicates it's a Quest node
            }
            
            // Set the new details dictionary to trigger UI update
            Details = tempDetails;
            
            // Also refresh the title
            UpdateTitle();
            OnPropertyChanged(nameof(Title));
            
            // Re-detect player node status in case the quest node changed
            if (_castedData.QuestNode?.Chunk != null)
            {
                DetectPlayerNodeFromQuestNode(_castedData.QuestNode.Chunk);
            }
        }
        catch (System.Exception ex)
        {
            loggerService?.Error($"Error refreshing scnQuestNode {UniqueId} details: {ex.Message}");
            Details = new Dictionary<string, string> { ["Error"] = "Failed to refresh details" };
        }
    }

    /// <summary>
    /// Override to update title properly for scene quest nodes
    /// </summary>
    protected override void UpdateTitle()
    {
        try
        {
            if (_castedData.QuestNode?.Chunk != null)
            {
                var questNodeType = NodeProperties.GetNameFromClass(_castedData.QuestNode.Chunk);
                Title = questNodeType; // ID is now shown separately via NodeIdText
            }
            else
            {
                Title = "Quest"; // ID is now shown separately via NodeIdText
            }

            // Notable point suffix is now handled by base class
        }
        catch (System.Exception ex)
        {
            var loggerService = Locator.Current.GetService<ILoggerService>();
            loggerService?.Error($"Error updating scnQuestNode {UniqueId} title: {ex.Message}");
        }
    }

    /// <summary>
    /// Re-detect player node status from the nested quest node
    /// </summary>
    private void DetectPlayerNodeFromQuestNode(questNodeDefinition questNode)
    {
        try
        {
            // Use the protected method from base class to check for player node indicators
            IsPlayerNode = CheckForPlayerNodeRecursively(questNode);
            
            // Notify UI of changes
            OnPropertyChanged(nameof(IsPlayerNode));
        }
        catch (System.Exception)
        {
            // If detection fails, assume it's not a player node
            IsPlayerNode = false;
            
            OnPropertyChanged(nameof(IsPlayerNode));
        }
    }

    /// <summary>
    /// Override RefreshFromData to avoid regenerating sockets unnecessarily
    /// </summary>
    public override void RefreshFromData()
    {
        // Update title
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        
        // Refresh details but DON'T regenerate sockets (this prevents duplication)
        // Sockets should only be regenerated when the socket structure actually changes
        RefreshDetails();
    }
}