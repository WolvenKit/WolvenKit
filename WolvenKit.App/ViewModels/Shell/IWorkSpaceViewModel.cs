using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WolvenKit.ViewModels.Editor.Basic;
using WolvenKit.Models;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.ViewModels.Shell
{
    /// <summary>
    /// Defines the interface to the <see cref="WorkSpaceViewModel"/> which implements
    /// AvalonDock demo specific properties, events and methods.
    /// </summary>
    public interface IWorkSpaceViewModel
    {
        #region Events

        /// <summary>Event is raised when AvalonDock (or the user) selects a new document.</summary>
        event EventHandler ActiveDocumentChanged;

        #endregion Events

        #region Properties

        /// <summary>Gets/sets the currently active document.</summary>
        DocumentViewModel ActiveDocument { get; set; }

        /// <summary>Gets an enumeration of all currently available document viewmodels.</summary>
        ObservableCollection<DocumentViewModel> Files { get; }

        /// <summary>Gets an enumeration of all currently available tool window viewmodels.</summary>
        ObservableCollection<ToolViewModel> Tools { get; }

        #endregion Properties

        #region methods

        /// <summary>
        /// Add a new document viewmodel into the collection of files.
        /// </summary>
        /// <param name="fileToAdd"></param>
        void AddFile(DocumentViewModel fileToAdd);

        /// <summary>
        /// Checks if a document can be closed and asks the user whether
        /// to save before closing if the document appears to be dirty.
        /// </summary>
        /// <param name="fileToClose"></param>
        void Close(DocumentViewModel fileToClose);

        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        void CloseAllDocuments();

        /// <summary>
        /// Open a file and return its content in a viewmodel.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        Task<DocumentViewModel> OpenAsync(FileViewModel model);

        /// <summary>
        /// Saves a document and resets the dirty flag.
        /// </summary>
        /// <param name="fileToSave"></param>
        /// <param name="saveAsFlag"></param>
        void Save(DocumentViewModel fileToSave, bool saveAsFlag = false);

        #endregion methods
    }
}
