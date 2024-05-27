using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Splat;
using WolvenKit.App.Extensions;
using WolvenKit.App.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes;

internal class NodeProperties
{
    public static Dictionary<string, string> GetPropertiesFor(questNodeDefinition? node)
    {
        Dictionary<string, string> details = new();

        details["Type"] = GetNameFromClass(node);

        var _settingsManager = Locator.Current.GetService<ISettingsManager>();
        if (_settingsManager != null && !_settingsManager.ShowGraphEditorNodeProperties)
        {
            return details;
        }

        if (node is questPauseConditionNodeDefinition pauseCondCasted)
        {
            details.AddRange(GetPropertiesForConditions(pauseCondCasted?.Condition?.Chunk));
        }
        else if (node is questConditionNodeDefinition condCasted)
        {
            details.AddRange(GetPropertiesForConditions(condCasted?.Condition?.Chunk));
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
        }
        else if (node is questEventManagerNodeDefinition eventManagerNodeCasted)
        {
            details["Component Name"] = eventManagerNodeCasted?.ComponentName.ToString()!;
            details["Event"] = eventManagerNodeCasted?.Event?.Chunk?.GetType()?.Name!;
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
                details["Type"] = warningMessageCasted?.Type.ToEnumString()!;
            }
            if (uiManagerNodeCasted?.Type?.Chunk is questProgressBar_NodeType progressBarCasted)
            {
                details["Bottom Text"] = progressBarCasted?.BottomText?.Value!;
                details["Duration"] = progressBarCasted?.Duration.ToString()!;
                details["Show"] = progressBarCasted?.Show == true ? "True" : "False";
                details["Text"] = progressBarCasted?.Text?.Value!;
                details["Type"] = progressBarCasted?.Type.ToEnumString()!;
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
        }

        return details;
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
                for (int i = 0; i <  condLogicalCasted.Conditions.Count; i++)
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
                details[logicalCondIndex + "Count"] = nodeCharSpawnedCondCasted?.ComparisonParams?.Chunk?.Count.ToString()!;
                details[logicalCondIndex + "Entire Community"] = nodeCharSpawnedCondCasted?.ComparisonParams?.Chunk?.EntireCommunity == true ? "True" : "False";
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
        }

        return str;
    }

    private static string GetNameFromClass(RedBaseClass? node)
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
