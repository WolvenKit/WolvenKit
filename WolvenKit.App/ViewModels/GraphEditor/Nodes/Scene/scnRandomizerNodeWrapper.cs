using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using System.Collections.Generic;
using System;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnRandomizerNodeWrapper : BaseSceneViewModel<scnRandomizerNode>, IDynamicOutputNode
{
    public scnRandomizerNodeWrapper(scnRandomizerNode scnRandomizerNode) : base(scnRandomizerNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");

        OutputSocketNames.Add(0, "Out");

        PopulateDetails();
    }

    public override void RefreshDetails()
    {
        // Create a new dictionary to trigger UI update (WPF needs reference change)
        var newDetails = new Dictionary<string, string>();
        
        // Populate the new dictionary
        PopulateDetails(newDetails);
        
        // Set the new dictionary to trigger UI update
        Details = newDetails;
        
        // Update socket percentages
        UpdateSocketPercentages();
        
        // Update title as well
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    private void PopulateDetails(Dictionary<string, string>? detailsDict = null)
    {
        var targetDetails = detailsDict ?? Details;
        
        targetDetails["Mode"] = _castedData?.Mode.ToEnumString()!;

        // Build output weights string with percentages
        var outputWeights = "";
        if (_castedData?.Weights != null && _castedData.NumOutSockets > 0)
        {
            // Calculate total weight for percentage calculation
            var total = 0;
            for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
            {
                total += _castedData.Weights[i];
            }

            // Build the weights string with percentages
            if (total > 0)
            {
                for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
                {
                    var weight = _castedData.Weights[i];
                    var percentage = (float)weight / total * 100;
                    outputWeights += (outputWeights != "" ? ", " : "") + $"{weight} ({percentage:0.00}%)";
                }
            }
            else
            {
                // If total is 0, just show the raw weights
                for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
                {
                    outputWeights += (outputWeights != "" ? ", " : "") + _castedData.Weights[i].ToString();
                }
            }
        }
        
        targetDetails["Output Weights"] = outputWeights;
    }

    private void UpdateSocketPercentages()
    {
        if (_castedData == null || Output == null || Output.Count == 0)
            return;

        // Calculate total weight
        var total = 0;
        for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
        {
            total += _castedData.Weights[i];
        }

        // Update socket subtitles with percentages
        for (var i = 0; i < Math.Min(Output.Count, _castedData.NumOutSockets); i++)
        {
            if (i < _castedData.Weights.Count && total > 0)
            {
                var chance = (float)_castedData.Weights[i] / total * 100;
                Output[i].Subtitle = $"[{chance:0.00}%] Out{i}";
            }
            else
            {
                Output[i].Subtitle = $"[0.00%] Out{i}";
            }
        }
        
        // Notify that output collection has been updated
        OnPropertyChanged(nameof(Output));
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

        // Calculate total weight for percentage calculation
        var total = 0;
        for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
        {
            total += _castedData.Weights[i];
        }

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            var nameAndTitle = $"({socket.Stamp.Name},{socket.Stamp.Ordinal})";
            var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socket.Stamp.Name, socket.Stamp.Ordinal, socket);
            
            // Calculate percentage for this socket
            if (i < _castedData.Weights.Count && total > 0)
            {
                var chance = (float)_castedData.Weights[i] / total * 100;
                output.Subtitle = $"[{chance:0.00}%] Out{i}";
            }
            else
            {
                output.Subtitle = $"[0.00%] Out{i}";
            }
            
            Output.Add(output);
        }
    }

    public BaseConnectorViewModel AddOutput()
    {
        var outputSocket = new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = (ushort)Output.Count } };
        _castedData.OutputSockets.Add(outputSocket);

        var index = (ushort)Output.Count;
        var nameAndTitle = $"({outputSocket.Stamp.Name},{outputSocket.Stamp.Ordinal})";
        var output = new SceneOutputConnectorViewModel(nameAndTitle, $"Out{index}", UniqueId, outputSocket.Stamp.Name, outputSocket.Stamp.Ordinal, outputSocket);
        
        _castedData.NumOutSockets = (uint)(_castedData.OutputSockets.Count);

        // Add a default weight for the new output if needed
        if (_castedData.Weights.Count < _castedData.NumOutSockets)
        {
            _castedData.Weights.Add(1); // Default weight of 1
        }

        // Calculate and set the percentage subtitle
        var total = 0;
        for (var i = 0; i < Math.Min(_castedData.NumOutSockets, _castedData.Weights.Count); i++)
        {
            total += _castedData.Weights[i];
        }
        
        if (index < _castedData.Weights.Count && total > 0)
        {
            var chance = (float)_castedData.Weights[index] / total * 100;
            output.Subtitle = $"[{chance:0.00}%] Out{index}";
        }
        else
        {
            output.Subtitle = $"[0.00%] Out{index}";
        }
        
        Output.Add(output);

        // Update all socket percentages since totals changed
        UpdateSocketPercentages();
        
        // Refresh details to show updated weights
        RefreshDetails();

        // Note: Subscription to destination changes happens automatically via Output.CollectionChanged
        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return output;
    }

    public void RemoveOutput()
    {
        if (_castedData.OutputSockets.Count > 1) // Keep at least one output
        {
            var lastSocket = _castedData.OutputSockets[^1];
            
            // Only remove if it has no connections
            if (lastSocket.Destinations.Count == 0)
            {
                _castedData.OutputSockets.RemoveAt(_castedData.OutputSockets.Count - 1);
                Output.RemoveAt(Output.Count - 1);
                
                // Update the counter
                _castedData.NumOutSockets = (uint)Output.Count;
                
                // Update weights array if needed
                if (_castedData.Weights.Count > _castedData.NumOutSockets)
                {
                    _castedData.Weights.RemoveAt(_castedData.Weights.Count - 1);
                }
                
                // Update all socket percentages since totals changed
                UpdateSocketPercentages();
                
                // Refresh details to show updated weights
                RefreshDetails();
                
                // Notify UI and mark document dirty
                NotifySocketsChanged();
            }
        }
    }

}
