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
            Background = GetBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
            ContentBackground = GetContentBackgroundForQuestNodeType(_castedData.QuestNode.Chunk);
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

    private static Brush GetBackgroundForQuestNodeType(questNodeDefinition node)
    {
        // Use the same color scheme as quest nodes for consistency
        return node switch
        {
            questStartNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33228B22")), // Dark green tint
            questEndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B22222")), // Dark red tint
            questInputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332288B2")), // Dark blue tint
            questOutputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B28822")), // Dark orange tint
            questConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2B222")), // Dark yellow tint
            questPhaseNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B222B2")), // Dark purple tint
            questSceneNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3322B2B2")), // Dark cyan tint
            questRandomizerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2AA22")), // Dark orange tint
            questFlowControlNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AA22")), // Dark lime tint
            questSwitchNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2255")), // Dark pink tint
            questLogicalAndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332255AA")), // Dark light blue tint
            questLogicalXorNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA5522")), // Dark brown tint
            questLogicalHubNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AA55")), // Dark green-blue tint
            questFactsDBManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA22AA")), // Dark magenta tint
            questItemManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377AA22")), // Dark olive tint
            questCharacterManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA7722")), // Dark amber tint
            questUIManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332277AA")), // Dark teal tint
            questAudioNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2277")), // Dark rose tint
            questJournalNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377AA77")), // Dark sage tint
            questPauseConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#55FF6600")), // Bright orange tint - more prominent for crucial nodes
            questSceneManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3322B2B2")), // Dark cyan tint
            questRenderFxManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2AA22")), // Dark orange tint  
            questSpawnManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA22B2")), // Dark purple-magenta tint
            questTriggerManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B222AA")), // Dark purple-green tint
            questEntityManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3322AAB2")), // Dark blue-green tint
            questEnvironmentManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AAB222")), // Dark yellow-green tint
            questEventManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2B2AA")), // Dark yellow-cyan tint
            questMappinManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA77B2")), // Dark blue-sage tint
            questRewardManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B277AA")), // Dark teal-amber tint
            questTimeManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377B2AA")), // Dark teal-sage tint
            questVisionModesManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA77AA")), // Dark magenta-sage tint
            questVoicesetManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377AAAA")), // Dark teal-sage tint
            questFXManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2AA22")), // Dark orange tint
            questPuppetAIManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2255")), // Dark pink tint
            questCrowdManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#335522AA")), // Dark purple-lime tint
            questInteractiveObjectManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AAB2")), // Dark blue-lime tint
            questPhoneManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B25522")), // Dark orange-lime tint
            _ => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33666666")) // Default darker gray tint
        };
    }

    private static Brush GetContentBackgroundForQuestNodeType(questNodeDefinition node)
    {
        // Very subtle tint for content area (much lighter than header)
        return node switch
        {
            questStartNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11228B22")), // Very subtle green tint
            questEndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B22222")), // Very subtle red tint
            questInputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#112288B2")), // Very subtle blue tint
            questOutputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B28822")), // Very subtle orange tint
            questConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2B222")), // Very subtle yellow tint
            questPhaseNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B222B2")), // Very subtle purple tint
            questSceneNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1122B2B2")), // Very subtle cyan tint
            questRandomizerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2AA22")), // Very subtle orange tint
            questFlowControlNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1155AA22")), // Very subtle lime tint
            questSwitchNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA2255")), // Very subtle pink tint
            questLogicalAndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#112255AA")), // Very subtle light blue tint
            questLogicalXorNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA5522")), // Very subtle brown tint
            questLogicalHubNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1155AA55")), // Very subtle green-blue tint
            questFactsDBManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA22AA")), // Very subtle magenta tint
            questItemManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1177AA22")), // Very subtle olive tint
            questCharacterManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA7722")), // Very subtle amber tint
            questUIManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#112277AA")), // Very subtle teal tint
            questAudioNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA2277")), // Very subtle rose tint
            questJournalNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1177AA77")), // Very subtle sage tint
            questPauseConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#22FF6600")), // Subtle orange tint - still prominent but toned down
            questSceneManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1122B2B2")), // Very subtle cyan tint
            questRenderFxManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2AA22")), // Very subtle orange tint  
            questSpawnManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA22B2")), // Very subtle purple-magenta tint
            questTriggerManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B222AA")), // Very subtle purple-green tint
            questEntityManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1122AAB2")), // Very subtle blue-green tint
            questEnvironmentManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AAB222")), // Very subtle yellow-green tint
            questEventManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2B2AA")), // Very subtle yellow-cyan tint
            questMappinManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA77B2")), // Very subtle blue-sage tint
            questRewardManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B277AA")), // Very subtle teal-amber tint
            questTimeManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1177B2AA")), // Very subtle teal-sage tint
            questVisionModesManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA77AA")), // Very subtle magenta-sage tint
            questVoicesetManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1177AAAA")), // Very subtle teal-sage tint
            questFXManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B2AA22")), // Very subtle orange tint
            questPuppetAIManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11AA2255")), // Very subtle pink tint
            questCrowdManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#115522AA")), // Very subtle purple-lime tint
            questInteractiveObjectManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1155AAB2")), // Very subtle blue-lime tint
            questPhoneManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11B25522")), // Very subtle orange-lime tint
            _ => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11666666")) // Very subtle default gray tint
        };
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
            if (DocumentViewModel?.SelectedTabItemViewModel is CombinedSceneViewModel combinedScene)
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