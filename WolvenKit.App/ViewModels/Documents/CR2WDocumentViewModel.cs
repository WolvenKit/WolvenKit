using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.App.ViewModels
{
    public class CR2WDocumentViewModel : CommonDocumentViewModel
    {
        public CR2WDocumentViewModel()
        {
            chunkDisplayMode = EChunkDisplayMode.VirtualParent;

            CopyVariableCommand = new RelayCommand(CopyVariable, CanCopyVariable);
            PasteVariableCommand = new RelayCommand(PasteVariable, CanPasteVariable);

            _openEmbedded =new Dictionary<string, CR2WDocumentViewModel>();
        }

        #region Fields
        public enum EChunkDisplayMode
        {
            Linear,
            Parent,
            VirtualParent
        }
        public EChunkDisplayMode chunkDisplayMode;

        #endregion

        #region Properties

        #region OpenEmbedded
        private Dictionary<string, CR2WDocumentViewModel> _openEmbedded;
        public Dictionary<string, CR2WDocumentViewModel> OpenEmbedded
        {
            get => _openEmbedded;
            set
            {
                if (_openEmbedded != value)
                {
                    _openEmbedded = value;
                    OnPropertyChanged();
                }
            }
        }

        public void RemoveEmbedded(object sender, EventArgs e, CR2WDocumentViewModel embVM)
        {
            string embkey = embVM.FileName;
            if (!OpenEmbedded.ContainsKey(embkey))
                throw new NullReferenceException();
            OpenEmbedded.Remove(embkey);
        }
        #endregion
        #region SelectedChunk
        private List<CR2WExportWrapper> _selectedChunks;
        public List<CR2WExportWrapper> SelectedChunks
        {
            get => _selectedChunks;
            set
            {
                if(_selectedChunks != value)
                {
                    _selectedChunks = value;
                    // update the property list only if out of multi-selection
                    if(_selectedChunks.Count() == 1)
                    {
                        OnPropertyChanged();
                    }
                }
            }
        }
        #endregion
        #endregion

        

        #region Commands
        public ICommand CopyVariableCommand { get; }
        public ICommand PasteVariableCommand { get; }

        #endregion

        #region Commands Implementation
        protected bool CanCopyVariable() => true;

        protected bool CanPasteVariable() => CopyController.Source != null && CopyController.Target != null;

        private void CopyVariable()
        {
            

        }

        /// <summary>
        /// Paste-in-place = replace = overwrite, or paste-insert
        /// </summary>
        private void PasteVariable()
        {
            if (CopyController.Source == null || CopyController.Target == null) return;
            if (!(CopyController.Target is CVariable ctarget)) return; 

            var first = CopyController.Source.FirstOrDefault();
            var areOfTheSameType = (first != null) && CopyController.Source.All(_ => _ is CVariable)
                                                   && CopyController.Source.All(p => p.REDType == first.REDType);
            // all copied files are CVariables
            if (!areOfTheSameType || !(CopyController.Source.First() is CVariable csource)) return;


            // -------------------------------------------------------------------------------------------------------------------
            // Paste-in-place - if only one variable was copied and that one variable is of the same type as the selected variable
            // -------------------------------------------------------------------------------------------------------------------
            if (CopyController.Source.Count == 1 && ctarget.GetType() == csource.GetType())
            {
                var sourcechunk = csource.cr2w.chunks[csource.LookUpChunkIndex()];
                var targetchunk = ctarget.cr2w.chunks[ctarget.LookUpChunkIndex()];

                var context = new CR2WCopyAction()
                {
                    SourceChunk = sourcechunk,
                    SourceFile = csource.cr2w,
                    DestinationChunk = targetchunk,
                    DestinationFile = ctarget.cr2w
                };

                //Remember the old parenting hierarchy
                var oldparentinghierarchy = new Dictionary<CR2WExportWrapper, (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)>();
                foreach (var achunk in context.DestinationFile.chunks)
                {
                    oldparentinghierarchy.Add(achunk, (achunk.ParentChunk, achunk.VirtualParentChunk));
                }

                // remove children chunks
                ctarget.cr2w.RemoveChunks(
                    new List<CR2WExportWrapper>() { targetchunk },
                    true,
                    (CR2WFile.EChunkDisplayMode)chunkDisplayMode);
                // copy-paste recursively children chunks
                context.AddChildrenChunks(sourcechunk, targetchunk, oldparentinghierarchy);

                var copy = csource.Copy(context);
                ctarget.SetValue(copy);
                ctarget.IsSerialized = true; // why repeat?

                OnPropertyChanged(nameof(File));
            }

            // -------------------------------------------------------------------------------------------------------------------
            // Paste-insert - check if the target is an array and the elementtype is of the same type as the selected nodes
            // -------------------------------------------------------------------------------------------------------------------
            else if (ctarget is IArrayAccessor targetarray && targetarray.Elementtype == first.REDType)
            {
                if (!targetarray.CanAddVariable(null)) return;

                var targetarraychunk = targetarray.cr2w.chunks[targetarray.LookUpChunkIndex()];

                //Remember the old parenting hierarchy
                var oldparentinghierarchy = new Dictionary<CR2WExportWrapper, (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)>();
                foreach (var achunk in targetarray.cr2w.chunks)
                {
                    oldparentinghierarchy.Add(achunk, (achunk.ParentChunk, achunk.VirtualParentChunk));
                }

                // Copy-paste
                var context = new CR2WCopyAction()
                {
                    SourceFile = csource.cr2w,
                    DestinationFile = targetarray.cr2w,
                    DestinationChunk = targetarraychunk,
                    Parent = targetarray.ParentVar as CVariable
                };

                if (first is IChunkPtrAccessor && CopyController.Source.Cast<IChunkPtrAccessor>().All(_=>_.Reference != null))
                {
                    context.PasteChunksInArray(
                        CopyController.Source.Cast<IChunkPtrAccessor>().Select(_=>_.Reference).ToList(),
                        targetarray,
                        oldparentinghierarchy);
                }

                foreach (var sourceelement in CopyController.Source)
                {
                    var copy = sourceelement.Copy(context);
                    copy.IsSerialized = true;
                    targetarray.AddVariable(copy);
                }


                OnPropertyChanged(nameof(File));
            }
        }
        #endregion

        public override void SaveFile()
        {
            // save all open embedded files
            // TODO: save them inside their viewmodels?
            foreach (CR2WDocumentViewModel model in OpenEmbedded.Values)
            {
                if (model.SaveTarget is CR2WEmbeddedWrapper embedded)
                {
                    embedded?.SetRawEmbeddedData(model.GetRawBytes());
                }
                else if (model.SaveTarget is CVariable bytearray)
                {
                    using (var mem = new MemoryStream())
                    using (var writer = new BinaryWriter(mem))
                    {
                        model.File.Write(writer);

                        //OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = mem, File = File });
                        bytearray.SetValue(mem.ToArray());
                    }
                    
                    //model.SaveFile();
                }
            }

            base.SaveFile();
        }


        
    }
}
