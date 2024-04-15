using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    [MemberNotNull(nameof(Value))]
    public void CalculateValue()
    {
        Value = "";

        // nothing to calculate
        if (ResolvedData is RedDummy)
        {
            return;
        }

        if (PropertyType.IsAssignableTo(typeof(IRedString)) && Data is IRedString redString)
        {
            var value = redString.GetString();
            if (!string.IsNullOrEmpty(value))
            {
                Value = value;
                if (Value.StartsWith("LocKey#") && ulong.TryParse(Value[7..], out var _))
                {
                    Value = "";
                }
            }
        }
        else if (PropertyType.IsAssignableTo(typeof(CByteArray)) && Data is CByteArray b)
        {
            var ba = (byte[])b;
            Value = string.Join(" ", ba.Select(x => $"{x:X2}"));
        }
        else if (PropertyType.IsAssignableTo(typeof(LocalizationString)) && Data is LocalizationString l)
        {
            Value = l.Value is "" or null ? "null" : l.Value;
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedEnum)) && Data is IRedEnum e)
        {
            Value = e.ToEnumString();
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedBitField)) && Data is IRedBitField f)
        {
            Value = f.ToBitFieldString();
        }
        else if (NodeIdxInParent > -1 && Parent?.Name == "referenceTracks" &&
                 GetRootModel().GetModelFromPath("trackNames")?.ResolvedData is CArray<CName> trackNames)
        {
            Value = trackNames[NodeIdxInParent].GetResolvedText();
            IsValueExtrapolated = true;
        }
        //else if (PropertyType.IsAssignableTo(typeof(TweakDBID)))
        //{
        //    Value = (TweakDBID)Data.ToString();
        //    //Value = Locator.Current.GetService<TweakDBService>().GetString(value);
        //}
        else if (PropertyType.IsAssignableTo(typeof(CBool)) && Data is CBool cb)
        {
            Value = cb ? "True" : "False";
        }
        else if (PropertyType.IsAssignableTo(typeof(CRUID)) && Data is CRUID cr)
        {
            Value = ((ulong)cr).ToString();
        }
        else if (PropertyType.IsAssignableTo(typeof(CUInt64)) && Data is CUInt64 uInt64)
        {
            Value = uInt64 != 0 ? ((NodeRef)(ulong)uInt64).ToString() : ((ulong)uInt64).ToString();
        }
        else if (PropertyType.IsAssignableTo(typeof(gamedataLocKeyWrapper)))
        {
            //var value = (gamedataLocKeyWrapper)Data;
            //Value = ((ulong)value).ToString();
            //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedInteger)) && Data is IRedInteger i)
        {
            Value = i.ToString(CultureInfo.CurrentCulture);
        }
        else if (PropertyType.IsAssignableTo(typeof(FixedPoint)) && Data is FixedPoint fp)
        {
            Value = ((float)fp).ToString("G9");
        }
        else if (PropertyType.IsAssignableTo(typeof(NodeRef)) && Data is NodeRef nr)
        {
            Value = nr;
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedRef)) && Data is IRedRef rr)
        {
            // if a path is resolved in the file, but is not yet added to the list of known hashes, add it
            var depotPath = rr.DepotPath;
            if (!_hashService.Contains(depotPath) && !ResourcePath.IsNullOrEmpty(depotPath))
            {
                _hashService.AddCustom(depotPath.GetResolvedText() ?? "");
            }

            if (depotPath.IsResolvable)
            {
                Value = depotPath.GetResolvedText().NotNull();
            }
            else
            {
                Value = depotPath == ResourcePath.Empty
                    ? "null"
                    : $"{(ulong)depotPath}{_hashService.GetGuessedExtension(depotPath)}";
            }
        }
        else if (Data is IBrowsableType ibt)
        {
            Value = ibt.GetBrowsableValue();
        }
        else if (ResolvedData is animPoseLink link && StringHelper.GetNodeName(link.Node) is string s && s != "") 
        {
            Value = s;
            IsValueExtrapolated = true;
            return;
            
        }

        // factory.csv
        else if (Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray &&
                 Data is CArray<CString> { Count: 3 } ary)
        {
            IsValueExtrapolated = true;
            Value = ary[1];
        }
        // i18n.json
        else if (Data is localizationPersistenceOnScreenEntry i18N)
        {
            IsValueExtrapolated = true;
            // fall back to male variant only if female variant is
            Value = i18N.FemaleVariant;
            if (Value == "" && i18N.MaleVariant != "")
            {
                Value = i18N.MaleVariant;
            }
        }
        // i18n.json
        else if (Data is IRedBaseHandle handle && handle.GetValue() is scnSceneGraphNode sgn)
        {
            IsValueExtrapolated = true;
            Value = StringHelper.Stringify(sgn.OutputSockets);
        }
        
        switch (ResolvedData)
        {
            case CKeyValuePair kvp:
                // If the CValuePair has a value, we'll try to resolve it
                Value = kvp.Value switch
                {
                    CName cname => cname.GetResolvedText() ?? "",
                    IRedRef reference => reference.DepotPath.GetResolvedText() ?? "",
                    _ => kvp.Value.ToString()
                };
                IsValueExtrapolated = true;
                break;
            // csv files: Some of them have a fallbackXYZname
            case IRedArray { Count: > 0 } csvAry when Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray csv:

                var nameIndex = 0;
                for (var i = 0; i < csv.CompiledHeaders.Count; i++)
                {
                    var propertyName = ((string)csv.CompiledHeaders[i]).ToLower();
                    if (!propertyName.Contains("name") && propertyName.Contains("fallback"))
                    {
                        continue;
                    }

                    nameIndex = i;
                    break;
                }

                Value = $"{csvAry[nameIndex]}";
                if (Value != "")
                {
                    IsValueExtrapolated = true;
                    return;
                }

                break;
            
            case meshMeshAppearance { ChunkMaterials: not null } appearance:
                Value = string.Join(", ", appearance.ChunkMaterials);
                Value = $"[{appearance.ChunkMaterials.Count}] {Value}";
                IsValueExtrapolated = true;
                break;
            case CArray<CHandle<meshMeshAppearance>> appearanceArray:
                Value = $"[ {string.Join(", ",
                    appearanceArray.Select(e => (e.GetValue() as meshMeshAppearance)?.Name ?? "").Where((el) => el != ""))} ]";
                IsValueExtrapolated = true;
                break;
            case CArray<CMeshMaterialEntry> materialDefinitions:
                Value = $"[ {string.Join(", ", materialDefinitions.Select((m) => m.Name))} ]";
                IsValueExtrapolated = true;
                break;
            // Material instance (mesh): "[2] - engine\materials\multilayered.mt" (show #keyValuePairs)
            case CMaterialInstance { BaseMaterial: { } cResourceReference } material:
            {
                var numMaterials = $"[{material.Values?.Count ?? 0}] - ";
                Value = $"{numMaterials}{cResourceReference.DepotPath.GetResolvedText() ?? "none"}";
                IsValueExtrapolated = Value != "";
                break;
            }
            case CResourceAsyncReference<IMaterial> materialRef
                when materialRef.DepotPath.GetResolvedText() is string text:
                Value = text;
                IsValueExtrapolated = Value != "";
                break;
            case scnSceneWorkspotDataId sceneWorkspotData when sceneWorkspotData.Id != 0:
                Value = $"{sceneWorkspotData.Id}";
                IsValueExtrapolated = sceneWorkspotData.Id != 0;
                break;
            case worldNode worldNode:
                Value = StringHelper.Stringify(worldNode, true);
                IsValueExtrapolated = Value != "";
                break;
            case graphGraphNodeDefinition nodeDef:
                Value = $"[{nodeDef.Sockets.Count}]";
                IsValueExtrapolated = true;
                return;
            case scnSceneWorkspotInstanceId sceneWorkspotInstance when sceneWorkspotInstance.Id != 0:
                Value = $"{sceneWorkspotInstance.Id}";
                IsValueExtrapolated = sceneWorkspotInstance.Id != 0;
                break;
            case scnNotablePoint scnNotablePoint when scnNotablePoint.NodeId.Id != 0:
                Value = $"NodeId: {scnNotablePoint.NodeId.Id}";
                IsValueExtrapolated = true;
                break;
            case scnActorId scnActorId:
                Value = $"{scnActorId.Id}";
                IsValueExtrapolated = scnActorId.Id != 0;
                break;
            case scnPlayerActorDef playerActorDef:
                Value = $"NodeId: {playerActorDef.SpecCharacterRecordId.GetResolvedText()}";
                IsValueExtrapolated = true;
                break;
            case workWorkEntryId id:
                Value = $"{id.Id}";
                IsValueExtrapolated = true;
                break;
            case questFactsDBCondition condition:
                switch (condition.Type.GetValue())
                {
                    case questVarComparison_ConditionType type:
                        Value = $"{type.ComparisonType.ToEnumString()}: {type.FactName}";
                        break;
                    case questVarVsVarComparison_ConditionType type:
                        Value = $"{type.ComparisonType.ToEnumString()}: {StringHelper.Stringify([type.FactName1, type.FactName2])}";
                        break;

                    default:
                        break;
                }

                IsValueExtrapolated = true;
                break;
            case graphGraphConnectionDefinition conn:
                List<string> nameParts = [];
                if (conn.Source.GetValue() is graphGraphSocketDefinition source)
                {
                    nameParts.Add($"[{source.Connections.Count}] {source.Name.GetResolvedText()}");
                }

                if (conn.Destination.GetValue() is graphGraphSocketDefinition dest)
                {
                    nameParts.Add($"[{dest.Connections.Count}] {dest.Name.GetResolvedText()}");
                }

                // If they're called "In" and "Out", we don't need to know
                Value = string.Join(" -> ", nameParts).Replace(" In", "").Replace(" Out", "");
                IsValueExtrapolated = true;
                break;

            case scnCinematicAnimSetSRRef scnCineAnimRef:
                Value = $"{scnCineAnimRef.AsyncAnimSet.DepotPath.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                if (scnCineAnimRef.IsOverride)
                {
                    var separator = Value == "" ? "" : " | ";
                    Value = $"{Value}{separator}IsOverride: true";
                }

                return;
            case scnVoicesetComponent voiceset:
                Value = voiceset.CombatVoSettingsName.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case entSoundListenerComponent listener when
                listener.ParentTransform?.GetValue() is entHardTransformBinding tBinding:
                Value = StringHelper.Stringify(tBinding);
                IsValueExtrapolated = Value != "";
                break;
            case entAnimationSetupExtensionComponent animSetupComp when
                animSetupComp.ControlBinding.GetValue() is entAnimationControlBinding controlBinding:
                Value = $"{controlBinding.BindName.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                break;
            case entVisualControllerDependency controllerDep:
                Value = $"{controllerDep.Mesh.DepotPath.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                break;
            case IRedArray<CRUID> entry:
                Value = StringHelper.Stringify(entry.Select(id => id.ToString()).ToArray());
                IsValueExtrapolated = Value != "";
                break;
            case animLipsyncMappingSceneEntry entry:
                Value = StringHelper.Stringify(entry.AnimSets, true);
                IsValueExtrapolated = true;
                break;
            case locVoiceoverMap entry:
                Value = $"[{entry.Entries.Count}]";
                IsValueExtrapolated = true;
                break;
            case locVoLengthEntry entry:
                Value = $"{entry.FemaleLength.ToString()}";
                if (entry.MaleLength != 0)
                {
                    Value = $"Fem: {Value} | Masc: {entry.MaleLength.ToString()}";
                }

                IsValueExtrapolated = true;
                break;
            case locVoLineEntry voLineEntry:
                Value = StringHelper.StringifyOrNull(voLineEntry.FemaleResPath.DepotPath, true)
                        ?? StringHelper.StringifyOrNull(voLineEntry.MaleResPath.DepotPath, true)
                        ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case CArray<CResourceAsyncReference<animAnimSet>> entry:
                Value = StringHelper.Stringify(entry);
                IsValueExtrapolated = true;
                break;
            case animAnimSetEntry entry when entry.Animation?.GetValue() is animAnimation animation:

                Value = animation.GetProperty(nameof(Name))?.ToString() ?? "";
                if (ulong.TryParse(Value, out var result))
                {
                    Value = $"{ResourcePathPool.ResolveHash(result)}";
                }

                IsValueExtrapolated = Value != "";

                break;
            case gameBinkVideoRecord videoRecord:
                Value = ResourcePathPool.ResolveHash(videoRecord.ResourceHash);
                IsValueExtrapolated = Value != "";
                break;
            case animAnimNode_Base animNodeBase:
                Value = StringHelper.Stringify(animNodeBase);
                IsValueExtrapolated = Value != "";
                break;
            case entVisualControllerComponent entVisualControllerComponent:
                Value = $"{entVisualControllerComponent.ForcedLodDistance}";
                if (entVisualControllerComponent.MeshProxy.DepotPath.GetResolvedText() is string meshProxyPath &&
                    meshProxyPath != "")
                {
                    var separator = Value == "" ? "" : " | ";
                    Value = $"{Value}{separator}{meshProxyPath}";
                }

                IsValueExtrapolated = Value != "";
                break;
            case entAnimatedComponent animComp:
                if (animComp.FacialSetup.DepotPath.GetResolvedText() is string path)
                {
                    Value = path;
                }
                else if (animComp.Graph.DepotPath.GetResolvedText() is string graphPath)
                {
                    Value = graphPath;
                }
                else
                {
                    Value = $"{animComp.Rig.DepotPath.GetResolvedText()}";
                }

                IsValueExtrapolated = Value != "";
                break;
            case entSlotComponent slotComponent when
                slotComponent.ParentTransform?.GetValue() is entHardTransformBinding tBinding4:
                Value = StringHelper.Stringify(tBinding4);
                IsValueExtrapolated = Value != "";
                break;
            case entSkinningBinding entSkinningBinding:
                Value = $"{entSkinningBinding.BindName.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                break;
            case gameaudioSoundComponent soundComponent:
                Value = $"{soundComponent.AudioName}";
                IsValueExtrapolated = Value != "";
                break;
            case WidgetHudComponent hudComponent:
                Value = $"{hudComponent.HudEntriesResource}";
                IsValueExtrapolated = Value != "";
                break;
            case WidgetMenuComponent menuComponent:
                Value = $"{menuComponent.CursorResource}";
                IsValueExtrapolated = Value != "";
                break;
            case entTriggerComponent triggerComponent when
                triggerComponent.ParentTransform?.GetValue() is entHardTransformBinding tBinding2:
                Value = StringHelper.Stringify(tBinding2);
                IsValueExtrapolated = Value != "";
                break;
            case scnlocLocstringId stringId when
                stringId.Ruid != 0:
                Value = stringId.Ruid.ToString();
                IsValueExtrapolated = true;
                break;
            case scnEntryPoint entryPoint:
                Value = $"NodeID: {entryPoint.NodeId.Id}";
                IsValueExtrapolated = true;
                break;
            case scnExitPoint exitPoint:
                Value = $"NodeID: {exitPoint.NodeId.Id}";
                IsValueExtrapolated = true;
                break;
            case scnlocVariantId variantId:
                Value = variantId.Ruid.ToString();
                break;
            case scnPerformerId performerId:
                Value = performerId.Id.ToString();
                break;
            case CArray<CName> cNames:
                Value = StringHelper.Stringify(cNames);
                IsValueExtrapolated = cNames.Count != 0;
                break;
            case CEvaluatorFloatConst floatConst:
                Value = $"{floatConst.Value}";
                break;
            case CArray<TweakDBID> tweakIds:
                Value = StringHelper.Stringify(tweakIds);
                IsValueExtrapolated = tweakIds.Count != 0;
                break;
            case CParticleEmitter particleEmitter:
            {
                Value = particleEmitter.Material.DepotPath.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            }
            case scnInterruptionScenarioId scenarioId:
                Value = scenarioId.Id.ToString();
                break;
            case effectTrackItemParticles particlesEffect:
                Value = particlesEffect.ParticleSystem.DepotPath.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case effectTrackItemLoopMarker loopMarker:
                Value = $"{loopMarker.TimeDuration}";
                IsValueExtrapolated = Value != "";
                break;
            case scnscreenplayItemId scnscreenplayItemId:
                Value = scnscreenplayItemId.Id.ToString();
                break;
            case scnscreenplayDialogLine scnscreenplayDialogLine:
                Value = scnscreenplayDialogLine.LocstringId.Ruid.ToString();
                IsValueExtrapolated = scnscreenplayDialogLine.LocstringId.Ruid != 0;
                break;
            case scnWorkspotInstance workspotInstance:
                Value = $"{workspotInstance.WorkspotInstanceId.Id}";
                IsValueExtrapolated = workspotInstance.WorkspotInstanceId.Id != 0;
                break;
            case scnWorkspotData_ExternalWorkspotResource externalWorkspotResource:
                Value = externalWorkspotResource.WorkspotResource.DepotPath.GetResolvedText();
                IsValueExtrapolated =
                    externalWorkspotResource.WorkspotResource.DepotPath.GetResolvedText() is not (null or "" or "none");
                break;
            case scnWorkspotData_EmbeddedWorkspotTree externalWorkspotTree:
                Value = externalWorkspotTree.DataId.Id.ToString();
                IsValueExtrapolated = externalWorkspotTree.DataId.Id != 0;
                break;
            case scnGenderMask scnGenderMask:
                Value = scnGenderMask.Mask.ToString();
                IsValueExtrapolated = scnGenderMask.Mask != 0;
                break;
            case scnPerformerSymbol performerSymbol:
                Value = performerSymbol.PerformerId.Id.ToString();
                IsValueExtrapolated = performerSymbol.PerformerId.Id != 0;
                break;
            case scnSceneEventSymbol sceneEventSymbol:
                Value = sceneEventSymbol.OriginNodeId.Id.ToString();
                IsValueExtrapolated = sceneEventSymbol.OriginNodeId.Id != 0;
                break;
            case scnWorkspotSymbol scnWorkspotSymbol:
                Value = scnWorkspotSymbol.WsEditorEventId.ToString();
                IsValueExtrapolated = scnWorkspotSymbol.WsEditorEventId != 0;
                break;
            case scnCinematicAnimSetSRRefId cinematicAnimSetRefId:
                Value = cinematicAnimSetRefId.Id.ToString();
                break;
            case scnlocSignature locSignature:
                Value = locSignature.Val.ToString();
                IsValueExtrapolated = locSignature.Val != 0;
                break;
            case gameEntityReference gameEntRef:
                Value = gameEntRef.Reference.GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case scnPropDef propDef when propDef.FindEntityInNodeParams.NodeRef.GetResolvedText() is string nodeRef &&
                                         nodeRef != "":
                Value = $"NodeRef: {nodeRef}";
                IsValueExtrapolated = true;
                return;
            case scnAnimSetAnimNames animNames when animNames.AnimationNames.Count > 0:
                Value = $"{StringHelper.Stringify(animNames.AnimationNames)}";
                IsValueExtrapolated = true;
                return;
            case rendRenderTextureBlobMemoryLayout rendTexBlobLayout:
                Value = $"rowPitch: {rendTexBlobLayout.RowPitch}, slicePitch: {rendTexBlobLayout.SlicePitch}";
                IsValueExtrapolated = true;
                break;
            case rendRenderTextureBlobPlacement rendTexBlobPlacement:
                Value = $"Offset: {rendTexBlobPlacement.Offset}, size: {rendTexBlobPlacement.Size}";
                IsValueExtrapolated = true;
                break;
            case rendRenderTextureBlobMipMapInfo rendTexMipmapInfo:
                Value = $"rowPitch: {rendTexMipmapInfo.Layout.RowPitch}, slicePitch: {rendTexMipmapInfo.Layout.SlicePitch}";
                IsValueExtrapolated = true;
                break;
            case rendRenderTextureBlobTextureInfo rtbtInfo:
                Value = $"sliceCount: {rtbtInfo.SliceCount}, MipCount: {rtbtInfo.MipCount}";
                IsValueExtrapolated = true;
                break;
            case rendGradientEntry gradient:
                Value = $"{StringHelper.Stringify(gradient.Color)}";
                IsValueExtrapolated = true;
                break;
            case rendRenderTextureBlobSizeInfo rtbSizeInfo:
                Value = $"{rtbSizeInfo.Width} x {rtbSizeInfo.Height}";
                if (rtbSizeInfo.Depth != 1)
                {
                    Value = $"{Value} x {rtbSizeInfo.Depth}";
                }

                IsValueExtrapolated = true;
                break;
            case scnInputSocketId socketId:
                Value = $"{socketId.NodeId.Id}";
                IsValueExtrapolated = socketId.NodeId.Id != 0;
                return;
            case ICollection<scnInputSocketId> socketIds:
                Value = $"{StringHelper.Stringify(socketIds.Select(s => s.NodeId.Id.ToString()).ToArray())}";
                IsValueExtrapolated = Value != "";
                return;
            case scnChoiceNodeOption scnChoiceNodeOption:
                Value = $"{scnChoiceNodeOption.Caption.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                return;
            case scnscreenplayOptionUsage screenplayOptionUsage:
                Value = $"{screenplayOptionUsage.PlayerGenderMask.Mask}";
                IsValueExtrapolated = screenplayOptionUsage.PlayerGenderMask.Mask == 0;
                IsValueExtrapolated = !IsDefault;
                return;
            case scnscreenplayChoiceOption screenplayOption:
                Value = $"{screenplayOption.ItemId.Id} => {screenplayOption.LocstringId.Ruid}";
                IsValueExtrapolated = screenplayOption.ItemId.Id != 0 || screenplayOption.LocstringId.Ruid != 0;
                return;
            case scnSpawnDespawnEntityParams spawnDespawnParams
                when spawnDespawnParams.SpecRecordId.GetResolvedText() is string specRecordId && specRecordId != "":
                Value = $"{specRecordId}";
                IsValueExtrapolated = true;
                return;
            case Transform transform:
                Value = $"{StringHelper.Stringify(transform.Position)}";
                IsValueExtrapolated = Value != "";
                return;
            case scnPropId propId:
                Value = $"{propId.Id}";
                IsValueExtrapolated = propId.Id != 0;
                return;
            case scnSceneSolutionHash scnSolutionHash:
                Value = $"{scnSolutionHash.SceneSolutionHash.SceneSolutionHashDate}";
                IsValueExtrapolated = scnSolutionHash.SceneSolutionHash.SceneSolutionHashDate != 0;
                return;
            case scnSceneSolutionHashHash scnSolutionHashHash:
                Value = $"{scnSolutionHashHash.SceneSolutionHashDate}";
                IsValueExtrapolated = scnSolutionHashHash.SceneSolutionHashDate != 0;
                return;
            case scnGameplayAnimSetSRRef animSetRRef:
                Value = $"{animSetRRef.AsyncAnimSet.DepotPath.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                return;
            case scnFindEntityInNodeParams findInParams
                when findInParams.NodeRef.GetResolvedText() is string s && s != "":
                Value = $"NodeRef: {s}";
                return;
            case scnFindEntityInNodeParams nodeParams
                when nodeParams.NodeRef.GetResolvedText() is string s && s != "":
                Value = $"NodeRef: {s}";
                return;
            case entTriggerActivatorComponent tActivatorComponent:
            {
                if (tActivatorComponent.ParentTransform?.GetValue() is entHardTransformBinding tBinding3)
                {
                    Value = StringHelper.Stringify(tBinding3);
                }

                if (tActivatorComponent.Channels.ToString().Length > 0)
                {
                    var separator = Value == "" ? "" : " -> ";
                    Value = $"{Value}{separator}{tActivatorComponent.Channels}";
                }

                IsValueExtrapolated = Value != "";
                break;
            }
            case gameinteractionsComponent intComponent:
                Value = $"{intComponent.DefinitionResource}";
                IsValueExtrapolated = Value != "";
                break;
            case FxResourceMapData { Resource: gameFxResource fxResourceValue }:
                Value = fxResourceValue.Effect.DepotPath.GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case entMeshComponent meshComponent:
            {
                Value = "";
                if (meshComponent.ParentTransform?.GetValue() is entHardTransformBinding parentTransformValue)
                {
                    Value = StringHelper.Stringify(parentTransformValue);
                }

                if (meshComponent.Mesh.DepotPath.GetResolvedText() is string dePathText)
                {
                    Value = Value.Length == 0 ? $"{dePathText}" : $" ({dePathText})";
                }

                IsValueExtrapolated = Value != "";
                break;
            }
            case entSkinnedMeshComponent skinnedMeshComponent:
            {
                Value = "";
                if (skinnedMeshComponent.ParentTransform?.GetValue() is entHardTransformBinding parentTransformValue)
                {
                    Value = StringHelper.Stringify(parentTransformValue);
                }

                if (skinnedMeshComponent.Mesh.DepotPath.GetResolvedText() is string dePathText)
                {
                    Value = Value.Length == 0 ? $"{dePathText}" : $" ({dePathText})";
                }

                IsValueExtrapolated = Value != "";
                break;
            }
            case locVoiceoverLengthMap lengthMap:
                Value = $"[{lengthMap.Entries.Count}]";
                IsValueExtrapolated = Value != "";
                break;
            case entDynamicActorRepellingComponent repComponent when
                repComponent.ParentTransform?.GetValue() is entHardTransformBinding parentTransformValue:
                Value = StringHelper.Stringify(parentTransformValue);
                IsValueExtrapolated = Value != "";
                break;
            case gameFxResource fxResource:
                Value = fxResource.Effect.DepotPath.GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case senseVisibleObjectComponent visibleComponent when
                visibleComponent.VisibleObject?.GetValue() is senseVisibleObject visibleObject:
                Value = $"{visibleObject.Description}";
                IsValueExtrapolated = Value != "";
                break;
            case workWorkspotAnimsetEntry animsetEntry:
                Value = $"{animsetEntry.Rig.DepotPath.GetResolvedText() ?? "none"}";
                IsValueExtrapolated = true;
                break;
            case gameAudioEmitterComponent audioEmitter:
                Value = $"{audioEmitter.EmitterName}";
                IsValueExtrapolated = Value != "";
                break;
            case CMeshMaterialEntry materialDefinition:
                Value = materialDefinition.IsLocalInstance ? "" : " (external)";
                Value = $"{materialDefinition.Index}{Value}";
                IsValueExtrapolated = true;
                break;
            case animRigRetarget retarget:
                Value = $"{retarget.SourceRig}";
                IsValueExtrapolated = true;
                break;
            case redTagList list:
                Value = $"[ {string.Join(", ", list.Tags.ToList().Select(t => t.GetResolvedText() ?? "").ToArray())} ]";
                IsValueExtrapolated = true;
                break;
            case physicsRagdollBodyInfo when
                NodeIdxInParent > -1 && GetRootModel().GetModelFromPath("ragdollNames")?.ResolvedData is
                    CArray<physicsRagdollBodyNames> ragdollNames:
                var rN = ragdollNames[NodeIdxInParent];
                Value = $"{rN.ParentAnimName.GetResolvedText() ?? ""} -> {rN.ChildAnimName.GetResolvedText() ?? ""}";
                IsValueExtrapolated = true;
                break;
            case scnNodeSymbol scnNodeSymbol when scnNodeSymbol.EditorNodeId.Id != 0:
                Value = $"EditorNodeId: {scnNodeSymbol.EditorNodeId.Id}";
                IsValueExtrapolated = true;
                break;
            default:
                break;
        }

        if (string.IsNullOrEmpty(Value) && TVProperties is [ChunkViewModel child])
        {
            Value = child.Descriptor ?? child.Value;
            IsValueExtrapolated = !string.IsNullOrEmpty(Value);
        }

        // Make sure it's never null
        Value ??= "null";
    }

}