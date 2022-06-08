using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Models.Docking;

namespace WolvenKit.App.ViewModels.Documents
{
    public interface IDocumentViewModel : IDockElement
    {
        #region Properties

        /// <summary>
        /// Gets the current path of the file being managed in this document viewmodel.
        /// </summary>
        string FilePath { get; set; }

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

        bool OpenFile(string path);

        #endregion Methods
    }
}
