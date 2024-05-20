using System;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Docking;

namespace WolvenKit.App.ViewModels.Documents;

public interface IDocumentViewModel : IDockElement
{
    /// <summary>
    /// Gets the current path of the file being managed in this document viewmodel.
    /// </summary>
    string FilePath { get; set; }
    bool IsReadOnly { get; set; }

    public bool IsDirty
    {
        get;
        protected set;
    }
    
    DateTime LastWriteTime { get; }

    IAsyncRelayCommand<object> SaveCommand { get; }
    IRelayCommand<object> SaveAsCommand { get; }
    
    //public ICommand Close { get; set; }

    string ContentId { get; }

    bool IsInitialized();
    bool Reload(bool force);
}
