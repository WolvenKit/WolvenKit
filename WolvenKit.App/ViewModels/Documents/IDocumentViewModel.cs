using System;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Docking;

namespace WolvenKit.App.ViewModels.Documents;

public class SaveAsParameters
{
    public object OriginalObject { get; set; }
    public string AbsoluteFilePath { get; set; }
    public bool SkipOnSaveHook { get; set; }

    public SaveAsParameters(object originalObject, string absoluteFilePath, bool skipOnSaveHook = false)
    {
        OriginalObject = originalObject;
        AbsoluteFilePath = absoluteFilePath;
        SkipOnSaveHook = skipOnSaveHook;
    }
}

public interface IDocumentViewModel : IDockElement
{
    /// <summary>
    /// Gets the current path of the file being managed in this document viewmodel.
    /// </summary>
    string? FilePath { get; set; }
    bool IsReadOnly { get; set; }

    public bool IsDirty
    {
        get;
    }
    
    DateTime LastWriteTime { get; }

    IAsyncRelayCommand<object> SaveCommand { get; }
    IRelayCommand<SaveAsParameters> SaveAsCommand { get; }
    
    //public ICommand Close { get; set; }

    string ContentId { get; }

    bool IsInitialized();
    bool Reload(bool force);
}
