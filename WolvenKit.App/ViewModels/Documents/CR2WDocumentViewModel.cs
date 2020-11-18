using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.App.ViewModels
{
    public class CR2WDocumentViewModel : CommonDocumentViewModel
    {
        public CR2WDocumentViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            //OpenChunkFormCommand = new DelegateCommand<IEnumerable<string>>(OpenChunkForm); ;

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

        public CR2WExportWrapper SelectedChunk => (SelectedChunks != null && SelectedChunks.Count > 0) 
                ? SelectedChunks.First() 
                : null;

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
            // Paste-in-place - 1-->1 - if only one variable was copied and that one variable is of the same type as the target variable
            // -------------------------------------------------------------------------------------------------------------------
            if (CopyController.Source.Count == 1 && ctarget.GetType().IsSubclassOf(csource.GetType()))
            {
                //Remember the old parenting hierarchy
                var oldparentinghierarchy = new Dictionary<CR2WExportWrapper, (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)>();
                foreach (var achunk in ctarget.cr2w.Chunks)
                {
                    oldparentinghierarchy.Add(achunk, (achunk.ParentChunk, achunk.VirtualParentChunk));
                }

                var context = new CR2WCopyAction();

                if (ctarget.ParentVar == null) // if we are in a "pure chunk" paste - no parent variable
                {
                    var sourcechunk = csource.cr2w.Chunks[csource.LookUpChunkIndex()];
                    var targetchunk = ctarget.cr2w.Chunks[ctarget.LookUpChunkIndex()];

                    context = new CR2WCopyAction()
                    {
                        SourceChunk = sourcechunk,
                        SourceFile = csource.cr2w,
                        DestinationChunk = targetchunk,
                        DestinationFile = ctarget.cr2w
                    };

                    // remove all virtual children chunks
                    ctarget.cr2w.RemoveChunks(
                    new List<CR2WExportWrapper>() { targetchunk },
                    true,
                    CR2WFile.EChunkDisplayMode.VirtualParent);

                    // copy-paste recursively children chunks
                    context.AddChildrenChunks(sourcechunk, targetchunk, oldparentinghierarchy);
                }
                // if we are pasting a non-chunk variable, a pointer in an array,
                // we don't want to delete all children of the chunk.
                else if (ctarget is IChunkPtrAccessor ctargetptr)
                {
                    context = new CR2WCopyAction()
                    {
                        SourceChunk = (csource as IChunkPtrAccessor).Reference,
                        SourceFile = csource.cr2w,
                        DestinationChunk = ctargetptr.Reference,
                        DestinationFile = ctarget.cr2w
                    };

                    // remove all virtual children chunks of the reference
                    ctarget.cr2w.RemoveChunks(
                    new List<CR2WExportWrapper>() { ctargetptr.Reference },
                    true,
                    CR2WFile.EChunkDisplayMode.VirtualParent,
                    true);

                    // copy-paste recursively children chunks
                    context.AddChildrenChunks((csource as IChunkPtrAccessor).Reference, ctargetptr.Reference, oldparentinghierarchy);

                    var refcopy = (csource as IChunkPtrAccessor).Reference.data.Copy(context);
                    ctargetptr.Reference.data.SetValue(refcopy);
                    ctargetptr.Reference.data.IsSerialized = true; // why repeat?

                    foreach (var chunktranslationentry in context.chunkTranslation)
                    {
                        // Corner cases :
                        // - add descending CNewNPC components
                        if (ctargetptr.ParentVar.REDName == "Components" &&
                            context.DestinationFile.Chunks[ctargetptr.ParentVar.LookUpChunkIndex()].REDType == "CNewNPC" &&
                            chunktranslationentry.Value.data is CComponent &&
                            context.SourceChunk != chunktranslationentry.Key)
                        {
                            var uppercopy = CR2WTypeManager.Create("ptr:CComponent", chunktranslationentry.Value.REDName, context.DestinationFile, (ctargetptr.ParentVar as CVariable));
                            (uppercopy as IChunkPtrAccessor).Reference = chunktranslationentry.Value;
                            ctargetptr.ParentVar.AddVariable(uppercopy);
                        }
                    }
                }
                else
                {
                    context = new CR2WCopyAction()
                    {
                        SourceFile = csource.cr2w,
                        DestinationFile = ctarget.cr2w
                    };
                }

                var copy = csource.Copy(context);
                ctarget.SetValue(copy);
                ctarget.IsSerialized = true; // why repeat?

                OnPropertyChanged(nameof(File));
            }

            // -------------------------------------------------------------------------------------------------------------------
            // Paste-insert - n-->1 - check if the target is an array and the elementtype is of the same type as the selected nodes
            // -------------------------------------------------------------------------------------------------------------------
            else if (ctarget is IArrayAccessor targetarray && targetarray.Elementtype == first.REDType)
            {
                if (!targetarray.CanAddVariable(null)) return;

                var targetarraychunk = targetarray.cr2w.Chunks[targetarray.LookUpChunkIndex()];

                //Remember the old parenting hierarchy
                var oldparentinghierarchy = new Dictionary<CR2WExportWrapper, (CR2WExportWrapper oldchunkparent, CR2WExportWrapper oldchunkvparent)>();
                foreach (var achunk in targetarray.cr2w.Chunks)
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

                // Add new pointers to the array and reparent them
                foreach (var sourceelement in CopyController.Source)
                {
                    var copy = sourceelement.Copy(context);
                    copy.IsSerialized = true;
                    copy.ParentVar = targetarray as IEditableVariable;
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
                        // save embedded files inside the embedded file if any
                        model.SaveFile();

                        model.File.Write(writer);

                        bytearray.SetValue(mem.ToArray());
                    }
                }
            }
            base.SaveFile();
        }

        /// <summary>
        /// Adds a new chunk for variables implementing IPtrAccessor or IHandleAccessor
        /// </summary>
        /// <param name="newvar"></param>
        public void AddNewChunkFor(IChunkPtrAccessor newvar)
        {
            switch (newvar)
            {
                case IPtrAccessor ptr:
                    {
                        string newChunktype = "";
                        string innerParentType = ptr.ReferenceType /*parentarray.Elementtype.Substring("ptr:".Length)*/;

                        List<string> availableTypes = CR2WManager.GetAvailableTypes(innerParentType).Select(_ => _.Name).ToList();
                        if (availableTypes.Count <= 0)
                        {
                            return;
                        }
                        else if (availableTypes.Count == 1)
                        {
                            newChunktype = availableTypes.First();
                        }
                        else
                        {
                            newChunktype = m_windowFactory.ShowAddChunkFormModal(availableTypes);
                        }

                        if (string.IsNullOrEmpty(newChunktype))
                            return;

                        var cr2w = /*viewModel.*/File as CR2WFile;
                        ptr.Reference = cr2w.CreateChunk(
                            newChunktype,
                            cr2w.GetLastChildrenIndexRecursive(cr2w.Chunks[ptr.LookUpChunkIndex()]) + 1,
                            SelectedChunk,
                            SelectedChunk,
                            (CVariable)newvar);
                        ptr.IsSerialized = true;

                        OnPropertyChanged(nameof(File));
                        //RequestChunkViewUpdate?.Invoke(null, null);
                        break;
                    }
                case IHandleAccessor handle:
                    {
                        bool isChunkHandle = true;

                        // check parent if the handle is a chunkhandle
                        if (newvar.ParentVar is IArrayAccessor parentarray && parentarray.Count > 0
                                                                           && parentarray is IList il && il[0] is IHandleAccessor ih)
                        {
                            isChunkHandle = ih.ChunkHandle;
                        }
                        else
                        {
                            //// ask the user?
                            //switch (MessageBox.Show(
                            //    "Please select Yes if this a CHandle to an existing chunk, or No if it is a CHandle to an external source.",
                            //    "New CHandle",
                            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            //{
                            //    case DialogResult.No:
                            //        {
                            //            isChunkHandle = false;
                            //            break;
                            //        }
                            //}
                        }

                        // it is a chunk handle, so create a new chunk
                        if (isChunkHandle)
                        {
                            string newhandletype = "";
                            string innerParentType = handle.ReferenceType /*parentarray.Elementtype.Substring("handle:".Length)*/;

                            List<string> availableTypes = CR2WManager.GetAvailableTypes(innerParentType).Select(_ => _.Name).ToList();
                            if (availableTypes.Count <= 0)
                            {
                                return;
                            }
                            else if (availableTypes.Count == 1)
                            {
                                newhandletype = availableTypes.First();
                            }
                            else
                            {
                                newhandletype = m_windowFactory.ShowAddChunkFormModal(availableTypes);
                            }


                            if (string.IsNullOrEmpty(newhandletype))
                                return;

                            handle.ChunkHandle = true;
                            var cr2w = /*viewModel.*/File as CR2WFile;
                            handle.Reference = cr2w.CreateChunk(
                                newhandletype,
                                cr2w.GetLastChildrenIndexRecursive(cr2w.Chunks[handle.LookUpChunkIndex()]) + 1,
                                SelectedChunk,
                                SelectedChunk,
                                (CVariable)newvar);
                            handle.IsSerialized = true;
                        }

                        OnPropertyChanged(nameof(File));
                        //RequestChunkViewUpdate?.Invoke(null, null);
                        break;
                    }
            }
        }

        public void AddListElement(IEditableVariable editableVariable)
        {
            if (editableVariable == null || !editableVariable.CanAddVariable(null) || !(editableVariable is IArrayAccessor parentarray))
                return;

            // Create new CVariable
            var newvar = CR2WTypeManager.Create(parentarray.Elementtype, "", SelectedChunk.cr2w,
                editableVariable as CVariable, false);
            if (newvar == null)
                return;

            if (newvar is IVariantAccessor ivar)
            {
                var availableTypes = CR2WManager.GetAvailableTypes("CObject").Select(_ => _.Name);
                var variantType = m_windowFactory.ShowAddChunkFormModal(availableTypes);

                var variant = CR2WTypeManager.Create(variantType, "Variant", newvar.cr2w, newvar);
                variant.IsSerialized = true;
                ivar.Variant = variant;
            }

            if (newvar is IChunkPtrAccessor chunkptr)
                AddNewChunkFor(chunkptr);

            newvar.IsSerialized = true;

            parentarray.AddVariable(newvar);
            parentarray.IsSerialized = true;

            OnPropertyChanged(nameof(SelectedChunks));
            //UpdateTreeListView();
        }
    }
}
