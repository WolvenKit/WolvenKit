using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.RedReflection;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    public void CalculateDescriptor()
    {
        Descriptor = "";

        if (Data is worldNodeData sst && Tab is RDTDataViewModel dvm &&
            dvm.Chunks[0].Data is worldStreamingSector wss && sst.NodeIndex < wss.Nodes.Count)
        {
            Descriptor = $"[{sst.NodeIndex}] {GetNameFrom(wss.Nodes[sst.NodeIndex].NotNull().Chunk)}";
            return;
        }

        if (Data is worldStreamingSectorDescriptor wssd)
        {
            Descriptor = (wssd.Data.DepotPath.GetResolvedText() ?? "")
                .Replace("base\\worlds\\03_night_city\\_compiled\\default\\", "").Replace(".streamingsector", "");
            return;
        }

        if (ResolvedData is IRedArray ary && ary.Count > 0)
        {
            // csv files and the like 
            if (Parent is { Name: "compiledData" } && GetRootModel().Data is C2dArray csv)
            {
                var index = 0;
                for (var i = 0; i < csv.CompiledHeaders.Count; i++)
                {
                    if (((string)csv.CompiledHeaders[i]).Contains("name", StringComparison.InvariantCultureIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }

                Descriptor = $"{ary[index]}";
                if (Descriptor != "")
                {
                    return;
                }
            }

            Descriptor = $"[{ary.Count}]";
        }
        else if (ResolvedData is appearanceAppearancePart)
        {
            Descriptor = ((appearanceAppearancePart)ResolvedData).Resource.DepotPath.GetResolvedText() ?? "";
            if (Descriptor != "")
            {
                return;
            }
        }
        else if (ResolvedData is animAnimSetEntry)
        {
            var animation = ((animAnimSetEntry)ResolvedData).Animation?.GetValue();
            Descriptor = animation?.GetProperty("Name")?.ToString() ?? "";
            if (Descriptor != "")
            {
                return;
            }
        }
        // animgraph - something is broken here. Why does the orange text go away? Why do I need the try/catch
        // around the GetNodename?
        else if (Data is CHandle<animAnimNode_Base> handle)
        {
            if (handle.Chunk is animAnimNode_Switch)
            {
                var inputNodes = handle.Chunk.GetProperty("InputNodes");
                if (inputNodes is CArray<animPoseLink> animAry)
                {
                    var names = animAry
                        .Select((animPoseLink) => GetNodeName(animPoseLink.Node) ?? "")
                        .Where((name) => name != "")
                        .ToArray();
                    Descriptor = string.Join(", ", names);
                    // Value = string.Join(", ", names);
                    // IsValueExtrapolated = true;
                    return;
                }
            }
        }
        else if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is RedPackage pkg)
        {
            Descriptor = $"[{pkg.Chunks.Count}]";
        }
        else if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
        {
            Descriptor = $"[{cl.Files.Count}]";
        }
        else if (ResolvedData is CKeyValuePair kvp)
        {
            Descriptor = kvp.Key;
        }
        else if (ResolvedData is questNodeDefinition qnd)
        {
            Descriptor = qnd.Id.ToString();
            return;
        }
        else if (ResolvedData is scnSceneGraphNode sgn)
        {
            Descriptor = sgn.NodeId.Id.ToString();
            return;
        }
        else if (ResolvedData is worldCompiledEffectInfo info)
        {
            Descriptor = string.Join(", ", info.PlacementInfos);
            return;
        }
        else if (Data is TweakDBID tdb)
        {
            //Descriptor = Locator.Current.GetService<TweakDBService>().GetString(tdb);
            Descriptor = tdb.GetResolvedText();
            return;
        }
        else if (Data is gamedataLocKeyWrapper locKey)
        {
            Descriptor = ((ulong)locKey).ToString();
            //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
        }
        else if (Data is IRedString str)
        {
            var s = str.GetString();
            if (s is not null && s.StartsWith("LocKey#") && ulong.TryParse(s[7..], out var locKey2))
            {
                Descriptor = locKey2.ToString();
            }
        }
        //if (ResolvedData is CMaterialInstance && Parent is not null)
        //{
        //    if (Parent.Parent is not null && Parent.Parent.Parent is not null && Parent.Parent.Data is CMesh mesh)
        //    {
        //        Descriptor = mesh.MaterialEntries[int.Parse(Name)].Name;
        //    }
        //}
        else if (Data is Vector3 v3)
        {
            Descriptor = $"{v3.X}, {v3.Y}, {v3.Z}";
        }
        else if (Data is Vector4 v4)
        {
            Descriptor = $"{v4.X}, {v4.Y}, {v4.Z}, {v4.W}";
        }
        else if (Data is Quaternion q)
        {
            Descriptor = $"{q.I}, {q.J}, {q.K}, {q.R}";
        }

        // For local and external materials
        if (ResolvedData is CMaterialInstance or CResourceAsyncReference<IMaterial> && NodeIdxInParent > -1
            && GetRootModel().GetModelFromPath("materialEntries")?.ResolvedData is CArray<CMeshMaterialEntry>
                materialEntries && materialEntries.Count > NodeIdxInParent)
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
                .Where((e, idx) => e.Index == NodeIdxInParent && e.IsLocalInstance == isLocalMaterial)
                .FirstOrDefault();

            // Will return null if no entry is found
            Descriptor = entry?.Name.GetResolvedText();

            if (Descriptor != null)
            {
                return;
            }
        }
        else if (ResolvedData is localizationPersistenceOnScreenEntry localizationPersistenceOnScreenEntry)
        {
            var desc = $"[{localizationPersistenceOnScreenEntry.PrimaryKey}]";
            if (!string.IsNullOrEmpty(localizationPersistenceOnScreenEntry.SecondaryKey))
            {
                desc += $" {localizationPersistenceOnScreenEntry.SecondaryKey}";
            }

            Descriptor = desc;
        }
        else if (ResolvedData is entHardTransformBinding tBinding)
        {
            Descriptor = tBinding.BindName;
        }
        else if (ResolvedData is WorldTransform bind)
        {
            Descriptor =
                $"Pos: (X: {(float)bind.Position.X:G9}, Y: {(float)bind.Position.Y:G9}, Z: {(float)bind.Position.Z:G9})";
            Descriptor =
                $"{Descriptor}, Orientation: ({bind.Orientation})";
            return;
        }
        else if (ResolvedData is WorldPosition position)
        {
            Descriptor = $"{(float)position.X:G9}, {(float)position.Y:G9}, {(float)position.Z:G9}";
            return;
        }
        else if (ResolvedData is inkTextureSlot texturesSlot)
        {
            var desc = texturesSlot.Texture.DepotPath.GetResolvedText();
            if (!string.IsNullOrEmpty(desc))
            {
                Descriptor = desc;
            }
        }
        else if (ResolvedData is worldInstancedMeshNode instancedMeshNode)
        {
            // If this isn't overwritten by debugName, put the mesh name instead
            var desc = GetNameFrom(instancedMeshNode);
            if (!string.IsNullOrEmpty(desc))
            {
                Descriptor = desc;
            }
        }
        else if (ResolvedData is entEffectDesc { EffectName: var name })
        {
            Descriptor = name;
            if (Descriptor is not null and not "")
            {
                return;
            }
        }
        else if (ResolvedData is senseVisibleObject senseVisibleObject)
        {
            Descriptor = senseVisibleObject.Description;

            if (Descriptor is not null and not "")
            {
                return;
            }
        }
        else if (ResolvedData is FxResourceMapData mapData)
        {
            Descriptor = mapData.Key;
            if (Descriptor is not null and not "")
            {
                return;
            }
        }
        else if (ResolvedData is localizationPersistenceOnScreenEntries jsonRoot)
        {
            Descriptor = $"[{jsonRoot.Entries.Count}]";
            if (Descriptor is not null and not "")
            {
                return;
            }
        }
        else if (ResolvedData is gameFxResource fxResource)
        {
            Descriptor = fxResource.Effect.DepotPath.GetResolvedText();
            if (Descriptor is not null and not "")
            {
                return;
            }
        }
        // mesh: boneTransforms (in different coordinate spaces)
        else if (NodeIdxInParent > -1 &&
                 (Parent?.Name == "boneTransforms" || Parent?.Name == "aPoseLS" || Parent?.Name == "aPoseMS") &&
                 GetRootModel().GetModelFromPath("boneNames")?.ResolvedData is CArray<CName> boneNames &&
                 boneNames.Count > NodeIdxInParent)
        {
            Descriptor = boneNames[NodeIdxInParent];
        }
        else if (ResolvedData is not null)
        {
            if (Data is IBrowsableDictionary ibd)
            {
                var pns = ibd.GetPropertyNames();
                Descriptor = $"[{pns.Count()}]";
            }
            else if (Data is IList list)
            {
                Descriptor = $"[{list.Count}]";
            }
            else if (Data is Dictionary<string, object> dict)
            {
                Descriptor = $"[{dict.Count}]";
            }
        }
        
        
        if (ResolvedData is RedBaseClass irc)
        {
            foreach (var propName in s_DescriptorPropNames)
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
            foreach (var propName in s_DescriptorPropNames)
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

    private static string GetNameFrom(worldNode? linkNode)
    {
        if (linkNode is null)
        {
            return "None";
        }

        if (linkNode.DebugName.GetResolvedText() is string s && s != "" && s != "None")
        {
            return s;
        }

        if (linkNode is worldInstancedMeshNode inst)
        {
            return inst.Mesh.DepotPath.GetResolvedText()?.Split("/").LastOrDefault() ?? "None";
        }

        return "None";
    }

    /// <summary>
    /// Property names for descriptor field
    /// </summary>
    private static readonly string[] s_DescriptorPropNames =
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
        "propertyPath" // ?
    ];
}