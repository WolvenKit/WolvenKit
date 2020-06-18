using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public class CR2WCopyAction
    {
        internal List<CR2WExportWrapper> chunks;
        internal Dictionary<int, int> chunkTranslation;
        internal List<CPtr<CVariable>> ptrs;

        public CR2WCopyAction()
        {
            ptrs = new List<CPtr<CVariable>>();
            chunks = new List<CR2WExportWrapper>();
            chunkTranslation = new Dictionary<int, int>();
        }

        public CR2WFile DestinationFile { get; set; }

        /// <summary>
        ///     List of excluded property names
        /// </summary>
        public IEnumerable<string> ExcludeProperties { get; set; }

        /// <summary>
        ///     List of excluded chunk types
        /// </summary>
        public IEnumerable<string> ExcludeChunks { get; set; }

        /// <summary>
        ///     How many pointers deep the copy action should iterate when doing a deep copy.
        /// </summary>
        public int MaxIterationDepth { get; set; }

        public CR2WFile SourceFile { get; set; }

        /// <summary>
        ///     Removes all unnessary offsets from story scene sections
        ///     e.g. if all placement offsets are at least z = 10 then it will deduct 10 from all z placement offsets
        /// </summary>
        public bool StorySceneRemoveUnnessaryTeleportation { get; set; }

        /// <summary>
        ///     Remove all add fact events
        ///     Usefull when you just want to copy the scene and not have facts be applied that could influence the story.
        /// </summary>
        public bool StorySceneRemoveAddFacts { get; set; }

        /// <summary>
        ///     Copy scene dialog sets by name
        /// </summary>
        public bool StorySceneCopyDialogsets { get; set; }

        /// <summary>
        ///     Copy scene cameras by name
        /// </summary>
        public bool StorySceneCopyCameras { get; set; }

        /// <summary>
        ///     Deep copies a chunk.
        /// </summary>
        /// <param name="chunkSource"></param>
        /// <param name="destinationFile"></param>
        /// <param name="maxDepth"></param>
        /// <param name="excludeProperties"></param>
        /// <param name="excludeChunks"></param>
        /// <param name="storySceneRemoveUnnessaryTeleportation"></param>
        /// <param name="storySceneRemoveAddFacts"></param>
        /// <param name="storySceneCopyDialogsets"></param>
        /// <param name="storySceneCopyCameras"></param>
        /// <returns></returns>
        public static CR2WExportWrapper CopyChunk(CR2WExportWrapper chunkSource, CR2WFile destinationFile,
            int maxDepth = -1,
            IEnumerable<string> excludeProperties = null,
            IEnumerable<string> excludeChunks = null,
            bool storySceneRemoveUnnessaryTeleportation = false,
            bool storySceneRemoveAddFacts = false,
            bool storySceneCopyDialogsets = false,
            bool storySceneCopyCameras = false)
        {
            var context = new CR2WCopyAction
            {
                SourceFile = chunkSource.cr2w,
                DestinationFile = destinationFile,
                MaxIterationDepth = maxDepth,
                ExcludeProperties = excludeProperties,
                ExcludeChunks = excludeChunks,
                StorySceneRemoveUnnessaryTeleportation = storySceneRemoveUnnessaryTeleportation,
                StorySceneRemoveAddFacts = storySceneRemoveAddFacts,
                StorySceneCopyDialogsets = storySceneCopyDialogsets,
                StorySceneCopyCameras = storySceneCopyCameras
            };


            var result = context.CopyChunk(chunkSource);

            context.DeepCopy();

            return result;
        }

        /// <summary>
        ///     Copies pointers and their chunks.
        ///     Fixes all pointers and parent id's
        /// </summary>
        public void DeepCopy()
        {
            var depth = 0;
            var ptrIndex = 0;

            while ((depth < MaxIterationDepth || MaxIterationDepth == -1) && ptrs.Count - ptrIndex > 0)
            {
                var ptrCount = ptrs.Count;
                    // save current pointer count all, pointers that get added are in a higher depth
                // follow all pointers and copy their chunks
                for (; ptrIndex < ptrCount; ptrIndex++)
                {
                    var ptr = ptrs[ptrIndex];

                    CopyChunk(SourceFile.chunks[ptr.Reference.ChunkIndex]);
                }


                depth++;
            }

            // reparent chunks
            foreach (var chunk in chunks)
            {
                if (chunkTranslation.ContainsKey((int) chunk.ParentChunkId - 1))
                {
                    chunk.SetParentChunkId((uint) chunkTranslation[(int) chunk.ParentChunkId - 1] + 1);
                }
                else if (SourceFile == DestinationFile)
                {
                    // Don't do anything, pointers are valid.
                }
                else
                {
                    // this chunk's parent was not copied, use the first chunk as parent
                    chunk.SetParentChunkId(1);
                }
            }

            // fix all pointers
            foreach (var ptr in ptrs)
            {
                if (chunkTranslation.ContainsKey(ptr.Reference.ChunkIndex))
                {
                    //ptr.ChunkIndex = chunkTranslation[ptr.PtrTarget.ChunkIndex];
                    int translatedidx = chunkTranslation[ptr.Reference.ChunkIndex];
                    ptr.Reference = DestinationFile.chunks[translatedidx];
                }
                else if (SourceFile == DestinationFile)
                {
                    // Don't do anything, pointers are valid.
                }
                else
                {
// this ptr's target was not copied, point to 0
                    ptr.Reference = null;
                }
            }
        }

        public bool ShouldCopy(CVariable item)
        {
            if (ExcludeProperties != null &&
                ExcludeProperties.Contains(item.Name))
                return false;

            return true;
        }

        private CR2WExportWrapper CopyChunk(CR2WExportWrapper chunk)
        {
            if (ExcludeChunks != null
                && ExcludeChunks.Contains(chunk.Type))
                return null;

            var chunkcopy = chunk.Copy(this);

            if (chunkcopy != null)
            {
                if (chunkcopy.data is CStorySceneSection)
                {
                    OnCopyStorySceneSection(chunkcopy);
                }

                CStoryScene CStoryScene = DestinationFile.GetChunkByType("CStoryScene").data as CStoryScene;
                if (CStoryScene != null)
                {
                    CArray<CPtr<CStorySceneControlPart>> controlParts = CStoryScene.ControlParts;
                    // Add this chunk to the controlParts
                    if (controlParts != null)
                    {
                        switch (chunkcopy.Type)
                        {
                            case "CStorySceneInput":

                            case "CStorySceneScript":
                            case "CStorySceneFlowCondition":

                            case "CStorySceneSection":
                            case "CStorySceneCutsceneSection":
                            case "CStorySceneVideoSection":
                            case "CStorySceneRandomizer":
                            case "CStorySceneOutput":
                            case "CStorySceneCutscenePlayer":

                                //DestinationFile.CreatePtr(controlParts, chunkcopy);
                                controlParts.AddVariable(new CPtr<CStorySceneControlPart>(DestinationFile)
                                {
                                    Reference = chunkcopy
                                }
                                );
                                break;

                            default:
                                break;
                        }
                    }

                    CArray<CPtr<CStorySceneSection>> sections = CStoryScene.Sections;
                    // Add this chunk to the sections
                    if (sections != null)
                    {
                        switch (chunkcopy.Type)
                        {
                            case "CStorySceneSection":
                            case "CStorySceneCutsceneSection":
                            case "CStorySceneVideoSection":

                                //DestinationFile.CreatePtr(sections, chunkcopy);
                                sections.AddVariable(new CPtr<CStorySceneControlPart>(DestinationFile)
                                {
                                    Reference = chunkcopy
                                }
                                );
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            return chunkcopy;
        }

        private void OnCopyStorySceneSection(CR2WExportWrapper chunkcopy)
        {
            var storysection = (CStorySceneSection) chunkcopy.data;

            if (StorySceneRemoveAddFacts)
            {
                removeStorySceneAddFacts(storysection);
            }

            if (StorySceneRemoveUnnessaryTeleportation)
            {
                removeUnnessaryTeleportation(storysection);
            }

            if (StorySceneCopyDialogsets)
            {
                copyDialogset(storysection);
            }

            if (StorySceneCopyCameras)
            {
                copyStorySceneCameras(storysection);
            }
        }

        private static void removeStorySceneAddFacts(CStorySceneSection storysection)
        {
            var factevents =
                storysection.sceneEventElements.elements.FindAll(
                    delegate(CVariantSizeTypeName sectionitem) { return sectionitem.Type == "CStorySceneAddFactEvent"; });

            foreach (var factevent in factevents)
            {
                storysection.sceneEventElements.Remove(factevent);
            }
        }

        private void copyStorySceneCameras(CStorySceneSection storysection)
        {
            CStoryScene CStoryScene = DestinationFile.GetChunkByType("CStoryScene").data as CStoryScene;
            CArray<StorySceneCameraDefinition> cameraInstances = CStoryScene.CameraDefinitions;

            CStoryScene CStorySceneSource = SourceFile.GetChunkByType("CStoryScene").data as CStoryScene;
            CArray<StorySceneCameraDefinition> cameraInstancesSource = CStorySceneSource.CameraDefinitions;

            foreach (var e in storysection.sceneEventElements)
            {
                if (e != null && e is CStorySceneEventCustomCameraInstance && e.Type == "CStorySceneEventCustomCameraInstance")
                {
                    var v = (CStorySceneEventCustomCameraInstance) e.Variable;
                    CName n = v.CustomCameraName;
                    if (n != null)
                    {
                        var camera = findCameraInstance(cameraInstances, n.Value);

                        // Doesn't exist yet, copy from source
                        if (camera == null)
                        {
                            var sourceCamera = findCameraInstance(cameraInstancesSource, n.Value);

                            if (sourceCamera != null)
                            {
                                cameraInstances.AddVariable(sourceCamera.Copy(this));
                            }
                        }
                    }
                }
            }
        }

        private CVariable findCameraInstance(CArray<StorySceneCameraDefinition> cameraInstances, string findCameraName)
        {
            try
            {
                return cameraInstances.elements.FirstOrDefault(_ => _.CameraName.Value == findCameraName);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private CR2WExportWrapper findDialogset(CR2WFile infile, string dialogsetName)
        {
            var camera = infile.chunks.Find(delegate (CR2WExportWrapper chunk)
            {
                if (chunk != null && chunk.data != null)
                {
                    var scene = chunk.data as CStoryScene;
                    var name = scene.Name; //FIXME
                    return (name != null && name == dialogsetName);
                }

                return false;
            });

            return camera;
        }

        private void copyDialogset(CStorySceneSection storysection)
        {
            // see if it has a change dialog set property
            CName dlgset = storysection.DialogsetChangeTo;
            if (dlgset != null)
            {
                // see if we already have a dialog set with this name
                var destdlgset = findDialogset(DestinationFile, dlgset.Value);
                if (destdlgset == null)
                {
                    // we dont so find the one in the source and copy it.
                    var srcdlgset = findDialogset(SourceFile, dlgset.Value);
                    if (srcdlgset != null)
                    {
                        CStoryScene CStoryScene = DestinationFile.GetChunkByType("CStoryScene").data as CStoryScene;
                        CArray<CPtr<CStorySceneDialogsetInstance>> dialogsetInstances = CStoryScene.DialogsetInstances;

                        var copieddialogsetchunk = srcdlgset.Copy(this);
                        CStorySceneDialogsetInstance copieddialogset = (CStorySceneDialogsetInstance)copieddialogsetchunk.data;

                        //DestinationFile.CreatePtr(dialogsetInstances, copieddialogset);
                        dialogsetInstances.AddVariable(new CPtr<CStorySceneDialogsetInstance>(DestinationFile)
                        {
                            Reference = copieddialogsetchunk
                        }
                        );

                        TagList placementTag = copieddialogset.PlacementTag;
                        placementTag.tags.Clear();
                        placementTag.tags.AddVariable(new CName(DestinationFile) { Value = "PLAYER" }); //FIXME variable name or value?
                    }
                }
            }
        }

        private static void removeUnnessaryTeleportation(CStorySceneSection storysection)
        {
            var placement_x = 0.0f;
            var placement_y = 0.0f;
            var placement_z = 0.0f;
            storysection.sceneEventElements.elements.ForEach(delegate (CVariantSizeTypeName sectionvar)
            {
                if (sectionvar.Type == "CStorySceneEventOverridePlacement")
                {
                    var placement = (sectionvar.Variable as CStorySceneEventOverridePlacement).Placement;

                    if (placement_x == 0 || Math.Abs(placement.X.val) < Math.Abs(placement_x))
                        placement_x = placement.X.val;
                    if (placement_y == 0 || Math.Abs(placement.Y.val) < Math.Abs(placement_y))
                        placement_y = placement.Y.val;
                    if (placement_z == 0 || Math.Abs(placement.Z.val) < Math.Abs(placement_z))
                        placement_z = placement.Z.val;
                }
            });

            // Remove Unnessasary teleportation
            storysection.sceneEventElements.elements.ForEach(delegate (CVariantSizeTypeName sectionvar)
            {
                if (sectionvar.Type == "CStorySceneEventOverridePlacement")
                {
                    var placement = (sectionvar.Variable as CStorySceneEventOverridePlacement).Placement;
                    if (placement != null)
                    {
                        placement.X.val -= placement_x;
                        placement.Y.val -= placement_y;
                        placement.Z.val -= placement_z;
                    }
                }
                else if (sectionvar.Type == "CStorySceneEventCustomCamera")
                {
                    var cameraDefinition = (sectionvar.Variable as CStorySceneEventCustomCamera).CameraDefinition;
                    var cameraTransform = cameraDefinition.CameraTransform;

                    cameraTransform.X.val -= placement_x;
                    cameraTransform.Y.val -= placement_y;
                    cameraTransform.Z.val -= placement_z;

                    var cameraTranslation = (sectionvar.Variable as CStorySceneEventCustomCamera).CameraTranslation;
                    if (cameraTranslation != null)
                    {
                        cameraTranslation.X.val -= placement_x;
                        cameraTranslation.Y.val -= placement_y;
                        cameraTranslation.Z.val -= placement_z;
                    }
                }
                else if (sectionvar.Type == "CStorySceneEventCameraLight")
                {
                    SStorySceneCameraLightMod lightMod1 = (sectionvar.Variable as CStorySceneEventCameraLight).LightMod1;
                    if (lightMod1 != null)
                    {
                        var lightOffset = lightMod1.LightOffset;

                        if (lightOffset != null)
                        {
                            lightOffset.X.val -= placement_x;
                            lightOffset.Y.val -= placement_y;
                            lightOffset.Z.val -= placement_z;
                        }
                    }
                }
            });
            ///
        }
    }
}