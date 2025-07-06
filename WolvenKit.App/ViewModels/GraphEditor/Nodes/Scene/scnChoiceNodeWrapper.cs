using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnChoiceNodeWrapper : BaseSceneViewModel<scnChoiceNode>, IRefreshableDetails
{
    private readonly scnSceneResource _sceneResource;

    public ObservableCollection<string> Options { get; set; } = new();

    public scnChoiceNodeWrapper(scnChoiceNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode, scnSceneResource)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        InputSocketNames.Add(2, "ReactivateGroup");
        InputSocketNames.Add(3, "TimeLimitedFinish");

        OutputSocketNames.Add(0, "Option");
        OutputSocketNames.Add(1, "AnyOption");
        OutputSocketNames.Add(2, "Immediate");
        OutputSocketNames.Add(3, "OnCancel");
        OutputSocketNames.Add(4, "NoOption");
        OutputSocketNames.Add(5, "WhenDisplayed");
        OutputSocketNames.Add(6, "Reminder");

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
        
        // Update socket subtitles to reflect property changes without regenerating sockets
        // but fall back to full regeneration if sockets are out of sync
        UpdateSocketsPreservingConnections();
    }

    /// <summary>
    /// Updates socket subtitles without regenerating the entire socket collection when possible
    /// This preserves connections while updating the display text.
    /// Falls back to full regeneration if sockets are out of sync.
    /// </summary>
    private void UpdateSocketsPreservingConnections()
    {
        // Refresh the choices collection to get latest text
        GetChoices();
        
        // Check if sockets are in sync with choice data
        var choiceOutputs = Output.OfType<SceneOutputConnectorViewModel>()
            .Where(o => o?.Data != null && o.Data.Stamp.Name == 0)
            .OrderBy(o => o?.Data?.Stamp.Ordinal)
            .ToList();
            
        var expectedChoiceSocketCount = _castedData.OutputSockets.Count(s => s.Stamp.Name == 0);
        
        // If socket count doesn't match or we have virtual sockets that need real ones, do full regeneration
        if (choiceOutputs.Count != expectedChoiceSocketCount || 
            choiceOutputs.Count != Options.Count ||
            choiceOutputs.Any(s => s?.Data == null))
        {
            // Sockets are out of sync, need full regeneration
            GenerateSockets();
            return;
        }
        
        // Sockets are in sync, just update subtitles
        for (int i = 0; i < choiceOutputs.Count && i < Options.Count; i++)
        {
            var socket = choiceOutputs[i];
            if (socket?.Data != null)
            {
                var ordinal = socket.Data.Stamp.Ordinal;
                var baseName = $"(Option_{ordinal + 1}) {Options[i]}";
                socket.Subtitle = baseName;
            }
        }
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

        Input.Clear();
        foreach (var (socketNameId, socketName) in InputSocketNames)
        {
            var input = new SceneInputConnectorViewModel(socketName, socketName, UniqueId, socketNameId, 0);
            input.Subtitle = $"({socketNameId},0)";
            Input.Add(input);
        }

        Output.Clear();
        foreach (var (socketNameId, socketName) in OutputSocketNames)
        {
            var sockets = _castedData.OutputSockets
                .Where(x => x.Stamp.Name == socketNameId)
                .OrderBy(x => (ushort)x.Stamp.Ordinal)
                .ToList();

            if (sockets.Count > 0)
            {
                foreach (var socket in sockets)
                {
                    // Only add ordinal suffix for choice options (socketNameId == 0) or if there are multiple of the same type
                    var baseName = (socketNameId == 0 || sockets.Count > 1) ? $"({socketName}_{socket.Stamp.Ordinal + 1})" : socketName;
                    
                    if (socketNameId == 0 && socket.Stamp.Ordinal < Options.Count)
                    {
                        baseName += $" {Options[socket.Stamp.Ordinal]}";
                    }

                    var nameAndTitle = $"({socket.Stamp.Name},{socket.Stamp.Ordinal})";
                    var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socket.Stamp.Name, socket.Stamp.Ordinal, socket);
                    output.Subtitle = baseName;
                    Output.Add(output);
                    // Explicit subscription to guarantee property panel sync
                    SubscribeToSocketDestinations(output);
                }
            }
            else
            {
                // Virtual socket - only add ordinal for choice options (socketNameId == 0)
                var baseName = socketNameId == 0 ? $"({socketName}_1)" : socketName;
                var nameAndTitle = $"({socketNameId},0)";
                var output = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, socketNameId, 0);
                output.Subtitle = baseName;
                Output.Add(output);
                // Explicit subscription to guarantee property panel sync (even for virtual sockets)
                SubscribeToSocketDestinations(output);
            }
        }

        // Notify UI and mark document dirty
        NotifySocketsChanged();
    }

    private void GetChoices()
    {
        Options.Clear();
        
        for (var i = 0; i < _castedData.Options.Count; i++)
        {
            var option = _castedData.Options[i];
            string choiceText;

            // First, check if there's a meaningful caption set - prefer this over screenplay entries
            var hasMeaningfulCaption = option.Caption != CName.Empty && 
                                      !string.IsNullOrEmpty(option.Caption.GetResolvedText());

            if (hasMeaningfulCaption)
            {
                choiceText = option.Caption.GetResolvedText()!;
                Options.Add(choiceText);
                continue;
            }

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
                            choiceText = vpEntry.Content;
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

            // Final fallback to choice index and ID
            choiceText = $"Choice {i + 1} [ID:{option.ScreenplayOptionId.Id}]";
            Options.Add(choiceText);
        }
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
                        choiceText = vpEntry.Content;
                    }
                }
            }
        }
        catch
        {
            // Use fallback
        }

        // Create and insert the new connector at the correct position
        var nameAndTitle = $"({newOutputSocket.Stamp.Name},{newOutputSocket.Stamp.Ordinal})";
        var socketSubtitle = $"(Option_{newChoiceOrdinal + 1}) {choiceText}";
        var newConnector = new SceneOutputConnectorViewModel(nameAndTitle, nameAndTitle, UniqueId, newOutputSocket.Stamp.Name, newOutputSocket.Stamp.Ordinal, newOutputSocket);
        newConnector.Subtitle = socketSubtitle;
        Output.Insert(insertPosition, newConnector);

        // Note: Subscription to destination changes happens automatically via Output.CollectionChanged
        // Notify UI and mark document dirty
        NotifySocketsChanged();
        
        // Refresh the property panel to show the new screenplay/localization entries
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.MainGraph is RedGraph graph)
            {
                graph.RefreshSceneResourcePropertiesInTabs();
            }
        }
    }

    /// <summary>
    /// Removes the last choice option (if at least two exist) and associated socket/data.
    /// </summary>
    public void RemoveChoice()
    {
        if (_castedData.Options.Count <= 1)
            return;

        int lastIdx = _castedData.Options.Count - 1;
        var option = _castedData.Options[lastIdx];
        _castedData.Options.RemoveAt(lastIdx);

        // Remove screenplay option
        var spOpt = _sceneResource.ScreenplayStore.Options.FirstOrDefault(o => o.ItemId.Id == option.ScreenplayOptionId.Id);
        if (spOpt != null)
        {
            _sceneResource.ScreenplayStore.Options.Remove(spOpt);
            var vd = _sceneResource.LocStore.VdEntries.FirstOrDefault(v => v.LocstringId.Ruid == spOpt.LocstringId.Ruid);
            if (vd != null)
            {
                var vp = _sceneResource.LocStore.VpEntries.FirstOrDefault(p => p.VariantId.Ruid == vd.VariantId.Ruid);
                if (vp != null) _sceneResource.LocStore.VpEntries.Remove(vp);
                _sceneResource.LocStore.VdEntries.Remove(vd);
            }
        }

        // Remove corresponding socket (name 0 highest ordinal)
        var socket = _castedData.OutputSockets.Where(s => s.Stamp.Name == 0).OrderByDescending(s => s.Stamp.Ordinal).FirstOrDefault();
        if (socket != null && socket.Destinations.Count == 0)
        {
            int si = _castedData.OutputSockets.IndexOf(socket);
            if (si >= 0)
            {
                _castedData.OutputSockets.RemoveAt(si);
                if (si < Output.Count) Output.RemoveAt(si);
            }
        }

        NotifySocketsChanged();
        
        // Refresh the property panel to show the removed screenplay/localization entries
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.MainGraph is RedGraph graph)
            {
                graph.RefreshSceneResourcePropertiesInTabs();
            }
        }
    }
}