using System;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Documents;

public partial class ScriptDocumentViewModel : DocumentViewModel
{
    public ScriptDocumentViewModel(string path) : base(path)
    {
        _extension = "reds";
    }

    [ObservableProperty] private string _extension;

    [ObservableProperty] private bool _isReadOnly;

    [ObservableProperty] private string? _isReadOnlyReason;

    //public override bool OpenFile(string path)
    //{
    //    _isInitialized = false;

    //    LoadDocument(path);

    //    ContentId = path;
    //    FilePath = path;
    //    _isInitialized = true;

    //    return true;
    //}

    //public override Task<bool> OpenFileAsync(string path)
    //{
    //    _isInitialized = false;

    //    LoadDocument(path);

    //    ContentId = path;
    //    FilePath = path;
    //    _isInitialized = true;

    //    return Task.FromResult(true);
    //}

    private void LoadDocument(string paramFilePath)
    {
        if (!File.Exists(paramFilePath))
        {
            return;
        }

        // Check file attributes and set to read-only if file attributes indicate that
        if ((File.GetAttributes(paramFilePath) & FileAttributes.ReadOnly) != 0)
        {
            IsReadOnly = true;
            IsReadOnlyReason = "This file cannot be edit because another process is currently writting to it.\n" +
                               "Change the file access permissions or save the file in a different location if you want to edit it.";
        }

        FilePath = paramFilePath;
    }

    public override Task Save(object parameter) => throw new NotImplementedException();
    public override void SaveAs(object parameter) => throw new NotImplementedException();
    public override bool Reload(bool parameter) => throw new NotImplementedException();
}
