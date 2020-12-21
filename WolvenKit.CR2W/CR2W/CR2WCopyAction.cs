using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.Common.Services;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    /// <summary>
    /// Copy-pasting has been scattered /TODO recentralize here
    /// </summary>
    public class CR2WCopyAction
    {
        public Dictionary<CR2WExportWrapper, CR2WExportWrapper> chunkTranslation; // source, target

        public CR2WCopyAction()
        {
            chunkTranslation = new Dictionary<CR2WExportWrapper, CR2WExportWrapper>();
        }

        public CR2WExportWrapper SourceChunk { get; set; }
        public CR2WExportWrapper DestinationChunk { get; set; }
        public CVariable SourceCVar => SourceChunk.data;
        public CVariable DestinationCVar => DestinationChunk.data;
        public CR2WFile SourceFile { get; set; }
        public CR2WFile DestinationFile { get; set; }
        public CVariable Parent { get; set; }

        /// <summary>
        /// Used when pasting-in-place a chunk, takes care of (virtual) children.
        /// </summary>
        /// <param name="sourcechunk"></param>
        /// <param name="destinationchunk"></param>
        /// <param name="oldparentinghierarchy"></param>
        public void AddChildrenChunks(
            CR2WExportWrapper sourcechunk,
            CR2WExportWrapper destinationchunk = null,
            Dictionary<CR2WExportWrapper,
                (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)> oldparentinghierarchy = null)
        {
            // First recursion to create the "empty" chunk descendent shells
            DeepChunkCopy(SourceChunk, DestinationChunk);

            // Reparent full old chunk hierarchy to take into account the inserted children
            foreach (var achunk in DestinationFile.Chunks)
            {
                if (oldparentinghierarchy.ContainsKey(achunk))
                {
                    achunk.ParentChunk = oldparentinghierarchy[achunk].oldchunkparent;
                }
            }

            // Second recursion to copy the cvars - "deepvarcopy"
            // Pointers are handled during this.
            foreach (var chunktranslationentry in chunkTranslation)
            {
                chunktranslationentry.Value.CreateDefaultData(chunktranslationentry.Key.data.Copy(this));
            }

            // From root call : reparent copied chunks
            foreach (var chunktranslationentry in chunkTranslation)
            {
                // parent
                chunktranslationentry.Value.ParentChunk = TryLookupReference(chunktranslationentry.Key.ParentChunk);
                // virtual parent
                chunktranslationentry.Value.MountChunkVirtually(TryLookupReference(chunktranslationentry.Key.VirtualParentChunk), true);
            }
        }

        /// <summary>
        /// Used whith paste-insert
        /// </summary>
        /// <param name="sourcechunks"></param>
        /// <param name="targetarray"></param>
        /// <param name="oldparentinghierarchy"></param>
        public void PasteChunksInArray(
            List<CR2WExportWrapper> sourcechunks,
            IArrayAccessor targetarray,
            Dictionary<CR2WExportWrapper,
                (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)> oldparentinghierarchy = null)
        {
            // First recursion to create the "empty" chunk descendent shells
            foreach (var sourcechunk in sourcechunks)
            {
                SourceChunk = sourcechunk;
                //Create the related chunk
                var newchunk = DestinationFile.CreateChunk(
                        sourcechunk.data.REDType,
                        DestinationFile.GetLastChildrenIndexRecursive(DestinationChunk) + 1);

                if(!chunkTranslation.ContainsKey(sourcechunk))
                {
                    chunkTranslation.Add(sourcechunk, newchunk);
                }

                newchunk.ParentChunk = TryLookupReference(sourcechunk.ParentChunk);
                newchunk.MountChunkVirtually(TryLookupReference(sourcechunk.VirtualParentChunk), true);

                DeepChunkCopy(sourcechunk, newchunk, false);
            }


            // Reparent full old chunk hierarchy to take into account the inserted children
            foreach (var achunk in DestinationFile.Chunks)
            {
                if (oldparentinghierarchy.ContainsKey(achunk))
                {
                    achunk.ParentChunk = oldparentinghierarchy[achunk].oldchunkparent;
                }
            }

            // Second recursion to copy the cvars - "deepvarcopy"
            // Pointers are handled during this.
            foreach (var chunktranslationentry in chunkTranslation)
            {
                var copy = chunktranslationentry.Key.data.Copy(this);
                chunktranslationentry.Value.CreateDefaultData(copy);

                // Corner cases :
                // - add descending CNewNPC components
                if (targetarray.REDName == "Components" &&
                    DestinationFile.Chunks[targetarray.LookUpChunkIndex()].REDType == "CNewNPC" &&
                    copy is CComponent &&
                    !sourcechunks.Contains(chunktranslationentry.Key))
                {
                    var uppercopy = CR2WTypeManager.Create("ptr:CComponent", chunktranslationentry.Value.REDName, DestinationFile, (targetarray as CVariable));
                    (uppercopy as IChunkPtrAccessor).Reference = chunktranslationentry.Value;
                    targetarray.AddVariable(uppercopy);
                }
            }
        }

        /// <summary>
        /// Recursive function used both by paste-in-place and paste-insert.
        /// </summary>
        /// <param name="sourcechunk"></param>
        /// <param name="destinationchunk"></param>
        /// <param name="inplace"></param>
        private void DeepChunkCopy (CR2WExportWrapper sourcechunk, CR2WExportWrapper destinationchunk, bool inplace = true)
        {
            Parent = null;
            foreach (var sourcevirtualchildchunk in sourcechunk.VirtualChildrenChunks)
            {
                var newchunk = DestinationFile.CreateChunk(
                    sourcevirtualchildchunk.data.REDType,
                    inplace ? destinationchunk.ChunkIndex + sourcevirtualchildchunk.ChunkIndex - SourceChunk.ChunkIndex
                            : destinationchunk.cr2w.GetLastChildrenIndexRecursive(destinationchunk) + 1);

                if(!chunkTranslation.ContainsKey(sourcevirtualchildchunk))
                {
                    chunkTranslation.Add(sourcevirtualchildchunk, newchunk);
                }

                if (!inplace)
                {
                    newchunk.ParentChunk = TryLookupReference(sourcevirtualchildchunk.ParentChunk);
                    newchunk.MountChunkVirtually(TryLookupReference(sourcevirtualchildchunk.VirtualParentChunk), true);
                }

                DeepChunkCopy(sourcevirtualchildchunk, newchunk, inplace);
            }
        }

        /// <summary>
        /// Tries to look up a chunk reference in a cr2w file by a number of checks
        /// This method is only called on Pointer/Soft copy
        /// This is unsafe! A chunk could fit all criteria but still not be the intended pointer/soft reference *for the user*!
        /// It is deterministically impossible to get this right, so the user will always have to double check.
        /// </summary>
        /// <param name="oldExportWrapper"></param>
        /// <param name="targetVariable"></param>
        /// <returns></returns>
        internal CR2WExportWrapper TryLookupReference(CR2WExportWrapper oldExportWrapper, CVariable targetVariable = null)
        {
            if (oldExportWrapper == null)
            {
                return null;
            }

            // Try from this context translation dict
            if (chunkTranslation.ContainsKey(oldExportWrapper))
            {
                return chunkTranslation[oldExportWrapper];
            }

            // Try going up the chunk hierarchy
            CR2WExportWrapper parent = DestinationChunk;
            while (parent != null)
            {
                if (parent.REDType == oldExportWrapper.REDType)
                {
                    return parent;
                }
                parent = parent.VirtualParentChunk;
            }

            // Try last way
            string vardepstring = null;
            if(targetVariable != null)
            {
                vardepstring = targetVariable.GetFullDependencyStringName();
            }
            var chunkdepstring = oldExportWrapper.GetFullChunkTypeDependencyString();

            var targetchunk = DestinationFile.Chunks.Where(_ =>
                _.GetFullChunkTypeDependencyString() == chunkdepstring)
                .ToList();

            if (targetchunk.Count == 1)
            {
                //Logger?.LogString($"Found exactly one chunk target. Please double check pointer targets in {vardepstring}", Logtype.Success);
                return targetchunk.FirstOrDefault();
            }
            else if (targetchunk.Count > 1)
            {
                DestinationFile.Logger?.LogString($"More than one chunk target found, please set pointer target manually in {(targetVariable != null ? vardepstring : chunkdepstring)}", Logtype.Error);
                return null;
            }
            else
            {
                DestinationFile.Logger?.LogString($"No chunk target found, please set pointer target manually in {(targetVariable != null ? vardepstring : chunkdepstring)}", Logtype.Error);
                return null;
            }
        }
    }
}