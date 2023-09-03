using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DynamicData.Binding;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools;

public class ChunkViewModelTools
{
    public void SetChildExpansionStates(ChunkViewModel? node, bool isExpanded)
    {
        if (node is null)
        {
            return;
        }

        var properties = node.Properties;
        if (properties.Count == 0 && node.TVProperties.Count > 0)
        {
            properties = node.TVProperties;
        }

        // Possible that we're calling this recursively
        node.IsExpanded = isExpanded;

        if (properties.Count == 0)
        {
            return;
        }

        // .app: appearance definition (expand components, partsValues, partsOverrides)
        if (node.Data is CHandle<appearanceAppearanceDefinition> or appearanceAppearanceDefinition)
        {
            foreach (var chunkViewModel in properties.Where((prop) =>
                         prop.Name is "components" or "partsOverrides" or "partsValues"))
            {
                if (chunkViewModel.Name == "components")
                {
                    chunkViewModel.IsExpanded = isExpanded;
                }

                SetChildExpansionStates(chunkViewModel, isExpanded);
            }

            return;
        }

        // mesh: material, expand values array (recursively)
        if (node.Data is CMaterialInstance)
        {
            SetChildExpansionStates(properties.Last(), isExpanded);
            return;
        }

        // mesh: appearances
        if (node.Data is CHandle<meshMeshAppearance> &&
            properties.First() is ChunkViewModel chunkNames)
        {
            chunkNames.IsExpanded = node.IsExpanded;
            return;
        }

        if (node.Data is CArray<IRedType> or CArray<appearanceAppearancePart> or CArray<RedBaseClass>)
        {
            foreach (var chunkViewModel in properties)
            {
                SetChildExpansionStates(chunkViewModel, isExpanded);
            }
            return;
        }

        if (node.Data is CArray<CKeyValuePair>)
        {
                foreach (var chunkViewModel in properties)
                {
                    chunkViewModel.IsExpanded = isExpanded;
                }

                return;
        }

        if (isExpanded)
        {
            return;
        }

        foreach (var chunkViewModel in node.Properties)
        {
            chunkViewModel.IsExpanded = false;
        }
    }
}