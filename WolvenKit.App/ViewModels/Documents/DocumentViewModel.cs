using System;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;

namespace WolvenKit.App.ViewModels.Documents;

public abstract partial class DocumentViewModel : PaneViewModel, IDocumentViewModel
{
    protected bool _isInitialized;

    public DocumentViewModel(string path) : base(Path.GetFileName(path), path)
    {
        _filePath = path;

        State = DockState.Document;
        SideInDockedMode = DockSide.Tabbed;
        CanSerialize = false;

        if (File.Exists(path))
        {
            LastWriteTime = File.GetLastWriteTime(path);
        }
    }

    [ObservableProperty] private string _filePath;
    [ObservableProperty] private bool _isReadOnly;
    [ObservableProperty] private bool _showToolbar;

    private bool _isDirty;

    public bool IsDirty
    {
        get => _isDirty;
        protected set => SetProperty(ref _isDirty, value);
    }

    [ObservableProperty] private EditorDifficultyLevel _editorDifficultyLevel;

    public bool IsInitialized() => _isInitialized;

    public void SetIsDirty(bool b)
    {
        IsDirty = b;
        Header = GetHeader();
    }

    public DateTime LastWriteTime { get; protected set; } = DateTime.MaxValue;

    private string GetHeader() => Path.GetFileName(ContentId) + (IsDirty ? "*" : "");


    [RelayCommand]
    public abstract Task Save(object parameter);

    [RelayCommand]
    public abstract void SaveAs(object parameter);


    public abstract bool Reload(bool force);
}
