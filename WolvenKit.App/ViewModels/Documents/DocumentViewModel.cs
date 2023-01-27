using System;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models.Docking;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public abstract partial class DocumentViewModel : PaneViewModel, IDocumentViewModel
    {
        protected bool _isInitialized;


        public DocumentViewModel(string path) : base(Path.GetFileName(path), path)
        {
            _filePath = path;

            State = DockState.Document;
            SideInDockedMode = DockSide.Tabbed;

            Close = ReactiveCommand.Create(() => { });
        }

        #region commands

        private ICommand? _saveAsCommand = null;
        /// <summary>Gets a command to save this document's content into another file in the file system.</summary>
        public ICommand SaveAsCommand
        {
            get
            {
                _saveAsCommand ??= new DelegateCommand<object>(OnSaveAs, CanSaveAs);

                return _saveAsCommand;
            }
        }

        private ICommand? _saveCommand = null;

        /// <summary>Gets a command to save this document's content into the file system.</summary>
        public ICommand SaveCommand
        {
            get
            {
                _saveCommand ??= new DelegateCommand<object>((p) => OnSave(p), CanSave);

                return _saveCommand;
            }
        }

        public ReactiveCommand<Unit, Unit> Close { get; set; }

        #endregion commands

        #region Properties

        [ObservableProperty] private string _filePath;
        private bool _isDirty;

        public bool IsDirty
        {
            get => _isDirty;
            protected set => SetProperty(ref _isDirty, value);
        }

        #endregion Properties

        #region methods

        public bool IsInitialized() => _isInitialized;

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
        //public abstract Task<bool> OpenFileAsync(string path);

        // public abstract bool OpenFile(string path);

        private bool CanClose() => true;

        private bool CanSave(object parameter) => true/*IsDirty*/;

        private bool CanSaveAs(object parameter) => true/*IsDirty*/;

        public abstract Task OnSave(object parameter);

        private void OnSaveAs(object parameter) => throw new NotImplementedException();

        #endregion methods


    }
}
