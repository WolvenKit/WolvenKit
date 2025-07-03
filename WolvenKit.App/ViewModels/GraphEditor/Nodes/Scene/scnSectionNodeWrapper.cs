using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using System.Linq;
using System.Collections.Generic;
using Splat;
using System;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnSectionNodeWrapper : BaseSceneViewModel<scnSectionNode>, IDynamicOutputNode
{
    private readonly scnSceneResource _sceneResource;
    private readonly ILoggerService? _logger = Locator.Current.GetService<ILoggerService>();
    
    public scnSectionNodeWrapper(scnSectionNode scnSectionNode, scnSceneResource scnSceneResource) : base(scnSectionNode)
    {
        _sceneResource = scnSceneResource;
        EnsureStandardSockets();
        PopulateDetailsInto(Details);
    }
    
    private void EnsureStandardSockets()
    {
        // Ensure standard output sockets exist
        bool hasOnEnd = false;
        bool hasOnCut = false;
        
        for (int i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            if (i == 0 && socket.Stamp.Name == 0 && socket.Stamp.Ordinal == 0)
                hasOnEnd = true;
            if (i == 1 && socket.Stamp.Name == 1 && socket.Stamp.Ordinal == 0)
                hasOnCut = true;
        }
        
        // Add missing standard sockets at the beginning
        if (!hasOnEnd)
        {
            _castedData.OutputSockets.Insert(0, new scnOutputSocket 
            { 
                Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = 0 } 
            });
        }
        
        if (!hasOnCut)
        {
            int cutIndex = hasOnEnd ? 1 : 0;
            _castedData.OutputSockets.Insert(cutIndex, new scnOutputSocket 
            { 
                Stamp = new scnOutputSocketStamp { Name = 1, Ordinal = 0 } 
            });
        }
    }

    public override void RefreshDetails()
    {
        // Build the details in a temporary dictionary first
        var tempDetails = new Dictionary<string, string>();
        
        // Now try to populate with real data
        try
        {
            PopulateDetailsInto(tempDetails);
        }
        catch (Exception ex)
        {
            var loggerService = Locator.Current.GetService<ILoggerService>();
            loggerService?.Error($"Error in PopulateDetails for node {UniqueId}: {ex.Message}");
            tempDetails["Error"] = ex.Message;
        }
        
        // Only set Details once it's fully populated to avoid race condition with UI trigger
        Details = tempDetails;
        
        // Force UI update by explicitly notifying about Details change
        OnPropertyChanged(nameof(Details));
        
        // Update title as well
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    private void PopulateDetailsInto(Dictionary<string, string> detailsDict)
    {        
        if (_castedData == null)
        {
            detailsDict["Error"] = "Data is null";
            return;
        }
        
        try
        {
            var duration = _castedData.SectionDuration.Stu;
            var strategy = _castedData.FfStrategy.ToEnumString();
            var eventCount = _castedData.Events.Count;
            
            detailsDict["Section Duration"] = duration + "ms";
            detailsDict["Ff Strategy"] = strategy;
            detailsDict["Events"] = eventCount.ToString();

            int counter = 1;
            foreach (var eventClass in _castedData.Events)
        {
            string evName = eventClass?.Chunk?.GetType().Name ?? "Undefined Event";
            string detailSuffix = "";

            switch (eventClass?.Chunk)
            {
                case scneventsSocket evSocket:
                    {
                        // Find the corresponding socket index to determine the event label
                        var socketName = evSocket.OsockStamp.Name;
                        var socketOrdinal = evSocket.OsockStamp.Ordinal;
                        
                        // Try to find the matching output socket to get the index
                        int socketIndex = -1;
                        for (int i = 0; i < _castedData.OutputSockets.Count; i++)
                        {
                            var outputSocket = _castedData.OutputSockets[i];
                            if (outputSocket.Stamp.Name == socketName && outputSocket.Stamp.Ordinal == socketOrdinal)
                            {
                                socketIndex = i;
                                break;
                            }
                        }
                        
                        // Generate the event label using the same logic as sockets
                        string eventLabel;
                        if (socketIndex >= 0)
                        {
                            eventLabel = GetSocketLabel(socketIndex, socketName, socketOrdinal);
                        }
                        else
                        {
                            // Fallback: use the helper method
                            eventLabel = GetEventLabel(socketName, socketOrdinal, socketIndex);
                        }
                        
                        detailSuffix = $" - {eventLabel} ({socketName},{socketOrdinal})";
                    }
                    break;
                case scnPlaySkAnimEvent playSkAnimEvent:
                    {
                            string performerName = ResolvePerformerName(playSkAnimEvent.Performer.Id, _sceneResource);
                        string animSuffix = "[No Anim]";

                        scnAnimName? animNameObj = null;
                        if (playSkAnimEvent.AnimName is CHandle<scnAnimName> handle)
                        {
                            animNameObj = handle.GetValue() as scnAnimName;
                        }
                        if (animNameObj != null && animNameObj.Unk1 != null && animNameObj.Unk1.Count > 0)
                        {
                            var animCName = animNameObj.Unk1[0];
                            if (animCName != CName.Empty)
                            {
                                string? animNameString = animCName.GetResolvedText();
                                if (!string.IsNullOrEmpty(animNameString))
                                {
                                    const int maxLen = 35;
                                    string displayAnimName = animNameString;
                                    if (displayAnimName.Length > maxLen)
                                    {
                                        displayAnimName = displayAnimName.Substring(0, maxLen) + "...";
                                    }
                                    animSuffix = displayAnimName;
                                }
                                else { animSuffix = "[unresolved]"; }
                            }
                        }
                        detailSuffix = $" ({performerName} - Anim: {animSuffix})";
                    }
                    break;
                case scnDialogLineEvent dialogLineEvent:
                    {
                        if (dialogLineEvent.ScreenplayLineId != null &&
                                _sceneResource?.LocStore != null &&
                                _sceneResource.LocStore.VdEntries != null &&
                                _sceneResource.LocStore.VpEntries != null)
                        {
                            CUInt32 screenplayId = dialogLineEvent.ScreenplayLineId.Id;
                                var screenplayLine = _sceneResource.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);

                            if (screenplayLine != null && screenplayLine.LocstringId != null)
                            {
                                CRUID locstringRuid = screenplayLine.LocstringId.Ruid;
                                string? dialogueText = null;
                                bool foundText = false;

                                var preferredLocaleId = WolvenKit.RED4.Types.Enums.scnlocLocaleId.db_db;
                                    var vdEntryPreferred = _sceneResource.LocStore.VdEntries.FirstOrDefault(vd => vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId == preferredLocaleId);

                                if (vdEntryPreferred != null && vdEntryPreferred.VariantId != null)
                                {
                                    CRUID targetVariantRuid = vdEntryPreferred.VariantId.Ruid;
                                        var vpEntry = _sceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == targetVariantRuid);
                                    if (vpEntry != null)
                                    {
                                        dialogueText = vpEntry.Content;
                                        if (!string.IsNullOrEmpty(dialogueText))
                                        {
                                            foundText = true;
                                        }
                                    }
                                }

                                if (!foundText)
                                {
                                        var vdEntryFallback = _sceneResource.LocStore.VdEntries.FirstOrDefault(vd => vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId != preferredLocaleId);
                                    if (vdEntryFallback != null && vdEntryFallback.VariantId != null)
                                    {
                                        CRUID fallbackVariantRuid = vdEntryFallback.VariantId.Ruid;
                                            var vpEntryFallback = _sceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == fallbackVariantRuid);
                                        if (vpEntryFallback != null)
                                        {
                                            dialogueText = vpEntryFallback.Content;
                                            if (!string.IsNullOrEmpty(dialogueText))
                                            {
                                                foundText = true;
                                            }
                                        }
                                    }
                                }

                                if (foundText && !string.IsNullOrEmpty(dialogueText))
                                {
                                    const int maxLen = 40;
                                    string displayDialogue = dialogueText;
                                    if (displayDialogue.Length > maxLen)
                                    {
                                        displayDialogue = displayDialogue.Substring(0, maxLen) + "...";
                                    }
                                    detailSuffix = $" (\"{displayDialogue}\")";
                                }
                                else
                                {
                                    detailSuffix = $" (RUID {locstringRuid} - empty)";
                                }
                            }
                            else
                            {
                                detailSuffix = $" (ID {screenplayId} - missing refs)";
                            }
                        }
                    }
                    break;
                case scnLookAtEvent lookAtEvent:
                    {
                            if (lookAtEvent.BasicData?.Basic != null && _sceneResource != null)
                        {
                            var basicLookAtData = lookAtEvent.BasicData.Basic;
                                string performerName = ResolvePerformerName(basicLookAtData.PerformerId.Id, _sceneResource);
                            string targetName = "UnknownTarget";

                            var targetTypeEnum = (WolvenKit.RED4.Types.Enums.scnLookAtTargetType)basicLookAtData.TargetType;
                            switch (targetTypeEnum)
                            {
                                case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Actor:
                                    // Use TargetPerformerId when TargetType is Actor
                                    if (basicLookAtData.TargetPerformerId != null)
                                    {
                                            targetName = ResolvePerformerName(basicLookAtData.TargetPerformerId.Id, _sceneResource);
                                    }
                                    else
                                    {
                                        targetName = "Performer: [Null ID]";
                                    }
                                    break;
                                case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Prop:
                                    if (basicLookAtData.TargetPropId != null)
                                    {
                                            var propDef = _sceneResource.Props?.FirstOrDefault(p => p.PropId?.Id == basicLookAtData.TargetPropId.Id);
                                        if (propDef != null)
                                        {
                                            targetName = $"Prop: {propDef.PropName} [{basicLookAtData.TargetPropId.Id}]";
                                        }
                                        else
                                        {
                                            targetName = $"Prop: Unknown [{basicLookAtData.TargetPropId.Id}]";
                                        }
                                    }
                                    else
                                    {
                                        targetName = "Prop: [Null ID]";
                                    }
                                    break;
                                default:
                                    // Check StaticTarget first (assuming non-default means it's used)
                                    if (basicLookAtData.StaticTarget.X != 0 || basicLookAtData.StaticTarget.Y != 0 || basicLookAtData.StaticTarget.Z != 0)
                                    {
                                        targetName = $"Position: ({basicLookAtData.StaticTarget.X:F1}, {basicLookAtData.StaticTarget.Y:F1}, {basicLookAtData.StaticTarget.Z:F1})";
                                    }
                                    // Then check TargetPerformerId
                                    else if (basicLookAtData.TargetPerformerId != null &&
                                       basicLookAtData.TargetPerformerId.Id != 4294967040)
                                    {
                                            targetName = ResolvePerformerName(basicLookAtData.TargetPerformerId.Id, _sceneResource);
                                        targetName += " (as Performer)";
                                    }
                                    // Then check TargetSlot
                                    else if (basicLookAtData.TargetSlot != CName.Empty)
                                    {
                                        targetName = $"Slot: {basicLookAtData.TargetSlot.GetResolvedText() ?? "?"}";
                                    }
                                    else
                                    {
                                        targetName = $"Unknown ({targetTypeEnum})";
                                    }
                                    break;
                            }
                            detailSuffix = $" ({performerName} -> {targetName})";
                        }
                    }
                    break;
                case scneventsVFXEvent vfxEvent:
                    {
                        string actionName = vfxEvent.Action.ToString();
                        string effectName = "[No Effect]";
                        if (vfxEvent.EffectEntry != null && vfxEvent.EffectEntry.EffectName != CName.Empty)
                        {
                            effectName = vfxEvent.EffectEntry.EffectName.GetResolvedText() ?? "[unresolved]";
                        }
                        detailSuffix = $" ({actionName}: {effectName})";
                    }
                    break;
                case scnChangeIdleAnimEvent idleAnimEvent:
                    {
                            string performerName = ResolvePerformerName(idleAnimEvent.Performer.Id, _sceneResource);
                        string idleAnim = "[None]";
                        if (idleAnimEvent.IdleAnimName != CName.Empty)
                        {
                            idleAnim = idleAnimEvent.IdleAnimName.GetResolvedText() ?? "[unresolved]";
                        }

                        string facialAnim = "[None]";
                        if (idleAnimEvent.BakedFacialTransition != null)
                        {
                            var facialCName = CName.Empty;
                            if (idleAnimEvent.BakedFacialTransition.ToIdleFemale != CName.Empty)
                            {
                                facialCName = idleAnimEvent.BakedFacialTransition.ToIdleFemale;
                            }
                            else if (idleAnimEvent.BakedFacialTransition.ToIdleMale != CName.Empty)
                            {
                                facialCName = idleAnimEvent.BakedFacialTransition.ToIdleMale;
                            }

                            if (facialCName != CName.Empty)
                            {
                                facialAnim = facialCName.GetResolvedText() ?? "[unresolved]";
                            }
                        }

                        var suffixParts = new List<string>();
                        if (idleAnim != "[None]") suffixParts.Add($"Idle: {idleAnim}");
                        if (facialAnim != "[None]") suffixParts.Add($"Face: {facialAnim}");

                        if (suffixParts.Count > 0)
                        {
                            detailSuffix = $" ({performerName} - {string.Join(", ", suffixParts)})";
                        }
                        else
                        {
                            detailSuffix = $" ({performerName})";
                        }
                    }
                    break;
                case scnIKEvent ikEvent:
                    {
                        string performerName = "[No Performer]";
                            if (ikEvent.IkData?.Basic?.PerformerId != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(ikEvent.IkData.Basic.PerformerId.Id, _sceneResource);
                        }

                        string chainName = "[No Chain]";
                        if (ikEvent.IkData?.ChainName != null && ikEvent.IkData.ChainName != CName.Empty)
                        {
                            chainName = ikEvent.IkData.ChainName.GetResolvedText() ?? "[unresolved]";
                        }

                        detailSuffix = $" ({performerName} - Chain: {chainName})";
                    }
                    break;
                case scneventsAttachPropToPerformer attachEvent:
                    {
                        string propName = "[No Prop]";
                            if (attachEvent.PropId != null && _sceneResource?.Props != null)
                        {
                                var propDef = _sceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachEvent.PropId.Id);
                            if (propDef != null)
                            {
                                string? pName = propDef.PropName;
                                propName = pName ?? "Unnamed";
                            }
                            else
                            {
                                propName = $"Unknown [{attachEvent.PropId.Id}]";
                            }
                        }

                        string performerName = "[No Performer]";
                            if (attachEvent.PerformerId != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(attachEvent.PerformerId.Id, _sceneResource);
                        }

                        string slotName = "[No Slot]";
                        if (attachEvent.Slot != CName.Empty)
                        {
                            slotName = attachEvent.Slot.GetResolvedText() ?? "[unresolved]";
                        }

                        detailSuffix = $" (Prop: {propName} -> Performer: {performerName} at Slot: {slotName})";
                    }
                    break;
                case scneventsAttachPropToWorld attachWorldEvent:
                    {
                        string propName = "[No Prop]";
                            if (attachWorldEvent.PropId != null && _sceneResource?.Props != null)
                        {
                                var propDef = _sceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachWorldEvent.PropId.Id);
                            if (propDef != null)
                            {
                                string? pName = propDef.PropName;
                                propName = pName ?? "Unnamed";
                            }
                            else
                            {
                                propName = $"Unknown [{attachWorldEvent.PropId.Id}]";
                            }
                        }
                        detailSuffix = $" (Prop: {propName} -> World)";
                    }
                    break;
                case scneventsAttachPropToNode attachNodeEvent:
                    {
                        string propName = "[No Prop]";
                            if (attachNodeEvent.PropId != null && _sceneResource?.Props != null)
                        {
                                var propDef = _sceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachNodeEvent.PropId.Id);
                            if (propDef != null)
                            {
                                string? pName = propDef.PropName;
                                propName = pName ?? "Unnamed";
                            }
                            else
                            {
                                propName = $"Unknown [{attachNodeEvent.PropId.Id}]";
                            }
                        }
                        string nodeRef = attachNodeEvent.NodeRef != NodeRef.Empty
                                         ? attachNodeEvent.NodeRef.GetRedHash().ToString("X")
                                         : "[No Node]";
                        detailSuffix = $" (Prop: {propName} -> Node: {nodeRef})";
                    }
                    break;
                case scneventsEquipItemToPerformer equipEvent:
                    {
                        string performerName = "[No Performer]";
                            if (equipEvent.PerformerId != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(equipEvent.PerformerId.Id, _sceneResource);
                        }

                        string itemName = "[No Item]";
                        if (equipEvent.ItemId != TweakDBID.Empty)
                        {
                            itemName = equipEvent.ItemId.GetResolvedText() ?? "[unresolved]";
                        }

                        string slotName = "[No Slot]";
                        if (equipEvent.SlotId != TweakDBID.Empty)
                        {
                            slotName = equipEvent.SlotId.GetResolvedText() ?? "[unresolved]";
                        }

                        detailSuffix = $" (Performer: {performerName}, Item: {itemName}, Slot: {slotName})";
                    }
                    break;
                case scnAudioEvent audioEvent:
                    {
                        string performerName = "[No Performer]";
                            if (audioEvent.Performer != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(audioEvent.Performer.Id, _sceneResource);
                        }

                        string audioName = "[No Audio Name]";
                        if (audioEvent.AudioEventName != CName.Empty)
                        {
                            audioName = audioEvent.AudioEventName.GetResolvedText() ?? "[unresolved]";
                        }

                        detailSuffix = $" ({performerName} - Audio: {audioName})";
                    }
                    break;
                case scnGameplayTransitionEvent gameplayTransitionEvent:
                    {
                        string performerName = "[No Performer]";
                            if (gameplayTransitionEvent.Performer != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(gameplayTransitionEvent.Performer.Id, _sceneResource);
                        }

                        string vehState = gameplayTransitionEvent.VehState.ToEnumString();

                        detailSuffix = $" ({performerName} - VehState: {vehState})";
                    }
                    break;
                case scneventsSetAnimFeatureEvent setAnimFeatureEvent:
                    {
                        string actorName = "[No Actor]";
                            if (setAnimFeatureEvent.ActorId != null && _sceneResource != null)
                        {
                                actorName = ResolvePerformerName(setAnimFeatureEvent.ActorId.Id, _sceneResource);
                        }

                        string featureName = "[No Feature Name]";
                        if (setAnimFeatureEvent.AnimFeatureName != CName.Empty)
                        {
                            featureName = setAnimFeatureEvent.AnimFeatureName.GetResolvedText() ?? "[unresolved]";
                        }

                        string featureType = "[No Feature Type]";
                        if (setAnimFeatureEvent.AnimFeature is CHandle<animAnimFeature> handle)
                        {
                           var featureInstance = handle.GetValue() as animAnimFeature;
                           if (featureInstance != null)
                           {
                               featureType = featureInstance.GetType().Name;
                           }
                           else
                           {
                               featureType = "[Invalid Handle]";
                           }
                        }
                        else if (setAnimFeatureEvent.AnimFeature != null)
                        {
                           featureType = setAnimFeatureEvent.AnimFeature.GetType().Name;
                        }

                        detailSuffix = $" ({actorName} - {featureType}: {featureName})";
                    }
                    break;
                 case scnUnmountEvent unmountEvent:
                    {
                        string performerName = "[No Performer]";
                            if (unmountEvent.Performer != null && _sceneResource != null)
                        {
                                performerName = ResolvePerformerName(unmountEvent.Performer.Id, _sceneResource);
                        }
                        detailSuffix = $" ({performerName})";
                    }
                    break;
                default:
                    break;
            }

            string fullEventName = evName + detailSuffix;

                detailsDict["#" + counter.ToString() + " " + eventClass?.Chunk?.StartTime.ToString() + "ms"] = fullEventName;
            counter++;
        }

            // Notable point information is now handled by the base class
        }
        catch (Exception ex)
        {
            detailsDict["Error"] = ex.Message;
        }
    }

    // Helper method to resolve performer IDs to names using index encoding
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
                 return $"{playerName} [ID:0]";
             }
             var actorDefZero = sceneResource?.Actors?.FirstOrDefault(a => a.ActorId?.Id == 0);
             if(actorDefZero != null)
             {
                 string? actorName = actorDefZero.ActorName;
                 return $"{actorName ?? "Unnamed"} [ID:0]";
             }
             return "Player? [ID:0]";
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

        internal override void GenerateSockets()
    {        
        Input.Clear();
        var mainInput = new SceneInputConnectorViewModel("In", "In", UniqueId, 0, 0);
        mainInput.Subtitle = "(0,0)";
        Input.Add(mainInput);
        
        var cancelInput = new SceneInputConnectorViewModel("Cancel", "Cancel", UniqueId, 1, 0);
        cancelInput.Subtitle = "(1,0)";
        Input.Add(cancelInput);

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var socket = _castedData.OutputSockets[i];
            var label = GetSocketLabel(i, socket.Stamp.Name, socket.Stamp.Ordinal);
            var connectorVM = new SceneOutputConnectorViewModel($"({socket.Stamp.Name},{socket.Stamp.Ordinal})", $"({socket.Stamp.Name},{socket.Stamp.Ordinal})", UniqueId, socket);
            connectorVM.Subtitle = label;
            Output.Add(connectorVM);
            // Subscribe to destination changes so property panel shows connection counts
            SubscribeToSocketDestinations(connectorVM);
        }
    }
    
    private string GetSocketLabel(int index, ushort name, ushort ordinal)
    {
        if (index == 0) return "OnEnd";
        if (index == 1) return "OnCancel";
        
        // For event sockets, show just the event number (coordinates now in subtitle)
        int eventNumber;
        
        // Detect which pattern for correct Event number
        if (name == index && ordinal == 0)
        {
            eventNumber = index - 2;  // Direct: Event0, Event1...
        } 
        else if (name == 2)
        {
            eventNumber = ordinal;     // Ordinal: Event0, Event1...
        }
        else
        {
            // Edge case - show with Event_N_O format
            return $"Event_{name}_{ordinal}";
        }

        return $"Event{eventNumber}";
    }

    /// <summary>
    /// Helper method to get event label using the same logic as socket labels
    /// </summary>
    private string GetEventLabel(ushort name, ushort ordinal, int index)
    {
        // Use the same logic as GetSocketLabel for consistency
        if (name == index && ordinal == 0)
        {
            int eventNumber = index - 2;  // Direct pattern
            return $"Event{eventNumber}";
        } 
        else if (name == 2)
        {
            return $"Event{ordinal}";     // Ordinal pattern
        }
        else
        {
            return $"Event_{name}_{ordinal}"; // Edge case with Event_N_O format
        }
    }

    public BaseConnectorViewModel AddOutput()
    {
        // Auto-detect and continue existing pattern
        var existingSockets = _castedData.OutputSockets.Where((s, index) => index >= 2); // Skip fixed sockets (OnEnd, OnCut)
        bool hasOrdinal = existingSockets.Any(s => s.Stamp.Name == 2 && s.Stamp.Ordinal > 0);

        int newIndex = _castedData.OutputSockets.Count;
        ushort newName, newOrdinal;

        if (hasOrdinal)
        {
            // Continue ordinal pattern
            newName = 2;
            newOrdinal = (ushort)(newIndex - 2);
        }
        else
        {
            // Continue/start direct pattern (default for new nodes)
            newName = (ushort)newIndex;
            newOrdinal = 0;
        }

        // Create the new output socket
        var outputSocket = new scnOutputSocket 
        { 
            Stamp = new scnOutputSocketStamp 
            { 
                Name = newName, 
                Ordinal = newOrdinal 
            } 
        };

        _castedData.OutputSockets.Add(outputSocket);

        // Create label using our new method
        var label = GetSocketLabel(newIndex, newName, newOrdinal);
        var output = new SceneOutputConnectorViewModel($"({newName},{newOrdinal})", $"({newName},{newOrdinal})", UniqueId, outputSocket);
        output.Subtitle = label;
        Output.Add(output);

        // Note: Subscription to destination changes happens automatically via Output.CollectionChanged
        // Notify UI and mark document dirty
        NotifySocketsChanged();

        return output;
    }

    public void RemoveOutput()
    {        
        if (_castedData.OutputSockets.Count > 2) // Keep at least OnEnd and OnCut
        {
            var lastSocket = _castedData.OutputSockets[^1];
            
            // Only remove if it has no connections
            if (lastSocket.Destinations.Count == 0)
            {
                _castedData.OutputSockets.RemoveAt(_castedData.OutputSockets.Count - 1);
                Output.RemoveAt(Output.Count - 1);
                                
                // Notify UI and mark document dirty
                NotifySocketsChanged();
            }
        }
    }
}