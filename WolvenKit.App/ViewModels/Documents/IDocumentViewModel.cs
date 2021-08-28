using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.Models.Docking;

namespace WolvenKit.ViewModels.Documents
{
    public interface IDocumentViewModel : IDockElement
    {
        #region Properties

        /// <summary>
        /// Gets the current filename of the file being managed in this document viewmodel.
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// Gets the current path of the file being managed in this document viewmodel.
        /// </summary>
        string FilePath { get; }

  //      /// <summary>
		///// Gets/sets whether the documents content has been changed without saving into file system or not.
		///// </summary>
		//bool IsDirty { get; set; }

        /// <summary>
        /// Gets a command to save this document's content into another file in the file system.
        /// </summary>
        ICommand SaveAsCommand { get; }

        /// <summary>
        /// Gets a command to save this document's content into the file system.
        /// </summary>
        ICommand SaveCommand { get; }

        public ReactiveCommand<Unit, Unit> Close { get; set; }

        string ContentId { get; }

        #endregion Properties

        #region Methods

        Task<bool> OpenFileAsync(string path);
        void SetIsDirty(bool v);


        #endregion Methods
    }
}
