using System;
using System.ComponentModel;
using WolvenKit.Common;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
    /// Represents a viewmodel
    /// </summary>
    public interface Old_IDocumentViewModel/* : INotifyPropertyChanged, INotifyPropertyChanging*/
    {
        string FileName { get; }

        void SaveFile();
        
        event EventHandler<FileSavedEventArgs> OnFileSaved;


        object SaveTarget { get; set; }
        string Title { get; }

        void Close();
    }
}
