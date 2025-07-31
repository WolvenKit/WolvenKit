using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;
using static WolvenKit.RED4.Types.Enums;

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
            var value = l.Value;
            if (!string.IsNullOrEmpty(value))
            {
                Value = value;
                if (Value.StartsWith("LocKey#") && ulong.TryParse(Value[7..], out var _))
                {
                    Value = "";
                }
            }
        }
        else if (DisplayAsEnumType != null && Data is IRedInteger ri)
        {
            if (EnumHelper.IsBitfield(DisplayAsEnumType))
            {
                Value = EnumHelper.RedIntToBitfieldString(DisplayAsEnumType, ri);
            }
            else
            {
                Value = EnumHelper.RedIntToEnumString(DisplayAsEnumType, ri);
            }
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
                 GetRootModel().GetPropertyFromPath("trackNames")?.ResolvedData is CArray<CName> trackNames)
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
            var depotPath = rr.DepotPath;
            
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
        else if (ResolvedData is inkTextureSlot inkTextureSlot)
        {
            Value = $"[{inkTextureSlot.Parts.Count}]";
            IsValueExtrapolated = true;
            return;
        }

        else if (ResolvedData is gameuiOptionsGroup &&
                 GetPropertyChild("options") is ChunkViewModel opts && !string.IsNullOrEmpty(opts.Value))
        {
            Value = $"{opts.Value}";
            IsValueExtrapolated = true;
            return;
        }
        else if (ResolvedData is gameuiSwitcherInfo &&
                 GetPropertyChild("names") is ChunkViewModel switcherOpts && !string.IsNullOrEmpty(switcherOpts.Value))
        {
            Value = $"{switcherOpts.Value}";
            IsValueExtrapolated = true;
            return;
        }
        else if ((ResolvedData is gameuiSwitcherInfo or gameuiSwitcherOption)
                 && GetPropertyChild("names") is { Value: string names })
        {
            Value = $"{names}";
            IsValueExtrapolated = true;
            return;
        }
        // inkcc
        else if (ResolvedData is IRedArray { Count: > 0 } tagsAry && Name is "editTags")
        {
            List<string> descriptorParts = [];
            for (var j = 0; j < tagsAry.Count; j++)
            {
                if (tagsAry[j] is not IRedEnum tag)
                {
                    continue;
                }

                // ReSharper disable once InvertIf
                if (tag.ToEnumString() is string tagName && tagName != "")
                {
                    descriptorParts.Add(tagName);
                }
            }

            if (descriptorParts.Count > 0)
            {
                Descriptor = StringHelper.Stringify(descriptorParts.ToArray());
                IsValueExtrapolated = true;
                return;
            }
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

                var pathIndex = 0;
                for (var i = 0; i < csv.CompiledHeaders.Count; i++)
                {
                    var propertyName = ((string)csv.CompiledHeaders[i]).ToLower();
                    // ReSharper disable once InvertIf
                    if (propertyName.Contains("path") && !propertyName.Contains("fallback"))
                    {
                        pathIndex = i;
                        break;
                    }
                }

                Value = $"{csvAry[pathIndex]}";
                if (Value != "")
                {
                    IsValueExtrapolated = true;
                    return;
                }

                break;
            case inkanimDefinition animDef:
                Value = StringHelper.Stringify(animDef);
                IsValueExtrapolated = Value != "";
                break;
            case rendIndexBufferChunk rendBuffer:
                Value = rendBuffer.TeOffset.ToString();
                IsValueExtrapolated = true;
                break;
            case inkanimInterpolator inkAnimInt:
                Value = StringHelper.Stringify(inkAnimInt);
                IsValueExtrapolated = true;
                break;
            case inkanimSequenceTargetInfo targetInfo:
                Value = $"[{string.Join(", ", targetInfo.Path)}]";
                IsValueExtrapolated = true;
                break;

            case CurvePoint<CFloat> cP:
                Value = $"Point: {cP.Point}, Value: {cP.Value}";
                IsValueExtrapolated = true;
                break;
            case effectTrackItemDecal dec:
                Value = $"{dec.Material.DepotPath.GetResolvedText()}";
                IsValueExtrapolated = Value != "";
                break;
            case effectLoopData dec:
                Value = $"{dec.StartTime} => {dec.EndTime}";
                IsValueExtrapolated = Value != "";
                break;
            case effectTrackItemPointLight light:
                Value = $"{StringHelper.Stringify(light.Color)}, EV: {light.EV}";
                IsValueExtrapolated = Value != "";
                break;
            case effectTrack track:
                Value = $"[{track.Items.Count}]";
                IsValueExtrapolated = true;
                break;

            case gameJournalFolderEntry folderEntry:
                Value = $"[{folderEntry.Entries.Count}]";
                IsValueExtrapolated = true;
                break;
            case IRedArray<IRedHandle<gameJournalFolderEntry>> ary:
                Value = StringHelper.Stringify(ary);
                IsValueExtrapolated = Value != "";
                break;
            case IRedArray<IRedHandle<graphGraphNodeDefinition>> nodeDefs:
                Value = StringHelper.Stringify(nodeDefs);
                IsValueExtrapolated = Value != "";
                break;
            case IRedArray<gameJournalFolderEntry> ary:
                Value = StringHelper.Stringify(ary);
                IsValueExtrapolated = Value != "";
                break;
            
            case worldCompiledEffectPlacementInfo epI when Parent?.Parent?.ResolvedData is worldCompiledEffectInfo info:
                if (info.RelativePositions.Count > epI.RelativePositionIndex)
                {
                    Value = $"pos: {StringHelper.Stringify(info.RelativePositions[epI.RelativePositionIndex])}";
                }

                if (info.RelativeRotations.Count > epI.RelativeRotationIndex)
                {
                    if (Value != "")
                    {
                        Value = $"{Value}, ";
                    }

                    Value = $"{Value}rot: {StringHelper.Stringify(info.RelativeRotations[epI.RelativeRotationIndex])}";
                }

                IsValueExtrapolated = Value != "";
                break;

            case CUInt8 when Parent?.ResolvedData is worldCompiledEffectPlacementInfo:
                Value = Name switch
                {
                    "relativePositionIndex" when Parent.Value?.Contains("pos:") == true => Parent.Value.Split(", ")[0],
                    "relativeRotationIndex" when Parent.Value?.Contains("rot:") == true => Parent.Value.Split(", ")
                        .LastOrDefault() ?? "",
                    _ => Value
                };

                IsValueExtrapolated = Value != "";
                break;

            case worldStreamingBlockIndex wsbI:
                Value = wsbI.RldGridCell.ToString();
                IsValueExtrapolated = true;
                return;

            case worldStreamingSectorDescriptor wssd:
                List<string> valueParts = [];
                if (wssd.NumNodeRanges > 1)
                {
                    valueParts.Add($"#{wssd.NumNodeRanges}");
                }

                if (wssd.Level > 0)
                {
                    valueParts.Add($"L{wssd.Level}");
                }

                if (wssd.Variants.Count > 0)
                {
                    valueParts.Add($"{wssd.Variants.Count} variants");
                }

                if (StringHelper.Stringify(wssd.QuestPrefabNodeRef) is string nodeStr && !string.IsNullOrEmpty(nodeStr))
                {
                    valueParts.Add($"{nodeStr.Split("/").Last()}");
                }
                else if (StringHelper.Stringify(wssd.Data.DepotPath) is string depotPath && depotPath != string.Empty)
                {
                    valueParts.Add(
                        $"{depotPath.Split(Path.DirectorySeparatorChar).Last()}".Replace(".streamingsector", ""));
                }

                Value = string.Join(", ", valueParts);
                IsValueExtrapolated = Value != string.Empty;
                return;

            case Box box:
                Value = $"{StringHelper.Stringify(box.Min)} - {StringHelper.Stringify(box.Max)}";
                IsValueExtrapolated = true;
                return;

            case appearanceAppearancePartOverrides partsOverrides:
                if (GetPropertyChild("componentsOverrides") is ChunkViewModel cvm)
                {
                    Value = cvm.Value;
                }
                else
                {
                    Value = $"[{partsOverrides.ComponentsOverrides.Count}] {Value}";
                }

                IsValueExtrapolated = true;
                break;
            case CArray<appearancePartComponentOverrides> ary:
                foreach (var t in ary)
                {
                    if (t.ComponentName.GetResolvedText() is string partName && partName != "")
                    {
                        Value = $"{Value} {partName}";
                    }
                }

                if (string.IsNullOrEmpty(Value))
                {
                    Value = "0";
                }

                IsValueExtrapolated = true;
                Value = $"[{Value!.Trim()}]";

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
                // ReSharper disable once ConditionalAccessQualifierIsNonNullableAccordingToAPIContract yeah right
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
            case CMatrix when Parent?.Name == "boneRigMatrices" &&
                              GetRootModel().GetPropertyFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                              boneNames.Count > NodeIdxInParent:
                Value = boneNames[NodeIdxInParent].GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case Vector4 when Parent?.Name == "bonePositions" &&
                              GetRootModel().GetPropertyFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                              boneNames.Count > NodeIdxInParent:
                Value = boneNames[NodeIdxInParent].GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case CFloat when Parent?.Name == "boneVertexEpsilons" &&
                             GetRootModel().GetPropertyFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                             boneNames.Count > NodeIdxInParent:
                Value = boneNames[NodeIdxInParent].GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case CInt16 boneIdx when Parent?.Name == "boneParentIndexes" &&
                                     GetRootModel().GetPropertyFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                                     boneNames.Count > NodeIdxInParent:
                Value = boneNames[NodeIdxInParent].GetResolvedText();
                IsValueExtrapolated = Value != "";
                if (boneIdx > 0 && boneIdx < boneNames.Count)
                {
                    Value = $"{Value} -> {boneNames[boneIdx].GetResolvedText()}";
                }

                break;
            case scnSceneWorkspotDataId sceneWorkspotData when sceneWorkspotData.Id != 0:
                Value = $"{sceneWorkspotData.Id}";
                IsValueExtrapolated = sceneWorkspotData.Id != 0;
                break;
            case worldNodeData sst when Parent?.Parent?.ResolvedData is worldStreamingSector wss && sst.NodeIndex < wss.Nodes.Count:
                var node = wss.Nodes[sst.NodeIndex].Chunk;
                Value = $"#{sst.NodeIndex}";
                if (node?.GetType().Name is string nodeName && !string.IsNullOrEmpty(nodeName))
                {
                    Value = $"{Value} => {nodeName}";
                }

                IsValueExtrapolated = true;
                return;
            case worldNode worldNode:
                Value = StringHelper.Stringify(worldNode, true);
                IsValueExtrapolated = Value != "";
                break;
            case worldStreamingSectorVariant sectorVar:
                Value = $"#{sectorVar.RangeIndex}";
                if (sectorVar.NodeRef != NodeRef.Empty)
                {
                    Value = $"{Value} => {sectorVar.NodeRef.GetResolvedText()!}";
                }

                IsValueExtrapolated = true;
                return;
            case graphGraphNodeDefinition nodeDef:
                Value = $"[{nodeDef.Sockets.Count}]";
                IsValueExtrapolated = true;
                return;
            case scnNotablePoint scnNotablePoint when scnNotablePoint.NodeId.Id != 0:
                Value = $"NodeId: {scnNotablePoint.NodeId.Id}";
                IsValueExtrapolated = true;
                break;
            case scnActorId scnActorId:
                Value = $"{scnActorId.Id}";
                IsValueExtrapolated = scnActorId.Id != 0;
                break;
            case scnPerformerId scnPerformerId when GetRootModel().ResolvedData is scnSceneResource sceneForPerformer:
                Value = $"{scnPerformerId.Id}";
                IsValueExtrapolated = scnPerformerId.Id != 0;
                
                if (sceneForPerformer.DebugSymbols?.PerformersDebugSymbols != null)
                {
                    var performerSymbol = sceneForPerformer.DebugSymbols.PerformersDebugSymbols
                        .FirstOrDefault(p => p.PerformerId.Id == scnPerformerId.Id);
                    if (performerSymbol != null)
                    {
                        string? performerName = null;
                        if (performerSymbol.EntityRef?.Names != null && performerSymbol.EntityRef.Names.Count > 0)
                        {
                            performerName = performerSymbol.EntityRef.Names[0].GetResolvedText();
                        }
                        
                        if (string.IsNullOrEmpty(performerName) && performerSymbol.EntityRef?.Reference != null)
                        {
                            var referenceString = performerSymbol.EntityRef.Reference.ToString();
                            if (!string.IsNullOrEmpty(referenceString) && referenceString != "NodeRef")
                            {
                                performerName = referenceString.StartsWith("#") ? referenceString.Substring(1) : referenceString;
                            }
                        }
                        
                        if (!string.IsNullOrEmpty(performerName))
                        {
                            Value = $"{scnPerformerId.Id}: {performerName}";
                        }
                    }
                }
                break;
            case scnSceneWorkspotInstanceId sceneWorkspotInstance when GetRootModel().ResolvedData is scnSceneResource sceneForWorkspot:
                 Value = $"{sceneWorkspotInstance.Id}";
                 IsValueExtrapolated = sceneWorkspotInstance.Id != 0;
                 
                 var matchingWorkspotInstance = sceneForWorkspot.WorkspotInstances
                     .FirstOrDefault(w => w.WorkspotInstanceId.Id == sceneWorkspotInstance.Id);
                 if (matchingWorkspotInstance != null)
                 {
                     var instanceDataId = matchingWorkspotInstance.DataId.Id;
                     var workspotResource = sceneForWorkspot.Workspots
                         .FirstOrDefault(w => w.Chunk is scnWorkspotData workspotData && workspotData.DataId.Id == instanceDataId);
                     
                     if (workspotResource?.Chunk is scnWorkspotData_ExternalWorkspotResource externalWorkspot)
                     {
                         var workspotPath = externalWorkspot.WorkspotResource.DepotPath.GetResolvedText();
                         if (!string.IsNullOrEmpty(workspotPath))
                         {
                             var filename = System.IO.Path.GetFileNameWithoutExtension(workspotPath);
                             Value = $"{sceneWorkspotInstance.Id}: {filename}";
                         }
                     }
                 }
                 break;
            case scnEffectInstanceId scnEffectInstance when GetRootModel().ResolvedData is scnSceneResource sceneForEffect:
                Value = $"{scnEffectInstance.Id}";
                IsValueExtrapolated = scnEffectInstance.Id != 0;
                
                var effectInstance = sceneForEffect.EffectInstances
                    .FirstOrDefault(e => e.EffectInstanceId.Id == scnEffectInstance.Id);
                if (effectInstance != null)
                {
                    var effectId = effectInstance.EffectInstanceId.EffectId.Id;
                    var effectDef = sceneForEffect.EffectDefinitions
                        .FirstOrDefault(e => e.Id.Id == effectId);
                    
                    if (effectDef != null)
                    {
                        var effectPath = effectDef.Effect.DepotPath.GetResolvedText();
                        if (!string.IsNullOrEmpty(effectPath))
                        {
                            var filename = System.IO.Path.GetFileNameWithoutExtension(effectPath);
                            Value = $"{scnEffectInstance.Id}: {filename}";
                        }
                    }
                }
                break;
            case scnPropId scnPropId when GetRootModel().ResolvedData is scnSceneResource sceneForProp:
                Value = $"{scnPropId.Id}";
                IsValueExtrapolated = scnPropId.Id != 0;
                
                // Add friendly prop name if available
                var propDefinition = sceneForProp.Props
                    .FirstOrDefault(p => p.PropId.Id == scnPropId.Id);
                if (propDefinition != null)
                {
                    var propName = propDefinition.PropName.ToString();
                    if (!string.IsNullOrEmpty(propName))
                    {
                        Value = $"{scnPropId.Id}: {propName}";
                    }
                }
                break;
            case scnPlayerActorDef playerActorDef:
                Value = $"NodeId: {playerActorDef.SpecCharacterRecordId.GetResolvedText()}";
                IsValueExtrapolated = true;
                break;
            case workWorkEntryId id:
                Value = $"{id.Id}";
                IsValueExtrapolated = true;
                break;
            case CArray<entSlot> entSlots:
                var entSlotDescriptors = entSlots
                    .Select(slotsOption => slotsOption.SlotName.GetResolvedText() ?? "")
                    .Where(e => !string.IsNullOrEmpty(e))
                    .ToList();
                Value = $"{string.Join(", ", entSlotDescriptors)}";
                IsValueExtrapolated = true;
                break;
            case CArray<gameAnimParamSlotsOption> slotsOptions:
                var childDescriptors = slotsOptions
                    .Select(slotsOption => slotsOption.SlotID.GetResolvedText() ?? "")
                    .Where(e => !string.IsNullOrEmpty(e))
                    .ToList();
                Value = $"{string.Join(", ", childDescriptors)}";
                IsValueExtrapolated = true;
                break;
            case questFactsDBCondition condition:
                switch (condition.Type?.GetValue())
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
            case Multilayer_Layer layer:
                Value = layer.ColorScale;
                if (layer.Microblend.DepotPath.GetResolvedText() is string microblend && !string.IsNullOrEmpty(microblend) &&
                    microblend != "base\\surfaces\\microblends\\default.xbm")
                {
                    Value = $"{Value}, {microblend.Split('\\').Last()}";
                }                
                IsValueExtrapolated = true;
                break;
            case scnVoicesetComponent voiceset:
                Value = voiceset.CombatVoSettingsName.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case CMaterialParameterTexture cTexPar:
                Value = cTexPar.Texture.DepotPath.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case CMaterialParameterScalar cNumPar:
                Value = $"{cNumPar.Min}..{cNumPar.Max}";
                IsValueExtrapolated = Value != "";
                break;
            case CMaterialParameterVector cVecPar:
                Value = StringHelper.Stringify(cVecPar.Vector);
                IsValueExtrapolated = Value != "";
                break;
            case CMaterialParameterColor cColorPar:
                Value = StringHelper.Stringify(cColorPar.Color);
                IsValueExtrapolated = Value != "";
                break;
            case CMaterialParameterInfo cInfoPar:
                Value = EnumHelper.RedIntToEnumString(typeof(IMaterialDataProviderDescEParameterType), cInfoPar.Type);
                IsValueExtrapolated = Value != "";
                break;
            case FeatureFlagsMask ffm:
                Value = EnumHelper.RedIntToBitfieldString(typeof(EFeatureFlagMask), ffm.Flags);
                IsValueExtrapolated = Value != "" && Value != "None";
                break;
            case entTemplateAppearance entAppearance:
                Value = StringHelper.Stringify(entAppearance.AppearanceResource.DepotPath);
                IsValueExtrapolated = Value != "";
                break;
            case entSoundListenerComponent listener when
                listener.ParentTransform?.GetValue() is entHardTransformBinding tBinding:
                Value = StringHelper.Stringify(tBinding);
                IsValueExtrapolated = Value != "";
                break;
            case entAnimationSetupExtensionComponent animSetupComp:
                Value = "";
                if (animSetupComp.Animations.Cinematics.Count > 0)
                {
                    Value = $"{Value}c:[{animSetupComp.Animations.Cinematics.Count}] ";
                }

                if (animSetupComp.Animations.Gameplay.Count > 0)
                {
                    Value = $"{Value}g:[{animSetupComp.Animations.Gameplay.Count}] ";
                }

                if (animSetupComp.ControlBinding.GetValue() is entAnimationControlBinding controlBinding &&
                    controlBinding.BindName.GetResolvedText() is string bindName && bindName != string.Empty)
                {
                    Value = $"binding: {Value}{bindName}";
                }
                
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
                List<string> values = [];
                if (animComp.FacialSetup.DepotPath != ResourcePath.Empty)
                {
                    values.Add(StringHelper.Stringify(animComp.FacialSetup.DepotPath, true));
                }

                if (animComp.Graph.DepotPath != ResourcePath.Empty)
                {
                    values.Add(StringHelper.Stringify(animComp.Graph.DepotPath, true));
                }

                if (animComp.Rig.DepotPath != ResourcePath.Empty)
                {
                    values.Add(StringHelper.Stringify(animComp.Rig.DepotPath, true));
                }

                Value = string.Join(", ", values);
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
            case CArray<CName> cNames:
                Value = StringHelper.Stringify(cNames);
                IsValueExtrapolated = cNames.Count != 0;
                break;
            case CEvaluatorFloatConst floatConst:
                Value = $"{floatConst.Value}";
                break;
            case QsTransform transform:
                Value = StringHelper.Stringify(transform);
                IsValueExtrapolated = Value != "";
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
            case scnCinematicAnimSetSRRefId cinematicAnimSetRefId when GetRootModel().ResolvedData is scnSceneResource sceneForAnimSetRef:
                var animSetId = cinematicAnimSetRefId.Id;
                Value = ((uint)animSetId).ToString();
                
                // Try to show the animation set file name if available
                var animSetIdValue = (uint)animSetId;
                if (sceneForAnimSetRef.ResouresReferences?.CinematicAnimSets != null && 
                    animSetIdValue < sceneForAnimSetRef.ResouresReferences.CinematicAnimSets.Count)
                {
                    var animSet = sceneForAnimSetRef.ResouresReferences.CinematicAnimSets[(int)animSetIdValue];
                    var animSetPath = animSet.AsyncAnimSet.DepotPath.GetResolvedText();
                    
                    if (!string.IsNullOrEmpty(animSetPath))
                    {
                        var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                        Value = $"{animSetIdValue}: {filename}.anims";
                        IsValueExtrapolated = true;
                    }
                }
                break;
            case scnCinematicAnimSetSRRefId cinematicAnimSetRefId:
                // Fallback case when not in a scene context
                Value = cinematicAnimSetRefId.Id.ToString();
                break;
            case scnLipsyncAnimSetSRRefId lipsyncAnimSetRefId when GetRootModel().ResolvedData is scnSceneResource sceneForLipsyncAnimSetRef:
                var lipsyncAnimSetId = lipsyncAnimSetRefId.Id;
                Value = ((uint)lipsyncAnimSetId).ToString();
                
                // Try to show the lipsync animation set file name if available
                var lipsyncAnimSetIdValue = (uint)lipsyncAnimSetId;
                if (sceneForLipsyncAnimSetRef.ResouresReferences?.LipsyncAnimSets != null && 
                    lipsyncAnimSetIdValue < sceneForLipsyncAnimSetRef.ResouresReferences.LipsyncAnimSets.Count)
                {
                    var animSet = sceneForLipsyncAnimSetRef.ResouresReferences.LipsyncAnimSets[(int)lipsyncAnimSetIdValue];
                    var animSetPath = animSet.AsyncRefLipsyncAnimSet.DepotPath.GetResolvedText();
                    
                    if (!string.IsNullOrEmpty(animSetPath))
                    {
                        var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                        Value = $"{lipsyncAnimSetIdValue}: {filename}.anims";
                        IsValueExtrapolated = true;
                    }
                }
                break;
            case scnLipsyncAnimSetSRRefId lipsyncAnimSetRefId:
                // Fallback case when not in a scene context
                Value = lipsyncAnimSetRefId.Id.ToString();
                break;

            case scnDynamicAnimSetSRRefId dynamicAnimSetRefId when GetRootModel().ResolvedData is scnSceneResource sceneForDynamicAnimSetRef:
                var dynamicAnimSetId = dynamicAnimSetRefId.Id;
                Value = ((uint)dynamicAnimSetId).ToString();
                
                // Try to show the dynamic animation set file name if available
                var dynamicAnimSetIdValue = (uint)dynamicAnimSetId;
                if (sceneForDynamicAnimSetRef.ResouresReferences?.DynamicAnimSets != null && 
                    dynamicAnimSetIdValue < sceneForDynamicAnimSetRef.ResouresReferences.DynamicAnimSets.Count)
                {
                    var animSet = sceneForDynamicAnimSetRef.ResouresReferences.DynamicAnimSets[(int)dynamicAnimSetIdValue];
                    var animSetPath = animSet.AsyncAnimSet.DepotPath.GetResolvedText();
                    
                    if (!string.IsNullOrEmpty(animSetPath))
                    {
                        var filename = System.IO.Path.GetFileNameWithoutExtension(animSetPath);
                        Value = $"{dynamicAnimSetIdValue}: {filename}.anims";
                        IsValueExtrapolated = true;
                    }
                }
                break;
            case scnDynamicAnimSetSRRefId dynamicAnimSetRefId:
                // Fallback case when not in a scene context
                Value = dynamicAnimSetRefId.Id.ToString();
                break;
            case scnlocSignature locSignature:
                Value = locSignature.Val.ToString();
                IsValueExtrapolated = locSignature.Val != 0;
                break;
            case gameEntityReference gameEntRef:
                Value = gameEntRef.Reference.GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case gameEntitySpawnerComponent when GetTvPropertyFromPath("slotDataArray") is ChunkViewModel sda:
                Value = sda.Descriptor;
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
            case IRedMeshComponent meshComponent:
            {
                Value = StringHelper.Stringify(meshComponent.Mesh.DepotPath, true);
                if (meshComponent.MeshAppearance.GetResolvedText() is string app and (not "default" or "") && Value != "")
                {
                    Value = $"{Value} ({app})";
                }
                IsValueExtrapolated = Value != "";
                break;
            }
            case entMorphTargetSkinnedMeshComponent morphtargetComponent:
            {
                Value = StringHelper.Stringify(morphtargetComponent.MorphResource.DepotPath, true);
                if (morphtargetComponent.MeshAppearance.GetResolvedText() is string app and (not "default" or "") && Value != "")
                {
                    Value = $"{Value} ({app})";
                }

                IsValueExtrapolated = Value != "";
                break;
            }
            case IRedArray<gameEntitySpawnerSlotData> slotDataAry:
                if (slotDataAry.Count() == 0)
                {
                    Value = "";
                }
                else
                {
                    Value = $"[{string.Join(", ", slotDataAry.Select(s => StringHelper.Stringify(s)))}]";
                }

                IsValueExtrapolated = Value != "";
                break;
            case gameEntitySpawnerSlotData slotData:
                Value = StringHelper.Stringify(slotData, true);
                IsValueExtrapolated = Value != "";
                break;
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
                NodeIdxInParent > -1 && GetRootModel().GetPropertyFromPath("ragdollNames")?.ResolvedData is
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

        if (!IsDefault && string.IsNullOrEmpty(Value) && TVProperties is [ChunkViewModel child])
        {
            Value = child.Descriptor ?? child.Value;
            IsValueExtrapolated = !string.IsNullOrEmpty(Value);
        }

        if (Parent is not null && Parent.IsValueExtrapolated)
        {
            Parent.CalculateValue();
        }
            

        // Make sure it's never null
        Value ??= "null";
    }

}