using System;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.ViewModels.Documents
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
