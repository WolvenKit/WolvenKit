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

        Title += NodeProperties.SetNameFromNotablePoints(_castedData.NodeId.Id, _sceneResource);
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));
        Input.Add(new SceneInputConnectorViewModel("CutDestination", "CutDestination", UniqueId, 1));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var title = $"Out{i} - Name: " + _castedData.OutputSockets[i].Stamp.Name + ", Ordinal: " + _castedData.OutputSockets[i].Stamp.Ordinal;
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, _castedData.OutputSockets[i]));
        }
    }
}