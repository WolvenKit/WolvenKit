#nullable enable
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Splat;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converts RedBaseClass instances to a collection containing a single ChunkViewModel for RedTreeView
    /// </summary>
    public class RedTypeToChunkViewModelCollectionConverter : IValueConverter
    {
        private readonly ConditionalWeakTable<RedBaseClass, List<ChunkViewModel>> _cache = new();
        
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not RedBaseClass redData)
                return null;

            // Use cache to avoid creating new ChunkViewModel on every selection change
            return _cache.GetValue(redData, CreateChunkViewModelCollection);
        }

        private List<ChunkViewModel> CreateChunkViewModelCollection(RedBaseClass redData)
        {
            var factory = Locator.Current.GetService<IChunkViewmodelFactory>();
            var appViewModel = Locator.Current.GetService<AppViewModel>();
            
            if (factory == null || appViewModel == null)
                throw new InvalidOperationException("Required services not available");

            // Try to get the current document's RDTDataViewModel to use as Tab reference
            // This ensures property edits can mark the document as dirty and save properly
            var currentDocument = appViewModel.ActiveDocument as RedDocumentViewModel;
            var currentTab = currentDocument?.SelectedTabItemViewModel;
            
            ChunkViewModel chunkViewModel;
            
            // If we have a CombinedSceneViewModel, use its RDTViewModel as the tab reference
            if (currentTab is CombinedSceneViewModel combinedScene)
            {
                chunkViewModel = factory.ChunkViewModel(redData, combinedScene.RDTViewModel, appViewModel);
            }
            // If we have an RDTDataViewModel directly, use it
            else if (currentTab is RDTDataViewModel rdtTab)
            {
                chunkViewModel = factory.ChunkViewModel(redData, rdtTab, appViewModel);
            }
            // Fallback to no tab reference (old behavior)
            else
            {
                var typeName = redData.GetType().Name;
                chunkViewModel = factory.ChunkViewModel(redData, typeName, appViewModel, null);
            }
            
            // Force calculation of properties so they show up in the property editor
            chunkViewModel.CalculateProperties();
            
            // Auto-expand based on node type
            AutoExpandProperties(chunkViewModel, redData);
            
            // Return as a single-item collection for RedTreeView
            return new List<ChunkViewModel> { chunkViewModel };
        }
        
        private void AutoExpandProperties(ChunkViewModel rootChunk, RedBaseClass redData)
        {
            // Always expand the first level to show immediate properties
            rootChunk.IsExpanded = true;
            
            var typeName = redData.GetType().Name;
            
            // For quest nodes, we need deeper expansion
            if (typeName == "scnQuestNode")
            {
                // Find the questNode property and expand it too
                var questNodeProperty = rootChunk.TVProperties
                    .FirstOrDefault(p => p.Name.Equals("questNode", StringComparison.OrdinalIgnoreCase));
                
                if (questNodeProperty != null)
                {
                    // Force calculation of the questNode's properties
                    questNodeProperty.CalculateProperties();
                    questNodeProperty.IsExpanded = true;
                }
            }
            // For section nodes, expand to the events field
            else if (typeName == "scnSectionNode" || typeName == "scnRewindableSectionNode")
            {
                // Find the events property and expand it
                var eventsProperty = rootChunk.TVProperties
                    .FirstOrDefault(p => p.Name.Equals("events", StringComparison.OrdinalIgnoreCase));
                
                if (eventsProperty != null)
                {
                    eventsProperty.CalculateProperties();
                    eventsProperty.IsExpanded = true;
                }
            }
            // For FactsDB manager nodes, expand all the way to the actual type
            else if (typeName == "questFactsDBManagerNodeDefinition")
            {
                // Find the Type property and expand it
                var typeProperty = rootChunk.TVProperties
                    .FirstOrDefault(p => p.Name.Equals("type", StringComparison.OrdinalIgnoreCase));
                
                if (typeProperty != null)
                {
                    typeProperty.CalculateProperties();
                    typeProperty.IsExpanded = true;
                    
                    // Look for the nested Chunk property (the actual facts DB type)
                    var chunkProperty = typeProperty.TVProperties
                        .FirstOrDefault(p => p.Name.Equals("chunk", StringComparison.OrdinalIgnoreCase));
                    
                    if (chunkProperty != null)
                    {
                        chunkProperty.CalculateProperties();
                        chunkProperty.IsExpanded = true;
                    }
                }
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException("RedTypeToChunkViewModelCollectionConverter is one-way only");
        }
    }
} 