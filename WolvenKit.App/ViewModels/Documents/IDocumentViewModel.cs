using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using WolvenKit.Models.Docking;

namespace WolvenKit.ViewModels.Documents
{
    public interface IDocumentViewModel : IDockElement
    {
        /// <summary>
        /// Gets the current path of the file being managed in this document viewmodel.
        /// </summary>
        string FilePath { get; set; }

       
        IAsyncRelayCommand<object> SaveCommand { get; }
        IRelayCommand<object> SaveAsCommand { get; }

        public ReactiveCommand<Unit, Unit> Close { get; set; }

        string ContentId { get; }

        bool IsInitialized();
    }
}
