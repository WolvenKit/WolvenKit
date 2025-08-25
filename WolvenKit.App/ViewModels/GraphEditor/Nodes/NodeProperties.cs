using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Splat;
using WolvenKit.App.Extensions;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes;

internal static class DictionaryExtensions
{
    public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> other)
        where TKey : notnull
    {
        foreach (var kvp in other)
        {
            dictionary[kvp.Key] = kvp.Value;
        }
    }
}

internal class NodeProperties
{
    public static Dictionary<string, string> GetPropertiesFor(questNodeDefinition? node, scnSceneResource? scnSceneResource = null)
    {
        Dictionary<string, string> details = new();

        details["Type"] = GetNameFromClass(node);

        var settingsManager = Locator.Current.GetService<ISettingsManager>();
        if (settingsManager != null && !settingsManager.ShowGraphEditorNodeProperties)
        {
            return details;
        }

        // Try curated properties first (existing manual logic)
        var hasCuratedProperties = TryGetCuratedProperties(node, details, scnSceneResource);
        
        // Always try smart discovery to supplement curated properties (if we have room)
        if (details.Count < 8) // Only add smart properties if we have room
        {
            var autoDiscovered = GetSmartAutoDiscoveredProperties(node);
            
            // Add smart properties that aren't already covered (check both key and value to avoid duplicates)
            foreach (var kvp in autoDiscovered)
            {
                if (!details.ContainsKey(kvp.Key) && 
                    !IsValueAlreadyPresent(details, kvp.Value) && 
                    details.Count < 8)
                {
                    details[kvp.Key] = kvp.Value;
                }
            }
        }
        
        return LimitAndPrioritizeProperties(details);
    }

    // Expose legacy condition property listing for fallbacks when semantic formatting is too generic
    public static Dictionary<string, string> GetLegacyConditionProperties(questIBaseCondition? condition)
    {
        var raw = GetPropertiesForConditions(condition);
        return LimitAndPrioritizeProperties(raw);
    }

    private static bool IsValueAlreadyPresent(Dictionary<string, string> details, string value)
    {
        // Check if any existing property has the same value to avoid duplicates
        return details.Values.Any(existingValue => string.Equals(existingValue, value, StringComparison.OrdinalIgnoreCase));
    }

