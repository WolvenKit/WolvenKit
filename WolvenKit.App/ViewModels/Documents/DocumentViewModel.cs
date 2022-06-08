using System;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Commands.Base;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Documents
{
    public abstract class DocumentViewModel : PaneViewModel, IDocumentViewModel
    {
        #region fields

        protected bool _isInitialized;

        #endregion fields

        #region ctors

        public DocumentViewModel(string path) : this()
        {
            Header = Path.GetFileName(path);
            ContentId = path;
        }

        private DocumentViewModel()
        {
            State = DockState.Document;
            SideInDockedMode = DockSide.Tabbed;

            Close = ReactiveCommand.Create(() => { });
        }

        #endregion ctors

        #region commands

        private ICommand _saveAsCommand = null;
        /// <summary>Gets a command to save this document's content into another file in the file system.</summary>
        public ICommand SaveAsCommand
        {
            get
            {
                if (_saveAsCommand == null)
                {
                    _saveAsCommand = new DelegateCommand<object>((p) => OnSaveAs(p), (p) => CanSaveAs(p));
                }

                return _saveAsCommand;
            }
        }

        private ICommand _saveCommand = null;

        /// <summary>Gets a command to save this document's content into the file system.</summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new DelegateCommand<object>((p) => OnSave(p), (p) => CanSave(p));
                }

                return _saveCommand;
            }
        }

        public ReactiveCommand<Unit, Unit> Close { get; set; }

        #endregion commands

        #region Properties

        [Reactive] public string FilePath { get; set; }

        [Reactive] public bool IsDirty { get; protected set; }



        #endregion Properties

        #region methods

        public void SetIsDirty(bool b)
        {
            IsDirty = b;
            Header = GetHeader();
        }

        private string GetHeader() =>
            // not sure this is that useful
            //if (FilePath == null)
            //{
            //    return "Noname" + (IsDirty ? "*" : "");
            //}

            Path.GetFileName(ContentId) + (IsDirty ? "*" : "");


        /// <summary>
        /// Attempts to read the contents of a wolvenkit file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>True if file read was successful, otherwise false</returns>
        public abstract Task<bool> OpenFileAsync(string path);

        public abstract bool OpenFile(string path);

        private bool CanClose() => true;

        private bool CanSave(object parameter) => true/*IsDirty*/;

        private bool CanSaveAs(object parameter) => true/*IsDirty*/;

        public abstract Task OnSave(object parameter);

        private void OnSaveAs(object parameter) => throw new NotImplementedException();

        #endregion methods


    }
}
