using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentItemViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }

        [Reactive] public bool IsDirty { get; set; }

        public RedDocumentItemViewModel()
        {

        }
        
    }
}
