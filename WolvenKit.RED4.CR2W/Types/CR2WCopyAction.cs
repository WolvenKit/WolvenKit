using System.Collections.Generic;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Helpers;

namespace WolvenKit.RED4.CR2W
{
    /// <summary>
    /// Copy-pasting has been scattered /TODO recentralize here
    /// </summary>
    public class CR2WCopyAction : ICR2WCopyAction
    {
        #region Fields

        public Dictionary<ICR2WExport, ICR2WExport> chunkTranslation;

        #endregion Fields

        // source, target

        #region Constructors

        public CR2WCopyAction()
        {
            chunkTranslation = new Dictionary<ICR2WExport, ICR2WExport>();
        }

        #endregion Constructors

        #region Properties

        public ICR2WExport DestinationChunk { get; set; }
        public IEditableVariable DestinationCVar => DestinationChunk.Data;
        public IWolvenkitFile DestinationFile { get; set; }
        public IEditableVariable Parent { get; set; }
        public ICR2WExport SourceChunk { get; set; }
        public IEditableVariable SourceCVar => SourceChunk.Data;
        public IWolvenkitFile SourceFile { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Used when pasting-in-place a chunk, takes care of (virtual) children.
        /// </summary>
        /// <param name="sourcechunk"></param>
        /// <param name="destinationchunk"></param>
        /// <param name="oldparentinghierarchy"></param>
        public void AddChildrenChunks(
            ICR2WExport sourcechunk,
            ICR2WExport destinationchunk = null,
            Dictionary<ICR2WExport,
                (ICR2WExport oldchunkparent, ICR2WExport oldchunkvparent)> oldparentinghierarchy = null)
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
                chunktranslationentry.Value.CreateDefaultData(chunktranslationentry.Key.Data.Copy(this));
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
            List<ICR2WExport> sourcechunks,
            IREDArray targetarray,
            Dictionary<ICR2WExport,
                (ICR2WExport oldchunkparent, ICR2WExport oldchunkvparent)> oldparentinghierarchy = null)
        {
            // First recursion to create the "empty" chunk descendent shells
            foreach (var sourcechunk in sourcechunks)
            {
                SourceChunk = sourcechunk;
                //Create the related chunk
                var newchunk = DestinationFile.CreateChunk(
                        sourcechunk.Data.REDType,
                        Cr2wHelper.GetLastChildrenIndexRecursive(DestinationChunk) + 1);

                if (!chunkTranslation.ContainsKey(sourcechunk))
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
                var copy = chunktranslationentry.Key.Data.Copy(this);
                chunktranslationentry.Value.CreateDefaultData(copy);

                //TODO: no CComponent in cp77
                // Corner cases :
                // - add descending CNewNPC components
                //if (targetarray.REDName == "Components" &&
                //    DestinationFile.Chunks[targetarray.LookUpChunkIndex()].REDType == "CNewNPC" &&
                //    copy is CComponent &&
                //    !sourcechunks.Contains(chunktranslationentry.Key))
                //{
                //    var uppercopy = CR2WTypeManager.Create("ptr:CComponent", chunktranslationentry.Value.REDName, DestinationFile, (targetarray as CVariable));
                //    (uppercopy as IREDChunkPtr).Reference = chunktranslationentry.Value;
                //    targetarray.AddVariable(uppercopy);
                //}
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
        public ICR2WExport TryLookupReference(ICR2WExport oldExportWrapper, IEditableVariable targetVariable = null)
        {
            //var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

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
            ICR2WExport parent = DestinationChunk;
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
            if (targetVariable != null)
            {
                vardepstring = targetVariable.UniqueIdentifier;
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
                //logger.LogString($"More than one chunk target found, please set pointer target manually in {(targetVariable != null ? vardepstring : chunkdepstring)}", Logtype.Error);
                return null;
            }
            else
            {
                //logger.LogString($"No chunk target found, please set pointer target manually in {(targetVariable != null ? vardepstring : chunkdepstring)}", Logtype.Error);
                return null;
            }
        }

        /// <summary>
        /// Recursive function used both by paste-in-place and paste-insert.
        /// </summary>
        /// <param name="sourcechunk"></param>
        /// <param name="destinationchunk"></param>
        /// <param name="inplace"></param>
        private void DeepChunkCopy(ICR2WExport sourcechunk, ICR2WExport destinationchunk, bool inplace = true)
        {
            Parent = null;
            foreach (var sourcevirtualchildchunk in sourcechunk.VirtualChildrenChunks)
            {
                var newchunk = DestinationFile.CreateChunk(
                    sourcevirtualchildchunk.Data.REDType,
                    inplace ? destinationchunk.ChunkIndex + sourcevirtualchildchunk.ChunkIndex - SourceChunk.ChunkIndex
                            : Cr2wHelper.GetLastChildrenIndexRecursive(destinationchunk) + 1);

                if (!chunkTranslation.ContainsKey(sourcevirtualchildchunk))
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

        #endregion Methods
    }
}
