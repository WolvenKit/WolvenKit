using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Helpers
{
    public static class CollectionViewHelper
    {
        public static ICollectionView CreateFilteredView(ChunkViewModel rootChunk, Func<ChunkViewModel, bool> filter)
        {
            var view = new ListCollectionView(rootChunk.TVProperties);
            view.Filter = obj => obj is ChunkViewModel chunk && filter(chunk);
            return view;
        }

        public static Func<ChunkViewModel, bool> CreateSceneFilter(string propertyPath)
        {
            return chunk => 
            {
                if (string.IsNullOrEmpty(propertyPath))
                    return true;

                var current = chunk;
                var pathParts = propertyPath.Split('.');
                
                foreach (var part in pathParts)
                {
                    current = current?.GetPropertyChild(part);
                    if (current == null)
                        return false;
                }
                
                return current.PropertyCount > 0;
            };
        }

        public static Func<ChunkViewModel, bool> CreateNodePropertiesFilter()
        {
            return chunk => chunk.Name == "sceneGraph";
        }

        public static Func<ChunkViewModel, bool> CreateActorsAndPropsFilter()
        {
            return chunk => 
            {
                return chunk.Name == "actors" || 
                       chunk.Name == "playerActors" || 
                       chunk.Name == "debugSymbols" ||
                       chunk.Name == "props";
            };
        }

        public static Func<ChunkViewModel, bool> CreateLogicAndFlowFilter()
        {
            return chunk => 
            {
                return chunk.Name == "entryPoints" ||
                       chunk.Name == "exitPoints" ||
                       chunk.Name == "notablePoints" ||
                       chunk.Name == "interruptionScenarios" || 
                       chunk.Name == "startNodes" ||
                       chunk.Name == "endNodes";
            };
        }

        public static Func<ChunkViewModel, bool> CreateDialogueFilter()
        {
            return chunk => 
            {
                return chunk.Name == "locStore" ||
                       chunk.Name == "screenplayStore" ||
                       chunk.Name == "voInfo";
            };
        }

        public static Func<ChunkViewModel, bool> CreateAssetLibraryFilter()
        {
            return chunk => 
            {
                return chunk.Name == "resouresReferences" ||
                       chunk.Name == "ridResources" ||
                       chunk.Name == "effectDefinitions" ||
                       chunk.Name == "effectInstances" ||
                       chunk.Name == "workspots" ||
                       chunk.Name == "workspotInstances";
            };
        }

        public static Func<ChunkViewModel, bool> CreateMarkersAndMetadataFilter()
        {
            return chunk => 
            {
                return chunk.Name == "localMarkers" ||
                       chunk.Name == "referencePoints" ||
                       chunk.Name == "version" ||
                       chunk.Name == "sceneCategoryTag" ||
                       chunk.Name == "executionTagEntries" ||
                       chunk.Name == "executionTags" ||
                       chunk.Name == "sceneSolutionHash" ||
                       chunk.Name == "cookingPlatform";
            };
        }

        // Quest Phase specific filters
        public static Func<ChunkViewModel, bool> CreateQuestNodePropertiesFilter()
        {
            return chunk => chunk.Name == "graph";
        }

        public static Func<ChunkViewModel, bool> CreateQuestPhaseResourcesFilter()
        {
            return chunk => 
            {
                return chunk.Name == "phasePrefabs" || 
                       chunk.Name == "inplacePhases";
            };
        }

        // Legacy filters for backward compatibility
        public static Func<ChunkViewModel, bool> CreateActorsFilter() => CreateActorsAndPropsFilter();
        public static Func<ChunkViewModel, bool> CreatePerformersFilter() => CreateAssetLibraryFilter();
        public static Func<ChunkViewModel, bool> CreateAnimSetsFilter() => CreateAssetLibraryFilter();
        public static Func<ChunkViewModel, bool> CreateWorkspotFilter() => CreateAssetLibraryFilter();
        public static Func<ChunkViewModel, bool> CreateInterruptsFilter() => CreateLogicAndFlowFilter();
        public static Func<ChunkViewModel, bool> CreateResourcesFilter() => CreateAssetLibraryFilter();
        public static Func<ChunkViewModel, bool> CreateMetadataFilter() => CreateMarkersAndMetadataFilter();
    }
} 