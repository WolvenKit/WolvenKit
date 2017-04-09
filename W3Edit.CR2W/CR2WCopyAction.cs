using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public class CR2WCopyAction
    {
        internal List<CR2WChunk> chunks;
        internal Dictionary<int, int> chunkTranslation;
        internal List<CPtr> ptrs;

        public CR2WCopyAction()
        {
            ptrs = new List<CPtr>();
            chunks = new List<CR2WChunk>();
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
        public static CR2WChunk CopyChunk(CR2WChunk chunkSource, CR2WFile destinationFile,
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

                    CopyChunk(SourceFile.chunks[ptr.ChunkIndex]);
                }


                depth++;
            }

            // reparent chunks
            foreach (var chunk in chunks)
            {
                if (chunkTranslation.ContainsKey((int) chunk.ParentChunkId - 1))
                {
                    chunk.ParentChunkId = (uint) chunkTranslation[(int) chunk.ParentChunkId - 1] + 1;
                }
                else if (SourceFile == DestinationFile)
                {
                    // Don't do anything, pointers are valid.
                }
                else
                {
// this chunk's parent was not copied, use the first chunk as parent
                    chunk.ParentChunkId = 1;
                }
            }

            // fix all pointers
            foreach (var ptr in ptrs)
            {
                if (chunkTranslation.ContainsKey(ptr.ChunkIndex))
                {
                    ptr.ChunkIndex = chunkTranslation[ptr.ChunkIndex];
                }
                else if (SourceFile == DestinationFile)
                {
                    // Don't do anything, pointers are valid.
                }
                else
                {
// this ptr's target was not copied, point to 0
                    ptr.val = 0;
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

        private CR2WChunk CopyChunk(CR2WChunk chunk)
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

                var CStoryScene = DestinationFile.GetChunkByType("CStoryScene");
                if (CStoryScene != null)
                {
                    var controlParts = CStoryScene.GetVariableByName("controlParts") as CArray;
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

                                DestinationFile.CreatePtr(controlParts, chunkcopy);
                                break;

                            default:
                                break;
                        }
                    }

                    var sections = CStoryScene.GetVariableByName("sections") as CArray;
                    // Add this chunk to the sections
                    if (sections != null)
                    {
                        switch (chunkcopy.Type)
                        {
                            case "CStorySceneSection":
                            case "CStorySceneCutsceneSection":
                            case "CStorySceneVideoSection":

                                DestinationFile.CreatePtr(sections, chunkcopy);
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            return chunkcopy;
        }

        private void OnCopyStorySceneSection(CR2WChunk chunkcopy)
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
                storysection.sceneEventElements.FindAll(
                    delegate(CVariable sectionitem) { return sectionitem.Type == "CStorySceneAddFactEvent"; });

            foreach (var factevent in factevents)
            {
                storysection.sceneEventElements.Remove(factevent);
            }
        }

        private void copyStorySceneCameras(CStorySceneSection storysection)
        {
            var CStoryScene = DestinationFile.GetChunkByType("CStoryScene");
            var cameraInstances = (CArray) CStoryScene.GetVariableByName("cameraDefinitions");

            var CStorySceneSource = SourceFile.GetChunkByType("CStoryScene");
            var cameraInstancesSource = (CArray) CStorySceneSource.GetVariableByName("cameraDefinitions");

            foreach (var e in storysection.sceneEventElements)
            {
                if (e != null && e is CVector && e.Type == "CStorySceneEventCustomCameraInstance")
                {
                    var v = (CVector) e;
                    var n = v.GetVariableByName("customCameraName") as CName;
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

        private CVariable findCameraInstance(CArray cameraInstances, string findCameraName)
        {
            var camera = cameraInstances.array.Find(delegate(CVariable c)
            {
                if (c != null && c is CVector)
                {
                    var v = (CVector) c;
                    var cameraName = v.GetVariableByName("cameraName") as CName;
                    return (cameraName != null && cameraName.Value == findCameraName);
                }

                return false;
            });

            return camera;
        }

        private CR2WChunk findDialogset(CR2WFile infile, string dialogsetName)
        {
            var camera = infile.chunks.Find(delegate(CR2WChunk c)
            {
                if (c != null && c.data != null && c.data is CVector)
                {
                    var v = (CVector) c.data;
                    var name = v.GetVariableByName("name") as CName;
                    return (name != null && name.Value == dialogsetName);
                }

                return false;
            });

            return camera;
        }

        private void copyDialogset(CStorySceneSection storysection)
        {
            // see if it has a change dialog set property
            var dlgset = storysection.GetVariableByName("dialogsetChangeTo") as CName;
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
                        var CStoryScene = DestinationFile.GetChunkByType("CStoryScene");
                        var dialogsetInstances = (CArray) CStoryScene.GetVariableByName("dialogsetInstances");

                        var copieddialogset = srcdlgset.Copy(this);
                        DestinationFile.CreatePtr(dialogsetInstances, copieddialogset);
                        var placementTag = (CTagList) copieddialogset.GetVariableByName("placementTag");
                        placementTag.tags.Clear();
                        placementTag.tags.Add((CName) DestinationFile.CreateVariable("CName").SetValue("PLAYER"));
                    }
                }
            }
        }

        private static void removeUnnessaryTeleportation(CStorySceneSection storysection)
        {
            var placement_x = 0.0f;
            var placement_y = 0.0f;
            var placement_z = 0.0f;
            storysection.sceneEventElements.ForEach(delegate(CVariable sectionvar)
            {
                var sectionitem = ((CVector) sectionvar);

                if (sectionitem.Type == "CStorySceneEventOverridePlacement")
                {
                    var placement = (CEngineTransform) sectionitem.variables.GetVariableByName("placement");

                    if (placement_x == 0 || Math.Abs(placement.x.val) < Math.Abs(placement_x))
                        placement_x = placement.x.val;
                    if (placement_y == 0 || Math.Abs(placement.y.val) < Math.Abs(placement_y))
                        placement_y = placement.y.val;
                    if (placement_z == 0 || Math.Abs(placement.z.val) < Math.Abs(placement_z))
                        placement_z = placement.z.val;
                }
            });

            /// Remove Unnessasary teleportation
            storysection.sceneEventElements.ForEach(delegate(CVariable sectionvar)
            {
                var sectionitem = ((CVector) sectionvar);

                if (sectionitem.Type == "CStorySceneEventOverridePlacement")
                {
                    var placement = (CEngineTransform) sectionitem.variables.GetVariableByName("placement");
                    if (placement != null)
                    {
                        placement.x.val -= placement_x;
                        placement.y.val -= placement_y;
                        placement.z.val -= placement_z;
                    }
                }
                else if (sectionitem.Type == "CStorySceneEventCustomCamera")
                {
                    var cameraDefinition = (CVector) sectionitem.variables.GetVariableByName("cameraDefinition");
                    var cameraTransform = (CEngineTransform) cameraDefinition.GetVariableByName("cameraTransform");

                    cameraTransform.x.val -= placement_x;
                    cameraTransform.y.val -= placement_y;
                    cameraTransform.z.val -= placement_z;

                    var cameraTranslation = (CVector) sectionitem.variables.GetVariableByName("cameraTranslation");
                    if (cameraTranslation != null)
                    {
                        ((CFloat) cameraTranslation.GetVariableByName("X")).val -= placement_x;
                        ((CFloat) cameraTranslation.GetVariableByName("Y")).val -= placement_y;
                        ((CFloat) cameraTranslation.GetVariableByName("Z")).val -= placement_z;
                    }
                }
                else if (sectionitem.Type == "CStorySceneEventCameraLight")
                {
                    var lightMod1 = (CVector) sectionitem.variables.GetVariableByName("lightMod1");
                    if (lightMod1 != null)
                    {
                        var lightOffset = (CVector) lightMod1.GetVariableByName("lightOffset");

                        if (lightOffset != null)
                        {
                            ((CFloat) lightOffset.GetVariableByName("X")).val -= placement_x;
                            ((CFloat) lightOffset.GetVariableByName("Y")).val -= placement_y;
                            ((CFloat) lightOffset.GetVariableByName("Z")).val -= placement_z;
                        }
                    }
                }
            });
            ///
        }
    }
}