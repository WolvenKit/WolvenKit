using System;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Docking;

namespace WolvenKit.App.ViewModels.Documents;

public class SaveAsParameters(object originalObject, string absoluteFilePath, bool skipOnSaveHook = false)
{
    public object OriginalObject { get; set; } = originalObject;
    public string AbsoluteFilePath { get; set; } = absoluteFilePath;
    public bool SkipOnSaveHook { get; set; } = skipOnSaveHook;
}

public interface IDocumentViewModel : IDockElement
{
    /// <summary>
    /// Gets the current path of the file being managed in this document viewmodel.
    /// </summary>
    string? FilePath { get; set; }
    bool IsReadOnly { get; set; }

    public bool IsDirty { get; }
    
    DateTime LastWriteTime { get; }

    IAsyncRelayCommand<object> SaveCommand { get; }
    IRelayCommand<SaveAsParameters> SaveAsCommand { get; }
    
    //public ICommand Close { get; set; }

    string ContentId { get; }

    bool IsInitialized();
    bool Reload(bool force);
}
