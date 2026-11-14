using System;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Shell;

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

        OpenedAt = DateTime.Now;
    }

    [ObservableProperty] private string _filePath;
    [ObservableProperty] private bool _isReadOnly;
    [ObservableProperty] private bool _showToolbar;

    public DateTime OpenedAt { get; init; }

    private bool _isDirty;

    public bool IsDirty
    {
        get => _isDirty;
        protected set => SetProperty(ref _isDirty, value);
    }

    public bool IsInitialized() => _isInitialized;

    /// <summary>
    /// Raised on every <see cref="SetIsDirty"/>(true), i.e. after each edit; <see cref="IsDirty"/>
    /// itself only changes on the first one. Lets views of the document follow the edits
    /// (the mesh preview updates its materials).
    /// </summary>
    public event EventHandler? ContentModified;

    /// <summary>
    /// Counts the edits (<see cref="SetIsDirty"/>(true) calls), so a view that stopped following
    /// <see cref="ContentModified"/> can tell later whether the document changed meanwhile.
    /// </summary>
    public int ContentVersion { get; private set; }

    public void SetIsDirty(bool b)
    {
        IsDirty = b;
        Header = GetHeader();
        if (b)
        {
            ContentVersion++;
            ContentModified?.Invoke(this, EventArgs.Empty);
        }
    }

    public DateTime LastWriteTime { get; protected set; } = DateTime.MaxValue;

    private string GetHeader() => Path.GetFileName(ContentId) + (IsDirty ? "*" : "");


    [RelayCommand]
    public abstract Task Save(object parameter);

    [RelayCommand]
    protected abstract void SaveAs(SaveAsParameters saveParams);
        
    public abstract bool Reload(bool force);


}
