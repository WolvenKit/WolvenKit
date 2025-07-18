using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;
using static WolvenKit.RED4.Types.RedReflection;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    private bool CalculateDescriptorFromData()
    {
        switch (Data)
        {
            case IBrowsableDictionary ibd:
            {
                var pns = ibd.GetPropertyNames();
                Descriptor = $"[{pns.Count()}]";
                return true;
            }
            case IList list:
                Descriptor = $"[{list.Count}]";
                return true;
            case Dictionary<string, object> dict:
                Descriptor = $"[{dict.Count}]";
                return true;
            case TweakDBID tdb:
                //Descriptor = Locator.Current.GetService<TweakDBService>().GetString(tdb);
                Descriptor = tdb.GetResolvedText();
                return true;
            case gamedataLocKeyWrapper locKey:
                Descriptor = ((ulong)locKey).ToString();
                //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
                return true;
            case gameuiSwitcherInfo:
                if (GetPropertyChild("localizedName") is ChunkViewModel loc && !string.IsNullOrEmpty(loc.Descriptor))
                {
                    Descriptor = loc.Descriptor;
                    return true;
                }

                if (GetPropertyChild("name") is ChunkViewModel name && !string.IsNullOrEmpty(name.Descriptor))
                {
                    Descriptor = name.Descriptor;
                    return true;
                }

                if (GetPropertyChild("link") is ChunkViewModel link && !string.IsNullOrEmpty(link.Descriptor))
                {
                    Descriptor = link.Descriptor;
                    return true;
                }

                return false;
            case gameuiSwitcherOption when GetPropertyChild("localizedName") is ChunkViewModel lName &&
                                           !string.IsNullOrEmpty(lName.Value):

                Descriptor = lName.Value;
                return true;
            case IRedString str:
            {
                var s = str.GetString();
                if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var locKey2))
                {
                    Descriptor = locKey2.ToString();
                }

                return true;
            }
            case Vector3 v3:
                Descriptor = $"{v3.X}, {v3.Y}, {v3.Z}";
                return true;
            case Vector4 v4:
                Descriptor = $"{v4.X}, {v4.Y}, {v4.Z}, {v4.W}";
                return true;
            case Quaternion q:
                Descriptor = $"{q.I}, {q.J}, {q.K}, {q.R}";
                return true;

            default:
                return false;
        }
    }
    
    public void CalculateDescriptor()
    {
        Descriptor = "";


        switch (ResolvedData)
        {
            case null:
            case RedDummy:
                return;
            
            case scnPlaySkAnimEvent playSkAnimEvent:
            {
                var startTime = $"[{playSkAnimEvent.StartTime}ms] ";
                var animDetails = "";
                
                if (playSkAnimEvent.AnimName?.GetValue() is scnAnimName animName && 
                    animName.Unk1 is not null && animName.Unk1.Count > 0)
                {
                    var unk1Details = string.Join(", ", animName.Unk1.Select(u => (string?)u ?? "").Take(3));
                    if (!string.IsNullOrEmpty(unk1Details))
                    {
                        animDetails = $" - {unk1Details}";
                    }
                }
                
                Descriptor = $"{startTime}scnPlaySkAnimEvent{animDetails}";
                return;
            }
            case scnAudioEvent audioEvent:
            {
                var startTime = $"[{audioEvent.StartTime}ms] ";
                var audioName = audioEvent.AudioEventName.GetResolvedText();
                var audioDetails = !string.IsNullOrEmpty(audioName) ? $" - {audioName}" : "";
                
                Descriptor = $"{startTime}scnAudioEvent{audioDetails}";
                return;
            }
            case scnAudioDurationEvent audioDurationEvent:
            {
                var startTime = $"[{audioDurationEvent.StartTime}ms] ";
                var audioName = audioDurationEvent.AudioEventName.GetResolvedText();
                var audioDetails = !string.IsNullOrEmpty(audioName) ? $" - {audioName}" : "";
                
                Descriptor = $"{startTime}scnAudioDurationEvent{audioDetails}";
                return;
            }
            case scneventsVFXEvent vfxEvent:
            {
                var startTime = $"[{vfxEvent.StartTime}ms] ";
                var effectDetails = GetVFXEffectDetails(vfxEvent.EffectEntry);
                
                Descriptor = $"{startTime}scneventsVFXEvent{effectDetails}";
                return;
            }
            case scneventsVFXDurationEvent vfxDurationEvent:
            {
                var startTime = $"[{vfxDurationEvent.StartTime}ms] ";
                var effectDetails = GetVFXEffectDetails(vfxDurationEvent.EffectEntry);
                
                Descriptor = $"{startTime}scneventsVFXDurationEvent{effectDetails}";
                return;
            }
            case scneventsVFXBraindanceEvent vfxBraindanceEvent:
            {
                var startTime = $"[{vfxBraindanceEvent.StartTime}ms] ";
                var effectDetails = GetVFXEffectDetails(vfxBraindanceEvent.EffectEntry);
                
                Descriptor = $"{startTime}scneventsVFXBraindanceEvent{effectDetails}";
                return;
            }
            case scnPlayVideoEvent playVideoEvent:
            {
                var startTime = $"[{playVideoEvent.StartTime}ms] ";
                var videoPath = playVideoEvent.VideoPath.ToString();
                var videoDetails = !string.IsNullOrEmpty(videoPath) ? $" - {System.IO.Path.GetFileName(videoPath)}" : "";
                
                Descriptor = $"{startTime}scnPlayVideoEvent{videoDetails}";
                return;
            }
            case scnSceneEvent sceneEvent:
            {
                // Fallback for other scene events - just show start time
                var startTime = $"[{sceneEvent.StartTime}ms] ";
                var eventType = sceneEvent.GetType().Name;
                
                Descriptor = $"{startTime}{eventType}";
                return;
            }
            
            case worldStreamingSectorDescriptor:
                // handled by default name resolution below
                break;
            case worldNodeData sst when Parent?.Parent?.ResolvedData is worldStreamingSector wss && sst.NodeIndex < wss.Nodes.Count:
                Descriptor = $"[{sst.NodeIndex}] {StringHelper.Stringify(wss.Nodes[sst.NodeIndex].Chunk)}";
                return;
            case worldNode worldNode when StringHelper.Stringify(worldNode) is string s && s != "":
                Descriptor = s;
                return;
            case worldNode:
                // TODO find fallback properties for other node types
                break;
            case CHandle<animAnimNode_Base> { Chunk: animAnimNode_Switch } handle
                when handle.Chunk.GetProperty("InputNodes") is CArray<animPoseLink> animAry:

                Descriptor = StringHelper.Stringify(animAry
                    .Select((animPoseLink) => GetNodeName(animPoseLink.Node) ?? "").ToArray());
                if (Descriptor != "")
                {
                    return;
                }

                break;

            # region inkanim

            case inkanimScaleInterpolator scaleInt:
                Descriptor =
                    $"{StringHelper.Stringify(scaleInt.StartValue)} => {StringHelper.Stringify(scaleInt.EndValue)}";
                break;
            case inkanimAnchorInterpolator scaleInt:
                Descriptor =
                    $"{StringHelper.Stringify(scaleInt.StartValue)} => {StringHelper.Stringify(scaleInt.EndValue)}";
                break;
            case inkanimTransparencyInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimColorInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimEffectInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimRotationInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimMarginInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimPaddingInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimPivotInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimShearInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimSizeInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimTranslationInterpolator transInt:
                Descriptor =
                    $"{StringHelper.Stringify(transInt.StartValue)} => {StringHelper.Stringify(transInt.EndValue)}";
                break;
            case inkanimShapeBorderTransparencyInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimShapeFillTransparencyInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimTextInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case inkanimVideoInterpolator transInt:
                Descriptor = $"{transInt.StartValue} => {transInt.EndValue}";
                break;
            case gameJournalEntry journalEntry:
                Descriptor = journalEntry.Id.ToString();
                break;
            
            # endregion
            // csv files
            case IRedArray { Count: > 0 } csvAry when Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray csv:

                var nameIndex = 0;
                for (var i = 0; i < csv.CompiledHeaders.Count; i++)
                {
                    // ReSharper disable once InvertIf
                    if (((string)csv.CompiledHeaders[i]).Contains("name", StringComparison.InvariantCultureIgnoreCase))
                    {
                        nameIndex = i;
                        break;
                    }
                }

                Descriptor = $"{csvAry[nameIndex]}";
                if (Descriptor != "")
                {
                    return;
                }

                break;

            // regular arrays
            case IRedArray { Count: > 0 } ary:
            {
                Descriptor = $"[{ary.Count}]";
                break;
            }
            case appearanceAppearancePart part:
            {
                Descriptor = part.Resource.DepotPath.GetResolvedText() ?? "";
                if (Descriptor != "")
                {
                    return;
                }

                break;
            }
            case locVoLineEntry voLineEntry:
            {
                Descriptor = voLineEntry.StringId.ToString();
                if (Descriptor != "")
                {
                    return;
                }

                break;
            }
            case animAnimEvent animEvent:
            {
                Descriptor = animEvent.EventName.GetResolvedText();
                if (Descriptor != "")
                {
                    return;
                }

                break;
            }
            case locVoLengthEntry voLengthEntry:
            {
                Descriptor = voLengthEntry.StringId.ToString();
                if (Descriptor != "")
                {
                    return;
                }

                break;
            }
            case animAnimSetEntry entry when entry.Animation?.GetValue() is animAnimation animation:
            {
                Descriptor = animation.GetProperty(nameof(Name))?.ToString() ?? "";

                if (ulong.TryParse(Descriptor, out var result))
                {
                    Descriptor = ResourcePathPool.ResolveHash(result);
                }

                if (Descriptor != "")
                {
                    return;
                }

                break;
            }
            case scnWorkspotData_ExternalWorkspotResource externalWorkspotResource:
                Descriptor = $"{externalWorkspotResource.DataId.Id.ToString()}";
                return;
            case animAnimSetupEntry animSetupEntry:
                Descriptor = $"{animSetupEntry.AnimSet.DepotPath.GetResolvedText()}";
                return;
            case entAnimationControlBinding controlBinding:
                Descriptor = $"{controlBinding.BindName.GetResolvedText()}";
                return;
            case scnSceneWorkspotInstanceId workspotInstanceId:
                Descriptor = $"{workspotInstanceId.Id}";
                return;
            case scnWorkspotInstance workspotInstance:
                Descriptor = $"{workspotInstance.OriginMarker.NodeRef.GetResolvedText()}";
                return;
            case scnChoiceNodeOption choiceNodeOption:
                Descriptor = $"{choiceNodeOption.Caption}";
                return;
            case scnSectionNode sectionNode:
                Descriptor = $"{sectionNode.NodeId.Id}";
                return;
            case gameAnimParamSlotsOption slotsOption:
                Descriptor = $"{slotsOption.SlotID.GetResolvedText()}";
                return;
            case scnInteractionShapeParams shapeParams:
                Descriptor = $"{shapeParams.Preset}";
                return;
            case scnSceneWorkspotDataId workspotDataId:
                Descriptor = $"{workspotDataId.Id}";
                return;
            case scnNodeId id:
                Descriptor = $"{id.Id}";
                return;
            case scnPlayerActorDef playerActorDef:
                Descriptor = $"{playerActorDef.PlayerName}";
                return;
            case scnMarker sceneMarker:
                Descriptor = sceneMarker.NodeRef.GetResolvedText();
                break;
            case scnlocLocStoreEmbeddedVariantDescriptorEntry locDescriptorEmbedded when
                locDescriptorEmbedded.VpeIndex > 0:
                Descriptor = locDescriptorEmbedded.VpeIndex.ToString();
                break;
            case scnlocLocStoreEmbeddedVariantPayloadEntry locPayloadEmbedded:
                Descriptor = locPayloadEmbedded.VariantId.Ruid.ToString();
                break;
            case scnPropDef propDef:
            {
                Descriptor = $"{propDef.PropName}";
                if (propDef.SpecPropRecordId.GetResolvedText() is string s && s != "")
                {
                    Descriptor = $"{Descriptor} ID: {s}";
                }

                return;
            }
            case scnSpawnDespawnEntityParams spawnDespawnParams:
            {
                Descriptor = $"{spawnDespawnParams.DynamicEntityUniqueName.GetResolvedText()}";
                if (spawnDespawnParams.SpawnMarkerNodeRef.GetResolvedText() is string s && s != "")
                {
                    Descriptor = $"{Descriptor} ID: {s}";
                }

                return;
            }
            case scnNodeSymbol scnNodeSymbol:
                Descriptor = $"NodeID: {scnNodeSymbol.NodeId.Id}";
                return;
            case scnWorkspotSymbol scnWorkspotSymbol:
                Descriptor = $"NodeID: {scnWorkspotSymbol.WsInstance.Id} (Instance {scnWorkspotSymbol.WsInstance.Id})";
                return;
            case scnSceneEventSymbol sceneEventSymbol:
                Descriptor = $"EditorEventId: {sceneEventSymbol.EditorEventId}";
                return;
            case scnPerformerSymbol performerSymbol:
                Descriptor = $"{performerSymbol.EntityRef.DynamicEntityUniqueName.GetResolvedText()}";
                return;
            case gameEntityReference gameEntRef:
                Descriptor = $"{gameEntRef.DynamicEntityUniqueName.GetResolvedText()}";
                return;
            case scnLipsyncAnimSetSRRef lipsyncAnim:
                Descriptor = StringHelper.StringifyOrNull(lipsyncAnim.LipsyncAnimSet.DepotPath)
                             ?? StringHelper.StringifyOrNull(lipsyncAnim.AsyncRefLipsyncAnimSet.DepotPath) ?? "";
                if (Descriptor != "")
                {
                    return;
                }

                break;

            case appearanceAppearancePartOverrides partsOverrides
                when partsOverrides.PartResource.DepotPath.GetResolvedText() is string s && !string.IsNullOrEmpty(s):
                Descriptor = s;
                return;
            
            case scnscreenplayDialogLine scnscreenplayDialogLine:
            {
                Descriptor = scnscreenplayDialogLine.FemaleLipsyncAnimationName.GetResolvedText() ?? "";
                if (StringHelper.StringifyOrNull(scnscreenplayDialogLine.MaleLipsyncAnimationName) is string s1)
                {
                    var separator = Value == "" ? "" : " | ";
                    Descriptor = $"{Descriptor}{separator}${s1}";
                }

                break;
            }
            case CMeshMaterialEntry materialEntry:
                Descriptor = materialEntry.Name.GetResolvedText() ?? "";
                break;
            // For local and external materials
            case CMaterialInstance or CResourceAsyncReference<IMaterial>
                when NodeIdxInParent > -1
                     && GetRootModel().GetPropertyFromPath("materialEntries")?.ResolvedData is CArray<CMeshMaterialEntry> materialEntries
                     && materialEntries.Count > NodeIdxInParent:
            {
                var isLocalMaterial = ResolvedData is CMaterialInstance;
                var entry = materialEntries[NodeIdxInParent];

                // If we immediately found the right material: use material name
                if (entry.IsLocalInstance == isLocalMaterial && entry.Index == NodeIdxInParent)
                {
                    Descriptor = entry.Name.GetResolvedText();
                    if (Descriptor != null)
                    {
                        return;
                    }
                }

                // Else: Iterate to find material name
                entry = materialEntries
                    .FirstOrDefault(e => e.Index == NodeIdxInParent && e.IsLocalInstance == isLocalMaterial);

                // Will return null if no entry is found
                Descriptor = entry?.Name.GetResolvedText();

                if (Descriptor != null)
                {
                    return;
                }

                break;
            }
            case localizationPersistenceOnScreenEntry localizationPersistenceOnScreenEntry:
            {
                var desc = $"[{localizationPersistenceOnScreenEntry.PrimaryKey}]";
                if (!string.IsNullOrEmpty(localizationPersistenceOnScreenEntry.SecondaryKey))
                {
                    desc += $" {localizationPersistenceOnScreenEntry.SecondaryKey}";
                }

                Descriptor = desc;
                break;
            }
            case LocalizationString localizationString:
            {
                if (!string.IsNullOrEmpty(localizationString.Value) && 
                    localizationString.Value.StartsWith("LocKey#") &&
                    ulong.TryParse(localizationString.Value[7..], out var locKey) &&
                    _locKeyService.GetEntry(locKey) is { } locEntry)
                {
                    var desc = $"[{locEntry.PrimaryKey}]";
                    if (!string.IsNullOrEmpty(locEntry.SecondaryKey))
                    {
                        desc += $" {locEntry.SecondaryKey}";
                    }

                    Descriptor = desc;
                }
                
                break;
            }
            case entHardTransformBinding tBinding:
                Descriptor = tBinding.BindName;
                break;
            case WorldTransform bind:
                Descriptor = StringHelper.Stringify(bind);
                return;
            case WorldPosition position:
                Descriptor = StringHelper.Stringify(position);
                return;
            case inkTextureSlot texturesSlot:
            {
                Descriptor = StringHelper.StringifyOrNull(texturesSlot.Texture.DepotPath);
                if (Descriptor is not null)
                {
                    return;
                }

                break;
            }
            case entEffectDesc { EffectName: var name }:
            {
                Descriptor = name;
                if (Descriptor is not null and not "")
                {
                    return;
                }

                break;
            }
            case senseVisibleObject senseVisibleObject:
            {
                Descriptor = senseVisibleObject.Description;

                if (Descriptor is not null and not "")
                {
                    return;
                }

                break;
            }
            case FxResourceMapData mapData:
            {
                Descriptor = mapData.Key;
                if (Descriptor is not null and not "")
                {
                    return;
                }

                break;
            }
            case CParticleEmitter particleEmitter:
            {
                Descriptor = particleEmitter.EditorName;
                if (Descriptor is not null and not "")
                {
                    return;
                }

                break;
            }
            case rendGradientEntry rendGradientEntry:
                Descriptor = $"{rendGradientEntry.Value}";
                break;
            case localizationPersistenceOnScreenEntries jsonRoot:
            {
                Descriptor = $"[{jsonRoot.Entries.Count}]";
                return;
            }
            case gameFxResource fxResource:
            {
                Descriptor = StringHelper.StringifyOrNull(fxResource.Effect.DepotPath);
                if (Descriptor is not null)
                {
                    return;
                }

                break;
            }
            case gameBinkVideoRecord videoRecord:
            {
                Descriptor = $"{videoRecord.BinkDuration}";
                if (Descriptor is not "")
                {
                    return;
                }

                break;
            }
            case IRedMeshComponent meshComponent
                when meshComponent.Name.GetResolvedText() is string name && name != "":
            {
                IsDefault = name == "Component";
                Descriptor = name;
                return;
            }
            case IRedBufferPointer rbp when rbp.GetValue().Data is RedPackage pkg:
                Descriptor = $"[{pkg.Chunks.Count}]";
                break;
            case IRedBufferPointer rbp2 when rbp2.GetValue().Data is CR2WList cl:
                Descriptor = $"[{cl.Files.Count}]";
                break;
            case CKeyValuePair kvp:
                Descriptor = kvp.Key;
                break;
            case questNodeDefinition qnd:
                Descriptor = qnd.Id.ToString();
                return;
            case questVarComparison_ConditionType qnd:
                Descriptor = qnd.FactName;
                return;
            case questVarVsVarComparison_ConditionType qnd:
                Descriptor = StringHelper.Stringify([qnd.FactName1, qnd.FactName2]);
                return;
            case scnSceneGraphNode sgn:
                Descriptor = sgn.NodeId.Id.ToString();
                return;
            case Multilayer_Layer layer:
                Descriptor = StringHelper.Stringify(layer.Material.DepotPath, true);
                break;
            case meshMeshMaterialBuffer matBuffer:
                // ReSharper disable once ConditionalAccessQualifierIsNonNullableAccordingToAPIContract this can be null!
                Descriptor = $"[{matBuffer.Materials?.Count ?? 0}]";
                return;
            case worldCompiledEffectInfo info:
                Descriptor = string.Join(", ", info.PlacementInfos);
                return;
            case animAnimNode_Container nodeContainer:
                Descriptor = $"[{nodeContainer.Nodes.Count}]";
                return;
            default:
            {
                // mesh: boneTransforms (in different coordinate spaces)
                if (NodeIdxInParent > -1 &&
                    Parent?.Name is "boneTransforms" or "aPoseLS" or "aPoseMS" &&
                    GetRootModel().GetPropertyFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                    boneNames.Count > NodeIdxInParent)
                {
                    Descriptor = boneNames[NodeIdxInParent];
                    break;
                }

                if (CalculateDescriptorFromData())
                {
                    return;
                }

                break;
            }
        }


        if (ResolvedData is RedBaseClass irc)
        {
            foreach (var propName in s_descriptorPropNames)
            {
                var prop = GetPropertyByRedName(irc.GetType(), propName);
                if (prop is null)
                {
                    continue;
                }

                var desc = irc.GetProperty(prop.RedName.NotNull())?.ToString();
                if (desc is null or "None" or "")
                {
                    continue;
                }

                Descriptor = desc;
                return;
            }
        }
        else
        {
            foreach (var propName in s_descriptorPropNames)
            {
                var prop = Data?.GetType().GetProperty(propName);

                if (prop is null)
                {
                    continue;
                }

                var val = prop.GetValue(Data)?.ToString();
                if (val is not null and not "" and not "None")
                {
                    Descriptor = val;
                }

                return;
            }
        }

        // Make sure that it's not null
        Descriptor ??= "";
    }

    private string GetVFXEffectDetails(scnEffectEntry effectEntry)
    {
        if (effectEntry == null)
        {
            return "";
        }
            
        // First try to use EffectName if available
        if (effectEntry.EffectName != CName.Empty)
        {
            var effectName = effectEntry.EffectName.GetResolvedText();
            if (!string.IsNullOrEmpty(effectName))
            {
                return $" - {effectName}";
            }
        }
        
        // If no effect name, try to resolve through EffectInstanceId
        if (effectEntry.EffectInstanceId != null && GetRootModel().ResolvedData is scnSceneResource sceneResource)
        {
            var instanceId = effectEntry.EffectInstanceId.Id;
            var effectId = effectEntry.EffectInstanceId.EffectId.Id;
            
            // Find the effect definition
            var effectDef = sceneResource.EffectDefinitions
                .FirstOrDefault(e => e.Id.Id == effectId);
                
            if (effectDef != null)
            {
                var effectPath = effectDef.Effect.DepotPath.GetResolvedText();
                if (!string.IsNullOrEmpty(effectPath))
                {
                    var filename = System.IO.Path.GetFileNameWithoutExtension(effectPath);
                    return $" - {filename}";
                }
            }
            
            // If we have instance ID but no effect definition, show instance/effect IDs
            if (instanceId != uint.MaxValue && effectId != uint.MaxValue)
            {
                return $" - Instance:{instanceId}/Effect:{effectId}";
            }
        }
        
        return "";
    }

    /// <summary>
    /// Property names for descriptor field
    /// </summary>
    private static readonly string[] s_descriptorPropNames =
    [
        "name", // default property
        "partName", // ?
        "slotName", // ?
        "hudEntryName", // ?
        "stateName", // ?
        "characterRecordId", // tweak record children
        "secondaryKey", // json
        "femaleVariant", // also json
        "maleVariant", // also json
        "n", // ?
        "componentName", // ?
        "parameterName", // ?
        "debugName", // e.g. nodes
        "expressionString", // e.g. animMathExpressionNodes
        "idleAnim", // .workspot handle work entry items
        "category", // ?
        "entryName", // ?
        "className", // ?
        "actorName", // ?
        "sectorHash", // sectors
        "propertyPath", // ?
        "link", // gameuiSwitcherInfo
    ];

    private static readonly string[] s_nonRenamableProperties =
    [
        "propertyPath",
        "className",
    ];
    // For search&replace

    private static readonly string[] s_replacementPropertyNames = s_descriptorPropNames
        .Where((s) => !s_nonRenamableProperties.Contains(s))
        .Concat<string>([
            "depotPath",
            "meshAppearance",
            "mesh",
        ]).ToArray();

}