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

            if (eventClass?.Chunk is scneventsSocket evSocket)
            {
                detailSuffix = " - Name: " + evSocket.OsockStamp.Name.ToString() + ", Ordinal: " + evSocket.OsockStamp.Ordinal.ToString();
            }
            else if (eventClass?.Chunk is scnPlaySkAnimEvent playSkAnimEvent)
            {
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
                            detailSuffix = $" ({displayAnimName})";
                        }
                        else { detailSuffix = " ([unresolved animName])"; }
                    }
                }
            }
            else if (eventClass?.Chunk is scnDialogLineEvent dialogLineEvent)
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
            else if (eventClass?.Chunk is scnLookAtEvent lookAtEvent)
            {
                if (lookAtEvent.BasicData?.Basic != null && scnSceneResource != null)
                {
                    var basicLookAtData = lookAtEvent.BasicData.Basic;
                    string performerName = ResolvePerformerName(basicLookAtData.PerformerId.Id, scnSceneResource);
                    string targetName = "UnknownTarget";

                    var targetTypeEnum = (Enums.scnLookAtTargetType)basicLookAtData.TargetType;
                    switch (targetTypeEnum) 
                    {
                        case Enums.scnLookAtTargetType.Actor:
                            // Use TargetPerformerId when TargetType is Actor
                            if (basicLookAtData.TargetPerformerId != null)
                            {
                                targetName = ResolvePerformerName(basicLookAtData.TargetPerformerId.Id, scnSceneResource);
                            }
                            else
                            {
                                targetName = "Performer: [Null ID]"; // Fallback if TargetPerformerId is null
                            }
                            break;
                        case Enums.scnLookAtTargetType.Prop:
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
                             // Final fallback
                             else
                             {
                                 targetName = $"Unknown ({targetTypeEnum})";
                             }
                             break;
                    }
                    detailSuffix = $" ({performerName} -> {targetName})";
                }
            }
            else if (eventClass?.Chunk is scneventsVFXEvent vfxEvent)
            {
                string actionName = vfxEvent.Action.ToString(); // Get enum string representation
                string effectName = "[No Effect]";
                if (vfxEvent.EffectEntry != null && vfxEvent.EffectEntry.EffectName != CName.Empty)
                {
                    effectName = vfxEvent.EffectEntry.EffectName.GetResolvedText() ?? "[unresolved]";
                }
                detailSuffix = $" ({actionName}: {effectName})";
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

    // Helper method to resolve performer IDs to names using BITMASK encoding
    private string ResolvePerformerName(CUInt32 performerIdCUint32, scnSceneResource sceneResource)
    {
        uint performerId = performerIdCUint32; // Implicit conversion

        // Handle potential 'None' or special values
        if (performerId == uint.MaxValue || performerId == 4294967040 || performerId == 0) return "None [0]";

        var names = new List<string>();
        for (int actorIndex = 0; actorIndex < 16; actorIndex++) // Check up to 16 actors
        {
            if (((performerId >> actorIndex) & 1) == 1)
            {
                string resolvedName = $"Idx {actorIndex}?";

                if (sceneResource?.Actors != null && actorIndex < sceneResource.Actors.Count)
                {
                     var actorDef = sceneResource.Actors[actorIndex];
                     if (actorDef != null)
                     {
                         var playerActorDef = sceneResource.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == actorDef.ActorId?.Id);
                         if(playerActorDef != null)
                         {
                             string playerName = playerActorDef.PlayerName;
                             string? playerNameStr = playerName;
                             if (string.IsNullOrEmpty(playerNameStr)) playerNameStr = "Player";
                             resolvedName = $"{playerNameStr} [{actorIndex}]";
                         }
                         else
                         {
                             string actorName = actorDef.ActorName;
                             string? actorNameStr = actorName;
                             resolvedName = $"{actorNameStr ?? "Unnamed"} [{actorIndex}]";
                         }
                     }
                     else
                     {
                          resolvedName = $"Idx {actorIndex} (Null Def)";
                     }
                }
                 names.Add(resolvedName);
            }
        }

        if (names.Count > 0)
        {
            string joinedNames = string.Join(", ", names);
            const int maxTotalLen = 50;
            if (joinedNames.Length > maxTotalLen)
            {
                joinedNames = joinedNames.Substring(0, maxTotalLen) + "...";
            }
            return joinedNames;
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