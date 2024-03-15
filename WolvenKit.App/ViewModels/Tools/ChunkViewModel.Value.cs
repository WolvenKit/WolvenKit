using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using WolvenKit.App.Models;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    [MemberNotNull(nameof(Value))]
    protected void CalculateValue()
    {
        Value = Data is null ? "null" : "";

        // nothing to calculate
        if (ResolvedData is RedDummy)
        {
            return;
        }

        if (PropertyType.IsAssignableTo(typeof(IRedString)) && Data is IRedString s)
        {
            var value = s.GetString();
            if (!string.IsNullOrEmpty(value))
            {
                Value = value;
                if (Value.StartsWith("LocKey#") && ulong.TryParse(Value[7..], out var key))
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
            var value = l;
            Value = value.Value is "" or null ? "null" : value.Value;
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedEnum)) && Data is IRedEnum e)
        {
            var value = e;
            Value = value.ToEnumString();
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedBitField)) && Data is IRedBitField f)
        {
            var value = f;
            Value = value.ToBitFieldString();
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
            var value = cb;
            Value = value ? "True" : "False";
        }
        else if (PropertyType.IsAssignableTo(typeof(CRUID)) && Data is CRUID cr)
        {
            var value = cr;
            Value = ((ulong)value).ToString();
        }
        else if (PropertyType.IsAssignableTo(typeof(CUInt64)) && Data is CUInt64 uInt64)
        {
            var value = uInt64;
            Value = value != 0 ? ((NodeRef)(ulong)value).ToString() : ((ulong)value).ToString();
        }
        else if (PropertyType.IsAssignableTo(typeof(gamedataLocKeyWrapper)))
        {
            //var value = (gamedataLocKeyWrapper)Data;
            //Value = ((ulong)value).ToString();
            //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
        }
        else if (PropertyType.IsAssignableTo(typeof(IRedInteger)) && Data is IRedInteger i)
        {
            var value = i;

            Value = value.ToString(CultureInfo.CurrentCulture);
        }
        else if (PropertyType.IsAssignableTo(typeof(FixedPoint)) && Data is FixedPoint fp)
        {
            var value = fp;
            Value = ((float)value).ToString("G9");
        }
        else if (PropertyType.IsAssignableTo(typeof(NodeRef)) && Data is NodeRef nr)
        {
            var value = nr;
            Value = value;
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
        else if (ResolvedData is animPoseLink link)
        {
            if (link.Node is not null)
            {
                var desc = GetNodeName(link.Node);

                if (!string.IsNullOrEmpty(desc))
                {
                    Value = desc;
                    IsValueExtrapolated = true;
                    return;
                }
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
        else if (Data is localizationPersistenceOnScreenEntry i18n)
        {
            IsValueExtrapolated = true;
            // fall back to male variant only if female variant is
            Value = i18n.FemaleVariant;
            if (Value == "" && i18n.MaleVariant != "")
            {
                Value = i18n.MaleVariant;
            }
        }


        switch (ResolvedData)
        {
            case CKeyValuePair kvp:
                // If the CValuePair has a value, we'll try to resolve it
                Value = kvp.Value switch
                {
                    CName cname => cname.GetResolvedText() ?? "",
                    CResourceReference<ITexture> reference => reference.DepotPath.GetResolvedText() ?? "",
                    _ => kvp.Value.ToString()
                };
                IsValueExtrapolated = true;
                break;
            case meshMeshAppearance { ChunkMaterials: not null } appearance:
                Value = string.Join(", ", appearance.ChunkMaterials);
                Value = $"[{appearance.ChunkMaterials.Count}] {Value}";
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
            case workWorkEntryId id:
                Value = $"{id.Id}";
                IsValueExtrapolated = true;
                break;
            case scnVoicesetComponent voiceset:
                Value = voiceset.CombatVoSettingsName.GetResolvedText() ?? "";
                IsValueExtrapolated = Value != "";
                break;
            case entSoundListenerComponent listener when
                listener.ParentTransform?.GetValue() is entHardTransformBinding tBinding:
                Value = Stringify(tBinding);
                IsValueExtrapolated = Value != "";
                break;
            case entSlotComponent slotComponent when
                slotComponent.ParentTransform?.GetValue() is entHardTransformBinding tBinding4:
                Value = Stringify(tBinding4);
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
                Value = Stringify(tBinding2);
                IsValueExtrapolated = Value != "";
                break;
            case entTriggerActivatorComponent tActivatorComponent:
            {
                if (tActivatorComponent.ParentTransform?.GetValue() is entHardTransformBinding tBinding3)
                {
                    Value = Stringify(tBinding3);
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
            case FxResourceMapData mapData when mapData.Resource is gameFxResource fxResourceValue:
                Value = fxResourceValue.Effect.DepotPath.GetResolvedText();
                IsValueExtrapolated = Value != "";
                break;
            case entMeshComponent meshComponent:
            {
                Value = "";
                if (meshComponent.ParentTransform?.GetValue() is entHardTransformBinding parentTransformValue)
                {
                    Value = Stringify(parentTransformValue);
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
                    Value = Stringify(parentTransformValue);
                }

                if (skinnedMeshComponent.Mesh.DepotPath.GetResolvedText() is string dePathText)
                {
                    Value = Value.Length == 0 ? $"{dePathText}" : $" ({dePathText})";
                }

                IsValueExtrapolated = Value != "";
                break;
            }
            case entDynamicActorRepellingComponent repComponent when
                repComponent.ParentTransform?.GetValue() is entHardTransformBinding parentTransformValue:
                Value = Stringify(parentTransformValue);
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
            default:
                break;
        }

        // Make sure it's never null
        Value ??= "null";
    }

    private static string Stringify(entHardTransformBinding hardTransformBinding)
    {
        var ret = $"{hardTransformBinding.SlotName}".Replace("None", "");
        if (ret == "")
        {
            ret = $"{hardTransformBinding.BindName}".Replace("None", "");
        }

        return ret;
    }
}