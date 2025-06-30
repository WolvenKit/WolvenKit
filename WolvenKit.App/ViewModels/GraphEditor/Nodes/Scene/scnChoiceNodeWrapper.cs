using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnChoiceNodeWrapper : BaseSceneViewModel<scnChoiceNode>
{
    private readonly scnSceneResource _sceneResource;

    public ObservableCollection<string> Options { get; set; } = new();

    public scnChoiceNodeWrapper(scnChoiceNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode, scnSceneResource)
    {
        _sceneResource = scnSceneResource;
        
        // Populate initial details
        RefreshDetails();
    }

    /// <summary>
    /// Override to provide curated details for choice nodes
    /// </summary>
    public override void RefreshDetails()
    {
        // Create a new dictionary to trigger UI update
        var newDetails = new Dictionary<string, string>();
        
        try
        {
            // Mode information
            var mode = _castedData.Mode.ToEnumString();
            newDetails["Mode"] = mode;
            
            // Add attachment target information based on mode
            switch ((Enums.scnChoiceNodeNsOperationMode)_castedData.Mode)
            {
                case Enums.scnChoiceNodeNsOperationMode.attachToActor:
                    if (_castedData.AtaParams.ActorId.Id != uint.MaxValue)
                    {
                        var actorName = ResolvePerformerName(_castedData.AtaParams.ActorId.Id, _sceneResource);
                        newDetails["Actor"] = actorName;
                        newDetails["Visualizer Style"] = _castedData.AtaParams.VisualizerStyle.ToEnumString();
                    }
                    break;
                    
                case Enums.scnChoiceNodeNsOperationMode.attachToProp:
                    if (_castedData.AtpParams.PropId.Id != uint.MaxValue)
                    {
                        var propName = ResolvePropName(_castedData.AtpParams.PropId.Id, _sceneResource);
                        newDetails["Prop"] = propName;
                        newDetails["Visualizer Style"] = _castedData.AtpParams.VisualizerStyle.ToEnumString();
                    }
                    break;
                    
                case Enums.scnChoiceNodeNsOperationMode.attachToGameObject:
                    if (_castedData.AtgoParams.NodeRef != NodeRef.Empty)
                    {
                        var nodeRef = _castedData.AtgoParams.NodeRef.GetRedHash().ToString("X8");
                        newDetails["Game Object"] = $"Node: {nodeRef}";
                        newDetails["Visualizer Style"] = _castedData.AtgoParams.VisualizerStyle.ToEnumString();
                    }
                    break;
                    
                case Enums.scnChoiceNodeNsOperationMode.attachToWorld:
                    var pos = _castedData.AtwParams.EntityPosition;
                    var rot = _castedData.AtwParams.EntityOrientation;
                    newDetails["World Position"] = $"({pos.X:F1}, {pos.Y:F1}, {pos.Z:F1})";
                    newDetails["World Rotation"] = $"({rot.I:F2}, {rot.J:F2}, {rot.K:F2}, {rot.R:F2})";
                    break;
                    
                case Enums.scnChoiceNodeNsOperationMode.attachToScreen:
                    // Screen attachment doesn't have specific params to show
                    newDetails["Attachment"] = "Screen";
                    break;
            }
            
            // Mapping parameters if present
            if (_castedData.MappinParams?.GetValue() is scnChoiceNodeNsMappinParams mappinParams)
            {
                newDetails["Mappin Location"] = mappinParams.LocationType.ToEnumString();
                if (mappinParams.MappinSettings != TweakDBID.Empty)
                {
                    var mappinSettings = mappinParams.MappinSettings.GetResolvedText();
                    newDetails["Mappin Settings"] = !string.IsNullOrEmpty(mappinSettings) ? mappinSettings : "[unresolved]";
                }
            }
            
            // Choice count
            newDetails["Choices"] = _castedData.Options.Count.ToString();
            
            // Priority information if set
            if (_castedData.ChoicePriority > 0)
            {
                newDetails["Choice Priority"] = _castedData.ChoicePriority.ToString();
            }
            if (_castedData.HubPriority > 0)
            {
                newDetails["Hub Priority"] = _castedData.HubPriority.ToString();
            }
        }
        catch (Exception ex)
        {
            newDetails["Error"] = ex.Message;
        }
        
        // Set new details
        Details = newDetails;
        
        // Update title as well
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    /// <summary>
    /// Helper method to resolve performer IDs to names (copied from scnSectionNodeWrapper)
    /// </summary>
    private string ResolvePerformerName(CUInt32 performerIdCUint32, scnSceneResource? sceneResource)
    {
        uint performerId = performerIdCUint32;
        if (performerId == uint.MaxValue || performerId == 4294967040) return "None";
        if (performerId == 0)
        {
             var playerActorDef = sceneResource?.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == 0);
             if (playerActorDef != null)
             {
                 string? playerName = playerActorDef.PlayerName;
                 if (string.IsNullOrEmpty(playerName)) playerName = "Player";
                 return $"{playerName} [0]";
             }
             var actorDefZero = sceneResource?.Actors?.FirstOrDefault(a => a.ActorId?.Id == 0);
             if(actorDefZero != null)
             {
                 string? actorName = actorDefZero.ActorName;
                 return $"{actorName ?? "Unnamed"} [0]";
             }
             return "Player? [0]";
        }
        
        if (performerId >= 2 && (performerId % 256 == 2))
        {
            uint propIndex = (performerId - 2) / 256;
            if (sceneResource?.Props != null && propIndex < sceneResource.Props.Count)
            {
                var propDef = sceneResource.Props[(int)propIndex];
                string? propName = propDef?.PropName;
                return $"Prop: {propName ?? "Unnamed"} [{propIndex}]";
            }
            else { return $"Prop Idx {propIndex}? [{performerId}]"; }
        }
        else if (performerId >= 1 && (performerId % 256 == 1))
        {
            uint actorIndex = (performerId - 1) / 256;

            var playerActorDef = sceneResource?.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == actorIndex);
            if(playerActorDef != null)
            {
                string? playerName = playerActorDef.PlayerName;
                if (string.IsNullOrEmpty(playerName)) playerName = "Player";
                return $"{playerName} [{actorIndex}]";
            }

            if (sceneResource?.Actors != null && actorIndex < sceneResource.Actors.Count)
            {
                 var actorDef = sceneResource.Actors[(int)actorIndex];
                 if (actorDef != null)
                 {
                     string? actorName = actorDef.ActorName;
                     return $"{actorName ?? "Unnamed"} [{actorIndex}]";
                 }
                 else { return $"Actor Idx {actorIndex} (Null Def) [{performerId}]"; } 
            }
            else { return $"Actor Idx {actorIndex}? [{performerId}]"; }
        }
        return $"Unknown [{performerId}]";
    }

    /// <summary>
    /// Helper method to resolve prop IDs to names
    /// </summary>
    private string ResolvePropName(CUInt32 propId, scnSceneResource? sceneResource)
    {
        if (propId == uint.MaxValue) return "None";
        
        var propDef = sceneResource?.Props?.FirstOrDefault(p => p.PropId?.Id == propId);
        if (propDef != null)
        {
            string? propName = propDef.PropName;
            return $"{propName ?? "Unnamed"} [{propId}]";
        }
        
        return $"Unknown Prop [{propId}]";
    }

    internal override void GenerateSockets()
    {
        GetChoices();

        // --- Synchronize INPUT connectors (they are static: In, CutDestination) ---
        string[] inputNames = { "In", "CutDestination" };
        for (int i = 0; i < inputNames.Length; i++)
        {
            if (i < Input.Count)
            {
                // Update existing
                var existingInput = Input[i];
                if (existingInput.Name != inputNames[i])
                {
                    Input[i] = new SceneInputConnectorViewModel(inputNames[i], inputNames[i], UniqueId, (ushort)i);
                }
            }
            else
            {
                Input.Add(new SceneInputConnectorViewModel(inputNames[i], inputNames[i], UniqueId, (ushort)i));
            }
        }

        // Remove excess inputs
        while (Input.Count > inputNames.Length)
        {
            Input.RemoveAt(Input.Count - 1);
        }

        // Synchronize the Output collection with the underlying socket list while keeping
        // existing connector instances alive whenever possible to preserve established
        // connections in the graph editor.

        int desiredCount = _castedData.OutputSockets.Count;

        // Ensure the collection has the correct size
        // 1. Update or create connectors up to desiredCount
        for (var i = 0; i < desiredCount; i++)
        {
            var socket = _castedData.OutputSockets[i];

            // Determine the proper title for this socket
            var socketName = socket.Stamp.Name;
            var socketOrdinal = socket.Stamp.Ordinal;

            string title;

            if (socketName == 0)
            {
                // Choice outputs: ordinal maps to option index
                var choiceIndex = (int)socketOrdinal;
                title = choiceIndex < Options.Count ? Options[choiceIndex] : $"Choice {choiceIndex + 1}";
            }
            else
            {
                // Static control-flow outputs
                var labelIndex = ((ushort)socketName) switch
                {
                    1 => (ushort)(_castedData.Options.Count + 0), // AnyOption
                    2 => (ushort)(_castedData.Options.Count + 1), // Immediate
                    3 => (ushort)(_castedData.Options.Count + 2), // OnCut
                    4 => (ushort)(_castedData.Options.Count + 3), // NoOption
                    5 => (ushort)(_castedData.Options.Count + 4), // WhenDisplayed
                    6 => (ushort)(_castedData.Options.Count + 5), // Reminder
                    _ => (ushort)ushort.MaxValue
                };

                title = (labelIndex != ushort.MaxValue && labelIndex < Options.Count)
                    ? Options[labelIndex]
                    : $"Out {socketName}";
            }

            if (i < Output.Count)
            {
                // Update existing connector if it references the same socket; otherwise replace
                var existing = Output[i] as SceneOutputConnectorViewModel;

                if (existing == null || existing.Data != socket)
                {
                    // Replace the connector but *do not* clear the whole collection
                    Output[i] = new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, socket);
                }
                else
                {
                    // Same connector; replace if title mismatches because Title is immutable
                    if (existing.Title != title)
                    {
                        Output[i] = new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, socket);
                    }
                }
            }
            else
            {
                // Need to add a new connector
                Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, socket));
            }
        }

        // 2. Remove any excess connectors at the end
        while (Output.Count > desiredCount)
        {
            Output.RemoveAt(Output.Count - 1);
        }
    }

    private void GetChoices()
    {
        Options.Clear();
        
        for (var i = 0; i < _castedData.Options.Count; i++)
        {
            var option = _castedData.Options[i];
            string choiceText;

            // Try to get text from screenplay/localization store
            try
            {
                var screenPlay = _sceneResource
                    .ScreenplayStore
                    ?.Options
                    ?.FirstOrDefault(x => x.ItemId.Id == option.ScreenplayOptionId.Id);

                if (screenPlay != null)
                {
                    var vdEntry = _sceneResource
                        .LocStore
                        ?.VdEntries
                        ?.FirstOrDefault(x => x.LocstringId.Ruid == screenPlay.LocstringId.Ruid);

                    if (vdEntry != null)
                    {
                        var vpEntry = _sceneResource
                            .LocStore
                            ?.VpEntries
                            ?.FirstOrDefault(x => x.VariantId.Ruid == vdEntry.VariantId.Ruid);

                        if (vpEntry != null && !string.IsNullOrEmpty(vpEntry.Content))
                        {
                            choiceText = $"[{vdEntry.LocaleId.ToEnumString()}] {vpEntry.Content}";
                            Options.Add(choiceText);
                            continue;
                        }
                    }
                }
            }
            catch
            {
                // Continue to fallbacks if there's any error accessing screenplay/loc data
            }

            // Fallback to caption if no localized text found
            if (option.Caption != CName.Empty)
            {
                var captionString = option.Caption.GetResolvedText();
                if (!string.IsNullOrEmpty(captionString))
                {
                    choiceText = $"{captionString}";
                }
                else
                {
                    choiceText = $"[unresolved]";
                }
            }
            else
            {
                // Final fallback to choice index and ID
                choiceText = $"Choice {i + 1} [ID:{option.ScreenplayOptionId.Id}]";
            }

            Options.Add(choiceText);
        }

        // Add the standard control flow socket labels  
        Options.Add("AnyOption");
        Options.Add("Immediate");
        Options.Add("OnCut");
        Options.Add("NoOption");
        Options.Add("WhenDisplayed");
        Options.Add("Reminder");
    }

    public void AddChoice()
    {
        var random = new Random();

        // VariantId is 4 higher then LocstringId, doesn't seem important
        var cruid = (CRUID)random.NextCRUID();

        // first id is always 2, don't know why
        var id = (CUInt32)2;
        if (_sceneResource.ScreenplayStore.Options.Count > 0)
        {
            // needs to be 256 higher, if lower the previous text is used, if higher nothing is shown...
            id = _sceneResource.ScreenplayStore.Options[^1].ItemId.Id + 256;
        }

        _sceneResource.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
        {
            Content = "Choice",
            VariantId = new scnlocVariantId
            {
                Ruid = cruid
            }
        });

        _sceneResource.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
        {
            LocstringId = new scnlocLocstringId
            {
                Ruid = cruid - 4
            },
            VariantId = new scnlocVariantId
            {
                Ruid = cruid
            },
            VpeIndex = (uint)(_sceneResource.LocStore.VpEntries.Count - 1),
            Signature = new scnlocSignature
            {
                Val = 3 // ???
            }
        });

        _sceneResource.ScreenplayStore.Options.Add(new scnscreenplayChoiceOption
        {
            LocstringId = new scnlocLocstringId
            {
                Ruid = cruid - 4
            },
            ItemId = new scnscreenplayItemId
            {
                Id = id
            },
            Usage = new scnscreenplayOptionUsage
            {
                PlayerGenderMask = new scnGenderMask
                {
                    Mask = 3 // both
                }
            }
        });

        _castedData.Options.Add(new scnChoiceNodeOption
        {
            ScreenplayOptionId = new scnscreenplayItemId()
            {
                Id = id
            }
        });

        // Find the number of existing choice sockets (name=0)
        var existingChoiceCount = _castedData.OutputSockets.Count(s => s.Stamp.Name == 0);
        
        // New choice ordinal should be the next choice index
        var newChoiceOrdinal = (ushort)existingChoiceCount;
        
        // Insert position should be after all existing choice sockets
        var insertPosition = existingChoiceCount;
        
        var newOutputSocket = new scnOutputSocket
        {
            Stamp = new scnOutputSocketStamp
            {
                Name = (CUInt16)0,
                Ordinal = (CUInt16)newChoiceOrdinal
            }
        };
        
        _castedData.OutputSockets.Insert(insertPosition, newOutputSocket);

        // Add the choice text to Options and get the title
        // Since we just added a choice, we need to refresh the Options to get proper text
        var choiceText = "Choice"; // Default fallback
        try
        {
            var newOption = _castedData.Options[^1]; // The choice we just added
            var screenPlay = _sceneResource
                .ScreenplayStore
                ?.Options
                ?.FirstOrDefault(x => x.ItemId.Id == newOption.ScreenplayOptionId.Id);

            if (screenPlay != null)
            {
                var vdEntry = _sceneResource
                    .LocStore
                    ?.VdEntries
                    ?.FirstOrDefault(x => x.LocstringId.Ruid == screenPlay.LocstringId.Ruid);

                if (vdEntry != null)
                {
                    var vpEntry = _sceneResource
                        .LocStore
                        ?.VpEntries
                        ?.FirstOrDefault(x => x.VariantId.Ruid == vdEntry.VariantId.Ruid);

                    if (vpEntry != null && !string.IsNullOrEmpty(vpEntry.Content))
                    {
                        choiceText = $"[{vdEntry.LocaleId.ToEnumString()}] {vpEntry.Content}";
                    }
                }
            }
        }
        catch
        {
            // Use fallback
        }

        // Create and insert the new connector at the correct position
        var newConnector = new SceneOutputConnectorViewModel($"Out{insertPosition}", choiceText, UniqueId, newOutputSocket);
        Output.Insert(insertPosition, newConnector);

        // SOCKET SYNC FIX: Subscribe to destination changes for property panel sync
        SubscribeToSocketDestinations(newConnector);

        // SYNC FIX: Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Output));
        OnPropertyChanged(nameof(Data));

        // Mark document as dirty
        DocumentViewModel?.SetIsDirty(true);
    }
}