    private static bool TryGetCuratedProperties(questNodeDefinition? node, Dictionary<string, string> details, scnSceneResource? scnSceneResource = null)
    {
        if (node == null) return false;

        var initialCount = details.Count;

        if (node is questPauseConditionNodeDefinition pauseCondCasted)
        {
            // Use semantic condition display for better readability
            var semanticDetails = QuestConditionHelper.GetSemanticConditionDisplay(pauseCondCasted?.Condition?.Chunk);
            details.AddRange(semanticDetails);
        }
        else if (node is questConditionNodeDefinition condCasted)
        {
            // Use semantic condition display for better readability
            var semanticDetails = QuestConditionHelper.GetSemanticConditionDisplay(condCasted?.Condition?.Chunk);
            details.AddRange(semanticDetails);
        }
        else if (node is questSwitchNodeDefinition switchCasted)
        {
            // Show total conditions count right after the type
            details["Total Cases"] = switchCasted.Conditions.Count.ToString();
            
            var conditionsToShow = switchCasted.Conditions.Take(8).ToList();
            foreach (var cond in conditionsToShow)
            {
                var socketPrefix = $"Case {cond?.SocketId}";
                var semanticDetails = QuestConditionHelper.GetSemanticConditionDisplay(cond?.Condition?.Chunk);
                foreach (var kvp in semanticDetails)
                {
                    details[$"{socketPrefix} {kvp.Key}"] = kvp.Value;
                }
            }
        }
        else if (node is questFactsDBManagerNodeDefinition factDBManagerCasted)
        {
            if (factDBManagerCasted?.Type?.Chunk is questSetVar_NodeType setVarCasted)
            {
                details["Fact Name"] = setVarCasted?.FactName ?? "";
                details["Set Exact Value"] = setVarCasted?.SetExactValue == true ? "True" : "False";
                details["Value"] = setVarCasted?.Value.ToString() ?? "";
            }
        }
        else if (node is questJournalNodeDefinition journalNodeCasted)
        {
            details["Manager"] = GetNameFromClass(journalNodeCasted?.Type?.Chunk);

            if (journalNodeCasted?.Type?.Chunk is questJournalQuestEntry_NodeType journalQuestEntryCasted)
            {
                details.AddRange(ParseJournalPath(journalQuestEntryCasted?.Path?.Chunk));

                details["Send Notification"] = journalQuestEntryCasted?.SendNotification == true ? "True" : "False";
                details["Track Quest"] = journalQuestEntryCasted?.TrackQuest == true ? "True" : "False";
                details["Version"] = journalQuestEntryCasted?.Version.ToEnumString()!;
            }
            if (journalNodeCasted?.Type?.Chunk is questJournalEntry_NodeType journalEntryCasted)
            {
                details.AddRange(ParseJournalPath(journalEntryCasted?.Path?.Chunk));

                details["Send Notification"] = journalEntryCasted?.SendNotification == true ? "True" : "False";
            }
            if (journalNodeCasted?.Type?.Chunk is questJournalBulkUpdate_NodeType journalBulkUpdateCasted)
            {
                details["New Entry State"] = journalBulkUpdateCasted?.NewEntryState.ToString()!;
                details.AddRange(ParseJournalPath(journalBulkUpdateCasted?.Path?.Chunk));
                details["Propagate Change"] = journalBulkUpdateCasted?.PropagateChange == true ? "True" : "False";
                details["Required Entry State"] = journalBulkUpdateCasted?.RequiredEntryState.ToString()!;
                details["Required Entry Type"] = journalBulkUpdateCasted?.RequiredEntryType.ToString()!;
                details["Send Notification"] = journalBulkUpdateCasted?.SendNotification == true ? "True" : "False";
            }
        }
        else if (node is questUseWorkspotNodeDefinition useWorkspotNodeCasted)
        {
            details["Entity Reference"] = ParseGameEntityReference(useWorkspotNodeCasted?.EntityReference);

            if (useWorkspotNodeCasted?.ParamsV1?.Chunk is scnUseSceneWorkspotParamsV1 useSceneWorkspotCasted)
            {
                details["Entry Id"] = useSceneWorkspotCasted?.EntryId?.Id.ToString()!;
                details["Exit Entry Id"] = useSceneWorkspotCasted?.ExitEntryId?.Id.ToString()!;
                details["Workspot Instance Id"] = useSceneWorkspotCasted?.WorkspotInstanceId?.Id.ToString()!;
                details["Workspot Name"] = GetWorkspotPath(useSceneWorkspotCasted?.WorkspotInstanceId?.Id, scnSceneResource);
            }
            else if (useWorkspotNodeCasted?.ParamsV1?.Chunk is questUseWorkspotParamsV1 useWorkspotCasted)
            {
                details["Entry Id"] = useWorkspotCasted?.EntryId?.Id.ToString()!;
                details["Exit Entry Id"] = useWorkspotCasted?.ExitEntryId?.Id.ToString()!;
                details["Workspot Node"] = useWorkspotCasted?.WorkspotNode.GetResolvedText()!;
            }
        }
        else if (node is questSceneManagerNodeDefinition sceneManagerNodeCasted)
        {
            details["Manager"] = GetNameFromClass(sceneManagerNodeCasted?.Type?.Chunk);

            if (sceneManagerNodeCasted?.Type?.Chunk is questSetTier_NodeType setTierCasted)
            {
                details["Force Empty Hands"] = setTierCasted?.ForceEmptyHands == true ? "True" : "False";
                details["Tier"] = setTierCasted?.Tier.ToEnumString()!;
            }
            if (sceneManagerNodeCasted?.Type?.Chunk is questCameraClippingPlane_NodeType cameraClippingCasted)
            {
                details["Preset"] = cameraClippingCasted?.Preset.ToEnumString()!;
            }
        }
        else if (node is questTimeManagerNodeDefinition timeManagerNodeCasted)
        {
            details["Manager"] = GetNameFromClass(timeManagerNodeCasted?.Type?.Chunk);

            if (timeManagerNodeCasted?.Type?.Chunk is questPauseTime_NodeType pauseTimeCasted)
            {
                details["Pause"] = pauseTimeCasted?.Pause == true ? "True" : "False";
                details["Source"] = pauseTimeCasted?.Source.ToString()!;
            }
            if (timeManagerNodeCasted?.Type?.Chunk is questSetTime_NodeType setTimeCasted)
            {
                details["Hours"] = setTimeCasted?.Hours.ToString()!;
                details["Minutes"] = setTimeCasted?.Minutes.ToString()!;
                details["Seconds"] = setTimeCasted?.Seconds.ToString()!;
                details["Source"] = setTimeCasted?.Source.ToString()!;
            }
        }
        else if (node is questAudioNodeDefinition audioNodeCasted)
        {
            details["Manager"] = GetNameFromClass(audioNodeCasted?.Type?.Chunk);

            if (audioNodeCasted?.Type?.Chunk is questAudioMixNodeType audioMixCasted)
            {
                details["Mix Signpost"] = audioMixCasted?.MixSignpost.ToString()!;
            }
            if (audioNodeCasted?.Type?.Chunk is questAudioEventNodeType audioEventCasted)
            {
                details["Ambient Unique Name"] = audioEventCasted?.AmbientUniqueName.ToString()!;

                var dynamicParams = "";
                if (audioEventCasted?.DynamicParams != null)
                {
                    foreach (var p in audioEventCasted.DynamicParams)
                    {
                        dynamicParams += (dynamicParams != "" ? ", " : "") + p.ToString()!;
                    }
                }
                details["Dynamic Params"] = dynamicParams;

                details["Emitter"] = audioEventCasted?.Emitter.ToString()!;
                details["Event"] = audioEventCasted?.Event.Event.GetResolvedText()!;

                var events = "";
                if (audioEventCasted?.Events != null)
                {
                    foreach (var p in audioEventCasted.Events)
                    {
                        events += (events != "" ? ", " : "") + p.Event.GetResolvedText()!;
                    }
                }
                details["Events"] = events;

                details["Is Music"] = audioEventCasted?.IsMusic == true ? "True" : "False";
                details["Is Player"] = audioEventCasted?.IsPlayer == true ? "True" : "False";

                var musicEvents = "";
                if (audioEventCasted?.MusicEvents != null)
                {
                    foreach (var p in audioEventCasted.MusicEvents)
                    {
                        musicEvents += (musicEvents != "" ? ", " : "") + p.Event.GetResolvedText()!;
                    }
                }
                details["Music Events"] = musicEvents;

                details["Object Ref"] = ParseGameEntityReference(audioEventCasted?.ObjectRef);

                var paramsStr = "";
                if (audioEventCasted?.Params != null)
                {
                    foreach (var p in audioEventCasted.Params)
                    {
                        paramsStr += (paramsStr != "" ? ", " : "") + p.Name.ToString()!;
                    }
                }
                details["Params"] = paramsStr;

                var switches = "";
                if (audioEventCasted?.Switches != null)
                {
                    foreach (var p in audioEventCasted.Switches)
                    {
                        switches += (switches != "" ? ", " : "") + p.Name.ToString()!;
                    }
                }
                details["Switches"] = switches;
            }
            if (audioNodeCasted?.Type?.Chunk is questAudioSwitchNodeType audioSwitchCasted)
            {
                details["Is Music"] = audioSwitchCasted?.IsMusic == true ? "True" : "False";
                details["Is Player"] = audioSwitchCasted?.IsPlayer == true ? "True" : "False";
                details["Object Ref"] = ParseGameEntityReference(audioSwitchCasted?.ObjectRef);
                details["Switch Name"] = audioSwitchCasted?.Switch?.Name.ToString()!;
                details["Switch Value"] = audioSwitchCasted?.Switch?.Value.ToString()!;
            }
        }
        else if (node is questEventManagerNodeDefinition eventManagerNodeCasted)
        {
            details["Component Name"] = eventManagerNodeCasted?.ComponentName.ToString()!;
            details["Event"] = eventManagerNodeCasted?.Event?.Chunk?.GetType()?.Name!;

            if (eventManagerNodeCasted?.Event?.Chunk is DisableBraindanceActions disableBDActionsCasted)
            {
                details.AddRange(ParseBDMask(disableBDActionsCasted.ActionMask));
            }
            if (eventManagerNodeCasted?.Event?.Chunk is EnableBraindanceActions enableBDActionsCasted)
            {
                details.AddRange(ParseBDMask(enableBDActionsCasted.ActionMask));
            }
            if (eventManagerNodeCasted?.Event?.Chunk is gameActionEvent gameActionEventCasted)
            {
                details["- Event Action"] = gameActionEventCasted?.EventAction.GetResolvedText()!;
                details["- Internal Event"] = gameActionEventCasted?.InternalEvent?.Chunk?.GetType()?.Name!;
                details["- Name"] = gameActionEventCasted?.Name.GetResolvedText()!;
                details["- Time To Live"] = gameActionEventCasted?.TimeToLive.ToString()!;
            }

            details["Is Object Player"] = eventManagerNodeCasted?.IsObjectPlayer == true ? "True" : "False";
            details["Manager Name"] = eventManagerNodeCasted?.ManagerName.ToString()!;
            details["Object Ref"] = ParseGameEntityReference(eventManagerNodeCasted?.ObjectRef);
        }
        else if (node is questEnvironmentManagerNodeDefinition envManagerNodeCasted)
        {
            details["Manager"] = GetNameFromClass(envManagerNodeCasted?.Type?.Chunk);

            if (envManagerNodeCasted?.Type?.Chunk is questPlayEnv_SetWeather playEnvCasted)
            {
                details["Blend Time"] = playEnvCasted?.BlendTime.ToString()!;
                details["Priority"] = playEnvCasted?.Priority.ToString()!;
                details["Reset"] = playEnvCasted?.Reset == true ? "True" : "False";
                details["Source"] = playEnvCasted?.Source.ToString()!;
                details["Weather ID"] = playEnvCasted?.WeatherID.ResolvedText!;
            }
        }
        else if (node is questRenderFxManagerNodeDefinition renderFxManagerNodeCasted)
        {
            details["Manager"] = GetNameFromClass(renderFxManagerNodeCasted?.Type?.Chunk);

            if (renderFxManagerNodeCasted?.Type?.Chunk is questSetFadeInOut_NodeType fadeInOutCasted)
            {
                details["Duration"] = fadeInOutCasted?.Duration.ToString()!;
                details["FadeColor"] = fadeInOutCasted?.FadeColor.ToString()!;
                details["Fade In"] = fadeInOutCasted?.FadeIn == true ? "True" : "False";
            }
        }
        else if (node is questUIManagerNodeDefinition uiManagerNodeCasted)
        {
            details["Manager"] = GetNameFromClass(uiManagerNodeCasted?.Type?.Chunk);

            if (uiManagerNodeCasted?.Type?.Chunk is questSetHUDEntryForcedVisibility_NodeType hudVisibilityCasted)
            {
                if (hudVisibilityCasted?.HudEntryName != null)
                {
                    for (int i = 0; i < hudVisibilityCasted?.HudEntryName.Count; i++)
                    {
                        details["Hud Entry Name #" + i] = hudVisibilityCasted?.HudEntryName[i].ToString()!;
                    }
                }

                details["Hud Visibility Preset"] = hudVisibilityCasted?.HudVisibilityPreset.ResolvedText!;
                details["Skip Animation"] = hudVisibilityCasted?.SkipAnimation == true ? "True" : "False";
                details["Use Preset"] = hudVisibilityCasted?.UsePreset == true ? "True" : "False";
                details["Visibility"] = hudVisibilityCasted?.Visibility.ToEnumString()!;
            }
            if (uiManagerNodeCasted?.Type?.Chunk is questSwitchNameplate_NodeType switchNameplateCasted)
            {
                details["Alternative Name"] = switchNameplateCasted?.AlternativeName == true ? "True" : "False";
                details["Enable"] = switchNameplateCasted?.Enable == true ? "True" : "False";
                details["Is Player"] = switchNameplateCasted?.IsPlayer == true ? "True" : "False";
                details["Puppet Ref"] = ParseGameEntityReference(switchNameplateCasted?.PuppetRef);
            }
            if (uiManagerNodeCasted?.Type?.Chunk is questWarningMessage_NodeType warningMessageCasted)
            {
                details["Duration"] = warningMessageCasted?.Duration.ToString()!;
                details["Instant"] = warningMessageCasted?.Instant == true ? "True" : "False";
                details["Localized Message"] = warningMessageCasted?.LocalizedMessage?.Value!;
                details["Message"] = warningMessageCasted?.Message.ToString()!;
                details["Show"] = warningMessageCasted?.Show == true ? "True" : "False";
                details["Message Type"] = warningMessageCasted?.Type.ToEnumString()!;
            }
            if (uiManagerNodeCasted?.Type?.Chunk is questProgressBar_NodeType progressBarCasted)
            {
                details["Bottom Text"] = progressBarCasted?.BottomText?.Value!;
                details["Duration"] = progressBarCasted?.Duration.ToString()!;
                details["Show"] = progressBarCasted?.Show == true ? "True" : "False";
                details["Text"] = progressBarCasted?.Text?.Value!;
                details["Progress Bar Type"] = progressBarCasted?.Type.ToEnumString()!;
            }
            if (uiManagerNodeCasted?.Type?.Chunk is questTutorial_NodeType tutorialCasted)
            {
                details["Sub Manager"] = GetNameFromClass(tutorialCasted?.Subtype?.Chunk);

                if (tutorialCasted?.Subtype?.Chunk is questShowPopup_NodeSubType showPopupNodeCasted)
                {
                    details["Close At Input"] = showPopupNodeCasted?.CloseAtInput == true ? "True" : "False";
                    details["Close Current Popup"] = showPopupNodeCasted?.CloseCurrentPopup == true ? "True" : "False";
                    details["Hide In Menu"] = showPopupNodeCasted?.HideInMenu == true ? "True" : "False";
                    details["Ignore Disabled Tutorials"] = showPopupNodeCasted?.IgnoreDisabledTutorials == true ? "True" : "False";
                    details["Lock Player Movement"] = showPopupNodeCasted?.LockPlayerMovement == true ? "True" : "False";
                    details["Margin"] = ParseMargin(showPopupNodeCasted?.Margin);
                    details["Open"] = showPopupNodeCasted?.Open == true ? "True" : "False";
                    details.AddRange(ParseJournalPath(showPopupNodeCasted?.Path?.Chunk));
                    details["Pause Game"] = showPopupNodeCasted?.PauseGame == true ? "True" : "False";
                    details["Position"] = showPopupNodeCasted?.Position.ToEnumString()!;
                    details["Screen Mode"] = showPopupNodeCasted?.ScreenMode.ToEnumString()!;
                    details["Video"] = showPopupNodeCasted?.Video.DepotPath.GetResolvedText()!;
                    details["Video Type"] = showPopupNodeCasted?.VideoType.ToEnumString()!;
                }
                if (tutorialCasted?.Subtype?.Chunk is questShowBracket_NodeSubType showBracketNodeCasted)
                {
                    details["Anchor"] = showBracketNodeCasted?.Anchor.ToEnumString()!;
                    details["Bracket ID"] = showBracketNodeCasted?.BracketID.ToString()!;
                    details["Bracket Type"] = showBracketNodeCasted?.BracketType.ToEnumString()!;
                    details["Ignore Disabled Tutorials"] = showBracketNodeCasted?.IgnoreDisabledTutorials == true ? "True" : "False";
                    details["Offset"] = showBracketNodeCasted?.Offset.ToString()!;
                    details["Size"] = showBracketNodeCasted?.Size.ToString()!;
                    details["Visible"] = showBracketNodeCasted?.Visible == true ? "True" : "False";
                    details["Visible On UI Layer"] = showBracketNodeCasted?.VisibleOnUILayer.ToEnumString()!;
                }
                if (tutorialCasted?.Subtype?.Chunk is questShowHighlight_NodeSubType showHighlightNodeCasted)
                {
                    details["Enable"] = showHighlightNodeCasted?.Enable == true ? "True" : "False";
                    details["Entity Reference"] = ParseGameEntityReference(showHighlightNodeCasted?.EntityReference);
                }
                if (tutorialCasted?.Subtype?.Chunk is questShowOverlay_NodeSubType showOverlayNodeCasted)
                {
                    details["Hide On Input"] = showOverlayNodeCasted?.HideOnInput == true ? "True" : "False";
                    details["Library Item Name"] = showOverlayNodeCasted?.LibraryItemName.ToString()!;
                    details["Lock Player Movement"] = showOverlayNodeCasted?.LockPlayerMovement == true ? "True" : "False";
                    details["Overlay Library"] = showOverlayNodeCasted?.OverlayLibrary.DepotPath.GetResolvedText()!;
                    details["Pause Game"] = showOverlayNodeCasted?.PauseGame == true ? "True" : "False";
                    details["Visible"] = showOverlayNodeCasted?.Visible == true ? "True" : "False";
                }
            }
        }
        else if (node is questTeleportPuppetNodeDefinition teleportNodeCasted)
        {
            details["Entity Reference"] = GetNameFromUniversalRef(teleportNodeCasted?.EntityReference?.Chunk);
            details["Local Player"] = teleportNodeCasted?.EntityReference?.Chunk?.RefLocalPlayer == true ? "True" : "False";
            details["Look At Action"] = teleportNodeCasted?.LookAtAction.ToEnumString()!;

            details["Destination Offset"] = teleportNodeCasted?.Params?.Chunk?.DestinationOffset.ToString()!;
            details["Destination Entity Reference"] = GetNameFromUniversalRef(teleportNodeCasted?.Params?.Chunk?.DestinationRef?.Chunk);
            details["Heal At Teleport"] = teleportNodeCasted?.Params?.Chunk?.HealAtTeleport == true ? "True" : "False";

            details["Player Look At Offset"] = teleportNodeCasted?.PlayerLookAt?.Chunk?.Offset.ToString()!;
            details["Player Look At Target"] = ParseGameEntityReference(teleportNodeCasted?.PlayerLookAt?.Chunk?.LookAtTarget);
        }
        else if (node is questWorldDataManagerNodeDefinition worldDataManagerCasted)
        {
            details["Manager"] = GetNameFromClass(worldDataManagerCasted?.Type?.Chunk);

            if (worldDataManagerCasted?.Type?.Chunk is questShowWorldNode_NodeType showWorldNodeCasted)
            {
                details["Component Name"] = showWorldNodeCasted?.ComponentName.ToString()!;
                details["Is Player"] = showWorldNodeCasted?.IsPlayer == true ? "True" : "False";
                details["Object Ref"] = showWorldNodeCasted?.ObjectRef.GetResolvedText()!;
                details["Show"] = showWorldNodeCasted?.Show == true ? "True" : "False";
            }
            if (worldDataManagerCasted?.Type?.Chunk is questTogglePrefabVariant_NodeType togglePrefabNodeCasted)
            {
                var paramsArr = togglePrefabNodeCasted?.Params;
                //details["Params Count"] = paramsArr?.Count.ToString()!;

                if (paramsArr != null)
                {
                    int counter = 1;
                    foreach (var re in paramsArr)
                    {
                        details["#" + counter + " Prefab Node Ref"] = re.PrefabNodeRef.GetResolvedText()!;

                        var variantStates = re.VariantStates;
                        //details["#" + counter + " Variant States Count"] = variantStates?.Count.ToString()!;

                        if (variantStates != null)
                        {
                            int counter2 = 1;
                            foreach (var vs in variantStates)
                            {
                                details["#" + counter + " Variant State #" + counter2 + " Name"] = vs.Name.ToString()!;
                                details["#" + counter + " Variant State #" + counter2 + " Show"] = vs.Show == true ? "True" : "False";

                                counter2++;
                            }
                        }

                        counter++;
                    }
                }
            }
            if (worldDataManagerCasted?.Type?.Chunk is questPrefetchStreaming_NodeTypeV2 prefetchStreamingNodeCasted)
            {
                details["Force Enable"] = prefetchStreamingNodeCasted?.ForceEnable == true ? "True" : "False";
                details["Max Distance"] = prefetchStreamingNodeCasted?.MaxDistance.ToString()!;
                details["Prefetch Position Ref"] = prefetchStreamingNodeCasted?.PrefetchPositionRef.GetResolvedText()!;
                details["Use Streaming Occlusion"] = prefetchStreamingNodeCasted?.UseStreamingOcclusion == true ? "True" : "False";
            }
        }
        else if (node is questSpawnManagerNodeDefinition spawnManagerCasted)
        {
            var actions = spawnManagerCasted.Actions;
            //details["Actions"] = actions.Count.ToString();

            int counter = 1;
            foreach (var action in actions)
            {
                if (action?.Type?.Chunk is questScene_NodeType spwActionNodeCasted)
                {
                    details["#" + counter + " Action"] = spwActionNodeCasted.Action.ToEnumString()!;
                    details["#" + counter + " Entity Reference"] = ParseGameEntityReference(spwActionNodeCasted.EntityReference);
                }
                if (action?.Type?.Chunk is questCommunityTemplate_NodeType spwCommunityTemplateNodeCasted)
                {
                    details["#" + counter + " Action"] = spwCommunityTemplateNodeCasted.Action.ToEnumString()!;
                    details["#" + counter + " Community Entry Name"] = spwCommunityTemplateNodeCasted.CommunityEntryName.ToString()!;
                    details["#" + counter + " Community Entry Phase Name"] = spwCommunityTemplateNodeCasted.CommunityEntryPhaseName.ToString()!;
                    details["#" + counter + " Spawner Reference"] = spwCommunityTemplateNodeCasted.SpawnerReference.GetResolvedText()!;
                }
                if (action?.Type?.Chunk is questSpawnSet_NodeType spwSetNodeCasted)
                {
                    details["#" + counter + " Action"] = spwSetNodeCasted.Action.ToEnumString()!;
                    details["#" + counter + " Entry Name"] = spwSetNodeCasted.EntryName.ToString()!;
                    details["#" + counter + " Phase Name"] = spwSetNodeCasted.PhaseName.ToString()!;
                    details["#" + counter + " Reference"] = spwSetNodeCasted.Reference.GetResolvedText()!;
                }
                if (action?.Type?.Chunk is questSpawner_NodeType spawnerNodeCasted)
                {
                    details["#" + counter + " Action"] = spawnerNodeCasted.Action.ToEnumString()!;
                    details["#" + counter + " Spawner Reference"] = spawnerNodeCasted.SpawnerReference.GetResolvedText()!;
                }

                counter++;
            }
        }
        else if (node is questGameManagerNodeDefinition gameManagerCasted)
        {
            details["Manager"] = GetNameFromClass(gameManagerCasted?.Type?.Chunk);

            if (gameManagerCasted?.Type?.Chunk is questGameplayRestrictions_NodeType gameplayRestrictionsNodeCasted)
            {
                details["Action"] = gameplayRestrictionsNodeCasted?.Action.ToEnumString()!;

                var restr = gameplayRestrictionsNodeCasted?.RestrictionIDs;
                //details["Restrictions"] = restr?.Count.ToString()!;

                if (restr != null)
                {
                    int counter = 1;
                    foreach (var re in restr)
                    {
                        details["#" + counter] = re.GetResolvedText()!;

                        counter++;
                    }
                }
            }
            if (gameManagerCasted?.Type?.Chunk is questRumble_NodeType rumbleNodeCasted)
            {
                details["Is Player"] = rumbleNodeCasted?.IsPlayer == true ? "True" : "False";
                details["Object Ref"] = ParseGameEntityReference(rumbleNodeCasted?.ObjectRef);
                details["Rumble Event"] = rumbleNodeCasted?.RumbleEvent.ToString()!;
            }
            if (gameManagerCasted?.Type?.Chunk is questContentTokenManager_NodeType contentTokenManagerNodeCasted)
            {
                details["Sub Manager"] = GetNameFromClass(contentTokenManagerNodeCasted?.Subtype?.Chunk);

                if (contentTokenManagerNodeCasted?.Subtype?.Chunk is questBlockTokenActivation_NodeSubType blockTokenNodeCasted)
                {
                    details["Action"] = blockTokenNodeCasted?.Action.ToEnumString()!;
                    details["Reset Token Spawn Timer"] = blockTokenNodeCasted?.ResetTokenSpawnTimer == true ? "True" : "False";
                    details["Source"] = blockTokenNodeCasted?.Source.ToString()!;
                }
            }
        }
        else if (node is questVoicesetManagerNodeDefinition voicesetManagerCasted)
        {
            details["Manager"] = GetNameFromClass(voicesetManagerCasted?.Type?.Chunk);

            if (voicesetManagerCasted?.Type?.Chunk is questPlayVoiceset_NodeType playVoiceSetCasted)
            {
                var paramsArr = playVoiceSetCasted.Params;
                //details["Actions"] = actions.Count.ToString();

                int counter = 1;
                foreach (var param in paramsArr)
                {
                    details["#" + counter + " Is Player"] = param.IsPlayer == true ? "True" : "False";
                    details["#" + counter + " Override Visual Style"] = param.OverrideVisualStyle == true ? "True" : "False";
                    details["#" + counter + " Override Voiceover Expression"] = param.OverrideVoiceoverExpression == true ? "True" : "False";
                    details["#" + counter + " Overriding Visual Style"] = param.OverridingVisualStyle.ToEnumString();
                    details["#" + counter + " Overriding Voiceover Context"] = param.OverridingVoiceoverContext.ToEnumString();
                    details["#" + counter + " Overriding Voiceover Expression"] = param.OverridingVoiceoverExpression.ToEnumString();
                    details["#" + counter + " Play Only Grunt"] = param.PlayOnlyGrunt == true ? "True" : "False";
                    details["#" + counter + " Puppet Ref"] = ParseGameEntityReference(param?.PuppetRef);
                    details["#" + counter + " Use Voiceset System"] = param?.UseVoicesetSystem == true ? "True" : "False";
                    details["#" + counter + " Voiceset Name"] = param?.VoicesetName.ToString()!;

                    counter++;
                }
            }
        }
        else if (node is questInteractiveObjectManagerNodeDefinition interactiveObjectManagerCasted)
        {
            details["Manager"] = GetNameFromClass(interactiveObjectManagerCasted?.Type?.Chunk);

            if (interactiveObjectManagerCasted?.Type?.Chunk is questDeviceManager_NodeType deviceManagerCasted)
            {
                var paramsArr = deviceManagerCasted.Params;
                //details["Actions"] = actions.Count.ToString();

                int counter = 1;
                foreach (var param in paramsArr)
                {
                    var actionProperties = "";
                    if (param?.Chunk?.ActionProperties != null)
                    {
                        foreach (var p in param.Chunk.ActionProperties)
                        {
                            actionProperties += (actionProperties != "" ? ", " : "") + p.Name.ToString()!;
                        }
                    }
                    details["#" + counter + " Action Properties"] = actionProperties;

                    details["#" + counter + " Device Action"] = param?.Chunk?.DeviceAction.ToString()!;
                    details["#" + counter + " Device Controller Class"] = param?.Chunk?.DeviceControllerClass.ToString()!;
                    details["#" + counter + " Entity Ref"] = ParseGameEntityReference(param?.Chunk?.EntityRef);
                    details["#" + counter + " Object Ref"] = param?.Chunk?.ObjectRef.GetResolvedText()!;
                    details["#" + counter + " Slot Name"] = param?.Chunk?.SlotName.ToString()!;

                    counter++;
                }
            }
        }
        else if (node is questCharacterManagerNodeDefinition characterManagerCasted)
        {
            details["Manager"] = GetNameFromClass(characterManagerCasted?.Type?.Chunk);

            if (characterManagerCasted?.Type?.Chunk is questCharacterManagerParameters_NodeType charParamsNodeCasted)
            {
                details["Sub Manager"] = GetNameFromClass(charParamsNodeCasted?.Subtype?.Chunk);

                if (charParamsNodeCasted?.Subtype?.Chunk is questCharacterManagerParameters_SetStatusEffect setStatusEffectNodeCasted)
                {
                    details["Is Player"] = setStatusEffectNodeCasted?.IsPlayer == true ? "True" : "False";
                    details["Is Player Status Effect Source"] = setStatusEffectNodeCasted?.IsPlayerStatusEffectSource == true ? "True" : "False";
                    details["Puppet Ref"] = ParseGameEntityReference(setStatusEffectNodeCasted?.PuppetRef);
                    //setStatusEffectNodeCasted?.RecordSelector
                    details["Set"] = setStatusEffectNodeCasted?.Set == true ? "True" : "False";
                    details["Status Effect ID"] = setStatusEffectNodeCasted?.StatusEffectID.GetResolvedText()!;
                    details["Status Effect Source Object"] = ParseGameEntityReference(setStatusEffectNodeCasted?.StatusEffectSourceObject);
                }
            }
            if (characterManagerCasted?.Type?.Chunk is questCharacterManagerVisuals_NodeType charVisualsNodeCasted)
            {
                details["Sub Manager"] = GetNameFromClass(charVisualsNodeCasted?.Subtype?.Chunk);

                if (charVisualsNodeCasted?.Subtype?.Chunk is questCharacterManagerVisuals_GenitalsManager genitalsManagerNodeCasted)
                {
                    details["Body Group Name"] = genitalsManagerNodeCasted?.BodyGroupName.ToString()!;
                    details["Enable"] = genitalsManagerNodeCasted?.Enable == true ? "True" : "False";
                    details["Is Player"] = genitalsManagerNodeCasted?.IsPlayer == true ? "True" : "False";
                    details["Puppet Ref"] = ParseGameEntityReference(genitalsManagerNodeCasted?.PuppetRef);
                }
                if (charVisualsNodeCasted?.Subtype?.Chunk is questCharacterManagerVisuals_ChangeEntityAppearance appearanceManagerNodeCasted)
                {
                    var appearancesArr = appearanceManagerNodeCasted?.AppearanceEntries;

                    if (appearancesArr != null)
                    {
                        int counter = 1;
                        foreach (var appearance in appearancesArr)
                        {
                            details["#" + counter + " Appearance Name"] = appearance.AppearanceName.ToString()!;
                            details["#" + counter + " Is Player"] = appearance.IsPlayer == true ? "True" : "False";
                            details["#" + counter + " Puppet Ref"] = ParseGameEntityReference(appearance?.PuppetRef);

                            counter++;
                        }
                    }
                }
            }
            if (characterManagerCasted?.Type?.Chunk is questCharacterManagerCombat_NodeType charCombatNodeCasted)
            {
                details["Sub Manager"] = GetNameFromClass(charCombatNodeCasted?.Subtype?.Chunk);

                if (charCombatNodeCasted?.Subtype?.Chunk is questCharacterManagerCombat_EquipWeapon equipWpnNodeCasted)
                {
                    details["Equip"] = equipWpnNodeCasted?.Equip == true ? "True" : "False";
                    details["Equip Last Weapon"] = equipWpnNodeCasted?.EquipLastWeapon == true ? "True" : "False";
                    details["Force First Equip"] = equipWpnNodeCasted?.ForceFirstEquip == true ? "True" : "False";
                    details["Ignore State Machine"] = equipWpnNodeCasted?.IgnoreStateMachine == true ? "True" : "False";
                    details["Instant"] = equipWpnNodeCasted?.Instant == true ? "True" : "False";
                    details["Slot ID"] = equipWpnNodeCasted?.SlotID.GetResolvedText()!;
                    details["Weapon ID"] = equipWpnNodeCasted?.WeaponID.GetResolvedText()!;
                }
            }
        }
        else if (node is questItemManagerNodeDefinition itemManagerCasted)
        {
            details["Manager"] = GetNameFromClass(itemManagerCasted?.Type?.Chunk);

            if (itemManagerCasted?.Type?.Chunk is questAddRemoveItem_NodeType itemAddRemoveNodeCasted)
            {
                var paramsArr = itemAddRemoveNodeCasted.Params;
                //details["Actions"] = actions.Count.ToString();

                int counter = 1;
                foreach (var param in paramsArr)
                {
                    details["#" + counter + " Entity Ref"] = GetNameFromUniversalRef(param?.Chunk?.EntityRef?.Chunk);
                    details["#" + counter + " Flag Item Added Callback As Silent"] = param?.Chunk?.FlagItemAddedCallbackAsSilent == true ? "True" : "False";
                    details["#" + counter + " Is Player"] = param?.Chunk?.IsPlayer == true ? "True" : "False";
                    details["#" + counter + " Item ID"] = param?.Chunk?.ItemID.GetResolvedText()!;

                    var itemToIgnore = "";
                    if (param?.Chunk?.ItemIDsToIgnoreOnRemove != null)
                    {
                        foreach (var p in param.Chunk.ItemIDsToIgnoreOnRemove)
                        {
                            itemToIgnore += (itemToIgnore != "" ? ", " : "") + p.GetResolvedText()!;
                        }
                    }
                    details["#" + counter + " Item IDs To Ignore On Remove"] = itemToIgnore;

                    details["#" + counter + " Node Type"] = param?.Chunk?.NodeType.ToEnumString()!;
                    details["#" + counter + " Object Ref"] = ParseGameEntityReference(param?.Chunk?.ObjectRef);
                    details["#" + counter + " Quantity"] = param?.Chunk?.Quantity.ToString()!;
                    details["#" + counter + " Remove All Quantity"] = param?.Chunk?.RemoveAllQuantity == true ? "True" : "False";
                    details["#" + counter + " Send Notification"] = param?.Chunk?.SendNotification == true ? "True" : "False";

                    var tagsToIgnore = "";
                    if (param?.Chunk?.TagsToIgnoreOnRemove != null)
                    {
                        foreach (var p in param.Chunk.TagsToIgnoreOnRemove)
                        {
                            tagsToIgnore += (tagsToIgnore != "" ? ", " : "") + p.ToString();
                        }
                    }
                    details["#" + counter + " Tags To Ignore On Remove"] = tagsToIgnore;

                    details["#" + counter + " Tag To Remove"] = param?.Chunk?.TagToRemove.ToString()!;

                    counter++;
                }
            }
        }
        else if (node is questCrowdManagerNodeDefinition crowdManagerCasted)
        {
            details["Manager"] = GetNameFromClass(crowdManagerCasted?.Type?.Chunk);

            if (crowdManagerCasted?.Type?.Chunk is questCrowdManagerNodeType_ControlCrowd controlCrowdNodeCasted)
            {
                details["Action"] = controlCrowdNodeCasted?.Action.ToEnumString()!;
                details["Debug Source"] = controlCrowdNodeCasted?.DebugSource.ToString()!;
                details["Distant Crowd Only"] = controlCrowdNodeCasted?.DistantCrowdOnly == true ? "True" : "False";
            }
        }
        else if (node is questFXManagerNodeDefinition fxManagerCasted)
        {
            details["Manager"] = GetNameFromClass(fxManagerCasted?.Type?.Chunk);

            if (fxManagerCasted?.Type?.Chunk is questPlayFX_NodeType playFxNodeCasted)
            {
                var paramsArr = playFxNodeCasted.Params;
                //details["Actions"] = actions.Count.ToString();

                int counter = 1;
                foreach (var param in paramsArr)
                {
                    details["#" + counter + " Effect Instance Name"] = param?.EffectInstanceName.ToString()!;
                    details["#" + counter + " Effect Name"] = param?.EffectName.ToString()!;
                    details["#" + counter + " Is Player"] = param?.IsPlayer == true ? "True" : "False";
                    details["#" + counter + " Object Ref"] = ParseGameEntityReference(param?.ObjectRef);
                    details["#" + counter + " Play"] = param?.Play == true ? "True" : "False";
                    details["#" + counter + " Save"] = param?.Save == true ? "True" : "False";
                    details["#" + counter + " Sequence Shift"] = param?.SequenceShift.ToString()!;

                    counter++;
                }
            }
        }
        else if (node is questRandomizerNodeDefinition randomizerCasted)
        {
            details["Mode"] = randomizerCasted?.Mode.ToEnumString()!;

            var outputWeights = "";
            if (randomizerCasted?.OutputWeights != null)
            {
                foreach (var p in randomizerCasted.OutputWeights)
                {
                    outputWeights += (outputWeights != "" ? ", " : "") + p.ToString();
                }
            }
            details["Output Weights"] = outputWeights;
        }
        else if (node is questEntityManagerNodeDefinition entityManagerCasted)
        {
            details["Manager"] = GetNameFromClass(entityManagerCasted?.Type?.Chunk);

            if (entityManagerCasted?.Type?.Chunk is questEntityManagerToggleMirrorsArea_NodeType toggleMirrorNodeCasted)
            {
                details["Is In Mirrors Area"] = toggleMirrorNodeCasted?.IsInMirrorsArea == true ? "True" : "False";
                details["Object Ref"] = ParseGameEntityReference(toggleMirrorNodeCasted?.ObjectRef);
            }
            if (entityManagerCasted?.Type?.Chunk is questEntityManagerChangeAppearance_NodeType changeAppearanceNodeCasted)
            {
                details["Appearance Name"] = changeAppearanceNodeCasted?.AppearanceName.ToString()!;
                details["Entity Ref"] = ParseGameEntityReference(changeAppearanceNodeCasted?.EntityRef);
                details["Prefetch Only"] = changeAppearanceNodeCasted?.PrefetchOnly == true ? "True" : "False";
            }
        }
        else if (node is questPuppetAIManagerNodeDefinition puppetAIManagerCasted)
        {
            details["Entries Count"] = puppetAIManagerCasted?.Entries?.Count.ToString() ?? "0";

            if (puppetAIManagerCasted?.Entries != null)
            {
                int counter = 1;
                foreach (var entry in puppetAIManagerCasted.Entries)
                {
                    if (counter > 3) break; // Limit to first 3 entries to avoid overwhelming details

                    details[$"#{counter} Entity Ref"] = ParseGameEntityReference(entry?.EntityReference);
                    details[$"#{counter} AI Tier"] = entry?.AiTier.ToEnumString() ?? "Unknown";

                    counter++;
                }
            }
        }
        else if (node is questMovePuppetNodeDefinition movePuppetManagerCasted)
        {
            details["Entity Reference"] = ParseGameEntityReference(movePuppetManagerCasted?.EntityReference);
            details["Move Type"] = movePuppetManagerCasted?.MoveType.ToString()!;

            if (movePuppetManagerCasted?.NodeParams?.Chunk is questMoveOnSplineParams splineParams)
            {
                details["Spline Node Ref"] = splineParams?.SplineNodeRef.GetResolvedText()!;
            }
        }
        else if (node is questPhoneManagerNodeDefinition phoneManagerCasted)
        {
            details["Manager"] = GetNameFromClass(phoneManagerCasted?.Type?.Chunk);

            if (phoneManagerCasted?.Type?.Chunk is questCallContact_NodeType callContactCasted)
            {
                details.AddRange(ParseJournalPath(callContactCasted?.Caller?.Chunk, "Caller"));
                details.AddRange(ParseJournalPath(callContactCasted?.Addressee?.Chunk, "Addressee"));
                details["Phase"] = callContactCasted?.Phase.ToEnumString()!;
                details["Mode"] = callContactCasted?.Mode.ToEnumString()!;
                details["Apply Phone Restriction"] = callContactCasted?.ApplyPhoneRestriction == true ? "True" : "False";
                details["Is Rejectable"] = callContactCasted?.IsRejectable == true ? "True" : "False";
                details["Show Avatar"] = callContactCasted?.ShowAvatar == true ? "True" : "False";
                details["Visuals"] = callContactCasted?.Visuals.ToEnumString()!;
            }
            if (phoneManagerCasted?.Type?.Chunk is questSendMessage_NodeType sendMessageCasted)
            {
                details.AddRange(ParseJournalPath(sendMessageCasted?.Msg?.Chunk, "Message"));
                details["Send Notification"] = sendMessageCasted?.SendNotification == true ? "True" : "False";
            }
            if (phoneManagerCasted?.Type?.Chunk is questOpenMessage_NodeType openMessageCasted)
            {
                details.AddRange(ParseJournalPath(openMessageCasted?.Msg?.Chunk, "Message"));
            }
            if (phoneManagerCasted?.Type?.Chunk is questCloseMessage_NodeType closeMessageCasted)
            {
                details.AddRange(ParseJournalPath(closeMessageCasted?.Msg?.Chunk, "Message"));
            }
            if (phoneManagerCasted?.Type?.Chunk is questSetPhoneStatus_NodeType setStatusCasted)
            {
                details["Status"] = setStatusCasted?.Status.ToEnumString()!;
                details["Custom Status"] = setStatusCasted?.CustomStatus.ToString()!;
            }
            if (phoneManagerCasted?.Type?.Chunk is questSetPhoneRestriction_NodeType setRestrictionCasted)
            {
                details["Apply Phone Restriction"] = setRestrictionCasted?.ApplyPhoneRestriction == true ? "True" : "False";
                details["Forced Apply"] = setRestrictionCasted?.ForcedApply == true ? "True" : "False";
                details["Forced Apply Source"] = setRestrictionCasted?.ForcedApplySource.ToString()!;
            }
            if (phoneManagerCasted?.Type?.Chunk is questMinimize_NodeType minimizeCasted)
            {
                details["Minimize"] = minimizeCasted?.Minimize == true ? "True" : "False";
            }
            if (phoneManagerCasted?.Type?.Chunk is questAddRemoveContact_NodeType addRemoveContactCasted)
            {
                if (addRemoveContactCasted?.Params != null && addRemoveContactCasted.Params.Count > 0)
                {
                    var firstParam = addRemoveContactCasted.Params[0];
                    details.AddRange(ParseJournalPath(firstParam?.Contact?.Chunk, "Contact"));
                    details["Add Contact"] = firstParam?.AddContact == true ? "True" : "False";
                    details["Send Notification"] = firstParam?.SendNotification == true ? "True" : "False";
                    if (addRemoveContactCasted.Params.Count > 1)
                    {
                        details["Contacts Count"] = addRemoveContactCasted.Params.Count.ToString();
                    }
                }
            }
            if (phoneManagerCasted?.Type?.Chunk is questRemoveAllContacts_NodeType removeAllContactsCasted)
            {
                details["Excluded Contacts Count"] = removeAllContactsCasted?.ExcludedContacts?.Count.ToString() ?? "0";
            }
        }
        else if (node is questVehicleNodeDefinition vehicleNodeCasted)
        {
            details["Manager"] = GetNameFromClass(vehicleNodeCasted?.Type?.Chunk);

            if (vehicleNodeCasted?.Type?.Chunk is questMoveOnSpline_NodeType splineParams)
            {
                details["Arrive With Pivot"] = splineParams?.ArriveWithPivot == true ? "True" : "False";
                details["Audio Curves"] = splineParams?.AudioCurves.DepotPath!;
                details["Blend Time"] = splineParams?.BlendTime.ToString()!;
                details["Blend Type"] = splineParams?.BlendType.ToEnumString()!;
                details["Overrides"] = splineParams?.Overrides?.Chunk?.GetType().Name!;
                details["Reverse Gear"] = splineParams?.ReverseGear == true ? "True" : "False";
                details["Scene Blend In Distance"] = splineParams?.SceneBlendInDistance.ToString()!;
                details["Scene Blend Out Distance"] = splineParams?.SceneBlendOutDistance.ToString()!;
                details["Spline Ref"] = splineParams?.SplineRef.GetResolvedText()!;
                details["Start From"] = splineParams?.StartFrom.ToString()!;
                details["Traffic Deletion Mode"] = splineParams?.TrafficDeletionMode.ToEnumString()!;
                details["Vehicle Ref"] = ParseGameEntityReference(splineParams?.VehicleRef);
            }
            if (vehicleNodeCasted?.Type?.Chunk is questTeleport_NodeType teleportParams)
            {
                details["Entity Reference"] = ParseGameEntityReference(teleportParams?.EntityReference);
                details["Destination Offset"] = teleportParams?.Params?.DestinationOffset.ToString()!;
                details["Destination Ref"] = GetNameFromUniversalRef(teleportParams?.Params?.DestinationRef?.Chunk);
            }
        }

        // Return true if we found curated properties (more than just the initial "Type")
        return details.Count > initialCount;
    }

