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
            Title = $"[{UniqueId}] {questNodeType}";
            Background = GraphNodeColors.GetBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
            ContentBackground = GraphNodeColors.GetContentBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
        }
        else
        {
            Title = $"[{UniqueId}] Quest";
        }

        Details.AddRange(NodeProperties.GetPropertiesFor(_castedData.QuestNode?.Chunk, scnSceneResource));

        Title += NodeProperties.SetNameFromNotablePoints(scnSceneGraphNode.NodeId.Id, scnSceneResource);
    }

    internal override void GenerateSockets()
    {
        /*var inSockets = new[] { "CutDestination", "In" };
        for (ushort i = 0; i < inSockets.Length; i++)
        {
            var name = inSockets[i];
            if (_castedData.IsockMappings.Count > i)
            {
                name = _castedData.IsockMappings[i].GetResolvedText()!;
            }

            Input.Add(new SceneInputConnectorViewModel(name, name, UniqueId, i));
        }*/

        for (ushort i = 0; i < _castedData.IsockMappings.Count; i++)
        {
            var name = _castedData.IsockMappings[i].GetResolvedText()!;
            Input.Add(new SceneInputConnectorViewModel(name, name, UniqueId, i));
        }

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var name = $"Out{i}";
            if (_castedData.OsockMappings.Count > i)
            {
                name = _castedData.OsockMappings[i].GetResolvedText()!;
            }

            Output.Add(new SceneOutputConnectorViewModel(name, name, UniqueId, _castedData.OutputSockets[i]));
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
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination });
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
                    tempDetails[kvp.Key] = kvp.Value;
                }
                
            }
            else
            {
                tempDetails["Type"] = "Quest";
            }
            
            // Set the new details dictionary to trigger UI update
            Details = tempDetails;
            
            // Also refresh the title
            UpdateTitle();
            OnPropertyChanged(nameof(Title));
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
                Title = $"[{UniqueId}] {questNodeType}";
            }
            else
            {
                Title = $"[{UniqueId}] Quest";
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