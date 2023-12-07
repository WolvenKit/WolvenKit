using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    // Keep track of expansion state changes triggered by parent nodes. In that case, we want to swallow our own
    // ExpansionStateChanged event and not interact with our child nodes again.

    public bool ExpansionStateChangedFromParent { get; set; } = false;

    /// <summary>
    /// Can recursively set expansion states of child nodes.
    /// </summary>
    /// <param name="isExpanded">Expansion state (open/closed)</param>
    public void SetChildExpansionStates(bool isExpanded)
    {
        // If we've been triggered from the change event and our state has been set internally, swallow the event
        if (ExpansionStateChangedFromParent)
        {
            ExpansionStateChangedFromParent = false;
            return;
        }

        SetChildExpansionStatesInternal(isExpanded, -1);
    }

    /// <summary>
    /// Can recursively set expansion states of child thiss. Pass "false" as last parameter from initial call.
    /// </summary>
    /// <param name="this">The this to call on</param>
    /// <param name="isExpanded">Expansion state (open/closed)</param>
    /// <param name="recursionLevel">How deep into the rabbit hole are we? (Logic-based switching of child states)</param>
    private void SetChildExpansionStatesInternal(bool isExpanded, int recursionLevel)
    {
        var _recursionLevel = recursionLevel + 1;

        // Remember if this was expanded recursively so that it can swallow its next event and not re-expand its children  
        this.ExpansionStateChangedFromParent = _recursionLevel > 0;

        // Possible that we're calling this recursively
        this.IsExpanded = isExpanded;

        ObservableCollectionExtended<ChunkViewModel> properties = this.Properties;
        if (properties.Count == 0 && this.TVProperties.Count > 0)
        {
            properties = this.TVProperties;
        }

        if (properties.Count == 0)
        {
            return;
        }

        switch (this.Data)
        {
            // .app: appearance definition (expand components, partsValues, partsOverrides)
            case CHandle<appearanceAppearanceDefinition> or appearanceAppearanceDefinition:
            {
                foreach (var chunkViewModel in properties.Where((prop) =>
                             prop.Name is "components" or "partsOverrides" or "partsValues"))
                {
                    if (chunkViewModel.Name == "components")
                    {
                        chunkViewModel.IsExpanded = isExpanded;
                    }

                    chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                }

                break;
            }
            // mesh: material, expand values array (but not recursively)
            case CMaterialInstance or CHandle<IMaterial>:
                properties.Last().SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                break;
            // mesh: appearances
            case CHandle<meshMeshAppearance> when properties.First() is { } chunkNames:
                chunkNames.IsExpanded = this.IsExpanded;
                chunkNames.ExpansionStateChangedFromParent = IsExpanded;
                break;

            // Generic Array
            case CArray<IRedType> or CArray<appearanceAppearancePart> or CArray<RedBaseClass>:
            {
                foreach (var chunkViewModel in properties)
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
                foreach (var chunkViewModel in properties)
                {
                    chunkViewModel.ExpansionStateChangedFromParent = true;
                    chunkViewModel.SetChildExpansionStatesInternal(isExpanded, _recursionLevel);
                }

                break;
            }
            default:
                break;
        }


        if (isExpanded)
        {
            return;
        }

        foreach (var chunkViewModel in this.Properties)
        {
            chunkViewModel.IsExpanded = false;
        }
    }
}