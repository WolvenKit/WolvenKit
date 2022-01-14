using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentTabViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }
        public string Header { get; set; }
        public string FilePath { get; set; }

        [Reactive] public bool CanClose { get; set; }

        public RedDocumentTabViewModel()
        {

        }

    }
}
