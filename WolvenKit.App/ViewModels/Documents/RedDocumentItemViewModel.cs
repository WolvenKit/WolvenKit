using ReactiveUI;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentItemViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }

        public RedDocumentItemViewModel()
        {
            


        }

        
    }
}
