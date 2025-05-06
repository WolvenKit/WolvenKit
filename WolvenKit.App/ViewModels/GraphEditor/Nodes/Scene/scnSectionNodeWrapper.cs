using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;
using System.Linq;
using System.Collections.Generic;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnSectionNodeWrapper : BaseSceneViewModel<scnSectionNode>
{
    public scnSectionNodeWrapper(scnSectionNode scnSectionNode, scnSceneResource scnSceneResource) : base(scnSectionNode)
    {
        Details["Section Duration"] = scnSectionNode.SectionDuration.Stu.ToString() + "ms";
        Details["Ff Strategy"] = scnSectionNode.FfStrategy.ToEnumString();

        var events = scnSectionNode.Events;
        Details["Events"] = events.Count.ToString();

        int counter = 1;
        foreach (var eventClass in events)
        {
            string evName = eventClass?.Chunk?.GetType().Name ?? "UnknownEvent";
            string detailSuffix = "";

            switch (eventClass?.Chunk)
            {
                case scneventsSocket evSocket:
                    detailSuffix = " - Name: " + evSocket.OsockStamp.Name.ToString() + ", Ordinal: " + evSocket.OsockStamp.Ordinal.ToString();
                    break;
                case scnPlaySkAnimEvent playSkAnimEvent:
                    {
                        string performerName = ResolvePerformerName(playSkAnimEvent.Performer.Id, scnSceneResource);
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
                            scnSceneResource?.LocStore != null &&
                            scnSceneResource.LocStore.VdEntries != null &&
                            scnSceneResource.LocStore.VpEntries != null)
                        {
                            CUInt32 screenplayId = dialogLineEvent.ScreenplayLineId.Id;
                            var screenplayLine = scnSceneResource.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);

                            if (screenplayLine != null && screenplayLine.LocstringId != null)
                            {
                                CRUID locstringRuid = screenplayLine.LocstringId.Ruid;
                                string? dialogueText = null;
                                bool foundText = false;

                                var preferredLocaleId = WolvenKit.RED4.Types.Enums.scnlocLocaleId.db_db;
                                var vdEntryPreferred = scnSceneResource.LocStore.VdEntries.FirstOrDefault(vd => vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId == preferredLocaleId);

                                if (vdEntryPreferred != null && vdEntryPreferred.VariantId != null)
                                {
                                    CRUID targetVariantRuid = vdEntryPreferred.VariantId.Ruid;
                                    var vpEntry = scnSceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == targetVariantRuid);
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
                                    var vdEntryFallback = scnSceneResource.LocStore.VdEntries.FirstOrDefault(vd => vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId != preferredLocaleId);
                                    if (vdEntryFallback != null && vdEntryFallback.VariantId != null)
                                    {
                                        CRUID fallbackVariantRuid = vdEntryFallback.VariantId.Ruid;
                                        var vpEntryFallback = scnSceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == fallbackVariantRuid);
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
                        if (lookAtEvent.BasicData?.Basic != null && scnSceneResource != null)
                        {
                            var basicLookAtData = lookAtEvent.BasicData.Basic;
                            string performerName = ResolvePerformerName(basicLookAtData.PerformerId.Id, scnSceneResource);
                            string targetName = "UnknownTarget";

                            var targetTypeEnum = (WolvenKit.RED4.Types.Enums.scnLookAtTargetType)basicLookAtData.TargetType;
                            switch (targetTypeEnum)
                            {
                                case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Actor:
                                    // Use TargetPerformerId when TargetType is Actor
                                    if (basicLookAtData.TargetPerformerId != null)
                                    {
                                        targetName = ResolvePerformerName(basicLookAtData.TargetPerformerId.Id, scnSceneResource);
                                    }
                                    else
                                    {
                                        targetName = "Performer: [Null ID]";
                                    }
                                    break;
                                case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Prop:
                                    if (basicLookAtData.TargetPropId != null)
                                    {
                                        var propDef = scnSceneResource.Props?.FirstOrDefault(p => p.PropId?.Id == basicLookAtData.TargetPropId.Id);
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
                                        targetName = ResolvePerformerName(basicLookAtData.TargetPerformerId.Id, scnSceneResource);
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
                        string performerName = ResolvePerformerName(idleAnimEvent.Performer.Id, scnSceneResource);
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
                        if (ikEvent.IkData?.Basic?.PerformerId != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(ikEvent.IkData.Basic.PerformerId.Id, scnSceneResource);
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
                        if (attachEvent.PropId != null && scnSceneResource?.Props != null)
                        {
                            var propDef = scnSceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachEvent.PropId.Id);
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
                        if (attachEvent.PerformerId != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(attachEvent.PerformerId.Id, scnSceneResource);
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
                        if (attachWorldEvent.PropId != null && scnSceneResource?.Props != null)
                        {
                            var propDef = scnSceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachWorldEvent.PropId.Id);
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
                        if (attachNodeEvent.PropId != null && scnSceneResource?.Props != null)
                        {
                            var propDef = scnSceneResource.Props.FirstOrDefault(p => p.PropId?.Id == attachNodeEvent.PropId.Id);
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
                        if (equipEvent.PerformerId != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(equipEvent.PerformerId.Id, scnSceneResource);
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
                        if (audioEvent.Performer != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(audioEvent.Performer.Id, scnSceneResource);
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
                        if (gameplayTransitionEvent.Performer != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(gameplayTransitionEvent.Performer.Id, scnSceneResource);
                        }

                        string vehState = gameplayTransitionEvent.VehState.ToEnumString();

                        detailSuffix = $" ({performerName} - VehState: {vehState})";
                    }
                    break;
                case scneventsSetAnimFeatureEvent setAnimFeatureEvent:
                    {
                        string actorName = "[No Actor]";
                        if (setAnimFeatureEvent.ActorId != null && scnSceneResource != null)
                        {
                            actorName = ResolvePerformerName(setAnimFeatureEvent.ActorId.Id, scnSceneResource);
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
                        if (unmountEvent.Performer != null && scnSceneResource != null)
                        {
                            performerName = ResolvePerformerName(unmountEvent.Performer.Id, scnSceneResource);
                        }
                        detailSuffix = $" ({performerName})";
                    }
                    break;
                default:
                    break;
            }

            string fullEventName = evName + detailSuffix;

            Details["#" + counter.ToString() + " " + eventClass?.Chunk?.StartTime.ToString() + "ms"] = fullEventName;
            counter++;
        }

        if (scnSceneResource != null)
        {
        Title += NodeProperties.SetNameFromNotablePoints(scnSectionNode.NodeId.Id, scnSceneResource);
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
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var title = $"Out{i} - Name: " + _castedData.OutputSockets[i].Stamp.Name + ", Ordinal: " + _castedData.OutputSockets[i].Stamp.Ordinal;
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, _castedData.OutputSockets[i]));
        }
    }
}