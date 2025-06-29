using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using System.Collections.Generic;
using System;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnRewindableSectionNodeWrapper : BaseSceneViewModel<scnRewindableSectionNode>
{
    private readonly scnSceneResource _sceneResource;
    
    public scnRewindableSectionNodeWrapper(scnRewindableSectionNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode)
    {
        _sceneResource = scnSceneResource;
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
        Details["Section Duration"] = _castedData.SectionDuration.Stu.ToString() + "ms";
        Details["Ff Strategy"] = _castedData.FfStrategy.ToEnumString();
        Details["Play Speed Modifiers - Backward Fast"] = _castedData.PlaySpeedModifiers.BackwardFast.ToString();
        Details["Play Speed Modifiers - Backward Slow"] = _castedData.PlaySpeedModifiers.BackwardSlow.ToString();
        Details["Play Speed Modifiers - Backward Very Fast"] = _castedData.PlaySpeedModifiers.BackwardVeryFast.ToString();
        Details["Play Speed Modifiers - Forward Fast"] = _castedData.PlaySpeedModifiers.ForwardFast.ToString();
        Details["Play Speed Modifiers - Forward Slow"] = _castedData.PlaySpeedModifiers.ForwardSlow.ToString();
        Details["Play Speed Modifiers - Forward Very Fast"] = _castedData.PlaySpeedModifiers.ForwardVeryFast.ToString();

        var events = _castedData.Events;
        Details["Events"] = events.Count.ToString();

        int counter = 1;
        foreach (var eventClass in events)
        {
            string evName = eventClass?.Chunk?.GetType().Name!;

            if (eventClass?.Chunk is scneventsSocket evSocket)
            {
                evName += " - Name: " + evSocket.OsockStamp.Name.ToString()! + ", Ordinal: " + evSocket.OsockStamp.Ordinal.ToString()!;
            }

            Details["#" + counter.ToString() + " " + eventClass?.Chunk?.StartTime.ToString() + "ms"] = evName;
            counter++;
        }


    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            var label = GetSocketLabel(i, socket.Stamp.Name, socket.Stamp.Ordinal);
            var connectorVM = new SceneOutputConnectorViewModel($"Out{i}", label, UniqueId, socket);
            connectorVM.Subtitle = $"({socket.Stamp.Name},{socket.Stamp.Ordinal})";
            Output.Add(connectorVM);
        }
    }
    
    private string GetSocketLabel(int index, ushort name, ushort ordinal)
    {
        if (index == 0) return "OnEnd";
        if (index == 1) return "OnCut";
        
        // Detect which pattern for correct Event number
        if (name == index && ordinal == 0)
        {
            return $"Event{index - 2}";  // Direct: Event0, Event1...
        } 
        else if (name == 2)
        {
            return $"Event{ordinal}";     // Ordinal: Event0, Event1...
        }
        else
        {
            return $"Custom[{name},{ordinal}]"; // Edge case
        }
    }
}