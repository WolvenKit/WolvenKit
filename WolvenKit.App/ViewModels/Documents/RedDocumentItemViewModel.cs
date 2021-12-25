using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentItemViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }
        public string Header { get; set; }

        public RedDocumentItemViewModel()
        {

        }
        
    }
}
