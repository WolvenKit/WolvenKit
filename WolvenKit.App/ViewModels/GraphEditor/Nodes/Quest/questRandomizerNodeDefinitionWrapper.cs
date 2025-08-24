using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questRandomizerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questRandomizerNodeDefinition>, IDynamicOutputNode
{
    public questRandomizerNodeDefinitionWrapper(questRandomizerNodeDefinition questRandomizerNodeDefinition) : base(questRandomizerNodeDefinition)
    {
        //Title = $"{Title} [{questRandomizerNodeDefinition.Id}]";
        //Details.Add("Type", questRandomizerNodeDefinition.Mode.ToEnumString());

        // Use our custom detail population instead of the generic one
        RefreshDetails();
    }

    /// <summary>
    /// Override to provide detailed quest randomizer information with live weight percentages
    /// </summary>
    public override void RefreshDetails()
    {
        // Create a new Details dictionary to trigger UI updates
        var tempDetails = new Dictionary<string, string>();
        
        // Populate the new dictionary with randomizer-specific details
        PopulateRandomizerDetails(tempDetails);
        
        // Replace the Details dictionary to trigger WPF binding updates
        Details = tempDetails;
        
        // Also refresh the title
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        
        // Update socket percentages
        UpdateSocketPercentages();
    }

    private void PopulateRandomizerDetails(Dictionary<string, string> details)
    {
        // Add mode
        details["Mode"] = _castedData.Mode.ToEnumString();

        // Calculate and display output weights with percentages
        var outputWeights = "";
        if (_castedData.OutputWeights != null && _castedData.OutputWeights.Count > 0)
        {
            // Calculate total weight
            var total = 0;
            foreach (var weight in _castedData.OutputWeights)
            {
                total += weight;
            }

            // Build weights string with percentages
            if (total > 0)
            {
                for (var i = 0; i < _castedData.OutputWeights.Count; i++)
                {
                    var weight = _castedData.OutputWeights[i];
                    var percentage = (float)weight / total * 100;
                    outputWeights += (outputWeights != "" ? ", " : "") + $"{weight} ({percentage:0.00}%)";
                }
            }
            else
            {
                // If total is 0, just show the raw weights
                foreach (var weight in _castedData.OutputWeights)
                {
                    outputWeights += (outputWeights != "" ? ", " : "") + weight.ToString();
                }
            }
        }
        details["Output Weights"] = outputWeights;

        // Add other generic properties
        var nodeDetails = NodeProperties.GetPropertiesFor(_castedData);
        foreach (var kvp in nodeDetails)
        {
            // Skip properties we've already handled with better formatting
            if (kvp.Key != "Mode" && kvp.Key != "OutputWeights")
            {
                details[kvp.Key] = kvp.Value;
            }
        }
    }

    private void UpdateSocketPercentages()
    {
        // Quest graphs don't use socket subtitles - percentages are only shown in details panel
        // No need to update socket subtitles for quest randomizer nodes
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Output.Clear();

        // Calculate total weight for percentage calculation
        var total = 0;
        foreach (var weight in _castedData.OutputWeights)
        {
            total += weight;
        }

        var outputIndex = 0;
        foreach (var socketHandle in _castedData.Sockets)
        {
            if (socketHandle.Chunk is questSocketDefinition socketDefinition)
            {
                var name = socketDefinition.Name.GetResolvedText()!;

                if (socketDefinition.Type == Enums.questSocketType.Input ||
                    socketDefinition.Type == Enums.questSocketType.CutDestination)
                {
                    Input.Add(new QuestInputConnectorViewModel(name, name, UniqueId, socketDefinition));
                }

                if (socketDefinition.Type == Enums.questSocketType.Output ||
                    socketDefinition.Type == Enums.questSocketType.CutSource)
                {
                    // Show percentage in the socket name itself, no subtitle
                    var displayName = name;
                    if (outputIndex < _castedData.OutputWeights.Count && total > 0)
                    {
                        var chance = (float)_castedData.OutputWeights[outputIndex] / total * 100;
                        displayName = $"[{chance:0.00}%] {name}";
                    }
                    else
                    {
                        displayName = $"[0.00%] {name}";
                    }

                    Output.Add(new QuestOutputConnectorViewModel(name, displayName, UniqueId, socketDefinition));
                    outputIndex++;
                }
            }
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out1", Enums.questSocketType.Output);
        CreateSocket("Out2", Enums.questSocketType.Output);
    }

    public BaseConnectorViewModel AddOutput()
    {
        var cnt = 1;
        foreach (var handle in _castedData.Sockets)
        {
            if (handle.Chunk is not questSocketDefinition socketDefinition)
            {
                throw new Exception();
            }

            if (socketDefinition.Type == Enums.questSocketType.Output)
            {
                cnt++;
            }
        }

        var socket = CreateSocket($"Out{cnt}", Enums.questSocketType.Output);
        
        // Add a default weight of 1 instead of 0 to avoid division by zero
        _castedData.OutputWeights.Add(1);

        // Calculate percentage for the new output
        var total = 0;
        foreach (var weight in _castedData.OutputWeights)
        {
            total += weight;
        }
        
        var chance = total > 0 ? (float)1 / total * 100 : 0f;
        var displayName = $"[{chance:0.00}%] Out{cnt}";
        
        var connector = new QuestOutputConnectorViewModel($"Out{cnt}", displayName, UniqueId, socket);
        Output.Add(connector);

        // Regenerate all sockets to update percentages
        GenerateSockets();
        
        // Refresh details to show updated weights
        RefreshDetails();

        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Output));
        OnPropertyChanged(nameof(Data));

        return connector;
    }

    public void RemoveOutput() => throw new System.NotImplementedException();
}
