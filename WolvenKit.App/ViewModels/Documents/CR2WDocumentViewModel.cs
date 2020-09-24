using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
    public class CR2WDocumentViewModel : CommonDocumentViewModel
    {
        public CR2WDocumentViewModel()
        {
            CopyVariableCommand = new RelayCommand(CopyVariable, CanCopyVariable);
            PasteVariableCommand = new RelayCommand(PasteVariable, CanPasteVariable);

            _openEmbedded =new Dictionary<string, CR2WDocumentViewModel>();
        }

        #region Fields

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
        private CR2WExportWrapper _selectedChunk;
        public CR2WExportWrapper SelectedChunk
        {
            get => _selectedChunk;
            set
            {
                _selectedChunk = value;
                OnPropertyChanged();
                
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

        private void PasteVariable()
        {
            if (CopyController.Source == null || CopyController.Target == null) return;
            if (!(CopyController.Target is CVariable ctarget)) return; 

            var first = CopyController.Source.FirstOrDefault();
            var areOfTheSameType = (first != null) && CopyController.Source.All(_ => _ is CVariable)
                                                   && CopyController.Source.All(p => p.REDType == first.REDType);
            // all copied files are CVariables
            if (!areOfTheSameType || !(CopyController.Source.First() is CVariable csource)) return;


            // if only one variable was copied and that one variable is of the same type as the selected variable
            if (CopyController.Source.Count == 1 && ctarget.GetType() == csource.GetType())
            {
                var context = new CR2WCopyAction()
                {
                    DestinationFile = ctarget.cr2w,
                    Parent = ctarget.ParentVar as CVariable
                };

                var copy = csource.Copy(context);
                ctarget.SetValue(copy);
                ctarget.IsSerialized = true;

                OnPropertyChanged(nameof(SelectedChunk));
            }

            // check if the target is an array and the elementtype is of the same type as the selected nodes
            if (ctarget is IArrayAccessor targetarray && targetarray.Elementtype == first.REDType)
            {
                if (!targetarray.CanAddVariable(null)) return;
                // disable pasting pointers for now
                if (first is IChunkPtrAccessor) return;

                foreach (var sourceelement in CopyController.Source)
                {
                    var context = new CR2WCopyAction()
                    {
                        DestinationFile = targetarray.cr2w,
                        Parent = targetarray.ParentVar as CVariable
                    };

                    var copy = sourceelement.Copy(context);
                    copy.IsSerialized = true;

                    targetarray.AddVariable(copy);
                }

                OnPropertyChanged(nameof(SelectedChunk));
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
