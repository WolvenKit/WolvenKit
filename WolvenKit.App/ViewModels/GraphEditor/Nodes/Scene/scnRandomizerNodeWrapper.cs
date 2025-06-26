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
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));  // Added CutDestination input socket

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

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel(names[i], names[i], UniqueId, _castedData.OutputSockets[i]));
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

        return output;
    }

    public void RemoveOutput() => throw new System.NotImplementedException();
}