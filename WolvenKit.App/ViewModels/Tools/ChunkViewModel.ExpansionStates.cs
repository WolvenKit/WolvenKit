using System;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public class CustomLoopException : Exception
{
    public CustomLoopException()
    {
    }

    public CustomLoopException(string message)
        : base(message)
    {
    }

    public CustomLoopException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

public partial class ChunkViewModel : ObservableObject
{
    // Keep track of expansion state changes triggered by parent nodes. In that case, we want to swallow our own
    // ExpansionStateChanged event and not interact with our child nodes again.

    public bool ExpansionStateChangedFromParent { get; set; } = false;

    /// <summary>
    /// Can recursively set expansion states of child nodes.
    /// </summary>
    /// <param name="isExpanded">Expansion state (open/closed)</param>
    /// <param name="skipRecursion">Do not recurse into child nodes</param>
    public void SetChildExpansionStates(bool isExpanded, bool skipRecursion = false)
    {
        // If we've been triggered from the change event and our state has been set internally, swallow the event
        if (ExpansionStateChangedFromParent)
        {
            ExpansionStateChangedFromParent = false;
            return;
        }

        SetChildExpansionStatesInternal(isExpanded, skipRecursion ? 99 : -1);
    }

    /// <summary>
    /// Can recursively set expansion states of child thiss. Pass "false" as last parameter from initial call.
    /// </summary>
    /// <param name="this">The this to call on</param>
    /// <param name="isExpanded">Expansion state (open/closed)</param>
    /// <param name="collapseOnException">Collapse this node if the child nodes throw an exception?</param>
    /// <param name="recursionLevel">How deep into the rabbit hole are we? (Logic-based switching of child states)</param>
    private void SetChildExpansionStatesInternal(bool isExpanded, int recursionLevel, bool collapseOnException = false)
    {
        var _recursionLevel = recursionLevel + 1;

        // Remember if this was expanded recursively so that it can swallow its next event and not re-expand its children  
        ExpansionStateChangedFromParent = _recursionLevel > 0;

        // Possible that we're calling this recursively
        IsExpanded = isExpanded;

        ObservableCollectionExtended<ChunkViewModel> treeViewProperties = Properties;
        if (treeViewProperties.Count == 0 && TVProperties.Count > 0)
        {
            treeViewProperties = TVProperties;
        }

        if (treeViewProperties.Count == 0)
        {
            return;
        }

        try
        {
            switch (ResolvedData)
            {
                // .app: appearance definition (expand components, partsValues, partsOverrides)
                case CHandle<appearanceAppearanceDefinition> or appearanceAppearanceDefinition when _recursionLevel < 2:
                {
                    foreach (var chunkViewModel in treeViewProperties.Where((prop) =>
                                 prop.Name is "components" or "partsOverrides" or "partsValues" or "visualTags"))
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = chunkViewModel.Name != "partsOverrides";
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                // .visualTags (.app file and nested under .ent.visualTagSchema)
                case redTagList when treeViewProperties.Count == 1:
                    treeViewProperties[0].IsExpanded = isExpanded;
                    break;
                // visualTagSchema (.ent file)
                //      - schema 
                //      - redTagList visualTags
                case entVisualTagsSchema when treeViewProperties.Count == 2:
                    treeViewProperties[1].SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    break;
                // mesh: material, expand values array (but not recursively)
                case CMaterialInstance or CHandle<IMaterial>:
                    treeViewProperties.Last().SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    break;
                // mesh: appearances
                case CHandle<meshMeshAppearance> or meshMeshAppearance when treeViewProperties.First() is { } chunkNames:
                    chunkNames.IsExpanded = this.IsExpanded;
                    chunkNames.ExpansionStateChangedFromParent = IsExpanded;
                    break;

                /*
                 * effect info
                 *     - placementInfos
                 */
                case worldCompiledEffectInfo when _recursionLevel < 2 || !isExpanded:
                    treeViewProperties.FirstOrDefault(prop => prop.Name == "placementInfos")
                        ?.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    break;
                /*
                 * entEffectSpawnerComponent:
                 *    - effectDescs
                 */
                case entEffectSpawnerComponent when treeViewProperties.FirstOrDefault(prop => prop.Name == "effectDescs") is
                    { } effectsArray:
                    effectsArray.IsExpanded = isExpanded;
                    if (_recursionLevel == 0 || !isExpanded)
                    {
                        effectsArray.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                /*
                 * effect slots
                 *     - slots
                 */
                case entSlotComponent when _recursionLevel == 0 || !isExpanded:
                    treeViewProperties.FirstOrDefault(prop => prop.Name == "slots")
                        ?.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    break;
                /*
                 * effect slots
                 *     - slots
                 */
                case CHandle<entEffectDesc> when _recursionLevel == 0 || !isExpanded:
                    treeViewProperties.FirstOrDefault(prop => prop.Name == "compiledEffectInfo")
                        ?.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    break;

                // Components array, or array of effect descriptors
                case CArray<entIComponent> when _recursionLevel == 0 || !isExpanded:
                case CArray<CHandle<entEffectDesc>> when _recursionLevel == 0 || !isExpanded:
                {
                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                /*
                 * Since we have value preview now, there's no need to open up KeyValue pairs when opening the material.
                 */
                case CArray<CKeyValuePair> when _recursionLevel == 0 || !isExpanded:
                {
                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = true;
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                /*
                 * PartsOverrides
                 */
                case CArray<appearanceAppearancePartOverrides> array:
                {
                    // abort expanding, also collapse parent node
                    if (array.Count == 0)
                    {
                        throw new CustomLoopException();
                    }

                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = true;
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel, true);
                    }

                    break;
                }
                /*
                 * PartsOverrides: nested child array
                 */
                case CArray<appearanceAppearanceDefinition> array:
                {
                    // abort expanding, also collapse parent node
                    if (array.Count == 0)
                    {
                        throw new CustomLoopException();
                    }

                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = true;
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel, true);
                    }

                    break;
                }
                /*
                 * PartsOverrides
                 */
                case appearanceAppearancePartOverrides ovr:
                {
                    if (ovr.ComponentsOverrides.Count == 0)
                    {
                        throw new CustomLoopException();
                    }

                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = true;
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                /*
                 * PartsOverrides
                 */
                case appearancePartComponentOverrides:
                {
                    if (treeViewProperties.Count == 0)
                    {
                        throw new CustomLoopException();
                    }

                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.ExpansionStateChangedFromParent = true;
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                /*
                 * meshMeshMaterialBuffer: For top level, expand everything
                 */
                case meshMeshMaterialBuffer:
                {
                    var child = treeViewProperties[0];
                    child.IsExpanded = true;
                    foreach (var chunkViewModel in child.Properties)
                    {
                        chunkViewModel.SetChildExpansionStates(isExpanded);
                    }

                    break;
                }
                /*
                 * Generic array, or stuff with just one property
                 */
                case CArray<IRedType>
                    or CArray<RedBaseClass>
                    or CArray<CHandle<meshMeshAppearance>>
                    or CArray<IMaterial>
                    or CArray<CHandle<appearanceAppearanceDefinition>>
                    or CArray<CHandle<entEffectDesc>>:
                {
                    if (recursionLevel == 99)
                    {
                        break;
                    }


                    foreach (var chunkViewModel in treeViewProperties)
                    {
                        chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                    }

                    break;
                }
                default:
                    break;
            }
        }
        catch (CustomLoopException)
        {
            if (collapseOnException)
            {
                IsExpanded = false;
                isExpanded = false;
            }
        }

        if (isExpanded)
        {
            return;
        }

        foreach (var chunkViewModel in Properties)
        {
            chunkViewModel.IsExpanded = false;
        }
    }
}