    private static Dictionary<string, string> GetSmartAutoDiscoveredProperties(questNodeDefinition? node)
    {
        var properties = new Dictionary<string, string>();
        
        if (node == null) return properties;

        try
        {
            // Generic recursive discovery - explores all interesting nested objects
            var visited = new HashSet<object>();
            DiscoverPropertiesRecursively(node, properties, "", visited, maxDepth: 5);
            

        }
        catch (Exception ex)
        {
            var loggerService = Locator.Current.GetService<ILoggerService>();
            loggerService?.Warning($"Error in smart property discovery for {node.GetType().Name}: {ex.Message}");
        }

        return properties;
    }
    
    private static void DiscoverPropertiesRecursively(object obj, Dictionary<string, string> properties, string prefix, HashSet<object> visited, int maxDepth)
    {
        if (obj == null || properties.Count >= 8 || maxDepth <= 0 || visited.Contains(obj)) 
            return;
        
        visited.Add(obj);
        
        var objType = obj.GetType();
        var allProperties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in allProperties)
        {
            if (properties.Count >= 8) break;
            
            try
            {
                var value = prop.GetValue(obj);
                if (value == null) continue;
                
                // Check if this is a simple property we want to display
                if (IsSimpleDisplayProperty(prop, value))
                {
                    var formattedValue = FormatPropertyValue(value);
                    if (!string.IsNullOrEmpty(formattedValue) && !IsDefaultValue(value))
                    {
                        var displayName = string.IsNullOrEmpty(prefix) ? GetDisplayName(prop.Name) : $"{prefix} {GetDisplayName(prop.Name)}";
                        if (!properties.ContainsKey(displayName))
                        {
                            properties[displayName] = formattedValue;
                        }
                    }
                }
                // Check if this is a nested object we should explore
                else if (IsNestedObjectToExplore(prop, value))
                {
                    var nestedPrefix = string.IsNullOrEmpty(prefix) ? GetDisplayName(prop.Name) : $"{prefix} {GetDisplayName(prop.Name)}";
                    
                    // Handle CHandle<T> by getting the chunk
                    if (IsHandleType(value) && TryGetChunkFromHandle(value, out var chunk) && chunk != null)
                    {
                        DiscoverPropertiesRecursively(chunk, properties, nestedPrefix, visited, maxDepth - 1);
                    }
                    else if (!IsHandleType(value))
                    {
                        DiscoverPropertiesRecursively(value, properties, nestedPrefix, visited, maxDepth - 1);
                    }
                }
            }
            catch
            {
                // Skip properties that can't be accessed
                continue;
            }
        }
        
