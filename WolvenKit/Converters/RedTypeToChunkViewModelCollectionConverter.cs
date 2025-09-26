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
using WolvenKit.Core.Interfaces;
using WolvenKit.App.Services;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converts RedBaseClass instances to a collection containing a single ChunkViewModel for RedTreeView
    /// </summary>
    public class RedTypeToChunkViewModelCollectionConverter : IValueConverter
    {
        private static ILoggerService? s_loggerService;
        private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

        /// <summary>
        /// Global cache shared across all converter instances
        /// </summary>
        private static readonly ConditionalWeakTable<RedBaseClass, List<ChunkViewModel>> s_globalCache = new();

        /// <summary>
        /// Invalidates the cache for a specific data object, forcing fresh conversion
        /// </summary>
        public static void InvalidateCache(RedBaseClass redData)
        {
            s_globalCache.Remove(redData);
        }

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not RedBaseClass redData)
            {
                return null;
            }

            try
            {
                // Always create fresh ChunkViewModel to ensure correct document context
                var result = CreateChunkViewModelCollection(redData);
                return result;
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Failed to create ChunkViewModel for {redData.GetType().Name}: {ex.Message}");

                // Return empty collection to prevent UI crashes
                return new List<ChunkViewModel>();
            }
        }

        private List<ChunkViewModel> CreateChunkViewModelCollection(RedBaseClass redData)
        {
            try
            {
                var factory = Locator.Current.GetService<IChunkViewmodelFactory>();
                var appViewModel = Locator.Current.GetService<AppViewModel>();

                if (factory == null)
                {
                    LoggerService?.Error("IChunkViewmodelFactory service not available");
                    return new List<ChunkViewModel>();
                }

                if (appViewModel == null)
                {
                    LoggerService?.Error("AppViewModel service not available");
                    return new List<ChunkViewModel>();
                }

                // Try to get the current document's RDTDataViewModel to use as Tab reference
                // This ensures property edits can mark the document as dirty and save properly
                var currentDocument = appViewModel.ActiveDocument as RedDocumentViewModel;
                var currentTab = currentDocument?.SelectedTabItemViewModel;

                ChunkViewModel chunkViewModel;

                // If we have a SceneGraphViewModel, use its RDTViewModel as the tab reference
                if (currentTab is SceneGraphViewModel combinedScene && combinedScene.RDTViewModel != null)
                {
                    chunkViewModel = factory.ChunkViewModel(redData, combinedScene.RDTViewModel, appViewModel);
                }
                // If we have a QuestPhaseGraphViewModel, use its RDTViewModel as the tab reference
                else if (currentTab is QuestPhaseGraphViewModel combinedQuestPhase && combinedQuestPhase.RDTViewModel != null)
                {
                    chunkViewModel = factory.ChunkViewModel(redData, combinedQuestPhase.RDTViewModel, appViewModel);
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

                if (chunkViewModel == null)
                {
                    LoggerService?.Error($"Failed to create ChunkViewModel for {redData.GetType().Name}");
                    return new List<ChunkViewModel>();
                }

                // Force calculation of properties so they show up in the property editor
                try
                {
                    chunkViewModel.CalculateProperties();
                }
                catch (Exception ex)
                {
                    LoggerService?.Error($"Failed to calculate properties for {redData.GetType().Name}: {ex.Message}");
                    // Continue anyway, as some properties might still be viewable
                }

                // Auto-expand based on node type
                try
                {
                    AutoExpandProperties(chunkViewModel, redData);

                    // Auto-select important properties for specific node types
                    NodePropertiesSelectionService.Instance.AutoSelectImportantProperty(chunkViewModel);
                }
                catch (Exception ex)
                {
                    LoggerService?.Error($"Failed to auto-expand properties for {redData.GetType().Name}: {ex.Message}");
                    // Continue anyway, user can manually expand
                }

                // Return as a single-item collection for RedTreeView
                return new List<ChunkViewModel> { chunkViewModel };
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Exception in CreateChunkViewModelCollection for {redData.GetType().Name}: {ex}");
                return new List<ChunkViewModel>();
            }
        }

        private void AutoExpandProperties(ChunkViewModel? rootChunk, RedBaseClass redData)
        {
            if (rootChunk == null)
            {
                return;
            }

            try
            {
                // Always expand the first level to show immediate properties
                rootChunk.IsExpanded = true;

                var typeName = redData.GetType().Name;

                if (typeName == "scnQuestNode")
                {
                    var questNodeProperty = rootChunk.TVProperties?.FirstOrDefault(p =>
                        p.Name.Equals("questNode", StringComparison.OrdinalIgnoreCase));

                    if (questNodeProperty != null)
                    {
                        try
                        {
                            questNodeProperty.CalculateProperties();
                            questNodeProperty.IsExpanded = true;

                            if (questNodeProperty.ResolvedData is questNodeDefinition)
                            {
                                foreach (var nestedProperty in questNodeProperty.TVProperties ?? Enumerable.Empty<ChunkViewModel>())
                                {
                                    if (nestedProperty.Name.Equals("sockets", StringComparison.OrdinalIgnoreCase))
                                    {
                                        continue;
                                    }

                                    try
                                    {
                                        nestedProperty.CalculateProperties();
                                        nestedProperty.IsExpanded = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        LoggerService?.Error($"Failed to expand nested quest node property '{nestedProperty.Name}': {ex.Message}");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LoggerService?.Error($"Failed to expand questNode property: {ex.Message}");
                        }
                    }
                }
                // For section nodes, expand to the events field
                else if (typeName is ("scnSectionNode" or "scnRewindableSectionNode") &&
                         rootChunk.GetPropertyChild("events") is { } eventsProperty)
                {
                    try
                    {
                        eventsProperty.CalculateProperties();
                        eventsProperty.IsExpanded = true;
                    }
                    catch (Exception ex)
                    {
                        LoggerService?.Error($"Failed to expand events property: {ex.Message}");
                    }
                }
                // For FactsDB manager nodes, expand all the way to the actual type
                else if (typeName == "questFactsDBManagerNodeDefinition" && rootChunk.GetPropertyChild("factsDB") is
                { } factsDBProperty)
                {
                    // These nodes have deep nesting, expand a few levels
                    try
                    {
                        factsDBProperty.CalculateProperties();
                        factsDBProperty.IsExpanded = true;
                    }
                    catch (Exception ex)
                    {
                        LoggerService?.Error($"Failed to expand factsDB property: {ex.Message}");
                    }

                }
                // For all quest node types in quest graphs, expand everything one level except sockets
                else if (redData is questNodeDefinition)
                {
                    try
                    {
                        // Auto-expand all properties one level deep, but exclude sockets
                        foreach (var property in rootChunk.TVProperties ?? Enumerable.Empty<ChunkViewModel>())
                        {
                            // Skip socket properties to keep them collapsed
                            if (property.Name.Equals("sockets", StringComparison.OrdinalIgnoreCase))
                            {
                                continue;
                            }

                            try
                            {
                                property.CalculateProperties();
                                property.IsExpanded = true;
                            }
                            catch (Exception ex)
                            {
                                LoggerService?.Error($"Failed to expand property '{property.Name}' for quest node: {ex.Message}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LoggerService?.Error($"Failed to auto-expand quest node properties: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Exception in AutoExpandProperties: {ex.Message}");
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException("RedTypeToChunkViewModelCollectionConverter is one-way only");
        }
    }
}
