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
        
        // Temporarily set Details to new dictionary so PopulateDetails can populate it
        var originalDetails = Details;
        Details = newDetails;
        
        try
        {
            PopulateDetails();
            
            // Update title as well
            UpdateTitle();
            OnPropertyChanged(nameof(Title));
        }
        catch (Exception)
        {
            // If population fails, restore original details
            Details = originalDetails;
        }
    }

    private void PopulateDetails()
    {
        Details["Mode"] = _castedData?.Mode.ToEnumString()!;

        var outputWeights = "";
        if (_castedData?.Weights != null)
        {
            foreach (var p in _castedData.Weights)
            {
                outputWeights += (outputWeights != "" ? ", " : "") + p.ToString();
            }
        }
        Details["Output Weights"] = outputWeights;
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

        var names = new string[_castedData.NumOutSockets];

        var total = 0;
        for (var i = 0; i < _castedData.NumOutSockets; i++)
        {
            total += _castedData.Weights[i];
        }

        for (var i = 0; i < _castedData.NumOutSockets; i++)
        {
            var chance = (float)_castedData.Weights[i] / total * 100;
            names[i] = $"[{chance:0.00}%] Out{i}";
        }

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            var output = new SceneOutputConnectorViewModel($"({socket.Stamp.Name},{socket.Stamp.Ordinal})", $"({socket.Stamp.Name},{socket.Stamp.Ordinal})", UniqueId, socket);
            output.Subtitle = names[i];
            Output.Add(output);
        }
    }

    public BaseConnectorViewModel AddOutput()
    {
        var index = (ushort)Output.Count;
        var outputSocket = new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = index } };

        _castedData.OutputSockets.Add(outputSocket);

        var output = new SceneOutputConnectorViewModel($"Out{index}", $"Out{index}", UniqueId, outputSocket);
        Output.Add(output);

        _castedData.NumOutSockets = (uint)Output.Count;

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
                
                // Notify UI and mark document dirty
                NotifySocketsChanged();
            }
        }
    }

}