        visited.Remove(obj);
    }
    
    private static bool IsSimpleDisplayProperty(PropertyInfo prop, object value)
    {
        var name = prop.Name;
        var type = prop.PropertyType;

        if (name.Contains("Id") && name != "Id" || // Catches actorId, performerId etc. but not a simple "Id"
            name.Contains("Socket") ||
            name.StartsWith("Unk") ||
            name.Contains("Internal") ||
            name == "Chunk" ||
            name == "version")
        {
            return false;
        }

        if (
            // Identity & Naming (What is this thing called?)
            name.EndsWith("Name") || name.EndsWith("Label") || name.EndsWith("Path") || name.EndsWith("Tag") ||

            // Facts & Journal (What game state does it touch?)
            name.Contains("Fact") || name.Contains("Journal") || name.Contains("Mappin") || name.Contains("Objective") ||
            
            // Actions & States (What is its current state or the action it performs?)
            name.Contains("Action") || name.Contains("State") || name.Contains("Mode") || name.Contains("Phase") || name.Contains("Type") ||
            
            // Quantifiable Values (How much/many/long?)
            name.Contains("Duration") || name.Contains("Time") || name.Contains("Count") || name.Contains("Value") || name.Contains("Percent") || 
            name.Contains("Quantity") || name.Contains("Weight") || name.Contains("Priority") || name.Contains("Distance") || name.Contains("Speed") ||
            
            // Subjects & Targets (Who/what is this node acting upon?)
            name.Contains("Actor") || name.Contains("Puppet") || name.Contains("Performer") || name.Contains("Player") ||
            name.Contains("Target") || name.Contains("Source") || name.Contains("Destination") ||
            name.Contains("Vehicle") || name.Contains("Weapon") || name.Contains("Item") || name.Contains("Reward") ||
            name.Contains("Entity") || name.Contains("Object") ||

            // Common Flags (Is it on or off?)
            name.Contains("Enable") || name.Contains("Show") || name.Contains("Assign") || name.Contains("Skip") || 
            name.Contains("Play") || name.Contains("Stop") || name.Contains("Block") ||
            
            // Miscellaneous high-value properties
            name.Contains("Appearance") || name.Contains("Context") || name.Contains("Slot") || 
            name.Contains("Effect") || name.Contains("Event") || name.Contains("Prereq")
        )
        {
            return IsSimpleValueType(type);
        }

        // Fallback for any other simple types that weren't keyword-matched
        return IsSimpleValueType(type);
    }

    
    private static bool IsSimpleValueType(Type type)
    {
        return type == typeof(bool) || 
               type == typeof(string) || 
               type.IsEnum || 
               typeof(IRedEnum).IsAssignableFrom(type) ||
               type == typeof(CName) ||
               type == typeof(CUInt32) || 
               type == typeof(CInt32) ||
               type == typeof(CFloat) ||
               type == typeof(CDouble) ||
               // References and IDs
               type == typeof(NodeRef) ||
               type == typeof(TweakDBID) ||
               type == typeof(CRUID) ||
               type == typeof(CResourceAsyncReference<>) ||
               type == typeof(CResourceReference<>) ||
               // Spatial types
               type == typeof(Vector3) ||
               type == typeof(Vector4) ||
               type == typeof(Transform) ||
               type == typeof(Quaternion) ||
               type == typeof(EulerAngles) ||
               type == typeof(CColor) ||
               type == typeof(HDRColor) ||
               // Check for generic types (like CResourceReference<T>)
               (type.IsGenericType && (
                   type.GetGenericTypeDefinition() == typeof(CResourceAsyncReference<>) ||
                   type.GetGenericTypeDefinition() == typeof(CResourceReference<>)
               ));
    }
    
    private static bool IsNestedObjectToExplore(PropertyInfo prop, object value)
    {
        var name = prop.Name;
        var type = prop.PropertyType;

        // Avoid exploring things we've already identified as simple display values
        if (IsSimpleValueType(type))
        {
            return false;
        }

        if (
            // Common Suffixes for container objects
            name.EndsWith("Params") || name.EndsWith("Data") || name.EndsWith("Condition") || 
            name.EndsWith("Operation") || name.EndsWith("Provider") || name.EndsWith("Listener") ||
            name.EndsWith("Definition") ||
            
            // Specific high-value nested properties
            name == "type" || // Lowercase 'type' is very common for holding the main logic object
            name == "subtype" ||
            name == "event" ||
            name == "config" ||
            name.Contains("Manager") || // e.g. questCharacterManagerNodeDefinition
            name.Contains("Settings") ||
            name.Contains("Override") ||
            
            // References are almost always objects to explore
            name.EndsWith("Ref") || name.EndsWith("Reference") ||
            name == "entityRef" || name == "EntityRef" ||
            
            // A handle to another resource is a primary exploration target
            IsHandleType(value)
        )
        {
            return true;
        }

        return false;
    }
    
    private static bool IsHandleType(object value)
    {
        var type = value.GetType();
        return type.IsGenericType && type.GetGenericTypeDefinition().Name.Contains("Handle");
    }
    
    private static bool TryGetChunkFromHandle(object handle, out object? chunk)
    {
        chunk = null;
        try
        {
            var chunkProperty = handle.GetType().GetProperty("Chunk");
            if (chunkProperty != null)
            {
                chunk = chunkProperty.GetValue(handle);
                return chunk != null;
            }
        }
        catch { }
        return false;
    }



    private static string FormatPropertyValue(object? value)
    {
        if (value == null) return "";

        return value switch
        {
            bool b => b ? "True" : "False",
            CName cname => cname.GetResolvedText() ?? "",
            CUInt32 cuint => cuint.ToString(),
            CInt32 cint => cint.ToString(),
            CFloat cfloat => cfloat.ToString(),
            CDouble cdouble => cdouble.ToString(),
            string str => str,
            IRedEnum redEnum => redEnum.ToEnumString(),
            Enum enumVal => enumVal.ToString(),
            // References and IDs
            NodeRef nodeRef => nodeRef.GetResolvedText() ?? nodeRef.ToString(),
            TweakDBID tweakId => tweakId.GetResolvedText() ?? tweakId.ToString(),
            CRUID cruid => cruid.ToString(),
            // Spatial types - formatted for readability
            Vector3 vec3 => $"({vec3.X:F2}, {vec3.Y:F2}, {vec3.Z:F2})",
            Vector4 vec4 => $"({vec4.X:F2}, {vec4.Y:F2}, {vec4.Z:F2}, {vec4.W:F2})",
            Transform transform => $"Pos: ({transform.Position.X:F1}, {transform.Position.Y:F1}, {transform.Position.Z:F1})",
            Quaternion quat => $"({quat.I:F2}, {quat.J:F2}, {quat.K:F2}, {quat.R:F2})",
            EulerAngles euler => $"({euler.Pitch:F1}°, {euler.Yaw:F1}°, {euler.Roll:F1}°)",
            CColor color => $"RGB({color.Red}, {color.Green}, {color.Blue}, {color.Alpha})",
            HDRColor hdrColor => $"HDR({hdrColor.Red:F2}, {hdrColor.Green:F2}, {hdrColor.Blue:F2}, {hdrColor.Alpha:F2})",
            // Resource references
            var resRef when resRef.GetType().IsGenericType && 
                           (resRef.GetType().GetGenericTypeDefinition() == typeof(CResourceAsyncReference<>) ||
                            resRef.GetType().GetGenericTypeDefinition() == typeof(CResourceReference<>)) =>
                GetResourceReferencePath(resRef),
            _ => value.ToString() ?? ""
        };
    }
    
    private static string GetResourceReferencePath(object resourceRef)
    {
        try
        {
            var depotPathProperty = resourceRef.GetType().GetProperty("DepotPath");
            if (depotPathProperty?.GetValue(resourceRef) is ResourcePath depotPath)
            {
                var resolved = depotPath.GetResolvedText();
                if (!string.IsNullOrEmpty(resolved))
                {
                    // Show just the filename for readability
                    return System.IO.Path.GetFileName(resolved);
                }
            }
            return resourceRef.ToString() ?? "";
        }
        catch
        {
            return resourceRef.ToString() ?? "";
        }
    }

    private static bool IsDefaultValue(object? value)
    {
        if (value == null) return true;

        return value switch
        {
            bool b => !b, // false is default for bools
            string str => string.IsNullOrEmpty(str),
            CName cname => cname == CName.Empty || string.IsNullOrEmpty(cname.GetResolvedText()),
            CUInt32 cuint => cuint == 0,
            CInt32 cint => cint == 0,
            CFloat cfloat => cfloat == 0.0f,
            CDouble cdouble => cdouble == 0.0,
            Enum enumVal => enumVal.ToString() == "0" || enumVal.ToString().Contains("None"),
            IRedEnum redEnum => redEnum.ToEnumString().Contains("None") || redEnum.ToEnumString() == "0",
            // References and IDs
            NodeRef nodeRef => nodeRef == NodeRef.Empty || string.IsNullOrEmpty(nodeRef.GetResolvedText()),
            TweakDBID tweakId => tweakId == TweakDBID.Empty || string.IsNullOrEmpty(tweakId.GetResolvedText()),
            CRUID cruid => cruid == 0,
            // Spatial types - check for zero/identity values
            Vector3 vec3 => vec3.X == 0 && vec3.Y == 0 && vec3.Z == 0,
            Vector4 vec4 => vec4.X == 0 && vec4.Y == 0 && vec4.Z == 0 && vec4.W == 0,
            Transform transform => IsDefaultTransform(transform),
            Quaternion quat => quat.I == 0 && quat.J == 0 && quat.K == 0 && quat.R == 1, // Identity quaternion
            EulerAngles euler => euler.Pitch == 0 && euler.Yaw == 0 && euler.Roll == 0,
            CColor color => color.Red == 0 && color.Green == 0 && color.Blue == 0 && color.Alpha == 0,
            HDRColor hdrColor => hdrColor.Red == 0 && hdrColor.Green == 0 && hdrColor.Blue == 0 && hdrColor.Alpha == 0,
            // Resource references
            var resRef when resRef.GetType().IsGenericType && 
                           (resRef.GetType().GetGenericTypeDefinition() == typeof(CResourceAsyncReference<>) ||
                            resRef.GetType().GetGenericTypeDefinition() == typeof(CResourceReference<>)) =>
                IsDefaultResourceReference(resRef),
            _ => false
        };
    }
    
    private static bool IsDefaultTransform(Transform transform)
    {
        // Check if position is zero and rotation is identity
        return transform.Position.X == 0 && transform.Position.Y == 0 && transform.Position.Z == 0 &&
               transform.Orientation.I == 0 && transform.Orientation.J == 0 && 
               transform.Orientation.K == 0 && transform.Orientation.R == 1;
    }
    
    private static bool IsDefaultResourceReference(object resourceRef)
    {
        try
        {
            var depotPathProperty = resourceRef.GetType().GetProperty("DepotPath");
            if (depotPathProperty?.GetValue(resourceRef) is ResourcePath depotPath)
            {
                var resolved = depotPath.GetResolvedText();
                return string.IsNullOrEmpty(resolved);
            }
            return true;
        }
        catch
        {
            return true;
        }
    }

    private static string GetDisplayName(string propertyName)
    {
        // Convert camelCase/PascalCase to readable format
        var result = System.Text.RegularExpressions.Regex.Replace(propertyName, "([A-Z])", " $1").Trim();
        
        // Capitalize first letter
        if (result.Length > 0)
        {
            result = char.ToUpper(result[0]) + result.Substring(1);
        }

        return result;
    }

    private static Dictionary<string, string> LimitAndPrioritizeProperties(Dictionary<string, string> properties)
    {
        const int maxProperties = 8;
        
        if (properties.Count <= maxProperties)
        {
            return properties;
        }

        // Prioritize certain properties and limit to max count
        var prioritized = new Dictionary<string, string>();
        
        // Always keep "Type" first
        if (properties.ContainsKey("Type"))
        {
            prioritized["Type"] = properties["Type"];
        }

        // Add high-priority properties
        var highPriority = new[] { "Name", "Path", "Duration", "Action", "Value", "Count", "Mode", "State" };
        foreach (var priority in highPriority)
        {
            var key = properties.Keys.FirstOrDefault(k => k.Contains(priority));
            if (key != null && !prioritized.ContainsKey(key) && prioritized.Count < maxProperties)
            {
                prioritized[key] = properties[key];
            }
        }

        // Fill remaining slots with other properties
        foreach (var kvp in properties.Where(p => !prioritized.ContainsKey(p.Key)))
        {
            if (prioritized.Count >= maxProperties) break;
            prioritized[kvp.Key] = kvp.Value;
        }

        return prioritized;
    }

    private static Dictionary<string, string> GetPropertiesForConditions(questIBaseCondition? node, string logicalCondIndex = "")
    {
        Dictionary<string, string> details = new();

        details[logicalCondIndex + "Condition type"] = GetNameFromClass(node);

        if (node is questTimeCondition condTimeCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condTimeCasted?.Type?.Chunk);

            string ConditionTimeTypeName = logicalCondIndex + "Time condition";
            string ConditionTimeValTypeName = logicalCondIndex + "Time";

            if (condTimeCasted?.Type?.Chunk is questRealtimeDelay_ConditionType nodeRealtimeCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeRealtimeCondCasted);
                details[ConditionTimeValTypeName] =
                    FormatNumber(nodeRealtimeCondCasted?.Hours) + "h:" +
                    FormatNumber(nodeRealtimeCondCasted?.Minutes) + "m:" +
                    FormatNumber(nodeRealtimeCondCasted?.Seconds) + "s:" +
                    FormatNumber(nodeRealtimeCondCasted?.Miliseconds, true) + "ms";
            }

            if (condTimeCasted?.Type?.Chunk is questGameTimeDelay_ConditionType nodeGameTimeCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeGameTimeCondCasted);
                details[ConditionTimeValTypeName] =
                    FormatNumber(nodeGameTimeCondCasted?.Days) + "d " +
                    FormatNumber(nodeGameTimeCondCasted?.Hours) + "h:" +
                    FormatNumber(nodeGameTimeCondCasted?.Minutes) + "m:" +
                    FormatNumber(nodeGameTimeCondCasted?.Seconds) + "s";
            }

            if (condTimeCasted?.Type?.Chunk is questTickDelay_ConditionType nodeTickCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeTickCondCasted);
                details[ConditionTimeValTypeName] = FormatNumber(nodeTickCondCasted?.TickCount) + " ticks";
            }

            if (condTimeCasted?.Type?.Chunk is questTimePeriod_ConditionType nodeTimePeriodCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeTimePeriodCondCasted);

                string timeNameFrom = "";
                string timeNameTo = "";

                if (nodeTimePeriodCondCasted?.Begin?.Seconds != null)
                {
                    TimeSpan t = TimeSpan.FromSeconds((double)(nodeTimePeriodCondCasted?.Begin?.Seconds ?? 0));
                    timeNameFrom = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);
                }

                if (nodeTimePeriodCondCasted?.End?.Seconds != null)
                {
                    TimeSpan t = TimeSpan.FromSeconds((double)(nodeTimePeriodCondCasted?.End?.Seconds ?? 0));
                    timeNameTo = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);
                }

                details[ConditionTimeValTypeName] =
                    "from " + FormatNumber(nodeTimePeriodCondCasted?.Begin?.Seconds) + " (" + timeNameFrom + ")" +
                    " to " + FormatNumber(nodeTimePeriodCondCasted?.End?.Seconds) + " (" + timeNameTo + ")";
            }
        }
        else if (node is questFactsDBCondition condFactCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condFactCasted?.Type?.Chunk);

            if (condFactCasted?.Type?.Chunk is questVarComparison_ConditionType nodeVarCompCondCasted)
            {
                details[logicalCondIndex + "Fact Name"] = nodeVarCompCondCasted?.FactName!;
                details[logicalCondIndex + "Comparison Type"] = nodeVarCompCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Value"] = nodeVarCompCondCasted?.Value.ToString()!;
            }

            if (condFactCasted?.Type?.Chunk is questVarVsVarComparison_ConditionType nodeVarVsVarCondCasted)
            {
                details[logicalCondIndex + "Comparison Type"] = nodeVarVsVarCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Fact 1 Name"] = nodeVarVsVarCondCasted?.FactName1!;
                details[logicalCondIndex + "Fact 2 Name"] = nodeVarVsVarCondCasted?.FactName2!;
            }
        }
        else if (node is questLogicalCondition condLogicalCasted)
        {
            details[logicalCondIndex + "Operation"] = condLogicalCasted?.Operation.ToEnumString()!;
            if (condLogicalCasted?.Conditions != null)
            {
                for (int i = 0; i < condLogicalCasted.Conditions.Count; i++)
                {
                    details.AddRange(GetPropertiesForConditions(condLogicalCasted.Conditions[i]?.Chunk, logicalCondIndex + "#" + i + " "));
                }
            }
        }
        else if (node is questCharacterCondition condCharacterCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condCharacterCasted?.Type?.Chunk);

            if (condCharacterCasted?.Type?.Chunk is questCharacterBodyType_CondtionType nodeCharBodyTypeCondCasted)
            {
                details[logicalCondIndex + "Gender"] = nodeCharBodyTypeCondCasted?.Gender.ToString()!;
                details[logicalCondIndex + "Object Ref"] = ParseGameEntityReference(nodeCharBodyTypeCondCasted?.ObjectRef);
                details[logicalCondIndex + "Is Player"] = nodeCharBodyTypeCondCasted?.IsPlayer == true ? "True" : "False";
            }
            if (condCharacterCasted?.Type?.Chunk is questCharacterSpawned_ConditionType nodeCharSpawnedCondCasted)
            {
                details[logicalCondIndex + "Comparison Type"] = nodeCharSpawnedCondCasted?.ComparisonParams?.Chunk?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Comparison Count"] = nodeCharSpawnedCondCasted?.ComparisonParams?.Chunk?.Count.ToString()!;
                details[logicalCondIndex + "Comparison Entire Community"] = nodeCharSpawnedCondCasted?.ComparisonParams?.Chunk?.EntireCommunity == true ? "True" : "False";
                details[logicalCondIndex + "Object Ref"] = ParseGameEntityReference(nodeCharSpawnedCondCasted?.ObjectRef);
            }
        }
        else if (node is questTriggerCondition condTriggerCasted)
        {
            details[logicalCondIndex + "Activator Ref"] = ParseGameEntityReference(condTriggerCasted?.ActivatorRef);
            details[logicalCondIndex + "Is Player Activator"] = condTriggerCasted?.IsPlayerActivator == true ? "True" : "False";
            details[logicalCondIndex + "Trigger Area Ref"] = condTriggerCasted?.TriggerAreaRef.GetResolvedText()!;
            details[logicalCondIndex + "Trigger Type"] = condTriggerCasted?.Type.ToEnumString()!;
        }
        else if (node is questSystemCondition condSystemCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condSystemCasted?.Type?.Chunk);

            if (condSystemCasted?.Type?.Chunk is questCameraFocus_ConditionType nodeCameraFocusCondCasted)
            {
                details[logicalCondIndex + "Angle Tolerance"] = nodeCameraFocusCondCasted?.AngleTolerance.ToString()!;
                details[logicalCondIndex + "Inverted"] = nodeCameraFocusCondCasted?.Inverted == true ? "True" : "False";
                details[logicalCondIndex + "Object Ref"] = ParseGameEntityReference(nodeCameraFocusCondCasted?.ObjectRef);
                details[logicalCondIndex + "On Screen Test"] = nodeCameraFocusCondCasted?.OnScreenTest == true ? "True" : "False";
                details[logicalCondIndex + "Time Interval"] = nodeCameraFocusCondCasted?.TimeInterval.ToString()!;
                details[logicalCondIndex + "Use Frustrum Check"] = nodeCameraFocusCondCasted?.UseFrustrumCheck == true ? "True" : "False";
                details[logicalCondIndex + "Zoomed"] = nodeCameraFocusCondCasted?.Zoomed == true ? "True" : "False";
            }
        }
        else if (node is questDistanceCondition condDistanceCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condDistanceCasted?.Type?.Chunk);

            if (condDistanceCasted?.Type?.Chunk is questDistanceComparison_ConditionType nodeDistanceComparisonCondCasted)
            {
                details[logicalCondIndex + "Comparison Type"] = nodeDistanceComparisonCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Entity Ref - Entity Reference"] = GetNameFromUniversalRef(nodeDistanceComparisonCondCasted?.DistanceDefinition1?.Chunk?.EntityRef?.Chunk);
                details[logicalCondIndex + "Entity Ref - Main Player Object"] = nodeDistanceComparisonCondCasted?.DistanceDefinition1?.Chunk?.EntityRef?.Chunk?.MainPlayerObject == true ? "True" : "False";
                details[logicalCondIndex + "Entity Ref - Ref Local Player"] = nodeDistanceComparisonCondCasted?.DistanceDefinition1?.Chunk?.EntityRef?.Chunk?.RefLocalPlayer == true ? "True" : "False";
                details[logicalCondIndex + "Node Ref 2"] = ParseGameEntityReference(nodeDistanceComparisonCondCasted?.DistanceDefinition1?.Chunk?.NodeRef2);
                details[logicalCondIndex + "Distance Value"] = nodeDistanceComparisonCondCasted?.DistanceDefinition2?.Chunk?.DistanceValue.ToString()!;
            }
        }
        else if (node is questSceneCondition condSceneCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(condSceneCasted?.Type?.Chunk);

            if (condSceneCasted?.Type?.Chunk is questSectionNode_ConditionType nodeSectionCondCasted)
            {
                details[logicalCondIndex + "Scene File"] = nodeSectionCondCasted?.SceneFile.DepotPath.GetResolvedText()!;
                details[logicalCondIndex + "Scene Version"] = nodeSectionCondCasted?.SceneVersion.ToEnumString()!;
                details[logicalCondIndex + "Section Name"] = nodeSectionCondCasted?.SectionName.ToString()!;
                details[logicalCondIndex + "Cond Type"] = nodeSectionCondCasted?.Type.ToEnumString()!;
            }
        }
        else if (node is questJournalCondition journalCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(journalCasted?.Type?.Chunk);

            if (journalCasted?.Type?.Chunk is questJournalEntryState_ConditionType nodeJournalEntryStateCondCasted)
            {
                details[logicalCondIndex + "Inverted"] = nodeJournalEntryStateCondCasted?.Inverted == true ? "True" : "False";
                details.AddRange(ParseJournalPath(nodeJournalEntryStateCondCasted?.Path?.Chunk, logicalCondIndex));
                details[logicalCondIndex + "State"] = nodeJournalEntryStateCondCasted?.State.ToEnumString()!;
            }
        }
        else if (node is questObjectCondition objectCasted)
        {
            details[logicalCondIndex + "Condition subtype"] = GetNameFromClass(objectCasted?.Type?.Chunk);

            if (objectCasted?.Type?.Chunk is questInventory_ConditionType nodeInventoryCondCasted)
            {
                details[logicalCondIndex + "Comparison Type"] = nodeInventoryCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Is Player"] = nodeInventoryCondCasted?.IsPlayer == true ? "True" : "False";
                details[logicalCondIndex + "Item ID"] = nodeInventoryCondCasted?.ItemID.GetResolvedText()!;
                details[logicalCondIndex + "Item Tag"] = nodeInventoryCondCasted?.ItemTag.GetResolvedText()!;
                details[logicalCondIndex + "Object Ref"] = ParseGameEntityReference(nodeInventoryCondCasted?.ObjectRef);
                details[logicalCondIndex + "Quantity"] = nodeInventoryCondCasted?.Quantity.ToString()!;
            }
        }

        return details;
    }

    public static string SetNameFromNotablePoints(CUInt32 nodeID, scnSceneResource scnSceneResource)
    {
        var notable = scnSceneResource
            .NotablePoints
            .FirstOrDefault(x => x.NodeId.Id == nodeID);

        if (notable != null)
        {
            return " - Notable: " + notable.Name.GetResolvedText()!;
        }

        return "";
    }

    private static string ParseGameEntityReference(gameEntityReference? entRef)
    {
        string str = "-";

        if (entRef != null)
        {
            if (entRef.DynamicEntityUniqueName != "None")
            {
                str = entRef.DynamicEntityUniqueName!;
            }
            if (entRef.Reference != 0)
            {
                str = entRef.Reference.GetResolvedText()!;
            }

            if (entRef.Names.Count > 0)
            {
                string names = "";
                foreach (var name in entRef.Names)
                {
                    names += (names == "" ? "" : ", ") + name;
                }

                str += " [" + names + "]";
            }
        }

        return str;
    }

    public static string GetNameFromClass(RedBaseClass? node)
    {
        string name = "";

        if (node != null)
        {
            name = node.GetType().Name;

            name = name.Replace("quest", "");
            name = name.Replace("_ConditionType", "");
            name = name.Replace("NodeDefinition", "");
            name = name.Replace("_NodeType", "");
            name = name.Replace("_NodeSubType", "");

            //name = AddSpacesToSentence(name);
        }

        return name;
    }

    private static string GetNameFromUniversalRef(questUniversalRef? uniRef)
    {
        string outStr = "";

        string entRef = ParseGameEntityReference(uniRef?.EntityReference);
        if (entRef == "-")
        {
            outStr = uniRef?.RefLocalPlayer == true ? "Ref Local Player" : "";
            outStr += uniRef?.MainPlayerObject == true ? ((outStr != "" ? ", " : "") + "Main Player Object") : "";
        }
        else
        {
            outStr = entRef;
        }

        return outStr;
    }

    private static Dictionary<string, string> ParseBDMask(SBraindanceInputMask? mask)
    {
        Dictionary<string, string> details = new();
        details[" - Camera Toggle Action"] = mask?.CameraToggleAction == true ? "True" : "False";
        details[" - Pause Action"] = mask?.PauseAction == true ? "True" : "False";
        details[" - Play Backward Action"] = mask?.PlayBackwardAction == true ? "True" : "False";
        details[" - Play Forward Action"] = mask?.PlayForwardAction == true ? "True" : "False";
        details[" - Restart Action"] = mask?.RestartAction == true ? "True" : "False";
        details[" - Switch Layer Action"] = mask?.SwitchLayerAction == true ? "True" : "False";
        return details;
    }

    private static Dictionary<string, string> ParseJournalPath(gameJournalPath? gameJournalPath, string possiblePrefix = "")
    {
        Dictionary<string, string> details = new();
        details[possiblePrefix + "Path Class Name"] = gameJournalPath?.ClassName.ToString()!;
        details[possiblePrefix + "Path File Entry Index"] = gameJournalPath?.FileEntryIndex.ToString()!;
        details[possiblePrefix + "Path Real Path"] = gameJournalPath?.RealPath.ToString()!;
        return details;
    }

    private static string ParseMargin(inkMargin? margin)
    {
        string str = "-";
        if (margin != null)
        {
            str = "Left: " + margin.Left + ", ";
            str += "Top: " + margin.Top + ", ";
            str += "Right: " + margin.Right + ", ";
            str += "Bottom: " + margin.Bottom;
        }
        return str;
    }

    private static string GetWorkspotPath(CUInt32? workspotID, scnSceneResource? scnSceneResource)
    {
        string retVal = "";

        if (scnSceneResource != null)
        {
            CUInt32 dataID = 0;

            foreach (var workspotInstance in scnSceneResource.WorkspotInstances)
            {
                if (workspotInstance.WorkspotInstanceId.Id == workspotID)
                {
                    dataID = workspotInstance.DataId.Id;
                }
            }

            if (dataID > 0)
            {
                foreach (var workspot in scnSceneResource.Workspots)
                {
                    if (workspot?.Chunk is scnWorkspotData_ExternalWorkspotResource workspotData)
                    {
                        if (workspotData.DataId.Id == dataID)
                        {
                            retVal = Path.GetFileName(workspotData.WorkspotResource.DepotPath.GetResolvedText()!);
                        }
                    }
                }
            }
        }

        return retVal;
    }

    private static string FormatNumber(CUInt32? number, bool three = false)
    {
        if (number < 10 && !three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else if (number < 10 && three)
        {
            return "00" + (number.ToString() ?? "0");
        }
        else if (number < 100 && three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else
        {
            return (number.ToString() ?? (three ? "000" : "00"));
        }
    }

    private static string FormatNumber(CInt32? number, bool three = false)
    {
        if (number < 10 && !three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else if (number < 10 && three)
        {
            return "00" + (number.ToString() ?? "0");
        }
        else if (number < 100 && three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else
        {
            return (number.ToString() ?? (three ? "000" : "00"));
        }
    }
}
