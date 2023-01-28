using System;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
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

        private string GetHeader() =>  Path.GetFileName(ContentId) + (IsDirty ? "*" : "");


        [RelayCommand]
        public abstract Task Save(object parameter);

        [RelayCommand]
        public abstract void SaveAs(object parameter);


        #endregion methods


    }
}
